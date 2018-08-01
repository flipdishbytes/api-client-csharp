# Flipdish.Api.MenuOptionSetsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuItemOptionSet**](MenuOptionSetsApi.md#createmenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Create menu item option set
[**DeleteMenuItemOptionSet**](MenuOptionSetsApi.md#deletemenuitemoptionset) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Delete menu item option set
[**DeleteOptionSetImage**](MenuOptionSetsApi.md#deleteoptionsetimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Delete option set image
[**GetMenuItemOptionSetById**](MenuOptionSetsApi.md#getmenuitemoptionsetbyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Get menu item option set by identifier
[**GetMenuItemOptionSets**](MenuOptionSetsApi.md#getmenuitemoptionsets) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Get menu item option sets
[**UpdateMenuItemOptionSet**](MenuOptionSetsApi.md#updatemenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Update menu item option set
[**UploadOptionSetImage**](MenuOptionSetsApi.md#uploadoptionsetimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Upload menu item option set image


<a name="createmenuitemoptionset"></a>
# **CreateMenuItemOptionSet**
> Object CreateMenuItemOptionSet (int? menuId, int? menuSectionId, int? menuSectionItemId, MenuItemOptionSetBase menuItemOptionSet)

Create menu item option set

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | Menu item option set

            try
            {
                // Create menu item option set
                Object result = apiInstance.CreateMenuItemOptionSet(menuId, menuSectionId, menuSectionItemId, menuItemOptionSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.CreateMenuItemOptionSet: " + e.Message );
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
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)| Menu item option set | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuitemoptionset"></a>
# **DeleteMenuItemOptionSet**
> void DeleteMenuItemOptionSet (int? menuId, int? menuSectionItemId, int? menuSectionId, int? optionSetId)

Delete menu item option set

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var optionSetId = 56;  // int? | Option set identifier

            try
            {
                // Delete menu item option set
                apiInstance.DeleteMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.DeleteMenuItemOptionSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **optionSetId** | **int?**| Option set identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoptionsetimage"></a>
# **DeleteOptionSetImage**
> void DeleteOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId)

Delete option set image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteOptionSetImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier

            try
            {
                // Delete option set image
                apiInstance.DeleteOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.DeleteOptionSetImage: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsetbyid"></a>
# **GetMenuItemOptionSetById**
> RestApiResultMenuItemOptionSet GetMenuItemOptionSetById (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId)

Get menu item option set by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Menu item option set identifier

            try
            {
                // Get menu item option set by identifier
                RestApiResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSetById(menuId, menuSectionId, menuSectionItemId, optionSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.GetMenuItemOptionSetById: " + e.Message );
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
 **optionSetId** | **int?**| Menu item option set identifier | 

### Return type

[**RestApiResultMenuItemOptionSet**](RestApiResultMenuItemOptionSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsets"></a>
# **GetMenuItemOptionSets**
> RestApiArrayResultMenuItemOptionSet GetMenuItemOptionSets (int? menuId, int? menuSectionId, int? menuSectionItemId)

Get menu item option sets

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier

            try
            {
                // Get menu item option sets
                RestApiArrayResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSets(menuId, menuSectionId, menuSectionItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.GetMenuItemOptionSets: " + e.Message );
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

[**RestApiArrayResultMenuItemOptionSet**](RestApiArrayResultMenuItemOptionSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenuitemoptionset"></a>
# **UpdateMenuItemOptionSet**
> void UpdateMenuItemOptionSet (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, MenuItemOptionSetBase menuItemOptionSet)

Update menu item option set

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | Menu item option set (delta)

            try
            {
                // Update menu item option set
                apiInstance.UpdateMenuItemOptionSet(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSet);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.UpdateMenuItemOptionSet: " + e.Message );
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
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)| Menu item option set (delta) | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadoptionsetimage"></a>
# **UploadOptionSetImage**
> RestApiStringResult UploadOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, System.IO.Stream image)

Upload menu item option set image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadOptionSetImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Option set identifier
            var image = new System.IO.Stream(); // System.IO.Stream | Option set image

            try
            {
                // Upload menu item option set image
                RestApiStringResult result = apiInstance.UploadOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.UploadOptionSetImage: " + e.Message );
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
 **image** | **System.IO.Stream**| Option set image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

