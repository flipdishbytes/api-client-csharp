# Flipdish.Api.AppStoreConfigurationsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppStoreConfigurationsAppStoreHandleOauthResponseCode**](AppStoreConfigurationsApi.md#appstoreconfigurationsappstorehandleoauthresponsecode) | **GET** /api/v1.0/appstore/oauthresponse/{appStoreAppId}/responsecode | Process the OAuth response code (bounce back redirect from external OAuth provider after successful authentication)  the query string will contain state and code
[**CreateAppStoreConfig**](AppStoreConfigurationsApi.md#createappstoreconfig) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config | Create App store app configuration
[**DeleteAppStoreConfig**](AppStoreConfigurationsApi.md#deleteappstoreconfig) | **DELETE** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Delete App store app configuration
[**ExecuteConfigurationAction**](AppStoreConfigurationsApi.md#executeconfigurationaction) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId}/action | Execute configuration action on a configuration item (eg. handle button press)
[**GetAppStoreConfig**](AppStoreConfigurationsApi.md#getappstoreconfig) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Get App store app configuration
[**GetConfiguredAppSingleApp**](AppStoreConfigurationsApi.md#getconfiguredappsingleapp) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId} | Get list of App store app configurations for one App store app
[**GetConfiguredApps**](AppStoreConfigurationsApi.md#getconfiguredapps) | **GET** /api/v1.0/{appId}/appstore/apps | Get list of App store apps which have been configured
[**UpdateAppStoreConfig**](AppStoreConfigurationsApi.md#updateappstoreconfig) | **PUT** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Update App store app configuration


<a name="appstoreconfigurationsappstorehandleoauthresponsecode"></a>
# **AppStoreConfigurationsAppStoreHandleOauthResponseCode**
> Object AppStoreConfigurationsAppStoreHandleOauthResponseCode (string appStoreAppId)

Process the OAuth response code (bounce back redirect from external OAuth provider after successful authentication)  the query string will contain state and code

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AppStoreConfigurationsAppStoreHandleOauthResponseCodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                // Process the OAuth response code (bounce back redirect from external OAuth provider after successful authentication)  the query string will contain state and code
                Object result = apiInstance.AppStoreConfigurationsAppStoreHandleOauthResponseCode(appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.AppStoreConfigurationsAppStoreHandleOauthResponseCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoreconfig"></a>
# **CreateAppStoreConfig**
> RestApiResultAppStoreAppConfiguration CreateAppStoreConfig (string appId, string appStoreAppId)

Create App store app configuration

[BETA - this endpoint is under development, do not use it in your production system] This adds an Application to a Whitelabel that can later be configured to specific stores

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Create App store app configuration
                RestApiResultAppStoreAppConfiguration result = apiInstance.CreateAppStoreConfig(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.CreateAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**RestApiResultAppStoreAppConfiguration**](RestApiResultAppStoreAppConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreconfig"></a>
# **DeleteAppStoreConfig**
> RestApiStringResult DeleteAppStoreConfig (string appId, string appStoreAppId, string configId)

Delete App store app configuration

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
    public class DeleteAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var configId = configId_example;  // string | App store app configuration id

            try
            {
                // Delete App store app configuration
                RestApiStringResult result = apiInstance.DeleteAppStoreConfig(appId, appStoreAppId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.DeleteAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **appStoreAppId** | **string**| App store app id | 
 **configId** | **string**| App store app configuration id | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeconfigurationaction"></a>
# **ExecuteConfigurationAction**
> ExecuteConfigurationActionResult ExecuteConfigurationAction (string appId, string appStoreAppId, string configId, ExecuteConfigurationActionRequest executeConfigurationActionRequest)

Execute configuration action on a configuration item (eg. handle button press)

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExecuteConfigurationActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | AppStore App Id
            var configId = configId_example;  // string | AppStore App configuration Id
            var executeConfigurationActionRequest = new ExecuteConfigurationActionRequest(); // ExecuteConfigurationActionRequest | Action request details

            try
            {
                // Execute configuration action on a configuration item (eg. handle button press)
                ExecuteConfigurationActionResult result = apiInstance.ExecuteConfigurationAction(appId, appStoreAppId, configId, executeConfigurationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.ExecuteConfigurationAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| AppStore App Id | 
 **configId** | **string**| AppStore App configuration Id | 
 **executeConfigurationActionRequest** | [**ExecuteConfigurationActionRequest**](ExecuteConfigurationActionRequest.md)| Action request details | 

### Return type

[**ExecuteConfigurationActionResult**](ExecuteConfigurationActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreconfig"></a>
# **GetAppStoreConfig**
> AppStoreAppConfiguration GetAppStoreConfig (string appId, string appStoreAppId, string configId)

Get App store app configuration

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
    public class GetAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var configId = configId_example;  // string | App store app configuration id

            try
            {
                // Get App store app configuration
                AppStoreAppConfiguration result = apiInstance.GetAppStoreConfig(appId, appStoreAppId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **appStoreAppId** | **string**| App store app id | 
 **configId** | **string**| App store app configuration id | 

### Return type

[**AppStoreAppConfiguration**](AppStoreAppConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredappsingleapp"></a>
# **GetConfiguredAppSingleApp**
> RestApiArrayResultAppStoreAppConfigurationSummary GetConfiguredAppSingleApp (string appId, string appStoreAppId)

Get list of App store app configurations for one App store app

[ALPHA - this endpoint is not ready to be consumed]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetConfiguredAppSingleAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Get list of App store app configurations for one App store app
                RestApiArrayResultAppStoreAppConfigurationSummary result = apiInstance.GetConfiguredAppSingleApp(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetConfiguredAppSingleApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**RestApiArrayResultAppStoreAppConfigurationSummary**](RestApiArrayResultAppStoreAppConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredapps"></a>
# **GetConfiguredApps**
> RestApiArrayResultAppStoreAppConfigurationHeader GetConfiguredApps (string appId)

Get list of App store apps which have been configured

[ALPHA - this endpoint is not ready to be consumed]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetConfiguredAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id

            try
            {
                // Get list of App store apps which have been configured
                RestApiArrayResultAppStoreAppConfigurationHeader result = apiInstance.GetConfiguredApps(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetConfiguredApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 

### Return type

[**RestApiArrayResultAppStoreAppConfigurationHeader**](RestApiArrayResultAppStoreAppConfigurationHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreconfig"></a>
# **UpdateAppStoreConfig**
> void UpdateAppStoreConfig (string appId, string appStoreAppId, string configId, UpdateAppStoreAppConfiguration updateAppStoreAppConfiguration)

Update App store app configuration

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
    public class UpdateAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | App id
            var appStoreAppId = appStoreAppId_example;  // string | App store app id
            var configId = configId_example;  // string | App store app configuration id
            var updateAppStoreAppConfiguration = new UpdateAppStoreAppConfiguration(); // UpdateAppStoreAppConfiguration | Update App store app configuration

            try
            {
                // Update App store app configuration
                apiInstance.UpdateAppStoreConfig(appId, appStoreAppId, configId, updateAppStoreAppConfiguration);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.UpdateAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **appStoreAppId** | **string**| App store app id | 
 **configId** | **string**| App store app configuration id | 
 **updateAppStoreAppConfiguration** | [**UpdateAppStoreAppConfiguration**](UpdateAppStoreAppConfiguration.md)| Update App store app configuration | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

