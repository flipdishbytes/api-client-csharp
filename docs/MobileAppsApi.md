# Flipdish.Api.MobileAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditAppConfigSalesChannel**](MobileAppsApi.md#editappconfigsaleschannel) | **POST** /api/v1.0/mobileapps/{appId}/submission | Submission form mobile apps
[**EditAppConfigSalesChannel_0**](MobileAppsApi.md#editappconfigsaleschannel_0) | **POST** /api/v1.0/mobileapps/{appId}/saleschannel | Set the application sales channel configuration
[**GetAppDetails**](MobileAppsApi.md#getappdetails) | **GET** /api/v1.0/mobileapps/{appId}/details | Get mobile app details
[**UploadMobileAppsImage**](MobileAppsApi.md#uploadmobileappsimage) | **POST** /api/v1.0/mobileapps/{appId}/image | Upload a Mobile Apps Image


<a name="editappconfigsaleschannel"></a>
# **EditAppConfigSalesChannel**
> RestApiResultMobileAppsSubmission EditAppConfigSalesChannel (string appId, MobileAppsSubmission mobileAppsSubmission)

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
    public class EditAppConfigSalesChannelExample
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
                RestApiResultMobileAppsSubmission result = apiInstance.EditAppConfigSalesChannel(appId, mobileAppsSubmission);
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
 **mobileAppsSubmission** | [**MobileAppsSubmission**](MobileAppsSubmission.md)|  | 

### Return type

[**RestApiResultMobileAppsSubmission**](RestApiResultMobileAppsSubmission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editappconfigsaleschannel_0"></a>
# **EditAppConfigSalesChannel_0**
> RestApiResultAppConfigSalesChannel EditAppConfigSalesChannel_0 (string appId, AppConfigSalesChannel appConfigSalesChannel)

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
    public class EditAppConfigSalesChannel_0Example
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
                RestApiResultAppConfigSalesChannel result = apiInstance.EditAppConfigSalesChannel_0(appId, appConfigSalesChannel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileAppsApi.EditAppConfigSalesChannel_0: " + e.Message );
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

