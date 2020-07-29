# Flipdish.Api.StripeCustomConnectApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStripeConnectedAccount**](StripeCustomConnectApi.md#createstripeconnectedaccount) | **POST** /api/v1.0/{appId}/customconnect/create-account | Get the Stripe connected account associated with the bank account of bankAccountId, if any
[**CreateStripeConnectedAccountLink**](StripeCustomConnectApi.md#createstripeconnectedaccountlink) | **POST** /api/v1.0/{appId}/customconnect/create-account-link | Gets a single-use Stripe URL for the given account
[**GetCustomConnectAccount**](StripeCustomConnectApi.md#getcustomconnectaccount) | **GET** /api/v1.0/{appId}/customconnect/account | Get the Stripe connected account associated with the bank account of bankAccountId, if any
[**GetVerificationStatus**](StripeCustomConnectApi.md#getverificationstatus) | **GET** /api/v1.0/{appId}/customconnect/verification-status | Gets the current verification status of the given connected account


<a name="createstripeconnectedaccount"></a>
# **CreateStripeConnectedAccount**
> RestApiResultStripeConnectedAccount CreateStripeConnectedAccount (string appId, int? bankAccountId)

Get the Stripe connected account associated with the bank account of bankAccountId, if any

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
                // Get the Stripe connected account associated with the bank account of bankAccountId, if any
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
> RestApiResultStripeConnectedAccount CreateStripeConnectedAccountLink (string appId, StripeAccountLinkRequest stripeAccountLinkRequest)

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
            var appId = appId_example;  // string | 
            var stripeAccountLinkRequest = new StripeAccountLinkRequest(); // StripeAccountLinkRequest | 

            try
            {
                // Gets a single-use Stripe URL for the given account
                RestApiResultStripeConnectedAccount result = apiInstance.CreateStripeConnectedAccountLink(appId, stripeAccountLinkRequest);
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
 **stripeAccountLinkRequest** | [**StripeAccountLinkRequest**](StripeAccountLinkRequest.md)|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomconnectaccount"></a>
# **GetCustomConnectAccount**
> RestApiResultStripeConnectedAccount GetCustomConnectAccount (string appId, int? bankAccountId)

Get the Stripe connected account associated with the bank account of bankAccountId, if any

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCustomConnectAccountExample
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
                // Get the Stripe connected account associated with the bank account of bankAccountId, if any
                RestApiResultStripeConnectedAccount result = apiInstance.GetCustomConnectAccount(appId, bankAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StripeCustomConnectApi.GetCustomConnectAccount: " + e.Message );
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

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> RestApiResultStripeConnectedAccount GetVerificationStatus (string appId, string stripeId)

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
            var stripeId = stripeId_example;  // string | 

            try
            {
                // Gets the current verification status of the given connected account
                RestApiResultStripeConnectedAccount result = apiInstance.GetVerificationStatus(appId, stripeId);
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
 **stripeId** | **string**|  | 

### Return type

[**RestApiResultStripeConnectedAccount**](RestApiResultStripeConnectedAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

