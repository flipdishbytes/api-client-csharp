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
    /// MenuUpdatedEvent
    /// </summary>
    [DataContract]
    public partial class MenuUpdatedEvent :  IEquatable<MenuUpdatedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuUpdatedEvent" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="User">User.</param>
        /// <param name="Menu">Menu.</param>
        /// <param name="EventName">EventName.</param>
        /// <param name="FlipdishEventId">FlipdishEventId.</param>
        /// <param name="CreateTime">CreateTime.</param>
        /// <param name="Position">Position.</param>
        public MenuUpdatedEvent(string Description = default(string), UserEventInfo User = default(UserEventInfo), Menu Menu = default(Menu), string EventName = default(string), Guid? FlipdishEventId = default(Guid?), DateTime? CreateTime = default(DateTime?), int? Position = default(int?))
        {
            this.Description = Description;
            this.User = User;
            this.Menu = Menu;
            this.EventName = EventName;
            this.FlipdishEventId = FlipdishEventId;
            this.CreateTime = CreateTime;
            this.Position = Position;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// Gets or Sets Menu
        /// </summary>
        [DataMember(Name="menu", EmitDefaultValue=false)]
        public Menu Menu { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets FlipdishEventId
        /// </summary>
        [DataMember(Name="flipdishEventId", EmitDefaultValue=false)]
        public Guid? FlipdishEventId { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuUpdatedEvent {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Menu: ").Append(Menu).Append("\n");
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
        public string ToJson()
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
            return this.Equals(input as MenuUpdatedEvent);
        }

        /// <summary>
        /// Returns true if MenuUpdatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuUpdatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuUpdatedEvent input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Menu == input.Menu ||
                    (this.Menu != null &&
                    this.Menu.Equals(input.Menu))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Menu != null)
                    hashCode = hashCode * 59 + this.Menu.GetHashCode();
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
