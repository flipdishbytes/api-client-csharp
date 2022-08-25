# IO.Swagger.Api.ChannelsStoreMappingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelsGetStoreChannelStoreMapping**](ChannelsStoreMappingApi.md#channelsgetstorechannelstoremapping) | **GET** /api/v1.0/{appId}/channels/storemappings | 
[**ChannelsSetStoreChannelStoreMapping**](ChannelsStoreMappingApi.md#channelssetstorechannelstoremapping) | **POST** /api/v1.0/{appId}/channels/storemappings | 


<a name="channelsgetstorechannelstoremapping"></a>
# **ChannelsGetStoreChannelStoreMapping**
> RestApiArrayResultStoreChannelStoreMapping ChannelsGetStoreChannelStoreMapping (string appId, int? channelId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChannelsGetStoreChannelStoreMappingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsStoreMappingApi();
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

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



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChannelsSetStoreChannelStoreMappingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsStoreMappingApi();
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 
            var stores = new List<ChannelStoreMapping>(); // List<ChannelStoreMapping> | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 
 **stores** | [**List&lt;ChannelStoreMapping&gt;**](ChannelStoreMapping.md)|  | 

### Return type

[**RestApiArrayResultStoreChannelStoreMapping**](RestApiArrayResultStoreChannelStoreMapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

