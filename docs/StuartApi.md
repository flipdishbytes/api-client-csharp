# Flipdish.Api.StuartApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StuartCancelJob**](StuartApi.md#stuartcanceljob) | **DELETE** /api/v1.0/stuart/jobs/{jobId} | 
[**StuartGetClientCredentials**](StuartApi.md#stuartgetclientcredentials) | **GET** /api/v1.0/stuart/credentials/{storeId} | Get stuart credentials
[**StuartPostClientCredentials**](StuartApi.md#stuartpostclientcredentials) | **POST** /api/v1.0/stuart/credentials/{storeId} | 


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

<a name="stuartgetclientcredentials"></a>
# **StuartGetClientCredentials**
> RestApiResultClientCredentials StuartGetClientCredentials (int? storeId)

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
    public class StuartGetClientCredentialsExample
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
                RestApiResultClientCredentials result = apiInstance.StuartGetClientCredentials(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartGetClientCredentials: " + e.Message );
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

[**RestApiResultClientCredentials**](RestApiResultClientCredentials.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stuartpostclientcredentials"></a>
# **StuartPostClientCredentials**
> Object StuartPostClientCredentials (int? storeId, ClientCredentials clientCredentials)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class StuartPostClientCredentialsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StuartApi();
            var storeId = 56;  // int? | 
            var clientCredentials = new ClientCredentials(); // ClientCredentials | 

            try
            {
                Object result = apiInstance.StuartPostClientCredentials(storeId, clientCredentials);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StuartApi.StuartPostClientCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **clientCredentials** | [**ClientCredentials**](ClientCredentials.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

