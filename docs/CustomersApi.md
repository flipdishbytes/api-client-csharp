# IO.Swagger.Api.CustomersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCustomerById**](CustomersApi.md#getcustomerbyid) | **GET** /api/v1.0/{appId}/customers/{customerId} | Get customer of an app by Id
[**UpdateCustomerById**](CustomersApi.md#updatecustomerbyid) | **POST** /api/v1.0/{appId}/customers/{customerId} | Update customer of an app by Id


<a name="getcustomerbyid"></a>
# **GetCustomerById**
> RestApiResultCustomer GetCustomerById (string appId, int? customerId)

Get customer of an app by Id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var appId = appId_example;  // string | App Name Id
            var customerId = 56;  // int? | Customer Id

            try
            {
                // Get customer of an app by Id
                RestApiResultCustomer result = apiInstance.GetCustomerById(appId, customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **customerId** | **int?**| Customer Id | 

### Return type

[**RestApiResultCustomer**](RestApiResultCustomer.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerbyid"></a>
# **UpdateCustomerById**
> RestApiResultCustomer UpdateCustomerById (string appId, int? customerId, CustomerUpdateModel updateCustomer)

Update customer of an app by Id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCustomerByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var appId = appId_example;  // string | App Name Id
            var customerId = 56;  // int? | Customer Id
            var updateCustomer = new CustomerUpdateModel(); // CustomerUpdateModel | Updated customer information

            try
            {
                // Update customer of an app by Id
                RestApiResultCustomer result = apiInstance.UpdateCustomerById(appId, customerId, updateCustomer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **customerId** | **int?**| Customer Id | 
 **updateCustomer** | [**CustomerUpdateModel**](CustomerUpdateModel.md)| Updated customer information | 

### Return type

[**RestApiResultCustomer**](RestApiResultCustomer.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

