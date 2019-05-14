# Flipdish.Api.OAuthClientsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRedirectUri**](OAuthClientsApi.md#addredirecturi) | **POST** /api/v1.0/{appId}/oauthclients/{oauthAppId}/redirecturis | Create OAuth App redirect uri
[**CreateOAuthApp**](OAuthClientsApi.md#createoauthapp) | **POST** /api/v1.0/{appId}/oauthclients | Create OAuth App
[**DeleteOAuthApp**](OAuthClientsApi.md#deleteoauthapp) | **DELETE** /api/v1.0/{appId}/oauthclients/{oauthAppId} | Delete OAuth App
[**GetOAuthApps**](OAuthClientsApi.md#getoauthapps) | **GET** /api/v1.0/{appId}/oauthclients | Get all OAuth Apps
[**GetOAuthClientByClientId**](OAuthClientsApi.md#getoauthclientbyclientid) | **GET** /api/v1.0/{appId}/oauthclients/{oauthAppId} | Get OAuth App by identifier
[**GetOAuthClientSecret**](OAuthClientsApi.md#getoauthclientsecret) | **GET** /api/v1.0/{appId}/oauthclients/{oauthAppId}/secret | Get OAuth App secret key
[**GetOauthAccessToken**](OAuthClientsApi.md#getoauthaccesstoken) | **GET** /api/v1.0/{appId}/oauthclients/{oauthAppId}/accesstoken | Get OAuth access token for App
[**GetRedirectUris**](OAuthClientsApi.md#getredirecturis) | **GET** /api/v1.0/{appId}/oauthclients/{oauthAppId}/redirecturis | Get OAuth App redirect uris
[**OAuthClientsGetApplications**](OAuthClientsApi.md#oauthclientsgetapplications) | **GET** /api/v1.0/{appId}/oauthclients/appnames | 
[**RemoveRedirectUri**](OAuthClientsApi.md#removeredirecturi) | **DELETE** /api/v1.0/{appId}/oauthclients/{oauthAppId}/redirecturis/{uriId} | Delete OAuth App redirect uri


<a name="addredirecturi"></a>
# **AddRedirectUri**
> RestApiResultOauthClientRedirectUri AddRedirectUri (string oauthAppId, string uri, string appId)

Create OAuth App redirect uri

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddRedirectUriExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var uri = uri_example;  // string | Redirect uri
            var appId = appId_example;  // string | 

            try
            {
                // Create OAuth App redirect uri
                RestApiResultOauthClientRedirectUri result = apiInstance.AddRedirectUri(oauthAppId, uri, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.AddRedirectUri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **uri** | **string**| Redirect uri | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultOauthClientRedirectUri**](RestApiResultOauthClientRedirectUri.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createoauthapp"></a>
# **CreateOAuthApp**
> void CreateOAuthApp (OAuthApp oAuthApp, string appId)

Create OAuth App

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateOAuthAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oAuthApp = new OAuthApp(); // OAuthApp | OAuth App
            var appId = appId_example;  // string | 

            try
            {
                // Create OAuth App
                apiInstance.CreateOAuthApp(oAuthApp, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.CreateOAuthApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oAuthApp** | [**OAuthApp**](OAuthApp.md)| OAuth App | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoauthapp"></a>
# **DeleteOAuthApp**
> void DeleteOAuthApp (string oauthAppId, string appId)

Delete OAuth App

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteOAuthAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appId = appId_example;  // string | 

            try
            {
                // Delete OAuth App
                apiInstance.DeleteOAuthApp(oauthAppId, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.DeleteOAuthApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthapps"></a>
# **GetOAuthApps**
> RestApiArrayResultOAuthApp GetOAuthApps (string appId, string oauthAppName = null)

Get all OAuth Apps

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOAuthAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var appId = appId_example;  // string | 
            var oauthAppName = oauthAppName_example;  // string |  (optional) 

            try
            {
                // Get all OAuth Apps
                RestApiArrayResultOAuthApp result = apiInstance.GetOAuthApps(appId, oauthAppName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetOAuthApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **oauthAppName** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultOAuthApp**](RestApiArrayResultOAuthApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclientbyclientid"></a>
# **GetOAuthClientByClientId**
> RestApiResultOAuthApp GetOAuthClientByClientId (string oauthAppId, string appId)

Get OAuth App by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOAuthClientByClientIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appId = appId_example;  // string | 

            try
            {
                // Get OAuth App by identifier
                RestApiResultOAuthApp result = apiInstance.GetOAuthClientByClientId(oauthAppId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetOAuthClientByClientId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultOAuthApp**](RestApiResultOAuthApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclientsecret"></a>
# **GetOAuthClientSecret**
> RestApiStringResult GetOAuthClientSecret (string oauthAppId, string appId)

Get OAuth App secret key

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOAuthClientSecretExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appId = appId_example;  // string | 

            try
            {
                // Get OAuth App secret key
                RestApiStringResult result = apiInstance.GetOAuthClientSecret(oauthAppId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetOAuthClientSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthaccesstoken"></a>
# **GetOauthAccessToken**
> RestApiStringResult GetOauthAccessToken (string oauthAppId, string appId)

Get OAuth access token for App

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOauthAccessTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appId = appId_example;  // string | 

            try
            {
                // Get OAuth access token for App
                RestApiStringResult result = apiInstance.GetOauthAccessToken(oauthAppId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetOauthAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getredirecturis"></a>
# **GetRedirectUris**
> RestApiArrayResultOauthClientRedirectUri GetRedirectUris (string oauthAppId, string appId)

Get OAuth App redirect uris

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRedirectUrisExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var appId = appId_example;  // string | 

            try
            {
                // Get OAuth App redirect uris
                RestApiArrayResultOauthClientRedirectUri result = apiInstance.GetRedirectUris(oauthAppId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetRedirectUris: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultOauthClientRedirectUri**](RestApiArrayResultOauthClientRedirectUri.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthclientsgetapplications"></a>
# **OAuthClientsGetApplications**
> Object OAuthClientsGetApplications (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class OAuthClientsGetApplicationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var appId = appId_example;  // string | 

            try
            {
                Object result = apiInstance.OAuthClientsGetApplications(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.OAuthClientsGetApplications: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeredirecturi"></a>
# **RemoveRedirectUri**
> void RemoveRedirectUri (string oauthAppId, int? uriId, string appId)

Delete OAuth App redirect uri

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveRedirectUriExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oauthAppId = oauthAppId_example;  // string | OAuth App identifier
            var uriId = 56;  // int? | Redirect uri identifier
            var appId = appId_example;  // string | 

            try
            {
                // Delete OAuth App redirect uri
                apiInstance.RemoveRedirectUri(oauthAppId, uriId, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.RemoveRedirectUri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| OAuth App identifier | 
 **uriId** | **int?**| Redirect uri identifier | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

