# Flipdish.Api.PayoutsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPayout**](PayoutsApi.md#getpayout) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId} | 
[**GetPayoutChargebacks**](PayoutsApi.md#getpayoutchargebacks) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/chargebacks | 
[**GetPayoutOrders**](PayoutsApi.md#getpayoutorders) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/orders | 
[**GetPayoutOtherCharges**](PayoutsApi.md#getpayoutothercharges) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/othercharges | 
[**GetPayoutRefunds**](PayoutsApi.md#getpayoutrefunds) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/refunds | 
[**GetPayoutSummaries**](PayoutsApi.md#getpayoutsummaries) | **GET** /api/v1.0/{appId}/payouts/summaries | 
[**GetPayouts**](PayoutsApi.md#getpayouts) | **GET** /api/v1.0/{appId}/payouts | 


<a name="getpayout"></a>
# **GetPayout**
> PayoutDetail GetPayout (string appId, int? bankAccountId, int? payoutId)



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
> RestApiArrayResultPayoutSummary GetPayoutSummaries (string appId, DateTime? startDate = null, DateTime? endDate = null, List<int?> payoutRequestIdsBankAccountIds = null, List<string> payoutRequestIdsStates = null)



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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var payoutRequestIdsBankAccountIds = new List<int?>(); // List<int?> | List of bank account ids to search for (optional) 
            var payoutRequestIdsStates = payoutRequestIdsStates_example;  // List<string> | List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for (optional) 

            try
            {
                RestApiArrayResultPayoutSummary result = apiInstance.GetPayoutSummaries(appId, startDate, endDate, payoutRequestIdsBankAccountIds, payoutRequestIdsStates);
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **payoutRequestIdsBankAccountIds** | [**List&lt;int?&gt;**](int?.md)| List of bank account ids to search for | [optional] 
 **payoutRequestIdsStates** | **List&lt;string&gt;**| List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for | [optional] 

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
> RestApiPaginationResultPayout GetPayouts (string appId, DateTime? startDate = null, DateTime? endDate = null, int? page = null, int? limit = null, List<int?> payoutRequestIdsBankAccountIds = null, List<string> payoutRequestIdsStates = null)



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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var payoutRequestIdsBankAccountIds = new List<int?>(); // List<int?> | List of bank account ids to search for (optional) 
            var payoutRequestIdsStates = payoutRequestIdsStates_example;  // List<string> | List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for (optional) 

            try
            {
                RestApiPaginationResultPayout result = apiInstance.GetPayouts(appId, startDate, endDate, page, limit, payoutRequestIdsBankAccountIds, payoutRequestIdsStates);
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **payoutRequestIdsBankAccountIds** | [**List&lt;int?&gt;**](int?.md)| List of bank account ids to search for | [optional] 
 **payoutRequestIdsStates** | **List&lt;string&gt;**| List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for | [optional] 

### Return type

[**RestApiPaginationResultPayout**](RestApiPaginationResultPayout.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

