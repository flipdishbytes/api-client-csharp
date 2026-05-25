# Flipdish.Api.FirebaseAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFirebaseApp**](FirebaseAppsApi.md#addfirebaseapp) | **POST** /api/v1.0/FirebaseApp | 
[**DeleteFirebaseApp**](FirebaseAppsApi.md#deletefirebaseapp) | **DELETE** /api/v1.0/FirebaseApp/{whiteLabelId} | 
[**GetFirebaseApp**](FirebaseAppsApi.md#getfirebaseapp) | **GET** /api/v1.0/FirebaseApp/{whitelabelId} | 


<a name="addfirebaseapp"></a>
# **AddFirebaseApp**
> Object AddFirebaseApp (FirebaseApp firebaseApp)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var firebaseApp = new FirebaseApp(); // FirebaseApp | 

            try
            {
                Object result = apiInstance.AddFirebaseApp(firebaseApp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.AddFirebaseApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firebaseApp** | [**FirebaseApp**](FirebaseApp.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefirebaseapp"></a>
# **DeleteFirebaseApp**
> Object DeleteFirebaseApp (int? whiteLabelId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var whiteLabelId = 56;  // int? | 

            try
            {
                Object result = apiInstance.DeleteFirebaseApp(whiteLabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.DeleteFirebaseApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whiteLabelId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirebaseapp"></a>
# **GetFirebaseApp**
> void GetFirebaseApp (int? whitelabelId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var whitelabelId = 56;  // int? | 

            try
            {
                apiInstance.GetFirebaseApp(whitelabelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.GetFirebaseApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whitelabelId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

