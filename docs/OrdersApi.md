# Flipdish.Api.OrdersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptOrder**](OrdersApi.md#acceptorder) | **POST** /api/v1.0/orders/{id}/accept | Accept order
[**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /api/v1.0/orders/{id} | Get order by ID
[**GetOrders**](OrdersApi.md#getorders) | **GET** /api/v1.0/orders | Get orders by filter
[**RefundOrder**](OrdersApi.md#refundorder) | **POST** /api/v1.0/orders/{id}/refund | Refund order
[**RejectOrder**](OrdersApi.md#rejectorder) | **POST** /api/v1.0/orders/{id}/reject | Reject order


<a name="acceptorder"></a>
# **AcceptOrder**
> void AcceptOrder (int? id, FlipdishPublicModelsV1OrdersAccept acceptObject)

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
            var acceptObject = new FlipdishPublicModelsV1OrdersAccept(); // FlipdishPublicModelsV1OrdersAccept | 

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
 **acceptObject** | [**FlipdishPublicModelsV1OrdersAccept**](FlipdishPublicModelsV1OrdersAccept.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OrdersOrder GetOrderById (int? id)

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
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OrdersOrder result = apiInstance.GetOrderById(id);
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

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OrdersOrder**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OrdersOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OrdersOrder GetOrders (List<int?> physicalRestaurantId = null, List<string> state = null, int? page = null, int? limit = null)

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
            var state = new List<string>(); // List<string> | Order states (optional) 
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get orders by filter
                FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OrdersOrder result = apiInstance.GetOrders(physicalRestaurantId, state, page, limit);
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
 **state** | [**List&lt;string&gt;**](string.md)| Order states | [optional] 
 **page** | **int?**| Requested page number | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OrdersOrder**](FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OrdersOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundorder"></a>
# **RefundOrder**
> void RefundOrder (int? id, FlipdishPublicModelsV1OrdersRefund refundObject)

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
            var refundObject = new FlipdishPublicModelsV1OrdersRefund(); // FlipdishPublicModelsV1OrdersRefund | 

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
 **refundObject** | [**FlipdishPublicModelsV1OrdersRefund**](FlipdishPublicModelsV1OrdersRefund.md)|  | 

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
> void RejectOrder (int? id, FlipdishPublicModelsV1OrdersReject rejectObject)

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
            var rejectObject = new FlipdishPublicModelsV1OrdersReject(); // FlipdishPublicModelsV1OrdersReject | 

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
 **rejectObject** | [**FlipdishPublicModelsV1OrdersReject**](FlipdishPublicModelsV1OrdersReject.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

