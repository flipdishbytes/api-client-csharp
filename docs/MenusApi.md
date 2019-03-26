# Flipdish.Api.MenusApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDraftMenuFromExistingMenu**](MenusApi.md#createdraftmenufromexistingmenu) | **POST** /api/v1.0/menus/{menuId}/clone | [PRIVATE API]Clone a menu, (without attaching stores)
[**CreateNewMenuForApp**](MenusApi.md#createnewmenuforapp) | **POST** /api/v1.0/{appId}/menus | [PRIVATE API]Create a new menu
[**DeleteMenu**](MenusApi.md#deletemenu) | **DELETE** /api/v1.0/menus/{menuId} | [PRIVATE API]Mark a Menu as Deleted
[**DeleteMenuImage**](MenusApi.md#deletemenuimage) | **DELETE** /api/v1.0/menus/{menuId}/image | Delete menu image
[**DeleteMenuItemMetadata**](MenusApi.md#deletemenuitemmetadata) | **DELETE** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Delete menu item metadata
[**GetMenuById**](MenusApi.md#getmenubyid) | **GET** /api/v1.0/menus/{menuId} | Get menu by identifier
[**GetMenuItemMetadata**](MenusApi.md#getmenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Get menu item metadata
[**GetMenuItemMetadataByKey**](MenusApi.md#getmenuitemmetadatabykey) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Get menu item metadata by key
[**GetMenuItemOptionSetItemMetadata**](MenusApi.md#getmenuitemoptionsetitemmetadata) | **GET** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Get menu item option set item metadata by key
[**GetMenuStoreNames**](MenusApi.md#getmenustorenames) | **GET** /api/v1.0/menus/{menuId}/stores | [PRIVATE API]Get menus store names
[**GetMenusByAppId**](MenusApi.md#getmenusbyappid) | **GET** /api/v1.0/{appId}/menus | [PRIVATE API]Get menus by appId
[**GetMenusCheckpoints**](MenusApi.md#getmenuscheckpoints) | **GET** /api/v1.0/menus/{menuId}/checkpoints | [PRIVATE API]Get a Menus Checkpoints
[**RestoreAMenuCheckpoint**](MenusApi.md#restoreamenucheckpoint) | **POST** /api/v1.0/menus/{menuId}/checkpoints/{checkpointId}/restore | [PRIVATE API]Restore a Menu to a checkpoint
[**SetMenuItemMetadata**](MenusApi.md#setmenuitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Update menu item metadata
[**SetMenuItemOptionSetItemMetadata**](MenusApi.md#setmenuitemoptionsetitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Update menu item option set item metadata
[**SetMenuLock**](MenusApi.md#setmenulock) | **POST** /api/v1.0/menus/{menuId}/lock | [PRIVATE API]Lock/Unlock a Menu for Editing
[**SetMenuName**](MenusApi.md#setmenuname) | **POST** /api/v1.0/menus/{menuId}/name | [PRIVATE API]Set Menus Name
[**UpdateMenu**](MenusApi.md#updatemenu) | **POST** /api/v1.0/menus/{menuId} | Update menu
[**UploadMenuImage**](MenusApi.md#uploadmenuimage) | **POST** /api/v1.0/menus/{menuId}/image | Upload menu image


<a name="createdraftmenufromexistingmenu"></a>
# **CreateDraftMenuFromExistingMenu**
> RestApiResultMenu CreateDraftMenuFromExistingMenu (int? menuId)

[PRIVATE API]Clone a menu, (without attaching stores)

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

            try
            {
                // [PRIVATE API]Clone a menu, (without attaching stores)
                RestApiResultMenu result = apiInstance.CreateDraftMenuFromExistingMenu(menuId);
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

### Return type

[**RestApiResultMenu**](RestApiResultMenu.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnewmenuforapp"></a>
# **CreateNewMenuForApp**
> int? CreateNewMenuForApp (string appId)

[PRIVATE API]Create a new menu

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

            try
            {
                // [PRIVATE API]Create a new menu
                int? result = apiInstance.CreateNewMenuForApp(appId);
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

### Return type

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenu"></a>
# **DeleteMenu**
> void DeleteMenu (int? menuId)

[PRIVATE API]Mark a Menu as Deleted

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
            var menuId = 56;  // int? | Get Menus for this appId

            try
            {
                // [PRIVATE API]Mark a Menu as Deleted
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
 **menuId** | **int?**| Get Menus for this appId | 

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
> void GetMenuItemMetadataByKey (int? menuId, int? storeId, int? menuItemId, string key)

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
                apiInstance.GetMenuItemMetadataByKey(menuId, storeId, menuItemId, key);
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

void (empty response body)

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

<a name="getmenustorenames"></a>
# **GetMenuStoreNames**
> RestApiArrayResultMenuStoreNames GetMenuStoreNames (int? menuId)

[PRIVATE API]Get menus store names

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
                // [PRIVATE API]Get menus store names
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

<a name="getmenusbyappid"></a>
# **GetMenusByAppId**
> RestApiArrayResultMenuSummary GetMenusByAppId (string appId)

[PRIVATE API]Get menus by appId

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
                // [PRIVATE API]Get menus by appId
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

<a name="restoreamenucheckpoint"></a>
# **RestoreAMenuCheckpoint**
> void RestoreAMenuCheckpoint (int? menuId, int? checkpointId)

[PRIVATE API]Restore a Menu to a checkpoint

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
                // [PRIVATE API]Restore a Menu to a checkpoint
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

[PRIVATE API]Lock/Unlock a Menu for Editing

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
                // [PRIVATE API]Lock/Unlock a Menu for Editing
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

[PRIVATE API]Set Menus Name

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
                // [PRIVATE API]Set Menus Name
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
            var menu = new MenuBase(); // MenuBase | Menu (delta)

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
 **menu** | [**MenuBase**](MenuBase.md)| Menu (delta) | 

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

