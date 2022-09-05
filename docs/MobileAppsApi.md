# Flipdish.Api.MobileAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppConfigSalesChannel**](MobileAppsApi.md#getappconfigsaleschannel) | **GET** /api/v1.0/mobileapps/{appId}/saleschannel/details | Get sales channel configuration
[**GetStatistics**](MobileAppsApi.md#getstatistics) | **GET** /api/v1.0/mobileapps/{appId}/statistics | Get statistics mobile apps
[**GetSubmissionDetails**](MobileAppsApi.md#getsubmissiondetails) | **GET** /api/v1.0/mobileapps/{appId}/submission/details | Get submission details mobile apps
[**GetSubmissionStatus**](MobileAppsApi.md#getsubmissionstatus) | **GET** /api/v1.0/mobileapps/{appId}/submission/{submissionId}/status | Get submission status mobile apps
[**Publish**](MobileAppsApi.md#publish) | **POST** /api/v1.0/mobileapps/{appId}/submission/{submissionId}/publish | Publish mobile apps
[**Resubmission**](MobileAppsApi.md#resubmission) | **POST** /api/v1.0/mobileapps/{appId}/resubmission | Re-submission form mobile apps
[**Submission**](MobileAppsApi.md#submission) | **POST** /api/v1.0/mobileapps/{appId}/submission | Submission form mobile apps
[**Unpublish**](MobileAppsApi.md#unpublish) | **POST** /api/v1.0/mobileapps/{appId}/submission/{submissionId}/unpublish | Unpublish mobile apps
[**UpdateAppConfigSalesChannel**](MobileAppsApi.md#updateappconfigsaleschannel) | **POST** /api/v1.0/mobileapps/{appId}/saleschannel | Update the application sales channel configuration
[**UpdateSubmissionStatus**](MobileAppsApi.md#updatesubmissionstatus) | **POST** /api/v1.0/mobileapps/{appId}/submission/{submissionId}/status | Update submission status
[**UploadImage**](MobileAppsApi.md#uploadimage) | **POST** /api/v1.0/mobileapps/{appId}/submission/image | Upload image mobile apps


<a name="getappconfigsaleschannel"></a>
# **GetAppConfigSalesChannel**
> RestApiResultAppConfigSalesChannel GetAppConfigSalesChannel (string appId)

Get sales channel configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppConfigSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get sales channel configuration
                RestApiResultAppConfigSalesChannel result = apiInstance.GetAppConfigSalesChannel(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetAppConfigSalesChannel: " + e.Message );
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

[**RestApiResultAppConfigSalesChannel**](RestApiResultAppConfigSalesChannel.md)

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

<a name="getsubmissiondetails"></a>
# **GetSubmissionDetails**
> RestApiResultMobileAppsSubmissionDetails GetSubmissionDetails (string appId)

Get submission details mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSubmissionDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get submission details mobile apps
                RestApiResultMobileAppsSubmissionDetails result = apiInstance.GetSubmissionDetails(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetSubmissionDetails: " + e.Message );
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

[**RestApiResultMobileAppsSubmissionDetails**](RestApiResultMobileAppsSubmissionDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubmissionstatus"></a>
# **GetSubmissionStatus**
> RestApiResultMobileAppsSubmissionStatus GetSubmissionStatus (string appId, int? submissionId)

Get submission status mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSubmissionStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var submissionId = 56;  // int? | 

            try
            {
                // Get submission status mobile apps
                RestApiResultMobileAppsSubmissionStatus result = apiInstance.GetSubmissionStatus(appId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.GetSubmissionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **submissionId** | **int?**|  | 

### Return type

[**RestApiResultMobileAppsSubmissionStatus**](RestApiResultMobileAppsSubmissionStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publish"></a>
# **Publish**
> RestApiResultRestApiIntegerResult Publish (string appId, int? submissionId, string platformType)

Publish mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PublishExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var submissionId = 56;  // int? | 
            var platformType = platformType_example;  // string | 

            try
            {
                // Publish mobile apps
                RestApiResultRestApiIntegerResult result = apiInstance.Publish(appId, submissionId, platformType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.Publish: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **submissionId** | **int?**|  | 
 **platformType** | **string**|  | 

### Return type

[**RestApiResultRestApiIntegerResult**](RestApiResultRestApiIntegerResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resubmission"></a>
# **Resubmission**
> RestApiResultMobileAppsSubmission Resubmission (string appId, MobileAppsSubmission mobileAppsSubmission)

Re-submission form mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ResubmissionExample
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
                // Re-submission form mobile apps
                RestApiResultMobileAppsSubmission result = apiInstance.Resubmission(appId, mobileAppsSubmission);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.Resubmission: " + e.Message );
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

<a name="unpublish"></a>
# **Unpublish**
> RestApiIntegerResult Unpublish (string appId, int? submissionId, string platformType)

Unpublish mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnpublishExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var submissionId = 56;  // int? | 
            var platformType = platformType_example;  // string | 

            try
            {
                // Unpublish mobile apps
                RestApiIntegerResult result = apiInstance.Unpublish(appId, submissionId, platformType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.Unpublish: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **submissionId** | **int?**|  | 
 **platformType** | **string**|  | 

### Return type

[**RestApiIntegerResult**](RestApiIntegerResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappconfigsaleschannel"></a>
# **UpdateAppConfigSalesChannel**
> RestApiResultAppConfigSalesChannel UpdateAppConfigSalesChannel (string appId, AppConfigSalesChannel appConfigSalesChannel)

Update the application sales channel configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppConfigSalesChannelExample
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
                // Update the application sales channel configuration
                RestApiResultAppConfigSalesChannel result = apiInstance.UpdateAppConfigSalesChannel(appId, appConfigSalesChannel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.UpdateAppConfigSalesChannel: " + e.Message );
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

<a name="updatesubmissionstatus"></a>
# **UpdateSubmissionStatus**
> RestApiResultUpdateMobileAppsSubmissionStatus UpdateSubmissionStatus (string appId, int? submissionId, UpdateMobileAppsSubmissionStatus updateMobileAppsSubmissionStatus)

Update submission status

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateSubmissionStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileAppsApi();
            var appId = appId_example;  // string | 
            var submissionId = 56;  // int? | 
            var updateMobileAppsSubmissionStatus = new UpdateMobileAppsSubmissionStatus(); // UpdateMobileAppsSubmissionStatus | 

            try
            {
                // Update submission status
                RestApiResultUpdateMobileAppsSubmissionStatus result = apiInstance.UpdateSubmissionStatus(appId, submissionId, updateMobileAppsSubmissionStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.UpdateSubmissionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **submissionId** | **int?**|  | 
 **updateMobileAppsSubmissionStatus** | [**UpdateMobileAppsSubmissionStatus**](UpdateMobileAppsSubmissionStatus.md)|  | 

### Return type

[**RestApiResultUpdateMobileAppsSubmissionStatus**](RestApiResultUpdateMobileAppsSubmissionStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadimage"></a>
# **UploadImage**
> RestApiResultMobileAppsImage UploadImage (string appId, System.IO.Stream image)

Upload image mobile apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadImageExample
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
                // Upload image mobile apps
                RestApiResultMobileAppsImage result = apiInstance.UploadImage(appId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.UploadImage: " + e.Message );
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

