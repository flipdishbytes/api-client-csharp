# Flipdish.Api.OrderBatchingConfigurationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](OrderBatchingConfigurationApi.md#get) | **GET** /api/v1.0/stores/{storeId}/order-batching-configuration | 
[**Post**](OrderBatchingConfigurationApi.md#post) | **POST** /api/v1.0/stores/{storeId}/order-batching-configuration | 


<a name="get"></a>
# **Get**
> RestApiResultOrderBatchingConfiguration Get (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderBatchingConfigurationApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultOrderBatchingConfiguration result = apiInstance.Get(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderBatchingConfigurationApi.Get: " + e.Message );
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

[**RestApiResultOrderBatchingConfiguration**](RestApiResultOrderBatchingConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> void Post (int? storeId, SetOrderBatchingConfiguration setOrderBatchingConfiguration)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderBatchingConfigurationApi();
            var storeId = 56;  // int? | 
            var setOrderBatchingConfiguration = new SetOrderBatchingConfiguration(); // SetOrderBatchingConfiguration | 

            try
            {
                apiInstance.Post(storeId, setOrderBatchingConfiguration);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderBatchingConfigurationApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **setOrderBatchingConfiguration** | [**SetOrderBatchingConfiguration**](SetOrderBatchingConfiguration.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

