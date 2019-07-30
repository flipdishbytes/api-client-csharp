# Flipdish.Api.AppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApp**](AppsApi.md#getapp) | **GET** /api/v1.0/apps/{appId} | Get the application configuration
[**GetApps**](AppsApi.md#getapps) | **GET** /api/v1.0/apps | Get Apps
[**SetAppConfig**](AppsApi.md#setappconfig) | **POST** /api/v1.0/apps/{appId}/config | Set the application configuration
[**SetAppLanguages**](AppsApi.md#setapplanguages) | **POST** /api/v1.0/apps/{appId}/config/languages | Set the application languages
[**UploadAppLogo**](AppsApi.md#uploadapplogo) | **POST** /api/v1.0/apps/{appId}/logo | Set the application logo \\ icon


<a name="getapp"></a>
# **GetApp**
> RestApiResultApp GetApp (string appId)

Get the application configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier

            try
            {
                // Get the application configuration
                RestApiResultApp result = apiInstance.GetApp(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier | 

### Return type

[**RestApiResultApp**](RestApiResultApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapps"></a>
# **GetApps**
> RestApiPaginationResultApp GetApps (string nameFilter = null, int? page = null, int? limit = null)

Get Apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var nameFilter = nameFilter_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get Apps
                RestApiPaginationResultApp result = apiInstance.GetApps(nameFilter, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameFilter** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultApp**](RestApiPaginationResultApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setappconfig"></a>
# **SetAppConfig**
> RestApiResultApp SetAppConfig (string appId, AppConfigUpdateModel appConfigUpdate)

Set the application configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetAppConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier
            var appConfigUpdate = new AppConfigUpdateModel(); // AppConfigUpdateModel | Changes to the configuration

            try
            {
                // Set the application configuration
                RestApiResultApp result = apiInstance.SetAppConfig(appId, appConfigUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetAppConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier | 
 **appConfigUpdate** | [**AppConfigUpdateModel**](AppConfigUpdateModel.md)| Changes to the configuration | 

### Return type

[**RestApiResultApp**](RestApiResultApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setapplanguages"></a>
# **SetAppLanguages**
> RestApiResultApp SetAppLanguages (string appId, List<Language> languages)

Set the application languages

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetAppLanguagesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier
            var languages = new List<Language>(); // List<Language> | New list of languages

            try
            {
                // Set the application languages
                RestApiResultApp result = apiInstance.SetAppLanguages(appId, languages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetAppLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier | 
 **languages** | [**List&lt;Language&gt;**](Language.md)| New list of languages | 

### Return type

[**RestApiResultApp**](RestApiResultApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadapplogo"></a>
# **UploadAppLogo**
> void UploadAppLogo (string appId, System.IO.Stream image)

Set the application logo \\ icon

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadAppLogoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier
            var image = new System.IO.Stream(); // System.IO.Stream | App Logo

            try
            {
                // Set the application logo \\ icon
                apiInstance.UploadAppLogo(appId, image);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.UploadAppLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier | 
 **image** | **System.IO.Stream**| App Logo | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

