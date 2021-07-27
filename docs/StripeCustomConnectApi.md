# Flipdish.Api.StripeCustomConnectApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBankAccountAndConnectedAccount**](StripeCustomConnectApi.md#createbankaccountandconnectedaccount) | **POST** /api/v1.0/{appId}/customconnect/bank-account | Create a new Bank Account and Stripe connected account
[**CreateStripeConnectedAccount**](StripeCustomConnectApi.md#createstripeconnectedaccount) | **POST** /api/v1.0/{appId}/customconnect/{bankAccountId}/create-update-account | Create or update a Stripe connected account associated with the bank account of bankAccountId
[**CreateStripeConnectedAccountLink**](StripeCustomConnectApi.md#createstripeconnectedaccountlink) | **POST** /api/v1.0/{appId}/customconnect/{stripeConnectedAccountId}/create-account-link | Gets a single-use Stripe URL for the given account
[**GetVerificationStatus**](StripeCustomConnectApi.md#getverificationstatus) | **GET** /api/v1.0/{appId}/customconnect/verification-status | Gets the current verification status of the given connected account
[**SetBankAccountBusinessType**](StripeCustomConnectApi.md#setbankaccountbusinesstype) | **POST** /api/v1.0/{appId}/customconnect/bank-account/{bankAccountId}/businesstype | Update bank account&#39;s BusinessType and create a Stripe Connected Account
[**StripeCustomConnectRefresh**](StripeCustomConnectApi.md#stripecustomconnectrefresh) | **GET** /api/v1.0/{appId}/customconnect/refresh-link | 
[**UpdateBankAccountDetails**](StripeCustomConnectApi.md#updatebankaccountdetails) | **POST** /api/v1.0/{appId}/customconnect/{bankAccountId}/update-bank-account-details | Update bank account details


<a name="createbankaccountandconnectedaccount"></a>
# **CreateBankAccountAndConnectedAccount**
> RestApiResultBankAccountDetail CreateBankAccountAndConnectedAccount (string appId, BankAccountCreate account)

Create a new Bank Account and Stripe connected account

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
            var appId = appId_example;  // string | App Name
            var account = new BankAccountCreate(); // BankAccountCreate | Account to be created

            try
            {
                // Create a new Bank Account and Stripe connected account
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
 **appId** | **string**| App Name | 
 **account** | [**BankAccountCreate**](BankAccountCreate.md)| Account to be created | 

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

Create or update a Stripe connected account associated with the bank account of bankAccountId

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
            var appId = appId_example;  // string | App Name Id
            var bankAccountId = 56;  // int? | Bank Account Id

            try
            {
                // Create or update a Stripe connected account associated with the bank account of bankAccountId
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
 **appId** | **string**| App Name Id | 
 **bankAccountId** | **int?**| Bank Account Id | 

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

Gets a single-use Stripe URL for the given account

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
            var appId = appId_example;  // string | App Name
            var stripeConnectedAccountId = stripeConnectedAccountId_example;  // string | Stripe Connected Account Id
            var stripeAccountLinkRequest = new StripeAccountLinkRequest(); // StripeAccountLinkRequest | 

            try
            {
                // Gets a single-use Stripe URL for the given account
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
 **appId** | **string**| App Name | 
 **stripeConnectedAccountId** | **string**| Stripe Connected Account Id | 
 **stripeAccountLinkRequest** | [**StripeAccountLinkRequest**](StripeAccountLinkRequest.md)|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> RestApiResultStripeConnectedAccount GetVerificationStatus (string appId, string stripeConnectedAccountId)

Gets the current verification status of the given connected account

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
                // Gets the current verification status of the given connected account
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

Update bank account's BusinessType and create a Stripe Connected Account

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
            var appId = appId_example;  // string | App Name
            var bankAccountId = 56;  // int? | Bank Account Id
            var businessType = businessType_example;  // string | Bank Account business type

            try
            {
                // Update bank account's BusinessType and create a Stripe Connected Account
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
 **appId** | **string**| App Name | 
 **bankAccountId** | **int?**| Bank Account Id | 
 **businessType** | **string**| Bank Account business type | 

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

Update bank account details

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
            var appId = appId_example;  // string | App Name Id
            var bankAccountId = 56;  // int? | Bank Account Id
            var updateRequest = new BankAccountDetailsUpdateRequest(); // BankAccountDetailsUpdateRequest | fields to be updated

            try
            {
                // Update bank account details
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
 **appId** | **string**| App Name Id | 
 **bankAccountId** | **int?**| Bank Account Id | 
 **updateRequest** | [**BankAccountDetailsUpdateRequest**](BankAccountDetailsUpdateRequest.md)| fields to be updated | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

