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
    /// Represents one store&#39;s order capacity configuration
    /// </summary>
    [DataContract]
    public partial class StoreOrderCapacityConfig :  IEquatable<StoreOrderCapacityConfig>, IValidatableObject
    {
        /// <summary>
        /// Signifies whether the order capacity configuration is for Delivery / Pickup
        /// </summary>
        /// <value>Signifies whether the order capacity configuration is for Delivery / Pickup</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTypeEnum
        {
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 1,
            
            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 2
        }

        /// <summary>
        /// Signifies whether the order capacity configuration is for Delivery / Pickup
        /// </summary>
        /// <value>Signifies whether the order capacity configuration is for Delivery / Pickup</value>
        [DataMember(Name="DeliveryType", EmitDefaultValue=false)]
        public DeliveryTypeEnum? DeliveryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderCapacityConfig" /> class.
        /// </summary>
        /// <param name="storeId">Store identifier.</param>
        /// <param name="deliveryType">Signifies whether the order capacity configuration is for Delivery / Pickup.</param>
        /// <param name="storeIntervalInMinutes">Store Interval - time between orders, e.g. 10 minutes between each order time available to customer.</param>
        /// <param name="orderCapacityPeriods">Order capacity periods.</param>
        public StoreOrderCapacityConfig(int? storeId = default(int?), DeliveryTypeEnum? deliveryType = default(DeliveryTypeEnum?), int? storeIntervalInMinutes = default(int?), List<StoreOrderCapacityPeriod> orderCapacityPeriods = default(List<StoreOrderCapacityPeriod>))
        {
            this.StoreId = storeId;
            this.DeliveryType = deliveryType;
            this.StoreIntervalInMinutes = storeIntervalInMinutes;
            this.OrderCapacityPeriods = orderCapacityPeriods;
        }
        
        /// <summary>
        /// Store identifier
        /// </summary>
        /// <value>Store identifier</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }


        /// <summary>
        /// Store Interval - time between orders, e.g. 10 minutes between each order time available to customer
        /// </summary>
        /// <value>Store Interval - time between orders, e.g. 10 minutes between each order time available to customer</value>
        [DataMember(Name="StoreIntervalInMinutes", EmitDefaultValue=false)]
        public int? StoreIntervalInMinutes { get; set; }

        /// <summary>
        /// Order capacity periods
        /// </summary>
        /// <value>Order capacity periods</value>
        [DataMember(Name="OrderCapacityPeriods", EmitDefaultValue=false)]
        public List<StoreOrderCapacityPeriod> OrderCapacityPeriods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreOrderCapacityConfig {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  StoreIntervalInMinutes: ").Append(StoreIntervalInMinutes).Append("\n");
            sb.Append("  OrderCapacityPeriods: ").Append(OrderCapacityPeriods).Append("\n");
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
            return this.Equals(input as StoreOrderCapacityConfig);
        }

        /// <summary>
        /// Returns true if StoreOrderCapacityConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreOrderCapacityConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreOrderCapacityConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
                ) && 
                (
                    this.StoreIntervalInMinutes == input.StoreIntervalInMinutes ||
                    (this.StoreIntervalInMinutes != null &&
                    this.StoreIntervalInMinutes.Equals(input.StoreIntervalInMinutes))
                ) && 
                (
                    this.OrderCapacityPeriods == input.OrderCapacityPeriods ||
                    this.OrderCapacityPeriods != null &&
                    this.OrderCapacityPeriods.SequenceEqual(input.OrderCapacityPeriods)
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.DeliveryType != null)
                    hashCode = hashCode * 59 + this.DeliveryType.GetHashCode();
                if (this.StoreIntervalInMinutes != null)
                    hashCode = hashCode * 59 + this.StoreIntervalInMinutes.GetHashCode();
                if (this.OrderCapacityPeriods != null)
                    hashCode = hashCode * 59 + this.OrderCapacityPeriods.GetHashCode();
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