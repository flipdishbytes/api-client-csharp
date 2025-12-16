# Flipdish.Api.ClientsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClient**](ClientsApi.md#getclient) | **GET** /api/v1.0/clients/{clientId} | 
[**SetSalesForceContactId**](ClientsApi.md#setsalesforcecontactid) | **POST** /api/v1.0/clients/{clientId}/salesforcecontactid | 
[**SetStripeCustomerId**](ClientsApi.md#setstripecustomerid) | **POST** /api/v1.0/clients/{clientId}/stripecustomerid | 


<a name="getclient"></a>
# **GetClient**
> void GetClient (int? clientId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetClientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi();
            var clientId = 56;  // int? | 

            try
            {
                apiInstance.GetClient(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsalesforcecontactid"></a>
# **SetSalesForceContactId**
> void SetSalesForceContactId (int? clientId, string salesForceContactId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetSalesForceContactIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi();
            var clientId = 56;  // int? | 
            var salesForceContactId = salesForceContactId_example;  // string | 

            try
            {
                apiInstance.SetSalesForceContactId(clientId, salesForceContactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.SetSalesForceContactId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**|  | 
 **salesForceContactId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstripecustomerid"></a>
# **SetStripeCustomerId**
> void SetStripeCustomerId (int? clientId, string stripeCustomerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetStripeCustomerIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientsApi();
            var clientId = 56;  // int? | 
            var stripeCustomerId = stripeCustomerId_example;  // string | 

            try
            {
                apiInstance.SetStripeCustomerId(clientId, stripeCustomerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.SetStripeCustomerId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**|  | 
 **stripeCustomerId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

