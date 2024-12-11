using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace StarCi.CiFarmSDK
{
    public class ApiCaller
    {
        private readonly string _baseUrl = "https://6721b00d98bbb4d93ca948fe.mockapi.io/students";

        public ApiCaller()
        {
        }

        /// <summary>
        /// Call the Hello World API.
        /// </summary>
        /// <returns>A task containing the API response as a string.</returns>
        public async Task<string> CallHelloWorldApiAsync()
        {
            string endpoint = $"{_baseUrl}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Debug.Log($"API Response: {responseBody}");
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    Debug.LogError($"Error calling API: {e.Message}");
                    return null;
                }
            }
        }
    }
}
