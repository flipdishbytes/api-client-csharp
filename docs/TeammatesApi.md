# Flipdish.Api.TeammatesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTeammate**](TeammatesApi.md#createteammate) | **POST** /api/v1.0/{appId}/teammates | Create teammate and send an invite.
[**DeleteTeammate**](TeammatesApi.md#deleteteammate) | **DELETE** /api/v1.0/{appId}/teammates/{id} | Delete teammate
[**GetTeammateByAppIdAndTeammateId**](TeammatesApi.md#getteammatebyappidandteammateid) | **GET** /api/v1.0/{appId}/teammates/{id} | Get a teammates by email address
[**GetTeammatesByAppId**](TeammatesApi.md#getteammatesbyappid) | **GET** /api/v1.0/{appId}/teammates | Get all teammates
[**RedeemInvitation**](TeammatesApi.md#redeeminvitation) | **GET** /api/v1.0/{appId}/teammates/redeem/{otc} | 
[**UpdateTeammate**](TeammatesApi.md#updateteammate) | **POST** /api/v1.0/{appId}/teammates/{id} | Update teammates (this method does not support Deltas!)


<a name="createteammate"></a>
# **CreateTeammate**
> RestApiResultTeammate CreateTeammate (string appId, CreateTeammate teammate)

Create teammate and send an invite.

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
                // Create teammate and send an invite.
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

Delete teammate

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
                // Delete teammate
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

Get a teammates by email address

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
                // Get a teammates by email address
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

Get all teammates

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
                // Get all teammates
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

<a name="updateteammate"></a>
# **UpdateTeammate**
> RestApiResultTeammate UpdateTeammate (string appId, string id, TeammateBase teammate)

Update teammates (this method does not support Deltas!)

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
                // Update teammates (this method does not support Deltas!)
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

