# Flipdish.Api.MenusApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMenuImage**](MenusApi.md#deletemenuimage) | **DELETE** /api/v1.0/menus/{menuId}/image | Delete menu image
[**DeleteMenuItemMetadata**](MenusApi.md#deletemenuitemmetadata) | **DELETE** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Delete menu item metadata
[**GetMenuById**](MenusApi.md#getmenubyid) | **GET** /api/v1.0/menus/{menuId} | Get menu by identifier
[**GetMenuItemMetadata**](MenusApi.md#getmenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Get menu item metadata
[**GetMenuItemMetadata_0**](MenusApi.md#getmenuitemmetadata_0) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Get menu item metadata by key
[**GetMenuItemOptionSetItemMetadata**](MenusApi.md#getmenuitemoptionsetitemmetadata) | **GET** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Get menu item option set item metadata by key
[**SetMenuItemMetadata**](MenusApi.md#setmenuitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Update menu item metadata
[**SetMenuItemOptionSetItemMetadata**](MenusApi.md#setmenuitemoptionsetitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Update menu item option set item metadata
[**UpdateMenu**](MenusApi.md#updatemenu) | **POST** /api/v1.0/menus/{menuId} | Update menu
[**UploadMenuImage**](MenusApi.md#uploadmenuimage) | **POST** /api/v1.0/menus/{menuId}/image | Upload menu image


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

<a name="getmenuitemmetadata_0"></a>
# **GetMenuItemMetadata_0**
> void GetMenuItemMetadata_0 (int? menuId, int? storeId, int? menuItemId, string key)

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
    public class GetMenuItemMetadata_0Example
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
                apiInstance.GetMenuItemMetadata_0(menuId, storeId, menuItemId, key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenuItemMetadata_0: " + e.Message );
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

