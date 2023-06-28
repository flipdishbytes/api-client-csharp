# Flipdish.Api.AppStoreDeveloperApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppVerificationUpdate**](AppStoreDeveloperApi.md#appverificationupdate) | **PUT** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/verification | 
[**CreateAppStoreApp**](AppStoreDeveloperApi.md#createappstoreapp) | **POST** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps | 
[**DeleteAppStoreApp**](AppStoreDeveloperApi.md#deleteappstoreapp) | **DELETE** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId} | 
[**GetAppExternalProduct**](AppStoreDeveloperApi.md#getappexternalproduct) | **GET** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/external_product | 
[**GetExternalFunctionSigningKey**](AppStoreDeveloperApi.md#getexternalfunctionsigningkey) | **GET** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/external_function_signing_key | 
[**UpdateAppStoreApp**](AppStoreDeveloperApi.md#updateappstoreapp) | **PUT** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId} | 
[**UpdateExternalProduct**](AppStoreDeveloperApi.md#updateexternalproduct) | **PUT** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/external_product | 
[**UploadAppStoreAppLogo**](AppStoreDeveloperApi.md#uploadappstoreapplogo) | **POST** /api/v1.0/oauthclients/{oauthAppId}/appstore/apps/{appStoreAppId}/logo | 


<a name="appverificationupdate"></a>
# **AppVerificationUpdate**
> void AppVerificationUpdate (string oauthAppId, string appStoreAppId, string verificationStatus)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AppVerificationUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var verificationStatus = verificationStatus_example;  // string | 

            try
            {
                apiInstance.AppVerificationUpdate(oauthAppId, appStoreAppId, verificationStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.AppVerificationUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **verificationStatus** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoreapp"></a>
# **CreateAppStoreApp**
> RestApiResultAppStoreApp CreateAppStoreApp (string oauthAppId, CreateAppStoreApp createAppStoreApp)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var createAppStoreApp = new CreateAppStoreApp(); // CreateAppStoreApp | 

            try
            {
                RestApiResultAppStoreApp result = apiInstance.CreateAppStoreApp(oauthAppId, createAppStoreApp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.CreateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **createAppStoreApp** | [**CreateAppStoreApp**](CreateAppStoreApp.md)|  | 

### Return type

[**RestApiResultAppStoreApp**](RestApiResultAppStoreApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreapp"></a>
# **DeleteAppStoreApp**
> RestApiStringResult DeleteAppStoreApp (string oauthAppId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiStringResult result = apiInstance.DeleteAppStoreApp(oauthAppId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.DeleteAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappexternalproduct"></a>
# **GetAppExternalProduct**
> void GetAppExternalProduct (string oauthAppId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppExternalProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                apiInstance.GetAppExternalProduct(oauthAppId, appStoreAppId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.GetAppExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalfunctionsigningkey"></a>
# **GetExternalFunctionSigningKey**
> void GetExternalFunctionSigningKey (string oauthAppId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetExternalFunctionSigningKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                apiInstance.GetExternalFunctionSigningKey(oauthAppId, appStoreAppId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.GetExternalFunctionSigningKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreapp"></a>
# **UpdateAppStoreApp**
> void UpdateAppStoreApp (string oauthAppId, string appStoreAppId, UpdateAppStoreApp appStoreApp)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var appStoreApp = new UpdateAppStoreApp(); // UpdateAppStoreApp | 

            try
            {
                apiInstance.UpdateAppStoreApp(oauthAppId, appStoreAppId, appStoreApp);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.UpdateAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **appStoreApp** | [**UpdateAppStoreApp**](UpdateAppStoreApp.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalproduct"></a>
# **UpdateExternalProduct**
> void UpdateExternalProduct (string oauthAppId, string appStoreAppId, UpdateAppStoreAppExternalProduct appStoreAppExternalProduct)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateExternalProductExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var appStoreAppExternalProduct = new UpdateAppStoreAppExternalProduct(); // UpdateAppStoreAppExternalProduct | 

            try
            {
                apiInstance.UpdateExternalProduct(oauthAppId, appStoreAppId, appStoreAppExternalProduct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.UpdateExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **appStoreAppExternalProduct** | [**UpdateAppStoreAppExternalProduct**](UpdateAppStoreAppExternalProduct.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadappstoreapplogo"></a>
# **UploadAppStoreAppLogo**
> void UploadAppStoreAppLogo (string oauthAppId, string appStoreAppId, System.IO.Stream image)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadAppStoreAppLogoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreDeveloperApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | App Store App Logo

            try
            {
                apiInstance.UploadAppStoreAppLogo(oauthAppId, appStoreAppId, image);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreDeveloperApi.UploadAppStoreAppLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **image** | **System.IO.Stream**| App Store App Logo | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

