# Flipdish.Api.CatalogChangesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPendingMenuChanges**](CatalogChangesApi.md#getpendingmenuchanges) | **GET** /api/v1.0/{appId}/menus/catalog-changes | Get menu pending changes from Catalog groups and items
[**PublishPendingMenuChanges**](CatalogChangesApi.md#publishpendingmenuchanges) | **POST** /api/v1.0/{appId}/menus/catalog-changes/publish | Update menus with the pending changes from Catalog groups and items


<a name="getpendingmenuchanges"></a>
# **GetPendingMenuChanges**
> RestApiPaginationResultPendingMenuChanges GetPendingMenuChanges (string appId, int? menuId = null, string catalogItemId = null, int? page = null, int? limit = null)

Get menu pending changes from Catalog groups and items

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPendingMenuChangesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogChangesApi();
            var appId = appId_example;  // string | 
            var menuId = 56;  // int? |  (optional) 
            var catalogItemId = catalogItemId_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get menu pending changes from Catalog groups and items
                RestApiPaginationResultPendingMenuChanges result = apiInstance.GetPendingMenuChanges(appId, menuId, catalogItemId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogChangesApi.GetPendingMenuChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **menuId** | **int?**|  | [optional] 
 **catalogItemId** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultPendingMenuChanges**](RestApiPaginationResultPendingMenuChanges.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishpendingmenuchanges"></a>
# **PublishPendingMenuChanges**
> void PublishPendingMenuChanges (string appId, PublishMenuChanges publishMenuChanges)

Update menus with the pending changes from Catalog groups and items

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PublishPendingMenuChangesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogChangesApi();
            var appId = appId_example;  // string | 
            var publishMenuChanges = new PublishMenuChanges(); // PublishMenuChanges | 

            try
            {
                // Update menus with the pending changes from Catalog groups and items
                apiInstance.PublishPendingMenuChanges(appId, publishMenuChanges);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogChangesApi.PublishPendingMenuChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **publishMenuChanges** | [**PublishMenuChanges**](PublishMenuChanges.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

