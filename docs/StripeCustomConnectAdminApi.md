# Flipdish.Api.StripeCustomConnectAdminApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InitializeBankAccountConnectedAccount**](StripeCustomConnectAdminApi.md#initializebankaccountconnectedaccount) | **POST** /api/v1.0/customconnect/initialize-bank-account | Create a new Bank Account and Stripe connected account


<a name="initializebankaccountconnectedaccount"></a>
# **InitializeBankAccountConnectedAccount**
> RestApiResultBankAccountDetail InitializeBankAccountConnectedAccount (List<int?> accounts)

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
    public class InitializeBankAccountConnectedAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StripeCustomConnectAdminApi();
            var accounts = ;  // List<int?> | Accounts to be initialized in stripe

            try
            {
                // Create a new Bank Account and Stripe connected account
                RestApiResultBankAccountDetail result = apiInstance.InitializeBankAccountConnectedAccount(accounts);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectAdminApi.InitializeBankAccountConnectedAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accounts** | **List&lt;int?&gt;**| Accounts to be initialized in stripe | 

### Return type

[**RestApiResultBankAccountDetail**](RestApiResultBankAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

