using StarCi.CiFarmSDK.Configs;
using StarCi.CiFarmSDK.Services.Rest;
using StarCi.CiFarmSDK.Types;
using StarCi.CiFarmSDK.Utils;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private RestGameplayService _restGameplayService;

    async void Start()
    {
        // Create an instance of IHttpClientService
        var httpClientService = new HttpClientService();

        httpClientService.ConfigureClient(BaseConfig.BaseUrl, headers =>
        {
            headers.Add("User-Agent", "StarCiClient");
            // Add other default headers if needed
        });

        // Initialize RestGameplayService with BaseConfig.BaseUrl
        _restGameplayService = new RestGameplayService(httpClientService);

        // Create a request object for the Hello World API
        var helloParams = new HelloParams
        {
            Email = null,
            Name = null
        };

        var response = await _restGameplayService.GetHelloWorld(helloParams);

        if (response != null && !string.IsNullOrEmpty(response.ToString()))
        {
            Debug.Log($"Hello World API Response: {response}");
        }
        else
        {
            Debug.LogError("Failed to call Hello World API or received an empty response.");
        }
    }

    void Update()
    {
    }
}
