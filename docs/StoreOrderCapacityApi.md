# Flipdish.Api.StoreOrderCapacityApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStoreOrderCapacity**](StoreOrderCapacityApi.md#getstoreordercapacity) | **GET** /api/v1.0/{appId}/storeordercapacity/{storeId}/{deliveryType} | Get store&#39;s order capacity configuration
[**UpdateStoreOrderCapacityConfig**](StoreOrderCapacityApi.md#updatestoreordercapacityconfig) | **POST** /api/v1.0/{appId}/storeordercapacity/{storeId} | Create or update a store&#39;s order capacity configuration


<a name="getstoreordercapacity"></a>
# **GetStoreOrderCapacity**
> RestApiResultStoreOrderCapacityConfig GetStoreOrderCapacity (string appId, int? storeId, string deliveryType)

Get store's order capacity configuration

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
            var appId = appId_example;  // string | App Name Id
            var storeId = 56;  // int? | Store Id
            var deliveryType = deliveryType_example;  // string | Delivery / Pickup

            try
            {
                // Get store's order capacity configuration
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
 **appId** | **string**| App Name Id | 
 **storeId** | **int?**| Store Id | 
 **deliveryType** | **string**| Delivery / Pickup | 

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

Create or update a store's order capacity configuration

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
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | Delivery / Pickup
            var newOrderCapacityConfig = new StoreOrderCapacityConfigEditModel(); // StoreOrderCapacityConfigEditModel | new order capacity configuration
            var appId = appId_example;  // string | 

            try
            {
                // Create or update a store's order capacity configuration
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
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| Delivery / Pickup | 
 **newOrderCapacityConfig** | [**StoreOrderCapacityConfigEditModel**](StoreOrderCapacityConfigEditModel.md)| new order capacity configuration | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

