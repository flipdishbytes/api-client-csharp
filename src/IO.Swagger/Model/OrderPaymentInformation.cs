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
    /// Order Payment Information
    /// </summary>
    [DataContract]
    public partial class OrderPaymentInformation :  IEquatable<OrderPaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPaymentInformation" /> class.
        /// </summary>
        /// <param name="orderId">ID of the Order.</param>
        /// <param name="paymentRefundable">Signifies if the payment is refundable.</param>
        public OrderPaymentInformation(int? orderId = default(int?), bool? paymentRefundable = default(bool?))
        {
            this.OrderId = orderId;
            this.PaymentRefundable = paymentRefundable;
        }
        
        /// <summary>
        /// ID of the Order
        /// </summary>
        /// <value>ID of the Order</value>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Signifies if the payment is refundable
        /// </summary>
        /// <value>Signifies if the payment is refundable</value>
        [DataMember(Name="PaymentRefundable", EmitDefaultValue=false)]
        public bool? PaymentRefundable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPaymentInformation {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaymentRefundable: ").Append(PaymentRefundable).Append("\n");
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
            return this.Equals(input as OrderPaymentInformation);
        }

        /// <summary>
        /// Returns true if OrderPaymentInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPaymentInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaymentRefundable == input.PaymentRefundable ||
                    (this.PaymentRefundable != null &&
                    this.PaymentRefundable.Equals(input.PaymentRefundable))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PaymentRefundable != null)
                    hashCode = hashCode * 59 + this.PaymentRefundable.GetHashCode();
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
