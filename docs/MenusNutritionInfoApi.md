# Flipdish.Api.MenusNutritionInfoApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateMenuItemNutritionInfo**](MenusNutritionInfoApi.md#addorupdatemenuitemnutritioninfo) | **POST** /api/v1.0/menus/{menuId}/menuItem/{publicId}/nutrition | Add or update menuitem nutrition info by menu item&#39;s publicId
[**AddOrUpdateMenuItemOptionSetItemNutritionInfo**](MenusNutritionInfoApi.md#addorupdatemenuitemoptionsetitemnutritioninfo) | **POST** /api/v1.0/menus/{menuId}/menuItemOption/{publicId}/nutrition | Add or update menuitem optionsetitem nutrition info its publicId
[**AddOrUpdateMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#addorupdatemenunutritioninfobymenuid) | **POST** /api/v1.0/menus/{menuId}/nutrition | Add or update menu nutrition by identifier
[**DeleteMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#deletemenunutritioninfobymenuid) | **DELETE** /api/v1.0/menus/{menuId}/nutrition | Delete menu nutrition information by menuId
[**GetAllergens**](MenusNutritionInfoApi.md#getallergens) | **GET** /api/v1.0/{appId}/menus/nutrition/allergens | Get allergens
[**GetMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#getmenunutritioninfobymenuid) | **GET** /api/v1.0/menus/{menuId}/nutrition | Get menu nutrition by menuId


<a name="addorupdatemenuitemnutritioninfo"></a>
# **AddOrUpdateMenuItemNutritionInfo**
> RestApiResultMenuNutritionInfoHeader AddOrUpdateMenuItemNutritionInfo (int? menuId, string publicId, ItemNutritionInfoAddUpdateModel addOrUpdateModel)

Add or update menuitem nutrition info by menu item's publicId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrUpdateMenuItemNutritionInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var menuId = 56;  // int? | Menu identifier
            var publicId = publicId_example;  // string | Menu item's publicId
            var addOrUpdateModel = new ItemNutritionInfoAddUpdateModel(); // ItemNutritionInfoAddUpdateModel | 

            try
            {
                // Add or update menuitem nutrition info by menu item's publicId
                RestApiResultMenuNutritionInfoHeader result = apiInstance.AddOrUpdateMenuItemNutritionInfo(menuId, publicId, addOrUpdateModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.AddOrUpdateMenuItemNutritionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **publicId** | **string**| Menu item&#39;s publicId | 
 **addOrUpdateModel** | [**ItemNutritionInfoAddUpdateModel**](ItemNutritionInfoAddUpdateModel.md)|  | 

### Return type

[**RestApiResultMenuNutritionInfoHeader**](RestApiResultMenuNutritionInfoHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdatemenuitemoptionsetitemnutritioninfo"></a>
# **AddOrUpdateMenuItemOptionSetItemNutritionInfo**
> RestApiResultMenuNutritionInfoHeader AddOrUpdateMenuItemOptionSetItemNutritionInfo (int? menuId, Guid? publicId, ItemNutritionInfoAddUpdateModel addOrUpdateModel)

Add or update menuitem optionsetitem nutrition info its publicId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrUpdateMenuItemOptionSetItemNutritionInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var menuId = 56;  // int? | Menu identifier
            var publicId = new Guid?(); // Guid? | Menu item's publicId
            var addOrUpdateModel = new ItemNutritionInfoAddUpdateModel(); // ItemNutritionInfoAddUpdateModel | 

            try
            {
                // Add or update menuitem optionsetitem nutrition info its publicId
                RestApiResultMenuNutritionInfoHeader result = apiInstance.AddOrUpdateMenuItemOptionSetItemNutritionInfo(menuId, publicId, addOrUpdateModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.AddOrUpdateMenuItemOptionSetItemNutritionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **publicId** | [**Guid?**](Guid?.md)| Menu item&#39;s publicId | 
 **addOrUpdateModel** | [**ItemNutritionInfoAddUpdateModel**](ItemNutritionInfoAddUpdateModel.md)|  | 

### Return type

[**RestApiResultMenuNutritionInfoHeader**](RestApiResultMenuNutritionInfoHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdatemenunutritioninfobymenuid"></a>
# **AddOrUpdateMenuNutritionInfoByMenuId**
> RestApiResultMenuNutritionInfoHeader AddOrUpdateMenuNutritionInfoByMenuId (int? menuId)

Add or update menu nutrition by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrUpdateMenuNutritionInfoByMenuIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Add or update menu nutrition by identifier
                RestApiResultMenuNutritionInfoHeader result = apiInstance.AddOrUpdateMenuNutritionInfoByMenuId(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.AddOrUpdateMenuNutritionInfoByMenuId: " + e.Message );
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

[**RestApiResultMenuNutritionInfoHeader**](RestApiResultMenuNutritionInfoHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenunutritioninfobymenuid"></a>
# **DeleteMenuNutritionInfoByMenuId**
> Object DeleteMenuNutritionInfoByMenuId (int? menuId)

Delete menu nutrition information by menuId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuNutritionInfoByMenuIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Delete menu nutrition information by menuId
                Object result = apiInstance.DeleteMenuNutritionInfoByMenuId(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.DeleteMenuNutritionInfoByMenuId: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallergens"></a>
# **GetAllergens**
> RestApiArrayResultAllergen GetAllergens (string appId, string languageId = null)

Get allergens

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllergensExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var appId = appId_example;  // string | 
            var languageId = languageId_example;  // string |  (optional) 

            try
            {
                // Get allergens
                RestApiArrayResultAllergen result = apiInstance.GetAllergens(appId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.GetAllergens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **languageId** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultAllergen**](RestApiArrayResultAllergen.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenunutritioninfobymenuid"></a>
# **GetMenuNutritionInfoByMenuId**
> RestApiResultNutritionInfo GetMenuNutritionInfoByMenuId (int? menuId)

Get menu nutrition by menuId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuNutritionInfoByMenuIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Get menu nutrition by menuId
                RestApiResultNutritionInfo result = apiInstance.GetMenuNutritionInfoByMenuId(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoApi.GetMenuNutritionInfoByMenuId: " + e.Message );
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

[**RestApiResultNutritionInfo**](RestApiResultNutritionInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

