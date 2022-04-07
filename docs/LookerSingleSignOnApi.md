# Flipdish.Api.LookerSingleSignOnApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLookerCustomerReportingEmbedUrl**](LookerSingleSignOnApi.md#getlookercustomerreportingembedurl) | **GET** /api/v1.0/{appId}/looker/sso/CustomerReporting | 
[**GetSSOEndpoint**](LookerSingleSignOnApi.md#getssoendpoint) | **GET** /api/v1.0/{appId}/looker/sso | Get the single sign on embed URL for PerformanceSummary Dashboard


<a name="getlookercustomerreportingembedurl"></a>
# **GetLookerCustomerReportingEmbedUrl**
> DashboardEmbed GetLookerCustomerReportingEmbedUrl (string appId, string embedPath)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLookerCustomerReportingEmbedUrlExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LookerSingleSignOnApi();
            var appId = appId_example;  // string | 
            var embedPath = embedPath_example;  // string | 

            try
            {
                DashboardEmbed result = apiInstance.GetLookerCustomerReportingEmbedUrl(appId, embedPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookerSingleSignOnApi.GetLookerCustomerReportingEmbedUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **embedPath** | **string**|  | 

### Return type

[**DashboardEmbed**](DashboardEmbed.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getssoendpoint"></a>
# **GetSSOEndpoint**
> DashboardEmbed GetSSOEndpoint (string appId, string embedPath)

Get the single sign on embed URL for PerformanceSummary Dashboard

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSSOEndpointExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LookerSingleSignOnApi();
            var appId = appId_example;  // string | AppNameId
            var embedPath = embedPath_example;  // string | Embed URL of the dashboard

            try
            {
                // Get the single sign on embed URL for PerformanceSummary Dashboard
                DashboardEmbed result = apiInstance.GetSSOEndpoint(appId, embedPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookerSingleSignOnApi.GetSSOEndpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| AppNameId | 
 **embedPath** | **string**| Embed URL of the dashboard | 

### Return type

[**DashboardEmbed**](DashboardEmbed.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

