# Flipdish.Api.ApmApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBasicStatistics**](ApmApi.md#getbasicstatistics) | **GET** /api/v1.0/{appId}/apm/statistics | [PRIVATE API] Get Basic Statistics
[**GetCalendarWeekStatistics**](ApmApi.md#getcalendarweekstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/calendar | [PRIVATE API] Get Calendar statistics
[**GetCallsStatistics**](ApmApi.md#getcallsstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/calls/{aggregateDataBy} | [PRIVATE API] Get Calls Statistics
[**GetOrderStatistics**](ApmApi.md#getorderstatistics) | **GET** /api/v1.0/{appId}/apm/statistics/orders/{aggregateDataBy} | [PRIVATE API] Get Order Statistics (Value of Orders)
[**GetPaginatedCallList**](ApmApi.md#getpaginatedcalllist) | **GET** /api/v1.0/{appId}/apm/calls | [PRIVATE API] Get paginated APM call list


<a name="getbasicstatistics"></a>
# **GetBasicStatistics**
> RestApiResultApmStatistics GetBasicStatistics (string appId, List<int?> storeId = null)

[PRIVATE API] Get Basic Statistics

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
            var appId = appId_example;  // string | App Name
            var storeId = new List<int?>(); // List<int?> | List of stores to search by (optional) 

            try
            {
                // [PRIVATE API] Get Basic Statistics
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
 **appId** | **string**| App Name | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | [optional] 

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

[PRIVATE API] Get Calendar statistics

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
            var appId = appId_example;  // string | App Name
            var storeId = new List<int?>(); // List<int?> | List of stores to search by (optional) 

            try
            {
                // [PRIVATE API] Get Calendar statistics
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
 **appId** | **string**| App Name | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | [optional] 

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

[PRIVATE API] Get Calls Statistics

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
            var appId = appId_example;  // string | App Name
            var aggregateDataBy = aggregateDataBy_example;  // string | Aggregate data by day \\ week
            var dataPointLimit = 56;  // int? | Amount of data points per request (optional) 
            var storeId = new List<int?>(); // List<int?> | List of stores to search by (optional) 

            try
            {
                // [PRIVATE API] Get Calls Statistics
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
 **appId** | **string**| App Name | 
 **aggregateDataBy** | **string**| Aggregate data by day \\ week | 
 **dataPointLimit** | **int?**| Amount of data points per request | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | [optional] 

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

[PRIVATE API] Get Order Statistics (Value of Orders)

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
            var appId = appId_example;  // string | App Name
            var aggregateDataBy = aggregateDataBy_example;  // string | Aggregate data by day \\ week
            var dataPointLimit = 56;  // int? | Amount of data points per request (optional) 
            var storeId = new List<int?>(); // List<int?> | List of stores to search by (optional) 

            try
            {
                // [PRIVATE API] Get Order Statistics (Value of Orders)
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
 **appId** | **string**| App Name | 
 **aggregateDataBy** | **string**| Aggregate data by day \\ week | 
 **dataPointLimit** | **int?**| Amount of data points per request | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | [optional] 

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

[PRIVATE API] Get paginated APM call list

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
            var appId = appId_example;  // string | App Name
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var storeId = new List<int?>(); // List<int?> | List of stores to search by (optional) 

            try
            {
                // [PRIVATE API] Get paginated APM call list
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
 **appId** | **string**| App Name | 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | [optional] 

### Return type

[**RestApiPaginationResultPhoneCall**](RestApiPaginationResultPhoneCall.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

