# Antenny.API.RegistrationApi

All URIs are relative to *https://api.antenny.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRegistration**](RegistrationApi.md#getregistration) | **GET** /customers/{custId}/registration | Gets a customers registration


<a name="getregistration"></a>
# **GetRegistration**
> Registration GetRegistration (Guid custId)

Gets a customers registration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class GetRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new RegistrationApi(config);
            var custId = new Guid(); // Guid | Customer Id for registration

            try
            {
                // Gets a customers registration
                Registration result = apiInstance.GetRegistration(custId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationApi.GetRegistration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **custId** | [**Guid**](Guid.md)| Customer Id for registration | 

### Return type

[**Registration**](Registration.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized operation |  -  |
| **403** | Forbidden operation |  -  |
| **404** | Registration not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

