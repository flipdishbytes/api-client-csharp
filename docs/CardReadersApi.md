# Flipdish.Api.CardReadersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelCurrentlyInitiatedBluetoothDeviceUpdate**](CardReadersApi.md#cancelcurrentlyinitiatedbluetoothdeviceupdate) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/cancelUpdate | 
[**CancelReaderAction**](CardReadersApi.md#cancelreaderaction) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/{readerId}/cancel_action | 
[**CardReadersGetReader**](CardReadersApi.md#cardreadersgetreader) | **GET** /api/v1.0/{appId}/payments/terminals/stripe/{readerId} | 
[**GenerateStripeTerminalLocation**](CardReadersApi.md#generatestripeterminallocation) | **POST** /api/v1.0/{appId}/stripeterminal/location | 
[**GetBluetoothTerminalStatus**](CardReadersApi.md#getbluetoothterminalstatus) | **GET** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/status | 
[**GetStripeConnectionToken**](CardReadersApi.md#getstripeconnectiontoken) | **GET** /api/v1.0/{appId}/stripeterminal/connectiontoken | 
[**InitiateBluetoothTerminalDeviceUpdateCheck**](CardReadersApi.md#initiatebluetoothterminaldeviceupdatecheck) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/checkForUpdate | 
[**InitiateKioskBluetoothPairingMode**](CardReadersApi.md#initiatekioskbluetoothpairingmode) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/pair | 
[**InitiateKioskBluetoothUpdateInstall**](CardReadersApi.md#initiatekioskbluetoothupdateinstall) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/installUpdate | 
[**InitiateReaderProcessPaymentIntent**](CardReadersApi.md#initiatereaderprocesspaymentintent) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/{readerId}/processPaymentIntent | 
[**RegisterStripeTerminal**](CardReadersApi.md#registerstripeterminal) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/register | 
[**UnRegisterTerminal**](CardReadersApi.md#unregisterterminal) | **DELETE** /api/v1.0/{appId}/payments/terminals/stripe/unregister | 
[**UnpairCurrentlyPairedBluetoothDevice**](CardReadersApi.md#unpaircurrentlypairedbluetoothdevice) | **DELETE** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/unpair | 


<a name="cancelcurrentlyinitiatedbluetoothdeviceupdate"></a>
# **CancelCurrentlyInitiatedBluetoothDeviceUpdate**
> void CancelCurrentlyInitiatedBluetoothDeviceUpdate (string appId, string deviceId, string terminalType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CancelCurrentlyInitiatedBluetoothDeviceUpdateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var terminalType = terminalType_example;  // string | 

            try
            {
                apiInstance.CancelCurrentlyInitiatedBluetoothDeviceUpdate(appId, deviceId, terminalType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.CancelCurrentlyInitiatedBluetoothDeviceUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **terminalType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelreaderaction"></a>
# **CancelReaderAction**
> RestApiResultCardReader CancelReaderAction (string readerId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CancelReaderActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var readerId = readerId_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCardReader result = apiInstance.CancelReaderAction(readerId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.CancelReaderAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **readerId** | **string**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCardReader**](RestApiResultCardReader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cardreadersgetreader"></a>
# **CardReadersGetReader**
> RestApiResultCardReader CardReadersGetReader (string readerId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CardReadersGetReaderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var readerId = readerId_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCardReader result = apiInstance.CardReadersGetReader(readerId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.CardReadersGetReader: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **readerId** | **string**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCardReader**](RestApiResultCardReader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatestripeterminallocation"></a>
# **GenerateStripeTerminalLocation**
> RestApiResultStripeTerminalLocation GenerateStripeTerminalLocation (GeoPointRequest geoPointRequest, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GenerateStripeTerminalLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var geoPointRequest = new GeoPointRequest(); // GeoPointRequest | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultStripeTerminalLocation result = apiInstance.GenerateStripeTerminalLocation(geoPointRequest, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.GenerateStripeTerminalLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geoPointRequest** | [**GeoPointRequest**](GeoPointRequest.md)|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultStripeTerminalLocation**](RestApiResultStripeTerminalLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbluetoothterminalstatus"></a>
# **GetBluetoothTerminalStatus**
> RestApiResultBluetoothTerminalStatus GetBluetoothTerminalStatus (string appId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBluetoothTerminalStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiResultBluetoothTerminalStatus result = apiInstance.GetBluetoothTerminalStatus(appId, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.GetBluetoothTerminalStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiResultBluetoothTerminalStatus**](RestApiResultBluetoothTerminalStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstripeconnectiontoken"></a>
# **GetStripeConnectionToken**
> RestApiResultStripeTerminalConnectionToken GetStripeConnectionToken (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStripeConnectionTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultStripeTerminalConnectionToken result = apiInstance.GetStripeConnectionToken(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.GetStripeConnectionToken: " + e.Message );
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

[**RestApiResultStripeTerminalConnectionToken**](RestApiResultStripeTerminalConnectionToken.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatebluetoothterminaldeviceupdatecheck"></a>
# **InitiateBluetoothTerminalDeviceUpdateCheck**
> void InitiateBluetoothTerminalDeviceUpdateCheck (string appId, string deviceId, string terminalType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InitiateBluetoothTerminalDeviceUpdateCheckExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var terminalType = terminalType_example;  // string | 

            try
            {
                apiInstance.InitiateBluetoothTerminalDeviceUpdateCheck(appId, deviceId, terminalType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.InitiateBluetoothTerminalDeviceUpdateCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **terminalType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatekioskbluetoothpairingmode"></a>
# **InitiateKioskBluetoothPairingMode**
> void InitiateKioskBluetoothPairingMode (string appId, string deviceId, string terminalType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InitiateKioskBluetoothPairingModeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var terminalType = terminalType_example;  // string | 

            try
            {
                apiInstance.InitiateKioskBluetoothPairingMode(appId, deviceId, terminalType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.InitiateKioskBluetoothPairingMode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **terminalType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatekioskbluetoothupdateinstall"></a>
# **InitiateKioskBluetoothUpdateInstall**
> void InitiateKioskBluetoothUpdateInstall (string appId, string deviceId, string terminalType)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InitiateKioskBluetoothUpdateInstallExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var terminalType = terminalType_example;  // string | 

            try
            {
                apiInstance.InitiateKioskBluetoothUpdateInstall(appId, deviceId, terminalType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.InitiateKioskBluetoothUpdateInstall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **terminalType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatereaderprocesspaymentintent"></a>
# **InitiateReaderProcessPaymentIntent**
> RestApiResultCardReader InitiateReaderProcessPaymentIntent (ProcessPaymentIntentRequest request, string readerId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InitiateReaderProcessPaymentIntentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var request = new ProcessPaymentIntentRequest(); // ProcessPaymentIntentRequest | 
            var readerId = readerId_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCardReader result = apiInstance.InitiateReaderProcessPaymentIntent(request, readerId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.InitiateReaderProcessPaymentIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ProcessPaymentIntentRequest**](ProcessPaymentIntentRequest.md)|  | 
 **readerId** | **string**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCardReader**](RestApiResultCardReader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerstripeterminal"></a>
# **RegisterStripeTerminal**
> RestApiResultCardReader RegisterStripeTerminal (CardReaderRegistrationRequest request, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RegisterStripeTerminalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var request = new CardReaderRegistrationRequest(); // CardReaderRegistrationRequest | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCardReader result = apiInstance.RegisterStripeTerminal(request, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.RegisterStripeTerminal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CardReaderRegistrationRequest**](CardReaderRegistrationRequest.md)|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCardReader**](RestApiResultCardReader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterterminal"></a>
# **UnRegisterTerminal**
> RestApiResultCardReader UnRegisterTerminal (UnRegisterCardReaderRequest request, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnRegisterTerminalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var request = new UnRegisterCardReaderRequest(); // UnRegisterCardReaderRequest | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCardReader result = apiInstance.UnRegisterTerminal(request, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.UnRegisterTerminal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UnRegisterCardReaderRequest**](UnRegisterCardReaderRequest.md)|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCardReader**](RestApiResultCardReader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unpaircurrentlypairedbluetoothdevice"></a>
# **UnpairCurrentlyPairedBluetoothDevice**
> void UnpairCurrentlyPairedBluetoothDevice (string appId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnpairCurrentlyPairedBluetoothDeviceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                apiInstance.UnpairCurrentlyPairedBluetoothDevice(appId, deviceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.UnpairCurrentlyPairedBluetoothDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

