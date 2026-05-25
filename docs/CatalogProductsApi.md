# Flipdish.Api.CatalogProductsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveProduct**](CatalogProductsApi.md#archiveproduct) | **POST** /api/v1.0/{appId}/catalog/products/{catalogItemId}/archive | 
[**CreateProduct**](CatalogProductsApi.md#createproduct) | **POST** /api/v1.0/{appId}/catalog/products | 
[**DuplicateProduct**](CatalogProductsApi.md#duplicateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{catalogItemId}/duplicate | 
[**GetProductById**](CatalogProductsApi.md#getproductbyid) | **GET** /api/v1.0/{appId}/catalog/products/{catalogItemId} | 
[**GetProducts**](CatalogProductsApi.md#getproducts) | **GET** /api/v1.0/{appId}/catalog/products | 
[**UpdateProduct**](CatalogProductsApi.md#updateproduct) | **POST** /api/v1.0/{appId}/catalog/products/{catalogItemId} | 


<a name="archiveproduct"></a>
# **ArchiveProduct**
> void ArchiveProduct (string appId, string catalogItemId)



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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                apiInstance.ArchiveProduct(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.ArchiveProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

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
> RestApiResultProduct CreateProduct (string appId, CreateProduct createProduct)



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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var createProduct = new CreateProduct(); // CreateProduct | 

            try
            {
                RestApiResultProduct result = apiInstance.CreateProduct(appId, createProduct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **createProduct** | [**CreateProduct**](CreateProduct.md)|  | 

### Return type

[**RestApiResultProduct**](RestApiResultProduct.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicateproduct"></a>
# **DuplicateProduct**
> void DuplicateProduct (string appId, string catalogItemId)



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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                apiInstance.DuplicateProduct(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.DuplicateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductbyid"></a>
# **GetProductById**
> Product GetProductById (string appId, string catalogItemId)



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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                Product result = apiInstance.GetProductById(appId, catalogItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.GetProductById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var productTypes = productTypes_example;  // List<string> | 
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultProduct result = apiInstance.GetProducts(appId, productTypes, searchTerm, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.GetProducts: " + e.Message );
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
> void UpdateProduct (string appId, string catalogItemId, UpdateProduct updateProduct)



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

            var apiInstance = new CatalogProductsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 
            var updateProduct = new UpdateProduct(); // UpdateProduct | 

            try
            {
                apiInstance.UpdateProduct(appId, catalogItemId, updateProduct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogProductsApi.UpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 
 **updateProduct** | [**UpdateProduct**](UpdateProduct.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

