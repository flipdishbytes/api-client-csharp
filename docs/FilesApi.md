# Flipdish.Api.FilesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadFile**](FilesApi.md#downloadfile) | **GET** /api/v1.0/{appId}/files/download/{fileId} | Get file from storage


<a name="downloadfile"></a>
# **DownloadFile**
> string DownloadFile (string appId, string fileId)

Get file from storage

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DownloadFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FilesApi();
            var appId = appId_example;  // string | 
            var fileId = fileId_example;  // string | 

            try
            {
                // Get file from storage
                string result = apiInstance.DownloadFile(appId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DownloadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **fileId** | **string**|  | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

