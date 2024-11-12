# Flipdish.Api.AddressApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressTemplates**](AddressApi.md#addresstemplates) | **POST** /api/v1.0/address/templates | 
[**FormByApp**](AddressApi.md#formbyapp) | **GET** /api/v1.0/app/{appId}/address/form | 
[**FormByCountry**](AddressApi.md#formbycountry) | **GET** /api/v1.0/address/country/{countryCode}/form | 
[**FormatGoogleAddress**](AddressApi.md#formatgoogleaddress) | **POST** /api/v1.0/address/google | 
[**GetCountries**](AddressApi.md#getcountries) | **GET** /api/v1.0/address/countries | 


<a name="addresstemplates"></a>
# **AddressTemplates**
> RestApiStringResult AddressTemplates (StoreAddressForm address)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddressTemplatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressApi();
            var address = new StoreAddressForm(); // StoreAddressForm | 

            try
            {
                RestApiStringResult result = apiInstance.AddressTemplates(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | [**StoreAddressForm**](StoreAddressForm.md)|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formbyapp"></a>
# **FormByApp**
> RestApiResultAddressFormResponse FormByApp (string appId, string language = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FormByAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressApi();
            var appId = appId_example;  // string | 
            var language = language_example;  // string |  (optional) 

            try
            {
                RestApiResultAddressFormResponse result = apiInstance.FormByApp(appId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.FormByApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **language** | **string**|  | [optional] 

### Return type

[**RestApiResultAddressFormResponse**](RestApiResultAddressFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formbycountry"></a>
# **FormByCountry**
> RestApiResultAddressFormResponse FormByCountry (string countryCode, string language = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FormByCountryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressApi();
            var countryCode = countryCode_example;  // string | 
            var language = language_example;  // string |  (optional) 

            try
            {
                RestApiResultAddressFormResponse result = apiInstance.FormByCountry(countryCode, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.FormByCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCode** | **string**|  | 
 **language** | **string**|  | [optional] 

### Return type

[**RestApiResultAddressFormResponse**](RestApiResultAddressFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formatgoogleaddress"></a>
# **FormatGoogleAddress**
> RestApiResultAddressFormResponse FormatGoogleAddress (GoogleAddress googleAddress, string language = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FormatGoogleAddressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressApi();
            var googleAddress = new GoogleAddress(); // GoogleAddress | 
            var language = language_example;  // string |  (optional) 

            try
            {
                RestApiResultAddressFormResponse result = apiInstance.FormatGoogleAddress(googleAddress, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.FormatGoogleAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **googleAddress** | [**GoogleAddress**](GoogleAddress.md)|  | 
 **language** | **string**|  | [optional] 

### Return type

[**RestApiResultAddressFormResponse**](RestApiResultAddressFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountries"></a>
# **GetCountries**
> RestApiResultCountryFormResponse GetCountries (string language = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressApi();
            var language = language_example;  // string |  (optional) 

            try
            {
                RestApiResultCountryFormResponse result = apiInstance.GetCountries(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.GetCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**|  | [optional] 

### Return type

[**RestApiResultCountryFormResponse**](RestApiResultCountryFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

