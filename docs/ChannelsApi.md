# Flipdish.Api.ChannelsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachStoreToSalesChannel**](ChannelsApi.md#attachstoretosaleschannel) | **POST** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | Attachs the specified store to the given sales channel.
[**DetachAllStoresFromSalesChannel**](ChannelsApi.md#detachallstoresfromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores | Detaches all the stores from the given sales channel.
[**DetachStoreFromSalesChannel**](ChannelsApi.md#detachstorefromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | Detaches the specified store from the given sales channel.
[**GetChannel**](ChannelsApi.md#getchannel) | **GET** /api/v1.0/{appId}/channels/{id} | 
[**GetChannels**](ChannelsApi.md#getchannels) | **GET** /api/v1.0/{appId}/channels | 
[**GetStoresBySalesChannel**](ChannelsApi.md#getstoresbysaleschannel) | **GET** /api/v1.0/{appId}/channels/{channelId}/stores | Returns a list of store ids attached to the given channel type for the specified app.


<a name="attachstoretosaleschannel"></a>
# **AttachStoreToSalesChannel**
> Object AttachStoreToSalesChannel (string appId, int? channelId, int? storeId)

Attachs the specified store to the given sales channel.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AttachStoreToSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameId)
            var channelId = 56;  // int? | Type of sales channel (Android, IOS, Web, etc.)
            var storeId = 56;  // int? | Store Id (Phyisical Restaurant) to attach.

            try
            {
                // Attachs the specified store to the given sales channel.
                Object result = apiInstance.AttachStoreToSalesChannel(appId, channelId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.AttachStoreToSalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameId) | 
 **channelId** | **int?**| Type of sales channel (Android, IOS, Web, etc.) | 
 **storeId** | **int?**| Store Id (Phyisical Restaurant) to attach. | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachallstoresfromsaleschannel"></a>
# **DetachAllStoresFromSalesChannel**
> Object DetachAllStoresFromSalesChannel (string appId, int? channelId)

Detaches all the stores from the given sales channel.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DetachAllStoresFromSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameId)
            var channelId = 56;  // int? | Type of sales channel (Android, IOS, Web, etc.)

            try
            {
                // Detaches all the stores from the given sales channel.
                Object result = apiInstance.DetachAllStoresFromSalesChannel(appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.DetachAllStoresFromSalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameId) | 
 **channelId** | **int?**| Type of sales channel (Android, IOS, Web, etc.) | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachstorefromsaleschannel"></a>
# **DetachStoreFromSalesChannel**
> Object DetachStoreFromSalesChannel (string appId, int? channelId, int? storeId)

Detaches the specified store from the given sales channel.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DetachStoreFromSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameId)
            var channelId = 56;  // int? | Type of sales channel (Android, IOS, Web, etc.)
            var storeId = 56;  // int? | Store Id (Phyisical Restaurant) to detach.

            try
            {
                // Detaches the specified store from the given sales channel.
                Object result = apiInstance.DetachStoreFromSalesChannel(appId, channelId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.DetachStoreFromSalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameId) | 
 **channelId** | **int?**| Type of sales channel (Android, IOS, Web, etc.) | 
 **storeId** | **int?**| Store Id (Phyisical Restaurant) to detach. | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannel"></a>
# **GetChannel**
> RestApiPaginationResultChannel GetChannel (int? id, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var id = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiPaginationResultChannel result = apiInstance.GetChannel(id, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiPaginationResultChannel**](RestApiPaginationResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannels"></a>
# **GetChannels**
> RestApiPaginationResultChannel GetChannels (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiPaginationResultChannel result = apiInstance.GetChannels(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannels: " + e.Message );
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

[**RestApiPaginationResultChannel**](RestApiPaginationResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresbysaleschannel"></a>
# **GetStoresBySalesChannel**
> Response GetStoresBySalesChannel (string appId, int? channelId)

Returns a list of store ids attached to the given channel type for the specified app.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresBySalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameId)
            var channelId = 56;  // int? | Type of sales channel (Android, IOS, Web, etc.)

            try
            {
                // Returns a list of store ids attached to the given channel type for the specified app.
                Response result = apiInstance.GetStoresBySalesChannel(appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetStoresBySalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameId) | 
 **channelId** | **int?**| Type of sales channel (Android, IOS, Web, etc.) | 

### Return type

[**Response**](Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

