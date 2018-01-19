# Flipdish.Api.OAuthClientsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRedirectUri**](OAuthClientsApi.md#addredirecturi) | **POST** /api/v{apiVersion}/oauthclients/{oAuthClientId}/redirecturis | Create OAuth client redirect uri
[**CreateOAuthClient**](OAuthClientsApi.md#createoauthclient) | **POST** /api/v{apiVersion}/oauthclients | Create OAuth client
[**DeleteOAuthClient**](OAuthClientsApi.md#deleteoauthclient) | **DELETE** /api/v{apiVersion}/oauthclients/{oAuthClientId} | Delete OAuth client
[**GetOAuthClientByClientId**](OAuthClientsApi.md#getoauthclientbyclientid) | **GET** /api/v{apiVersion}/oauthclients/{clientId} | Get OAuth client by identifier
[**GetOAuthClientSecret**](OAuthClientsApi.md#getoauthclientsecret) | **GET** /api/v{apiVersion}/oauthclients/{clientId}/secret | Get OAuth client secret key
[**GetOAuthClients**](OAuthClientsApi.md#getoauthclients) | **GET** /api/v{apiVersion}/oauthclients | Get all OAuth client
[**GetOauthAccessToken**](OAuthClientsApi.md#getoauthaccesstoken) | **GET** /api/v{apiVersion}/oauthclients/{oAuthClientId}/accesstoken | Get OAuth access token for client
[**GetRedirectUris**](OAuthClientsApi.md#getredirecturis) | **GET** /api/v{apiVersion}/oauthclients/{oAuthClientId}/redirecturis | Get OAuth client redirect uris
[**RemoveRedirectUri**](OAuthClientsApi.md#removeredirecturi) | **DELETE** /api/v{apiVersion}/oauthclients/{oAuthClientId}/redirecturis/{uriId} | Delete OAuth client redirect uri


<a name="addredirecturi"></a>
# **AddRedirectUri**
> RestApiResultOauthClientRedirectUri AddRedirectUri (string oAuthClientId, string uri, string apiVersion)

Create OAuth client redirect uri

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
            var oAuthClientId = oAuthClientId_example;  // string | OAuth client identifier
            var uri = uri_example;  // string | Redirect uri
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create OAuth client redirect uri
                RestApiResultOauthClientRedirectUri result = apiInstance.AddRedirectUri(oAuthClientId, uri, apiVersion);
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
 **oAuthClientId** | **string**| OAuth client identifier | 
 **uri** | **string**| Redirect uri | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiResultOauthClientRedirectUri**](RestApiResultOauthClientRedirectUri.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createoauthclient"></a>
# **CreateOAuthClient**
> void CreateOAuthClient (OAuthClient oAuthClient, string apiVersion)

Create OAuth client

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateOAuthClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oAuthClient = new OAuthClient(); // OAuthClient | OAuth client
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create OAuth client
                apiInstance.CreateOAuthClient(oAuthClient, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.CreateOAuthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oAuthClient** | [**OAuthClient**](OAuthClient.md)| OAuth client | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoauthclient"></a>
# **DeleteOAuthClient**
> void DeleteOAuthClient (string oAuthClientId, string apiVersion)

Delete OAuth client

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteOAuthClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var oAuthClientId = oAuthClientId_example;  // string | OAuth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete OAuth client
                apiInstance.DeleteOAuthClient(oAuthClientId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.DeleteOAuthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oAuthClientId** | **string**| OAuth client identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclientbyclientid"></a>
# **GetOAuthClientByClientId**
> RestApiResultOAuthClient GetOAuthClientByClientId (string clientId, string apiVersion)

Get OAuth client by identifier

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
            var clientId = clientId_example;  // string | OAuth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get OAuth client by identifier
                RestApiResultOAuthClient result = apiInstance.GetOAuthClientByClientId(clientId, apiVersion);
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
 **clientId** | **string**| OAuth client identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiResultOAuthClient**](RestApiResultOAuthClient.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclientsecret"></a>
# **GetOAuthClientSecret**
> RestApiStringResult GetOAuthClientSecret (string clientId, string apiVersion)

Get OAuth client secret key

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
            var clientId = clientId_example;  // string | OAuth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get OAuth client secret key
                RestApiStringResult result = apiInstance.GetOAuthClientSecret(clientId, apiVersion);
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
 **clientId** | **string**| OAuth client identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclients"></a>
# **GetOAuthClients**
> RestApiArrayResultOAuthClient GetOAuthClients (string apiVersion)

Get all OAuth client

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOAuthClientsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthClientsApi();
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get all OAuth client
                RestApiArrayResultOAuthClient result = apiInstance.GetOAuthClients(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthClientsApi.GetOAuthClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiArrayResultOAuthClient**](RestApiArrayResultOAuthClient.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthaccesstoken"></a>
# **GetOauthAccessToken**
> RestApiStringResult GetOauthAccessToken (string oAuthClientId, string apiVersion)

Get OAuth access token for client

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
            var oAuthClientId = oAuthClientId_example;  // string | OAuth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get OAuth access token for client
                RestApiStringResult result = apiInstance.GetOauthAccessToken(oAuthClientId, apiVersion);
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
 **oAuthClientId** | **string**| OAuth client identifier | 
 **apiVersion** | **string**| API version | 

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
> RestApiArrayResultOauthClientRedirectUri GetRedirectUris (string oAuthClientId, string apiVersion)

Get OAuth client redirect uris

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
            var oAuthClientId = oAuthClientId_example;  // string | OAuth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get OAuth client redirect uris
                RestApiArrayResultOauthClientRedirectUri result = apiInstance.GetRedirectUris(oAuthClientId, apiVersion);
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
 **oAuthClientId** | **string**| OAuth client identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiArrayResultOauthClientRedirectUri**](RestApiArrayResultOauthClientRedirectUri.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeredirecturi"></a>
# **RemoveRedirectUri**
> void RemoveRedirectUri (string oAuthClientId, int? uriId, string apiVersion)

Delete OAuth client redirect uri

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
            var oAuthClientId = oAuthClientId_example;  // string | OAuth client identifier
            var uriId = 56;  // int? | Redirect uri identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete OAuth client redirect uri
                apiInstance.RemoveRedirectUri(oAuthClientId, uriId, apiVersion);
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
 **oAuthClientId** | **string**| OAuth client identifier | 
 **uriId** | **int?**| Redirect uri identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

