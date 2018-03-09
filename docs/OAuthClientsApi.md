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
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri AddRedirectUri (string oAuthClientId, string uri)

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
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri result = apiInstance.AddRedirectUri(oAuthClientId, uri);
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

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createoauthclient"></a>
# **CreateOAuthClient**
> void CreateOAuthClient (FlipdishPublicModelsV1OAuthClientsOAuthClient oAuthClient)

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
            var oAuthClient = new FlipdishPublicModelsV1OAuthClientsOAuthClient(); // FlipdishPublicModelsV1OAuthClientsOAuthClient | OAuth client

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
 **oAuthClient** | [**FlipdishPublicModelsV1OAuthClientsOAuthClient**](FlipdishPublicModelsV1OAuthClientsOAuthClient.md)| OAuth client | 

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
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOAuthClient GetOAuthClientByClientId (string clientId)

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
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOAuthClient result = apiInstance.GetOAuthClientByClientId(clientId);
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

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOAuthClient**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1OAuthClientsOAuthClient.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclientsecret"></a>
# **GetOAuthClientSecret**
> FlipdishPublicModelsV1ApiResultsRestApiStringResult GetOAuthClientSecret (string clientId)

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
                FlipdishPublicModelsV1ApiResultsRestApiStringResult result = apiInstance.GetOAuthClientSecret(clientId);
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

[**FlipdishPublicModelsV1ApiResultsRestApiStringResult**](FlipdishPublicModelsV1ApiResultsRestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthclients"></a>
# **GetOAuthClients**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOAuthClient GetOAuthClients ()

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
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOAuthClient result = apiInstance.GetOAuthClients();
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

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOAuthClient**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOAuthClient.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthaccesstoken"></a>
# **GetOauthAccessToken**
> FlipdishPublicModelsV1ApiResultsRestApiStringResult GetOauthAccessToken (string oAuthClientId)

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
                FlipdishPublicModelsV1ApiResultsRestApiStringResult result = apiInstance.GetOauthAccessToken(oAuthClientId);
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

[**FlipdishPublicModelsV1ApiResultsRestApiStringResult**](FlipdishPublicModelsV1ApiResultsRestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getredirecturis"></a>
# **GetRedirectUris**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri GetRedirectUris (string oAuthClientId)

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
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri result = apiInstance.GetRedirectUris(oAuthClientId);
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

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1OAuthClientsOauthClientRedirectUri.md)

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

