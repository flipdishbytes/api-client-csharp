# Flipdish.Api.SearchApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchRestaurants**](SearchApi.md#searchrestaurants) | **GET** /api/v1.0/search/restaurants | 


<a name="searchrestaurants"></a>
# **SearchRestaurants**
> RestApiPaginationResultRestaurant SearchRestaurants (string query, string countryId, string includeArchivedStores = null, string searchType = null, string publishedStatus = null, int? page = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchRestaurantsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var query = query_example;  // string | 
            var countryId = countryId_example;  // string | 
            var includeArchivedStores = includeArchivedStores_example;  // string |  (optional) 
            var searchType = searchType_example;  // string |  (optional) 
            var publishedStatus = publishedStatus_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultRestaurant result = apiInstance.SearchRestaurants(query, countryId, includeArchivedStores, searchType, publishedStatus, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchRestaurants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | 
 **countryId** | **string**|  | 
 **includeArchivedStores** | **string**|  | [optional] 
 **searchType** | **string**|  | [optional] 
 **publishedStatus** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultRestaurant**](RestApiPaginationResultRestaurant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

