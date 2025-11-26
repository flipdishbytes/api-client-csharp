# Flipdish.Api.FpmApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFpmForStore**](FpmApi.md#createfpmforstore) | **POST** /api/v1.0/{storeId}/fpm | 
[**DeleteFpmForStore**](FpmApi.md#deletefpmforstore) | **DELETE** /api/v1.0/{storeId}/fpm | 
[**EditFpmForStore**](FpmApi.md#editfpmforstore) | **POST** /api/v1.0/{storeId}/fpm/edit | 
[**GetFpmForStore**](FpmApi.md#getfpmforstore) | **GET** /api/v1.0/{storeId}/fpm | 


<a name="createfpmforstore"></a>
# **CreateFpmForStore**
> Object CreateFpmForStore (int? storeId, string phoneNumber)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateFpmForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FpmApi();
            var storeId = 56;  // int? | 
            var phoneNumber = phoneNumber_example;  // string | 

            try
            {
                Object result = apiInstance.CreateFpmForStore(storeId, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FpmApi.CreateFpmForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **phoneNumber** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefpmforstore"></a>
# **DeleteFpmForStore**
> void DeleteFpmForStore (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteFpmForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FpmApi();
            var storeId = 56;  // int? | 

            try
            {
                apiInstance.DeleteFpmForStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FpmApi.DeleteFpmForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editfpmforstore"></a>
# **EditFpmForStore**
> void EditFpmForStore (int? storeId, TelephonyConfig telephonyConfig)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class EditFpmForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FpmApi();
            var storeId = 56;  // int? | 
            var telephonyConfig = new TelephonyConfig(); // TelephonyConfig | 

            try
            {
                apiInstance.EditFpmForStore(storeId, telephonyConfig);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FpmApi.EditFpmForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **telephonyConfig** | [**TelephonyConfig**](TelephonyConfig.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfpmforstore"></a>
# **GetFpmForStore**
> TelephonyConfig GetFpmForStore (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFpmForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FpmApi();
            var storeId = 56;  // int? | 

            try
            {
                TelephonyConfig result = apiInstance.GetFpmForStore(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FpmApi.GetFpmForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**TelephonyConfig**](TelephonyConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

