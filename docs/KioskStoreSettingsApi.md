# Flipdish.Api.KioskStoreSettingsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllKioskSettingsForStore**](KioskStoreSettingsApi.md#getallkiosksettingsforstore) | **GET** /api/v1.0/{appId}/kiosksettings/store/{storeId} | 
[**GetAllStoreSettingsForKioskHydra**](KioskStoreSettingsApi.md#getallstoresettingsforkioskhydra) | **GET** /api/v1.0/kioskstoresettings | 
[**UpdateCashSettingForKiosk**](KioskStoreSettingsApi.md#updatecashsettingforkiosk) | **POST** /api/v1.0/{appId}/kiosksettings/cash | 


<a name="getallkiosksettingsforstore"></a>
# **GetAllKioskSettingsForStore**
> RestApiResultStoreKioskSettings GetAllKioskSettingsForStore (int? storeId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllKioskSettingsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskStoreSettingsApi();
            var storeId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultStoreKioskSettings result = apiInstance.GetAllKioskSettingsForStore(storeId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskStoreSettingsApi.GetAllKioskSettingsForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultStoreKioskSettings**](RestApiResultStoreKioskSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallstoresettingsforkioskhydra"></a>
# **GetAllStoreSettingsForKioskHydra**
> RestApiResultKioskStoreSettings GetAllStoreSettingsForKioskHydra ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllStoreSettingsForKioskHydraExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskStoreSettingsApi();

            try
            {
                RestApiResultKioskStoreSettings result = apiInstance.GetAllStoreSettingsForKioskHydra();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskStoreSettingsApi.GetAllStoreSettingsForKioskHydra: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultKioskStoreSettings**](RestApiResultKioskStoreSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecashsettingforkiosk"></a>
# **UpdateCashSettingForKiosk**
> RestApiResultKioskCashSetting UpdateCashSettingForKiosk (string appId, string deviceId, bool? isCashEnabled)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateCashSettingForKioskExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskStoreSettingsApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var isCashEnabled = true;  // bool? | 

            try
            {
                RestApiResultKioskCashSetting result = apiInstance.UpdateCashSettingForKiosk(appId, deviceId, isCashEnabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskStoreSettingsApi.UpdateCashSettingForKiosk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **isCashEnabled** | **bool?**|  | 

### Return type

[**RestApiResultKioskCashSetting**](RestApiResultKioskCashSetting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

