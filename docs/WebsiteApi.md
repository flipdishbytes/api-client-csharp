# Flipdish.Api.WebsiteApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTestimonial**](WebsiteApi.md#addtestimonial) | **POST** /api/v1.0/{appId}/website/testimonial | Add a testimonial
[**DeleteTestimonial**](WebsiteApi.md#deletetestimonial) | **DELETE** /api/v1.0/{appId}/website/testimonial/{testimonialId} | Delete a testimonial
[**DeleteWebsiteImage**](WebsiteApi.md#deletewebsiteimage) | **DELETE** /api/v1.0/{appId}/website/image/{imageId} | Delete Website Image
[**EditTestimonial**](WebsiteApi.md#edittestimonial) | **POST** /api/v1.0/{appId}/website/testimonial/{testimonialId} | Edit a testimonial
[**GetIndexConfiguration**](WebsiteApi.md#getindexconfiguration) | **GET** /api/v1.0/{appId}/website/index | Get Index Configuration
[**SetIndexConfiguration**](WebsiteApi.md#setindexconfiguration) | **POST** /api/v1.0/{appId}/website/index | Set Index Configuration
[**UploadWebsiteImage**](WebsiteApi.md#uploadwebsiteimage) | **POST** /api/v1.0/{appId}/website/image/{imageLocation} | Upload Website Image
[**WebsiteCheckNow**](WebsiteApi.md#websitechecknow) | **GET** /api/v1.0/{appId}/website/dnscheck | Triggers a Check DNS Process


<a name="addtestimonial"></a>
# **AddTestimonial**
> RestApiResultWebsiteTestimonial AddTestimonial (string appId, WebsiteTestimonialBase testimonial)

Add a testimonial

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
            var appId = appId_example;  // string | Application identifier
            var testimonial = new WebsiteTestimonialBase(); // WebsiteTestimonialBase | Testimonial to be added

            try
            {
                // Add a testimonial
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
 **appId** | **string**| Application identifier | 
 **testimonial** | [**WebsiteTestimonialBase**](WebsiteTestimonialBase.md)| Testimonial to be added | 

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

Delete a testimonial

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
            var appId = appId_example;  // string | Application identifier
            var testimonialId = 56;  // int? | Id of the testimonial to delete

            try
            {
                // Delete a testimonial
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
 **appId** | **string**| Application identifier | 
 **testimonialId** | **int?**| Id of the testimonial to delete | 

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

Delete Website Image

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
            var appId = appId_example;  // string | Application identifier
            var imageId = 56;  // int? | Id of the image

            try
            {
                // Delete Website Image
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
 **appId** | **string**| Application identifier | 
 **imageId** | **int?**| Id of the image | 

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

Edit a testimonial

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
            var appId = appId_example;  // string | Application identifier
            var testimonialId = 56;  // int? | Id of the testimonial to edit
            var testimonial = new WebsiteTestimonialBase(); // WebsiteTestimonialBase | New values of the testimonial

            try
            {
                // Edit a testimonial
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
 **appId** | **string**| Application identifier | 
 **testimonialId** | **int?**| Id of the testimonial to edit | 
 **testimonial** | [**WebsiteTestimonialBase**](WebsiteTestimonialBase.md)| New values of the testimonial | 

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

Get Index Configuration

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
            var appId = appId_example;  // string | Application identifier

            try
            {
                // Get Index Configuration
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
 **appId** | **string**| Application identifier | 

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

Set Index Configuration

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
            var appId = appId_example;  // string | Application identifier
            var indexPage = new IndexPageBase(); // IndexPageBase | New index page definition

            try
            {
                // Set Index Configuration
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
 **appId** | **string**| Application identifier | 
 **indexPage** | [**IndexPageBase**](IndexPageBase.md)| New index page definition | 

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

Upload Website Image

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
            var appId = appId_example;  // string | Application identifier
            var imageLocation = imageLocation_example;  // string | Section for which to upload the image
            var image = new System.IO.Stream(); // System.IO.Stream | App Logo

            try
            {
                // Upload Website Image
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
 **appId** | **string**| Application identifier | 
 **imageLocation** | **string**| Section for which to upload the image | 
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

Triggers a Check DNS Process

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
                // Triggers a Check DNS Process
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

