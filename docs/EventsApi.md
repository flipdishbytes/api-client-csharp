# Flipdish.Api.EventsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCustomerEvents**](EventsApi.md#getcustomerevents) | **GET** /api/v1.0/{appId}/events/customer/{customerId} | 
[**GetEvents**](EventsApi.md#getevents) | **GET** /api/v1.0/{appId}/events | 
[**GetEventsById**](EventsApi.md#geteventsbyid) | **GET** /api/v1.0/{appId}/events/{eventId} | 
[**GetMenuEvents**](EventsApi.md#getmenuevents) | **GET** /api/v1.0/{appId}/events/menu/{menuId} | 
[**GetOrderEvents**](EventsApi.md#getorderevents) | **GET** /api/v1.0/{appId}/events/order/{orderId} | 
[**GetOrderEventsByCustomer**](EventsApi.md#getordereventsbycustomer) | **GET** /api/v1.0/{appId}/events/order | 
[**GetStoreEvents**](EventsApi.md#getstoreevents) | **GET** /api/v1.0/{appId}/events/store/{storeId} | 
[**GetUserEvents**](EventsApi.md#getuserevents) | **GET** /api/v1.0/{appId}/events/user/{userId} | 
[**GetWhiteLabelEvents**](EventsApi.md#getwhitelabelevents) | **GET** /api/v1.0/{appId}/events/whitelabel/{whitelabelId} | 


<a name="getcustomerevents"></a>
# **GetCustomerEvents**
> RestApiEventSearchPaginationResult GetCustomerEvents (string appId, int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCustomerEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var customerId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetCustomerEvents(appId, customerId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetCustomerEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **customerId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> RestApiEventSearchPaginationResult GetEvents (string appId, int? whiteLabelId = null, int? customerId = null, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var whiteLabelId = 56;  // int? |  (optional) 
            var customerId = 56;  // int? |  (optional) 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetEvents(appId, whiteLabelId, customerId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **whiteLabelId** | **int?**|  | [optional] 
 **customerId** | **int?**|  | [optional] 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsbyid"></a>
# **GetEventsById**
> EventSearchResult GetEventsById (Guid? eventId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var eventId = new Guid?(); // Guid? | 
            var appId = appId_example;  // string | 

            try
            {
                EventSearchResult result = apiInstance.GetEventsById(eventId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | [**Guid?**](Guid?.md)|  | 
 **appId** | **string**|  | 

### Return type

[**EventSearchResult**](EventSearchResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuevents"></a>
# **GetMenuEvents**
> RestApiEventSearchPaginationResult GetMenuEvents (string appId, int? menuId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId2 = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var menuId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId2 = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetMenuEvents(appId, menuId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId, menuId2, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetMenuEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **menuId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId2** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderevents"></a>
# **GetOrderEvents**
> RestApiEventSearchPaginationResult GetOrderEvents (string appId, int? orderId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId2 = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var orderId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId2 = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEvents(appId, orderId, limit, page, start, end, orderId2, storeId, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetOrderEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **orderId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId2** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordereventsbycustomer"></a>
# **GetOrderEventsByCustomer**
> RestApiEventSearchPaginationResult GetOrderEventsByCustomer (string appId, int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderEventsByCustomerExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var customerId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEventsByCustomer(appId, customerId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetOrderEventsByCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **customerId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreevents"></a>
# **GetStoreEvents**
> RestApiEventSearchPaginationResult GetStoreEvents (string appId, int? storeId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId2 = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId2 = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetStoreEvents(appId, storeId, limit, page, start, end, orderId, storeId2, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetStoreEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId2** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserevents"></a>
# **GetUserEvents**
> RestApiEventSearchPaginationResult GetUserEvents (string appId, int? userId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId2 = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var userId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId2 = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetUserEvents(appId, userId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId2, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetUserEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **userId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId2** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhitelabelevents"></a>
# **GetWhiteLabelEvents**
> RestApiEventSearchPaginationResult GetWhiteLabelEvents (string appId, int? whitelabelId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, List<int?> storeIdList = null, int? storeGroupId = null, int? userId = null, int? menuId = null, int? campaignId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWhiteLabelEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var appId = appId_example;  // string | 
            var whitelabelId = 56;  // int? | 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeIdList = new List<int?>(); // List<int?> | Events that have Store Id List (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var menuId = 56;  // int? | Events that have Menu Id (optional) 
            var campaignId = 56;  // int? | Events that have Campaign Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                RestApiEventSearchPaginationResult result = apiInstance.GetWhiteLabelEvents(appId, whitelabelId, limit, page, start, end, orderId, storeId, storeIdList, storeGroupId, userId, menuId, campaignId, userEmail, userName, voucherCode, eventType, flipdishEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetWhiteLabelEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **whitelabelId** | **int?**|  | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeIdList** | [**List&lt;int?&gt;**](int?.md)| Events that have Store Id List | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
 **menuId** | **int?**| Events that have Menu Id | [optional] 
 **campaignId** | **int?**| Events that have Campaign Id | [optional] 
 **userEmail** | **string**| Events that have User Email | [optional] 
 **userName** | **string**| Events that have User Name | [optional] 
 **voucherCode** | **string**| Events that have voucher code | [optional] 
 **eventType** | [**List&lt;string&gt;**](string.md)| Events that have event type\\s | [optional] 
 **flipdishEventId** | **string**| Unique Identifier of Event, if this is specified, all other criteria are ignored. | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

