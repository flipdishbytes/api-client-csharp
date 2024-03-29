# Flipdish.Api.CampaignsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLoyaltyCampaign**](CampaignsApi.md#createloyaltycampaign) | **POST** /api/v1.0/{appId}/campaigns/loyalty | 
[**CreateRetentionCampaign**](CampaignsApi.md#createretentioncampaign) | **POST** /api/v1.0/{appId}/campaigns/retention | 
[**GetLoyaltyCampaignsForApp**](CampaignsApi.md#getloyaltycampaignsforapp) | **GET** /api/v1.0/{appId}/campaigns/loyalty | 
[**GetLoyaltyCampaignsForStore**](CampaignsApi.md#getloyaltycampaignsforstore) | **GET** /api/v1.0/{appId}/campaigns/loyalty/{storeId} | 
[**GetRetentionCampaignsForApp**](CampaignsApi.md#getretentioncampaignsforapp) | **GET** /api/v1.0/{appId}/campaigns/retention | 
[**GetRetentionCampaignsForStore**](CampaignsApi.md#getretentioncampaignsforstore) | **GET** /api/v1.0/{appId}/campaigns/retention/{storeId} | 
[**GetStoreList**](CampaignsApi.md#getstorelist) | **GET** /api/v1.0/{appId}/campaigns/stores | 
[**RemoveCampaign**](CampaignsApi.md#removecampaign) | **DELETE** /api/v1.0/{appId}/campaigns/{campaignId} | 
[**UpdateLoyaltyCampaign**](CampaignsApi.md#updateloyaltycampaign) | **POST** /api/v1.0/{appId}/campaigns/loyalty/{campaignId} | 
[**UpdateRetentionCampaign**](CampaignsApi.md#updateretentioncampaign) | **POST** /api/v1.0/{appId}/campaigns/retention/{campaignId} | 


<a name="createloyaltycampaign"></a>
# **CreateLoyaltyCampaign**
> RestApiResultLoyaltyCampaign CreateLoyaltyCampaign (string appId, LoyaltyCampaignBase campaign)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateLoyaltyCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var campaign = new LoyaltyCampaignBase(); // LoyaltyCampaignBase | 

            try
            {
                RestApiResultLoyaltyCampaign result = apiInstance.CreateLoyaltyCampaign(appId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateLoyaltyCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **campaign** | [**LoyaltyCampaignBase**](LoyaltyCampaignBase.md)|  | 

### Return type

[**RestApiResultLoyaltyCampaign**](RestApiResultLoyaltyCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createretentioncampaign"></a>
# **CreateRetentionCampaign**
> RestApiResultRetentionCampaign CreateRetentionCampaign (string appId, RetentionCampaignBase campaign)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateRetentionCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var campaign = new RetentionCampaignBase(); // RetentionCampaignBase | 

            try
            {
                RestApiResultRetentionCampaign result = apiInstance.CreateRetentionCampaign(appId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateRetentionCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **campaign** | [**RetentionCampaignBase**](RetentionCampaignBase.md)|  | 

### Return type

[**RestApiResultRetentionCampaign**](RestApiResultRetentionCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycampaignsforapp"></a>
# **GetLoyaltyCampaignsForApp**
> RestApiArrayResultLoyaltyCampaign GetLoyaltyCampaignsForApp (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLoyaltyCampaignsForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultLoyaltyCampaign result = apiInstance.GetLoyaltyCampaignsForApp(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetLoyaltyCampaignsForApp: " + e.Message );
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

[**RestApiArrayResultLoyaltyCampaign**](RestApiArrayResultLoyaltyCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltycampaignsforstore"></a>
# **GetLoyaltyCampaignsForStore**
> RestApiArrayResultLoyaltyCampaign GetLoyaltyCampaignsForStore (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLoyaltyCampaignsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultLoyaltyCampaign result = apiInstance.GetLoyaltyCampaignsForStore(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetLoyaltyCampaignsForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiArrayResultLoyaltyCampaign**](RestApiArrayResultLoyaltyCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getretentioncampaignsforapp"></a>
# **GetRetentionCampaignsForApp**
> RestApiArrayResultRetentionCampaign GetRetentionCampaignsForApp (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRetentionCampaignsForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultRetentionCampaign result = apiInstance.GetRetentionCampaignsForApp(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetRetentionCampaignsForApp: " + e.Message );
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

[**RestApiArrayResultRetentionCampaign**](RestApiArrayResultRetentionCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getretentioncampaignsforstore"></a>
# **GetRetentionCampaignsForStore**
> RestApiArrayResultRetentionCampaign GetRetentionCampaignsForStore (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRetentionCampaignsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultRetentionCampaign result = apiInstance.GetRetentionCampaignsForStore(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetRetentionCampaignsForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiArrayResultRetentionCampaign**](RestApiArrayResultRetentionCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorelist"></a>
# **GetStoreList**
> RestApiArrayResultStoreListItem GetStoreList (string appId, bool? onlyPublished = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var onlyPublished = true;  // bool? |  (optional) 

            try
            {
                RestApiArrayResultStoreListItem result = apiInstance.GetStoreList(appId, onlyPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetStoreList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **onlyPublished** | **bool?**|  | [optional] 

### Return type

[**RestApiArrayResultStoreListItem**](RestApiArrayResultStoreListItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecampaign"></a>
# **RemoveCampaign**
> void RemoveCampaign (string appId, int? campaignId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var campaignId = 56;  // int? | 

            try
            {
                apiInstance.RemoveCampaign(appId, campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.RemoveCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **campaignId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloyaltycampaign"></a>
# **UpdateLoyaltyCampaign**
> RestApiResultLoyaltyCampaign UpdateLoyaltyCampaign (string appId, int? campaignId, LoyaltyCampaignBase campaign)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateLoyaltyCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var campaignId = 56;  // int? | 
            var campaign = new LoyaltyCampaignBase(); // LoyaltyCampaignBase | 

            try
            {
                RestApiResultLoyaltyCampaign result = apiInstance.UpdateLoyaltyCampaign(appId, campaignId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateLoyaltyCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **campaignId** | **int?**|  | 
 **campaign** | [**LoyaltyCampaignBase**](LoyaltyCampaignBase.md)|  | 

### Return type

[**RestApiResultLoyaltyCampaign**](RestApiResultLoyaltyCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateretentioncampaign"></a>
# **UpdateRetentionCampaign**
> RestApiResultRetentionCampaign UpdateRetentionCampaign (string appId, int? campaignId, RetentionCampaignBase campaign)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateRetentionCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | 
            var campaignId = 56;  // int? | 
            var campaign = new RetentionCampaignBase(); // RetentionCampaignBase | 

            try
            {
                RestApiResultRetentionCampaign result = apiInstance.UpdateRetentionCampaign(appId, campaignId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateRetentionCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **campaignId** | **int?**|  | 
 **campaign** | [**RetentionCampaignBase**](RetentionCampaignBase.md)|  | 

### Return type

[**RestApiResultRetentionCampaign**](RestApiResultRetentionCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

