# Flipdish.Api.AccountsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerSignUpQuestion**](AccountsApi.md#answersignupquestion) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/answer | 
[**ChangePassword**](AccountsApi.md#changepassword) | **PUT** /api/v1.0/accounts/password | 
[**ChangePasswordWithPin**](AccountsApi.md#changepasswordwithpin) | **PUT** /api/v1.0/accounts/password/pin | 
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /api/v1.0/accounts | 
[**GetAccountDetails**](AccountsApi.md#getaccountdetails) | **GET** /api/v1.0/accounts | 
[**GetLocalisedTimeZones**](AccountsApi.md#getlocalisedtimezones) | **GET** /api/v1.0/accounts/timezones | 
[**Login**](AccountsApi.md#login) | **POST** /api/v1.0/accounts/login | 
[**LoginSso**](AccountsApi.md#loginsso) | **POST** /api/v1.0/accounts/login/sso | 
[**LoginWithPin**](AccountsApi.md#loginwithpin) | **POST** /api/v1.0/accounts/login/pin | 
[**Logout**](AccountsApi.md#logout) | **POST** /api/v1.0/accounts/logout | 
[**PasswordResetWithToken**](AccountsApi.md#passwordresetwithtoken) | **POST** /api/v1.0/accounts/password | 
[**RecaptchaValidate**](AccountsApi.md#recaptchavalidate) | **POST** /api/v1.0/accounts/recaptcha | 
[**RequestLoginPin**](AccountsApi.md#requestloginpin) | **POST** /api/v1.0/accounts/pin | 
[**RequestPasswordReset**](AccountsApi.md#requestpasswordreset) | **POST** /api/v1.0/accounts/passwordreset | 
[**SendPinForPasswordReset**](AccountsApi.md#sendpinforpasswordreset) | **POST** /api/v1.0/accounts/password/resetpin | 
[**SkipSignupStep**](AccountsApi.md#skipsignupstep) | **POST** /api/v1.0/accounts/signupstep/{signupStepAction}/skip | 
[**UpdateAccount**](AccountsApi.md#updateaccount) | **PUT** /api/v1.0/accounts | 


<a name="answersignupquestion"></a>
# **AnswerSignUpQuestion**
> void AnswerSignUpQuestion (string signupStepAction, int? answerId)



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
            var signupStepAction = signupStepAction_example;  // string | 
            var answerId = 56;  // int? | 

            try
            {
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
 **signupStepAction** | **string**|  | 
 **answerId** | **int?**|  | 

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
            var changePasswordModel = new ChangePasswordModel(); // ChangePasswordModel | 

            try
            {
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
 **changePasswordModel** | [**ChangePasswordModel**](ChangePasswordModel.md)|  | 

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
            var changePasswordModel = new SetPasswordWithPinModel(); // SetPasswordWithPinModel | 

            try
            {
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
 **changePasswordModel** | [**SetPasswordWithPinModel**](SetPasswordWithPinModel.md)|  | 

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
            var createAccountModel = new CreateAccountModel(); // CreateAccountModel | 

            try
            {
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
 **createAccountModel** | [**CreateAccountModel**](CreateAccountModel.md)|  | 

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

<a name="getlocalisedtimezones"></a>
# **GetLocalisedTimeZones**
> RestApiArrayResultLocalisedTimeZone GetLocalisedTimeZones ()



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
            var loginModel = new LoginModel(); // LoginModel | 

            try
            {
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
 **loginModel** | [**LoginModel**](LoginModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginsso"></a>
# **LoginSso**
> void LoginSso ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LoginSsoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();

            try
            {
                apiInstance.LoginSso();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.LoginSso: " + e.Message );
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

<a name="loginwithpin"></a>
# **LoginWithPin**
> void LoginWithPin (LoginWithPinModel loginModel)



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
            var loginModel = new LoginWithPinModel(); // LoginWithPinModel | 

            try
            {
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
 **loginModel** | [**LoginWithPinModel**](LoginWithPinModel.md)|  | 

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
            var passwordResetModel = new PasswordResetModel(); // PasswordResetModel | 

            try
            {
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
 **passwordResetModel** | [**PasswordResetModel**](PasswordResetModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recaptchavalidate"></a>
# **RecaptchaValidate**
> void RecaptchaValidate (string token)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RecaptchaValidateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var token = token_example;  // string | 

            try
            {
                apiInstance.RecaptchaValidate(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RecaptchaValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestloginpin"></a>
# **RequestLoginPin**
> RequestLoginPinResponse RequestLoginPin (RequestLoginPinModel requestLoginPinRequest)



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
            var requestLoginPinRequest = new RequestLoginPinModel(); // RequestLoginPinModel | 

            try
            {
                RequestLoginPinResponse result = apiInstance.RequestLoginPin(requestLoginPinRequest);
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
 **requestLoginPinRequest** | [**RequestLoginPinModel**](RequestLoginPinModel.md)|  | 

### Return type

[**RequestLoginPinResponse**](RequestLoginPinResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> void RequestPasswordReset (RequestPasswordResetModel requestPasswordResetModel)



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
            var requestPasswordResetModel = new RequestPasswordResetModel(); // RequestPasswordResetModel | 

            try
            {
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
 **requestPasswordResetModel** | [**RequestPasswordResetModel**](RequestPasswordResetModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendpinforpasswordreset"></a>
# **SendPinForPasswordReset**
> RequestPasswordResetPinResponse SendPinForPasswordReset (RequestPasswordResetModel requestPasswordResetRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SendPinForPasswordResetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var requestPasswordResetRequest = new RequestPasswordResetModel(); // RequestPasswordResetModel | 

            try
            {
                RequestPasswordResetPinResponse result = apiInstance.SendPinForPasswordReset(requestPasswordResetRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.SendPinForPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestPasswordResetRequest** | [**RequestPasswordResetModel**](RequestPasswordResetModel.md)|  | 

### Return type

[**RequestPasswordResetPinResponse**](RequestPasswordResetPinResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="skipsignupstep"></a>
# **SkipSignupStep**
> void SkipSignupStep (string signupStepAction)



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
 **signupStepAction** | **string**|  | 

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
            var updateAccountModel = new AccountDetailBase(); // AccountDetailBase | 

            try
            {
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
 **updateAccountModel** | [**AccountDetailBase**](AccountDetailBase.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

