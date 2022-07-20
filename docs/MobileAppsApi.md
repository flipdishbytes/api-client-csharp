# Flipdish.Api.MobileAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditAppConfigSalesChannel**](MobileAppsApi.md#editappconfigsaleschannel) | **POST** /api/v1.0/mobileapps/{appId}/saleschannel | Set the application sales channel configuration
[**GetAppConfig**](MobileAppsApi.md#getappconfig) | **GET** /api/v1.0/mobileapps/{appId}/config | Get mobile app configuration
[**GetAppDetails**](MobileAppsApi.md#getappdetails) | **GET** /api/v1.0/mobileapps/{appId}/details | Get mobile app details
[**GetMobileAppsSubmissionStatus**](MobileAppsApi.md#getmobileappssubmissionstatus) | **GET** /api/v1.0/mobileapps/{appId}/submissionstatus{plataformType} | Get mobile app submitted status
[**GetStatistics**](MobileAppsApi.md#getstatistics) | **GET** /api/v1.0/mobileapps/{appId}/statistics | Get statistics mobile apps
[**SetAppConfig**](MobileAppsApi.md#setappconfig) | **POST** /api/v1.0/mobileapps/{appId}/config | Set mobile app configuration
[**Submission**](MobileAppsApi.md#submission) | **POST** /api/v1.0/mobileapps/{appId}/submission | Submission form mobile apps
[**UploadMobileAppsImage**](MobileAppsApi.md#uploadmobileappsimage) | **POST** /api/v1.0/mobileapps/{appId}/image | Upload a Mobile Apps Image


<a name="editappconfigsaleschannel"></a>
# **EditAppConfigSalesChannel**
> RestApiResultAppConfigSalesChannel EditAppConfigSalesChannel (string appId, AppConfigSalesChannel appConfigSalesChannel)

Set the application sales channel configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class EditAppConfigSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var appConfigSalesChannel = new AppConfigSalesChannel(); // AppConfigSalesChannel | 

            try
            {
                // Set the application sales channel configuration
                RestApiResultAppConfigSalesChannel result = apiInstance.EditAppConfigSalesChannel(appId, appConfigSalesChannel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.EditAppConfigSalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appConfigSalesChannel** | [**AppConfigSalesChannel**](AppConfigSalesChannel.md)|  | 

### Return type

[**RestApiResultAppConfigSalesChannel**](RestApiResultAppConfigSalesChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappconfig"></a>
# **GetAppConfig**
> RestApiResultMobileAppsDetails GetAppConfig (string appId)

Get mobile app configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get mobile app configuration
                RestApiResultMobileAppsDetails result = apiInstance.GetAppConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetAppConfig: " + e.Message );
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

[**RestApiResultMobileAppsDetails**](RestApiResultMobileAppsDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappdetails"></a>
# **GetAppDetails**
> RestApiResultMobileAppsDetails GetAppDetails (string appId)

Get mobile app details

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get mobile app details
                RestApiResultMobileAppsDetails result = apiInstance.GetAppDetails(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetAppDetails: " + e.Message );
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

[**RestApiResultMobileAppsDetails**](RestApiResultMobileAppsDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmobileappssubmissionstatus"></a>
# **GetMobileAppsSubmissionStatus**
> RestApiResultMobileAppsSubmissionStatus GetMobileAppsSubmissionStatus (string appId, string plataformType)

Get mobile app submitted status

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMobileAppsSubmissionStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var plataformType = plataformType_example;  // string | 

            try
            {
                // Get mobile app submitted status
                RestApiResultMobileAppsSubmissionStatus result = apiInstance.GetMobileAppsSubmissionStatus(appId, plataformType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetMobileAppsSubmissionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **plataformType** | **string**|  | 

### Return type

[**RestApiResultMobileAppsSubmissionStatus**](RestApiResultMobileAppsSubmissionStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatistics"></a>
# **GetStatistics**
> RestApiArrayResultMobileAppsStatistics GetStatistics (string appId, List<string> platformTypes)

Get statistics mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var platformTypes = platformTypes_example;  // List<string> | 

            try
            {
                // Get statistics mobile apps
                RestApiArrayResultMobileAppsStatistics result = apiInstance.GetStatistics(appId, platformTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **platformTypes** | **List&lt;string&gt;**|  | 

### Return type

[**RestApiArrayResultMobileAppsStatistics**](RestApiArrayResultMobileAppsStatistics.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setappconfig"></a>
# **SetAppConfig**
> RestApiResult SetAppConfig (string appId, MobileAppConfig configUpdate)

Set mobile app configuration

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

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var configUpdate = new MobileAppConfig(); // MobileAppConfig | 

            try
            {
                // Set mobile app configuration
                RestApiResult result = apiInstance.SetAppConfig(appId, configUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.SetAppConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configUpdate** | [**MobileAppConfig**](MobileAppConfig.md)|  | 

### Return type

[**RestApiResult**](RestApiResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submission"></a>
# **Submission**
> RestApiResultMobileAppsSubmission Submission (string appId, MobileAppsSubmission mobileAppsSubmission)

Submission form mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmissionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var mobileAppsSubmission = new MobileAppsSubmission(); // MobileAppsSubmission | 

            try
            {
                // Submission form mobile apps
                RestApiResultMobileAppsSubmission result = apiInstance.Submission(appId, mobileAppsSubmission);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.Submission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **mobileAppsSubmission** | [**MobileAppsSubmission**](MobileAppsSubmission.md)|  | 

### Return type

[**RestApiResultMobileAppsSubmission**](RestApiResultMobileAppsSubmission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmobileappsimage"></a>
# **UploadMobileAppsImage**
> RestApiResultMobileAppsImage UploadMobileAppsImage (string appId, System.IO.Stream image)

Upload a Mobile Apps Image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMobileAppsImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | Mobile Apps image

            try
            {
                // Upload a Mobile Apps Image
                RestApiResultMobileAppsImage result = apiInstance.UploadMobileAppsImage(appId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.UploadMobileAppsImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **image** | **System.IO.Stream**| Mobile Apps image | 

### Return type

[**RestApiResultMobileAppsImage**](RestApiResultMobileAppsImage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

