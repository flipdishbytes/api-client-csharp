# Flipdish.Api.LightspeedApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateMenu**](LightspeedApi.md#generatemenu) | **POST** /api/v1.0/lightspeed/{storeId}/menu/generate | 
[**GetStoreSettings**](LightspeedApi.md#getstoresettings) | **GET** /api/v1.0/lightspeed/{storeId}/settings | 
[**SaveStoreSettings**](LightspeedApi.md#savestoresettings) | **POST** /api/v1.0/lightspeed/{storeId}/settings | 


<a name="generatemenu"></a>
# **GenerateMenu**
> void GenerateMenu (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GenerateMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LightspeedApi();
            var storeId = 56;  // int? | 

            try
            {
                apiInstance.GenerateMenu(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.GenerateMenu: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresettings"></a>
# **GetStoreSettings**
> RestApiResultLightspeedSettings GetStoreSettings (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LightspeedApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultLightspeedSettings result = apiInstance.GetStoreSettings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.GetStoreSettings: " + e.Message );
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

<a name="savestoresettings"></a>
# **SaveStoreSettings**
> RestApiResultLightspeedSettings SaveStoreSettings (int? storeId, LightspeedSettings lightspeedSettings)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SaveStoreSettingsExample
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
                RestApiResultLightspeedSettings result = apiInstance.SaveStoreSettings(storeId, lightspeedSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LightspeedApi.SaveStoreSettings: " + e.Message );
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

