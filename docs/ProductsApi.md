# Flipdish.Api.ProductsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveProduct**](ProductsApi.md#archiveproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId}/archive | Archive a product. If the product is used in Menus, the related MenuItems will be marked as deleted
[**CreateProduct**](ProductsApi.md#createproduct) | **POST** /api/v1.0/{appId}/catalog/products | Create a new product
[**DeleteProductImage**](ProductsApi.md#deleteproductimage) | **DELETE** /api/v1.0/{appId}/catalog/products/{productId}/image | 
[**DuplicateProduct**](ProductsApi.md#duplicateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId}/duplicate | Duplicate a product
[**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /api/v1.0/{appId}/catalog/products/{productId} | Get products by productId
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /api/v1.0/{appId}/catalog/products | Get paginated products by app name id filtered by product types
[**UpdateProduct**](ProductsApi.md#updateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId} | Update a product
[**UploadProductImage**](ProductsApi.md#uploadproductimage) | **POST** /api/v1.0/{appId}/catalog/products/{productId}/image | Upload a Product Image


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

<a name="createproduct"></a>
# **CreateProduct**
> RestApiResultProduct CreateProduct (string appId, CreateProduct product)

Create a new product

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var product = new CreateProduct(); // CreateProduct | 

            try
            {
                // Create a new product
                RestApiResultProduct result = apiInstance.CreateProduct(appId, product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **product** | [**CreateProduct**](CreateProduct.md)|  | 

### Return type

[**RestApiResultProduct**](RestApiResultProduct.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductimage"></a>
# **DeleteProductImage**
> void DeleteProductImage (string appId, string productId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteProductImageExample
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
                apiInstance.DeleteProductImage(appId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductImage: " + e.Message );
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

<a name="getproductbyid"></a>
# **GetProductById**
> Product GetProductById (string appId, string productId)

Get products by productId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProductByIdExample
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
                // Get products by productId
                Product result = apiInstance.GetProductById(appId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductById: " + e.Message );
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

[**Product**](Product.md)

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

<a name="updateproduct"></a>
# **UpdateProduct**
> void UpdateProduct (string appId, string productId, UpdateProduct product)

Update a product

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var productId = productId_example;  // string | 
            var product = new UpdateProduct(); // UpdateProduct | 

            try
            {
                // Update a product
                apiInstance.UpdateProduct(appId, productId, product);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProduct: " + e.Message );
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
 **product** | [**UpdateProduct**](UpdateProduct.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadproductimage"></a>
# **UploadProductImage**
> RestApiStringResult UploadProductImage (string appId, string productId, System.IO.Stream image)

Upload a Product Image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadProductImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var appId = appId_example;  // string | 
            var productId = productId_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | Product image

            try
            {
                // Upload a Product Image
                RestApiStringResult result = apiInstance.UploadProductImage(appId, productId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UploadProductImage: " + e.Message );
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
 **image** | **System.IO.Stream**| Product image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

