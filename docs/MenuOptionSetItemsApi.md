# Flipdish.Api.MenuOptionSetItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#addmenuitemoptionsetitem) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | Create menu item option set item
[**DeleteOptionSetItemImage**](MenuOptionSetItemsApi.md#deleteoptionsetitemimage) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | Delete menu item option set item image
[**GetMenuItemOptionSetItemById**](MenuOptionSetItemsApi.md#getmenuitemoptionsetitembyid) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Get menu item option set item by identifier
[**GetMenuItemOptionSetItems**](MenuOptionSetItemsApi.md#getmenuitemoptionsetitems) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | Get menu item option set items
[**RemoveMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#removemenuitemoptionsetitem) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Delete menu item option set item
[**UpdateMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#updatemenuitemoptionsetitem) | **PATCH** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Update menu item option set item
[**UploadOptionSetItemImage**](MenuOptionSetItemsApi.md#uploadoptionsetitemimage) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | Upload menu item option set item image


<a name="addmenuitemoptionsetitem"></a>
# **AddMenuItemOptionSetItem**
> Object AddMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, MenuItemOptionSetItemBase menuItemOptionSetItem, string apiVersion)

Create menu item option set item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddMenuItemOptionSetItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItem = new MenuItemOptionSetItemBase(); // MenuItemOptionSetItemBase | Option set item
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create menu item option set item
                Object result = apiInstance.AddMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItem, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.AddMenuItemOptionSetItem: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItem** | [**MenuItemOptionSetItemBase**](MenuItemOptionSetItemBase.md)| Option set item | 
 **apiVersion** | **string**| API version | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoptionsetitemimage"></a>
# **DeleteOptionSetItemImage**
> void DeleteOptionSetItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, string apiVersion)

Delete menu item option set item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteOptionSetItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItemId = 56;  // int? | Option set item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu item option set item image
                apiInstance.DeleteOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.DeleteOptionSetItemImage: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItemId** | **int?**| Option set item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsetitembyid"></a>
# **GetMenuItemOptionSetItemById**
> RestApiResultMenuItemOptionSetItem GetMenuItemOptionSetItemById (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, string apiVersion)

Get menu item option set item by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetItemByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItemId = 56;  // int? | Option set item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu item option set item by identifier
                RestApiResultMenuItemOptionSetItem result = apiInstance.GetMenuItemOptionSetItemById(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.GetMenuItemOptionSetItemById: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItemId** | **int?**| Option set item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiResultMenuItemOptionSetItem**](RestApiResultMenuItemOptionSetItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsetitems"></a>
# **GetMenuItemOptionSetItems**
> RestApiArrayResultMenuItemOptionSetItem GetMenuItemOptionSetItems (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, string apiVersion)

Get menu item option set items

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu item option set items
                RestApiArrayResultMenuItemOptionSetItem result = apiInstance.GetMenuItemOptionSetItems(menuId, menuSectionId, menuSectionItemId, optionSetId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.GetMenuItemOptionSetItems: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiArrayResultMenuItemOptionSetItem**](RestApiArrayResultMenuItemOptionSetItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removemenuitemoptionsetitem"></a>
# **RemoveMenuItemOptionSetItem**
> void RemoveMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, string apiVersion)

Delete menu item option set item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveMenuItemOptionSetItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItemId = 56;  // int? | Option set item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu item option set item
                apiInstance.RemoveMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.RemoveMenuItemOptionSetItem: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItemId** | **int?**| Option set item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenuitemoptionsetitem"></a>
# **UpdateMenuItemOptionSetItem**
> void UpdateMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, MenuItemOptionSetItemBase menuItemOptionSetItem, string apiVersion)

Update menu item option set item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuItemOptionSetItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItemId = 56;  // int? | Option set item identifier
            var menuItemOptionSetItem = new MenuItemOptionSetItemBase(); // MenuItemOptionSetItemBase | Option set item (delta)
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Update menu item option set item
                apiInstance.UpdateMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, menuItemOptionSetItem, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.UpdateMenuItemOptionSetItem: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItemId** | **int?**| Option set item identifier | 
 **menuItemOptionSetItem** | [**MenuItemOptionSetItemBase**](MenuItemOptionSetItemBase.md)| Option set item (delta) | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadoptionsetitemimage"></a>
# **UploadOptionSetItemImage**
> RestApiStringResult UploadOptionSetItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, string apiVersion, System.IO.Stream image)

Upload menu item option set item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadOptionSetItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSetItemId = 56;  // int? | Option set item identifier
            var apiVersion = apiVersion_example;  // string | API version
            var image = new System.IO.Stream(); // System.IO.Stream | Option set item image

            try
            {
                // Upload menu item option set item image
                RestApiStringResult result = apiInstance.UploadOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, apiVersion, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.UploadOptionSetItemImage: " + e.Message );
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
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSetItemId** | **int?**| Option set item identifier | 
 **apiVersion** | **string**| API version | 
 **image** | **System.IO.Stream**| Option set item image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

