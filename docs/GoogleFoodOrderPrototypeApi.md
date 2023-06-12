# Flipdish.Api.GoogleFoodOrderPrototypeApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrder**](GoogleFoodOrderPrototypeApi.md#createorder) | **POST** /api/v1.0/{appId}/googleorder | 
[**SubmitOrder**](GoogleFoodOrderPrototypeApi.md#submitorder) | **POST** /api/v1.0/{appId}/googleorder/{orderId}/submit | 


<a name="createorder"></a>
# **CreateOrder**
> RestApiResultSubmitOrderResponseDm CreateOrder (string appId, CreateOrderRequest orderRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoogleFoodOrderPrototypeApi();
            var appId = appId_example;  // string | 
            var orderRequest = new CreateOrderRequest(); // CreateOrderRequest | 

            try
            {
                RestApiResultSubmitOrderResponseDm result = apiInstance.CreateOrder(appId, orderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoogleFoodOrderPrototypeApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **orderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md)|  | 

### Return type

[**RestApiResultSubmitOrderResponseDm**](RestApiResultSubmitOrderResponseDm.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitorder"></a>
# **SubmitOrder**
> RestApiResultSubmitOrderResponseDm SubmitOrder (string appId, int? orderId, SubmitOrderRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmitOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoogleFoodOrderPrototypeApi();
            var appId = appId_example;  // string | 
            var orderId = 56;  // int? | 
            var request = new SubmitOrderRequest(); // SubmitOrderRequest | 

            try
            {
                RestApiResultSubmitOrderResponseDm result = apiInstance.SubmitOrder(appId, orderId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoogleFoodOrderPrototypeApi.SubmitOrder: " + e.Message );
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
 **request** | [**SubmitOrderRequest**](SubmitOrderRequest.md)|  | 

### Return type

[**RestApiResultSubmitOrderResponseDm**](RestApiResultSubmitOrderResponseDm.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

