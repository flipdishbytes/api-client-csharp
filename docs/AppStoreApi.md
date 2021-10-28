# Flipdish.Api.AppStoreApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppVerificationUpdate**](AppStoreApi.md#appverificationupdate) | **PUT** /api/v1.0/appstore/apps/{appStoreAppId}/verification | Update app store app verification
[**CreateAppStoreApp**](AppStoreApi.md#createappstoreapp) | **POST** /api/v1.0/appstore/apps | Create app store app
[**DeleteAppStoreApp**](AppStoreApi.md#deleteappstoreapp) | **DELETE** /api/v1.0/appstore/apps/{appStoreAppId} | Delete app store app
[**GetAppStoreApp**](AppStoreApi.md#getappstoreapp) | **GET** /api/v1.0/appstore/apps/{appStoreAppId} | Get app store app details
[**GetAppStoreApps**](AppStoreApi.md#getappstoreapps) | **GET** /api/v1.0/appstore/apps | Get list of app store app summaries
[**UpdateAppStoreApp**](AppStoreApi.md#updateappstoreapp) | **PUT** /api/v1.0/appstore/apps/{appStoreAppId} | Update app store app
[**UploadAppStoreAppLogo**](AppStoreApi.md#uploadappstoreapplogo) | **POST** /api/v1.0/appstore/apps/{appStoreAppId}/logo | Upload the app store app logo \\ icon


<a name="appverificationupdate"></a>
# **AppVerificationUpdate**
> void AppVerificationUpdate (string appStoreAppId, string verificationStatus)

Update app store app verification

[BETA - this endpoint is under development, do not use it in your production system][Flipdish Admin access required]

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
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var verificationStatus = verificationStatus_example;  // string | New Verification Status

            try
            {
                // Update app store app verification
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
 **appStoreAppId** | **string**| App Store App Id | 
 **verificationStatus** | **string**| New Verification Status | 

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
> RestApiResultAppDetail CreateAppStoreApp (AppDetailBase appDetailBase)

Create app store app

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
            var appDetailBase = new AppDetailBase(); // AppDetailBase | App Store App Detail Base

            try
            {
                // Create app store app
                RestApiResultAppDetail result = apiInstance.CreateAppStoreApp(appDetailBase);
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
 **appDetailBase** | [**AppDetailBase**](AppDetailBase.md)| App Store App Detail Base | 

### Return type

[**RestApiResultAppDetail**](RestApiResultAppDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreapp"></a>
# **DeleteAppStoreApp**
> RestApiStringResult DeleteAppStoreApp (string appStoreAppId)

Delete app store app

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
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id

            try
            {
                // Delete app store app
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
 **appStoreAppId** | **string**| App Store App Id | 

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
> AppDetail GetAppStoreApp (string appStoreAppId)

Get app store app details

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
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id

            try
            {
                // Get app store app details
                AppDetail result = apiInstance.GetAppStoreApp(appStoreAppId);
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
 **appStoreAppId** | **string**| App Store App Id | 

### Return type

[**AppDetail**](AppDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreapps"></a>
# **GetAppStoreApps**
> RestApiPaginationResultAppSummary GetAppStoreApps (string search, int? page = null, int? limit = null, bool? excludeNotOwned = null)

Get list of app store app summaries

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
            var search = search_example;  // string | Query app store app name
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var excludeNotOwned = true;  // bool? | Exclude app store apps that user is not the owner off (optional) 

            try
            {
                // Get list of app store app summaries
                RestApiPaginationResultAppSummary result = apiInstance.GetAppStoreApps(search, page, limit, excludeNotOwned);
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
 **search** | **string**| Query app store app name | 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **excludeNotOwned** | **bool?**| Exclude app store apps that user is not the owner off | [optional] 

### Return type

[**RestApiPaginationResultAppSummary**](RestApiPaginationResultAppSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreapp"></a>
# **UpdateAppStoreApp**
> void UpdateAppStoreApp (string appStoreAppId, AppDetail appDetail)

Update app store app

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
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var appDetail = new AppDetail(); // AppDetail | App Store App Detail

            try
            {
                // Update app store app
                apiInstance.UpdateAppStoreApp(appStoreAppId, appDetail);
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
 **appStoreAppId** | **string**| App Store App Id | 
 **appDetail** | [**AppDetail**](AppDetail.md)| App Store App Detail | 

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

Upload the app store app logo \\ icon

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
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var image = new System.IO.Stream(); // System.IO.Stream | App Store App Logo

            try
            {
                // Upload the app store app logo \\ icon
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
 **appStoreAppId** | **string**| App Store App Id | 
 **image** | **System.IO.Stream**| App Store App Logo | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

