# IO.Swagger.Api.AppStoreDeveloperApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppVerificationUpdate**](AppStoreDeveloperApi.md#appverificationupdate) | **PUT** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/verification | Update App store app verification
[**CreateAppStoreApp**](AppStoreDeveloperApi.md#createappstoreapp) | **POST** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps | Create App store app
[**DeleteAppStoreApp**](AppStoreDeveloperApi.md#deleteappstoreapp) | **DELETE** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId} | Delete App store app
[**UpdateAppStoreApp**](AppStoreDeveloperApi.md#updateappstoreapp) | **PUT** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId} | Update App store app
[**UploadAppStoreAppLogo**](AppStoreDeveloperApi.md#uploadappstoreapplogo) | **POST** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/logo | Upload the App store app logo \\ icon


<a name="appverificationupdate"></a>
# **AppVerificationUpdate**
> void AppVerificationUpdate (string oauthAppId, string appStoreAppId, string verificationStatus)

Update App store app verification

[BETA - this endpoint is under development, do not use it in your production system][Note: Only Flipdish staff can verify apps]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppVerificationUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var verificationStatus = verificationStatus_example;  // string | New verification status

            try
            {
                // Update App store app verification
                apiInstance.AppVerificationUpdate(oauthAppId, appStoreAppId, verificationStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.AppVerificationUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appStoreAppId** | **string**| App store app id | 
 **verificationStatus** | **string**| New verification status | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoreapp"></a>
# **CreateAppStoreApp**
> RestApiResultAppStoreApp CreateAppStoreApp (string oauthAppId, CreateAppStoreApp createAppStoreApp)

Create App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var createAppStoreApp = new CreateAppStoreApp(); // CreateAppStoreApp | App store app

            try
            {
                // Create App store app
                RestApiResultAppStoreApp result = apiInstance.CreateAppStoreApp(oauthAppId, createAppStoreApp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.CreateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **createAppStoreApp** | [**CreateAppStoreApp**](CreateAppStoreApp.md)| App store app | 

### Return type

[**RestApiResultAppStoreApp**](RestApiResultAppStoreApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreapp"></a>
# **DeleteAppStoreApp**
> RestApiStringResult DeleteAppStoreApp (string oauthAppId, string appStoreAppId)

Delete App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Delete App store app
                RestApiStringResult result = apiInstance.DeleteAppStoreApp(oauthAppId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.DeleteAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreapp"></a>
# **UpdateAppStoreApp**
> void UpdateAppStoreApp (string oauthAppId, string appStoreAppId, UpdateAppStoreApp appStoreApp)

Update App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var appStoreApp = new UpdateAppStoreApp(); // UpdateAppStoreApp | Update App store app

            try
            {
                // Update App store app
                apiInstance.UpdateAppStoreApp(oauthAppId, appStoreAppId, appStoreApp);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.UpdateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appStoreAppId** | **string**| App store app id | 
 **appStoreApp** | [**UpdateAppStoreApp**](UpdateAppStoreApp.md)| Update App store app | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadappstoreapplogo"></a>
# **UploadAppStoreAppLogo**
> void UploadAppStoreAppLogo (string oauthAppId, string appStoreAppId, System.IO.Stream image)

Upload the App store app logo \\ icon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadAppStoreAppLogoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var image = new System.IO.Stream(); // System.IO.Stream | App Store App Logo

            try
            {
                // Upload the App store app logo \\ icon
                apiInstance.UploadAppStoreAppLogo(oauthAppId, appStoreAppId, image);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.UploadAppStoreAppLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appStoreAppId** | **string**| App store app id | 
 **image** | **System.IO.Stream**| App Store App Logo | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

