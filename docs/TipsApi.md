# Flipdish.Api.TipsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TipConfigGet**](TipsApi.md#tipconfigget) | **GET** /api/v1.0/stores/{storeId}/tipconfig | Returns current tip configuration for a store
[**TipConfigUpsert**](TipsApi.md#tipconfigupsert) | **POST** /api/v1.0/stores/{storeId}/tipconfig | Update or insert current tip configuration for a store


<a name="tipconfigget"></a>
# **TipConfigGet**
> RestApiResultTipConfiguration TipConfigGet (int? storeId)

Returns current tip configuration for a store

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
            var storeId = 56;  // int? | Store Id

            try
            {
                // Returns current tip configuration for a store
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
 **storeId** | **int?**| Store Id | 

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

Update or insert current tip configuration for a store

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
            var storeId = 56;  // int? | Store Id
            var updateConfig = new UpdateTipConfiguration(); // UpdateTipConfiguration | Update Configuration

            try
            {
                // Update or insert current tip configuration for a store
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
 **storeId** | **int?**| Store Id | 
 **updateConfig** | [**UpdateTipConfiguration**](UpdateTipConfiguration.md)| Update Configuration | 

### Return type

[**RestApiResultTipConfiguration**](RestApiResultTipConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

