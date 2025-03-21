# Flipdish.Api.FirebaseAppsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FirebaseAppsAddFirebaseApp**](FirebaseAppsApi.md#firebaseappsaddfirebaseapp) | **POST** /api/v1.0/FirebaseApp | 
[**FirebaseAppsDeleteFirebaseApp**](FirebaseAppsApi.md#firebaseappsdeletefirebaseapp) | **DELETE** /api/v1.0/FirebaseApp/{whiteLabelId} | 
[**FirebaseAppsGetFirebaseApp**](FirebaseAppsApi.md#firebaseappsgetfirebaseapp) | **GET** /api/v1.0/FirebaseApp/{whitelabelId} | 


<a name="firebaseappsaddfirebaseapp"></a>
# **FirebaseAppsAddFirebaseApp**
> Object FirebaseAppsAddFirebaseApp (FirebaseApp firebaseApp)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FirebaseAppsAddFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var firebaseApp = new FirebaseApp(); // FirebaseApp | 

            try
            {
                Object result = apiInstance.FirebaseAppsAddFirebaseApp(firebaseApp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.FirebaseAppsAddFirebaseApp: " + e.Message );
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

<a name="firebaseappsdeletefirebaseapp"></a>
# **FirebaseAppsDeleteFirebaseApp**
> Object FirebaseAppsDeleteFirebaseApp (int? whiteLabelId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FirebaseAppsDeleteFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var whiteLabelId = 56;  // int? | 

            try
            {
                Object result = apiInstance.FirebaseAppsDeleteFirebaseApp(whiteLabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.FirebaseAppsDeleteFirebaseApp: " + e.Message );
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

<a name="firebaseappsgetfirebaseapp"></a>
# **FirebaseAppsGetFirebaseApp**
> Object FirebaseAppsGetFirebaseApp (int? whitelabelId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FirebaseAppsGetFirebaseAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FirebaseAppsApi();
            var whitelabelId = 56;  // int? | 

            try
            {
                Object result = apiInstance.FirebaseAppsGetFirebaseApp(whitelabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirebaseAppsApi.FirebaseAppsGetFirebaseApp: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

