# Flipdish.Api.InvoicesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /api/v1.0/{appId}/invoices | 
[**InvoicePdf**](InvoicesApi.md#invoicepdf) | **GET** /api/v1.0/{appId}/invoices/InvoicePdf | 
[**ListInvoices**](InvoicesApi.md#listinvoices) | **GET** /api/v1.0/{appId}/invoices/ListInvoices | 
[**ListSubscriptionInvoices**](InvoicesApi.md#listsubscriptioninvoices) | **GET** /api/v1.0/{appId}/invoices/ListSubscriptionInvoices | 


<a name="getinvoices"></a>
# **GetInvoices**
> RestApiFinanceSearchPaginationResultSubscriptionInvoice GetInvoices (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null, List<int?> storeId = null)



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
            var appId = appId_example;  // string | 
            var subscriptionId = subscriptionId_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var pageId = pageId_example;  // string |  (optional) 
            var excludeNotOwnedInvoices = true;  // bool? |  (optional) 
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var invoiceNumber = invoiceNumber_example;  // string |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiFinanceSearchPaginationResultSubscriptionInvoice result = apiInstance.GetInvoices(appId, subscriptionId, limit, pageId, excludeNotOwnedInvoices, dateFrom, dateTo, invoiceNumber, storeId);
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
 **appId** | **string**|  | 
 **subscriptionId** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **pageId** | **string**|  | [optional] 
 **excludeNotOwnedInvoices** | **bool?**|  | [optional] 
 **dateFrom** | **DateTime?**|  | [optional] 
 **dateTo** | **DateTime?**|  | [optional] 
 **invoiceNumber** | **string**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiFinanceSearchPaginationResultSubscriptionInvoice**](RestApiFinanceSearchPaginationResultSubscriptionInvoice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicepdf"></a>
# **InvoicePdf**
> void InvoicePdf (string invoiceNumber, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InvoicePdfExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var invoiceNumber = invoiceNumber_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.InvoicePdf(invoiceNumber, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicePdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceNumber** | **string**|  | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinvoices"></a>
# **ListInvoices**
> Object ListInvoices (int? storeId, string appId, int? limit = null, int? page = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ListInvoicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var storeId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var page = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.ListInvoices(storeId, appId, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.ListInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **appId** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **page** | **int?**|  | [optional] 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubscriptioninvoices"></a>
# **ListSubscriptionInvoices**
> RestApiFinanceSearchPaginationResultSubscriptionInvoice ListSubscriptionInvoices (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ListSubscriptionInvoicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var appId = appId_example;  // string | 
            var subscriptionId = subscriptionId_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var pageId = pageId_example;  // string |  (optional) 
            var excludeNotOwnedInvoices = true;  // bool? |  (optional) 
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var invoiceNumber = invoiceNumber_example;  // string |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiFinanceSearchPaginationResultSubscriptionInvoice result = apiInstance.ListSubscriptionInvoices(appId, subscriptionId, limit, pageId, excludeNotOwnedInvoices, dateFrom, dateTo, invoiceNumber, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.ListSubscriptionInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **subscriptionId** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **pageId** | **string**|  | [optional] 
 **excludeNotOwnedInvoices** | **bool?**|  | [optional] 
 **dateFrom** | **DateTime?**|  | [optional] 
 **dateTo** | **DateTime?**|  | [optional] 
 **invoiceNumber** | **string**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiFinanceSearchPaginationResultSubscriptionInvoice**](RestApiFinanceSearchPaginationResultSubscriptionInvoice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

