# Flipdish.Api.OnboardingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OnboardingGetOnboardingConfig**](OnboardingApi.md#onboardinggetonboardingconfig) | **GET** /api/v1.0/clients/{appId}/onboarding/config | 
[**OnboardingGetOnboardingConfigs**](OnboardingApi.md#onboardinggetonboardingconfigs) | **GET** /api/v1.0/clients/{appId}/onboarding/configs | 
[**OnboardingGetOnboardingItems**](OnboardingApi.md#onboardinggetonboardingitems) | **GET** /api/v1.0/clients/{appId}/onboarding/stores/{storeId} | 
[**OnboardingGetOnboardingItemsV2**](OnboardingApi.md#onboardinggetonboardingitemsv2) | **GET** /api/v1.0/clients/{appId}/onboarding/stores | 
[**OnboardingUpdateOnboardingConfig**](OnboardingApi.md#onboardingupdateonboardingconfig) | **POST** /api/v1.0/clients/{appId}/onboarding/config | 
[**OnboardingUpdateOnboardingConfigById**](OnboardingApi.md#onboardingupdateonboardingconfigbyid) | **POST** /api/v1.0/clients/{appId}/onboarding/config/{configId} | 
[**OnboardingUpdateOnboardingItem**](OnboardingApi.md#onboardingupdateonboardingitem) | **POST** /api/v1.0/clients/{appId}/onboarding/stores/{storeId}/items/{onboardingItemId} | 
[**OnboardingUpdateOnboardingItemV2**](OnboardingApi.md#onboardingupdateonboardingitemv2) | **POST** /api/v1.0/clients/{appId}/onboarding/stores/items/{onboardingItemId} | 


<a name="onboardinggetonboardingconfig"></a>
# **OnboardingGetOnboardingConfig**
> Object OnboardingGetOnboardingConfig (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingGetOnboardingConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 

            try
            {
                Object result = apiInstance.OnboardingGetOnboardingConfig(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingGetOnboardingConfig: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardinggetonboardingconfigs"></a>
# **OnboardingGetOnboardingConfigs**
> Object OnboardingGetOnboardingConfigs (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingGetOnboardingConfigsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnboardingApi();
            var appId = appId_example;  // string | 

            try
            {
                Object result = apiInstance.OnboardingGetOnboardingConfigs(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingGetOnboardingConfigs: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardinggetonboardingitems"></a>
# **OnboardingGetOnboardingItems**
> Object OnboardingGetOnboardingItems (string appId, int? storeId, int? milestoneId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingGetOnboardingItemsExample
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
                Object result = apiInstance.OnboardingGetOnboardingItems(appId, storeId, milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingGetOnboardingItems: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardinggetonboardingitemsv2"></a>
# **OnboardingGetOnboardingItemsV2**
> Object OnboardingGetOnboardingItemsV2 (string appId, int? storeId = null, int? milestoneId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingGetOnboardingItemsV2Example
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
                Object result = apiInstance.OnboardingGetOnboardingItemsV2(appId, storeId, milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingGetOnboardingItemsV2: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardingupdateonboardingconfig"></a>
# **OnboardingUpdateOnboardingConfig**
> Object OnboardingUpdateOnboardingConfig (string appId, OnboardingConfigUpdate configUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingUpdateOnboardingConfigExample
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
                Object result = apiInstance.OnboardingUpdateOnboardingConfig(appId, configUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingUpdateOnboardingConfig: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardingupdateonboardingconfigbyid"></a>
# **OnboardingUpdateOnboardingConfigById**
> Object OnboardingUpdateOnboardingConfigById (string appId, int? configId, OnboardingConfigUpdate configUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingUpdateOnboardingConfigByIdExample
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
                Object result = apiInstance.OnboardingUpdateOnboardingConfigById(appId, configId, configUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingUpdateOnboardingConfigById: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardingupdateonboardingitem"></a>
# **OnboardingUpdateOnboardingItem**
> Object OnboardingUpdateOnboardingItem (string appId, int? storeId, int? onboardingItemId, OnboardingItemUpdate itemUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingUpdateOnboardingItemExample
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
                Object result = apiInstance.OnboardingUpdateOnboardingItem(appId, storeId, onboardingItemId, itemUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingUpdateOnboardingItem: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onboardingupdateonboardingitemv2"></a>
# **OnboardingUpdateOnboardingItemV2**
> Object OnboardingUpdateOnboardingItemV2 (string appId, int? onboardingItemId, OnboardingItemUpdate itemUpdate, int? storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OnboardingUpdateOnboardingItemV2Example
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
                Object result = apiInstance.OnboardingUpdateOnboardingItemV2(appId, onboardingItemId, itemUpdate, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingUpdateOnboardingItemV2: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

