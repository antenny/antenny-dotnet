# Antenny.API.SubscriptionApi

All URIs are relative to *https://api.antenny.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelSubscription**](SubscriptionApi.md#cancelsubscription) | **PATCH** /subscriptions/{subId} | Cancels a subscription
[**CreateSubscription**](SubscriptionApi.md#createsubscription) | **POST** /subscriptions | Creates a subscription
[**GetSubscription**](SubscriptionApi.md#getsubscription) | **GET** /subscriptions/{subId} | Gets a subscription
[**ListSubscriptions**](SubscriptionApi.md#listsubscriptions) | **GET** /customers/{custId}/subscriptions | Gets a list of subscriptions


<a name="cancelsubscription"></a>
# **CancelSubscription**
> void CancelSubscription (Guid subId, InlineObject inlineObject)

Cancels a subscription

Cancels a subscription for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class CancelSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new SubscriptionApi(config);
            var subId = new Guid(); // Guid | Subscription id
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // Cancels a subscription
                apiInstance.CancelSubscription(subId, inlineObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CancelSubscription: " + e.Message );
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
 **subId** | [**Guid**](Guid.md)| Subscription id | 
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscription"></a>
# **CreateSubscription**
> Subscription CreateSubscription (NewSubscription newSubscription)

Creates a subscription

Creates a new subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new SubscriptionApi(config);
            var newSubscription = new NewSubscription(); // NewSubscription | 

            try
            {
                // Creates a subscription
                Subscription result = apiInstance.CreateSubscription(newSubscription);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CreateSubscription: " + e.Message );
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
 **newSubscription** | [**NewSubscription**](NewSubscription.md)|  | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (Guid subId)

Gets a subscription

Gets a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new SubscriptionApi(config);
            var subId = new Guid(); // Guid | Subscription id

            try
            {
                // Gets a subscription
                Subscription result = apiInstance.GetSubscription(subId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscription: " + e.Message );
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
 **subId** | [**Guid**](Guid.md)| Subscription id | 

### Return type

[**Subscription**](Subscription.md)

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

<a name="listsubscriptions"></a>
# **ListSubscriptions**
> SubscriptionList ListSubscriptions (Guid custId, string sort = null, int? limit = null, string startKey = null)

Gets a list of subscriptions

Lists subscriptions for a customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class ListSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new SubscriptionApi(config);
            var custId = new Guid(); // Guid | Customer Id to get subscriptions
            var sort = sort_example;  // string | Defines sort direction (optional) 
            var limit = 56;  // int? | Limits the number of returned items (optional) 
            var startKey = startKey_example;  // string | Defines start of page of results (optional) 

            try
            {
                // Gets a list of subscriptions
                SubscriptionList result = apiInstance.ListSubscriptions(custId, sort, limit, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ListSubscriptions: " + e.Message );
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
 **custId** | [**Guid**](Guid.md)| Customer Id to get subscriptions | 
 **sort** | **string**| Defines sort direction | [optional] 
 **limit** | **int?**| Limits the number of returned items | [optional] 
 **startKey** | **string**| Defines start of page of results | [optional] 

### Return type

[**SubscriptionList**](SubscriptionList.md)

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

