# Flipdish.Api.WebsiteApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTestimonial**](WebsiteApi.md#addtestimonial) | **POST** /api/v1.0/{appId}/website/testimonial | 
[**DeleteTestimonial**](WebsiteApi.md#deletetestimonial) | **DELETE** /api/v1.0/{appId}/website/testimonial/{testimonialId} | 
[**DeleteWebsiteImage**](WebsiteApi.md#deletewebsiteimage) | **DELETE** /api/v1.0/{appId}/website/image/{imageId} | 
[**EditTestimonial**](WebsiteApi.md#edittestimonial) | **POST** /api/v1.0/{appId}/website/testimonial/{testimonialId} | 
[**GetIndexConfiguration**](WebsiteApi.md#getindexconfiguration) | **GET** /api/v1.0/{appId}/website/index | 
[**SetIndexConfiguration**](WebsiteApi.md#setindexconfiguration) | **POST** /api/v1.0/{appId}/website/index | 
[**UploadWebsiteImage**](WebsiteApi.md#uploadwebsiteimage) | **POST** /api/v1.0/{appId}/website/image/{imageLocation} | 
[**WebsiteCheckNow**](WebsiteApi.md#websitechecknow) | **GET** /api/v1.0/{appId}/website/dnscheck | 


<a name="addtestimonial"></a>
# **AddTestimonial**
> RestApiResultWebsiteTestimonial AddTestimonial (string appId, WebsiteTestimonialBase testimonial)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddTestimonialExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var testimonial = new WebsiteTestimonialBase(); // WebsiteTestimonialBase | 

            try
            {
                RestApiResultWebsiteTestimonial result = apiInstance.AddTestimonial(appId, testimonial);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.AddTestimonial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **testimonial** | [**WebsiteTestimonialBase**](WebsiteTestimonialBase.md)|  | 

### Return type

[**RestApiResultWebsiteTestimonial**](RestApiResultWebsiteTestimonial.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetestimonial"></a>
# **DeleteTestimonial**
> void DeleteTestimonial (string appId, int? testimonialId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteTestimonialExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var testimonialId = 56;  // int? | 

            try
            {
                apiInstance.DeleteTestimonial(appId, testimonialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.DeleteTestimonial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **testimonialId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebsiteimage"></a>
# **DeleteWebsiteImage**
> void DeleteWebsiteImage (string appId, int? imageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteWebsiteImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var imageId = 56;  // int? | 

            try
            {
                apiInstance.DeleteWebsiteImage(appId, imageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.DeleteWebsiteImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **imageId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittestimonial"></a>
# **EditTestimonial**
> RestApiResultWebsiteTestimonial EditTestimonial (string appId, int? testimonialId, WebsiteTestimonialBase testimonial)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class EditTestimonialExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var testimonialId = 56;  // int? | 
            var testimonial = new WebsiteTestimonialBase(); // WebsiteTestimonialBase | 

            try
            {
                RestApiResultWebsiteTestimonial result = apiInstance.EditTestimonial(appId, testimonialId, testimonial);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.EditTestimonial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **testimonialId** | **int?**|  | 
 **testimonial** | [**WebsiteTestimonialBase**](WebsiteTestimonialBase.md)|  | 

### Return type

[**RestApiResultWebsiteTestimonial**](RestApiResultWebsiteTestimonial.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindexconfiguration"></a>
# **GetIndexConfiguration**
> RestApiResultIndexPage GetIndexConfiguration (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetIndexConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultIndexPage result = apiInstance.GetIndexConfiguration(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.GetIndexConfiguration: " + e.Message );
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

[**RestApiResultIndexPage**](RestApiResultIndexPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setindexconfiguration"></a>
# **SetIndexConfiguration**
> RestApiResultIndexPageBase SetIndexConfiguration (string appId, IndexPageBase indexPage)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetIndexConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var indexPage = new IndexPageBase(); // IndexPageBase | 

            try
            {
                RestApiResultIndexPageBase result = apiInstance.SetIndexConfiguration(appId, indexPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.SetIndexConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **indexPage** | [**IndexPageBase**](IndexPageBase.md)|  | 

### Return type

[**RestApiResultIndexPageBase**](RestApiResultIndexPageBase.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadwebsiteimage"></a>
# **UploadWebsiteImage**
> RestApiResultWebsiteImage UploadWebsiteImage (string appId, string imageLocation, System.IO.Stream image)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadWebsiteImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 
            var imageLocation = imageLocation_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | App Logo

            try
            {
                RestApiResultWebsiteImage result = apiInstance.UploadWebsiteImage(appId, imageLocation, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.UploadWebsiteImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **imageLocation** | **string**|  | 
 **image** | **System.IO.Stream**| App Logo | 

### Return type

[**RestApiResultWebsiteImage**](RestApiResultWebsiteImage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="websitechecknow"></a>
# **WebsiteCheckNow**
> void WebsiteCheckNow (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class WebsiteCheckNowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteApi();
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.WebsiteCheckNow(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteApi.WebsiteCheckNow: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

