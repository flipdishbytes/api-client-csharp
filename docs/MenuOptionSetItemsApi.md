# Flipdish.Api.MenuOptionSetItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#addmenuitemoptionsetitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | 
[**DeleteOptionSetItemImage**](MenuOptionSetItemsApi.md#deleteoptionsetitemimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | 
[**GetMenuItemOptionSetItemById**](MenuOptionSetItemsApi.md#getmenuitemoptionsetitembyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Get menu item option set item by identifier
[**GetMenuItemOptionSetItems**](MenuOptionSetItemsApi.md#getmenuitemoptionsetitems) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | Get menu item option set items
[**RemoveMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#removemenuitemoptionsetitem) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | 
[**SetOptionSetItemTax**](MenuOptionSetItemsApi.md#setoptionsetitemtax) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/taxrate/{taxRateId} | 
[**UpdateMenuItemOptionSetItem**](MenuOptionSetItemsApi.md#updatemenuitemoptionsetitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | 
[**UploadOptionSetItemImage**](MenuOptionSetItemsApi.md#uploadoptionsetitemimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | 


<a name="addmenuitemoptionsetitem"></a>
# **AddMenuItemOptionSetItem**
> Object AddMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, MenuItemOptionSetItemBase menuItemOptionSetItem)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItem = new MenuItemOptionSetItemBase(); // MenuItemOptionSetItemBase | 

            try
            {
                Object result = apiInstance.AddMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItem);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItem** | [**MenuItemOptionSetItemBase**](MenuItemOptionSetItemBase.md)|  | 

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
> void DeleteOptionSetItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItemId = 56;  // int? | 

            try
            {
                apiInstance.DeleteOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItemId** | **int?**|  | 

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
> RestApiResultMenuItemOptionSetItem GetMenuItemOptionSetItemById (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId)

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

            try
            {
                // Get menu item option set item by identifier
                RestApiResultMenuItemOptionSetItem result = apiInstance.GetMenuItemOptionSetItemById(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
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
> RestApiArrayResultMenuItemOptionSetItem GetMenuItemOptionSetItems (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId)

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

            try
            {
                // Get menu item option set items
                RestApiArrayResultMenuItemOptionSetItem result = apiInstance.GetMenuItemOptionSetItems(menuId, menuSectionId, menuSectionItemId, optionSetId);
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
> void RemoveMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItemId = 56;  // int? | 

            try
            {
                apiInstance.RemoveMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItemId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setoptionsetitemtax"></a>
# **SetOptionSetItemTax**
> void SetOptionSetItemTax (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, int? taxRateId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetOptionSetItemTaxExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetItemsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItemId = 56;  // int? | 
            var taxRateId = 56;  // int? | 

            try
            {
                apiInstance.SetOptionSetItemTax(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, taxRateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetItemsApi.SetOptionSetItemTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItemId** | **int?**|  | 
 **taxRateId** | **int?**|  | 

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
> void UpdateMenuItemOptionSetItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, MenuItemOptionSetItemBase menuItemOptionSetItem, double? undoAfter = null)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItemId = 56;  // int? | 
            var menuItemOptionSetItem = new MenuItemOptionSetItemBase(); // MenuItemOptionSetItemBase | 
            var undoAfter = 1.2;  // double? |  (optional) 

            try
            {
                apiInstance.UpdateMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, menuItemOptionSetItem, undoAfter);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItemId** | **int?**|  | 
 **menuItemOptionSetItem** | [**MenuItemOptionSetItemBase**](MenuItemOptionSetItemBase.md)|  | 
 **undoAfter** | **double?**|  | [optional] 

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
> RestApiStringResult UploadOptionSetItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, int? menuItemOptionSetItemId, System.IO.Stream image)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSetItemId = 56;  // int? | 
            var image = new System.IO.Stream(); // System.IO.Stream | Option set item image

            try
            {
                RestApiStringResult result = apiInstance.UploadOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, image);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSetItemId** | **int?**|  | 
 **image** | **System.IO.Stream**| Option set item image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

