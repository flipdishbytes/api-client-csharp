# Flipdish.Api.ContentSecurityPolicyApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Report**](ContentSecurityPolicyApi.md#report) | **POST** /api/v1.0/csp/report | 


<a name="report"></a>
# **Report**
> void Report (CspReportRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ReportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentSecurityPolicyApi();
            var request = new CspReportRequest(); // CspReportRequest | 

            try
            {
                apiInstance.Report(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentSecurityPolicyApi.Report: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CspReportRequest**](CspReportRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

