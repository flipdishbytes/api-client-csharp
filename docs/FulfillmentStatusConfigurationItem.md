# Flipdish.Model.FulfillmentStatusConfigurationItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusId** | **string** | Status Id (no whitespaces) | [optional] 
**StatusName** | **string** | Status name | [optional] 
**Enabled** | **bool?** | Is status enabled | [optional] 
**DisplayName** | **string** | The short status string that is displayed to users in apps, portal. If empty then Order Status Name is displayed instead | [optional] 
**Icon** | **string** | Icon/Image that represents that status visual | [optional] 
**PublicDescription** | **string** | A string which could be used in notification templates with a placeholder (SMS, email, push, web page with status) | [optional] 
**Internal** | **bool?** | Is internal state (internal states not shown to customers) | [optional] 
**NextStatuses** | **List&lt;string&gt;** | list of statuses that this status can move to (can be back or forth) | [optional] 
**DefaultNextStatus** | [**List&lt;NextStatusWithOrderType&gt;**](NextStatusWithOrderType.md) | The default next status (on a dropdown or quick button on terminal or portal) | [optional] 
**ChangeType** | **string** | How will state change (manually or automated, including timed) | [optional] 
**IncludeInReports** | **bool?** | Include in reports | [optional] 
**IsCustom** | **bool?** | Is custom state. If not, then it&#39;s a system state | [optional] 
**OrderTypes** | **List&lt;string&gt;** | If empty then applies to all ordertypes, otherwise a list of order types this state applies to | [optional] 
**Communication** | **bool?** | Whether state should fire off a notification to the customer | [optional] 
**VisualOrder** | **int?** | Integer for ordering results in choices (eg. dropdowns) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

