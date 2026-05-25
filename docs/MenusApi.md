# Flipdish.Api.MenusApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDraftMenuFromExistingMenu**](MenusApi.md#createdraftmenufromexistingmenu) | **POST** /api/v1.0/menus/{menuId}/clone/{newName} | 
[**CreateNewMenuAsync**](MenusApi.md#createnewmenuasync) | **POST** /api/v1.0/{appId}/menus/async | 
[**CreateNewMenuForApp**](MenusApi.md#createnewmenuforapp) | **POST** /api/v1.0/{appId}/menus | 
[**DeleteMenu**](MenusApi.md#deletemenu) | **DELETE** /api/v1.0/menus/{menuId} | 
[**DeleteMenuImage**](MenusApi.md#deletemenuimage) | **DELETE** /api/v1.0/menus/{menuId}/image | 
[**DeleteMenuItemMetadata**](MenusApi.md#deletemenuitemmetadata) | **DELETE** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | 
[**DeleteTaxRate**](MenusApi.md#deletetaxrate) | **DELETE** /api/v1.0/menus/{menuId}/tax/{taxId} | 
[**GetAllMenuMetadataByMenuIdAndStoreId**](MenusApi.md#getallmenumetadatabymenuidandstoreid) | **GET** /api/v1.0/menus/{menuId}/metadata/store/{storeId} | Get all menu metadata by menu ID and store ID
[**GetMenuBulkShowHide**](MenusApi.md#getmenubulkshowhide) | **GET** /api/v1.0/menus/{menuId}/bulkshowhide/list | 
[**GetMenuById**](MenusApi.md#getmenubyid) | **GET** /api/v1.0/menus/{menuId} | Get menu by identifier
[**GetMenuItemMetadata**](MenusApi.md#getmenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Get menu item metadata
[**GetMenuItemMetadataByKey**](MenusApi.md#getmenuitemmetadatabykey) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Get menu item metadata by key
[**GetMenuItemOptionSetItemMetadata**](MenusApi.md#getmenuitemoptionsetitemmetadata) | **GET** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Get menu item option set item metadata by key
[**GetMenuName**](MenusApi.md#getmenuname) | **GET** /api/v1.0/menus/{menuId}/name | Get Menus Name
[**GetMenuStoreNames**](MenusApi.md#getmenustorenames) | **GET** /api/v1.0/menus/{menuId}/stores | Get menus store names
[**GetMenuTaxDetails**](MenusApi.md#getmenutaxdetails) | **GET** /api/v1.0/menus/{menuId}/tax | Get menus tax details
[**GetMenusByAppId**](MenusApi.md#getmenusbyappid) | **GET** /api/v1.0/{appId}/menus | Get menus by appId
[**GetMenusCheckpoints**](MenusApi.md#getmenuscheckpoints) | **GET** /api/v1.0/menus/{menuId}/checkpoints | Get a Menus Checkpoints
[**RestoreAMenuCheckpoint**](MenusApi.md#restoreamenucheckpoint) | **POST** /api/v1.0/menus/{menuId}/checkpoints/{checkpointId}/restore | 
[**SetDisplayOnMenuTax**](MenusApi.md#setdisplayonmenutax) | **POST** /api/v1.0/menus/{menuId}/tax/show/{show} | 
[**SetItemDisplayOrders**](MenusApi.md#setitemdisplayorders) | **POST** /api/v1.0/menus/{menuId}/sectiondisplayorders | 
[**SetMenuItemMetadata**](MenusApi.md#setmenuitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | 
[**SetMenuItemOptionSetItemMetadata**](MenusApi.md#setmenuitemoptionsetitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | 
[**SetMenuLock**](MenusApi.md#setmenulock) | **POST** /api/v1.0/menus/{menuId}/lock | 
[**SetMenuName**](MenusApi.md#setmenuname) | **POST** /api/v1.0/menus/{menuId}/name | 
[**ShowHideBulkItems**](MenusApi.md#showhidebulkitems) | **POST** /api/v1.0/menus/{menuId}/bulkshowhide | 
[**UpdateMenu**](MenusApi.md#updatemenu) | **POST** /api/v1.0/menus/{menuId} | 
[**UpdateTaxType**](MenusApi.md#updatetaxtype) | **POST** /api/v1.0/menus/{menuId}/tax/type/{type} | 
[**UploadMenuImage**](MenusApi.md#uploadmenuimage) | **POST** /api/v1.0/menus/{menuId}/image | 
[**UploadNewMenuForApp**](MenusApi.md#uploadnewmenuforapp) | **POST** /api/v1.0/{appId}/menus/xlsx | 
[**UpsertTaxRate**](MenusApi.md#upserttaxrate) | **POST** /api/v1.0/menus/{menuId}/taxrate | 


<a name="createdraftmenufromexistingmenu"></a>
# **CreateDraftMenuFromExistingMenu**
> RestApiResultMenu CreateDraftMenuFromExistingMenu (int? menuId, string newName)



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
            var menuId = 56;  // int? | 
            var newName = newName_example;  // string | 

            try
            {
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
 **menuId** | **int?**|  | 
 **newName** | **string**|  | 

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
> Object CreateNewMenuAsync (string appId, CreateFullMenu menu, string orgId = null)



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
            var appId = appId_example;  // string | 
            var menu = new CreateFullMenu(); // CreateFullMenu | 
            var orgId = orgId_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.CreateNewMenuAsync(appId, menu, orgId);
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
 **appId** | **string**|  | 
 **menu** | [**CreateFullMenu**](CreateFullMenu.md)|  | 
 **orgId** | **string**|  | [optional] 

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
            var appId = appId_example;  // string | 
            var menu = new CreateFullMenu(); // CreateFullMenu | 

            try
            {
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
 **appId** | **string**|  | 
 **menu** | [**CreateFullMenu**](CreateFullMenu.md)|  | 

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
            var menuId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 

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
            var menuId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 

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
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var menuItemId = 56;  // int? | 
            var key = key_example;  // string | 

            try
            {
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
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **menuItemId** | **int?**|  | 
 **key** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaxrate"></a>
# **DeleteTaxRate**
> void DeleteTaxRate (int? menuId, int? taxId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteTaxRateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var taxId = 56;  // int? | 

            try
            {
                apiInstance.DeleteTaxRate(menuId, taxId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.DeleteTaxRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **taxId** | **int?**|  | 

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

<a name="getmenubulkshowhide"></a>
# **GetMenuBulkShowHide**
> RestApiArrayResultMenuElementListResponse GetMenuBulkShowHide (int? menuId, bool? isAvailable)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuBulkShowHideExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var isAvailable = true;  // bool? | 

            try
            {
                RestApiArrayResultMenuElementListResponse result = apiInstance.GetMenuBulkShowHide(menuId, isAvailable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuBulkShowHide: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **isAvailable** | **bool?**|  | 

### Return type

[**RestApiArrayResultMenuElementListResponse**](RestApiArrayResultMenuElementListResponse.md)

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

Get Menus Name

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
                // Get Menus Name
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

Get menus store names

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
                // Get menus store names
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

Get menus tax details

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
                // Get menus tax details
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

Get menus by appId

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
                // Get menus by appId
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

Get a Menus Checkpoints

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
                // Get a Menus Checkpoints
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
            var menuId = 56;  // int? | 
            var checkpointId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 
 **checkpointId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdisplayonmenutax"></a>
# **SetDisplayOnMenuTax**
> void SetDisplayOnMenuTax (int? menuId, bool? show)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetDisplayOnMenuTaxExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var show = true;  // bool? | 

            try
            {
                apiInstance.SetDisplayOnMenuTax(menuId, show);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetDisplayOnMenuTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **show** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setitemdisplayorders"></a>
# **SetItemDisplayOrders**
> void SetItemDisplayOrders (int? menuId, MenuObjectDisplayOrders displayOrders)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetItemDisplayOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var displayOrders = new MenuObjectDisplayOrders(); // MenuObjectDisplayOrders | 

            try
            {
                apiInstance.SetItemDisplayOrders(menuId, displayOrders);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.SetItemDisplayOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **displayOrders** | [**MenuObjectDisplayOrders**](MenuObjectDisplayOrders.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuitemmetadata"></a>
# **SetMenuItemMetadata**
> void SetMenuItemMetadata (int? menuId, int? storeId, int? menuItemId, Metadata metadata)



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
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var menuItemId = 56;  // int? | 
            var metadata = new Metadata(); // Metadata | 

            try
            {
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
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **menuItemId** | **int?**|  | 
 **metadata** | [**Metadata**](Metadata.md)|  | 

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
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var optionSetItemId = 56;  // int? | 
            var metadata = new Metadata(); // Metadata | 

            try
            {
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
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **optionSetItemId** | **int?**|  | 
 **metadata** | [**Metadata**](Metadata.md)|  | 

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
            var menuId = 56;  // int? | 
            var locked = true;  // bool? | 

            try
            {
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
 **menuId** | **int?**|  | 
 **locked** | **bool?**|  | 

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
            var menuId = 56;  // int? | 
            var name = name_example;  // string | 

            try
            {
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
 **menuId** | **int?**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showhidebulkitems"></a>
# **ShowHideBulkItems**
> RestApiArrayResultMenuElementEditResponse ShowHideBulkItems (int? menuId, List<MenuElementHide> menuElements, bool? isAvailable)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ShowHideBulkItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var menuElements = new List<MenuElementHide>(); // List<MenuElementHide> | 
            var isAvailable = true;  // bool? | 

            try
            {
                RestApiArrayResultMenuElementEditResponse result = apiInstance.ShowHideBulkItems(menuId, menuElements, isAvailable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.ShowHideBulkItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuElements** | [**List&lt;MenuElementHide&gt;**](MenuElementHide.md)|  | 
 **isAvailable** | **bool?**|  | 

### Return type

[**RestApiArrayResultMenuElementEditResponse**](RestApiArrayResultMenuElementEditResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenu"></a>
# **UpdateMenu**
> void UpdateMenu (int? menuId, MenuBase menu)



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
            var menuId = 56;  // int? | 
            var menu = new MenuBase(); // MenuBase | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menu** | [**MenuBase**](MenuBase.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaxtype"></a>
# **UpdateTaxType**
> void UpdateTaxType (int? menuId, string type)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateTaxTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var type = type_example;  // string | 

            try
            {
                apiInstance.UpdateTaxType(menuId, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.UpdateTaxType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **type** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenuimage"></a>
# **UploadMenuImage**
> RestApiStringResult UploadMenuImage (int? menuId, System.IO.Stream image)



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
            var menuId = 56;  // int? | 
            var image = new System.IO.Stream(); // System.IO.Stream | Menu image

            try
            {
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
 **menuId** | **int?**|  | 
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
            var appId = appId_example;  // string | 
            var menu = new System.IO.Stream(); // System.IO.Stream | Uploaded xlsx menu

            try
            {
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
 **appId** | **string**|  | 
 **menu** | **System.IO.Stream**| Uploaded xlsx menu | 

### Return type

**int?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upserttaxrate"></a>
# **UpsertTaxRate**
> MenuTaxRate UpsertTaxRate (int? menuId, MenuTaxRate taxRate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpsertTaxRateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusApi();
            var menuId = 56;  // int? | 
            var taxRate = new MenuTaxRate(); // MenuTaxRate | 

            try
            {
                MenuTaxRate result = apiInstance.UpsertTaxRate(menuId, taxRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.UpsertTaxRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **taxRate** | [**MenuTaxRate**](MenuTaxRate.md)|  | 

### Return type

[**MenuTaxRate**](MenuTaxRate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

