# Flipdish.Api.CatalogItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveCatalogItem**](CatalogItemsApi.md#archivecatalogitem) | **POST** /api/v1.0/{appId}/catalog/items/{catalogItemId}/archive | 
[**CreateCatalogItem**](CatalogItemsApi.md#createcatalogitem) | **POST** /api/v1.0/{appId}/catalog/items | 
[**DuplicateCatalogItem**](CatalogItemsApi.md#duplicatecatalogitem) | **POST** /api/v1.0/{appId}/catalog/items/{catalogItemId}/duplicate | 
[**GetCatalogItemById**](CatalogItemsApi.md#getcatalogitembyid) | **GET** /api/v1.0/{appId}/catalog/items/{catalogItemId} | 
[**GetItems**](CatalogItemsApi.md#getitems) | **GET** /api/v1.0/{appId}/catalog/items | 
[**UpdateCatalogItem**](CatalogItemsApi.md#updatecatalogitem) | **POST** /api/v1.0/{appId}/catalog/items/{catalogItemId} | 


<a name="archivecatalogitem"></a>
# **ArchiveCatalogItem**
> void ArchiveCatalogItem (string appId, string catalogItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ArchiveCatalogItemExample
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
                apiInstance.ArchiveCatalogItem(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.ArchiveCatalogItem: " + e.Message );
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

<a name="createcatalogitem"></a>
# **CreateCatalogItem**
> RestApiResultCatalogItem CreateCatalogItem (string appId, CreateCatalogItem createCatalogItem)



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

<a name="duplicatecatalogitem"></a>
# **DuplicateCatalogItem**
> void DuplicateCatalogItem (string appId, string catalogItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DuplicateCatalogItemExample
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
                apiInstance.DuplicateCatalogItem(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.DuplicateCatalogItem: " + e.Message );
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

<a name="getcatalogitembyid"></a>
# **GetCatalogItemById**
> CatalogItem GetCatalogItemById (string appId, string catalogItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCatalogItemByIdExample
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
                CatalogItem result = apiInstance.GetCatalogItemById(appId, catalogItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItemById: " + e.Message );
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

<a name="updatecatalogitem"></a>
# **UpdateCatalogItem**
> void UpdateCatalogItem (string appId, string catalogItemId, UpdateCatalogItem updateCatalogItem)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateCatalogItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogItemsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 
            var updateCatalogItem = new UpdateCatalogItem(); // UpdateCatalogItem | 

            try
            {
                apiInstance.UpdateCatalogItem(appId, catalogItemId, updateCatalogItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.UpdateCatalogItem: " + e.Message );
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
 **updateCatalogItem** | [**UpdateCatalogItem**](UpdateCatalogItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

