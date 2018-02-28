# Flipdish.Api.OAuthClientsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRedirectUri**](OAuthClientsApi.md#addredirecturi) | **POST** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis | Create OAuth client redirect uri
[**CreateOAuthClient**](OAuthClientsApi.md#createoauthclient) | **POST** /api/v1.0/oauthclients | Create OAuth client
[**DeleteOAuthClient**](OAuthClientsApi.md#deleteoauthclient) | **DELETE** /api/v1.0/oauthclients/{oAuthClientId} | Delete OAuth client
[**GetOAuthClientByClientId**](OAuthClientsApi.md#getoauthclientbyclientid) | **GET** /api/v1.0/oauthclients/{clientId} | Get OAuth client by identifier
[**GetOAuthClientSecret**](OAuthClientsApi.md#getoauthclientsecret) | **GET** /api/v1.0/oauthclients/{clientId}/secret | Get OAuth client secret key
[**GetOAuthClients**](OAuthClientsApi.md#getoauthclients) | **GET** /api/v1.0/oauthclients | Get all OAuth client
[**GetOauthAccessToken**](OAuthClientsApi.md#getoauthaccesstoken) | **GET** /api/v1.0/oauthclients/{oAuthClientId}/accesstoken | Get OAuth access token for client
[**GetRedirectUris**](OAuthClientsApi.md#getredirecturis) | **GET** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis | Get OAuth client redirect uris
[**RemoveRedirectUri**](OAuthClientsApi.md#removeredirecturi) | **DELETE** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis/{uriId} | Delete OAuth client redirect uri


<a name="addredirecturi"></a>
# **AddRedirectUri**
> RestApiResultOauthClientRedirectUri AddRedirectUri (string oAuthClientId, string uri)

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

            try
            {
                // Create OAuth client redirect uri
                RestApiResultOauthClientRedirectUri result = apiInstance.AddRedirectUri(oAuthClientId, uri);
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
> void CreateOAuthClient (OAuthClient oAuthClient)

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

            try
            {
                // Create OAuth client
                apiInstance.CreateOAuthClient(oAuthClient);
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
> void DeleteOAuthClient (string oAuthClientId)

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

            try
            {
                // Delete OAuth client
                apiInstance.DeleteOAuthClient(oAuthClientId);
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
> RestApiResultOAuthClient GetOAuthClientByClientId (string clientId)

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

            try
            {
                // Get OAuth client by identifier
                RestApiResultOAuthClient result = apiInstance.GetOAuthClientByClientId(clientId);
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
> RestApiStringResult GetOAuthClientSecret (string clientId)

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

            try
            {
                // Get OAuth client secret key
                RestApiStringResult result = apiInstance.GetOAuthClientSecret(clientId);
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
> RestApiArrayResultOAuthClient GetOAuthClients ()

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

            try
            {
                // Get all OAuth client
                RestApiArrayResultOAuthClient result = apiInstance.GetOAuthClients();
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
This endpoint does not need any parameter.

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
> RestApiStringResult GetOauthAccessToken (string oAuthClientId)

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

            try
            {
                // Get OAuth access token for client
                RestApiStringResult result = apiInstance.GetOauthAccessToken(oAuthClientId);
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
> RestApiArrayResultOauthClientRedirectUri GetRedirectUris (string oAuthClientId)

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

            try
            {
                // Get OAuth client redirect uris
                RestApiArrayResultOauthClientRedirectUri result = apiInstance.GetRedirectUris(oAuthClientId);
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
> void RemoveRedirectUri (string oAuthClientId, int? uriId)

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

            try
            {
                // Delete OAuth client redirect uri
                apiInstance.RemoveRedirectUri(oAuthClientId, uriId);
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

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

