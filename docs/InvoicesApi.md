# Flipdish.Api.InvoicesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /api/v1.0/{appId}/invoices | Get list of invoices


<a name="getinvoices"></a>
# **GetInvoices**
> RestApiFinanceSearchPaginationResultInvoice GetInvoices (string appId, string subscriptionId = null, int? limit = null, string pageId = null)

Get list of invoices

[BETA - this endpoint is under development, do not use it in your production system] Due to the nature of this request, page will always remain as 0.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var appId = appId_example;  // string | App Id
            var subscriptionId = subscriptionId_example;  // string | Subscription Id (optional) (optional) 
            var limit = 56;  // int? | Limit of invoices to return (optional) 
            var pageId = pageId_example;  // string | Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) 

            try
            {
                // Get list of invoices
                RestApiFinanceSearchPaginationResultInvoice result = apiInstance.GetInvoices(appId, subscriptionId, limit, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **subscriptionId** | **string**| Subscription Id (optional) | [optional] 
 **limit** | **int?**| Limit of invoices to return | [optional] 
 **pageId** | **string**| Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call | [optional] 

### Return type

[**RestApiFinanceSearchPaginationResultInvoice**](RestApiFinanceSearchPaginationResultInvoice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

