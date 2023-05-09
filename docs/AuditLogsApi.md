# Flipdish.Api.AuditLogsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderAuditLog**](AuditLogsApi.md#addorderauditlog) | **POST** /api/v1.0/auditlogs/orders/{orderId} | 
[**AddStoreAuditLogEvent**](AuditLogsApi.md#addstoreauditlogevent) | **POST** /api/v1.0/auditlogs/stores/{storeId} | 


<a name="addorderauditlog"></a>
# **AddOrderAuditLog**
> void AddOrderAuditLog (int? orderId, List<ExternalStoreAuditLog> externalEventCreate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrderAuditLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditLogsApi();
            var orderId = 56;  // int? | 
            var externalEventCreate = new List<ExternalStoreAuditLog>(); // List<ExternalStoreAuditLog> | 

            try
            {
                apiInstance.AddOrderAuditLog(orderId, externalEventCreate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.AddOrderAuditLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 
 **externalEventCreate** | [**List&lt;ExternalStoreAuditLog&gt;**](ExternalStoreAuditLog.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstoreauditlogevent"></a>
# **AddStoreAuditLogEvent**
> void AddStoreAuditLogEvent (int? storeId, List<ExternalStoreAuditLog> externalEventCreate)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddStoreAuditLogEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditLogsApi();
            var storeId = 56;  // int? | 
            var externalEventCreate = new List<ExternalStoreAuditLog>(); // List<ExternalStoreAuditLog> | 

            try
            {
                apiInstance.AddStoreAuditLogEvent(storeId, externalEventCreate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogsApi.AddStoreAuditLogEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **externalEventCreate** | [**List&lt;ExternalStoreAuditLog&gt;**](ExternalStoreAuditLog.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

