# Flipdish.Api.TipsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TipConfigGet**](TipsApi.md#tipconfigget) | **GET** /api/v1.0/stores/{storeId}/tipconfig | 
[**TipConfigUpsert**](TipsApi.md#tipconfigupsert) | **POST** /api/v1.0/stores/{storeId}/tipconfig | 


<a name="tipconfigget"></a>
# **TipConfigGet**
> RestApiResultTipConfiguration TipConfigGet (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class TipConfigGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TipsApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultTipConfiguration result = apiInstance.TipConfigGet(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TipsApi.TipConfigGet: " + e.Message );
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

[**RestApiResultTipConfiguration**](RestApiResultTipConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tipconfigupsert"></a>
# **TipConfigUpsert**
> RestApiResultTipConfiguration TipConfigUpsert (int? storeId, UpdateTipConfiguration updateConfig)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class TipConfigUpsertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TipsApi();
            var storeId = 56;  // int? | 
            var updateConfig = new UpdateTipConfiguration(); // UpdateTipConfiguration | 

            try
            {
                RestApiResultTipConfiguration result = apiInstance.TipConfigUpsert(storeId, updateConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TipsApi.TipConfigUpsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **updateConfig** | [**UpdateTipConfiguration**](UpdateTipConfiguration.md)|  | 

### Return type

[**RestApiResultTipConfiguration**](RestApiResultTipConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

