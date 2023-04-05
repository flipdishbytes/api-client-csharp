# Flipdish.Api.AppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApp**](AppsApi.md#getapp) | **GET** /api/v1.0/apps/{appId} | Get the application configuration
[**GetAppHostnameStatus**](AppsApi.md#getapphostnamestatus) | **GET** /api/v1.0/apps/{appId}/hostnamestatus | Get the application hostname DNS delegation states for A and CNAME records.
[**GetApps**](AppsApi.md#getapps) | **GET** /api/v1.0/apps | Get Apps
[**GetCompliance**](AppsApi.md#getcompliance) | **GET** /api/v1.0/apps/{appId}/compliance | Get the application compliance configuration
[**GetPanaceaVanityUrl**](AppsApi.md#getpanaceavanityurl) | **GET** /api/v1.0/apps/{appId}/panacea/url | Get panacea vanity url. This sets the URL which the Panacea website is available at. ie. my.flipdish.com/[vanityurl]
[**GetSupportedCountries**](AppsApi.md#getsupportedcountries) | **GET** /api/v1.0/apps/supportedcountries | Get all supported countries.
[**IsPanaceaVanityUrlAvailable**](AppsApi.md#ispanaceavanityurlavailable) | **GET** /api/v1.0/apps/{appId}/panacea/url/available | Is panacea vanity url available
[**SetAppConfig**](AppsApi.md#setappconfig) | **POST** /api/v1.0/apps/{appId}/config | Set the application configuration
[**SetAppHostname**](AppsApi.md#setapphostname) | **POST** /api/v1.0/apps/{appId}/hostname | Set the application hostname.
[**SetAppLanguages**](AppsApi.md#setapplanguages) | **POST** /api/v1.0/apps/{appId}/config/languages | Set the application languages
[**SetCompliance**](AppsApi.md#setcompliance) | **POST** /api/v1.0/apps/{appId}/compliance | Set the application compliance configuration
[**SetPanaceaVanityUrl**](AppsApi.md#setpanaceavanityurl) | **POST** /api/v1.0/apps/{appId}/panacea/url | Set panacea vanity url
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

<a name="getapphostnamestatus"></a>
# **GetAppHostnameStatus**
> RestApiResultDnsRecordInformation GetAppHostnameStatus (string appId)

Get the application hostname DNS delegation states for A and CNAME records.

A domain might be ready but still need 10 minutes to work properly because of HAProxy.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppHostnameStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier.

            try
            {
                // Get the application hostname DNS delegation states for A and CNAME records.
                RestApiResultDnsRecordInformation result = apiInstance.GetAppHostnameStatus(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetAppHostnameStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier. | 

### Return type

[**RestApiResultDnsRecordInformation**](RestApiResultDnsRecordInformation.md)

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

<a name="getcompliance"></a>
# **GetCompliance**
> RestApiResultAppCompliance GetCompliance (string appId)

Get the application compliance configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetComplianceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier

            try
            {
                // Get the application compliance configuration
                RestApiResultAppCompliance result = apiInstance.GetCompliance(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetCompliance: " + e.Message );
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

[**RestApiResultAppCompliance**](RestApiResultAppCompliance.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpanaceavanityurl"></a>
# **GetPanaceaVanityUrl**
> RestApiStringResult GetPanaceaVanityUrl (string appId)

Get panacea vanity url. This sets the URL which the Panacea website is available at. ie. my.flipdish.com/[vanityurl]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPanaceaVanityUrlExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier.

            try
            {
                // Get panacea vanity url. This sets the URL which the Panacea website is available at. ie. my.flipdish.com/[vanityurl]
                RestApiStringResult result = apiInstance.GetPanaceaVanityUrl(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetPanaceaVanityUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier. | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupportedcountries"></a>
# **GetSupportedCountries**
> RestApiArrayResultSupportedCountry GetSupportedCountries ()

Get all supported countries.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSupportedCountriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();

            try
            {
                // Get all supported countries.
                RestApiArrayResultSupportedCountry result = apiInstance.GetSupportedCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetSupportedCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiArrayResultSupportedCountry**](RestApiArrayResultSupportedCountry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ispanaceavanityurlavailable"></a>
# **IsPanaceaVanityUrlAvailable**
> RestApiStringResult IsPanaceaVanityUrlAvailable (string vanityUrl, string appId)

Is panacea vanity url available

Minimum length of 3 characters

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class IsPanaceaVanityUrlAvailableExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var vanityUrl = vanityUrl_example;  // string | Vanity url to check
            var appId = appId_example;  // string | 

            try
            {
                // Is panacea vanity url available
                RestApiStringResult result = apiInstance.IsPanaceaVanityUrlAvailable(vanityUrl, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.IsPanaceaVanityUrlAvailable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vanityUrl** | **string**| Vanity url to check | 
 **appId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

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

<a name="setapphostname"></a>
# **SetAppHostname**
> RestApiStringResult SetAppHostname (string appId, string hostname, bool? isEmbed = null, bool? isNextGenWeb = null)

Set the application hostname.

If no subdomain is specified in {hostname} 'www' will be prepended.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetAppHostnameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier.
            var hostname = hostname_example;  // string | The new Hostname.
            var isEmbed = true;  // bool? | Will the website be embedded (optional) 
            var isNextGenWeb = true;  // bool? | Enables the NextGen web editor (optional) 

            try
            {
                // Set the application hostname.
                RestApiStringResult result = apiInstance.SetAppHostname(appId, hostname, isEmbed, isNextGenWeb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetAppHostname: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier. | 
 **hostname** | **string**| The new Hostname. | 
 **isEmbed** | **bool?**| Will the website be embedded | [optional] 
 **isNextGenWeb** | **bool?**| Enables the NextGen web editor | [optional] 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a name="setcompliance"></a>
# **SetCompliance**
> RestApiResultAppCompliance SetCompliance (string appId, string complianceType)

Set the application compliance configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetComplianceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier
            var complianceType = complianceType_example;  // string | Compliance type

            try
            {
                // Set the application compliance configuration
                RestApiResultAppCompliance result = apiInstance.SetCompliance(appId, complianceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetCompliance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier | 
 **complianceType** | **string**| Compliance type | 

### Return type

[**RestApiResultAppCompliance**](RestApiResultAppCompliance.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpanaceavanityurl"></a>
# **SetPanaceaVanityUrl**
> RestApiStringResult SetPanaceaVanityUrl (string appId, string vanityUrl)

Set panacea vanity url

Minimum length of 3 characters

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetPanaceaVanityUrlExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | Application identifier.
            var vanityUrl = vanityUrl_example;  // string | Vanity url

            try
            {
                // Set panacea vanity url
                RestApiStringResult result = apiInstance.SetPanaceaVanityUrl(appId, vanityUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetPanaceaVanityUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application identifier. | 
 **vanityUrl** | **string**| Vanity url | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
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

