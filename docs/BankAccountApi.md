# Flipdish.Api.BankAccountApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachBankAccountToStore**](BankAccountApi.md#attachbankaccounttostore) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/store/{storeId} | 
[**CreateBankAccount**](BankAccountApi.md#createbankaccount) | **POST** /api/v1.0/{appId}/bankaccounts | 
[**DeleteBankAccount**](BankAccountApi.md#deletebankaccount) | **DELETE** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | 
[**GetBankAccountById**](BankAccountApi.md#getbankaccountbyid) | **GET** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | 
[**GetBankAccounts**](BankAccountApi.md#getbankaccounts) | **GET** /api/v1.0/{appId}/bankaccounts | 
[**GetCountriesWithFieldDefinitions**](BankAccountApi.md#getcountrieswithfielddefinitions) | **GET** /api/v1.0/{appId}/bankaccounts/countries-field-definitions | 
[**GetFieldDefinitions**](BankAccountApi.md#getfielddefinitions) | **GET** /api/v1.0/{appId}/bankaccounts/field-definitions | 
[**UpdateBankAccount**](BankAccountApi.md#updatebankaccount) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId} | 
[**UpdateBankAccountState**](BankAccountApi.md#updatebankaccountstate) | **POST** /api/v1.0/{appId}/bankaccounts/{bankAccountId}/state/{state} | 


<a name="attachbankaccounttostore"></a>
# **AttachBankAccountToStore**
> void AttachBankAccountToStore (string appId, int? bankAccountId, int? storeId)



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
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **storeId** | **int?**|  | 

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
            var appId = appId_example;  // string | 
            var account = new BankAccountCreate(); // BankAccountCreate | 

            try
            {
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

<a name="deletebankaccount"></a>
# **DeleteBankAccount**
> void DeleteBankAccount (string appId, int? bankAccountId)



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
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBankAccountByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountApi();
            var bankAccountId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
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
 **bankAccountId** | **int?**|  | 
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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

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
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var account = new BankAccountCreate(); // BankAccountCreate | 

            try
            {
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
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **account** | [**BankAccountCreate**](BankAccountCreate.md)|  | 

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
            var appId = appId_example;  // string | 
            var bankAccountId = 56;  // int? | 
            var state = state_example;  // string | 
            var reason = reason_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 
 **bankAccountId** | **int?**|  | 
 **state** | **string**|  | 
 **reason** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

