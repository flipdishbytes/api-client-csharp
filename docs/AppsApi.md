# Flipdish.Api.AppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApp**](AppsApi.md#getapp) | **GET** /api/v1.0/apps/{appId} | 
[**GetAppHostnameStatus**](AppsApi.md#getapphostnamestatus) | **GET** /api/v1.0/apps/{appId}/hostnamestatus | 
[**GetApps**](AppsApi.md#getapps) | **GET** /api/v1.0/apps | 
[**GetCompliance**](AppsApi.md#getcompliance) | **GET** /api/v1.0/apps/{appId}/compliance | 
[**GetPanaceaVanityUrl**](AppsApi.md#getpanaceavanityurl) | **GET** /api/v1.0/apps/{appId}/panacea/url | 
[**GetSalesforceReferences**](AppsApi.md#getsalesforcereferences) | **GET** /api/v1.0/apps/{appId}/salesforcereferences | 
[**GetSupportedCountries**](AppsApi.md#getsupportedcountries) | **GET** /api/v1.0/apps/supportedcountries | 
[**IsPanaceaVanityUrlAvailable**](AppsApi.md#ispanaceavanityurlavailable) | **GET** /api/v1.0/apps/{appId}/panacea/url/available | 
[**SetAppConfig**](AppsApi.md#setappconfig) | **POST** /api/v1.0/apps/{appId}/config | 
[**SetAppHostname**](AppsApi.md#setapphostname) | **POST** /api/v1.0/apps/{appId}/hostname | 
[**SetAppLanguages**](AppsApi.md#setapplanguages) | **POST** /api/v1.0/apps/{appId}/config/languages | 
[**SetAppStoreName**](AppsApi.md#setappstorename) | **POST** /api/v1.0/apps/{appId}/appstorename | 
[**SetCompliance**](AppsApi.md#setcompliance) | **POST** /api/v1.0/apps/{appId}/compliance | 
[**SetPanaceaVanityUrl**](AppsApi.md#setpanaceavanityurl) | **POST** /api/v1.0/apps/{appId}/panacea/url | 
[**SetSalesforceReferences**](AppsApi.md#setsalesforcereferences) | **POST** /api/v1.0/apps/{appId}/salesforcereferences | 
[**ToggleNextGenWeb**](AppsApi.md#togglenextgenweb) | **POST** /api/v1.0/apps/{appId}/nextgenweb | 
[**UploadAppLogo**](AppsApi.md#uploadapplogo) | **POST** /api/v1.0/apps/{appId}/logo | 


<a name="getapp"></a>
# **GetApp**
> RestApiResultApp GetApp (string appId)



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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsalesforcereferences"></a>
# **GetSalesforceReferences**
> AppSalesforceReferences GetSalesforceReferences (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSalesforceReferencesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | 

            try
            {
                AppSalesforceReferences result = apiInstance.GetSalesforceReferences(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetSalesforceReferences: " + e.Message );
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

[**AppSalesforceReferences**](AppSalesforceReferences.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupportedcountries"></a>
# **GetSupportedCountries**
> RestApiArrayResultSupportedCountry GetSupportedCountries ()



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
            var vanityUrl = vanityUrl_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
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
 **vanityUrl** | **string**|  | 
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
            var appId = appId_example;  // string | 
            var appConfigUpdate = new AppConfigUpdateModel(); // AppConfigUpdateModel | 

            try
            {
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
 **appId** | **string**|  | 
 **appConfigUpdate** | [**AppConfigUpdateModel**](AppConfigUpdateModel.md)|  | 

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
> RestApiStringResult SetAppHostname (string appId, string hostname, bool? isEmbed = null)



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
            var appId = appId_example;  // string | 
            var hostname = hostname_example;  // string | 
            var isEmbed = true;  // bool? |  (optional) 

            try
            {
                RestApiStringResult result = apiInstance.SetAppHostname(appId, hostname, isEmbed);
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
 **appId** | **string**|  | 
 **hostname** | **string**|  | 
 **isEmbed** | **bool?**|  | [optional] 

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
            var appId = appId_example;  // string | 
            var languages = new List<Language>(); // List<Language> | 

            try
            {
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
 **appId** | **string**|  | 
 **languages** | [**List&lt;Language&gt;**](Language.md)|  | 

### Return type

[**RestApiResultApp**](RestApiResultApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setappstorename"></a>
# **SetAppStoreName**
> void SetAppStoreName (string appId, string appStoreName)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetAppStoreNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | 
            var appStoreName = appStoreName_example;  // string | 

            try
            {
                apiInstance.SetAppStoreName(appId, appStoreName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetAppStoreName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcompliance"></a>
# **SetCompliance**
> RestApiResultAppCompliance SetCompliance (string appId, string complianceType)



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
            var appId = appId_example;  // string | 
            var complianceType = complianceType_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 
 **complianceType** | **string**|  | 

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
            var appId = appId_example;  // string | 
            var vanityUrl = vanityUrl_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 
 **vanityUrl** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsalesforcereferences"></a>
# **SetSalesforceReferences**
> RestApiStringResult SetSalesforceReferences (string appId, AppSalesforceReferences salesforceReferences)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetSalesforceReferencesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | 
            var salesforceReferences = new AppSalesforceReferences(); // AppSalesforceReferences | 

            try
            {
                RestApiStringResult result = apiInstance.SetSalesforceReferences(appId, salesforceReferences);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.SetSalesforceReferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **salesforceReferences** | [**AppSalesforceReferences**](AppSalesforceReferences.md)|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="togglenextgenweb"></a>
# **ToggleNextGenWeb**
> RestApiStringResult ToggleNextGenWeb (string appId, string hostname, string vanityUrl, bool? isNextGenWeb)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ToggleNextGenWebExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppsApi();
            var appId = appId_example;  // string | 
            var hostname = hostname_example;  // string | 
            var vanityUrl = vanityUrl_example;  // string | 
            var isNextGenWeb = true;  // bool? | 

            try
            {
                RestApiStringResult result = apiInstance.ToggleNextGenWeb(appId, hostname, vanityUrl, isNextGenWeb);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.ToggleNextGenWeb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **hostname** | **string**|  | 
 **vanityUrl** | **string**|  | 
 **isNextGenWeb** | **bool?**|  | 

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
            var appId = appId_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | App Logo

            try
            {
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
 **appId** | **string**|  | 
 **image** | **System.IO.Stream**| App Logo | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

