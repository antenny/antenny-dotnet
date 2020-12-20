# Antenny.API.EventsApi

All URIs are relative to *https://api.antenny.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListEvents**](EventsApi.md#listevents) | **GET** /subscriptions/{subId}/events | Gets a list of events for a subscription


<a name="listevents"></a>
# **ListEvents**
> EventList ListEvents (Guid subId, string sort = null, string level = null, int? limit = null, string startKey = null)

Gets a list of events for a subscription

Lists events for a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Antenny.API;
using Antenny.Client;
using Antenny.Model;

namespace Example
{
    public class ListEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.antenny.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new EventsApi(config);
            var subId = new Guid(); // Guid | Subscription id
            var sort = sort_example;  // string | Defines sort direction (optional) 
            var level = level_example;  // string | Filters events by level (optional) 
            var limit = 56;  // int? | Limits the number of returned items (optional) 
            var startKey = startKey_example;  // string | Defines start of page of results (optional) 

            try
            {
                // Gets a list of events for a subscription
                EventList result = apiInstance.ListEvents(subId, sort, level, limit, startKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ListEvents: " + e.Message );
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
 **sort** | **string**| Defines sort direction | [optional] 
 **level** | **string**| Filters events by level | [optional] 
 **limit** | **int?**| Limits the number of returned items | [optional] 
 **startKey** | **string**| Defines start of page of results | [optional] 

### Return type

[**EventList**](EventList.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

