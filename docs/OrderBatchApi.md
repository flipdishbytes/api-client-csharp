# Flipdish.Api.OrderBatchApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllOrderBatches**](OrderBatchApi.md#getallorderbatches) | **GET** /api/v1.0/{appId}/stores/{storeId}/order-batches | Returns order batches created in a given time range


<a name="getallorderbatches"></a>
# **GetAllOrderBatches**
> RestApiArrayResultOrderBatchItem GetAllOrderBatches (string appId, int? storeId, DateTime? startDate, DateTime? endDate)

Returns order batches created in a given time range

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllOrderBatchesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderBatchApi();
            var appId = appId_example;  // string | App Id
            var storeId = 56;  // int? | Store Id
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start Date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End Date

            try
            {
                // Returns order batches created in a given time range
                RestApiArrayResultOrderBatchItem result = apiInstance.GetAllOrderBatches(appId, storeId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderBatchApi.GetAllOrderBatches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **storeId** | **int?**| Store Id | 
 **startDate** | **DateTime?**| Start Date | 
 **endDate** | **DateTime?**| End Date | 

### Return type

[**RestApiArrayResultOrderBatchItem**](RestApiArrayResultOrderBatchItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

