# Flipdish.Api.ChannelsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignAppIdToSalesChannel**](ChannelsApi.md#assignappidtosaleschannel) | **POST** /api/v1.0/{appId}/channels/{channelId}/assign-appId | 
[**AssignStoreToChannel**](ChannelsApi.md#assignstoretochannel) | **POST** /api/v1.0/{appId}/channels/assign-store | 
[**AttachStoreToSalesChannel**](ChannelsApi.md#attachstoretosaleschannel) | **POST** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | 
[**DetachAllStoresFromSalesChannel**](ChannelsApi.md#detachallstoresfromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores | 
[**DetachStoreFromSalesChannel**](ChannelsApi.md#detachstorefromsaleschannel) | **DELETE** /api/v1.0/{appId}/channels/{channelId}/stores/{storeId} | 
[**GetAssignedChannels**](ChannelsApi.md#getassignedchannels) | **GET** /api/v1.0/{appId}/channels/assigned-channels | 
[**GetAvailableChannels**](ChannelsApi.md#getavailablechannels) | **GET** /api/v1.0/{appId}/channels/available-channels | 
[**GetChannel**](ChannelsApi.md#getchannel) | **GET** /api/v1.0/{appId}/channels/{id} | 
[**GetChannels**](ChannelsApi.md#getchannels) | **GET** /api/v1.0/{appId}/channels | 
[**GetStoresAssignedToChannel**](ChannelsApi.md#getstoresassignedtochannel) | **GET** /api/v1.0/{appId}/channels/{channelId}/assigned-stores | 
[**GetStoresBySalesChannel**](ChannelsApi.md#getstoresbysaleschannel) | **GET** /api/v1.0/{appId}/channels/{channelId}/stores | 
[**UnassignStoreFromChannel**](ChannelsApi.md#unassignstorefromchannel) | **DELETE** /api/v1.0/{appId}/channels/unassign-store | 


<a name="assignappidtosaleschannel"></a>
# **AssignAppIdToSalesChannel**
> Object AssignAppIdToSalesChannel (string appId, int? channelId)



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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 
 **storeId** | **int?**|  | 

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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 
 **storeId** | **int?**|  | 

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
> RestApiArrayResultChannel GetAssignedChannels (string appId)



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
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultChannel result = apiInstance.GetAssignedChannels(appId);
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
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultChannel**](RestApiArrayResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablechannels"></a>
# **GetAvailableChannels**
> RestApiArrayResultChannel GetAvailableChannels (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAvailableChannelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultChannel result = apiInstance.GetAvailableChannels(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetAvailableChannels: " + e.Message );
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

[**RestApiArrayResultChannel**](RestApiArrayResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannel"></a>
# **GetChannel**
> RestApiResultChannel GetChannel (int? id, string appId)



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
                RestApiResultChannel result = apiInstance.GetChannel(id, appId);
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

[**RestApiResultChannel**](RestApiResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannels"></a>
# **GetChannels**
> RestApiArrayResultChannel GetChannels (string appId)



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
                RestApiArrayResultChannel result = apiInstance.GetChannels(appId);
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

[**RestApiArrayResultChannel**](RestApiArrayResultChannel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresassignedtochannel"></a>
# **GetStoresAssignedToChannel**
> RestApiArrayResultStoreChannelAssignment GetStoresAssignedToChannel (string appId, int? channelId)



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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
                RestApiArrayResultStoreChannelAssignment result = apiInstance.GetStoresAssignedToChannel(appId, channelId);
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

### Return type

[**RestApiArrayResultStoreChannelAssignment**](RestApiArrayResultStoreChannelAssignment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresbysaleschannel"></a>
# **GetStoresBySalesChannel**
> Response GetStoresBySalesChannel (string appId, int? channelId)



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
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

### Return type

[**Response**](Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignstorefromchannel"></a>
# **UnassignStoreFromChannel**
> Object UnassignStoreFromChannel (int? storeId, string appId, int? channelId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnassignStoreFromChannelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsApi();
            var storeId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var channelId = 56;  // int? | 

            try
            {
                Object result = apiInstance.UnassignStoreFromChannel(storeId, appId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.UnassignStoreFromChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **appId** | **string**|  | 
 **channelId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

