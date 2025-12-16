# Flipdish.Api.LightspeedApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LightspeedGenerateMenu**](LightspeedApi.md#lightspeedgeneratemenu) | **POST** /api/v1.0/lightspeed/{storeId}/menu/generate | 
[**LightspeedGetStoreSettings**](LightspeedApi.md#lightspeedgetstoresettings) | **GET** /api/v1.0/lightspeed/{storeId}/settings | 
[**LightspeedSaveStoreSettings**](LightspeedApi.md#lightspeedsavestoresettings) | **POST** /api/v1.0/lightspeed/{storeId}/settings | 


<a name="lightspeedgeneratemenu"></a>
# **LightspeedGenerateMenu**
> Object LightspeedGenerateMenu (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LightspeedGenerateMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LightspeedApi();
            var storeId = 56;  // int? | 

            try
            {
                Object result = apiInstance.LightspeedGenerateMenu(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.LightspeedGenerateMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lightspeedgetstoresettings"></a>
# **LightspeedGetStoreSettings**
> RestApiResultLightspeedSettings LightspeedGetStoreSettings (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LightspeedGetStoreSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LightspeedApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultLightspeedSettings result = apiInstance.LightspeedGetStoreSettings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.LightspeedGetStoreSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultLightspeedSettings**](RestApiResultLightspeedSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lightspeedsavestoresettings"></a>
# **LightspeedSaveStoreSettings**
> RestApiResultLightspeedSettings LightspeedSaveStoreSettings (int? storeId, LightspeedSettings lightspeedSettings)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LightspeedSaveStoreSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LightspeedApi();
            var storeId = 56;  // int? | 
            var lightspeedSettings = new LightspeedSettings(); // LightspeedSettings | 

            try
            {
                RestApiResultLightspeedSettings result = apiInstance.LightspeedSaveStoreSettings(storeId, lightspeedSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.LightspeedSaveStoreSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **lightspeedSettings** | [**LightspeedSettings**](LightspeedSettings.md)|  | 

### Return type

[**RestApiResultLightspeedSettings**](RestApiResultLightspeedSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

