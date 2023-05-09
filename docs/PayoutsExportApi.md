# Flipdish.Api.PayoutsExportApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportPayoutChargebacks**](PayoutsExportApi.md#exportpayoutchargebacks) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/chargebacks/export | 
[**ExportPayoutOrders**](PayoutsExportApi.md#exportpayoutorders) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/orders/export | 
[**ExportPayoutOtherCharges**](PayoutsExportApi.md#exportpayoutothercharges) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/othercharges/export | 
[**ExportPayoutRefunds**](PayoutsExportApi.md#exportpayoutrefunds) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/refunds/export | 
[**ExportPayoutStores**](PayoutsExportApi.md#exportpayoutstores) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/payouts/{payoutId}/export | 
[**ExportPayouts**](PayoutsExportApi.md#exportpayouts) | **GET** /api/v1.0/{appId}/payouts/export | 


<a name="exportpayoutchargebacks"></a>
# **ExportPayoutChargebacks**
> string ExportPayoutChargebacks (string appId, int? bankAccountId, int? payoutId, List<int?> storeIds = null)



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

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                string result = apiInstance.ExportPayoutChargebacks(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayoutChargebacks: " + e.Message );
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

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                string result = apiInstance.ExportPayoutOrders(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayoutOrders: " + e.Message );
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

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                string result = apiInstance.ExportPayoutOtherCharges(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayoutOtherCharges: " + e.Message );
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

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                string result = apiInstance.ExportPayoutRefunds(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayoutRefunds: " + e.Message );
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

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var payoutId = 56;  // int? | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                string result = apiInstance.ExportPayoutStores(appId, bankAccountId, payoutId, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayoutStores: " + e.Message );
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

<a name="exportpayouts"></a>
# **ExportPayouts**
> string ExportPayouts (string appId, DateTime? startDate = null, DateTime? endDate = null, List<int?> payoutRequestIdsBankAccountIds = null, List<string> payoutRequestIdsStates = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExportPayoutsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PayoutsExportApi();
            var appId = appId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var payoutRequestIdsBankAccountIds = new List<int?>(); // List<int?> | List of bank account ids to search for (optional) 
            var payoutRequestIdsStates = payoutRequestIdsStates_example;  // List<string> | List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for (optional) 

            try
            {
                string result = apiInstance.ExportPayouts(appId, startDate, endDate, payoutRequestIdsBankAccountIds, payoutRequestIdsStates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsExportApi.ExportPayouts: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

