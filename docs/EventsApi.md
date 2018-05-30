# Flipdish.Api.EventsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCustomerEvents**](EventsApi.md#getcustomerevents) | **GET** /api/v1.0/events/customer/{customerId} | Get customer events
[**GetEvents**](EventsApi.md#getevents) | **GET** /api/v1.0/events | Get events
[**GetEventsById**](EventsApi.md#geteventsbyid) | **GET** /api/v1.0/events/{eventId} | Get event by Id
[**GetMenuEvents**](EventsApi.md#getmenuevents) | **GET** /api/v1.0/events/menu/{menuId} | Get menu events
[**GetOrderEvents**](EventsApi.md#getorderevents) | **GET** /api/v1.0/events/order/{orderId} | Get order events
[**GetOrderEventsByCustomer**](EventsApi.md#getordereventsbycustomer) | **GET** /api/v1.0/events/order | Get order events by customer
[**GetStoreEvents**](EventsApi.md#getstoreevents) | **GET** /api/v1.0/events/store/{storeId} | Get store events
[**GetUserEvents**](EventsApi.md#getuserevents) | **GET** /api/v1.0/events/user/{userId} | Get user events
[**GetWhiteLabelEvents**](EventsApi.md#getwhitelabelevents) | **GET** /api/v1.0/events/whitelabel/{whitelabelId} | Get WhiteLabel events


<a name="getcustomerevents"></a>
# **GetCustomerEvents**
> RestApiEventSearchPaginationResult GetCustomerEvents (int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get customer events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get customer events
                RestApiEventSearchPaginationResult result = apiInstance.GetCustomerEvents(customerId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetEvents (int? storeId = null, int? whiteLabelId = null, int? customerId = null, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get events
                RestApiEventSearchPaginationResult result = apiInstance.GetEvents(storeId, whiteLabelId, customerId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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

Get event by Id

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
                // Get event by Id
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
> RestApiEventSearchPaginationResult GetMenuEvents (int? menuId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get menu events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get menu events
                RestApiEventSearchPaginationResult result = apiInstance.GetMenuEvents(menuId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetOrderEvents (int? orderId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get order events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get order events
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEvents(orderId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetOrderEventsByCustomer (int? customerId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get order events by customer

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get order events by customer
                RestApiEventSearchPaginationResult result = apiInstance.GetOrderEventsByCustomer(customerId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetStoreEvents (int? storeId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get store events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get store events
                RestApiEventSearchPaginationResult result = apiInstance.GetStoreEvents(storeId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetUserEvents (int? userId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get user events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get user events
                RestApiEventSearchPaginationResult result = apiInstance.GetUserEvents(userId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

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
> RestApiEventSearchPaginationResult GetWhiteLabelEvents (int? whitelabelId, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, List<string> name = null)

Get WhiteLabel events

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
            var name = new List<string>(); // List<string> | Event names to filter in (optional) 

            try
            {
                // Get WhiteLabel events
                RestApiEventSearchPaginationResult result = apiInstance.GetWhiteLabelEvents(whitelabelId, limit, page, start, end, name);
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
 **name** | [**List&lt;string&gt;**](string.md)| Event names to filter in | [optional] 

### Return type

[**RestApiEventSearchPaginationResult**](RestApiEventSearchPaginationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
