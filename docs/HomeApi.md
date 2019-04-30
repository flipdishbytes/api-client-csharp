# Flipdish.Api.HomeApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteHomeAction**](HomeApi.md#completehomeaction) | **POST** /api/v1.0/{appId}/home/{homeActionId} | [PRIVATE API] Complete Home Action
[**GetHomeActions**](HomeApi.md#gethomeactions) | **GET** /api/v1.0/{appId}/home | [PRIVATE API] Get Home Actions
[**GetHomeStatistics**](HomeApi.md#gethomestatistics) | **GET** /api/v1.0/{appId}/home/stats | [PRIVATE API] Get Home Statistics


<a name="completehomeaction"></a>
# **CompleteHomeAction**
> Object CompleteHomeAction (string appId, int? homeActionId, bool? isDismissed)

[PRIVATE API] Complete Home Action

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CompleteHomeActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();
            var appId = appId_example;  // string | App Name Id
            var homeActionId = 56;  // int? | Id of the action
            var isDismissed = true;  // bool? | 

            try
            {
                // [PRIVATE API] Complete Home Action
                Object result = apiInstance.CompleteHomeAction(appId, homeActionId, isDismissed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.CompleteHomeAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **homeActionId** | **int?**| Id of the action | 
 **isDismissed** | **bool?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomeactions"></a>
# **GetHomeActions**
> RestApiArrayResultHomeAction GetHomeActions (string appId)

[PRIVATE API] Get Home Actions

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetHomeActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // [PRIVATE API] Get Home Actions
                RestApiArrayResultHomeAction result = apiInstance.GetHomeActions(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.GetHomeActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 

### Return type

[**RestApiArrayResultHomeAction**](RestApiArrayResultHomeAction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomestatistics"></a>
# **GetHomeStatistics**
> RestApiResultHomeStatistics GetHomeStatistics (string appId)

[PRIVATE API] Get Home Statistics

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetHomeStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // [PRIVATE API] Get Home Statistics
                RestApiResultHomeStatistics result = apiInstance.GetHomeStatistics(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.GetHomeStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 

### Return type

[**RestApiResultHomeStatistics**](RestApiResultHomeStatistics.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

