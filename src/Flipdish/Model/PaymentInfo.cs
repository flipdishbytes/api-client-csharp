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
    /// Payment information
    /// </summary>
    [DataContract]
    public partial class PaymentInfo :  IEquatable<PaymentInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInfo" /> class.
        /// </summary>
        /// <param name="paid">Defines if the order was paid.</param>
        /// <param name="paymentType">Payment Description.</param>
        public PaymentInfo(bool? paid = default(bool?), string paymentType = default(string))
        {
            this.Paid = paid;
            this.PaymentType = paymentType;
        }
        
        /// <summary>
        /// Defines if the order was paid
        /// </summary>
        /// <value>Defines if the order was paid</value>
        [DataMember(Name="Paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }

        /// <summary>
        /// Payment Description
        /// </summary>
        /// <value>Payment Description</value>
        [DataMember(Name="PaymentType", EmitDefaultValue=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInfo {\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
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
            return this.Equals(input as PaymentInfo);
        }

        /// <summary>
        /// Returns true if PaymentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paid == input.Paid ||
                    (this.Paid != null &&
                    this.Paid.Equals(input.Paid))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
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
                if (this.Paid != null)
                    hashCode = hashCode * 59 + this.Paid.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                return hashCode;
            }
        }
    }

}
