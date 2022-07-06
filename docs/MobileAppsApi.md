# Flipdish.Api.MobileAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditAppConfigSalesChannel**](MobileAppsApi.md#editappconfigsaleschannel) | **POST** /api/v1.0/mobileapps/{appId}/submission | Submission form mobile apps
[**EditAppConfigSalesChannel_0**](MobileAppsApi.md#editappconfigsaleschannel_0) | **POST** /api/v1.0/mobileapps/{appId}/saleschannel | Set the application sales channel configuration


<a name="editappconfigsaleschannel"></a>
# **EditAppConfigSalesChannel**
> RestApiResultAppConfigSalesChannel EditAppConfigSalesChannel (string appId, MobileAppsSubmission mobileAppsSubmission)

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
                RestApiResultAppConfigSalesChannel result = apiInstance.EditAppConfigSalesChannel(appId, mobileAppsSubmission);
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

[**RestApiResultAppConfigSalesChannel**](RestApiResultAppConfigSalesChannel.md)

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

