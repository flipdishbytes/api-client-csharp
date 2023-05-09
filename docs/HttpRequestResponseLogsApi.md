# Flipdish.Api.HttpRequestResponseLogsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLogs**](HttpRequestResponseLogsApi.md#getlogs) | **GET** /api/v1.0/{appId}/interactions/logs | 


<a name="getlogs"></a>
# **GetLogs**
> RestApiPaginationResultHttpRequestAndResponseLog GetLogs (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, string guid = null, int? page = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HttpRequestResponseLogsApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var appId = appId_example;  // string | 
            var filterByUserId = 56;  // int? |  (optional) 
            var guid = guid_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultHttpRequestAndResponseLog result = apiInstance.GetLogs(start, end, appId, filterByUserId, guid, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HttpRequestResponseLogsApi.GetLogs: " + e.Message );
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
 **appId** | **string**|  | 
 **filterByUserId** | **int?**|  | [optional] 
 **guid** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultHttpRequestAndResponseLog**](RestApiPaginationResultHttpRequestAndResponseLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

