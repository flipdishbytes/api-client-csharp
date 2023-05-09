# Flipdish.Api.HomeApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteHomeAction**](HomeApi.md#completehomeaction) | **POST** /api/v1.0/{appId}/home/{homeActionId} | 
[**DismissOldPortalAction**](HomeApi.md#dismissoldportalaction) | **POST** /api/v1.0/home/dismissoldportalaction | 
[**GetHomeActions**](HomeApi.md#gethomeactions) | **GET** /api/v1.0/{appId}/home | 
[**GetHomeStatistics**](HomeApi.md#gethomestatistics) | **GET** /api/v1.0/{appId}/home/stats | 
[**GetOktaPortalFeatureFlag**](HomeApi.md#getoktaportalfeatureflag) | **GET** /api/v1.0/home/okta-portal | 


<a name="completehomeaction"></a>
# **CompleteHomeAction**
> Object CompleteHomeAction (string appId, int? homeActionId, bool? isDismissed)



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
            var appId = appId_example;  // string | 
            var homeActionId = 56;  // int? | 
            var isDismissed = true;  // bool? | 

            try
            {
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
 **appId** | **string**|  | 
 **homeActionId** | **int?**|  | 
 **isDismissed** | **bool?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dismissoldportalaction"></a>
# **DismissOldPortalAction**
> Object DismissOldPortalAction ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DismissOldPortalActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();

            try
            {
                Object result = apiInstance.DismissOldPortalAction();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.DismissOldPortalAction: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

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
            var appId = appId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 

### Return type

[**RestApiResultHomeStatistics**](RestApiResultHomeStatistics.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoktaportalfeatureflag"></a>
# **GetOktaPortalFeatureFlag**
> RestApiResultOktaPortalFeatureFlag GetOktaPortalFeatureFlag ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOktaPortalFeatureFlagExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();

            try
            {
                RestApiResultOktaPortalFeatureFlag result = apiInstance.GetOktaPortalFeatureFlag();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.GetOktaPortalFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultOktaPortalFeatureFlag**](RestApiResultOktaPortalFeatureFlag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

