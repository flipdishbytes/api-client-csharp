# IO.Swagger.Api.CampaignsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLoyaltyCampaign**](CampaignsApi.md#createloyaltycampaign) | **POST** /api/v1.0/{appId}/campaigns/loyalty | Creates loyalty campaign
[**CreateRetentionCampaign**](CampaignsApi.md#createretentioncampaign) | **POST** /api/v1.0/{appId}/campaigns/retention | Creates retention campaign
[**GetLoyaltyCampaignsForApp**](CampaignsApi.md#getloyaltycampaignsforapp) | **GET** /api/v1.0/{appId}/campaigns/loyalty | Gets loyalty campaigns for app
[**GetLoyaltyCampaignsForStore**](CampaignsApi.md#getloyaltycampaignsforstore) | **GET** /api/v1.0/{appId}/campaigns/loyalty/{storeId} | Gets loyalty campaigns for store
[**GetRetentionCampaignsForApp**](CampaignsApi.md#getretentioncampaignsforapp) | **GET** /api/v1.0/{appId}/campaigns/retention | Gets retention campaigns for app
[**GetRetentionCampaignsForStore**](CampaignsApi.md#getretentioncampaignsforstore) | **GET** /api/v1.0/{appId}/campaigns/retention/{storeId} | Gets retention campaigns for store
[**GetStoreList**](CampaignsApi.md#getstorelist) | **GET** /api/v1.0/{appId}/campaigns/stores | Gets list of stores for app
[**RemoveCampaign**](CampaignsApi.md#removecampaign) | **DELETE** /api/v1.0/{appId}/campaigns/{campaignId} | Deletes a campaign
[**UpdateLoyaltyCampaign**](CampaignsApi.md#updateloyaltycampaign) | **POST** /api/v1.0/{appId}/campaigns/loyalty/{campaignId} | Updates loyalty campaign
[**UpdateRetentionCampaign**](CampaignsApi.md#updateretentioncampaign) | **POST** /api/v1.0/{appId}/campaigns/retention/{campaignId} | Updates retention campaign


<a name="createloyaltycampaign"></a>
# **CreateLoyaltyCampaign**
> RestApiResultLoyaltyCampaign CreateLoyaltyCampaign (string appId, LoyaltyCampaignBase campaign)

Creates loyalty campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLoyaltyCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var campaign = new LoyaltyCampaignBase(); // LoyaltyCampaignBase | Loyalty campaign details

            try
            {
                // Creates loyalty campaign
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
 **appId** | **string**| App Name Id | 
 **campaign** | [**LoyaltyCampaignBase**](LoyaltyCampaignBase.md)| Loyalty campaign details | 

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

Creates retention campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRetentionCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var campaign = new RetentionCampaignBase(); // RetentionCampaignBase | Retention campaign details

            try
            {
                // Creates retention campaign
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
 **appId** | **string**| App Name Id | 
 **campaign** | [**RetentionCampaignBase**](RetentionCampaignBase.md)| Retention campaign details | 

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

Gets loyalty campaigns for app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoyaltyCampaignsForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // Gets loyalty campaigns for app
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
 **appId** | **string**| App Name Id | 

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

Gets loyalty campaigns for store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoyaltyCampaignsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var storeId = 56;  // int? | Store Id

            try
            {
                // Gets loyalty campaigns for store
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
 **appId** | **string**| App Name Id | 
 **storeId** | **int?**| Store Id | 

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

Gets retention campaigns for app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRetentionCampaignsForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // Gets retention campaigns for app
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
 **appId** | **string**| App Name Id | 

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

Gets retention campaigns for store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRetentionCampaignsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var storeId = 56;  // int? | Store Id

            try
            {
                // Gets retention campaigns for store
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
 **appId** | **string**| App Name Id | 
 **storeId** | **int?**| Store Id | 

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
> RestApiArrayResultStoreListItem GetStoreList (string appId)

Gets list of stores for app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // Gets list of stores for app
                RestApiArrayResultStoreListItem result = apiInstance.GetStoreList(appId);
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
 **appId** | **string**| App Name Id | 

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

Deletes a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var campaignId = 56;  // int? | Campaign Id

            try
            {
                // Deletes a campaign
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
 **appId** | **string**| App Name Id | 
 **campaignId** | **int?**| Campaign Id | 

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

Updates loyalty campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLoyaltyCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var campaignId = 56;  // int? | Loyalty campaign Id
            var campaign = new LoyaltyCampaignBase(); // LoyaltyCampaignBase | Loyalty campaign details

            try
            {
                // Updates loyalty campaign
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
 **appId** | **string**| App Name Id | 
 **campaignId** | **int?**| Loyalty campaign Id | 
 **campaign** | [**LoyaltyCampaignBase**](LoyaltyCampaignBase.md)| Loyalty campaign details | 

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

Updates retention campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRetentionCampaignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var appId = appId_example;  // string | App Name Id
            var campaignId = 56;  // int? | Retention campaign Id
            var campaign = new RetentionCampaignBase(); // RetentionCampaignBase | Retention campaign details

            try
            {
                // Updates retention campaign
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
 **appId** | **string**| App Name Id | 
 **campaignId** | **int?**| Retention campaign Id | 
 **campaign** | [**RetentionCampaignBase**](RetentionCampaignBase.md)| Retention campaign details | 

### Return type

[**RestApiResultRetentionCampaign**](RestApiResultRetentionCampaign.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

