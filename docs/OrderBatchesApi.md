# Flipdish.Api.OrderBatchesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllOrderBatches**](OrderBatchesApi.md#getallorderbatches) | **GET** /api/v1.0/{appId}/stores/{storeId}/order-batches | Returns order batches
[**GetOrderBatch**](OrderBatchesApi.md#getorderbatch) | **GET** /api/v1.0/{appId}/stores/{storeId}/order-batches/{batchId} | Returns the order batch details


<a name="getallorderbatches"></a>
# **GetAllOrderBatches**
> RestApiArrayResultOrderBatchItem GetAllOrderBatches (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null)

Returns order batches

Entries are sorted by date, from the most recent. At most 100 entries are returned.

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

            var apiInstance = new OrderBatchesApi();
            var appId = appId_example;  // string | App Id
            var storeId = 56;  // int? | Store Id
            var createdFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date for retrieving the entries (optional) 
            var createdTo = 2013-10-20T19:20:30+01:00;  // DateTime? | End date for retrieving the entries (optional) 

            try
            {
                // Returns order batches
                RestApiArrayResultOrderBatchItem result = apiInstance.GetAllOrderBatches(appId, storeId, createdFrom, createdTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderBatchesApi.GetAllOrderBatches: " + e.Message );
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
 **createdFrom** | **DateTime?**| Start date for retrieving the entries | [optional] 
 **createdTo** | **DateTime?**| End date for retrieving the entries | [optional] 

### Return type

[**RestApiArrayResultOrderBatchItem**](RestApiArrayResultOrderBatchItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbatch"></a>
# **GetOrderBatch**
> RestApiResultOrderBatch GetOrderBatch (string appId, int? storeId, int? batchId)

Returns the order batch details

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderBatchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderBatchesApi();
            var appId = appId_example;  // string | App Id
            var storeId = 56;  // int? | Store Id
            var batchId = 56;  // int? | Order Batch Id

            try
            {
                // Returns the order batch details
                RestApiResultOrderBatch result = apiInstance.GetOrderBatch(appId, storeId, batchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderBatchesApi.GetOrderBatch: " + e.Message );
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
 **batchId** | **int?**| Order Batch Id | 

### Return type

[**RestApiResultOrderBatch**](RestApiResultOrderBatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

