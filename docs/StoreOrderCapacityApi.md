# Flipdish.Api.StoreOrderCapacityApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStoreOrderCapacity**](StoreOrderCapacityApi.md#getstoreordercapacity) | **GET** /api/v1.0/{appId}/storeordercapacity/{storeId}/{deliveryType} | 
[**UpdateStoreOrderCapacityConfig**](StoreOrderCapacityApi.md#updatestoreordercapacityconfig) | **POST** /api/v1.0/{appId}/storeordercapacity/{storeId} | 


<a name="getstoreordercapacity"></a>
# **GetStoreOrderCapacity**
> RestApiResultStoreOrderCapacityConfig GetStoreOrderCapacity (string appId, int? storeId, string deliveryType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreOrderCapacityExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreOrderCapacityApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 

            try
            {
                RestApiResultStoreOrderCapacityConfig result = apiInstance.GetStoreOrderCapacity(appId, storeId, deliveryType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreOrderCapacityApi.GetStoreOrderCapacity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 

### Return type

[**RestApiResultStoreOrderCapacityConfig**](RestApiResultStoreOrderCapacityConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreordercapacityconfig"></a>
# **UpdateStoreOrderCapacityConfig**
> void UpdateStoreOrderCapacityConfig (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreOrderCapacityConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreOrderCapacityApi();
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
            var newOrderCapacityConfig = new StoreOrderCapacityConfigEditModel(); // StoreOrderCapacityConfigEditModel | 
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.UpdateStoreOrderCapacityConfig(storeId, deliveryType, newOrderCapacityConfig, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreOrderCapacityApi.UpdateStoreOrderCapacityConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 
 **newOrderCapacityConfig** | [**StoreOrderCapacityConfigEditModel**](StoreOrderCapacityConfigEditModel.md)|  | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

