# Flipdish.Api.StoresApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStoreById**](StoresApi.md#getstorebyid) | **GET** /api/v1.0/stores/{storeId} | Get store by identifier
[**GetStores**](StoresApi.md#getstores) | **GET** /api/v1.0/stores | Get all stores
[**UpdateStoreAddress**](StoresApi.md#updatestoreaddress) | **POST** /api/v1.0/stores/{storeId}/address | Update store address
[**UpdateStoreAddressCoordinates**](StoresApi.md#updatestoreaddresscoordinates) | **POST** /api/v1.0/stores/{storeId}/address/coordinates | Update store address coordinates


<a name="getstorebyid"></a>
# **GetStoreById**
> RestApiResultStore GetStoreById (int? storeId)

Get store by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Get store by identifier
                RestApiResultStore result = apiInstance.GetStoreById(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> RestApiPaginationResultStore GetStores (string searchQuery = null, int? page = null, int? limit = null)

Get all stores

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var searchQuery = searchQuery_example;  // string | Search query (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get all stores
                RestApiPaginationResultStore result = apiInstance.GetStores(searchQuery, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchQuery** | **string**| Search query | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultStore**](RestApiPaginationResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreaddress"></a>
# **UpdateStoreAddress**
> RestApiResultStoreAddress UpdateStoreAddress (int? storeId, StoreAddressBase storeAddress)

Update store address

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreAddressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var storeAddress = new StoreAddressBase(); // StoreAddressBase | Store address

            try
            {
                // Update store address
                RestApiResultStoreAddress result = apiInstance.UpdateStoreAddress(storeId, storeAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStoreAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **storeAddress** | [**StoreAddressBase**](StoreAddressBase.md)| Store address | 

### Return type

[**RestApiResultStoreAddress**](RestApiResultStoreAddress.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreaddresscoordinates"></a>
# **UpdateStoreAddressCoordinates**
> RestApiResultCoordinates UpdateStoreAddressCoordinates (int? storeId, Coordinates coordinates)

Update store address coordinates

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreAddressCoordinatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var coordinates = new Coordinates(); // Coordinates | Store address coordinates

            try
            {
                // Update store address coordinates
                RestApiResultCoordinates result = apiInstance.UpdateStoreAddressCoordinates(storeId, coordinates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStoreAddressCoordinates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **coordinates** | [**Coordinates**](Coordinates.md)| Store address coordinates | 

### Return type

[**RestApiResultCoordinates**](RestApiResultCoordinates.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

