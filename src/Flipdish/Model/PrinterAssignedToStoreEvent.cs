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
    /// Printer assigned to store event
    /// </summary>
    [DataContract]
    public partial class PrinterAssignedToStoreEvent :  IEquatable<PrinterAssignedToStoreEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterAssignedToStoreEvent" /> class.
        /// </summary>
        /// <param name="EventName">The event name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="StoreId">Store Id.</param>
        /// <param name="User">Info User.</param>
        /// <param name="Printer">The printer.</param>
        /// <param name="FlipdishEventId">The identitfier of the event.</param>
        /// <param name="CreateTime">The time of creation of the event.</param>
        /// <param name="Position">Position.</param>
        public PrinterAssignedToStoreEvent(string EventName = default(string), string Description = default(string), int? StoreId = default(int?), UserEventInfo User = default(UserEventInfo), Printer Printer = default(Printer), Guid? FlipdishEventId = default(Guid?), DateTime? CreateTime = default(DateTime?), int? Position = default(int?))
        {
            this.EventName = EventName;
            this.Description = Description;
            this.StoreId = StoreId;
            this.User = User;
            this.Printer = Printer;
            this.FlipdishEventId = FlipdishEventId;
            this.CreateTime = CreateTime;
            this.Position = Position;
        }
        
        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Store Id
        /// </summary>
        /// <value>Store Id</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Info User
        /// </summary>
        /// <value>Info User</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// The printer
        /// </summary>
        /// <value>The printer</value>
        [DataMember(Name="Printer", EmitDefaultValue=false)]
        public Printer Printer { get; set; }

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
            sb.Append("class PrinterAssignedToStoreEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Printer: ").Append(Printer).Append("\n");
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
            return this.Equals(input as PrinterAssignedToStoreEvent);
        }

        /// <summary>
        /// Returns true if PrinterAssignedToStoreEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PrinterAssignedToStoreEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterAssignedToStoreEvent input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Printer == input.Printer ||
                    (this.Printer != null &&
                    this.Printer.Equals(input.Printer))
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Printer != null)
                    hashCode = hashCode * 59 + this.Printer.GetHashCode();
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
