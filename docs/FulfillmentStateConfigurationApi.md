# Flipdish.Api.FulfillmentStateConfigurationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#createfulfillmentstatesconfig) | **POST** /api/v1.0/{appId}/fulfillment/configuration/states | 
[**DeleteFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#deletefulfillmentstatesconfig) | **DELETE** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | 
[**GetFulfillmentStatesConfiguration**](FulfillmentStateConfigurationApi.md#getfulfillmentstatesconfiguration) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | 
[**GetFulfillmentStatesConfigurationTemplate**](FulfillmentStateConfigurationApi.md#getfulfillmentstatesconfigurationtemplate) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states_template | 
[**SearchFulfillmentStatesConfigurations**](FulfillmentStateConfigurationApi.md#searchfulfillmentstatesconfigurations) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states | 
[**UpdateFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#updatefulfillmentstatesconfig) | **POST** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | 


<a name="createfulfillmentstatesconfig"></a>
# **CreateFulfillmentStatesConfig**
> RestApiResultFulfillmentStatesConfiguration CreateFulfillmentStatesConfig (string appId, CreateFulfillmentStatesConfiguration fulfillmentStateConfiguration)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateFulfillmentStatesConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 
            var fulfillmentStateConfiguration = new CreateFulfillmentStatesConfiguration(); // CreateFulfillmentStatesConfiguration | 

            try
            {
                RestApiResultFulfillmentStatesConfiguration result = apiInstance.CreateFulfillmentStatesConfig(appId, fulfillmentStateConfiguration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.CreateFulfillmentStatesConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **fulfillmentStateConfiguration** | [**CreateFulfillmentStatesConfiguration**](CreateFulfillmentStatesConfiguration.md)|  | 

### Return type

[**RestApiResultFulfillmentStatesConfiguration**](RestApiResultFulfillmentStatesConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentstatesconfig"></a>
# **DeleteFulfillmentStatesConfig**
> RestApiStringResult DeleteFulfillmentStatesConfig (string appId, string configId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteFulfillmentStatesConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 
            var configId = configId_example;  // string | 

            try
            {
                RestApiStringResult result = apiInstance.DeleteFulfillmentStatesConfig(appId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.DeleteFulfillmentStatesConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstatesconfiguration"></a>
# **GetFulfillmentStatesConfiguration**
> FulfillmentStatesConfiguration GetFulfillmentStatesConfiguration (string appId, string configId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFulfillmentStatesConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 
            var configId = configId_example;  // string | 

            try
            {
                FulfillmentStatesConfiguration result = apiInstance.GetFulfillmentStatesConfiguration(appId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.GetFulfillmentStatesConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configId** | **string**|  | 

### Return type

[**FulfillmentStatesConfiguration**](FulfillmentStatesConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstatesconfigurationtemplate"></a>
# **GetFulfillmentStatesConfigurationTemplate**
> FulfillmentStatesConfiguration GetFulfillmentStatesConfigurationTemplate (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFulfillmentStatesConfigurationTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 

            try
            {
                FulfillmentStatesConfiguration result = apiInstance.GetFulfillmentStatesConfigurationTemplate(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.GetFulfillmentStatesConfigurationTemplate: " + e.Message );
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

[**FulfillmentStatesConfiguration**](FulfillmentStatesConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchfulfillmentstatesconfigurations"></a>
# **SearchFulfillmentStatesConfigurations**
> RestApiArrayResultFulfillmentStatesConfigurationSummary SearchFulfillmentStatesConfigurations (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchFulfillmentStatesConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultFulfillmentStatesConfigurationSummary result = apiInstance.SearchFulfillmentStatesConfigurations(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.SearchFulfillmentStatesConfigurations: " + e.Message );
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

[**RestApiArrayResultFulfillmentStatesConfigurationSummary**](RestApiArrayResultFulfillmentStatesConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentstatesconfig"></a>
# **UpdateFulfillmentStatesConfig**
> void UpdateFulfillmentStatesConfig (string appId, string configId, UpdateFulfillmentStatesConfiguration updateFulfillmentStatesConfiguration)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateFulfillmentStatesConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FulfillmentStateConfigurationApi();
            var appId = appId_example;  // string | 
            var configId = configId_example;  // string | 
            var updateFulfillmentStatesConfiguration = new UpdateFulfillmentStatesConfiguration(); // UpdateFulfillmentStatesConfiguration | 

            try
            {
                apiInstance.UpdateFulfillmentStatesConfig(appId, configId, updateFulfillmentStatesConfiguration);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentStateConfigurationApi.UpdateFulfillmentStatesConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **configId** | **string**|  | 
 **updateFulfillmentStatesConfiguration** | [**UpdateFulfillmentStatesConfiguration**](UpdateFulfillmentStatesConfiguration.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

