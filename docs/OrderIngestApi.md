# Flipdish.Api.OrderIngestApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderIngestSubmitNewOrder**](OrderIngestApi.md#orderingestsubmitneworder) | **POST** /api/v1.0/{appNameId}/order-ingest/submit | Provides an ability to ingest a 3rd party order into Flipdish ecosystem


<a name="orderingestsubmitneworder"></a>
# **OrderIngestSubmitNewOrder**
> RestApiResultOrderIngestSubmitOrderResponse OrderIngestSubmitNewOrder (OrderIngestSubmitOrderRequest order, string appNameId)

Provides an ability to ingest a 3rd party order into Flipdish ecosystem

[ALPHA - this endpoint is under internal development, it is not available just yet to use in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OrderIngestSubmitNewOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderIngestApi();
            var order = new OrderIngestSubmitOrderRequest(); // OrderIngestSubmitOrderRequest | 
            var appNameId = appNameId_example;  // string | 

            try
            {
                // Provides an ability to ingest a 3rd party order into Flipdish ecosystem
                RestApiResultOrderIngestSubmitOrderResponse result = apiInstance.OrderIngestSubmitNewOrder(order, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderIngestApi.OrderIngestSubmitNewOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**OrderIngestSubmitOrderRequest**](OrderIngestSubmitOrderRequest.md)|  | 
 **appNameId** | **string**|  | 

### Return type

[**RestApiResultOrderIngestSubmitOrderResponse**](RestApiResultOrderIngestSubmitOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

