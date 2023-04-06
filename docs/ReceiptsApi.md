# Flipdish.Api.ReceiptsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetReceipt**](ReceiptsApi.md#getreceipt) | **GET** /api/v1.0/receipts/{orderId} | Returns all receipt information for a given orderId


<a name="getreceipt"></a>
# **GetReceipt**
> GetReceiptByOrderIdQueryResponse GetReceipt (int? orderId)

Returns all receipt information for a given orderId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetReceiptExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceiptsApi();
            var orderId = 56;  // int? | 

            try
            {
                // Returns all receipt information for a given orderId
                GetReceiptByOrderIdQueryResponse result = apiInstance.GetReceipt(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceiptsApi.GetReceipt: " + e.Message );
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

[**GetReceiptByOrderIdQueryResponse**](GetReceiptByOrderIdQueryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

