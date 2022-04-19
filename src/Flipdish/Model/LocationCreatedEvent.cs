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
    /// Event for logging the creating of Locations
    /// </summary>
    [DataContract]
    public partial class LocationCreatedEvent :  IEquatable<LocationCreatedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationCreatedEvent" /> class.
        /// </summary>
        /// <param name="locationId">Location Location Id.</param>
        /// <param name="locationName">Location LocationName.</param>
        /// <param name="displayOrder">Location DisplayOrder.</param>
        /// <param name="externalLocationId">Location ExternalLocationId.</param>
        /// <param name="locationAreaId">Location LocationAreaId.</param>
        /// <param name="eventName">The event name.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        /// <param name="appId">App id.</param>
        /// <param name="ipAddress">Ip Address.</param>
        public LocationCreatedEvent(int? locationId = default(int?), string locationName = default(string), int? displayOrder = default(int?), string externalLocationId = default(string), int? locationAreaId = default(int?), string eventName = default(string), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?), string appId = default(string), string ipAddress = default(string))
        {
            this.LocationId = locationId;
            this.LocationName = locationName;
            this.DisplayOrder = displayOrder;
            this.ExternalLocationId = externalLocationId;
            this.LocationAreaId = locationAreaId;
            this.EventName = eventName;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
            this.AppId = appId;
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// Location Location Id
        /// </summary>
        /// <value>Location Location Id</value>
        [DataMember(Name="LocationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Location LocationName
        /// </summary>
        /// <value>Location LocationName</value>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Location DisplayOrder
        /// </summary>
        /// <value>Location DisplayOrder</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Location ExternalLocationId
        /// </summary>
        /// <value>Location ExternalLocationId</value>
        [DataMember(Name="ExternalLocationId", EmitDefaultValue=false)]
        public string ExternalLocationId { get; set; }

        /// <summary>
        /// Location LocationAreaId
        /// </summary>
        /// <value>Location LocationAreaId</value>
        [DataMember(Name="LocationAreaId", EmitDefaultValue=false)]
        public int? LocationAreaId { get; set; }

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
        /// App id
        /// </summary>
        /// <value>App id</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Ip Address
        /// </summary>
        /// <value>Ip Address</value>
        [DataMember(Name="IpAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationCreatedEvent {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  ExternalLocationId: ").Append(ExternalLocationId).Append("\n");
            sb.Append("  LocationAreaId: ").Append(LocationAreaId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
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
            return this.Equals(input as LocationCreatedEvent);
        }

        /// <summary>
        /// Returns true if LocationCreatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationCreatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationCreatedEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.ExternalLocationId == input.ExternalLocationId ||
                    (this.ExternalLocationId != null &&
                    this.ExternalLocationId.Equals(input.ExternalLocationId))
                ) && 
                (
                    this.LocationAreaId == input.LocationAreaId ||
                    (this.LocationAreaId != null &&
                    this.LocationAreaId.Equals(input.LocationAreaId))
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
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.ExternalLocationId != null)
                    hashCode = hashCode * 59 + this.ExternalLocationId.GetHashCode();
                if (this.LocationAreaId != null)
                    hashCode = hashCode * 59 + this.LocationAreaId.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
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
