# Flipdish.Api.AuthorizationTokensApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuthorizationTokens**](AuthorizationTokensApi.md#getauthorizationtokens) | **GET** /api/v1.0/{appId}/authorizationtokens/{oauthAppId} | Get authorization tokens
[**RevokeToken**](AuthorizationTokensApi.md#revoketoken) | **DELETE** /api/v1.0/{appId}/authorizationtokens/{key} | Revoke token


<a name="getauthorizationtokens"></a>
# **GetAuthorizationTokens**
> RestApiPaginationResultOAuthTokenModel GetAuthorizationTokens (string oauthAppId, string appId, int? page = null, int? limit = null)

Get authorization tokens

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAuthorizationTokensExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthorizationTokensApi();
            var oauthAppId = oauthAppId_example;  // string | Client identifier
            var appId = appId_example;  // string | 
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get authorization tokens
                RestApiPaginationResultOAuthTokenModel result = apiInstance.GetAuthorizationTokens(oauthAppId, appId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationTokensApi.GetAuthorizationTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**| Client identifier | 
 **appId** | **string**|  | 
 **page** | **int?**| Requested page number | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultOAuthTokenModel**](RestApiPaginationResultOAuthTokenModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revoketoken"></a>
# **RevokeToken**
> void RevokeToken (string key, string appId)

Revoke token

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RevokeTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthorizationTokensApi();
            var key = key_example;  // string | Token identifier key
            var appId = appId_example;  // string | 

            try
            {
                // Revoke token
                apiInstance.RevokeToken(key, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationTokensApi.RevokeToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Token identifier key | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

