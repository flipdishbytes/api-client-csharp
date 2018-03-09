# Flipdish.Api.AuthorizationTokensApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuthorizationTokens**](AuthorizationTokensApi.md#getauthorizationtokens) | **GET** /api/v1.0/authorizationtokens/{clientId} | Get authorization tokens
[**RevokeToken**](AuthorizationTokensApi.md#revoketoken) | **DELETE** /api/v1.0/authorizationtokens/{key} | Revoke token


<a name="getauthorizationtokens"></a>
# **GetAuthorizationTokens**
> FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OAuthClientsOAuthTokenModel GetAuthorizationTokens (string clientId, int? page = null, int? limit = null)

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
            var clientId = clientId_example;  // string | Client identifier
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get authorization tokens
                FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OAuthClientsOAuthTokenModel result = apiInstance.GetAuthorizationTokens(clientId, page, limit);
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
 **clientId** | **string**| Client identifier | 
 **page** | **int?**| Requested page number | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OAuthClientsOAuthTokenModel**](FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1OAuthClientsOAuthTokenModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revoketoken"></a>
# **RevokeToken**
> void RevokeToken (string key)

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

            try
            {
                // Revoke token
                apiInstance.RevokeToken(key);
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

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

