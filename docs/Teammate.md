# Flipdish.Model.Teammate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeammateId** | **string** | Unique indentifier | [optional] 
**UserId** | **int?** | User ID of the teammate | [optional] 
**Name** | **string** | Name | [optional] 
**LastActivity** | **DateTime?** | Last activity | [optional] 
**AppId** | **string** | Access level is for this App | [optional] 
**InvitationStatus** | **string** | Invitation status | [optional] 
**Email** | **string** | Email address | [optional] 
**AppAccessLevel** | **string** | App access level | [optional] 
**HasAccessToAllStores** | **bool?** | The user has access to all stores for the app (including new stores that added later) | [optional] 
**StoreIds** | **List&lt;int?&gt;** | Store IDs the user has access to (if HasAccessToAllStores is false) | [optional] 
**PropertyIds** | **List&lt;string&gt;** | Property Ids the user has access to (if HasAccessToAllStores is false) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

