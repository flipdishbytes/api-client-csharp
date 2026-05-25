# Flipdish.Api.MenusNutritionInfoApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateMenuItemNutritionInfo**](MenusNutritionInfoApi.md#addorupdatemenuitemnutritioninfo) | **POST** /api/v1.0/menus/{menuId}/menuItem/{publicId}/nutrition | 
[**AddOrUpdateMenuItemOptionSetItemNutritionInfo**](MenusNutritionInfoApi.md#addorupdatemenuitemoptionsetitemnutritioninfo) | **POST** /api/v1.0/menus/{menuId}/menuItemOption/{publicId}/nutrition | 
[**AddOrUpdateMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#addorupdatemenunutritioninfobymenuid) | **POST** /api/v1.0/menus/{menuId}/nutrition | 
[**DeleteMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#deletemenunutritioninfobymenuid) | **DELETE** /api/v1.0/menus/{menuId}/nutrition | 
[**GetAllergens**](MenusNutritionInfoApi.md#getallergens) | **GET** /api/v1.0/{appId}/menus/nutrition/allergens | 
[**GetMenuNutritionInfoByMenuId**](MenusNutritionInfoApi.md#getmenunutritioninfobymenuid) | **GET** /api/v1.0/menus/{menuId}/nutrition | 


<a name="addorupdatemenuitemnutritioninfo"></a>
# **AddOrUpdateMenuItemNutritionInfo**
> RestApiResultMenuNutritionInfoHeader AddOrUpdateMenuItemNutritionInfo (int? menuId, string publicId, ItemNutritionInfoAddUpdateModel addOrUpdateModel)



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
            var menuId = 56;  // int? | 
            var publicId = publicId_example;  // string | 
            var addOrUpdateModel = new ItemNutritionInfoAddUpdateModel(); // ItemNutritionInfoAddUpdateModel | 

            try
            {
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
 **menuId** | **int?**|  | 
 **publicId** | **string**|  | 
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
            var menuId = 56;  // int? | 
            var publicId = new Guid?(); // Guid? | 
            var addOrUpdateModel = new ItemNutritionInfoAddUpdateModel(); // ItemNutritionInfoAddUpdateModel | 

            try
            {
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
 **menuId** | **int?**|  | 
 **publicId** | [**Guid?**](Guid?.md)|  | 
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
            var menuId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 

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
            var menuId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 

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
            var menuId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 

### Return type

[**RestApiResultNutritionInfo**](RestApiResultNutritionInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

