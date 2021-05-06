# Flipdish.Api.PayoutsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportPayoutChargebacks**](PayoutsApi.md#exportpayoutchargebacks) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/chargebacks/export | Export a list of payout&#39;s chargebacks as CSV
[**ExportPayoutOrders**](PayoutsApi.md#exportpayoutorders) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/orders/export | Export a list of payout&#39;s orders as CSV
[**ExportPayoutOtherCharges**](PayoutsApi.md#exportpayoutothercharges) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/othercharges/export | Export a list of payout&#39;s other charges as CSV
[**ExportPayoutRefunds**](PayoutsApi.md#exportpayoutrefunds) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/refunds/export | Export a list of payout&#39;s refunds as CSV
[**ExportPayoutStores**](PayoutsApi.md#exportpayoutstores) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/export | Export payout&#39;s details as CSV
[**GetPayout**](PayoutsApi.md#getpayout) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId} | Get Payout details broken down by Store
[**GetPayoutChargebacks**](PayoutsApi.md#getpayoutchargebacks) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/chargebacks | Get list of payout&#39;s chargebacks
[**GetPayoutOrders**](PayoutsApi.md#getpayoutorders) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/orders | Get list of payout&#39;s orders
[**GetPayoutOtherCharges**](PayoutsApi.md#getpayoutothercharges) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/othercharges | Get list of payout&#39;s other charges
[**GetPayoutRefunds**](PayoutsApi.md#getpayoutrefunds) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/refunds | Get list of payout&#39;s refunds
[**GetPayoutSummaries**](PayoutsApi.md#getpayoutsummaries) | **GET** /api/v1.0/{appId}/payouts/summaries | Get list of payout summaries
[**GetPayouts**](PayoutsApi.md#getpayouts) | **GET** /api/v1.0/{appId}/payouts | Get list of payouts


<a name="exportpayoutchargebacks"></a>
# **ExportPayoutChargebacks**
> string ExportPayoutChargebacks (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)

Export a list of payout's chargebacks as CSV

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutChargebacksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Export a list of payout's chargebacks as CSV
                string result = apiInstance.ExportPayoutChargebacks(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.ExportPayoutChargebacks: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpayoutorders"></a>
# **ExportPayoutOrders**
> string ExportPayoutOrders (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)

Export a list of payout's orders as CSV

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Export a list of payout's orders as CSV
                string result = apiInstance.ExportPayoutOrders(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.ExportPayoutOrders: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpayoutothercharges"></a>
# **ExportPayoutOtherCharges**
> string ExportPayoutOtherCharges (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)

Export a list of payout's other charges as CSV

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutOtherChargesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Export a list of payout's other charges as CSV
                string result = apiInstance.ExportPayoutOtherCharges(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.ExportPayoutOtherCharges: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpayoutrefunds"></a>
# **ExportPayoutRefunds**
> string ExportPayoutRefunds (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)

Export a list of payout's refunds as CSV

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutRefundsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Export a list of payout's refunds as CSV
                string result = apiInstance.ExportPayoutRefunds(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.ExportPayoutRefunds: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportpayoutstores"></a>
# **ExportPayoutStores**
> string ExportPayoutStores (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)

Export payout's details as CSV

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutStoresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Export payout's details as CSV
                string result = apiInstance.ExportPayoutStores(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.ExportPayoutStores: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayout"></a>
# **GetPayout**
> PayoutDetail GetPayout (string appId, int? bankAccountId, int? payoutId)

Get Payout details broken down by Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 

            try
            {
                // Get Payout details broken down by Store
                PayoutDetail result = apiInstance.GetPayout(appId, bankAccountId, payoutId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayout: " + e.Message );
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

[**PayoutDetail**](PayoutDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutchargebacks"></a>
# **GetPayoutChargebacks**
> RestApiPaginationResultPayoutChargeback GetPayoutChargebacks (string appId, int? bankAccountId, int? payoutId, int? page = null, int? limit = null, List<int?> storeIds = null)

Get list of payout's chargebacks

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutChargebacksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Get list of payout's chargebacks
                RestApiPaginationResultPayoutChargeback result = apiInstance.GetPayoutChargebacks(appId, bankAccountId, payoutId, page, limit, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayoutChargebacks: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultPayoutChargeback**](RestApiPaginationResultPayoutChargeback.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutorders"></a>
# **GetPayoutOrders**
> RestApiPaginationResultPayoutOrder GetPayoutOrders (string appId, int? bankAccountId, int? payoutId, int? page = null, int? limit = null, List<int?> storeIds = null)

Get list of payout's orders

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Get list of payout's orders
                RestApiPaginationResultPayoutOrder result = apiInstance.GetPayoutOrders(appId, bankAccountId, payoutId, page, limit, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayoutOrders: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultPayoutOrder**](RestApiPaginationResultPayoutOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutothercharges"></a>
# **GetPayoutOtherCharges**
> RestApiPaginationResultPayoutOtherCharge GetPayoutOtherCharges (string appId, int? bankAccountId, int? payoutId, int? page = null, int? limit = null, List<int?> storeIds = null)

Get list of payout's other charges

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutOtherChargesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Get list of payout's other charges
                RestApiPaginationResultPayoutOtherCharge result = apiInstance.GetPayoutOtherCharges(appId, bankAccountId, payoutId, page, limit, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayoutOtherCharges: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultPayoutOtherCharge**](RestApiPaginationResultPayoutOtherCharge.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutrefunds"></a>
# **GetPayoutRefunds**
> RestApiPaginationResultPayoutRefund GetPayoutRefunds (string appId, int? bankAccountId, int? payoutId, int? page = null, int? limit = null, List<int?> storeIds = null)

Get list of payout's refunds

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutRefundsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // Get list of payout's refunds
                RestApiPaginationResultPayoutRefund result = apiInstance.GetPayoutRefunds(appId, bankAccountId, payoutId, page, limit, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayoutRefunds: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultPayoutRefund**](RestApiPaginationResultPayoutRefund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutsummaries"></a>
# **GetPayoutSummaries**
> RestApiArrayResultPayoutSummary GetPayoutSummaries (string appId, int? bankAccountId = null, int? payeeBankAccountDataId = null, DateTime? startDate = null, DateTime? endDate = null, string status = null)

Get list of payout summaries

BETA - this endpoint is under development, do not use it in your production system

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutSummariesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? |  (optional) 
            var payeeBankAccountDataId = 56;  // int? | Deprecated (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var status = status_example;  // string |  (optional) 

            try
            {
                // Get list of payout summaries
                RestApiArrayResultPayoutSummary result = apiInstance.GetPayoutSummaries(appId, bankAccountId, payeeBankAccountDataId, startDate, endDate, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayoutSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | [optional] 
 **payeeBankAccountDataId** | **int?**| Deprecated | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultPayoutSummary**](RestApiArrayResultPayoutSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayouts"></a>
# **GetPayouts**
> RestApiPaginationResultPayout GetPayouts (string appId, int? bankAccountId = null, int? payeeBankAccountDataId = null, DateTime? startDate = null, DateTime? endDate = null, string status = null, int? page = null, int? limit = null)

Get list of payouts

BETA - this endpoint is under development, do not use it in your production system

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayoutsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? |  (optional) 
            var payeeBankAccountDataId = 56;  // int? | Deprecated (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var status = status_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get list of payouts
                RestApiPaginationResultPayout result = apiInstance.GetPayouts(appId, bankAccountId, payeeBankAccountDataId, startDate, endDate, status, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetPayouts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | [optional] 
 **payeeBankAccountDataId** | **int?**| Deprecated | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **status** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultPayout**](RestApiPaginationResultPayout.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

