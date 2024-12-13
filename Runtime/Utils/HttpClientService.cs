using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Unity.Plastic.Newtonsoft.Json;

namespace StarCi.CiFarmSDK.Utils
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        public void ConfigureClient(string baseUrl, Action<HttpRequestHeaders> configureHeaders)
        {
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Clear();

            configureHeaders?.Invoke(_httpClient.DefaultRequestHeaders);
        }

        public async Task<TResponse> GetAsync<TResponse>(string endpoint, Dictionary<string, object> queryParams)
        {
            try
            {
                // Serialize query parameters into a query string
                string queryString = StringUtils.SerializeQueryParams(queryParams);

                // Append query string to the endpoint
                string endpointWithQuery = string.IsNullOrEmpty(queryString) ? endpoint : $"{endpoint}?{queryString}";

                using var response = await _httpClient.GetAsync(endpointWithQuery);

                response.EnsureSuccessStatusCode();

                // Read response content
                var responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize response into TResponse type
                return JsonConvert.DeserializeObject<TResponse>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"HTTP GET to endpoint {endpoint} failed with message: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"An unexpected error occurred during GET request to {endpoint}: {ex.Message}", ex);
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(data);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using var response = await _httpClient.PostAsync(endpoint, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error making POST request to {endpoint}: {ex.Message}", ex);
            }
        }

    }
}
