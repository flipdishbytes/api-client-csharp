# Flipdish.Api.KioskIotApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetKioskIotConnection**](KioskIotApi.md#getkioskiotconnection) | **POST** /api/v1.0/kioskiot/connect | Get the IoT connection parameters for telemetry and commands  No input parameters since authenticated hydra user defines context
[**QueryTelemetrySeries**](KioskIotApi.md#querytelemetryseries) | **POST** /api/v1.0/{appId}/kioskiot/timeseries/query | Get the IoT time series values for a given Kiosk Id, properties and time range


<a name="getkioskiotconnection"></a>
# **GetKioskIotConnection**
> RestApiResultKioskIotConnectionParameters GetKioskIotConnection ()

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
    public class GetKioskIotConnectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskIotApi();

            try
            {
                // Get the IoT connection parameters for telemetry and commands  No input parameters since authenticated hydra user defines context
                RestApiResultKioskIotConnectionParameters result = apiInstance.GetKioskIotConnection();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskIotApi.GetKioskIotConnection: " + e.Message );
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

<a name="querytelemetryseries"></a>
# **QueryTelemetrySeries**
> RestApiResultTelemetrySeriesResult QueryTelemetrySeries (string appId, TelemetrySeriesQueryParameters queryParams)

Get the IoT time series values for a given Kiosk Id, properties and time range

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
    public class QueryTelemetrySeriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskIotApi();
            var appId = appId_example;  // string | 
            var queryParams = new TelemetrySeriesQueryParameters(); // TelemetrySeriesQueryParameters | 

            try
            {
                // Get the IoT time series values for a given Kiosk Id, properties and time range
                RestApiResultTelemetrySeriesResult result = apiInstance.QueryTelemetrySeries(appId, queryParams);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskIotApi.QueryTelemetrySeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **queryParams** | [**TelemetrySeriesQueryParameters**](TelemetrySeriesQueryParameters.md)|  | 

### Return type

[**RestApiResultTelemetrySeriesResult**](RestApiResultTelemetrySeriesResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

