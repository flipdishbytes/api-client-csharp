# Flipdish.Api.MenuOptionSetsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuItemOptionSet**](MenuOptionSetsApi.md#createmenuitemoptionset) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Create menu item option set
[**DeleteMenuItemOptionSet**](MenuOptionSetsApi.md#deletemenuitemoptionset) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Delete menu item option set
[**DeleteOptionSetImage**](MenuOptionSetsApi.md#deleteoptionsetimage) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Delete option set image
[**GetMenuItemOptionSetById**](MenuOptionSetsApi.md#getmenuitemoptionsetbyid) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Get menu item option set by identifier
[**GetMenuItemOptionSets**](MenuOptionSetsApi.md#getmenuitemoptionsets) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Get menu item option sets
[**UpdateMenuItemOptionSet**](MenuOptionSetsApi.md#updatemenuitemoptionset) | **PATCH** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Update menu item option set
[**UploadOptionSetImage**](MenuOptionSetsApi.md#uploadoptionsetimage) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Upload menu item option set image


<a name="createmenuitemoptionset"></a>
# **CreateMenuItemOptionSet**
> Object CreateMenuItemOptionSet (int? menuId, int? menuSectionItemId, int? menuSectionId, MenuItemOptionSetBase menuItemOptionSet, string apiVersion)

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
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | Menu item option set
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create menu item option set
                Object result = apiInstance.CreateMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, menuItemOptionSet, apiVersion);
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)| Menu item option set | 
 **apiVersion** | **string**| API version | 

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
> void DeleteMenuItemOptionSet (int? menuId, int? menuSectionItemId, int? menuSectionId, int? optionSetId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu item option set
                apiInstance.DeleteMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId, apiVersion);
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
 **apiVersion** | **string**| API version | 

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
> void DeleteOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete option set image
                apiInstance.DeleteOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId, apiVersion);
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
 **apiVersion** | **string**| API version | 

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
> RestApiResultMenuItemOptionSet GetMenuItemOptionSetById (int? menuId, int? menuSectionItemId, int? menuSectionId, int? optionSetId, string apiVersion)

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
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var optionSetId = 56;  // int? | Menu item option set identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu item option set by identifier
                RestApiResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSetById(menuId, menuSectionItemId, menuSectionId, optionSetId, apiVersion);
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **optionSetId** | **int?**| Menu item option set identifier | 
 **apiVersion** | **string**| API version | 

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
> RestApiArrayResultMenuItemOptionSet GetMenuItemOptionSets (int? menuId, int? menuSectionItemId, int? menuSectionId, string apiVersion)

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
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu item option sets
                RestApiArrayResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSets(menuId, menuSectionItemId, menuSectionId, apiVersion);
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **apiVersion** | **string**| API version | 

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
> void UpdateMenuItemOptionSet (int? menuId, int? menuSectionItemId, int? menuSectionId, int? optionSetId, MenuItemOptionSetBase menuItemOptionSet, string apiVersion)

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
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var optionSetId = 56;  // int? | Option set identifier
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | Menu item option set (delta)
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Update menu item option set
                apiInstance.UpdateMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId, menuItemOptionSet, apiVersion);
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **optionSetId** | **int?**| Option set identifier | 
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)| Menu item option set (delta) | 
 **apiVersion** | **string**| API version | 

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
> RestApiStringResult UploadOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, string apiVersion, System.IO.Stream image)

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
            var apiVersion = apiVersion_example;  // string | API version
            var image = new System.IO.Stream(); // System.IO.Stream | Option set image

            try
            {
                // Upload menu item option set image
                RestApiStringResult result = apiInstance.UploadOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId, apiVersion, image);
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
 **apiVersion** | **string**| API version | 
 **image** | **System.IO.Stream**| Option set image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

