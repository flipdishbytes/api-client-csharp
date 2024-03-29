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
    /// Breakdown of third party integration fees
    /// </summary>
    [DataContract]
    public partial class ThirdPartyFeesDetails :  IEquatable<ThirdPartyFeesDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyFeesDetails" /> class.
        /// </summary>
        /// <param name="deliveryIntegrationFee">Third party integration delivery fee.</param>
        /// <param name="deliveryTipFee">Third party integration delivery tip fee.</param>
        /// <param name="totalThirdPartyFees">Total third party integration fees.</param>
        public ThirdPartyFeesDetails(double? deliveryIntegrationFee = default(double?), double? deliveryTipFee = default(double?), double? totalThirdPartyFees = default(double?))
        {
            this.DeliveryIntegrationFee = deliveryIntegrationFee;
            this.DeliveryTipFee = deliveryTipFee;
            this.TotalThirdPartyFees = totalThirdPartyFees;
        }
        
        /// <summary>
        /// Third party integration delivery fee
        /// </summary>
        /// <value>Third party integration delivery fee</value>
        [DataMember(Name="DeliveryIntegrationFee", EmitDefaultValue=false)]
        public double? DeliveryIntegrationFee { get; set; }

        /// <summary>
        /// Third party integration delivery tip fee
        /// </summary>
        /// <value>Third party integration delivery tip fee</value>
        [DataMember(Name="DeliveryTipFee", EmitDefaultValue=false)]
        public double? DeliveryTipFee { get; set; }

        /// <summary>
        /// Total third party integration fees
        /// </summary>
        /// <value>Total third party integration fees</value>
        [DataMember(Name="TotalThirdPartyFees", EmitDefaultValue=false)]
        public double? TotalThirdPartyFees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyFeesDetails {\n");
            sb.Append("  DeliveryIntegrationFee: ").Append(DeliveryIntegrationFee).Append("\n");
            sb.Append("  DeliveryTipFee: ").Append(DeliveryTipFee).Append("\n");
            sb.Append("  TotalThirdPartyFees: ").Append(TotalThirdPartyFees).Append("\n");
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
            return this.Equals(input as ThirdPartyFeesDetails);
        }

        /// <summary>
        /// Returns true if ThirdPartyFeesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ThirdPartyFeesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartyFeesDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryIntegrationFee == input.DeliveryIntegrationFee ||
                    (this.DeliveryIntegrationFee != null &&
                    this.DeliveryIntegrationFee.Equals(input.DeliveryIntegrationFee))
                ) && 
                (
                    this.DeliveryTipFee == input.DeliveryTipFee ||
                    (this.DeliveryTipFee != null &&
                    this.DeliveryTipFee.Equals(input.DeliveryTipFee))
                ) && 
                (
                    this.TotalThirdPartyFees == input.TotalThirdPartyFees ||
                    (this.TotalThirdPartyFees != null &&
                    this.TotalThirdPartyFees.Equals(input.TotalThirdPartyFees))
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
                if (this.DeliveryIntegrationFee != null)
                    hashCode = hashCode * 59 + this.DeliveryIntegrationFee.GetHashCode();
                if (this.DeliveryTipFee != null)
                    hashCode = hashCode * 59 + this.DeliveryTipFee.GetHashCode();
                if (this.TotalThirdPartyFees != null)
                    hashCode = hashCode * 59 + this.TotalThirdPartyFees.GetHashCode();
                return hashCode;
            }
        }
    }

}
