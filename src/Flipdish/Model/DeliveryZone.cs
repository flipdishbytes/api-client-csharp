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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// Delivery Zone
    /// </summary>
    [DataContract]
    public partial class DeliveryZone :  IEquatable<DeliveryZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryZone" /> class.
        /// </summary>
        /// <param name="id">Delivery Fee Area Id.</param>
        /// <param name="feeChargedToStore">Delivery Fee charged to store.</param>
        /// <param name="deliveryFee">Delivery fee (will not be set below 0).</param>
        /// <param name="minimumDeliveryOrderAmount">Minimum delivery order amount (will not be set below 0).</param>
        /// <param name="wellKnownText">Spatial data in Well Known Text format  We also support CIRCLE((0 0, 200)) - (centerLong centerLat, radius in m).</param>
        /// <param name="isEnabled">Is delivery zone enabled.</param>
        public DeliveryZone(int? id = default(int?), double? feeChargedToStore = default(double?), double? deliveryFee = default(double?), double? minimumDeliveryOrderAmount = default(double?), string wellKnownText = default(string), bool? isEnabled = default(bool?))
        {
            this.Id = id;
            this.FeeChargedToStore = feeChargedToStore;
            this.DeliveryFee = deliveryFee;
            this.MinimumDeliveryOrderAmount = minimumDeliveryOrderAmount;
            this.WellKnownText = wellKnownText;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Delivery Fee Area Id
        /// </summary>
        /// <value>Delivery Fee Area Id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Delivery Fee charged to store
        /// </summary>
        /// <value>Delivery Fee charged to store</value>
        [DataMember(Name="FeeChargedToStore", EmitDefaultValue=false)]
        public double? FeeChargedToStore { get; set; }

        /// <summary>
        /// Delivery fee (will not be set below 0)
        /// </summary>
        /// <value>Delivery fee (will not be set below 0)</value>
        [DataMember(Name="DeliveryFee", EmitDefaultValue=false)]
        public double? DeliveryFee { get; set; }

        /// <summary>
        /// Minimum delivery order amount (will not be set below 0)
        /// </summary>
        /// <value>Minimum delivery order amount (will not be set below 0)</value>
        [DataMember(Name="MinimumDeliveryOrderAmount", EmitDefaultValue=false)]
        public double? MinimumDeliveryOrderAmount { get; set; }

        /// <summary>
        /// Spatial data in Well Known Text format  We also support CIRCLE((0 0, 200)) - (centerLong centerLat, radius in m)
        /// </summary>
        /// <value>Spatial data in Well Known Text format  We also support CIRCLE((0 0, 200)) - (centerLong centerLat, radius in m)</value>
        [DataMember(Name="WellKnownText", EmitDefaultValue=false)]
        public string WellKnownText { get; set; }

        /// <summary>
        /// Is delivery zone enabled
        /// </summary>
        /// <value>Is delivery zone enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryZone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FeeChargedToStore: ").Append(FeeChargedToStore).Append("\n");
            sb.Append("  DeliveryFee: ").Append(DeliveryFee).Append("\n");
            sb.Append("  MinimumDeliveryOrderAmount: ").Append(MinimumDeliveryOrderAmount).Append("\n");
            sb.Append("  WellKnownText: ").Append(WellKnownText).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            return this.Equals(input as DeliveryZone);
        }

        /// <summary>
        /// Returns true if DeliveryZone instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FeeChargedToStore == input.FeeChargedToStore ||
                    (this.FeeChargedToStore != null &&
                    this.FeeChargedToStore.Equals(input.FeeChargedToStore))
                ) && 
                (
                    this.DeliveryFee == input.DeliveryFee ||
                    (this.DeliveryFee != null &&
                    this.DeliveryFee.Equals(input.DeliveryFee))
                ) && 
                (
                    this.MinimumDeliveryOrderAmount == input.MinimumDeliveryOrderAmount ||
                    (this.MinimumDeliveryOrderAmount != null &&
                    this.MinimumDeliveryOrderAmount.Equals(input.MinimumDeliveryOrderAmount))
                ) && 
                (
                    this.WellKnownText == input.WellKnownText ||
                    (this.WellKnownText != null &&
                    this.WellKnownText.Equals(input.WellKnownText))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FeeChargedToStore != null)
                    hashCode = hashCode * 59 + this.FeeChargedToStore.GetHashCode();
                if (this.DeliveryFee != null)
                    hashCode = hashCode * 59 + this.DeliveryFee.GetHashCode();
                if (this.MinimumDeliveryOrderAmount != null)
                    hashCode = hashCode * 59 + this.MinimumDeliveryOrderAmount.GetHashCode();
                if (this.WellKnownText != null)
                    hashCode = hashCode * 59 + this.WellKnownText.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
