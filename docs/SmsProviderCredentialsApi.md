# Flipdish.Api.SmsProviderCredentialsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBrandSmsProviderCredentialByServiceType**](SmsProviderCredentialsApi.md#getbrandsmsprovidercredentialbyservicetype) | **GET** /api/v1.0/sms-providers/orgs/{orgId}/brands/{brandId}/provider-credentials/{serviceType} | 
[**GetBrandSmsProviderCredentials**](SmsProviderCredentialsApi.md#getbrandsmsprovidercredentials) | **GET** /api/v1.0/sms-providers/orgs/{orgId}/brands/{brandId}/provider-credentials | 
[**SmsProviderCredentialDelete**](SmsProviderCredentialsApi.md#smsprovidercredentialdelete) | **DELETE** /api/v1.0/sms-providers/orgs/{orgId}/brands/{brandId}/provider-credentials/{serviceType} | 
[**SmsProviderCredentialUpdate**](SmsProviderCredentialsApi.md#smsprovidercredentialupdate) | **POST** /api/v1.0/sms-providers/orgs/{orgId}/brands/{brandId}/provider-credentials/{serviceType} | 
[**SmsProviderCredentialsBulkUpsert**](SmsProviderCredentialsApi.md#smsprovidercredentialsbulkupsert) | **POST** /api/v1.0/sms-providers/bulk-upsert | 


<a name="getbrandsmsprovidercredentialbyservicetype"></a>
# **GetBrandSmsProviderCredentialByServiceType**
> RestApiResultSmsProviderCredential GetBrandSmsProviderCredentialByServiceType (string orgId, string brandId, string serviceType, bool? withFallback = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBrandSmsProviderCredentialByServiceTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsProviderCredentialsApi();
            var orgId = orgId_example;  // string | 
            var brandId = brandId_example;  // string | 
            var serviceType = serviceType_example;  // string | 
            var withFallback = true;  // bool? |  (optional) 

            try
            {
                RestApiResultSmsProviderCredential result = apiInstance.GetBrandSmsProviderCredentialByServiceType(orgId, brandId, serviceType, withFallback);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsProviderCredentialsApi.GetBrandSmsProviderCredentialByServiceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**|  | 
 **brandId** | **string**|  | 
 **serviceType** | **string**|  | 
 **withFallback** | **bool?**|  | [optional] 

### Return type

[**RestApiResultSmsProviderCredential**](RestApiResultSmsProviderCredential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandsmsprovidercredentials"></a>
# **GetBrandSmsProviderCredentials**
> RestApiArrayResultSmsProviderCredential GetBrandSmsProviderCredentials (string orgId, string brandId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBrandSmsProviderCredentialsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsProviderCredentialsApi();
            var orgId = orgId_example;  // string | 
            var brandId = brandId_example;  // string | 

            try
            {
                RestApiArrayResultSmsProviderCredential result = apiInstance.GetBrandSmsProviderCredentials(orgId, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsProviderCredentialsApi.GetBrandSmsProviderCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**|  | 
 **brandId** | **string**|  | 

### Return type

[**RestApiArrayResultSmsProviderCredential**](RestApiArrayResultSmsProviderCredential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsprovidercredentialdelete"></a>
# **SmsProviderCredentialDelete**
> RestApiResultSmsProviderCredential SmsProviderCredentialDelete (string orgId, string brandId, string serviceType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SmsProviderCredentialDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsProviderCredentialsApi();
            var orgId = orgId_example;  // string | 
            var brandId = brandId_example;  // string | 
            var serviceType = serviceType_example;  // string | 

            try
            {
                RestApiResultSmsProviderCredential result = apiInstance.SmsProviderCredentialDelete(orgId, brandId, serviceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsProviderCredentialsApi.SmsProviderCredentialDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**|  | 
 **brandId** | **string**|  | 
 **serviceType** | **string**|  | 

### Return type

[**RestApiResultSmsProviderCredential**](RestApiResultSmsProviderCredential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsprovidercredentialupdate"></a>
# **SmsProviderCredentialUpdate**
> RestApiResultSmsProviderCredential SmsProviderCredentialUpdate (string orgId, string brandId, string serviceType, SmsProviderCredentialUpdateRequest credential)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SmsProviderCredentialUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsProviderCredentialsApi();
            var orgId = orgId_example;  // string | 
            var brandId = brandId_example;  // string | 
            var serviceType = serviceType_example;  // string | 
            var credential = new SmsProviderCredentialUpdateRequest(); // SmsProviderCredentialUpdateRequest | 

            try
            {
                RestApiResultSmsProviderCredential result = apiInstance.SmsProviderCredentialUpdate(orgId, brandId, serviceType, credential);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsProviderCredentialsApi.SmsProviderCredentialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**|  | 
 **brandId** | **string**|  | 
 **serviceType** | **string**|  | 
 **credential** | [**SmsProviderCredentialUpdateRequest**](SmsProviderCredentialUpdateRequest.md)|  | 

### Return type

[**RestApiResultSmsProviderCredential**](RestApiResultSmsProviderCredential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsprovidercredentialsbulkupsert"></a>
# **SmsProviderCredentialsBulkUpsert**
> RestApiArrayResultSmsProviderCredential SmsProviderCredentialsBulkUpsert (List<SmsProviderCredential> credentials)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SmsProviderCredentialsBulkUpsertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SmsProviderCredentialsApi();
            var credentials = new List<SmsProviderCredential>(); // List<SmsProviderCredential> | 

            try
            {
                RestApiArrayResultSmsProviderCredential result = apiInstance.SmsProviderCredentialsBulkUpsert(credentials);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsProviderCredentialsApi.SmsProviderCredentialsBulkUpsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credentials** | [**List&lt;SmsProviderCredential&gt;**](SmsProviderCredential.md)|  | 

### Return type

[**RestApiArrayResultSmsProviderCredential**](RestApiArrayResultSmsProviderCredential.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

