# Flipdish.Api.HttpRequestResponseLogsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHttpLogsByUserIdAsync**](HttpRequestResponseLogsApi.md#gethttplogsbyuseridasync) | **GET** /api/v1.0/interactions/logs | 


<a name="gethttplogsbyuseridasync"></a>
# **GetHttpLogsByUserIdAsync**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog GetHttpLogsByUserIdAsync (DateTime? start, DateTime? end, int? filterByUserId = null, int? take = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetHttpLogsByUserIdAsyncExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HttpRequestResponseLogsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var filterByUserId = 56;  // int? |  (optional) 
            var take = 56;  // int? |  (optional) 

            try
            {
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog result = apiInstance.GetHttpLogsByUserIdAsync(start, end, filterByUserId, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HttpRequestResponseLogsApi.GetHttpLogsByUserIdAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**|  | 
 **end** | **DateTime?**|  | 
 **filterByUserId** | **int?**|  | [optional] 
 **take** | **int?**|  | [optional] 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

