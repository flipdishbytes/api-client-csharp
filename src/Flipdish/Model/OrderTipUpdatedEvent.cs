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
    /// OrderTipUpdatedEvent
    /// </summary>
    [DataContract]
    public partial class OrderTipUpdatedEvent :  IEquatable<OrderTipUpdatedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTipUpdatedEvent" /> class.
        /// </summary>
        /// <param name="NewTipAmount">NewTipAmount.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Order">Order.</param>
        /// <param name="EventName">EventName.</param>
        /// <param name="FlipdishEventId">FlipdishEventId.</param>
        /// <param name="CreateTime">CreateTime.</param>
        /// <param name="Details">Details.</param>
        /// <param name="Position">Position.</param>
        public OrderTipUpdatedEvent(double? NewTipAmount = default(double?), string Description = default(string), Order Order = default(Order), string EventName = default(string), Guid? FlipdishEventId = default(Guid?), DateTime? CreateTime = default(DateTime?), string Details = default(string), int? Position = default(int?))
        {
            this.NewTipAmount = NewTipAmount;
            this.Description = Description;
            this.Order = Order;
            this.EventName = EventName;
            this.FlipdishEventId = FlipdishEventId;
            this.CreateTime = CreateTime;
            this.Details = Details;
            this.Position = Position;
        }
        
        /// <summary>
        /// Gets or Sets NewTipAmount
        /// </summary>
        [DataMember(Name="newTipAmount", EmitDefaultValue=false)]
        public double? NewTipAmount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }

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
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

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
            sb.Append("class OrderTipUpdatedEvent {\n");
            sb.Append("  NewTipAmount: ").Append(NewTipAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as OrderTipUpdatedEvent);
        }

        /// <summary>
        /// Returns true if OrderTipUpdatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderTipUpdatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderTipUpdatedEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewTipAmount == input.NewTipAmount ||
                    (this.NewTipAmount != null &&
                    this.NewTipAmount.Equals(input.NewTipAmount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.NewTipAmount != null)
                    hashCode = hashCode * 59 + this.NewTipAmount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
