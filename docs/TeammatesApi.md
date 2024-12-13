# Flipdish.Api.TeammatesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTeammate**](TeammatesApi.md#createteammate) | **POST** /api/v1.0/{appId}/teammates | 
[**DeleteTeammate**](TeammatesApi.md#deleteteammate) | **DELETE** /api/v1.0/{appId}/teammates/{id} | 
[**GetTeammateByAppIdAndTeammateId**](TeammatesApi.md#getteammatebyappidandteammateid) | **GET** /api/v1.0/{appId}/teammates/{id} | 
[**GetTeammatesByAppId**](TeammatesApi.md#getteammatesbyappid) | **GET** /api/v1.0/{appId}/teammates | 
[**Grantaccess**](TeammatesApi.md#grantaccess) | **POST** /api/v1.0/{appId}/teammates/grantaccess | 
[**RedeemInvitation**](TeammatesApi.md#redeeminvitation) | **GET** /api/v1.0/{appId}/teammates/redeem/{otc} | 
[**TeammatesAcceptInvitation**](TeammatesApi.md#teammatesacceptinvitation) | **GET** /api/v1.0/{appId}/teammates/accept/{otc} | 
[**TeammatesAcceptInvitations**](TeammatesApi.md#teammatesacceptinvitations) | **POST** /api/v1.0/teammates/acceptInvitations | 
[**TeammatesPendingInvitations**](TeammatesApi.md#teammatespendinginvitations) | **GET** /api/v1.0/teammates/pending-invitations | 
[**UpdateTeammate**](TeammatesApi.md#updateteammate) | **POST** /api/v1.0/{appId}/teammates/{id} | 


<a name="createteammate"></a>
# **CreateTeammate**
> RestApiResultTeammate CreateTeammate (string appId, CreateTeammate teammate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateTeammateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 
            var teammate = new CreateTeammate(); // CreateTeammate | 

            try
            {
                RestApiResultTeammate result = apiInstance.CreateTeammate(appId, teammate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.CreateTeammate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **teammate** | [**CreateTeammate**](CreateTeammate.md)|  | 

### Return type

[**RestApiResultTeammate**](RestApiResultTeammate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteteammate"></a>
# **DeleteTeammate**
> void DeleteTeammate (string appId, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteTeammateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteTeammate(appId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.DeleteTeammate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteammatebyappidandteammateid"></a>
# **GetTeammateByAppIdAndTeammateId**
> RestApiResultTeammate GetTeammateByAppIdAndTeammateId (string appId, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetTeammateByAppIdAndTeammateIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                RestApiResultTeammate result = apiInstance.GetTeammateByAppIdAndTeammateId(appId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.GetTeammateByAppIdAndTeammateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **id** | **string**|  | 

### Return type

[**RestApiResultTeammate**](RestApiResultTeammate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteammatesbyappid"></a>
# **GetTeammatesByAppId**
> RestApiArrayResultTeammate GetTeammatesByAppId (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetTeammatesByAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultTeammate result = apiInstance.GetTeammatesByAppId(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.GetTeammatesByAppId: " + e.Message );
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

[**RestApiArrayResultTeammate**](RestApiArrayResultTeammate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="grantaccess"></a>
# **Grantaccess**
> Object Grantaccess (string appId, CreateTeammate teammate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GrantaccessExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 
            var teammate = new CreateTeammate(); // CreateTeammate | 

            try
            {
                Object result = apiInstance.Grantaccess(appId, teammate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.Grantaccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **teammate** | [**CreateTeammate**](CreateTeammate.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeeminvitation"></a>
# **RedeemInvitation**
> RestApiResultRedeemInvitationResult RedeemInvitation (string otc, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RedeemInvitationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var otc = otc_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultRedeemInvitationResult result = apiInstance.RedeemInvitation(otc, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.RedeemInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otc** | **string**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultRedeemInvitationResult**](RestApiResultRedeemInvitationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammatesacceptinvitation"></a>
# **TeammatesAcceptInvitation**
> RestApiResultAcceptInvitationResult TeammatesAcceptInvitation (string otc, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class TeammatesAcceptInvitationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var otc = otc_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultAcceptInvitationResult result = apiInstance.TeammatesAcceptInvitation(otc, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.TeammatesAcceptInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otc** | **string**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultAcceptInvitationResult**](RestApiResultAcceptInvitationResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammatesacceptinvitations"></a>
# **TeammatesAcceptInvitations**
> void TeammatesAcceptInvitations ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class TeammatesAcceptInvitationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();

            try
            {
                apiInstance.TeammatesAcceptInvitations();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.TeammatesAcceptInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammatespendinginvitations"></a>
# **TeammatesPendingInvitations**
> RestApiArrayResultPendingInvitation TeammatesPendingInvitations ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class TeammatesPendingInvitationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();

            try
            {
                RestApiArrayResultPendingInvitation result = apiInstance.TeammatesPendingInvitations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.TeammatesPendingInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiArrayResultPendingInvitation**](RestApiArrayResultPendingInvitation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateteammate"></a>
# **UpdateTeammate**
> RestApiResultTeammate UpdateTeammate (string appId, string id, TeammateBase teammate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateTeammateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeammatesApi();
            var appId = appId_example;  // string | 
            var id = id_example;  // string | 
            var teammate = new TeammateBase(); // TeammateBase | 

            try
            {
                RestApiResultTeammate result = apiInstance.UpdateTeammate(appId, id, teammate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeammatesApi.UpdateTeammate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **id** | **string**|  | 
 **teammate** | [**TeammateBase**](TeammateBase.md)|  | 

### Return type

[**RestApiResultTeammate**](RestApiResultTeammate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

