# Flipdish.Api.FulfillmentStateConfigurationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#createfulfillmentstatesconfig) | **POST** /api/v1.0/{appId}/fulfillment/configuration/states | Create fulfillment configuration
[**DeleteFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#deletefulfillmentstatesconfig) | **DELETE** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | Delete fulfillment states configuration
[**GetFulfillmentStatesConfiguration**](FulfillmentStateConfigurationApi.md#getfulfillmentstatesconfiguration) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | Get fulfillment configuration
[**GetFulfillmentStatesConfigurationTemplate**](FulfillmentStateConfigurationApi.md#getfulfillmentstatesconfigurationtemplate) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states_template | Get fulfillment configuration template
[**SearchFulfillmentStatesConfigurations**](FulfillmentStateConfigurationApi.md#searchfulfillmentstatesconfigurations) | **GET** /api/v1.0/{appId}/fulfillment/configuration/states | List fulfillment configurations for AppId
[**UpdateFulfillmentStatesConfig**](FulfillmentStateConfigurationApi.md#updatefulfillmentstatesconfig) | **POST** /api/v1.0/{appId}/fulfillment/configuration/states/{configId} | Update fulfillment configuration


<a name="createfulfillmentstatesconfig"></a>
# **CreateFulfillmentStatesConfig**
> RestApiResultFulfillmentStatesConfiguration CreateFulfillmentStatesConfig (string appId, CreateFulfillmentStatesConfiguration fulfillmentStateConfiguration)

Create fulfillment configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id
            var fulfillmentStateConfiguration = new CreateFulfillmentStatesConfiguration(); // CreateFulfillmentStatesConfiguration | Fulfillment state configuration

            try
            {
                // Create fulfillment configuration
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
 **appId** | **string**| App id | 
 **fulfillmentStateConfiguration** | [**CreateFulfillmentStatesConfiguration**](CreateFulfillmentStatesConfiguration.md)| Fulfillment state configuration | 

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

Delete fulfillment states configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id
            var configId = configId_example;  // string | Fulfillment states configuration id

            try
            {
                // Delete fulfillment states configuration
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
 **appId** | **string**| App id | 
 **configId** | **string**| Fulfillment states configuration id | 

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

Get fulfillment configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id
            var configId = configId_example;  // string | Fulfillment configuration id

            try
            {
                // Get fulfillment configuration
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
 **appId** | **string**| App id | 
 **configId** | **string**| Fulfillment configuration id | 

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

Get fulfillment configuration template

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id

            try
            {
                // Get fulfillment configuration template
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
 **appId** | **string**| App id | 

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

List fulfillment configurations for AppId

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id

            try
            {
                // List fulfillment configurations for AppId
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
 **appId** | **string**| App id | 

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

Update fulfillment configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App id
            var configId = configId_example;  // string | Fulfillment states configuration id
            var updateFulfillmentStatesConfiguration = new UpdateFulfillmentStatesConfiguration(); // UpdateFulfillmentStatesConfiguration | Update fulfillment states configuration

            try
            {
                // Update fulfillment configuration
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
 **appId** | **string**| App id | 
 **configId** | **string**| Fulfillment states configuration id | 
 **updateFulfillmentStatesConfiguration** | [**UpdateFulfillmentStatesConfiguration**](UpdateFulfillmentStatesConfiguration.md)| Update fulfillment states configuration | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

