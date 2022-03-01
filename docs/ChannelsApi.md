# Flipdish.Api.ChannelsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignAppIdToSalesChannel**](ChannelsApi.md#assignappidtosaleschannel) | **POST** /api/v1.0/{appId}/channels/{channelId}/assign-appId | Assign a given AppId to a Sales Channel
[**AssignStoreToChannel**](ChannelsApi.md#assignstoretochannel) | **POST** /api/v1.0/{appId}/channels/assign-store | Assign a Store to a Sales Channel
[**AttachStoreToSalesChannel**](ChannelsApi.md#attachstoretosaleschannel) | **POST** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | Attachs the specified store to the given sales channel.
[**DetachAllStoresFromSalesChannel**](ChannelsApi.md#detachallstoresfromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores | Detaches all the stores from the given sales channel.
[**DetachStoreFromSalesChannel**](ChannelsApi.md#detachstorefromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | Detaches the specified store from the given sales channel.
[**GetAssignedChannels**](ChannelsApi.md#getassignedchannels) | **GET** /api/v1.0/{appId}/channels/assigned-channels | Returns a list of sales channels that are assigned to a given whitelabel
[**GetChannel**](ChannelsApi.md#getchannel) | **GET** /api/v1.0/{appId}/channels/{id} | 
[**GetChannels**](ChannelsApi.md#getchannels) | **GET** /api/v1.0/{appId}/channels | 
[**GetNotAssignedChannels**](ChannelsApi.md#getnotassignedchannels) | **GET** /api/v1.0/{appId}/channels/available-channels | Returns a list of sales channels that are not yet assigned to a given whitelabel
[**GetStoresAssignedToChannel**](ChannelsApi.md#getstoresassignedtochannel) | **GET** /api/v1.0/{appId}/channels/{channelId}/assigned-stores | Returns a list of store that are assigned to the given sales channel.
[**GetStoresBySalesChannel**](ChannelsApi.md#getstoresbysaleschannel) | **GET** /api/v1.0/{appId}/channels/{channelId}/stores | Returns a list of store ids attached to the given channel type for the specified app.


<a name="assignappidtosaleschannel"></a>
# **AssignAppIdToSalesChannel**
> Object AssignAppIdToSalesChannel (string appId, int? channelId)

Assign a given AppId to a Sales Channel

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignAppIdToSalesChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameIdxxx)
            var channelId = 56;  // int? | Channel Id (123, 456)

            try
            {
                // Assign a given AppId to a Sales Channel
                Object result = apiInstance.AssignAppIdToSalesChannel(appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.AssignAppIdToSalesChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameIdxxx) | 
 **channelId** | **int?**| Channel Id (123, 456) | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignstoretochannel"></a>
# **AssignStoreToChannel**
> Object AssignStoreToChannel (int? storeId, string appId, int? channelId)

Assign a Store to a Sales Channel

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignStoreToChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var storeId = 56;  // int? | Store Id (123, 456)
            var appId = appId_example;  // string | AppId (AppNameIdxxx)
            var channelId = 56;  // int? | Channel Id (123, 456)

            try
            {
                // Assign a Store to a Sales Channel
                Object result = apiInstance.AssignStoreToChannel(storeId, appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.AssignStoreToChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Id (123, 456) | 
 **appId** | **string**| AppId (AppNameIdxxx) | 
 **channelId** | **int?**| Channel Id (123, 456) | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="getassignedchannels"></a>
# **GetAssignedChannels**
> Object GetAssignedChannels (string appId)

Returns a list of sales channels that are assigned to a given whitelabel

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAssignedChannelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameIdxxx)

            try
            {
                // Returns a list of sales channels that are assigned to a given whitelabel
                Object result = apiInstance.GetAssignedChannels(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetAssignedChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameIdxxx) | 

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

<a name="getnotassignedchannels"></a>
# **GetNotAssignedChannels**
> Object GetNotAssignedChannels (string appId)

Returns a list of sales channels that are not yet assigned to a given whitelabel

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetNotAssignedChannelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameIdxxx)

            try
            {
                // Returns a list of sales channels that are not yet assigned to a given whitelabel
                Object result = apiInstance.GetNotAssignedChannels(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetNotAssignedChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameIdxxx) | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresassignedtochannel"></a>
# **GetStoresAssignedToChannel**
> Object GetStoresAssignedToChannel (string appId, int? channelId)

Returns a list of store that are assigned to the given sales channel.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresAssignedToChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | Application Id (AppNameId)
            var channelId = 56;  // int? | Sales channel (Android, IOS, Web, etc.)

            try
            {
                // Returns a list of store that are assigned to the given sales channel.
                Object result = apiInstance.GetStoresAssignedToChannel(appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetStoresAssignedToChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id (AppNameId) | 
 **channelId** | **int?**| Sales channel (Android, IOS, Web, etc.) | 

### Return type

**Object**

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

