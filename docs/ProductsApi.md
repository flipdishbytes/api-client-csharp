# Flipdish.Api.ProductsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProduct**](ProductsApi.md#createproduct) | **POST** /api/v1.0/{appId}/catalog/products | Create a new product
[**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /api/v1.0/{appId}/catalog/product/{productId} | Get products by productId
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /api/v1.0/{appId}/catalog/products | Get products by app name id
[**UpdateProduct**](ProductsApi.md#updateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{productId} | Update a product


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
> RestApiPaginationResultProduct GetProducts (string appId, string searchTerm = null, int? page = null, int? limit = null)

Get products by app name id

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
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get products by app name id
                RestApiPaginationResultProduct result = apiInstance.GetProducts(appId, searchTerm, page, limit);
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

