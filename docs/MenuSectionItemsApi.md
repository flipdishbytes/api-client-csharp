# Flipdish.Api.MenuSectionItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloneMenuSectionItem**](MenuSectionItemsApi.md#clonemenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/clone | 
[**CreateMenuSectionItem**](MenuSectionItemsApi.md#createmenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | 
[**CreateMenuSectionItemFromCatalogItems**](MenuSectionItemsApi.md#createmenusectionitemfromcatalogitems) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/add-catalogitems | 
[**DeleteMenuSectionItem**](MenuSectionItemsApi.md#deletemenusectionitem) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | 
[**DeleteMenuSectionItemImage**](MenuSectionItemsApi.md#deletemenusectionitemimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | 
[**GetMenuItemById**](MenuSectionItemsApi.md#getmenuitembyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Get menu item by identifier
[**GetMenuItems**](MenuSectionItemsApi.md#getmenuitems) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | Get menu items
[**MoveMenuItem**](MenuSectionItemsApi.md#movemenuitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/setorder/{destinationDisplayOrder} | 
[**SetSectionItemTax**](MenuSectionItemsApi.md#setsectionitemtax) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/taxrate/{taxRateId} | 
[**UpdateMenuSectionItem**](MenuSectionItemsApi.md#updatemenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | 
[**UploadMenuSectionItemImage**](MenuSectionItemsApi.md#uploadmenusectionitemimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | 


<a name="clonemenusectionitem"></a>
# **CloneMenuSectionItem**
> RestApiResultMenuSectionItem CloneMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CloneMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 

            try
            {
                RestApiResultMenuSectionItem result = apiInstance.CloneMenuSectionItem(menuId, menuSectionId, menuSectionItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.CloneMenuSectionItem: " + e.Message );
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

### Return type

[**RestApiResultMenuSectionItem**](RestApiResultMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmenusectionitem"></a>
# **CreateMenuSectionItem**
> Object CreateMenuSectionItem (int? menuId, int? menuSectionId, MenuSectionItemBase menuSectionItem)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItem = new MenuSectionItemBase(); // MenuSectionItemBase | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItem** | [**MenuSectionItemBase**](MenuSectionItemBase.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmenusectionitemfromcatalogitems"></a>
# **CreateMenuSectionItemFromCatalogItems**
> Object CreateMenuSectionItemFromCatalogItems (int? menuId, int? menuSectionId, CreateMenuSectionItemFromCatalogItems createFromCatalogItems)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuSectionItemFromCatalogItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var createFromCatalogItems = new CreateMenuSectionItemFromCatalogItems(); // CreateMenuSectionItemFromCatalogItems | 

            try
            {
                Object result = apiInstance.CreateMenuSectionItemFromCatalogItems(menuId, menuSectionId, createFromCatalogItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.CreateMenuSectionItemFromCatalogItems: " + e.Message );
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
 **createFromCatalogItems** | [**CreateMenuSectionItemFromCatalogItems**](CreateMenuSectionItemFromCatalogItems.md)|  | 

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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 

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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 

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
> RestApiResultMenuSectionItem GetMenuItemById (int? menuId, int? menuSectionId, int? menuSectionItemId)

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
                RestApiResultMenuSectionItem result = apiInstance.GetMenuItemById(menuId, menuSectionId, menuSectionItemId);
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

[**RestApiResultMenuSectionItem**](RestApiResultMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitems"></a>
# **GetMenuItems**
> RestApiArrayResultMenuSectionItem GetMenuItems (int? menuId, int? menuSectionId)

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
                RestApiArrayResultMenuSectionItem result = apiInstance.GetMenuItems(menuId, menuSectionId);
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

[**RestApiArrayResultMenuSectionItem**](RestApiArrayResultMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movemenuitem"></a>
# **MoveMenuItem**
> void MoveMenuItem (int? menuId, int? menuSectionId, int? menuSectionItemId, int? destinationDisplayOrder)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MoveMenuItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var destinationDisplayOrder = 56;  // int? | 

            try
            {
                apiInstance.MoveMenuItem(menuId, menuSectionId, menuSectionItemId, destinationDisplayOrder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.MoveMenuItem: " + e.Message );
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
 **destinationDisplayOrder** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsectionitemtax"></a>
# **SetSectionItemTax**
> void SetSectionItemTax (int? menuId, int? menuSectionId, int? menuSectionItemId, int? taxRateId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetSectionItemTaxExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var taxRateId = 56;  // int? | 

            try
            {
                apiInstance.SetSectionItemTax(menuId, menuSectionId, menuSectionItemId, taxRateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.SetSectionItemTax: " + e.Message );
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
 **taxRateId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenusectionitem"></a>
# **UpdateMenuSectionItem**
> void UpdateMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId, MenuSectionItemBase menuSectionItem, double? undoAfter = null)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var menuSectionItem = new MenuSectionItemBase(); // MenuSectionItemBase | 
            var undoAfter = 1.2;  // double? |  (optional) 

            try
            {
                apiInstance.UpdateMenuSectionItem(menuId, menuSectionId, menuSectionItemId, menuSectionItem, undoAfter);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **menuSectionItem** | [**MenuSectionItemBase**](MenuSectionItemBase.md)|  | 
 **undoAfter** | **double?**|  | [optional] 

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
> RestApiStringResult UploadMenuSectionItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, System.IO.Stream image)



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
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var image = new System.IO.Stream(); // System.IO.Stream | Menu section item image

            try
            {
                RestApiStringResult result = apiInstance.UploadMenuSectionItemImage(menuId, menuSectionId, menuSectionItemId, image);
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
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **image** | **System.IO.Stream**| Menu section item image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

