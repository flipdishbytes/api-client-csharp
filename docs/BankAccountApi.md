# IO.Swagger.Api.BankAccountApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachBankAccountToStore**](BankAccountApi.md#attachbankaccounttostore) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/store/{storeId} | [PRIVATE API] Attach Bank Account to Store
[**CreateBankAccount**](BankAccountApi.md#createbankaccount) | **POST** /api/v1.0/{appId}/bankaccounts | Create a new Bank Account and attach to this App
[**DeleteBankAccount**](BankAccountApi.md#deletebankaccount) | **DELETE** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | Delete BankAccount
[**GetBankAccountById**](BankAccountApi.md#getbankaccountbyid) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | Get BankAccount Detail by Id
[**GetBankAccounts**](BankAccountApi.md#getbankaccounts) | **GET** /api/v1.0/{appId}/bankaccounts | Get List of BankAccounts for WL
[**GetCountriesWithFieldDefinitions**](BankAccountApi.md#getcountrieswithfielddefinitions) | **GET** /api/v1.0/{appId}/bankaccounts/countries-field-definitions | Get bank account fields definitions
[**GetFieldDefinitions**](BankAccountApi.md#getfielddefinitions) | **GET** /api/v1.0/{appId}/bankaccounts/field-definitions | Get bank account fields definitions
[**UpdateBankAccount**](BankAccountApi.md#updatebankaccount) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | Update BankAccount
[**UpdateBankAccountState**](BankAccountApi.md#updatebankaccountstate) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/state/{state} | [PRIVATE API] Update State of Bank Account


<a name="attachbankaccounttostore"></a>
# **AttachBankAccountToStore**
> void AttachBankAccountToStore (string appId, int? bankAccountId, int? storeId)

[PRIVATE API] Attach Bank Account to Store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var bankAccountId = 56;  // int? | Id of account to be updated
            var storeId = 56;  // int? | Store to be attached to Bank account

            try
            {
                // [PRIVATE API] Attach Bank Account to Store
                apiInstance.AttachBankAccountToStore(appId, bankAccountId, storeId);
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
 **bankAccountId** | **int?**| Id of account to be updated | 
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

Create a new Bank Account and attach to this App

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
                // Create a new Bank Account and attach to this App
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
> void DeleteBankAccount (string appId, int? bankAccountId)

Delete BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var bankAccountId = 56;  // int? | Id of account to be marked as deleted

            try
            {
                // Delete BankAccount
                apiInstance.DeleteBankAccount(appId, bankAccountId);
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
 **bankAccountId** | **int?**| Id of account to be marked as deleted | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccountbyid"></a>
# **GetBankAccountById**
> RestApiResultBankAccountDetail GetBankAccountById (int? bankAccountId, string appId)

Get BankAccount Detail by Id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBankAccountByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var bankAccountId = 56;  // int? | Id of account
            var appId = appId_example;  // string | 

            try
            {
                // Get BankAccount Detail by Id
                RestApiResultBankAccountDetail result = apiInstance.GetBankAccountById(bankAccountId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetBankAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankAccountId** | **int?**| Id of account | 
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

Get List of BankAccounts for WL

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
                // Get List of BankAccounts for WL
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

<a name="getcountrieswithfielddefinitions"></a>
# **GetCountriesWithFieldDefinitions**
> RestApiArrayResultCountryWithAccountFieldsDefinitions GetCountriesWithFieldDefinitions (string appId)

Get bank account fields definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountriesWithFieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get bank account fields definitions
                RestApiArrayResultCountryWithAccountFieldsDefinitions result = apiInstance.GetCountriesWithFieldDefinitions(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetCountriesWithFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultCountryWithAccountFieldsDefinitions**](RestApiArrayResultCountryWithAccountFieldsDefinitions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfielddefinitions"></a>
# **GetFieldDefinitions**
> RestApiResultAccountFieldsDefinitions GetFieldDefinitions (string appId)

Get bank account fields definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get bank account fields definitions
                RestApiResultAccountFieldsDefinitions result = apiInstance.GetFieldDefinitions(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**RestApiResultAccountFieldsDefinitions**](RestApiResultAccountFieldsDefinitions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebankaccount"></a>
# **UpdateBankAccount**
> void UpdateBankAccount (string appId, int? bankAccountId, BankAccountCreate account)

Update BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var bankAccountId = 56;  // int? | Id of account to be updated
            var account = new BankAccountCreate(); // BankAccountCreate | Details to update account with

            try
            {
                // Update BankAccount
                apiInstance.UpdateBankAccount(appId, bankAccountId, account);
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
 **bankAccountId** | **int?**| Id of account to be updated | 
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
> void UpdateBankAccountState (string appId, int? bankAccountId, string state, string reason)

[PRIVATE API] Update State of Bank Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var bankAccountId = 56;  // int? | Id of account to be updated
            var state = state_example;  // string | New state
            var reason = reason_example;  // string | Reason for state change, Mandatory for rejections

            try
            {
                // [PRIVATE API] Update State of Bank Account
                apiInstance.UpdateBankAccountState(appId, bankAccountId, state, reason);
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
 **bankAccountId** | **int?**| Id of account to be updated | 
 **state** | **string**| New state | 
 **reason** | **string**| Reason for state change, Mandatory for rejections | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

