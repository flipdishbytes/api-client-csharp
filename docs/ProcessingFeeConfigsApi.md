# Flipdish.Api.ProcessingFeeConfigsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProcessingFeeConfigsByStoreIds**](ProcessingFeeConfigsApi.md#getprocessingfeeconfigsbystoreids) | **GET** /api/v1.0/processingfeeconfigs | Get processing fee configs by store identifiers


<a name="getprocessingfeeconfigsbystoreids"></a>
# **GetProcessingFeeConfigsByStoreIds**
> RestApiArrayResultProcessingFeeConfig GetProcessingFeeConfigsByStoreIds (List<int?> storeIds)

Get processing fee configs by store identifiers

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProcessingFeeConfigsByStoreIdsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessingFeeConfigsApi();
            var storeIds = new List<int?>(); // List<int?> | Store identifiers

            try
            {
                // Get processing fee configs by store identifiers
                RestApiArrayResultProcessingFeeConfig result = apiInstance.GetProcessingFeeConfigsByStoreIds(storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingFeeConfigsApi.GetProcessingFeeConfigsByStoreIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeIds** | [**List&lt;int?&gt;**](int?.md)| Store identifiers | 

### Return type

[**RestApiArrayResultProcessingFeeConfig**](RestApiArrayResultProcessingFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

