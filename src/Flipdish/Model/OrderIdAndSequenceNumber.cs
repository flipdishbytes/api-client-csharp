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
    /// OrderIdAndSequenceNumber
    /// </summary>
    [DataContract]
    public partial class OrderIdAndSequenceNumber :  IEquatable<OrderIdAndSequenceNumber>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderIdAndSequenceNumber" /> class.
        /// </summary>
        /// <param name="orderId">Order identifier.</param>
        /// <param name="sequence">Sequence for delivery.</param>
        public OrderIdAndSequenceNumber(int? orderId = default(int?), int? sequence = default(int?))
        {
            this.OrderId = orderId;
            this.Sequence = sequence;
        }
        
        /// <summary>
        /// Order identifier
        /// </summary>
        /// <value>Order identifier</value>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Sequence for delivery
        /// </summary>
        /// <value>Sequence for delivery</value>
        [DataMember(Name="Sequence", EmitDefaultValue=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderIdAndSequenceNumber {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
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
            return this.Equals(input as OrderIdAndSequenceNumber);
        }

        /// <summary>
        /// Returns true if OrderIdAndSequenceNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderIdAndSequenceNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderIdAndSequenceNumber input)
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
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
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
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }

}
