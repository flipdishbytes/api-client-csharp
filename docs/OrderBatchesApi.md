# Flipdish.Api.OrderBatchesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllOrderBatches**](OrderBatchesApi.md#getallorderbatches) | **GET** /api/v1.0/{appId}/order-batches | 
[**GetOrderBatch**](OrderBatchesApi.md#getorderbatch) | **GET** /api/v1.0/{appId}/order-batches/{orderBatchId} | 


<a name="getallorderbatches"></a>
# **GetAllOrderBatches**
> RestApiArrayResultOrderBatch GetAllOrderBatches (string appId, List<int?> storeIds = null, DateTime? createdFrom = null, DateTime? createdTo = null)



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
            var appId = appId_example;  // string | 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 
            var createdFrom = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var createdTo = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                RestApiArrayResultOrderBatch result = apiInstance.GetAllOrderBatches(appId, storeIds, createdFrom, createdTo);
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
 **appId** | **string**|  | 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **createdFrom** | **DateTime?**|  | [optional] 
 **createdTo** | **DateTime?**|  | [optional] 

### Return type

[**RestApiArrayResultOrderBatch**](RestApiArrayResultOrderBatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbatch"></a>
# **GetOrderBatch**
> RestApiResultOrderBatch GetOrderBatch (string appId, int? orderBatchId)



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
            var appId = appId_example;  // string | 
            var orderBatchId = 56;  // int? | 

            try
            {
                RestApiResultOrderBatch result = apiInstance.GetOrderBatch(appId, orderBatchId);
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
 **appId** | **string**|  | 
 **orderBatchId** | **int?**|  | 

### Return type

[**RestApiResultOrderBatch**](RestApiResultOrderBatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

