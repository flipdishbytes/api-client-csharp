# Flipdish.Api.RestaurantVouchersPayGreenApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayGreenConfiguration**](RestaurantVouchersPayGreenApi.md#createpaygreenconfiguration) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen | 
[**DeletePayGreenConfiguration**](RestaurantVouchersPayGreenApi.md#deletepaygreenconfiguration) | **DELETE** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**GetElegibleStores**](RestaurantVouchersPayGreenApi.md#getelegiblestores) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores | 
[**GetPayGreenConfigurations**](RestaurantVouchersPayGreenApi.md#getpaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen | 
[**GetStoreAvailablePayGreenConfigurations**](RestaurantVouchersPayGreenApi.md#getstoreavailablepaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId}/available-configurations | 
[**GetStorePayGreenConfiguration_**](RestaurantVouchersPayGreenApi.md#getstorepaygreenconfiguration_) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId} | 
[**ListPayGreenConfigurations**](RestaurantVouchersPayGreenApi.md#listpaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**UpdatePayGreenConfiguration**](RestaurantVouchersPayGreenApi.md#updatepaygreenconfiguration) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**UpdateStorePayGreenConfiguration_**](RestaurantVouchersPayGreenApi.md#updatestorepaygreenconfiguration_) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId} | 


<a name="createpaygreenconfiguration"></a>
# **CreatePayGreenConfiguration**
> RestApiResultRestaurantVoucherPayGreenConfiguration CreatePayGreenConfiguration (string appId, CreatePayGreenConfigurationRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreatePayGreenConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var request = new CreatePayGreenConfigurationRequest(); // CreatePayGreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPayGreenConfiguration result = apiInstance.CreatePayGreenConfiguration(appId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.CreatePayGreenConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **request** | [**CreatePayGreenConfigurationRequest**](CreatePayGreenConfigurationRequest.md)|  | 

### Return type

[**RestApiResultRestaurantVoucherPayGreenConfiguration**](RestApiResultRestaurantVoucherPayGreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaygreenconfiguration"></a>
# **DeletePayGreenConfiguration**
> Object DeletePayGreenConfiguration (string appId, int? paygreenConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeletePayGreenConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 

            try
            {
                Object result = apiInstance.DeletePayGreenConfiguration(appId, paygreenConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.DeletePayGreenConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **paygreenConfigurationId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelegiblestores"></a>
# **GetElegibleStores**
> RestApiArrayResultRestaurantVoucherEligibleStore GetElegibleStores (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetElegibleStoresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultRestaurantVoucherEligibleStore result = apiInstance.GetElegibleStores(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.GetElegibleStores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultRestaurantVoucherEligibleStore**](RestApiArrayResultRestaurantVoucherEligibleStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaygreenconfigurations"></a>
# **GetPayGreenConfigurations**
> RestApiArrayResultRestaurantVoucherPayGreenConfiguration GetPayGreenConfigurations (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPayGreenConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultRestaurantVoucherPayGreenConfiguration result = apiInstance.GetPayGreenConfigurations(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.GetPayGreenConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultRestaurantVoucherPayGreenConfiguration**](RestApiArrayResultRestaurantVoucherPayGreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreavailablepaygreenconfigurations"></a>
# **GetStoreAvailablePayGreenConfigurations**
> RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary GetStoreAvailablePayGreenConfigurations (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreAvailablePayGreenConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary result = apiInstance.GetStoreAvailablePayGreenConfigurations(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.GetStoreAvailablePayGreenConfigurations: " + e.Message );
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

[**RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary**](RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorepaygreenconfiguration_"></a>
# **GetStorePayGreenConfiguration_**
> RestApiResultRestaurantVoucherPayGreenStoreConfiguration GetStorePayGreenConfiguration_ (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStorePayGreenConfiguration_Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultRestaurantVoucherPayGreenStoreConfiguration result = apiInstance.GetStorePayGreenConfiguration_(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.GetStorePayGreenConfiguration_: " + e.Message );
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

[**RestApiResultRestaurantVoucherPayGreenStoreConfiguration**](RestApiResultRestaurantVoucherPayGreenStoreConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpaygreenconfigurations"></a>
# **ListPayGreenConfigurations**
> RestApiResultRestaurantVoucherPayGreenConfiguration ListPayGreenConfigurations (string appId, int? paygreenConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ListPayGreenConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 

            try
            {
                RestApiResultRestaurantVoucherPayGreenConfiguration result = apiInstance.ListPayGreenConfigurations(appId, paygreenConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.ListPayGreenConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **paygreenConfigurationId** | **int?**|  | 

### Return type

[**RestApiResultRestaurantVoucherPayGreenConfiguration**](RestApiResultRestaurantVoucherPayGreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaygreenconfiguration"></a>
# **UpdatePayGreenConfiguration**
> RestApiResultRestaurantVoucherPayGreenConfiguration UpdatePayGreenConfiguration (string appId, int? paygreenConfigurationId, UpdatePayGreenConfigurationRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdatePayGreenConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 
            var request = new UpdatePayGreenConfigurationRequest(); // UpdatePayGreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPayGreenConfiguration result = apiInstance.UpdatePayGreenConfiguration(appId, paygreenConfigurationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.UpdatePayGreenConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **paygreenConfigurationId** | **int?**|  | 
 **request** | [**UpdatePayGreenConfigurationRequest**](UpdatePayGreenConfigurationRequest.md)|  | 

### Return type

[**RestApiResultRestaurantVoucherPayGreenConfiguration**](RestApiResultRestaurantVoucherPayGreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestorepaygreenconfiguration_"></a>
# **UpdateStorePayGreenConfiguration_**
> RestApiResultRestaurantVoucherPayGreenStoreConfiguration UpdateStorePayGreenConfiguration_ (string appId, int? storeId, UpdateStorePayGreenConfigurationRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStorePayGreenConfiguration_Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RestaurantVouchersPayGreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var request = new UpdateStorePayGreenConfigurationRequest(); // UpdateStorePayGreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPayGreenStoreConfiguration result = apiInstance.UpdateStorePayGreenConfiguration_(appId, storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestaurantVouchersPayGreenApi.UpdateStorePayGreenConfiguration_: " + e.Message );
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
 **request** | [**UpdateStorePayGreenConfigurationRequest**](UpdateStorePayGreenConfigurationRequest.md)|  | 

### Return type

[**RestApiResultRestaurantVoucherPayGreenStoreConfiguration**](RestApiResultRestaurantVoucherPayGreenStoreConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

