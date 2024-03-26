# Flipdish.Api.PayoutReportsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPayoutReport3Details**](PayoutReportsApi.md#getpayoutreport3details) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/details | 
[**GetPayoutReport3Orders**](PayoutReportsApi.md#getpayoutreport3orders) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/orders | 
[**GetPayoutReport3Overview**](PayoutReportsApi.md#getpayoutreport3overview) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/overview | 


<a name="getpayoutreport3details"></a>
# **GetPayoutReport3Details**
> RestApiResultPayoutReport3Details GetPayoutReport3Details (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutReport3DetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultPayoutReport3Details result = apiInstance.GetPayoutReport3Details(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.GetPayoutReport3Details: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **payoutId** | **int?**|  | 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultPayoutReport3Details**](RestApiResultPayoutReport3Details.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutreport3orders"></a>
# **GetPayoutReport3Orders**
> RestApiPaginationResultPayoutReport3PayoutOrder GetPayoutReport3Orders (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null, int? page = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutReport3OrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultPayoutReport3PayoutOrder result = apiInstance.GetPayoutReport3Orders(appId, bankAccountId, payoutId, storeIds, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.GetPayoutReport3Orders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **payoutId** | **int?**|  | 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultPayoutReport3PayoutOrder**](RestApiPaginationResultPayoutReport3PayoutOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutreport3overview"></a>
# **GetPayoutReport3Overview**
> RestApiResultPayoutReport3Overview GetPayoutReport3Overview (string appId, int? bankAccountId, int? payoutId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutReport3OverviewExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 

            try
            {
                RestApiResultPayoutReport3Overview result = apiInstance.GetPayoutReport3Overview(appId, bankAccountId, payoutId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.GetPayoutReport3Overview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **payoutId** | **int?**|  | 

### Return type

[**RestApiResultPayoutReport3Overview**](RestApiResultPayoutReport3Overview.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

