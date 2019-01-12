/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// MenuItemOptionSetItemUpdatedEvent
    /// </summary>
    [DataContract]
    public partial class MenuItemOptionSetItemUpdatedEvent :  IEquatable<MenuItemOptionSetItemUpdatedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemOptionSetItemUpdatedEvent" /> class.
        /// </summary>
        /// <param name="menuId">Menu identifier.</param>
        /// <param name="description">Description.</param>
        /// <param name="user">User who has created the menu.</param>
        /// <param name="menuItemOptionSetItem">Updated menu item optionset item.</param>
        /// <param name="eventName">The event name.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        public MenuItemOptionSetItemUpdatedEvent(int? menuId = default(int?), string description = default(string), UserEventInfo user = default(UserEventInfo), MenuItemOptionSetItem menuItemOptionSetItem = default(MenuItemOptionSetItem), string eventName = default(string), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?))
        {
            this.MenuId = menuId;
            this.Description = description;
            this.User = user;
            this.MenuItemOptionSetItem = menuItemOptionSetItem;
            this.EventName = eventName;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
        }
        
        /// <summary>
        /// Menu identifier
        /// </summary>
        /// <value>Menu identifier</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// User who has created the menu
        /// </summary>
        /// <value>User who has created the menu</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// Updated menu item optionset item
        /// </summary>
        /// <value>Updated menu item optionset item</value>
        [DataMember(Name="MenuItemOptionSetItem", EmitDefaultValue=false)]
        public MenuItemOptionSetItem MenuItemOptionSetItem { get; set; }

        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The identitfier of the event
        /// </summary>
        /// <value>The identitfier of the event</value>
        [DataMember(Name="FlipdishEventId", EmitDefaultValue=false)]
        public Guid? FlipdishEventId { get; set; }

        /// <summary>
        /// The time of creation of the event
        /// </summary>
        /// <value>The time of creation of the event</value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        /// <value>Position</value>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuItemOptionSetItemUpdatedEvent {\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  MenuItemOptionSetItem: ").Append(MenuItemOptionSetItem).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MenuItemOptionSetItemUpdatedEvent);
        }

        /// <summary>
        /// Returns true if MenuItemOptionSetItemUpdatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuItemOptionSetItemUpdatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuItemOptionSetItemUpdatedEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.MenuItemOptionSetItem == input.MenuItemOptionSetItem ||
                    (this.MenuItemOptionSetItem != null &&
                    this.MenuItemOptionSetItem.Equals(input.MenuItemOptionSetItem))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.FlipdishEventId == input.FlipdishEventId ||
                    (this.FlipdishEventId != null &&
                    this.FlipdishEventId.Equals(input.FlipdishEventId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.MenuItemOptionSetItem != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetItem.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
