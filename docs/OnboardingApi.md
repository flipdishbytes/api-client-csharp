# Flipdish.Api.OnboardingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOnboardingConfig**](OnboardingApi.md#getonboardingconfig) | **GET** /api/v1.0/clients/{appId}/onboarding/config | 
[**GetOnboardingConfigs**](OnboardingApi.md#getonboardingconfigs) | **GET** /api/v1.0/clients/{appId}/onboarding/configs | 
[**GetOnboardingItems**](OnboardingApi.md#getonboardingitems) | **GET** /api/v1.0/clients/{appId}/onboarding/stores/{storeId} | 
[**GetOnboardingItemsV2**](OnboardingApi.md#getonboardingitemsv2) | **GET** /api/v1.0/clients/{appId}/onboarding/stores | 
[**UpdateOnboardingConfig**](OnboardingApi.md#updateonboardingconfig) | **POST** /api/v1.0/clients/{appId}/onboarding/config | 
[**UpdateOnboardingConfigById**](OnboardingApi.md#updateonboardingconfigbyid) | **POST** /api/v1.0/clients/{appId}/onboarding/config/{configId} | 
[**UpdateOnboardingItem**](OnboardingApi.md#updateonboardingitem) | **POST** /api/v1.0/clients/{appId}/onboarding/stores/{storeId}/items/{onboardingItemId} | 
[**UpdateOnboardingItemV2**](OnboardingApi.md#updateonboardingitemv2) | **POST** /api/v1.0/clients/{appId}/onboarding/stores/items/{onboardingItemId} | 


<a name="getonboardingconfig"></a>
# **GetOnboardingConfig**
> RestApiResultOnboardingConfig GetOnboardingConfig (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOnboardingConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultOnboardingConfig result = apiInstance.GetOnboardingConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.GetOnboardingConfig: " + e.Message );
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

[**RestApiResultOnboardingConfig**](RestApiResultOnboardingConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getonboardingconfigs"></a>
# **GetOnboardingConfigs**
> RestApiArrayResultOnboardingConfig GetOnboardingConfigs (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOnboardingConfigsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultOnboardingConfig result = apiInstance.GetOnboardingConfigs(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.GetOnboardingConfigs: " + e.Message );
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

[**RestApiArrayResultOnboardingConfig**](RestApiArrayResultOnboardingConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getonboardingitems"></a>
# **GetOnboardingItems**
> RestApiResultOnboardingProcess GetOnboardingItems (string appId, int? storeId, int? milestoneId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOnboardingItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var milestoneId = 56;  // int? |  (optional) 

            try
            {
                RestApiResultOnboardingProcess result = apiInstance.GetOnboardingItems(appId, storeId, milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.GetOnboardingItems: " + e.Message );
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
 **milestoneId** | **int?**|  | [optional] 

### Return type

[**RestApiResultOnboardingProcess**](RestApiResultOnboardingProcess.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getonboardingitemsv2"></a>
# **GetOnboardingItemsV2**
> RestApiResultOnboardingProcess GetOnboardingItemsV2 (string appId, int? storeId = null, int? milestoneId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOnboardingItemsV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? |  (optional) 
            var milestoneId = 56;  // int? |  (optional) 

            try
            {
                RestApiResultOnboardingProcess result = apiInstance.GetOnboardingItemsV2(appId, storeId, milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.GetOnboardingItemsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | [optional] 
 **milestoneId** | **int?**|  | [optional] 

### Return type

[**RestApiResultOnboardingProcess**](RestApiResultOnboardingProcess.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateonboardingconfig"></a>
# **UpdateOnboardingConfig**
> void UpdateOnboardingConfig (string appId, OnboardingConfigUpdate configUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateOnboardingConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var configUpdate = new OnboardingConfigUpdate(); // OnboardingConfigUpdate | 

            try
            {
                apiInstance.UpdateOnboardingConfig(appId, configUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UpdateOnboardingConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configUpdate** | [**OnboardingConfigUpdate**](OnboardingConfigUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateonboardingconfigbyid"></a>
# **UpdateOnboardingConfigById**
> void UpdateOnboardingConfigById (string appId, int? configId, OnboardingConfigUpdate configUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateOnboardingConfigByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var configId = 56;  // int? | 
            var configUpdate = new OnboardingConfigUpdate(); // OnboardingConfigUpdate | 

            try
            {
                apiInstance.UpdateOnboardingConfigById(appId, configId, configUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UpdateOnboardingConfigById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configId** | **int?**|  | 
 **configUpdate** | [**OnboardingConfigUpdate**](OnboardingConfigUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateonboardingitem"></a>
# **UpdateOnboardingItem**
> void UpdateOnboardingItem (string appId, int? storeId, int? onboardingItemId, OnboardingItemUpdate itemUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateOnboardingItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var onboardingItemId = 56;  // int? | 
            var itemUpdate = new OnboardingItemUpdate(); // OnboardingItemUpdate | 

            try
            {
                apiInstance.UpdateOnboardingItem(appId, storeId, onboardingItemId, itemUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UpdateOnboardingItem: " + e.Message );
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
 **onboardingItemId** | **int?**|  | 
 **itemUpdate** | [**OnboardingItemUpdate**](OnboardingItemUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateonboardingitemv2"></a>
# **UpdateOnboardingItemV2**
> void UpdateOnboardingItemV2 (string appId, int? onboardingItemId, OnboardingItemUpdate itemUpdate, int? storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateOnboardingItemV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 
            var onboardingItemId = 56;  // int? | 
            var itemUpdate = new OnboardingItemUpdate(); // OnboardingItemUpdate | 
            var storeId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.UpdateOnboardingItemV2(appId, onboardingItemId, itemUpdate, storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UpdateOnboardingItemV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **onboardingItemId** | **int?**|  | 
 **itemUpdate** | [**OnboardingItemUpdate**](OnboardingItemUpdate.md)|  | 
 **storeId** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

