# Flipdish.Api.AccountsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerSignUpQuestion**](AccountsApi.md#answersignupquestion) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/answer | Answer a signup question
[**ChangePassword**](AccountsApi.md#changepassword) | **PUT** /api/v1.0/accounts/password | Change password
[**ChangePasswordWithPin**](AccountsApi.md#changepasswordwithpin) | **PUT** /api/v1.0/accounts/password/pin | Change password
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /api/v1.0/accounts | Create account with email address and store name
[**GetAccountDetails**](AccountsApi.md#getaccountdetails) | **GET** /api/v1.0/accounts | Gets the current account detail
[**GetLocalisedTimeZones**](AccountsApi.md#getlocalisedtimezones) | **GET** /api/v1.0/accounts/timezones | [PRIVATE API] Get timezones localised to users language
[**Login**](AccountsApi.md#login) | **POST** /api/v1.0/accounts/login | Login with username and password
[**LoginWithPin**](AccountsApi.md#loginwithpin) | **POST** /api/v1.0/accounts/login/pin | Login with username and password
[**Logout**](AccountsApi.md#logout) | **POST** /api/v1.0/accounts/logout | Log out. It removes Flipdish authorization Cookie.
[**PasswordResetWithToken**](AccountsApi.md#passwordresetwithtoken) | **POST** /api/v1.0/accounts/password | Reset password with token.
[**RequestLoginPin**](AccountsApi.md#requestloginpin) | **POST** /api/v1.0/accounts/pin | Request login PIN. The server sends the PIN to the email address.
[**RequestPasswordReset**](AccountsApi.md#requestpasswordreset) | **POST** /api/v1.0/accounts/passwordreset | Request password reset. Flipdish system will send a token via email.
[**SkipSignupStep**](AccountsApi.md#skipsignupstep) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/skip | Skip a signup question
[**UpdateAccount**](AccountsApi.md#updateaccount) | **PUT** /api/v1.0/accounts | Update account with name and language


<a name="answersignupquestion"></a>
# **AnswerSignUpQuestion**
> void AnswerSignUpQuestion (string signupStepAction, int? answerId)

Answer a signup question

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AnswerSignUpQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var signupStepAction = signupStepAction_example;  // string | Signup step action
            var answerId = 56;  // int? | Identifier of the answer

            try
            {
                // Answer a signup question
                apiInstance.AnswerSignUpQuestion(signupStepAction, answerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AnswerSignUpQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signupStepAction** | **string**| Signup step action | 
 **answerId** | **int?**| Identifier of the answer | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePasswordModel changePasswordModel)

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
                apiInstance.ChangePassword(changePasswordModel);
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepasswordwithpin"></a>
# **ChangePasswordWithPin**
> void ChangePasswordWithPin (SetPasswordWithPinModel changePasswordModel)

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
    public class ChangePasswordWithPinExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var changePasswordModel = new SetPasswordWithPinModel(); // SetPasswordWithPinModel | Change password model

            try
            {
                // Change password
                apiInstance.ChangePasswordWithPin(changePasswordModel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ChangePasswordWithPin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changePasswordModel** | [**SetPasswordWithPinModel**](SetPasswordWithPinModel.md)| Change password model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaccount"></a>
# **CreateAccount**
> void CreateAccount (CreateAccountModel createAccountModel)

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
                apiInstance.CreateAccount(createAccountModel);
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountdetails"></a>
# **GetAccountDetails**
> RestApiResultAccountDetail GetAccountDetails ()

Gets the current account detail

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
                // Gets the current account detail
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

<a name="getlocalisedtimezones"></a>
# **GetLocalisedTimeZones**
> RestApiArrayResultLocalisedTimeZone GetLocalisedTimeZones ()

[PRIVATE API] Get timezones localised to users language

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLocalisedTimeZonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // [PRIVATE API] Get timezones localised to users language
                RestApiArrayResultLocalisedTimeZone result = apiInstance.GetLocalisedTimeZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetLocalisedTimeZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiArrayResultLocalisedTimeZone**](RestApiArrayResultLocalisedTimeZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> void Login (LoginModel loginModel)

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
                apiInstance.Login(loginModel);
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginwithpin"></a>
# **LoginWithPin**
> void LoginWithPin (LoginWithPinModel loginModel)

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
    public class LoginWithPinExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var loginModel = new LoginWithPinModel(); // LoginWithPinModel | Login model

            try
            {
                // Login with username and password
                apiInstance.LoginWithPin(loginModel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.LoginWithPin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginModel** | [**LoginWithPinModel**](LoginWithPinModel.md)| Login model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout ()

Log out. It removes Flipdish authorization Cookie.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                // Log out. It removes Flipdish authorization Cookie.
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordresetwithtoken"></a>
# **PasswordResetWithToken**
> void PasswordResetWithToken (PasswordResetModel passwordResetModel)

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
                apiInstance.PasswordResetWithToken(passwordResetModel);
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestloginpin"></a>
# **RequestLoginPin**
> RequestLoginPinResposne RequestLoginPin (RequestLoginPinModel requestLoginPinRequest)

Request login PIN. The server sends the PIN to the email address.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RequestLoginPinExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var requestLoginPinRequest = new RequestLoginPinModel(); // RequestLoginPinModel | Request login PIN request

            try
            {
                // Request login PIN. The server sends the PIN to the email address.
                RequestLoginPinResposne result = apiInstance.RequestLoginPin(requestLoginPinRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RequestLoginPin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestLoginPinRequest** | [**RequestLoginPinModel**](RequestLoginPinModel.md)| Request login PIN request | 

### Return type

[**RequestLoginPinResposne**](RequestLoginPinResposne.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> void RequestPasswordReset (RequestPasswordResetModel requestPasswordResetModel)

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
            var requestPasswordResetModel = new RequestPasswordResetModel(); // RequestPasswordResetModel | Request password reset model

            try
            {
                // Request password reset. Flipdish system will send a token via email.
                apiInstance.RequestPasswordReset(requestPasswordResetModel);
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
 **requestPasswordResetModel** | [**RequestPasswordResetModel**](RequestPasswordResetModel.md)| Request password reset model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="skipsignupstep"></a>
# **SkipSignupStep**
> void SkipSignupStep (string signupStepAction)

Skip a signup question

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
            var signupStepAction = signupStepAction_example;  // string | Signup step action

            try
            {
                // Skip a signup question
                apiInstance.SkipSignupStep(signupStepAction);
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
 **signupStepAction** | **string**| Signup step action | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccount"></a>
# **UpdateAccount**
> void UpdateAccount (AccountDetailBase updateAccountModel)

Update account with name and language

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var updateAccountModel = new AccountDetailBase(); // AccountDetailBase | Update account model

            try
            {
                // Update account with name and language
                apiInstance.UpdateAccount(updateAccountModel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateAccountModel** | [**AccountDetailBase**](AccountDetailBase.md)| Update account model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

