# Flipdish.Api.PayoutReportsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPayoutReport3Details**](PayoutReportsApi.md#getpayoutreport3details) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/details | 
[**GetPayoutReport3Orders**](PayoutReportsApi.md#getpayoutreport3orders) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/orders | 
[**GetPayoutReport3Overview**](PayoutReportsApi.md#getpayoutreport3overview) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/overview | 
[**PayoutReport3ExportPayoutChargebacks**](PayoutReportsApi.md#payoutreport3exportpayoutchargebacks) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/chargebacks | 
[**PayoutReport3ExportPayoutLedgerEntries**](PayoutReportsApi.md#payoutreport3exportpayoutledgerentries) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/ledgerentries | 
[**PayoutReport3ExportPayoutOnlineOrders**](PayoutReportsApi.md#payoutreport3exportpayoutonlineorders) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/onlineorders | 
[**PayoutReport3ExportPayoutOrders**](PayoutReportsApi.md#payoutreport3exportpayoutorders) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/orders | 
[**PayoutReport3ExportPayoutPosSales**](PayoutReportsApi.md#payoutreport3exportpayoutpossales) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/possales | 
[**PayoutReport3ExportPayoutRefundedRejected**](PayoutReportsApi.md#payoutreport3exportpayoutrefundedrejected) | **GET** /api/v1.0/{appId}/reporting/reports/payouts3/{bankAccountId}/{payoutId}/export/refundedrejected | 


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

<a name="payoutreport3exportpayoutchargebacks"></a>
# **PayoutReport3ExportPayoutChargebacks**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutChargebacks (string appId, int? bankAccountId, int? payoutId, List<int?> stores = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutChargebacksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var stores = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutChargebacks(appId, bankAccountId, payoutId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutChargebacks: " + e.Message );
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
 **stores** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payoutreport3exportpayoutledgerentries"></a>
# **PayoutReport3ExportPayoutLedgerEntries**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutLedgerEntries (string appId, int? bankAccountId, int? payoutId, List<int?> stores = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutLedgerEntriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var stores = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutLedgerEntries(appId, bankAccountId, payoutId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutLedgerEntries: " + e.Message );
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
 **stores** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payoutreport3exportpayoutonlineorders"></a>
# **PayoutReport3ExportPayoutOnlineOrders**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutOnlineOrders (string appId, string bankAccountId, string payoutId, DateTime? startDate = null, DateTime? endDate = null, List<int?> payoutRequestIdsBankAccountIds = null, List<string> payoutRequestIdsStates = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutOnlineOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = bankAccountId_example;  // string | 
            var payoutId = payoutId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var payoutRequestIdsBankAccountIds = new List<int?>(); // List<int?> | List of bank account ids to search for (optional) 
            var payoutRequestIdsStates = payoutRequestIdsStates_example;  // List<string> | List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutOnlineOrders(appId, bankAccountId, payoutId, startDate, endDate, payoutRequestIdsBankAccountIds, payoutRequestIdsStates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutOnlineOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **string**|  | 
 **payoutId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **payoutRequestIdsBankAccountIds** | [**List&lt;int?&gt;**](int?.md)| List of bank account ids to search for | [optional] 
 **payoutRequestIdsStates** | **List&lt;string&gt;**| List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payoutreport3exportpayoutorders"></a>
# **PayoutReport3ExportPayoutOrders**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutOrders (string appId, int? bankAccountId, int? payoutId, List<int?> stores = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var stores = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutOrders(appId, bankAccountId, payoutId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutOrders: " + e.Message );
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
 **stores** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payoutreport3exportpayoutpossales"></a>
# **PayoutReport3ExportPayoutPosSales**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutPosSales (string appId, int? bankAccountId, int? payoutId, List<int?> stores = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutPosSalesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var stores = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutPosSales(appId, bankAccountId, payoutId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutPosSales: " + e.Message );
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
 **stores** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payoutreport3exportpayoutrefundedrejected"></a>
# **PayoutReport3ExportPayoutRefundedRejected**
> RestApiResultFileCreationResult PayoutReport3ExportPayoutRefundedRejected (string appId, int? bankAccountId, int? payoutId, List<int?> stores = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PayoutReport3ExportPayoutRefundedRejectedExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutReportsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var stores = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultFileCreationResult result = apiInstance.PayoutReport3ExportPayoutRefundedRejected(appId, bankAccountId, payoutId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutReportsApi.PayoutReport3ExportPayoutRefundedRejected: " + e.Message );
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
 **stores** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultFileCreationResult**](RestApiResultFileCreationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

