# Flipdish.Api.HttpRequestResponseLogsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHttpLogsByUserIdAsync**](HttpRequestResponseLogsApi.md#gethttplogsbyuseridasync) | **GET** /api/v1.0/interactions/logs | Get API interaction logs


<a name="gethttplogsbyuseridasync"></a>
# **GetHttpLogsByUserIdAsync**
> RestApiPaginationResultHttpRequestAndResponseLog GetHttpLogsByUserIdAsync (DateTime? start, DateTime? end, int? filterByUserId = null, int? page = null, int? limit = null)

Get API interaction logs

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
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time
            var filterByUserId = 56;  // int? | User id (optional) (optional) 
            var page = 56;  // int? | Page number (optional) 
            var limit = 56;  // int? | Page size (optional) 

            try
            {
                // Get API interaction logs
                RestApiPaginationResultHttpRequestAndResponseLog result = apiInstance.GetHttpLogsByUserIdAsync(start, end, filterByUserId, page, limit);
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
 **start** | **DateTime?**| Start date time | 
 **end** | **DateTime?**| End date time | 
 **filterByUserId** | **int?**| User id (optional) | [optional] 
 **page** | **int?**| Page number | [optional] 
 **limit** | **int?**| Page size | [optional] 

### Return type

[**RestApiPaginationResultHttpRequestAndResponseLog**](RestApiPaginationResultHttpRequestAndResponseLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
