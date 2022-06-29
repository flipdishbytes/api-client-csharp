# Flipdish.Api.TerminalIotApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTerminalIotConnection**](TerminalIotApi.md#getterminaliotconnection) | **POST** /api/v1.0/terminaliot/connect | Get the IoT connection parameters for telemetry and commands  No input parameters since authenticated hydra user defines context


<a name="getterminaliotconnection"></a>
# **GetTerminalIotConnection**
> RestApiResultKioskIotConnectionParameters GetTerminalIotConnection ()

Get the IoT connection parameters for telemetry and commands  No input parameters since authenticated hydra user defines context

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetTerminalIotConnectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TerminalIotApi();

            try
            {
                // Get the IoT connection parameters for telemetry and commands  No input parameters since authenticated hydra user defines context
                RestApiResultKioskIotConnectionParameters result = apiInstance.GetTerminalIotConnection();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TerminalIotApi.GetTerminalIotConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultKioskIotConnectionParameters**](RestApiResultKioskIotConnectionParameters.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
