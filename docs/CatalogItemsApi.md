# Flipdish.Api.CatalogItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCatalogItem**](CatalogItemsApi.md#createcatalogitem) | **POST** /api/v1.0/{appId}/catalog/items | Create an item product
[**GetById**](CatalogItemsApi.md#getbyid) | **GET** /api/v1.0/{appId}/catalog/items/{catalogItemId} | Get item by Id
[**GetItems**](CatalogItemsApi.md#getitems) | **GET** /api/v1.0/{appId}/catalog/items | Get paginated items by app name id filtered by types


<a name="createcatalogitem"></a>
# **CreateCatalogItem**
> RestApiResultCatalogItem CreateCatalogItem (string appId, CreateCatalogItem createCatalogItem)

Create an item product

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateCatalogItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogItemsApi();
            var appId = appId_example;  // string | 
            var createCatalogItem = new CreateCatalogItem(); // CreateCatalogItem | 

            try
            {
                // Create an item product
                RestApiResultCatalogItem result = apiInstance.CreateCatalogItem(appId, createCatalogItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.CreateCatalogItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **createCatalogItem** | [**CreateCatalogItem**](CreateCatalogItem.md)|  | 

### Return type

[**RestApiResultCatalogItem**](RestApiResultCatalogItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> CatalogItem GetById (string appId, string catalogItemId)

Get item by Id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogItemsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                // Get item by Id
                CatalogItem result = apiInstance.GetById(appId, catalogItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetById: " + e.Message );
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

[**CatalogItem**](CatalogItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitems"></a>
# **GetItems**
> RestApiPaginationResultCatalogItem GetItems (string appId, List<string> itemTypes, string searchTerm = null, int? page = null, int? limit = null)

Get paginated items by app name id filtered by types

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogItemsApi();
            var appId = appId_example;  // string | 
            var itemTypes = itemTypes_example;  // List<string> | 
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get paginated items by app name id filtered by types
                RestApiPaginationResultCatalogItem result = apiInstance.GetItems(appId, itemTypes, searchTerm, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **itemTypes** | **List&lt;string&gt;**|  | 
 **searchTerm** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultCatalogItem**](RestApiPaginationResultCatalogItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

