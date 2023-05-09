# Flipdish.Api.PaymentsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderPaymentInformation**](PaymentsApi.md#getorderpaymentinformation) | **GET** /api/v1.0/payments/payment/{orderId}/refundable | 


<a name="getorderpaymentinformation"></a>
# **GetOrderPaymentInformation**
> RestApiResultOrderPaymentInformation GetOrderPaymentInformation (int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderPaymentInformationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsApi();
            var orderId = 56;  // int? | 

            try
            {
                RestApiResultOrderPaymentInformation result = apiInstance.GetOrderPaymentInformation(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetOrderPaymentInformation: " + e.Message );
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

[**RestApiResultOrderPaymentInformation**](RestApiResultOrderPaymentInformation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

