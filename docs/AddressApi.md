# Flipdish.Api.AddressApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FormByApp**](AddressApi.md#formbyapp) | **GET** /api/v1.0/app/{appId}/address/form | Provides a dyamic form definition based for the country of the given appId, with labels localized using the provided language.
[**FormByCountry**](AddressApi.md#formbycountry) | **GET** /api/v1.0/address/country/{countryCode}/form | Provides a dyamic form definition for the given country code, with labels localized using the provided language.
[**FormatGoogleAddress**](AddressApi.md#formatgoogleaddress) | **POST** /api/v1.0/address/google | Maps a Google Address Object to the values of the dynamic form associated with the address country and returns the dynamic form.


<a name="formbyapp"></a>
# **FormByApp**
> RestApiResultAddressFormResponse FormByApp (string appId, string language = null)

Provides a dyamic form definition based for the country of the given appId, with labels localized using the provided language.

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
            var appId = appId_example;  // string | Application (WhiteLabel) Id (WhiteLabelId or AppNameId).
            var language = language_example;  // string | (Optional) ISO culture info code, e.g.: en-IE, the default is en-US. (optional) 

            try
            {
                // Provides a dyamic form definition based for the country of the given appId, with labels localized using the provided language.
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
 **appId** | **string**| Application (WhiteLabel) Id (WhiteLabelId or AppNameId). | 
 **language** | **string**| (Optional) ISO culture info code, e.g.: en-IE, the default is en-US. | [optional] 

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

Provides a dyamic form definition for the given country code, with labels localized using the provided language.

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
            var countryCode = countryCode_example;  // string | The 2 letter ISO country code, e.g.: IE.
            var language = language_example;  // string | (Optional) ISO culture info code, e.g.: en-IE, the default is en-US. (optional) 

            try
            {
                // Provides a dyamic form definition for the given country code, with labels localized using the provided language.
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
 **countryCode** | **string**| The 2 letter ISO country code, e.g.: IE. | 
 **language** | **string**| (Optional) ISO culture info code, e.g.: en-IE, the default is en-US. | [optional] 

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
> RestApiResultAddressFormResponse FormatGoogleAddress (GoogleAddress googleAddress)

Maps a Google Address Object to the values of the dynamic form associated with the address country and returns the dynamic form.

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
            var googleAddress = new GoogleAddress(); // GoogleAddress | A Google address object, as it is retuned from the maps API.

            try
            {
                // Maps a Google Address Object to the values of the dynamic form associated with the address country and returns the dynamic form.
                RestApiResultAddressFormResponse result = apiInstance.FormatGoogleAddress(googleAddress);
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
 **googleAddress** | [**GoogleAddress**](GoogleAddress.md)| A Google address object, as it is retuned from the maps API. | 

### Return type

[**RestApiResultAddressFormResponse**](RestApiResultAddressFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
