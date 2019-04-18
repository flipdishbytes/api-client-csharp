# Flipdish.Api.BankAccountApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachBankAccountToStore**](BankAccountApi.md#attachbankaccounttostore) | **POST** /api/v1.0/{appId}/bankaccounts/{accountId}/store/{storeId} | [PRIVATE API] Attach Bank Account to Store
[**CreateBankAccount**](BankAccountApi.md#createbankaccount) | **POST** /api/v1.0/{appId}/bankaccounts | [PRIVATE API] Create a new Bank Account and attach to this App
[**DeleteBankAccount**](BankAccountApi.md#deletebankaccount) | **DELETE** /api/v1.0/{appId}/bankaccounts/{id} | [PRIVATE API] Delete BankAccount
[**GetBankAccount**](BankAccountApi.md#getbankaccount) | **GET** /api/v1.0/{appId}/bankaccounts/{id} | [PRIVATE API] Get BankAccount Detail by Id
[**GetBankAccounts**](BankAccountApi.md#getbankaccounts) | **GET** /api/v1.0/{appId}/bankaccounts | [PRIVATE API] Get List of BankAccounts for WL
[**UpdateBankAccount**](BankAccountApi.md#updatebankaccount) | **POST** /api/v1.0/{appId}/bankaccounts/{id} | [PRIVATE API] Update BankAccount
[**UpdateBankAccountState**](BankAccountApi.md#updatebankaccountstate) | **POST** /api/v1.0/{appId}/bankaccounts/{accountId}/state/{state} | [PRIVATE API] Update State of Bank Account


<a name="attachbankaccounttostore"></a>
# **AttachBankAccountToStore**
> void AttachBankAccountToStore (string appId, int? accountId, int? storeId)

[PRIVATE API] Attach Bank Account to Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AttachBankAccountToStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name
            var accountId = 56;  // int? | Id of account to be updated
            var storeId = 56;  // int? | Store to be attached to Bank account

            try
            {
                // [PRIVATE API] Attach Bank Account to Store
                apiInstance.AttachBankAccountToStore(appId, accountId, storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.AttachBankAccountToStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name | 
 **accountId** | **int?**| Id of account to be updated | 
 **storeId** | **int?**| Store to be attached to Bank account | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbankaccount"></a>
# **CreateBankAccount**
> RestApiResultBankAccountDetail CreateBankAccount (string appId, BankAccountCreate account)

[PRIVATE API] Create a new Bank Account and attach to this App

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateBankAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name
            var account = new BankAccountCreate(); // BankAccountCreate | Account to be created

            try
            {
                // [PRIVATE API] Create a new Bank Account and attach to this App
                RestApiResultBankAccountDetail result = apiInstance.CreateBankAccount(appId, account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.CreateBankAccount: " + e.Message );
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

<a name="deletebankaccount"></a>
# **DeleteBankAccount**
> void DeleteBankAccount (string appId, int? id)

[PRIVATE API] Delete BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteBankAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name
            var id = 56;  // int? | Id of account to be marked as deleted

            try
            {
                // [PRIVATE API] Delete BankAccount
                apiInstance.DeleteBankAccount(appId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.DeleteBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name | 
 **id** | **int?**| Id of account to be marked as deleted | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccount"></a>
# **GetBankAccount**
> RestApiResultBankAccountDetail GetBankAccount (int? id, string appId)

[PRIVATE API] Get BankAccount Detail by Id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBankAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var id = 56;  // int? | Id of account
            var appId = appId_example;  // string | 

            try
            {
                // [PRIVATE API] Get BankAccount Detail by Id
                RestApiResultBankAccountDetail result = apiInstance.GetBankAccount(id, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of account | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultBankAccountDetail**](RestApiResultBankAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccounts"></a>
# **GetBankAccounts**
> RestApiArrayResultBankAccountSummary GetBankAccounts (string appId)

[PRIVATE API] Get List of BankAccounts for WL

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBankAccountsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name

            try
            {
                // [PRIVATE API] Get List of BankAccounts for WL
                RestApiArrayResultBankAccountSummary result = apiInstance.GetBankAccounts(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetBankAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name | 

### Return type

[**RestApiArrayResultBankAccountSummary**](RestApiArrayResultBankAccountSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebankaccount"></a>
# **UpdateBankAccount**
> void UpdateBankAccount (string appId, int? id, BankAccountCreate account)

[PRIVATE API] Update BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateBankAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name
            var id = 56;  // int? | Id of account to be updated
            var account = new BankAccountCreate(); // BankAccountCreate | Details to update account with

            try
            {
                // [PRIVATE API] Update BankAccount
                apiInstance.UpdateBankAccount(appId, id, account);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.UpdateBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name | 
 **id** | **int?**| Id of account to be updated | 
 **account** | [**BankAccountCreate**](BankAccountCreate.md)| Details to update account with | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebankaccountstate"></a>
# **UpdateBankAccountState**
> void UpdateBankAccountState (string appId, int? accountId, string state)

[PRIVATE API] Update State of Bank Account

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateBankAccountStateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | App Name
            var accountId = 56;  // int? | Id of account to be updated
            var state = state_example;  // string | 

            try
            {
                // [PRIVATE API] Update State of Bank Account
                apiInstance.UpdateBankAccountState(appId, accountId, state);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.UpdateBankAccountState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name | 
 **accountId** | **int?**| Id of account to be updated | 
 **state** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

