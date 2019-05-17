# Flipdish.Api.EventsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCustomerEvents**](EventsApi.md#getcustomerevents) | **GET** /api/v1.0/events/customer/{customerId} | Get customer events  For technical reasons, the number of records returned is limited to 100.
[**GetEvents**](EventsApi.md#getevents) | **GET** /api/v1.0/events | Get events  For technical reasons, the number of records returned is limited to 100.
[**GetEventsById**](EventsApi.md#geteventsbyid) | **GET** /api/v1.0/events/{eventId} | Get event by Id  For technical reasons, the number of records returned is limited to 100.
[**GetMenuEvents**](EventsApi.md#getmenuevents) | **GET** /api/v1.0/events/menu/{menuId} | Get menu events  For technical reasons, the number of records returned is limited to 100.
[**GetOrderEvents**](EventsApi.md#getorderevents) | **GET** /api/v1.0/events/order/{orderId} | Get order events  For technical reasons, the number of records returned is limited to 100.
[**GetOrderEventsByCustomer**](EventsApi.md#getordereventsbycustomer) | **GET** /api/v1.0/events/order | Get order events by customer  For technical reasons, the number of records returned is limited to 100.
[**GetStoreEvents**](EventsApi.md#getstoreevents) | **GET** /api/v1.0/events/store/{storeId} | Get store events  For technical reasons, the number of records returned is limited to 100.
[**GetUserEvents**](EventsApi.md#getuserevents) | **GET** /api/v1.0/events/user/{userId} | Get user events  For technical reasons, the number of records returned is limited to 100.
[**GetWhiteLabelEvents**](EventsApi.md#getwhitelabelevents) | **GET** /api/v1.0/events/whitelabel/{whitelabelId} | Get WhiteLabel events  For technical reasons, the number of records returned is limited to 100.


<a name="getcustomerevents"></a>
# **GetCustomerEvents**
> RestApiEventSearchPaginationResult GetCustomerEvents (int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get customer events  For technical reasons, the number of records returned is limited to 100.

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
            var customerId = 56;  // int? | Customer identifier identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get customer events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetCustomerEvents(customerId, limit, page, start, end, orderId, storeId, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **customerId** | **int?**| Customer identifier identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetEvents (int? storeId = null, int? whiteLabelId = null, int? customerId = null, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId2 = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get events  For technical reasons, the number of records returned is limited to 100.

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
            var storeId = 56;  // int? | Store Id (optional) 
            var whiteLabelId = 56;  // int? | White Label Id (optional) 
            var customerId = 56;  // int? | Customer Id (optional) 
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId2 = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetEvents(storeId, whiteLabelId, customerId, limit, page, start, end, orderId, storeId2, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **storeId** | **int?**| Store Id | [optional] 
 **whiteLabelId** | **int?**| White Label Id | [optional] 
 **customerId** | **int?**| Customer Id | [optional] 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId2** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> EventSearchResult GetEventsById (Guid? eventId)

Get event by Id  For technical reasons, the number of records returned is limited to 100.

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
            var eventId = new Guid?(); // Guid? | Event identifier (Guid)

            try
            {
                // Get event by Id  For technical reasons, the number of records returned is limited to 100.
                EventSearchResult result = apiInstance.GetEventsById(eventId);
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
 **eventId** | [**Guid?**](Guid?.md)| Event identifier (Guid) | 

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
> RestApiEventSearchPaginationResult GetMenuEvents (int? menuId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get menu events  For technical reasons, the number of records returned is limited to 100.

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
            var menuId = 56;  // int? | Menu Identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get menu events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetMenuEvents(menuId, limit, page, start, end, orderId, storeId, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **menuId** | **int?**| Menu Identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetOrderEvents (int? orderId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId2 = null, int? storeId = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get order events  For technical reasons, the number of records returned is limited to 100.

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
            var orderId = 56;  // int? | Order identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId2 = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get order events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEvents(orderId, limit, page, start, end, orderId2, storeId, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **orderId** | **int?**| Order identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId2** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetOrderEventsByCustomer (int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get order events by customer  For technical reasons, the number of records returned is limited to 100.

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
            var customerId = 56;  // int? | Customer identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get order events by customer  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEventsByCustomer(customerId, limit, page, start, end, orderId, storeId, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **customerId** | **int?**| Customer identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetStoreEvents (int? storeId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId2 = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get store events  For technical reasons, the number of records returned is limited to 100.

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
            var storeId = 56;  // int? | Id of the store
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId2 = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get store events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetStoreEvents(storeId, limit, page, start, end, orderId, storeId2, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **storeId** | **int?**| Id of the store | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId2** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetUserEvents (int? userId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, int? storeGroupId = null, int? userId2 = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get user events  For technical reasons, the number of records returned is limited to 100.

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
            var userId = 56;  // int? | User identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId2 = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get user events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetUserEvents(userId, limit, page, start, end, orderId, storeId, storeGroupId, userId2, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **userId** | **int?**| User identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId2** | **int?**| Events that have User Id | [optional] 
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
> RestApiEventSearchPaginationResult GetWhiteLabelEvents (int? whitelabelId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, int? orderId = null, int? storeId = null, int? storeGroupId = null, int? userId = null, string userEmail = null, string userName = null, string voucherCode = null, List<string> eventType = null, string flipdishEventId = null)

Get WhiteLabel events  For technical reasons, the number of records returned is limited to 100.

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
            var whitelabelId = 56;  // int? | White Label Identifier
            var limit = 56;  // int? | The maximum elements to return (optional) 
            var page = 56;  // int? | The index of the page to return, starting by 1 (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 
            var orderId = 56;  // int? | Events that have Order Id (optional) 
            var storeId = 56;  // int? | Events that have Store Id (optional) 
            var storeGroupId = 56;  // int? | Events that have Store Group Id (optional) 
            var userId = 56;  // int? | Events that have User Id (optional) 
            var userEmail = userEmail_example;  // string | Events that have User Email (optional) 
            var userName = userName_example;  // string | Events that have User Name (optional) 
            var voucherCode = voucherCode_example;  // string | Events that have voucher code (optional) 
            var eventType = new List<string>(); // List<string> | Events that have event type\\s (optional) 
            var flipdishEventId = flipdishEventId_example;  // string | Unique Identifier of Event, if this is specified, all other criteria are ignored. (optional) 

            try
            {
                // Get WhiteLabel events  For technical reasons, the number of records returned is limited to 100.
                RestApiEventSearchPaginationResult result = apiInstance.GetWhiteLabelEvents(whitelabelId, limit, page, start, end, orderId, storeId, storeGroupId, userId, userEmail, userName, voucherCode, eventType, flipdishEventId);
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
 **whitelabelId** | **int?**| White Label Identifier | 
 **limit** | **int?**| The maximum elements to return | [optional] 
 **page** | **int?**| The index of the page to return, starting by 1 | [optional] 
 **start** | **DateTime?**| Start date | [optional] 
 **end** | **DateTime?**| End date | [optional] 
 **orderId** | **int?**| Events that have Order Id | [optional] 
 **storeId** | **int?**| Events that have Store Id | [optional] 
 **storeGroupId** | **int?**| Events that have Store Group Id | [optional] 
 **userId** | **int?**| Events that have User Id | [optional] 
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

