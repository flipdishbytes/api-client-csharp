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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Store Unpublished Event
    /// </summary>
    [DataContract]
    public partial class StoreUnpublishedEvent :  IEquatable<StoreUnpublishedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreUnpublishedEvent" /> class.
        /// </summary>
        /// <param name="eventName">The event name.</param>
        /// <param name="storeId">Store Id.</param>
        /// <param name="user">User which unpublished this store.</param>
        /// <param name="description">Description.</param>
        /// <param name="store">Unpublished Store.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        /// <param name="appId">App id.</param>
        public StoreUnpublishedEvent(string eventName = default(string), int? storeId = default(int?), UserEventInfo user = default(UserEventInfo), string description = default(string), Store store = default(Store), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?), string appId = default(string))
        {
            this.EventName = eventName;
            this.StoreId = storeId;
            this.User = user;
            this.Description = description;
            this.Store = store;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
            this.AppId = appId;
        }
        
        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Store Id
        /// </summary>
        /// <value>Store Id</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Store group Id
        /// </summary>
        /// <value>Store group Id</value>
        [DataMember(Name="StoreGroupId", EmitDefaultValue=false)]
        public int? StoreGroupId { get; private set; }

        /// <summary>
        /// User which unpublished this store
        /// </summary>
        /// <value>User which unpublished this store</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unpublished Store
        /// </summary>
        /// <value>Unpublished Store</value>
        [DataMember(Name="Store", EmitDefaultValue=false)]
        public Store Store { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreUnpublishedEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreGroupId: ").Append(StoreGroupId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
            return this.Equals(input as StoreUnpublishedEvent);
        }

        /// <summary>
        /// Returns true if StoreUnpublishedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreUnpublishedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreUnpublishedEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.StoreGroupId == input.StoreGroupId ||
                    (this.StoreGroupId != null &&
                    this.StoreGroupId.Equals(input.StoreGroupId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.StoreGroupId != null)
                    hashCode = hashCode * 59 + this.StoreGroupId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
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
