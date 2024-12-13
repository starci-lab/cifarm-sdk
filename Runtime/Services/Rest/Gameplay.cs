using StarCi.CiFarmSDK.Configs;
using StarCi.CiFarmSDK.Utils;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace StarCi.CiFarmSDK.Services.Rest
{
    public class RestGameplayService
    {
        private readonly IHttpClientService _httpClientService;

        public RestGameplayService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        /// <summary>
        /// Call the Hello World API.
        /// </summary>
        /// <param name="request">HelloRequest object containing request data.</param>
        /// <returns>A task containing the HelloResponse object.</returns>
        public async Task<HelloResponse[]> CallHelloWorldApiAsync(HelloRequest request)
        {
            try
            {
                Debug.Log("Calling Hello World API...");
                var response = await _httpClientService.GetAsync<HelloResponse[]>(
                    BaseConfig.EndpointHelloWorld, null);

                Debug.Log($"API Response: ");
                foreach (var item in response)
                {
                    Debug.Log($"Name: {item.Name} + Email: {item.Email}.");
                }
                return response;
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error calling Hello World API: {ex.Message}");
                return null;
            }
        }

        // DTOs for the Hello World API
        public class HelloRequest
        {
            public string Text { get; set; }
        }

        public class HelloResponse
        {
            public string Date { get; set; }
            public string Name { get; set; }
            public string Email { get; set; } = string.Empty;
            public string Gender { get; set; }
            public string Address { get; set; }
            public int IdMajor { get; set; }
            public string Id { get; set; }

        }
    }
}
