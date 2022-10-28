# Flipdish.Api.ChannelsStoreMappingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelsGetStoreChannelStoreMapping**](ChannelsStoreMappingApi.md#channelsgetstorechannelstoremapping) | **GET** /api/v1.0/{appId}/channels/storemappings | Gets the relationship between Flipdish Store and Channel Store
[**ChannelsSetStoreChannelStoreMapping**](ChannelsStoreMappingApi.md#channelssetstorechannelstoremapping) | **POST** /api/v1.0/{appId}/channels/storemappings | Sets the relationship between Flipdish Store and Channel Store


<a name="channelsgetstorechannelstoremapping"></a>
# **ChannelsGetStoreChannelStoreMapping**
> RestApiArrayResultStoreChannelStoreMapping ChannelsGetStoreChannelStoreMapping (string appId, int? channelId)

Gets the relationship between Flipdish Store and Channel Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ChannelsGetStoreChannelStoreMappingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsStoreMappingApi();
            var appId = appId_example;  // string | Flipdish App Name Id
            var channelId = 56;  // int? | Flipdish Channel ID

            try
            {
                // Gets the relationship between Flipdish Store and Channel Store
                RestApiArrayResultStoreChannelStoreMapping result = apiInstance.ChannelsGetStoreChannelStoreMapping(appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsStoreMappingApi.ChannelsGetStoreChannelStoreMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Flipdish App Name Id | 
 **channelId** | **int?**| Flipdish Channel ID | 

### Return type

[**RestApiArrayResultStoreChannelStoreMapping**](RestApiArrayResultStoreChannelStoreMapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelssetstorechannelstoremapping"></a>
# **ChannelsSetStoreChannelStoreMapping**
> RestApiArrayResultStoreChannelStoreMapping ChannelsSetStoreChannelStoreMapping (string appId, int? channelId, List<ChannelStoreMapping> stores)

Sets the relationship between Flipdish Store and Channel Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ChannelsSetStoreChannelStoreMappingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsStoreMappingApi();
            var appId = appId_example;  // string | Flipdish App Name Id
            var channelId = 56;  // int? | Flipdish Channel ID
            var stores = new List<ChannelStoreMapping>(); // List<ChannelStoreMapping> | Flipdish and Channel Store configuration

            try
            {
                // Sets the relationship between Flipdish Store and Channel Store
                RestApiArrayResultStoreChannelStoreMapping result = apiInstance.ChannelsSetStoreChannelStoreMapping(appId, channelId, stores);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsStoreMappingApi.ChannelsSetStoreChannelStoreMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Flipdish App Name Id | 
 **channelId** | **int?**| Flipdish Channel ID | 
 **stores** | [**List&lt;ChannelStoreMapping&gt;**](ChannelStoreMapping.md)| Flipdish and Channel Store configuration | 

### Return type

[**RestApiArrayResultStoreChannelStoreMapping**](RestApiArrayResultStoreChannelStoreMapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

