# Flipdish.Api.OrdersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptOrder**](OrdersApi.md#acceptorder) | **POST** /api/v1.0/orders/{id}/accept | Accept order
[**DispatchOrder**](OrdersApi.md#dispatchorder) | **POST** /api/v1.0/orders/{id}/dispatch | Dispatch order
[**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /api/v1.0/orders/{id} | Get order by ID
[**GetOrders**](OrdersApi.md#getorders) | **GET** /api/v1.0/orders | Get orders by filter
[**GetOrdersSummary**](OrdersApi.md#getorderssummary) | **GET** /api/v1.0/{appId}/orders/summaries | [PRIVATE API] Get summary of orders by filter
[**RefundOrder**](OrdersApi.md#refundorder) | **POST** /api/v1.0/orders/{id}/refund | Refund order
[**RejectOrder**](OrdersApi.md#rejectorder) | **POST** /api/v1.0/orders/{id}/reject | Reject order


<a name="acceptorder"></a>
# **AcceptOrder**
> void AcceptOrder (int? id, Accept acceptObject)

Accept order

To accept an order, you create an `accept` object and send it to Flipdish API using HTTP POST method. `Id` path parameter identifies the order.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AcceptOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var id = 56;  // int? | Order identifier
            var acceptObject = new Accept(); // Accept | 

            try
            {
                // Accept order
                apiInstance.AcceptOrder(id, acceptObject);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.AcceptOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order identifier | 
 **acceptObject** | [**Accept**](Accept.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dispatchorder"></a>
# **DispatchOrder**
> void DispatchOrder (int? id)

Dispatch order

To dispatch an order send a POST request with `Id` path parameter which identifies the order.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DispatchOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var id = 56;  // int? | Order identifier

            try
            {
                // Dispatch order
                apiInstance.DispatchOrder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.DispatchOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> RestApiResultOrder GetOrderById (int? id)

Get order by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var id = 56;  // int? | Order identifier

            try
            {
                // Get order by ID
                RestApiResultOrder result = apiInstance.GetOrderById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order identifier | 

### Return type

[**RestApiResultOrder**](RestApiResultOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> RestApiPaginationResultOrder GetOrders (List<int?> physicalRestaurantId = null, List<string> state = null, DateTime? from = null, DateTime? to = null, int? page = null, int? limit = null)

Get orders by filter

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var physicalRestaurantId = new List<int?>(); // List<int?> | Physical restaurant identifiers (optional) 
            var state = state_example;  // List<string> | Order states (optional) 
            var from = 2013-10-20T19:20:30+01:00;  // DateTime? | Order has been placed after this parameter value (optional) 
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? | Order has been placed before this parameter value (optional) 
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get orders by filter
                RestApiPaginationResultOrder result = apiInstance.GetOrders(physicalRestaurantId, state, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **physicalRestaurantId** | [**List&lt;int?&gt;**](int?.md)| Physical restaurant identifiers | [optional] 
 **state** | **List&lt;string&gt;**| Order states | [optional] 
 **from** | **DateTime?**| Order has been placed after this parameter value | [optional] 
 **to** | **DateTime?**| Order has been placed before this parameter value | [optional] 
 **page** | **int?**| Requested page number | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultOrder**](RestApiPaginationResultOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderssummary"></a>
# **GetOrdersSummary**
> RestApiPaginationResultOrderSummary GetOrdersSummary (string appId, string searchQuery = null, List<int?> physicalRestaurantId = null, List<string> state = null, int? page = null, int? limit = null)

[PRIVATE API] Get summary of orders by filter

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrdersSummaryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var appId = appId_example;  // string | App Name Id
            var searchQuery = searchQuery_example;  // string | Query string (optional) 
            var physicalRestaurantId = new List<int?>(); // List<int?> | Physical restaurant identifiers (optional) 
            var state = state_example;  // List<string> | Order states (optional) 
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // [PRIVATE API] Get summary of orders by filter
                RestApiPaginationResultOrderSummary result = apiInstance.GetOrdersSummary(appId, searchQuery, physicalRestaurantId, state, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrdersSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **searchQuery** | **string**| Query string | [optional] 
 **physicalRestaurantId** | [**List&lt;int?&gt;**](int?.md)| Physical restaurant identifiers | [optional] 
 **state** | **List&lt;string&gt;**| Order states | [optional] 
 **page** | **int?**| Requested page number | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultOrderSummary**](RestApiPaginationResultOrderSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundorder"></a>
# **RefundOrder**
> void RefundOrder (int? id, Refund refundObject)

Refund order

To refund an order, you create a `refund` object and send it to Flipdish API using HTTP POST method. `Id` path parameter identifies the order.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RefundOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var id = 56;  // int? | Order identifier
            var refundObject = new Refund(); // Refund | 

            try
            {
                // Refund order
                apiInstance.RefundOrder(id, refundObject);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.RefundOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order identifier | 
 **refundObject** | [**Refund**](Refund.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectorder"></a>
# **RejectOrder**
> void RejectOrder (int? id, Reject rejectObject)

Reject order

To reject an order, you create a `reject` object and send it to Flipdish API using HTTP POST method. `Id` path parameter identifies the order.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RejectOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var id = 56;  // int? | Order identifier
            var rejectObject = new Reject(); // Reject | 

            try
            {
                // Reject order
                apiInstance.RejectOrder(id, rejectObject);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.RejectOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order identifier | 
 **rejectObject** | [**Reject**](Reject.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

