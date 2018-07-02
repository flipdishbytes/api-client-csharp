# Flipdish.Api.AccountsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](AccountsApi.md#changepassword) | **PUT** /api/v1.0/accounts/password | Change password
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /api/v1.0/accounts | Create account with email address and store name
[**GetAccountDetails**](AccountsApi.md#getaccountdetails) | **GET** /api/v1.0/accounts | 
[**Login**](AccountsApi.md#login) | **POST** /api/v1.0/accounts/login | Login with username and password
[**PasswordResetWithToken**](AccountsApi.md#passwordresetwithtoken) | **POST** /api/v1.0/accounts/password | Reset password with token.
[**RequestPasswordReset**](AccountsApi.md#requestpasswordreset) | **GET** /api/v1.0/accounts/password | Request password reset. Flipdish system will send a token via email.
[**SkipSignupStep**](AccountsApi.md#skipsignupstep) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/skip | 
[**SkipSignupStep_0**](AccountsApi.md#skipsignupstep_0) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/answer | 


<a name="changepassword"></a>
# **ChangePassword**
> Object ChangePassword (ChangePasswordModel changePasswordModel)

Change password

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var changePasswordModel = new ChangePasswordModel(); // ChangePasswordModel | Change password model

            try
            {
                // Change password
                Object result = apiInstance.ChangePassword(changePasswordModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changePasswordModel** | [**ChangePasswordModel**](ChangePasswordModel.md)| Change password model | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaccount"></a>
# **CreateAccount**
> Object CreateAccount (CreateAccountModel createAccountModel)

Create account with email address and store name

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var createAccountModel = new CreateAccountModel(); // CreateAccountModel | Create account model

            try
            {
                // Create account with email address and store name
                Object result = apiInstance.CreateAccount(createAccountModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createAccountModel** | [**CreateAccountModel**](CreateAccountModel.md)| Create account model | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountdetails"></a>
# **GetAccountDetails**
> RestApiResultAccountDetail GetAccountDetails ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAccountDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                RestApiResultAccountDetail result = apiInstance.GetAccountDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultAccountDetail**](RestApiResultAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> Object Login (LoginModel loginModel)

Login with username and password

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var loginModel = new LoginModel(); // LoginModel | Login model

            try
            {
                // Login with username and password
                Object result = apiInstance.Login(loginModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginModel** | [**LoginModel**](LoginModel.md)| Login model | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordresetwithtoken"></a>
# **PasswordResetWithToken**
> Object PasswordResetWithToken (PasswordResetModel passwordResetModel)

Reset password with token.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PasswordResetWithTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var passwordResetModel = new PasswordResetModel(); // PasswordResetModel | Password reset model

            try
            {
                // Reset password with token.
                Object result = apiInstance.PasswordResetWithToken(passwordResetModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.PasswordResetWithToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passwordResetModel** | [**PasswordResetModel**](PasswordResetModel.md)| Password reset model | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> Object RequestPasswordReset (string email)

Request password reset. Flipdish system will send a token via email.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RequestPasswordResetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var email = email_example;  // string | Email address

            try
            {
                // Request password reset. Flipdish system will send a token via email.
                Object result = apiInstance.RequestPasswordReset(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RequestPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email address | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="skipsignupstep"></a>
# **SkipSignupStep**
> RestApiResultAccountDetail SkipSignupStep (string signupStepAction)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SkipSignupStepExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var signupStepAction = signupStepAction_example;  // string | 

            try
            {
                RestApiResultAccountDetail result = apiInstance.SkipSignupStep(signupStepAction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.SkipSignupStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signupStepAction** | **string**|  | 

### Return type

[**RestApiResultAccountDetail**](RestApiResultAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="skipsignupstep_0"></a>
# **SkipSignupStep_0**
> RestApiResultAccountDetail SkipSignupStep_0 (string signupStepAction, int? answerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SkipSignupStep_0Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var signupStepAction = signupStepAction_example;  // string | 
            var answerId = 56;  // int? | 

            try
            {
                RestApiResultAccountDetail result = apiInstance.SkipSignupStep_0(signupStepAction, answerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.SkipSignupStep_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signupStepAction** | **string**|  | 
 **answerId** | **int?**|  | 

### Return type

[**RestApiResultAccountDetail**](RestApiResultAccountDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

