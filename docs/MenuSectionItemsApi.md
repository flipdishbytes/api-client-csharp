# Flipdish.Api.MenuSectionItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuSectionItem**](MenuSectionItemsApi.md#createmenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | Create menu section item
[**DeleteMenuSectionItem**](MenuSectionItemsApi.md#deletemenusectionitem) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Delete menu section item
[**DeleteMenuSectionItemImage**](MenuSectionItemsApi.md#deletemenusectionitemimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Delete menu section item image
[**GetMenuItemById**](MenuSectionItemsApi.md#getmenuitembyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Get menu item by identifier
[**GetMenuItems**](MenuSectionItemsApi.md#getmenuitems) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | Get menu items
[**UpdateMenuSectionItem**](MenuSectionItemsApi.md#updatemenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Update menu section item
[**UploadMenuSectionItemImage**](MenuSectionItemsApi.md#uploadmenusectionitemimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Upload menu section item image


<a name="createmenusectionitem"></a>
# **CreateMenuSectionItem**
> Object CreateMenuSectionItem (int? menuId, int? menuSectionId, FlipdishPublicModelsV1MenusMenuSectionItemBase menuSectionItem)

Create menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItem = new FlipdishPublicModelsV1MenusMenuSectionItemBase(); // FlipdishPublicModelsV1MenusMenuSectionItemBase | Menu section item

            try
            {
                // Create menu section item
                Object result = apiInstance.CreateMenuSectionItem(menuId, menuSectionId, menuSectionItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.CreateMenuSectionItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItem** | [**FlipdishPublicModelsV1MenusMenuSectionItemBase**](FlipdishPublicModelsV1MenusMenuSectionItemBase.md)| Menu section item | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusectionitem"></a>
# **DeleteMenuSectionItem**
> void DeleteMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId)

Delete menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier

            try
            {
                // Delete menu section item
                apiInstance.DeleteMenuSectionItem(menuId, menuSectionId, menuSectionItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.DeleteMenuSectionItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItemId** | **int?**| Menu section item identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusectionitemimage"></a>
# **DeleteMenuSectionItemImage**
> void DeleteMenuSectionItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId)

Delete menu section item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier

            try
            {
                // Delete menu section item image
                apiInstance.DeleteMenuSectionItemImage(menuId, menuSectionId, menuSectionItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.DeleteMenuSectionItemImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItemId** | **int?**| Menu section item identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitembyid"></a>
# **GetMenuItemById**
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSectionItem GetMenuItemById (int? menuId, int? menuSectionId, int? menuSectionItemId)

Get menu item by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu item identifier

            try
            {
                // Get menu item by identifier
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSectionItem result = apiInstance.GetMenuItemById(menuId, menuSectionId, menuSectionItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.GetMenuItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItemId** | **int?**| Menu item identifier | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSectionItem**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitems"></a>
# **GetMenuItems**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem GetMenuItems (int? menuId, int? menuSectionId)

Get menu items

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier

            try
            {
                // Get menu items
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem result = apiInstance.GetMenuItems(menuId, menuSectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.GetMenuItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenusectionitem"></a>
# **UpdateMenuSectionItem**
> void UpdateMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId, MenuSectionItemBase menuSectionItem)

Update menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionItem = new MenuSectionItemBase(); // MenuSectionItemBase | Menu section item (delta)

            try
            {
                // Update menu section item
                apiInstance.UpdateMenuSectionItem(menuId, menuSectionId, menuSectionItemId, menuSectionItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.UpdateMenuSectionItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionItem** | [**MenuSectionItemBase**](MenuSectionItemBase.md)| Menu section item (delta) | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenusectionitemimage"></a>
# **UploadMenuSectionItemImage**
> FlipdishPublicModelsV1ApiResultsRestApiStringResult UploadMenuSectionItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, System.IO.Stream image)

Upload menu section item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuSectionItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var image = new System.IO.Stream(); // System.IO.Stream | Menu section item image

            try
            {
                // Upload menu section item image
                FlipdishPublicModelsV1ApiResultsRestApiStringResult result = apiInstance.UploadMenuSectionItemImage(menuId, menuSectionId, menuSectionItemId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.UploadMenuSectionItemImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **image** | **System.IO.Stream**| Menu section item image | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiStringResult**](FlipdishPublicModelsV1ApiResultsRestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

