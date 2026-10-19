# Flipdish.Api.WhiteLabelContactFormTypeApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppContactFormType**](WhiteLabelContactFormTypeApi.md#getappcontactformtype) | **GET** /api/v1.0/whitelabelconfig/{appId}/contact-form-type | 
[**UpdateAppContactFormType**](WhiteLabelContactFormTypeApi.md#updateappcontactformtype) | **POST** /api/v1.0/whitelabelconfig/{appId}/contact-form-type | 


<a name="getappcontactformtype"></a>
# **GetAppContactFormType**
> RestApiResultContactFormTypeConfigModel GetAppContactFormType (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppContactFormTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelContactFormTypeApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultContactFormTypeConfigModel result = apiInstance.GetAppContactFormType(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelContactFormTypeApi.GetAppContactFormType: " + e.Message );
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

[**RestApiResultContactFormTypeConfigModel**](RestApiResultContactFormTypeConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappcontactformtype"></a>
# **UpdateAppContactFormType**
> RestApiResultContactFormTypeConfigModel UpdateAppContactFormType (string appId, ContactFormTypeConfigModel contactFormTypeConfig)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppContactFormTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WhiteLabelContactFormTypeApi();
            var appId = appId_example;  // string | 
            var contactFormTypeConfig = new ContactFormTypeConfigModel(); // ContactFormTypeConfigModel | 

            try
            {
                RestApiResultContactFormTypeConfigModel result = apiInstance.UpdateAppContactFormType(appId, contactFormTypeConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhiteLabelContactFormTypeApi.UpdateAppContactFormType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **contactFormTypeConfig** | [**ContactFormTypeConfigModel**](ContactFormTypeConfigModel.md)|  | 

### Return type

[**RestApiResultContactFormTypeConfigModel**](RestApiResultContactFormTypeConfigModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

