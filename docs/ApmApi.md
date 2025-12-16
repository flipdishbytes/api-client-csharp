# Flipdish.Api.ApmApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApmStatus**](ApmApi.md#getapmstatus) | **GET** /api/v1.0/{appId}/apm/status | 
[**GetBasicStatistics**](ApmApi.md#getbasicstatistics) | **GET** /api/v1.0/{appId}/apm/statistics | 
[**GetCalendarWeekStatistics**](ApmApi.md#getcalendarweekstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/calendar | 
[**GetCallsStatistics**](ApmApi.md#getcallsstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/calls/{aggregateDataBy} | 
[**GetOrderStatistics**](ApmApi.md#getorderstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/orders/{aggregateDataBy} | 
[**GetPaginatedCallList**](ApmApi.md#getpaginatedcalllist) | **GET** /api/v1.0/{appId}/apm/calls | 


<a name="getapmstatus"></a>
# **GetApmStatus**
> RestApiResultApmStatus GetApmStatus (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetApmStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultApmStatus result = apiInstance.GetApmStatus(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetApmStatus: " + e.Message );
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

[**RestApiResultApmStatus**](RestApiResultApmStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbasicstatistics"></a>
# **GetBasicStatistics**
> RestApiResultApmStatistics GetBasicStatistics (string appId, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBasicStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiResultApmStatistics result = apiInstance.GetBasicStatistics(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetBasicStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiResultApmStatistics**](RestApiResultApmStatistics.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalendarweekstatistics"></a>
# **GetCalendarWeekStatistics**
> RestApiArrayResultApmHourlyDataPoint GetCalendarWeekStatistics (string appId, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCalendarWeekStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiArrayResultApmHourlyDataPoint result = apiInstance.GetCalendarWeekStatistics(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetCalendarWeekStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiArrayResultApmHourlyDataPoint**](RestApiArrayResultApmHourlyDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallsstatistics"></a>
# **GetCallsStatistics**
> RestApiArrayResultApmDataPoint GetCallsStatistics (string appId, string aggregateDataBy, int? dataPointLimit = null, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCallsStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 
            var aggregateDataBy = aggregateDataBy_example;  // string | 
            var dataPointLimit = 56;  // int? |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiArrayResultApmDataPoint result = apiInstance.GetCallsStatistics(appId, aggregateDataBy, dataPointLimit, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetCallsStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **aggregateDataBy** | **string**|  | 
 **dataPointLimit** | **int?**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiArrayResultApmDataPoint**](RestApiArrayResultApmDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderstatistics"></a>
# **GetOrderStatistics**
> RestApiArrayResultApmCurrencyDataPoint GetOrderStatistics (string appId, string aggregateDataBy, int? dataPointLimit = null, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetOrderStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 
            var aggregateDataBy = aggregateDataBy_example;  // string | 
            var dataPointLimit = 56;  // int? |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiArrayResultApmCurrencyDataPoint result = apiInstance.GetOrderStatistics(appId, aggregateDataBy, dataPointLimit, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetOrderStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **aggregateDataBy** | **string**|  | 
 **dataPointLimit** | **int?**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiArrayResultApmCurrencyDataPoint**](RestApiArrayResultApmCurrencyDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaginatedcalllist"></a>
# **GetPaginatedCallList**
> RestApiPaginationResultPhoneCall GetPaginatedCallList (string appId, int? page = null, int? limit = null, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPaginatedCallListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApmApi();
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiPaginationResultPhoneCall result = apiInstance.GetPaginatedCallList(appId, page, limit, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApmApi.GetPaginatedCallList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultPhoneCall**](RestApiPaginationResultPhoneCall.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

