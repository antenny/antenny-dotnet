# Antenny.API.ClientApi

All URIs are relative to *https://api.antenny.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClient**](ClientApi.md#createclient) | **POST** /clients | Creates a client
[**DeleteClient**](ClientApi.md#deleteclient) | **DELETE** /clients/{clientId} | Deletes a client
[**GetClient**](ClientApi.md#getclient) | **GET** /clients/{clientId} | Gets a client
[**ListClients**](ClientApi.md#listclients) | **GET** /customers/{custId}/clients | Gets a list of clients


<a name="createclient"></a>
# **CreateClient**
> ModelClient CreateClient (NewClient newClient)

Creates a client

Creates a new client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class CreateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var newClient = new NewClient(); // NewClient | 

            try
            {
                // Creates a client
                ModelClient result = apiInstance.CreateClient(newClient);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.CreateClient: " + e.Message );
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
 **newClient** | [**NewClient**](NewClient.md)|  | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (Guid clientId)

Deletes a client

Deletes a client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var clientId = new Guid(); // Guid | Client Id to get

            try
            {
                // Deletes a client
                apiInstance.DeleteClient(clientId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.DeleteClient: " + e.Message );
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
 **clientId** | [**Guid**](Guid.md)| Client Id to get | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful operation |  -  |
| **401** | Unauthorized operation |  -  |
| **403** | Forbidden operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclient"></a>
# **GetClient**
> ModelClient GetClient (Guid clientId)

Gets a client

Gets a client for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class GetClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var clientId = new Guid(); // Guid | Client Id to get

            try
            {
                // Gets a client
                ModelClient result = apiInstance.GetClient(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.GetClient: " + e.Message );
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
 **clientId** | [**Guid**](Guid.md)| Client Id to get | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Reqeuest |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listclients"></a>
# **ListClients**
> ClientList ListClients (Guid custId, string sort = null, int? limit = null, string startKey = null)

Gets a list of clients

List of clients for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class ListClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var custId = new Guid(); // Guid | Customer Id to get clients for
            var sort = sort_example;  // string | Defines sort direction (optional) 
            var limit = 56;  // int? | Limits the number of returned items (optional) 
            var startKey = startKey_example;  // string | Defines start of page of results (optional) 

            try
            {
                // Gets a list of clients
                ClientList result = apiInstance.ListClients(custId, sort, limit, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.ListClients: " + e.Message );
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
 **custId** | [**Guid**](Guid.md)| Customer Id to get clients for | 
 **sort** | **string**| Defines sort direction | [optional] 
 **limit** | **int?**| Limits the number of returned items | [optional] 
 **startKey** | **string**| Defines start of page of results | [optional] 

### Return type

[**ClientList**](ClientList.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

