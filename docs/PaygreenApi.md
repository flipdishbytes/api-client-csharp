# Flipdish.Api.PaygreenApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayGreenConfiguration**](PaygreenApi.md#createpaygreenconfiguration) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen | 
[**DeletePaygreenConfiguration**](PaygreenApi.md#deletepaygreenconfiguration) | **DELETE** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**GetPaygreenConfigurations**](PaygreenApi.md#getpaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen | 
[**GetStoreAvailablePayGreenConfigurations**](PaygreenApi.md#getstoreavailablepaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId}/available-configurations | 
[**GetStorePayGreenConfiguration**](PaygreenApi.md#getstorepaygreenconfiguration) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores | 
[**GetStorePayGreenConfiguration_**](PaygreenApi.md#getstorepaygreenconfiguration_) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId} | 
[**ListPayGreenConfigurations**](PaygreenApi.md#listpaygreenconfigurations) | **GET** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**UpdatePayGreenConfiguration**](PaygreenApi.md#updatepaygreenconfiguration) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen/{paygreenConfigurationId} | 
[**UpdateStorePayGreenConfiguration_**](PaygreenApi.md#updatestorepaygreenconfiguration_) | **POST** /api/v1.0/{appId}/restaurant-vouchers/paygreen/stores/{storeId} | 


<a name="createpaygreenconfiguration"></a>
# **CreatePayGreenConfiguration**
> RestApiResultRestaurantVoucherPaygreenConfiguration CreatePayGreenConfiguration (string appId, CreatePayGreenConfigurationRequest request)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var request = new CreatePayGreenConfigurationRequest(); // CreatePayGreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPaygreenConfiguration result = apiInstance.CreatePayGreenConfiguration(appId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.CreatePayGreenConfiguration: " + e.Message );
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

[**RestApiResultRestaurantVoucherPaygreenConfiguration**](RestApiResultRestaurantVoucherPaygreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaygreenconfiguration"></a>
# **DeletePaygreenConfiguration**
> Object DeletePaygreenConfiguration (string appId, int? paygreenConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeletePaygreenConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 

            try
            {
                Object result = apiInstance.DeletePaygreenConfiguration(appId, paygreenConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.DeletePaygreenConfiguration: " + e.Message );
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

<a name="getpaygreenconfigurations"></a>
# **GetPaygreenConfigurations**
> RestApiArrayResultRestaurantVoucherPaygreenConfiguration GetPaygreenConfigurations (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPaygreenConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultRestaurantVoucherPaygreenConfiguration result = apiInstance.GetPaygreenConfigurations(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.GetPaygreenConfigurations: " + e.Message );
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

[**RestApiArrayResultRestaurantVoucherPaygreenConfiguration**](RestApiArrayResultRestaurantVoucherPaygreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreavailablepaygreenconfigurations"></a>
# **GetStoreAvailablePayGreenConfigurations**
> RestApiArrayResultRestaurantVoucherPaygreenConfigurationSummary GetStoreAvailablePayGreenConfigurations (string appId, int? storeId)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultRestaurantVoucherPaygreenConfigurationSummary result = apiInstance.GetStoreAvailablePayGreenConfigurations(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.GetStoreAvailablePayGreenConfigurations: " + e.Message );
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

[**RestApiArrayResultRestaurantVoucherPaygreenConfigurationSummary**](RestApiArrayResultRestaurantVoucherPaygreenConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorepaygreenconfiguration"></a>
# **GetStorePayGreenConfiguration**
> RestApiArrayResultRestaurantVoucherEligibleStore GetStorePayGreenConfiguration (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStorePayGreenConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultRestaurantVoucherEligibleStore result = apiInstance.GetStorePayGreenConfiguration(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.GetStorePayGreenConfiguration: " + e.Message );
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

<a name="getstorepaygreenconfiguration_"></a>
# **GetStorePayGreenConfiguration_**
> RestApiResultRestaurantVoucherPaygreenStoreConfiguration GetStorePayGreenConfiguration_ (string appId, int? storeId)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultRestaurantVoucherPaygreenStoreConfiguration result = apiInstance.GetStorePayGreenConfiguration_(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.GetStorePayGreenConfiguration_: " + e.Message );
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

[**RestApiResultRestaurantVoucherPaygreenStoreConfiguration**](RestApiResultRestaurantVoucherPaygreenStoreConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpaygreenconfigurations"></a>
# **ListPayGreenConfigurations**
> RestApiResultRestaurantVoucherPaygreenConfiguration ListPayGreenConfigurations (string appId, int? paygreenConfigurationId)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 

            try
            {
                RestApiResultRestaurantVoucherPaygreenConfiguration result = apiInstance.ListPayGreenConfigurations(appId, paygreenConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.ListPayGreenConfigurations: " + e.Message );
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

[**RestApiResultRestaurantVoucherPaygreenConfiguration**](RestApiResultRestaurantVoucherPaygreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaygreenconfiguration"></a>
# **UpdatePayGreenConfiguration**
> RestApiResultRestaurantVoucherPaygreenConfiguration UpdatePayGreenConfiguration (string appId, int? paygreenConfigurationId, UpdatePayGreenConfigurationRequest request)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var paygreenConfigurationId = 56;  // int? | 
            var request = new UpdatePayGreenConfigurationRequest(); // UpdatePayGreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPaygreenConfiguration result = apiInstance.UpdatePayGreenConfiguration(appId, paygreenConfigurationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.UpdatePayGreenConfiguration: " + e.Message );
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

[**RestApiResultRestaurantVoucherPaygreenConfiguration**](RestApiResultRestaurantVoucherPaygreenConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestorepaygreenconfiguration_"></a>
# **UpdateStorePayGreenConfiguration_**
> RestApiResultRestaurantVoucherPaygreenStoreConfiguration UpdateStorePayGreenConfiguration_ (string appId, int? storeId, UpdateStorePaygreenConfigurationRequest request)



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

            var apiInstance = new PaygreenApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var request = new UpdateStorePaygreenConfigurationRequest(); // UpdateStorePaygreenConfigurationRequest | 

            try
            {
                RestApiResultRestaurantVoucherPaygreenStoreConfiguration result = apiInstance.UpdateStorePayGreenConfiguration_(appId, storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaygreenApi.UpdateStorePayGreenConfiguration_: " + e.Message );
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
 **request** | [**UpdateStorePaygreenConfigurationRequest**](UpdateStorePaygreenConfigurationRequest.md)|  | 

### Return type

[**RestApiResultRestaurantVoucherPaygreenStoreConfiguration**](RestApiResultRestaurantVoucherPaygreenStoreConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

