# Flipdish.Api.StoreFeeConfigsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProcessingFeeConfigsByStoreId**](StoreFeeConfigsApi.md#getprocessingfeeconfigsbystoreid) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs | Get processing fee configs by store identifier
[**GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**](StoreFeeConfigsApi.md#getprocessingfeeconfigsbystoreidandpaymentaccounttype) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs/{paymentAccountType} | Get processing fee configs by store identifier and paymentAccountType
[**GetStoreFeeConfig**](StoreFeeConfigsApi.md#getstorefeeconfig) | **GET** /api/v1.0/stores/{storeId}/feeConfig | Get Store feeConfig


<a name="getprocessingfeeconfigsbystoreid"></a>
# **GetProcessingFeeConfigsByStoreId**
> RestApiArrayResultProcessingFeeConfig GetProcessingFeeConfigsByStoreId (int? storeId, string appNameId = null)

Get processing fee configs by store identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProcessingFeeConfigsByStoreIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreFeeConfigsApi();
            var storeId = 56;  // int? | Store identifier
            var appNameId = appNameId_example;  // string | App Name Id(Not used, still here for compatability reasons) (optional) 

            try
            {
                // Get processing fee configs by store identifier
                RestApiArrayResultProcessingFeeConfig result = apiInstance.GetProcessingFeeConfigsByStoreId(storeId, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreFeeConfigsApi.GetProcessingFeeConfigsByStoreId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **appNameId** | **string**| App Name Id(Not used, still here for compatability reasons) | [optional] 

### Return type

[**RestApiArrayResultProcessingFeeConfig**](RestApiArrayResultProcessingFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessingfeeconfigsbystoreidandpaymentaccounttype"></a>
# **GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**
> RestApiResultProcessingFeeConfig GetProcessingFeeConfigsByStoreIdAndPaymentAccountType (int? storeId, string paymentAccountType, string appNameId = null)

Get processing fee configs by store identifier and paymentAccountType

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProcessingFeeConfigsByStoreIdAndPaymentAccountTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreFeeConfigsApi();
            var storeId = 56;  // int? | Store identifier
            var paymentAccountType = paymentAccountType_example;  // string | 
            var appNameId = appNameId_example;  // string | App Name Id(Not used, still here for compatability reasons) (optional) 

            try
            {
                // Get processing fee configs by store identifier and paymentAccountType
                RestApiResultProcessingFeeConfig result = apiInstance.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType(storeId, paymentAccountType, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreFeeConfigsApi.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **paymentAccountType** | **string**|  | 
 **appNameId** | **string**| App Name Id(Not used, still here for compatability reasons) | [optional] 

### Return type

[**RestApiResultProcessingFeeConfig**](RestApiResultProcessingFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorefeeconfig"></a>
# **GetStoreFeeConfig**
> StoreFeeConfig GetStoreFeeConfig (int? storeId)

Get Store feeConfig

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreFeeConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreFeeConfigsApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Get Store feeConfig
                StoreFeeConfig result = apiInstance.GetStoreFeeConfig(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreFeeConfigsApi.GetStoreFeeConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 

### Return type

[**StoreFeeConfig**](StoreFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

