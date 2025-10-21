# Flipdish.Api.WhiteLabelConfigApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppGeneralConfig**](WhiteLabelConfigApi.md#getappgeneralconfig) | **GET** /api/v1.0/whitelabelconfig/{appId}/general | 
[**GetAppStoreConfig**](WhiteLabelConfigApi.md#getappstoreconfig) | **GET** /api/v1.0/whitelabelconfig/{appId}/appstore | 
[**GetPlayStoreConfig**](WhiteLabelConfigApi.md#getplaystoreconfig) | **GET** /api/v1.0/whitelabelconfig/{appId}/playstore | 
[**GetWhiteLabelConfig**](WhiteLabelConfigApi.md#getwhitelabelconfig) | **GET** /api/v1.0/whitelabelconfig/id/{wlid} | 
[**GetWhiteLabelConfigByAppNameId**](WhiteLabelConfigApi.md#getwhitelabelconfigbyappnameid) | **GET** /api/v1.0/whitelabelconfig/name/{appId} | 
[**HealthCheck**](WhiteLabelConfigApi.md#healthcheck) | **GET** /api/v1.0/whitelabelconfig/health | 
[**UpdateAppGeneralConfig**](WhiteLabelConfigApi.md#updateappgeneralconfig) | **POST** /api/v1.0/whitelabelconfig/{appId}/general | 
[**UpdateAppStoreConfig**](WhiteLabelConfigApi.md#updateappstoreconfig) | **POST** /api/v1.0/whitelabelconfig/{appId}/appstore | 
[**UpdatePlayStoreConfig**](WhiteLabelConfigApi.md#updateplaystoreconfig) | **POST** /api/v1.0/whitelabelconfig/{appId}/playstore | 
[**UploadAppStoreIcon**](WhiteLabelConfigApi.md#uploadappstoreicon) | **POST** /api/v1.0/whitelabelconfig/{appId}/app-store-icon | 


<a name="getappgeneralconfig"></a>
# **GetAppGeneralConfig**
> RestApiResultAppGeneralConfigModel GetAppGeneralConfig (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppGeneralConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultAppGeneralConfigModel result = apiInstance.GetAppGeneralConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.GetAppGeneralConfig: " + e.Message );
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

[**RestApiResultAppGeneralConfigModel**](RestApiResultAppGeneralConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreconfig"></a>
# **GetAppStoreConfig**
> RestApiResultAppStoreConfigModel GetAppStoreConfig (string appId)



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

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultAppStoreConfigModel result = apiInstance.GetAppStoreConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.GetAppStoreConfig: " + e.Message );
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

[**RestApiResultAppStoreConfigModel**](RestApiResultAppStoreConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplaystoreconfig"></a>
# **GetPlayStoreConfig**
> RestApiResultPlayStoreConfigModel GetPlayStoreConfig (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPlayStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultPlayStoreConfigModel result = apiInstance.GetPlayStoreConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.GetPlayStoreConfig: " + e.Message );
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

[**RestApiResultPlayStoreConfigModel**](RestApiResultPlayStoreConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhitelabelconfig"></a>
# **GetWhiteLabelConfig**
> RestApiResultWhiteLabelConfigModel GetWhiteLabelConfig (int? wlid)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWhiteLabelConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var wlid = 56;  // int? | 

            try
            {
                RestApiResultWhiteLabelConfigModel result = apiInstance.GetWhiteLabelConfig(wlid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.GetWhiteLabelConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wlid** | **int?**|  | 

### Return type

[**RestApiResultWhiteLabelConfigModel**](RestApiResultWhiteLabelConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhitelabelconfigbyappnameid"></a>
# **GetWhiteLabelConfigByAppNameId**
> RestApiResultWhiteLabelConfigModel GetWhiteLabelConfigByAppNameId (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWhiteLabelConfigByAppNameIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultWhiteLabelConfigModel result = apiInstance.GetWhiteLabelConfigByAppNameId(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.GetWhiteLabelConfigByAppNameId: " + e.Message );
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

[**RestApiResultWhiteLabelConfigModel**](RestApiResultWhiteLabelConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="healthcheck"></a>
# **HealthCheck**
> string HealthCheck ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HealthCheckExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();

            try
            {
                string result = apiInstance.HealthCheck();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.HealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappgeneralconfig"></a>
# **UpdateAppGeneralConfig**
> RestApiResultAppGeneralConfigModel UpdateAppGeneralConfig (string appId, AppGeneralConfigModel appGeneralConfig)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppGeneralConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 
            var appGeneralConfig = new AppGeneralConfigModel(); // AppGeneralConfigModel | 

            try
            {
                RestApiResultAppGeneralConfigModel result = apiInstance.UpdateAppGeneralConfig(appId, appGeneralConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.UpdateAppGeneralConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appGeneralConfig** | [**AppGeneralConfigModel**](AppGeneralConfigModel.md)|  | 

### Return type

[**RestApiResultAppGeneralConfigModel**](RestApiResultAppGeneralConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreconfig"></a>
# **UpdateAppStoreConfig**
> RestApiResultAppStoreConfigModel UpdateAppStoreConfig (string appId, AppStoreConfigModel appStoreConfig)



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

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 
            var appStoreConfig = new AppStoreConfigModel(); // AppStoreConfigModel | 

            try
            {
                RestApiResultAppStoreConfigModel result = apiInstance.UpdateAppStoreConfig(appId, appStoreConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.UpdateAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreConfig** | [**AppStoreConfigModel**](AppStoreConfigModel.md)|  | 

### Return type

[**RestApiResultAppStoreConfigModel**](RestApiResultAppStoreConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplaystoreconfig"></a>
# **UpdatePlayStoreConfig**
> RestApiResultPlayStoreConfigModel UpdatePlayStoreConfig (string appId, PlayStoreConfigModel playStoreConfig)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdatePlayStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 
            var playStoreConfig = new PlayStoreConfigModel(); // PlayStoreConfigModel | 

            try
            {
                RestApiResultPlayStoreConfigModel result = apiInstance.UpdatePlayStoreConfig(appId, playStoreConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.UpdatePlayStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **playStoreConfig** | [**PlayStoreConfigModel**](PlayStoreConfigModel.md)|  | 

### Return type

[**RestApiResultPlayStoreConfigModel**](RestApiResultPlayStoreConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadappstoreicon"></a>
# **UploadAppStoreIcon**
> RestApiResultAssetResultModel UploadAppStoreIcon (string appId, HttpPostedFileBase _file)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadAppStoreIconExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelConfigApi();
            var appId = appId_example;  // string | 
            var _file = new HttpPostedFileBase(); // HttpPostedFileBase | 

            try
            {
                RestApiResultAssetResultModel result = apiInstance.UploadAppStoreIcon(appId, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelConfigApi.UploadAppStoreIcon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **_file** | [**HttpPostedFileBase**](HttpPostedFileBase.md)|  | 

### Return type

[**RestApiResultAssetResultModel**](RestApiResultAssetResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

