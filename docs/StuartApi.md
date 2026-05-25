# Flipdish.Api.StuartApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelJob**](StuartApi.md#canceljob) | **DELETE** /api/v1.0/stuart/jobs/{jobId} | 
[**GetJob**](StuartApi.md#getjob) | **GET** /api/v1.0/stuart/jobs/{jobId} | 
[**GetStuartSettings**](StuartApi.md#getstuartsettings) | **GET** /api/v1.0/stuart/settings/{storeId} | 
[**PostStuartSettings**](StuartApi.md#poststuartsettings) | **POST** /api/v1.0/stuart/settings/{storeId} | 


<a name="canceljob"></a>
# **CancelJob**
> void CancelJob (int? jobId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CancelJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var jobId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
                apiInstance.CancelJob(jobId, storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.CancelJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**|  | 
 **storeId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjob"></a>
# **GetJob**
> RestApiResultJobResponse GetJob (int? jobId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var jobId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultJobResponse result = apiInstance.GetJob(jobId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultJobResponse**](RestApiResultJobResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstuartsettings"></a>
# **GetStuartSettings**
> RestApiResultStuartSettings GetStuartSettings (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStuartSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultStuartSettings result = apiInstance.GetStuartSettings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.GetStuartSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultStuartSettings**](RestApiResultStuartSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststuartsettings"></a>
# **PostStuartSettings**
> Object PostStuartSettings (int? storeId, StuartSettings stuartSettings)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PostStuartSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var storeId = 56;  // int? | 
            var stuartSettings = new StuartSettings(); // StuartSettings | 

            try
            {
                Object result = apiInstance.PostStuartSettings(storeId, stuartSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.PostStuartSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **stuartSettings** | [**StuartSettings**](StuartSettings.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

