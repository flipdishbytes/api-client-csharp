# Flipdish.Api.CardReadersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelCurrentlyInitiatedBluetoothDeviceUpdate**](CardReadersApi.md#cancelcurrentlyinitiatedbluetoothdeviceupdate) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/cancelUpdate | Cancel currently initiated install update for bluetooth terminal
[**CancelReaderAction**](CardReadersApi.md#cancelreaderaction) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/{readerId}/cancel_action | Cancel terminals action
[**CardReadersGetReader**](CardReadersApi.md#cardreadersgetreader) | **GET** /api/v1.0/{appId}/payments/terminals/stripe/{readerId} | Get reader
[**GenerateStripeTerminalLocation**](CardReadersApi.md#generatestripeterminallocation) | **POST** /api/v1.0/{appId}/stripeterminal/location | Get Location ID for Stripe Terminal
[**GetBluetoothTerminalStatus**](CardReadersApi.md#getbluetoothterminalstatus) | **GET** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/status | Get the status of the bluetooth terminal
[**GetStripeConnectionToken**](CardReadersApi.md#getstripeconnectiontoken) | **GET** /api/v1.0/{appId}/stripeterminal/connectiontoken | Get Connection Token For a Stripe Terminal
[**InitiateBluetoothTerminalDeviceUpdateCheck**](CardReadersApi.md#initiatebluetoothterminaldeviceupdatecheck) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/checkForUpdate | Trigger check for Bluetooth device update on Kiosk
[**InitiateKioskBluetoothPairingMode**](CardReadersApi.md#initiatekioskbluetoothpairingmode) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/pair | Initiate stripe terminal pairing mode
[**InitiateKioskBluetoothUpdateInstall**](CardReadersApi.md#initiatekioskbluetoothupdateinstall) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/installUpdate | Initiate Kiosk Update Install for bluetooth terminal
[**InitiateReaderProcessPaymentIntent**](CardReadersApi.md#initiatereaderprocesspaymentintent) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/{readerId}/processPaymentIntent | Initiate Stripe terminal to Process Payment Intent
[**RegisterStripeTerminal**](CardReadersApi.md#registerstripeterminal) | **POST** /api/v1.0/{appId}/payments/terminals/stripe/register | 
[**UnRegisterTerminal**](CardReadersApi.md#unregisterterminal) | **DELETE** /api/v1.0/{appId}/payments/terminals/stripe/unregister | Un-register terminal by deleting it from stripe
[**UnpairCurrentlyPairedBluetoothDevice**](CardReadersApi.md#unpaircurrentlypairedbluetoothdevice) | **DELETE** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/unpair | Unpair the currently paired stripe terminal


<a name="cancelcurrentlyinitiatedbluetoothdeviceupdate"></a>
# **CancelCurrentlyInitiatedBluetoothDeviceUpdate**
> void CancelCurrentlyInitiatedBluetoothDeviceUpdate (string appId, string deviceId, string terminalType)

Cancel currently initiated install update for bluetooth terminal

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
                // Cancel currently initiated install update for bluetooth terminal
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

Cancel terminals action

Can only be called by Kiosk

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
                // Cancel terminals action
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

Get reader

Can only be called by Kiosk

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
                // Get reader
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

Get Location ID for Stripe Terminal

Can only be called by Kiosk  [BETA - this endpoint is under development, do not use it in your production system]

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
                // Get Location ID for Stripe Terminal
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

Get the status of the bluetooth terminal

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
                // Get the status of the bluetooth terminal
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

Get Connection Token For a Stripe Terminal

Can only be called by Kiosk

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
                // Get Connection Token For a Stripe Terminal
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

Trigger check for Bluetooth device update on Kiosk

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
                // Trigger check for Bluetooth device update on Kiosk
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

Initiate stripe terminal pairing mode

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
                // Initiate stripe terminal pairing mode
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

Initiate Kiosk Update Install for bluetooth terminal

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
                // Initiate Kiosk Update Install for bluetooth terminal
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

Initiate Stripe terminal to Process Payment Intent

Can only be called by Kiosk  [BETA - this endpoint is under development, do not use it in your production system]

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
                // Initiate Stripe terminal to Process Payment Intent
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

Un-register terminal by deleting it from stripe

Can only be called by Kiosk

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
                // Un-register terminal by deleting it from stripe
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

Unpair the currently paired stripe terminal

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
                // Unpair the currently paired stripe terminal
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

