using StarCi.CiFarmSDK.Configs;
using StarCi.CiFarmSDK.Types;
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
        /// <param name="helloParams">HelloParams object containing query params.</param>
        /// <returns>A task containing the HelloResponse object.</returns>
        public async Task<HelloResponse[]> GetHelloWorld(HelloParams helloParams)
        {
            try
            {
                Debug.Log("Calling Hello World API...");
                var response = await _httpClientService.GetAsync<HelloResponse[]>(
                    BaseConfig.EndpointHelloWorld, StringUtils.SerializeToDictionary(helloParams));

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

    }
}
