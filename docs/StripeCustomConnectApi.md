# Flipdish.Api.StripeCustomConnectApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBankAccountAndConnectedAccount**](StripeCustomConnectApi.md#createbankaccountandconnectedaccount) | **POST** /api/v1.0/{appId}/customconnect/bank-account | 
[**CreateStripeConnectedAccount**](StripeCustomConnectApi.md#createstripeconnectedaccount) | **POST** /api/v1.0/{appId}/customconnect/{bankAccountId}/create-update-account | 
[**CreateStripeConnectedAccountLink**](StripeCustomConnectApi.md#createstripeconnectedaccountlink) | **POST** /api/v1.0/{appId}/customconnect/{stripeConnectedAccountId}/create-account-link | 
[**GetCustomConnect**](StripeCustomConnectApi.md#getcustomconnect) | **GET** /api/v1.0/{appId}/customconnect/{storeId} | 
[**GetVerificationStatus**](StripeCustomConnectApi.md#getverificationstatus) | **GET** /api/v1.0/{appId}/customconnect/verification-status | 
[**SetBankAccountBusinessType**](StripeCustomConnectApi.md#setbankaccountbusinesstype) | **POST** /api/v1.0/{appId}/customconnect/bank-account/{bankAccountId}/businesstype | 
[**StripeCustomConnectRefresh**](StripeCustomConnectApi.md#stripecustomconnectrefresh) | **GET** /api/v1.0/{appId}/customconnect/refresh-link | 
[**UpdateBankAccountDetails**](StripeCustomConnectApi.md#updatebankaccountdetails) | **POST** /api/v1.0/{appId}/customconnect/{bankAccountId}/update-bank-account-details | 
[**UpdatePayoutSchedule**](StripeCustomConnectApi.md#updatepayoutschedule) | **POST** /api/v1.0/{appId}/customconnect/update-payout-schedule/{stripeConnectedAccountId}/{interval} | 


<a name="createbankaccountandconnectedaccount"></a>
# **CreateBankAccountAndConnectedAccount**
> RestApiResultBankAccountDetail CreateBankAccountAndConnectedAccount (string appId, BankAccountCreate account)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateBankAccountAndConnectedAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var account = new BankAccountCreate(); // BankAccountCreate | 

            try
            {
                RestApiResultBankAccountDetail result = apiInstance.CreateBankAccountAndConnectedAccount(appId, account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.CreateBankAccountAndConnectedAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **account** | [**BankAccountCreate**](BankAccountCreate.md)|  | 

### Return type

[**RestApiResultBankAccountDetail**](RestApiResultBankAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstripeconnectedaccount"></a>
# **CreateStripeConnectedAccount**
> RestApiResultStripeConnectedAccount CreateStripeConnectedAccount (string appId, int? bankAccountId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateStripeConnectedAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 

            try
            {
                RestApiResultStripeConnectedAccount result = apiInstance.CreateStripeConnectedAccount(appId, bankAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.CreateStripeConnectedAccount: " + e.Message );
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

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstripeconnectedaccountlink"></a>
# **CreateStripeConnectedAccountLink**
> RestApiResultStripeConnectedAccount CreateStripeConnectedAccountLink (string appId, string stripeConnectedAccountId, StripeAccountLinkRequest stripeAccountLinkRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateStripeConnectedAccountLinkExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var stripeConnectedAccountId = stripeConnectedAccountId_example;  // string | 
            var stripeAccountLinkRequest = new StripeAccountLinkRequest(); // StripeAccountLinkRequest | 

            try
            {
                RestApiResultStripeConnectedAccount result = apiInstance.CreateStripeConnectedAccountLink(appId, stripeConnectedAccountId, stripeAccountLinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.CreateStripeConnectedAccountLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **stripeConnectedAccountId** | **string**|  | 
 **stripeAccountLinkRequest** | [**StripeAccountLinkRequest**](StripeAccountLinkRequest.md)|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomconnect"></a>
# **GetCustomConnect**
> RestApiArrayResultStripeCustomConnectedAccount GetCustomConnect (int? storeId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCustomConnectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var storeId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultStripeCustomConnectedAccount result = apiInstance.GetCustomConnect(storeId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.GetCustomConnect: " + e.Message );
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

### Return type

[**RestApiArrayResultStripeCustomConnectedAccount**](RestApiArrayResultStripeCustomConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> RestApiResultStripeConnectedAccount GetVerificationStatus (string appId, string stripeConnectedAccountId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVerificationStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var stripeConnectedAccountId = stripeConnectedAccountId_example;  // string | 

            try
            {
                RestApiResultStripeConnectedAccount result = apiInstance.GetVerificationStatus(appId, stripeConnectedAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.GetVerificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **stripeConnectedAccountId** | **string**|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbankaccountbusinesstype"></a>
# **SetBankAccountBusinessType**
> RestApiResultBankAccountDetail SetBankAccountBusinessType (string appId, int? bankAccountId, string businessType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetBankAccountBusinessTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var businessType = businessType_example;  // string | 

            try
            {
                RestApiResultBankAccountDetail result = apiInstance.SetBankAccountBusinessType(appId, bankAccountId, businessType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.SetBankAccountBusinessType: " + e.Message );
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
 **businessType** | **string**|  | 

### Return type

[**RestApiResultBankAccountDetail**](RestApiResultBankAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stripecustomconnectrefresh"></a>
# **StripeCustomConnectRefresh**
> Object StripeCustomConnectRefresh (int? linkRequestId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StripeCustomConnectRefreshExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var linkRequestId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                Object result = apiInstance.StripeCustomConnectRefresh(linkRequestId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.StripeCustomConnectRefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkRequestId** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebankaccountdetails"></a>
# **UpdateBankAccountDetails**
> RestApiResultStripeConnectedAccount UpdateBankAccountDetails (string appId, int? bankAccountId, BankAccountDetailsUpdateRequest updateRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateBankAccountDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var updateRequest = new BankAccountDetailsUpdateRequest(); // BankAccountDetailsUpdateRequest | 

            try
            {
                RestApiResultStripeConnectedAccount result = apiInstance.UpdateBankAccountDetails(appId, bankAccountId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.UpdateBankAccountDetails: " + e.Message );
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
 **updateRequest** | [**BankAccountDetailsUpdateRequest**](BankAccountDetailsUpdateRequest.md)|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepayoutschedule"></a>
# **UpdatePayoutSchedule**
> RestApiResultModelBase UpdatePayoutSchedule (string appId, string stripeConnectedAccountId, string interval)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdatePayoutScheduleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectApi();
            var appId = appId_example;  // string | 
            var stripeConnectedAccountId = stripeConnectedAccountId_example;  // string | 
            var interval = interval_example;  // string | 

            try
            {
                RestApiResultModelBase result = apiInstance.UpdatePayoutSchedule(appId, stripeConnectedAccountId, interval);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.UpdatePayoutSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **stripeConnectedAccountId** | **string**|  | 
 **interval** | **string**|  | 

### Return type

[**RestApiResultModelBase**](RestApiResultModelBase.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

