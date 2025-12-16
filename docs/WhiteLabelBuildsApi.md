# Flipdish.Api.WhiteLabelBuildsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthCheck**](WhiteLabelBuildsApi.md#healthcheck) | **GET** /api/v1.0/whitelabelbuilds/health | 
[**SubmitAndroidApps**](WhiteLabelBuildsApi.md#submitandroidapps) | **POST** /api/v1.0/whitelabelbuilds/android/multiple | 
[**SubmitAndroidBuild**](WhiteLabelBuildsApi.md#submitandroidbuild) | **POST** /api/v1.0/whitelabelbuilds/{appId}/android | 
[**SubmitIosApps**](WhiteLabelBuildsApi.md#submitiosapps) | **POST** /api/v1.0/whitelabelbuilds/ios/multiple | 
[**SubmitIosBuild**](WhiteLabelBuildsApi.md#submitiosbuild) | **POST** /api/v1.0/whitelabelbuilds/{appId}/ios | 


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

            var apiInstance = new WhiteLabelBuildsApi();

            try
            {
                string result = apiInstance.HealthCheck();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelBuildsApi.HealthCheck: " + e.Message );
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

<a name="submitandroidapps"></a>
# **SubmitAndroidApps**
> RestApiResultBuildResultModel SubmitAndroidApps (string whiteLabelIds, string branch = null, string buildType = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmitAndroidAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelBuildsApi();
            var whiteLabelIds = whiteLabelIds_example;  // string | 
            var branch = branch_example;  // string |  (optional) 
            var buildType = buildType_example;  // string |  (optional) 

            try
            {
                RestApiResultBuildResultModel result = apiInstance.SubmitAndroidApps(whiteLabelIds, branch, buildType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelBuildsApi.SubmitAndroidApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whiteLabelIds** | **string**|  | 
 **branch** | **string**|  | [optional] 
 **buildType** | **string**|  | [optional] 

### Return type

[**RestApiResultBuildResultModel**](RestApiResultBuildResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitandroidbuild"></a>
# **SubmitAndroidBuild**
> RestApiResultBuildResultModel SubmitAndroidBuild (string appId, string branch, string lane, string buildType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmitAndroidBuildExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelBuildsApi();
            var appId = appId_example;  // string | 
            var branch = branch_example;  // string | 
            var lane = lane_example;  // string | 
            var buildType = buildType_example;  // string | 

            try
            {
                RestApiResultBuildResultModel result = apiInstance.SubmitAndroidBuild(appId, branch, lane, buildType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelBuildsApi.SubmitAndroidBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **branch** | **string**|  | 
 **lane** | **string**|  | 
 **buildType** | **string**|  | 

### Return type

[**RestApiResultBuildResultModel**](RestApiResultBuildResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitiosapps"></a>
# **SubmitIosApps**
> RestApiResultBuildResultModel SubmitIosApps (string whiteLabelIds, string branch = null, string buildType = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmitIosAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelBuildsApi();
            var whiteLabelIds = whiteLabelIds_example;  // string | 
            var branch = branch_example;  // string |  (optional) 
            var buildType = buildType_example;  // string |  (optional) 

            try
            {
                RestApiResultBuildResultModel result = apiInstance.SubmitIosApps(whiteLabelIds, branch, buildType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelBuildsApi.SubmitIosApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whiteLabelIds** | **string**|  | 
 **branch** | **string**|  | [optional] 
 **buildType** | **string**|  | [optional] 

### Return type

[**RestApiResultBuildResultModel**](RestApiResultBuildResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitiosbuild"></a>
# **SubmitIosBuild**
> RestApiResultBuildResultModel SubmitIosBuild (string appId, string buildType, string branch, bool? submitForReview = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubmitIosBuildExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelBuildsApi();
            var appId = appId_example;  // string | 
            var buildType = buildType_example;  // string | 
            var branch = branch_example;  // string | 
            var submitForReview = true;  // bool? |  (optional) 

            try
            {
                RestApiResultBuildResultModel result = apiInstance.SubmitIosBuild(appId, buildType, branch, submitForReview);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelBuildsApi.SubmitIosBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **buildType** | **string**|  | 
 **branch** | **string**|  | 
 **submitForReview** | **bool?**|  | [optional] 

### Return type

[**RestApiResultBuildResultModel**](RestApiResultBuildResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

