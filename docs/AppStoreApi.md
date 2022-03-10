# Flipdish.Api.AppStoreApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppVerificationUpdate**](AppStoreApi.md#appverificationupdate) | **PUT** /api/v1.0/appstore/apps/{appStoreAppId}/verification | Update App store app verification
[**CreateAppStoreApp**](AppStoreApi.md#createappstoreapp) | **POST** /api/v1.0/appstore/apps | Create App store app
[**DeleteAppStoreApp**](AppStoreApi.md#deleteappstoreapp) | **DELETE** /api/v1.0/appstore/apps/{appStoreAppId} | Delete App store app
[**GetAppStoreApp**](AppStoreApi.md#getappstoreapp) | **GET** /api/v1.0/appstore/apps/{appStoreAppId} | Get App store app
[**GetAppStoreApps**](AppStoreApi.md#getappstoreapps) | **GET** /api/v1.0/appstore/apps | Get list of App store app summaries
[**UpdateAppStoreApp**](AppStoreApi.md#updateappstoreapp) | **PUT** /api/v1.0/appstore/apps/{appStoreAppId} | Update App store app
[**UploadAppStoreAppLogo**](AppStoreApi.md#uploadappstoreapplogo) | **POST** /api/v1.0/appstore/apps/{appStoreAppId}/logo | Upload the App store app logo \\ icon


<a name="appverificationupdate"></a>
# **AppVerificationUpdate**
> void AppVerificationUpdate (string appStoreAppId, string verificationStatus)

Update App store app verification

[BETA - this endpoint is under development, do not use it in your production system][Note: Only Flipdish staff can verify apps]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AppVerificationUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var verificationStatus = verificationStatus_example;  // string | New verification status

            try
            {
                // Update App store app verification
                apiInstance.AppVerificationUpdate(appStoreAppId, verificationStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.AppVerificationUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**| App store app id | 
 **verificationStatus** | **string**| New verification status | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoreapp"></a>
# **CreateAppStoreApp**
> RestApiResultAppStoreApp CreateAppStoreApp (CreateAppStoreApp createAppStoreApp)

Create App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var createAppStoreApp = new CreateAppStoreApp(); // CreateAppStoreApp | App store app

            try
            {
                // Create App store app
                RestApiResultAppStoreApp result = apiInstance.CreateAppStoreApp(createAppStoreApp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.CreateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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
> RestApiStringResult DeleteAppStoreApp (string appStoreAppId)

Delete App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Delete App store app
                RestApiStringResult result = apiInstance.DeleteAppStoreApp(appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.DeleteAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreapp"></a>
# **GetAppStoreApp**
> AppStoreApp GetAppStoreApp (string appStoreAppId)

Get App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Get App store app
                AppStoreApp result = apiInstance.GetAppStoreApp(appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.GetAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**AppStoreApp**](AppStoreApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreapps"></a>
# **GetAppStoreApps**
> RestApiPaginationResultAppStoreAppSummary GetAppStoreApps (string search, int? page = null, int? limit = null, bool? excludeNotOwned = null)

Get list of App store app summaries

Only returns verified applications [BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var search = search_example;  // string | Query App store app name
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var excludeNotOwned = true;  // bool? | Exclude App store apps that user is not the owner off (optional) 

            try
            {
                // Get list of App store app summaries
                RestApiPaginationResultAppStoreAppSummary result = apiInstance.GetAppStoreApps(search, page, limit, excludeNotOwned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.GetAppStoreApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Query App store app name | 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **excludeNotOwned** | **bool?**| Exclude App store apps that user is not the owner off | [optional] 

### Return type

[**RestApiPaginationResultAppStoreAppSummary**](RestApiPaginationResultAppStoreAppSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreapp"></a>
# **UpdateAppStoreApp**
> void UpdateAppStoreApp (string appStoreAppId, UpdateAppStoreApp appStoreApp)

Update App store app

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var appStoreApp = new UpdateAppStoreApp(); // UpdateAppStoreApp | Update App store app

            try
            {
                // Update App store app
                apiInstance.UpdateAppStoreApp(appStoreAppId, appStoreApp);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.UpdateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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
> void UploadAppStoreAppLogo (string appStoreAppId, System.IO.Stream image)

Upload the App store app logo \\ icon

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadAppStoreAppLogoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var image = new System.IO.Stream(); // System.IO.Stream | App Store App Logo

            try
            {
                // Upload the App store app logo \\ icon
                apiInstance.UploadAppStoreAppLogo(appStoreAppId, image);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.UploadAppStoreAppLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

