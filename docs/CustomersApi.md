# Flipdish.Api.CustomersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /api/v1.0/{appId}/customers | 
[**GetCustomerById**](CustomersApi.md#getcustomerbyid) | **GET** /api/v1.0/{appId}/customers/{customerId} | 
[**UpdateCustomerById**](CustomersApi.md#updatecustomerbyid) | **POST** /api/v1.0/{appId}/customers/{customerId} | 


<a name="createcustomer"></a>
# **CreateCustomer**
> RestApiResultCustomer CreateCustomer (string appId, CustomerCreateModel customerCreateModel)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateCustomerExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var appId = appId_example;  // string | 
            var customerCreateModel = new CustomerCreateModel(); // CustomerCreateModel | 

            try
            {
                RestApiResultCustomer result = apiInstance.CreateCustomer(appId, customerCreateModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **customerCreateModel** | [**CustomerCreateModel**](CustomerCreateModel.md)|  | 

### Return type

[**RestApiResultCustomer**](RestApiResultCustomer.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerbyid"></a>
# **GetCustomerById**
> RestApiResultCustomer GetCustomerById (string appId, int? customerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCustomerByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var appId = appId_example;  // string | 
            var customerId = 56;  // int? | 

            try
            {
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
 **appId** | **string**|  | 
 **customerId** | **int?**|  | 

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateCustomerByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomersApi();
            var appId = appId_example;  // string | 
            var customerId = 56;  // int? | 
            var updateCustomer = new CustomerUpdateModel(); // CustomerUpdateModel | 

            try
            {
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
 **appId** | **string**|  | 
 **customerId** | **int?**|  | 
 **updateCustomer** | [**CustomerUpdateModel**](CustomerUpdateModel.md)|  | 

### Return type

[**RestApiResultCustomer**](RestApiResultCustomer.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

