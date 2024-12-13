using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StarCi.CiFarmSDK.Utils
{
    public interface IHttpClientService
    {
        /// <summary>
        /// Configure HttpClient with a base URL and default headers.
        /// </summary>
        /// <param name="baseUrl">Base URL for HttpClient.</param>
        /// <param name="configureHeaders">Action to configure headers.</param>
        void ConfigureClient(string baseUrl, Action<HttpRequestHeaders> configureHeaders);

        /// <summary>
        /// Send a GET request to the specified endpoint.
        /// </summary>
        /// <param name="endpoint">API endpoint.</param>
        /// <returns>Response content as a JSON string.</returns>
        Task<TResponse> GetAsync<TResponse>(string endpoint, Dictionary<string, object> queryParams);

        /// <summary>
        /// Send a POST request with JSON data to the specified endpoint.
        /// </summary>
        /// <typeparam name="TRequest">Request data type.</typeparam>
        /// <typeparam name="TResponse">Response data type.</typeparam>
        /// <param name="endpoint">API endpoint.</param>
        /// <param name="data">Request data to send.</param>
        /// <returns>Response deserialized into TResponse type.</returns>
        Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
    }
}
