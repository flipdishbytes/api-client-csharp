# Flipdish.Api.MenusApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDraftMenuFromExistingMenu**](MenusApi.md#createdraftmenufromexistingmenu) | **POST** /api/v1.0/menus/{menuId}/clone/{newName} | [PRIVATE API] Clone a menu, (without attaching stores)
[**CreateNewMenuAsync**](MenusApi.md#createnewmenuasync) | **POST** /api/v1.0/{appId}/menus/async | Create a new menu asynchronously
[**CreateNewMenuForApp**](MenusApi.md#createnewmenuforapp) | **POST** /api/v1.0/{appId}/menus | Create a new menu
[**DeleteMenu**](MenusApi.md#deletemenu) | **DELETE** /api/v1.0/menus/{menuId} | [PRIVATE API] Mark a Menu as Deleted
[**DeleteMenuImage**](MenusApi.md#deletemenuimage) | **DELETE** /api/v1.0/menus/{menuId}/image | Delete menu image
[**DeleteMenuItemMetadata**](MenusApi.md#deletemenuitemmetadata) | **DELETE** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Delete menu item metadata
[**GetAllMenuMetadataByMenuIdAndStoreId**](MenusApi.md#getallmenumetadatabymenuidandstoreid) | **GET** /api/v1.0/menus/{menuId}/metadata/store/{storeId} | Get all menu metadata by menu ID and store ID
[**GetMenuById**](MenusApi.md#getmenubyid) | **GET** /api/v1.0/menus/{menuId} | Get menu by identifier
[**GetMenuItemMetadata**](MenusApi.md#getmenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Get menu item metadata
[**GetMenuItemMetadataByKey**](MenusApi.md#getmenuitemmetadatabykey) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Get menu item metadata by key
[**GetMenuItemOptionSetItemMetadata**](MenusApi.md#getmenuitemoptionsetitemmetadata) | **GET** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Get menu item option set item metadata by key
[**GetMenuName**](MenusApi.md#getmenuname) | **GET** /api/v1.0/menus/{menuId}/name | [PRIVATE API] Get Menus Name
[**GetMenuStoreNames**](MenusApi.md#getmenustorenames) | **GET** /api/v1.0/menus/{menuId}/stores | [PRIVATE API] Get menus store names
[**GetMenuTaxDetails**](MenusApi.md#getmenutaxdetails) | **GET** /api/v1.0/menus/{menuId}/tax | [PRIVATE API] Get menus tax details
[**GetMenusByAppId**](MenusApi.md#getmenusbyappid) | **GET** /api/v1.0/{appId}/menus | [PRIVATE API] Get menus by appId
[**GetMenusCheckpoints**](MenusApi.md#getmenuscheckpoints) | **GET** /api/v1.0/menus/{menuId}/checkpoints | [PRIVATE API]Get a Menus Checkpoints
[**MenusDeleteTaxRate**](MenusApi.md#menusdeletetaxrate) | **DELETE** /api/v1.0/menus/{menuId}/tax/{taxId} | [PRIVATE API] Remove a Menus Tax Rate, can only remove a tax rate that does not have items/optionSetItems attached
[**MenusGetMenuBulkShowHide**](MenusApi.md#menusgetmenubulkshowhide) | **GET** /api/v1.0/menus/{menuId}/bulkshowhide/list | Get bulk show/hide menu items and option set items
[**MenusSetDisplayOnMenuTax**](MenusApi.md#menussetdisplayonmenutax) | **POST** /api/v1.0/menus/{menuId}/tax/show/{show} | [PRIVATE API] Set if tax shows for a Menu
[**MenusSetItemDisplayOrders**](MenusApi.md#menussetitemdisplayorders) | **POST** /api/v1.0/menus/{menuId}/sectiondisplayorders | [PRIVATE API] Re-arrange Sections within a Menu
[**MenusShowHideBulkItems**](MenusApi.md#menusshowhidebulkitems) | **POST** /api/v1.0/menus/{menuId}/bulkshowhide | Bulk show/hide menu items or option set items
[**MenusUpdateTaxType**](MenusApi.md#menusupdatetaxtype) | **POST** /api/v1.0/menus/{menuId}/tax/type/{type} | [PRIVATE API] Set the type of Tax on a Menu
[**MenusUpsertTaxRate**](MenusApi.md#menusupserttaxrate) | **POST** /api/v1.0/menus/{menuId}/taxrate | [PRIVATE API] Add/Update a Tax Rate
[**RestoreAMenuCheckpoint**](MenusApi.md#restoreamenucheckpoint) | **POST** /api/v1.0/menus/{menuId}/checkpoints/{checkpointId}/restore | [PRIVATE API] Restore a Menu to a checkpoint
[**SetMenuItemMetadata**](MenusApi.md#setmenuitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Update menu item metadata
[**SetMenuItemOptionSetItemMetadata**](MenusApi.md#setmenuitemoptionsetitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Update menu item option set item metadata
[**SetMenuLock**](MenusApi.md#setmenulock) | **POST** /api/v1.0/menus/{menuId}/lock | [PRIVATE API] Lock/Unlock a Menu for Editing
[**SetMenuName**](MenusApi.md#setmenuname) | **POST** /api/v1.0/menus/{menuId}/name | [PRIVATE API] Set Menus Name
[**UpdateMenu**](MenusApi.md#updatemenu) | **POST** /api/v1.0/menus/{menuId} | Update menu
[**UploadMenuImage**](MenusApi.md#uploadmenuimage) | **POST** /api/v1.0/menus/{menuId}/image | Upload menu image
[**UploadNewMenuForApp**](MenusApi.md#uploadnewmenuforapp) | **POST** /api/v1.0/{appId}/menus/xlsx | Create a new menu from xlsx file.


<a name="createdraftmenufromexistingmenu"></a>
# **CreateDraftMenuFromExistingMenu**
> RestApiResultMenu CreateDraftMenuFromExistingMenu (int? menuId, string newName)

[PRIVATE API] Clone a menu, (without attaching stores)

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateDraftMenuFromExistingMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var newName = newName_example;  // string | Name of the new Menu

            try
            {
                // [PRIVATE API] Clone a menu, (without attaching stores)
                RestApiResultMenu result = apiInstance.CreateDraftMenuFromExistingMenu(menuId, newName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.CreateDraftMenuFromExistingMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **newName** | **string**| Name of the new Menu | 

### Return type

[**RestApiResultMenu**](RestApiResultMenu.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnewmenuasync"></a>
# **CreateNewMenuAsync**
> Object CreateNewMenuAsync (string appId, CreateFullMenu menu)

Create a new menu asynchronously

You must listen to the webhook menu.async_creation.completed to know when the menu is ready

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateNewMenuAsyncExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var appId = appId_example;  // string | App id
            var menu = new CreateFullMenu(); // CreateFullMenu | Menu

            try
            {
                // Create a new menu asynchronously
                Object result = apiInstance.CreateNewMenuAsync(appId, menu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.CreateNewMenuAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App id | 
 **menu** | [**CreateFullMenu**](CreateFullMenu.md)| Menu | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnewmenuforapp"></a>
# **CreateNewMenuForApp**
> int? CreateNewMenuForApp (string appId, CreateFullMenu menu)

Create a new menu

[DEPRECATED] - Please use the async version as this endpoint may timeout for large menus

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateNewMenuForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var appId = appId_example;  // string | App identifier
            var menu = new CreateFullMenu(); // CreateFullMenu | Menu. If empty the system will create a menu with default items

            try
            {
                // Create a new menu
                int? result = apiInstance.CreateNewMenuForApp(appId, menu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.CreateNewMenuForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App identifier | 
 **menu** | [**CreateFullMenu**](CreateFullMenu.md)| Menu. If empty the system will create a menu with default items | 

### Return type

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenu"></a>
# **DeleteMenu**
> void DeleteMenu (int? menuId)

[PRIVATE API] Mark a Menu as Deleted

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu Identifier

            try
            {
                // [PRIVATE API] Mark a Menu as Deleted
                apiInstance.DeleteMenu(menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.DeleteMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu Identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuimage"></a>
# **DeleteMenuImage**
> void DeleteMenuImage (int? menuId)

Delete menu image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Delete menu image
                apiInstance.DeleteMenuImage(menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.DeleteMenuImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuitemmetadata"></a>
# **DeleteMenuItemMetadata**
> void DeleteMenuItemMetadata (int? menuId, int? storeId, int? menuItemId, string key)

Delete menu item metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuItemMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var menuItemId = 56;  // int? | Menu item identifier
            var key = key_example;  // string | Metadata key

            try
            {
                // Delete menu item metadata
                apiInstance.DeleteMenuItemMetadata(menuId, storeId, menuItemId, key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.DeleteMenuItemMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **menuItemId** | **int?**| Menu item identifier | 
 **key** | **string**| Metadata key | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmenumetadatabymenuidandstoreid"></a>
# **GetAllMenuMetadataByMenuIdAndStoreId**
> RestApiArrayResultAllMetadataResult GetAllMenuMetadataByMenuIdAndStoreId (int? menuId, int? storeId)

Get all menu metadata by menu ID and store ID

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllMenuMetadataByMenuIdAndStoreIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Get all menu metadata by menu ID and store ID
                RestApiArrayResultAllMetadataResult result = apiInstance.GetAllMenuMetadataByMenuIdAndStoreId(menuId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetAllMenuMetadataByMenuIdAndStoreId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 

### Return type

[**RestApiArrayResultAllMetadataResult**](RestApiArrayResultAllMetadataResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenubyid"></a>
# **GetMenuById**
> RestApiResultMenu GetMenuById (int? menuId)

Get menu by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Get menu by identifier
                RestApiResultMenu result = apiInstance.GetMenuById(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

[**RestApiResultMenu**](RestApiResultMenu.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemmetadata"></a>
# **GetMenuItemMetadata**
> RestApiArrayResultMetadata GetMenuItemMetadata (int? menuId, int? storeId, int? menuItemId)

Get menu item metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var menuItemId = 56;  // int? | Menu item identifier

            try
            {
                // Get menu item metadata
                RestApiArrayResultMetadata result = apiInstance.GetMenuItemMetadata(menuId, storeId, menuItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuItemMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **menuItemId** | **int?**| Menu item identifier | 

### Return type

[**RestApiArrayResultMetadata**](RestApiArrayResultMetadata.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemmetadatabykey"></a>
# **GetMenuItemMetadataByKey**
> RestApiResultMetadata GetMenuItemMetadataByKey (int? menuId, int? storeId, int? menuItemId, string key)

Get menu item metadata by key

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemMetadataByKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var menuItemId = 56;  // int? | Menu item identifier
            var key = key_example;  // string | Metadata key

            try
            {
                // Get menu item metadata by key
                RestApiResultMetadata result = apiInstance.GetMenuItemMetadataByKey(menuId, storeId, menuItemId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuItemMetadataByKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **menuItemId** | **int?**| Menu item identifier | 
 **key** | **string**| Metadata key | 

### Return type

[**RestApiResultMetadata**](RestApiResultMetadata.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsetitemmetadata"></a>
# **GetMenuItemOptionSetItemMetadata**
> RestApiResultMetadata GetMenuItemOptionSetItemMetadata (int? menuId, int? storeId, int? optionSetItemId)

Get menu item option set item metadata by key

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetItemMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var optionSetItemId = 56;  // int? | Menu item option set item identifier

            try
            {
                // Get menu item option set item metadata by key
                RestApiResultMetadata result = apiInstance.GetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuItemOptionSetItemMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **optionSetItemId** | **int?**| Menu item option set item identifier | 

### Return type

[**RestApiResultMetadata**](RestApiResultMetadata.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuname"></a>
# **GetMenuName**
> string GetMenuName (int? menuId)

[PRIVATE API] Get Menus Name

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // [PRIVATE API] Get Menus Name
                string result = apiInstance.GetMenuName(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenustorenames"></a>
# **GetMenuStoreNames**
> RestApiArrayResultMenuStoreNames GetMenuStoreNames (int? menuId)

[PRIVATE API] Get menus store names

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuStoreNamesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // [PRIVATE API] Get menus store names
                RestApiArrayResultMenuStoreNames result = apiInstance.GetMenuStoreNames(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuStoreNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

[**RestApiArrayResultMenuStoreNames**](RestApiArrayResultMenuStoreNames.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenutaxdetails"></a>
# **GetMenuTaxDetails**
> RestApiArrayResultMenuTaxDetails GetMenuTaxDetails (int? menuId)

[PRIVATE API] Get menus tax details

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuTaxDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // [PRIVATE API] Get menus tax details
                RestApiArrayResultMenuTaxDetails result = apiInstance.GetMenuTaxDetails(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuTaxDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

[**RestApiArrayResultMenuTaxDetails**](RestApiArrayResultMenuTaxDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenusbyappid"></a>
# **GetMenusByAppId**
> RestApiArrayResultMenuSummary GetMenusByAppId (string appId)

[PRIVATE API] Get menus by appId

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenusByAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var appId = appId_example;  // string | Get Menus for this appId

            try
            {
                // [PRIVATE API] Get menus by appId
                RestApiArrayResultMenuSummary result = apiInstance.GetMenusByAppId(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenusByAppId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Get Menus for this appId | 

### Return type

[**RestApiArrayResultMenuSummary**](RestApiArrayResultMenuSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuscheckpoints"></a>
# **GetMenusCheckpoints**
> RestApiArrayResultMenuCheckpoint GetMenusCheckpoints (int? menuId)

[PRIVATE API]Get a Menus Checkpoints

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenusCheckpointsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // [PRIVATE API]Get a Menus Checkpoints
                RestApiArrayResultMenuCheckpoint result = apiInstance.GetMenusCheckpoints(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenusCheckpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

[**RestApiArrayResultMenuCheckpoint**](RestApiArrayResultMenuCheckpoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menusdeletetaxrate"></a>
# **MenusDeleteTaxRate**
> void MenusDeleteTaxRate (int? menuId, int? taxId)

[PRIVATE API] Remove a Menus Tax Rate, can only remove a tax rate that does not have items/optionSetItems attached

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusDeleteTaxRateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var taxId = 56;  // int? | Id of Menu Tax to be removed

            try
            {
                // [PRIVATE API] Remove a Menus Tax Rate, can only remove a tax rate that does not have items/optionSetItems attached
                apiInstance.MenusDeleteTaxRate(menuId, taxId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusDeleteTaxRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **taxId** | **int?**| Id of Menu Tax to be removed | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menusgetmenubulkshowhide"></a>
# **MenusGetMenuBulkShowHide**
> RestApiArrayResultMenuElementListResponse MenusGetMenuBulkShowHide (int? menuId, bool? isAvailable)

Get bulk show/hide menu items and option set items

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusGetMenuBulkShowHideExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu id
            var isAvailable = true;  // bool? | Is available flag

            try
            {
                // Get bulk show/hide menu items and option set items
                RestApiArrayResultMenuElementListResponse result = apiInstance.MenusGetMenuBulkShowHide(menuId, isAvailable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusGetMenuBulkShowHide: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu id | 
 **isAvailable** | **bool?**| Is available flag | 

### Return type

[**RestApiArrayResultMenuElementListResponse**](RestApiArrayResultMenuElementListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menussetdisplayonmenutax"></a>
# **MenusSetDisplayOnMenuTax**
> void MenusSetDisplayOnMenuTax (int? menuId, bool? show)

[PRIVATE API] Set if tax shows for a Menu

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusSetDisplayOnMenuTaxExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var show = true;  // bool? | Boolean show or dont show tax (Exclusive tax type can only ever be TRUE)

            try
            {
                // [PRIVATE API] Set if tax shows for a Menu
                apiInstance.MenusSetDisplayOnMenuTax(menuId, show);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusSetDisplayOnMenuTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **show** | **bool?**| Boolean show or dont show tax (Exclusive tax type can only ever be TRUE) | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menussetitemdisplayorders"></a>
# **MenusSetItemDisplayOrders**
> void MenusSetItemDisplayOrders (int? menuId, MenuObjectDisplayOrders displayOrders)

[PRIVATE API] Re-arrange Sections within a Menu

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusSetItemDisplayOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var displayOrders = new MenuObjectDisplayOrders(); // MenuObjectDisplayOrders | Section Ids and their new display order

            try
            {
                // [PRIVATE API] Re-arrange Sections within a Menu
                apiInstance.MenusSetItemDisplayOrders(menuId, displayOrders);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusSetItemDisplayOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **displayOrders** | [**MenuObjectDisplayOrders**](MenuObjectDisplayOrders.md)| Section Ids and their new display order | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menusshowhidebulkitems"></a>
# **MenusShowHideBulkItems**
> RestApiArrayResultMenuElementEditResponse MenusShowHideBulkItems (int? menuId, List<MenuElementHide> menuElements, bool? isAvailable)

Bulk show/hide menu items or option set items

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusShowHideBulkItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu id
            var menuElements = new List<MenuElementHide>(); // List<MenuElementHide> | Elements to be show/hide
            var isAvailable = true;  // bool? | Is available flag

            try
            {
                // Bulk show/hide menu items or option set items
                RestApiArrayResultMenuElementEditResponse result = apiInstance.MenusShowHideBulkItems(menuId, menuElements, isAvailable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusShowHideBulkItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu id | 
 **menuElements** | [**List&lt;MenuElementHide&gt;**](MenuElementHide.md)| Elements to be show/hide | 
 **isAvailable** | **bool?**| Is available flag | 

### Return type

[**RestApiArrayResultMenuElementEditResponse**](RestApiArrayResultMenuElementEditResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menusupdatetaxtype"></a>
# **MenusUpdateTaxType**
> void MenusUpdateTaxType (int? menuId, string type)

[PRIVATE API] Set the type of Tax on a Menu

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusUpdateTaxTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var type = type_example;  // string | Type of Tax

            try
            {
                // [PRIVATE API] Set the type of Tax on a Menu
                apiInstance.MenusUpdateTaxType(menuId, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusUpdateTaxType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **type** | **string**| Type of Tax | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menusupserttaxrate"></a>
# **MenusUpsertTaxRate**
> MenuTaxRate MenusUpsertTaxRate (int? menuId, MenuTaxRate taxRate)

[PRIVATE API] Add/Update a Tax Rate

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MenusUpsertTaxRateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var taxRate = new MenuTaxRate(); // MenuTaxRate | Tax rate to add/update

            try
            {
                // [PRIVATE API] Add/Update a Tax Rate
                MenuTaxRate result = apiInstance.MenusUpsertTaxRate(menuId, taxRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.MenusUpsertTaxRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **taxRate** | [**MenuTaxRate**](MenuTaxRate.md)| Tax rate to add/update | 

### Return type

[**MenuTaxRate**](MenuTaxRate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restoreamenucheckpoint"></a>
# **RestoreAMenuCheckpoint**
> void RestoreAMenuCheckpoint (int? menuId, int? checkpointId)

[PRIVATE API] Restore a Menu to a checkpoint

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RestoreAMenuCheckpointExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var checkpointId = 56;  // int? | Checkpoint to restore menu to

            try
            {
                // [PRIVATE API] Restore a Menu to a checkpoint
                apiInstance.RestoreAMenuCheckpoint(menuId, checkpointId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.RestoreAMenuCheckpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **checkpointId** | **int?**| Checkpoint to restore menu to | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuitemmetadata"></a>
# **SetMenuItemMetadata**
> void SetMenuItemMetadata (int? menuId, int? storeId, int? menuItemId, Metadata metadata)

Update menu item metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuItemMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var menuItemId = 56;  // int? | Menu item identifier
            var metadata = new Metadata(); // Metadata | Metadata object

            try
            {
                // Update menu item metadata
                apiInstance.SetMenuItemMetadata(menuId, storeId, menuItemId, metadata);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetMenuItemMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **menuItemId** | **int?**| Menu item identifier | 
 **metadata** | [**Metadata**](Metadata.md)| Metadata object | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuitemoptionsetitemmetadata"></a>
# **SetMenuItemOptionSetItemMetadata**
> void SetMenuItemOptionSetItemMetadata (int? menuId, int? storeId, int? optionSetItemId, Metadata metadata)

Update menu item option set item metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuItemOptionSetItemMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var storeId = 56;  // int? | Store identifier
            var optionSetItemId = 56;  // int? | Menu item option set item identifier
            var metadata = new Metadata(); // Metadata | Metadata object

            try
            {
                // Update menu item option set item metadata
                apiInstance.SetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId, metadata);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetMenuItemOptionSetItemMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **storeId** | **int?**| Store identifier | 
 **optionSetItemId** | **int?**| Menu item option set item identifier | 
 **metadata** | [**Metadata**](Metadata.md)| Metadata object | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenulock"></a>
# **SetMenuLock**
> void SetMenuLock (int? menuId, bool? locked)

[PRIVATE API] Lock/Unlock a Menu for Editing

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuLockExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var locked = true;  // bool? | True: Locks menu for editing, False: Unlocks for editing

            try
            {
                // [PRIVATE API] Lock/Unlock a Menu for Editing
                apiInstance.SetMenuLock(menuId, locked);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetMenuLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **locked** | **bool?**| True: Locks menu for editing, False: Unlocks for editing | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuname"></a>
# **SetMenuName**
> void SetMenuName (int? menuId, string name)

[PRIVATE API] Set Menus Name

[PRIVATE API]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var name = name_example;  // string | Name to set for this Menu

            try
            {
                // [PRIVATE API] Set Menus Name
                apiInstance.SetMenuName(menuId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetMenuName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **name** | **string**| Name to set for this Menu | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenu"></a>
# **UpdateMenu**
> void UpdateMenu (int? menuId, MenuBase menu)

Update menu

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var menu = new MenuBase(); // MenuBase | Full menu data

            try
            {
                // Update menu
                apiInstance.UpdateMenu(menuId, menu);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.UpdateMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menu** | [**MenuBase**](MenuBase.md)| Full menu data | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenuimage"></a>
# **UploadMenuImage**
> RestApiStringResult UploadMenuImage (int? menuId, System.IO.Stream image)

Upload menu image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | Menu identifier
            var image = new System.IO.Stream(); // System.IO.Stream | Menu image

            try
            {
                // Upload menu image
                RestApiStringResult result = apiInstance.UploadMenuImage(menuId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.UploadMenuImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **image** | **System.IO.Stream**| Menu image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadnewmenuforapp"></a>
# **UploadNewMenuForApp**
> int? UploadNewMenuForApp (string appId, System.IO.Stream menu)

Create a new menu from xlsx file.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadNewMenuForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var appId = appId_example;  // string | App identifier
            var menu = new System.IO.Stream(); // System.IO.Stream | Uploaded xlsx menu

            try
            {
                // Create a new menu from xlsx file.
                int? result = apiInstance.UploadNewMenuForApp(appId, menu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.UploadNewMenuForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App identifier | 
 **menu** | **System.IO.Stream**| Uploaded xlsx menu | 

### Return type

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

