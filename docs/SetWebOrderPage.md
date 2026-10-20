# Flipdish.Model.SetWebOrderPage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderPagePath** | **string** | Path of the page on the app&#39;s hostname. Must be empty, or start with / and have no query string or fragment.  Required with Mode Manual (the default). An empty string clears the path: there is no ordering page to link to, and live orders will not fill it.  With Mode Automatic, omit it or leave it empty: the path is blanked and filled from the next live web order. | [optional] 
**Mode** | **string** | Manual (the default) stores OrderPagePath and stops live orders changing it.  Automatic blanks the path so the next live web order on the app&#39;s hostname fills it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

