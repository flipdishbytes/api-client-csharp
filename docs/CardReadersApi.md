# Flipdish.Api.CardReadersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizeStripeTerminal**](CardReadersApi.md#authorizestripeterminal) | **POST** /api/v1.0/{appId}/stripeterminal/authorize | Get Authorization Key for Stripe Terminal
[**CancelCurrentlyInitiatedBluetoothDeviceUpdate**](CardReadersApi.md#cancelcurrentlyinitiatedbluetoothdeviceupdate) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/cancelUpdate | Cancel currently initiated install update for bluetooth terminal
[**GetBluetoothTerminalStatus**](CardReadersApi.md#getbluetoothterminalstatus) | **GET** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/status | Get the status of the bluetooth terminal
[**InitiateBluetoothTerminalDeviceUpdateCheck**](CardReadersApi.md#initiatebluetoothterminaldeviceupdatecheck) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/checkForUpdate | Trigger check for Bluetooth device update on Kiosk
[**InitiateKioskBluetoothPairingMode**](CardReadersApi.md#initiatekioskbluetoothpairingmode) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/pair | Initiate stripe terminal pairing mode
[**InitiateKioskBluetoothUpdateInstall**](CardReadersApi.md#initiatekioskbluetoothupdateinstall) | **POST** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/{terminalType}/installUpdate | Initiate Kiosk Update Install for bluetooth terminal
[**UnpairCurrentlyPairedBluetoothDevice**](CardReadersApi.md#unpaircurrentlypairedbluetoothdevice) | **DELETE** /api/v1.0/{appId}/cardreaders/kiosk/{deviceId}/bluetooth/unpair | Unpair the currently paired stripe terminal


<a name="authorizestripeterminal"></a>
# **AuthorizeStripeTerminal**
> RestApiResultStripeTerminalPrivateKey AuthorizeStripeTerminal (string appId)

Get Authorization Key for Stripe Terminal

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
    public class AuthorizeStripeTerminalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CardReadersApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get Authorization Key for Stripe Terminal
                RestApiResultStripeTerminalPrivateKey result = apiInstance.AuthorizeStripeTerminal(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardReadersApi.AuthorizeStripeTerminal: " + e.Message );
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

[**RestApiResultStripeTerminalPrivateKey**](RestApiResultStripeTerminalPrivateKey.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
