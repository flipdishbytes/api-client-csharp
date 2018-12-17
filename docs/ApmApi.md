# Flipdish.Api.ApmApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBasicStatistics**](ApmApi.md#getbasicstatistics) | **GET** /api/v1.0/apm/statistics | [PRIVATE API] Get Basic Statistics
[**GetCalendarWeekStatistics**](ApmApi.md#getcalendarweekstatistics) | **GET** /api/v1.0/apm/statistics/calendar | [PRIVATE API] Get Calendar statistics
[**GetCallsStatistics**](ApmApi.md#getcallsstatistics) | **GET** /api/v1.0/apm/statistics/calls/{aggregateDataBy} | [PRIVATE API] Get Calls Statistics
[**GetOrderStatistics**](ApmApi.md#getorderstatistics) | **GET** /api/v1.0/apm/statistics/orders/{aggregateDataBy} | [PRIVATE API] Get Order Statistics
[**GetPaginatedCallList**](ApmApi.md#getpaginatedcalllist) | **GET** /api/v1.0/apm/calls | [PRIVATE API] Get paginated APM call list


<a name="getbasicstatistics"></a>
# **GetBasicStatistics**
> RestApiResultApmStatistics GetBasicStatistics (List<int?> storeId)

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
            var storeId = new List<int?>(); // List<int?> | List of stores to search by

            try
            {
                // [PRIVATE API] Get Basic Statistics
                RestApiResultApmStatistics result = apiInstance.GetBasicStatistics(storeId);
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
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | 

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
> RestApiArrayResultApmAverageHourlyDataPoint GetCalendarWeekStatistics (List<int?> storeId)

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
            var storeId = new List<int?>(); // List<int?> | List of stores to search by

            try
            {
                // [PRIVATE API] Get Calendar statistics
                RestApiArrayResultApmAverageHourlyDataPoint result = apiInstance.GetCalendarWeekStatistics(storeId);
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
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | 

### Return type

[**RestApiArrayResultApmAverageHourlyDataPoint**](RestApiArrayResultApmAverageHourlyDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallsstatistics"></a>
# **GetCallsStatistics**
> RestApiArrayResultApmDataPoint GetCallsStatistics (List<int?> storeId, string aggregateDataBy)

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
            var storeId = new List<int?>(); // List<int?> | List of stores to search by
            var aggregateDataBy = aggregateDataBy_example;  // string | Aggregate data by day \\ week

            try
            {
                // [PRIVATE API] Get Calls Statistics
                RestApiArrayResultApmDataPoint result = apiInstance.GetCallsStatistics(storeId, aggregateDataBy);
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
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | 
 **aggregateDataBy** | **string**| Aggregate data by day \\ week | 

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
> RestApiArrayResultApmDataPoint GetOrderStatistics (List<int?> storeId, string aggregateDataBy)

[PRIVATE API] Get Order Statistics

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
            var storeId = new List<int?>(); // List<int?> | List of stores to search by
            var aggregateDataBy = aggregateDataBy_example;  // string | Aggregate data by day \\ week

            try
            {
                // [PRIVATE API] Get Order Statistics
                RestApiArrayResultApmDataPoint result = apiInstance.GetOrderStatistics(storeId, aggregateDataBy);
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
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | 
 **aggregateDataBy** | **string**| Aggregate data by day \\ week | 

### Return type

[**RestApiArrayResultApmDataPoint**](RestApiArrayResultApmDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaginatedcalllist"></a>
# **GetPaginatedCallList**
> RestApiPaginationResultApmCall GetPaginatedCallList (List<int?> storeId, int? page = null, int? limit = null)

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
            var storeId = new List<int?>(); // List<int?> | List of stores to search by
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // [PRIVATE API] Get paginated APM call list
                RestApiPaginationResultApmCall result = apiInstance.GetPaginatedCallList(storeId, page, limit);
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
 **storeId** | [**List&lt;int?&gt;**](int?.md)| List of stores to search by | 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultApmCall**](RestApiPaginationResultApmCall.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

