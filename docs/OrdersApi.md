# Flipdish.Api.OrdersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptOrder**](OrdersApi.md#acceptorder) | **POST** /api/v1.0/orders/{id}/accept | 
[**DispatchOrder**](OrdersApi.md#dispatchorder) | **POST** /api/v1.0/orders/{id}/dispatch | 
[**GetDeliveryInformation**](OrdersApi.md#getdeliveryinformation) | **GET** /api/v1.0/orders/{orderId}/deliveryinfo | 
[**GetFulfillmentState**](OrdersApi.md#getfulfillmentstate) | **GET** /api/v1.0/orders/{orderId}/fulfillment/state | 
[**GetFulfillmentStatusWithDetailsAndActions**](OrdersApi.md#getfulfillmentstatuswithdetailsandactions) | **GET** /api/v1.0/orders/{orderId}/fulfillment/state/details | 
[**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /api/v1.0/orders/{id} | 
[**GetOrders**](OrdersApi.md#getorders) | **GET** /api/v1.0/orders | 
[**GetOrdersSummary**](OrdersApi.md#getorderssummary) | **GET** /api/v1.0/{appId}/orders/summaries | 
[**RefundOrder**](OrdersApi.md#refundorder) | **POST** /api/v1.0/orders/{id}/refund | 
[**RejectOrder**](OrdersApi.md#rejectorder) | **POST** /api/v1.0/orders/{id}/reject | 
[**SearchFulfillmentStatuses**](OrdersApi.md#searchfulfillmentstatuses) | **GET** /api/v1.0/{appId}/orders/fulfillmentstatuses | 
[**UpdateDeliveryInformation**](OrdersApi.md#updatedeliveryinformation) | **POST** /api/v1.0/orders/{orderId}/deliveryinfo | 
[**UpdateFulfillmentState**](OrdersApi.md#updatefulfillmentstate) | **POST** /api/v1.0/orders/{orderId}/fulfillment/state | 


<a name="acceptorder"></a>
# **AcceptOrder**
> void AcceptOrder (int? id, Accept acceptObject)



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
            var id = 56;  // int? | 
            var acceptObject = new Accept(); // Accept | 

            try
            {
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
 **id** | **int?**|  | 
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
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeliveryinformation"></a>
# **GetDeliveryInformation**
> RestApiResultOrderDeliveryInformation GetDeliveryInformation (int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetDeliveryInformationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | 

            try
            {
                RestApiResultOrderDeliveryInformation result = apiInstance.GetDeliveryInformation(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetDeliveryInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 

### Return type

[**RestApiResultOrderDeliveryInformation**](RestApiResultOrderDeliveryInformation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstate"></a>
# **GetFulfillmentState**
> RestApiResultOrderFulfillmentStatus GetFulfillmentState (int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFulfillmentStateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | 

            try
            {
                RestApiResultOrderFulfillmentStatus result = apiInstance.GetFulfillmentState(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetFulfillmentState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 

### Return type

[**RestApiResultOrderFulfillmentStatus**](RestApiResultOrderFulfillmentStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstatuswithdetailsandactions"></a>
# **GetFulfillmentStatusWithDetailsAndActions**
> RestApiResultOrderFulfillmentStatusWithConfigurationActions GetFulfillmentStatusWithDetailsAndActions (int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFulfillmentStatusWithDetailsAndActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | 

            try
            {
                RestApiResultOrderFulfillmentStatusWithConfigurationActions result = apiInstance.GetFulfillmentStatusWithDetailsAndActions(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetFulfillmentStatusWithDetailsAndActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 

### Return type

[**RestApiResultOrderFulfillmentStatusWithConfigurationActions**](RestApiResultOrderFulfillmentStatusWithConfigurationActions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> RestApiResultOrder GetOrderById (int? id)



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
            var id = 56;  // int? | 

            try
            {
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
 **id** | **int?**|  | 

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
            var physicalRestaurantId = new List<int?>(); // List<int?> |  (optional) 
            var state = state_example;  // List<string> |  (optional) 
            var from = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **physicalRestaurantId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **state** | **List&lt;string&gt;**|  | [optional] 
 **from** | **DateTime?**|  | [optional] 
 **to** | **DateTime?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

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
> RestApiPaginationResultOrderSummary GetOrdersSummary (string appId, string searchQuery = null, List<int?> physicalRestaurantId = null, List<string> state = null, int? page = null, int? limit = null, bool? orderByRequestedForTime = null, List<string> channels = null, List<int?> orderIds = null, DateTime? from = null, DateTime? to = null)



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
            var appId = appId_example;  // string | 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var physicalRestaurantId = new List<int?>(); // List<int?> |  (optional) 
            var state = state_example;  // List<string> |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var orderByRequestedForTime = true;  // bool? |  (optional) 
            var channels = channels_example;  // List<string> |  (optional) 
            var orderIds = new List<int?>(); // List<int?> |  (optional) 
            var from = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                RestApiPaginationResultOrderSummary result = apiInstance.GetOrdersSummary(appId, searchQuery, physicalRestaurantId, state, page, limit, orderByRequestedForTime, channels, orderIds, from, to);
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
 **appId** | **string**|  | 
 **searchQuery** | **string**|  | [optional] 
 **physicalRestaurantId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **state** | **List&lt;string&gt;**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **orderByRequestedForTime** | **bool?**|  | [optional] 
 **channels** | **List&lt;string&gt;**|  | [optional] 
 **orderIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **from** | **DateTime?**|  | [optional] 
 **to** | **DateTime?**|  | [optional] 

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
            var id = 56;  // int? | 
            var refundObject = new Refund(); // Refund | 

            try
            {
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
 **id** | **int?**|  | 
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
            var id = 56;  // int? | 
            var rejectObject = new Reject(); // Reject | 

            try
            {
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
 **id** | **int?**|  | 
 **rejectObject** | [**Reject**](Reject.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchfulfillmentstatuses"></a>
# **SearchFulfillmentStatuses**
> RestApiArrayResultOrderFulfillmentStatus SearchFulfillmentStatuses (string appId, string orderIds)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchFulfillmentStatusesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var appId = appId_example;  // string | 
            var orderIds = orderIds_example;  // string | 

            try
            {
                RestApiArrayResultOrderFulfillmentStatus result = apiInstance.SearchFulfillmentStatuses(appId, orderIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.SearchFulfillmentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **orderIds** | **string**|  | 

### Return type

[**RestApiArrayResultOrderFulfillmentStatus**](RestApiArrayResultOrderFulfillmentStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeliveryinformation"></a>
# **UpdateDeliveryInformation**
> void UpdateDeliveryInformation (int? orderId, OrderDeliveryInformationBase deliveryInformation)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateDeliveryInformationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | 
            var deliveryInformation = new OrderDeliveryInformationBase(); // OrderDeliveryInformationBase | 

            try
            {
                apiInstance.UpdateDeliveryInformation(orderId, deliveryInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateDeliveryInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 
 **deliveryInformation** | [**OrderDeliveryInformationBase**](OrderDeliveryInformationBase.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentstate"></a>
# **UpdateFulfillmentState**
> void UpdateFulfillmentState (int? orderId, OrderFulfillmentStatusUpdate fulfillmentStatusRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateFulfillmentStateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi();
            var orderId = 56;  // int? | 
            var fulfillmentStatusRequest = new OrderFulfillmentStatusUpdate(); // OrderFulfillmentStatusUpdate | 

            try
            {
                apiInstance.UpdateFulfillmentState(orderId, fulfillmentStatusRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateFulfillmentState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 
 **fulfillmentStatusRequest** | [**OrderFulfillmentStatusUpdate**](OrderFulfillmentStatusUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

