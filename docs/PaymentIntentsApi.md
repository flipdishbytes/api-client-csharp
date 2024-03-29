# Flipdish.Api.PaymentIntentsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentIntent**](PaymentIntentsApi.md#getpaymentintent) | **GET** /api/v1.0/payment_intents/{paymentIntentId} | 


<a name="getpaymentintent"></a>
# **GetPaymentIntent**
> RestApiResultPaymentIntent GetPaymentIntent (string paymentIntentId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPaymentIntentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentIntentsApi();
            var paymentIntentId = paymentIntentId_example;  // string | 

            try
            {
                RestApiResultPaymentIntent result = apiInstance.GetPaymentIntent(paymentIntentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentIntentsApi.GetPaymentIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentIntentId** | **string**|  | 

### Return type

[**RestApiResultPaymentIntent**](RestApiResultPaymentIntent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

