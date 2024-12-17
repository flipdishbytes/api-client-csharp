# Flipdish.Model.App
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **string** | App Identifier | [optional] 
**HasIosApp** | **bool?** | Has iOS app in Apple App Store. This is readonly. | [optional] 
**HasAndroidApp** | **bool?** | Has Android app in Google Play Store. This is readonly. | [optional] 
**LogoImageUrl** | **string** | Application Logo. | [optional] 
**Languages** | [**List&lt;Language&gt;**](Language.md) | Languages that have been selected to be available to customers. | [optional] 
**AvailableAppLanguages** | [**List&lt;Language&gt;**](Language.md) | Lists all languages that are supported by Flipdish. | [optional] 
**AppAccessLevel** | **string** | App access level for the logged in user | [optional] 
**AppResourceSet** | **List&lt;string&gt;** | Constitutes a list of available resources | [optional] 
**Features** | **List&lt;string&gt;** | Feature flags. These cannot be set by 3rd parties. | [optional] 
**MapCenter** | [**Coordinates**](Coordinates.md) | Center of the map coordinates. This is used to center the map when the iOS and Android app first open.  This value is automatically set based on the locations of the Stores in the App. | [optional] 
**MapNorthEast** | [**Coordinates**](Coordinates.md) | North East(Top Right) Corner of the map coordinates. This is used to frame the map when the iOS and Android app first open.  This value is automatically set based on the locations of the Stores in the App. | [optional] 
**MapSouthWest** | [**Coordinates**](Coordinates.md) | South West (Bottom Left) Corner of the map coordinates. This is used to frame the map when the iOS and Android app first open.  This value is automatically set based on the locations of the Stores in the App. | [optional] 
**GoogleMapsApiKeyWeb** | **string** | Key to be passed with Google Maps requests | [optional] 
**OrgId** | **string** | Org Id | [optional] 
**SmsRestaurantName** | **string** | SMS Restaurant Name | [optional] 
**Name** | **string** | App name.   This is used in various places on the Apple App Store, Google Play Store, mobile apps and websites. | [optional] 
**HostName** | **string** | HostName on which the web-ordering system is allowed to be hosted or that a Flipdish website is hosted on. | [optional] 
**MainColor** | **string** | Main color of the web / Android / iOS applications | [optional] 
**KioskPrimaryColour** | **string** | Primary colour used on the Kiosk | [optional] 
**ApplicationCategory** | **string** | Application Category | [optional] 
**IsPanaceaEnabled** | **bool?** | Panacea is the term used for websites that are hosted on the my.flipdish.com domain. This value is true when the App&#39;s website is hosted on this domain.  The alternative to using Panacea websites is to use a custom domain. | [optional] 
**PanaceaVanityUrl** | **string** | In case of IsPanaceaEnabled is true, the app can be accessed via https://my.flipdish.com/{PanaceaVanityUrl} | [optional] 
**CookieConsentPromptEnabled** | **bool?** | Cookie Consent Prompt Enabled | [optional] 
**CountryId** | **string** | Country identifier in ISO 3166-1 alpha-2 format.   This code is set automatically based on the locations of the Stores in the App.     The App Country is used    - to determine how to parse mobile phone numbers that are entered in their local numbering format   - to determine if country specific payment methods should be offered   - in various fraud checks | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

