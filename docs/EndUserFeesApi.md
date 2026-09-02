# Flipdish.Api.EndUserFeesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEndUserFeeConfig**](EndUserFeesApi.md#createenduserfeeconfig) | **POST** /api/v1.0/{appId}/stores/{storeId}/end-user-fees | 
[**GetEndUserFeesForStore**](EndUserFeesApi.md#getenduserfeesforstore) | **GET** /api/v1.0/{appId}/stores/{storeId}/end-user-fees | 
[**SetV2FeeCalculation**](EndUserFeesApi.md#setv2feecalculation) | **POST** /api/v1.0/{appId}/stores/{storeId}/end-user-fees/v2-fee-calculation | 


<a name="createenduserfeeconfig"></a>
# **CreateEndUserFeeConfig**
> Object CreateEndUserFeeConfig (CreateEndUserFeeConfig input, string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateEndUserFeeConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndUserFeesApi();
            var input = new CreateEndUserFeeConfig(); // CreateEndUserFeeConfig | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                Object result = apiInstance.CreateEndUserFeeConfig(input, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndUserFeesApi.CreateEndUserFeeConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**CreateEndUserFeeConfig**](CreateEndUserFeeConfig.md)|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenduserfeesforstore"></a>
# **GetEndUserFeesForStore**
> RestApiResultGetEndUserFeeConfigsResponse GetEndUserFeesForStore (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEndUserFeesForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndUserFeesApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultGetEndUserFeeConfigsResponse result = apiInstance.GetEndUserFeesForStore(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndUserFeesApi.GetEndUserFeesForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultGetEndUserFeeConfigsResponse**](RestApiResultGetEndUserFeeConfigsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setv2feecalculation"></a>
# **SetV2FeeCalculation**
> RestApiResultSetV2FeeCalculationRequest SetV2FeeCalculation (SetV2FeeCalculationRequest input, string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetV2FeeCalculationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndUserFeesApi();
            var input = new SetV2FeeCalculationRequest(); // SetV2FeeCalculationRequest | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultSetV2FeeCalculationRequest result = apiInstance.SetV2FeeCalculation(input, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndUserFeesApi.SetV2FeeCalculation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**SetV2FeeCalculationRequest**](SetV2FeeCalculationRequest.md)|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultSetV2FeeCalculationRequest**](RestApiResultSetV2FeeCalculationRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

