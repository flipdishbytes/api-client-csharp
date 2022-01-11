# Flipdish.Api.ProductsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveProduct**](ProductsApi.md#archiveproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId}/archive | Archive a product. If the product is used in Menus, the related MenuItems will be marked as deleted
[**DuplicateProduct**](ProductsApi.md#duplicateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId}/duplicate | Duplicate a product
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /api/v1.0/{appId}/catalog/products | Get paginated products by app name id filtered by product types


<a name="archiveproduct"></a>
# **ArchiveProduct**
> void ArchiveProduct (string appId, string productId)

Archive a product. If the product is used in Menus, the related MenuItems will be marked as deleted

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ArchiveProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // Archive a product. If the product is used in Menus, the related MenuItems will be marked as deleted
                apiInstance.ArchiveProduct(appId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ArchiveProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicateproduct"></a>
# **DuplicateProduct**
> RestApiResultProduct DuplicateProduct (string appId, string productId)

Duplicate a product

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DuplicateProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // Duplicate a product
                RestApiResultProduct result = apiInstance.DuplicateProduct(appId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.DuplicateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**RestApiResultProduct**](RestApiResultProduct.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproducts"></a>
# **GetProducts**
> RestApiPaginationResultProduct GetProducts (string appId, List<string> productTypes, string searchTerm = null, int? page = null, int? limit = null)

Get paginated products by app name id filtered by product types

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var productTypes = productTypes_example;  // List<string> | 
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get paginated products by app name id filtered by product types
                RestApiPaginationResultProduct result = apiInstance.GetProducts(appId, productTypes, searchTerm, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **productTypes** | **List&lt;string&gt;**|  | 
 **searchTerm** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultProduct**](RestApiPaginationResultProduct.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

