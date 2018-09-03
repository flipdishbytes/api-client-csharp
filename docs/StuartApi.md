# Flipdish.Api.StuartApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StuartCancelJob**](StuartApi.md#stuartcanceljob) | **DELETE** /api/v1.0/stuart/jobs/{jobId} | 
[**StuartGetJob**](StuartApi.md#stuartgetjob) | **GET** /api/v1.0/stuart/jobs/{jobId} | 
[**StuartGetStuartSettings**](StuartApi.md#stuartgetstuartsettings) | **GET** /api/v1.0/stuart/settings/{storeId} | Get stuart credentials
[**StuartPostStuartSettings**](StuartApi.md#stuartpoststuartsettings) | **POST** /api/v1.0/stuart/settings/{storeId} | 


<a name="stuartcanceljob"></a>
# **StuartCancelJob**
> Object StuartCancelJob (int? jobId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StuartCancelJobExample
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
                Object result = apiInstance.StuartCancelJob(jobId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartCancelJob: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stuartgetjob"></a>
# **StuartGetJob**
> RestApiResultJobResponse StuartGetJob (int? jobId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StuartGetJobExample
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
                RestApiResultJobResponse result = apiInstance.StuartGetJob(jobId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartGetJob: " + e.Message );
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

<a name="stuartgetstuartsettings"></a>
# **StuartGetStuartSettings**
> RestApiResultStuartSettings StuartGetStuartSettings (int? storeId)

Get stuart credentials

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StuartGetStuartSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var storeId = 56;  // int? | 

            try
            {
                // Get stuart credentials
                RestApiResultStuartSettings result = apiInstance.StuartGetStuartSettings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartGetStuartSettings: " + e.Message );
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

<a name="stuartpoststuartsettings"></a>
# **StuartPostStuartSettings**
> Object StuartPostStuartSettings (int? storeId, StuartSettings stuartSettings)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StuartPostStuartSettingsExample
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
                Object result = apiInstance.StuartPostStuartSettings(storeId, stuartSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartPostStuartSettings: " + e.Message );
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

