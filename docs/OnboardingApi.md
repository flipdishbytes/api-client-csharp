# IO.Swagger.Api.OnboardingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OnboardingGetOnboardingConfig**](OnboardingApi.md#onboardinggetonboardingconfig) | **GET** /api/v1.0/clients/{appId}/onboarding/config | 
[**OnboardingGetOnboardingItems**](OnboardingApi.md#onboardinggetonboardingitems) | **GET** /api/v1.0/clients/{appId}/onboarding/stores/{storeId} | 
[**OnboardingUpdateOnboardingConfig**](OnboardingApi.md#onboardingupdateonboardingconfig) | **POST** /api/v1.0/clients/{appId}/onboarding/config | 
[**OnboardingUpdateOnboardingItem**](OnboardingApi.md#onboardingupdateonboardingitem) | **POST** /api/v1.0/clients/{appId}/onboarding/stores/{storeId}/items/{onboardingItemId} | 


<a name="onboardinggetonboardingconfig"></a>
# **OnboardingGetOnboardingConfig**
> Object OnboardingGetOnboardingConfig (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

<a name="onboardinggetonboardingitems"></a>
# **OnboardingGetOnboardingItems**
> Object OnboardingGetOnboardingItems (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

            try
            {
                Object result = apiInstance.OnboardingGetOnboardingItems(appId, storeId);
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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

<a name="onboardingupdateonboardingitem"></a>
# **OnboardingUpdateOnboardingItem**
> Object OnboardingUpdateOnboardingItem (string appId, int? storeId, int? onboardingItemId, OnboardingItemUpdate itemUpdate)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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

