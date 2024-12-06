# Flipdish.Api.KioskEntitlementsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryKioskEntitlementsByOrgId**](KioskEntitlementsApi.md#querykioskentitlementsbyorgid) | **GET** /api/v1.0/orgs/{orgId}/kiosk/entitlements | 


<a name="querykioskentitlementsbyorgid"></a>
# **QueryKioskEntitlementsByOrgId**
> RestApiResultKioskEntitlementsResult QueryKioskEntitlementsByOrgId (string orgId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class QueryKioskEntitlementsByOrgIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskEntitlementsApi();
            var orgId = orgId_example;  // string | 

            try
            {
                RestApiResultKioskEntitlementsResult result = apiInstance.QueryKioskEntitlementsByOrgId(orgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskEntitlementsApi.QueryKioskEntitlementsByOrgId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**|  | 

### Return type

[**RestApiResultKioskEntitlementsResult**](RestApiResultKioskEntitlementsResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

