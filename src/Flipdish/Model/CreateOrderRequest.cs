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
    /// CreateOrderRequest
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequest :  IEquatable<CreateOrderRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        /// <param name="legacyOrderDm">legacyOrderDm.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="deliveryLocation">deliveryLocation.</param>
        public CreateOrderRequest(OrderDm legacyOrderDm = default(OrderDm), string phoneNumber = default(string), string customerName = default(string), DeliveryLocation deliveryLocation = default(DeliveryLocation))
        {
            this.LegacyOrderDm = legacyOrderDm;
            this.PhoneNumber = phoneNumber;
            this.CustomerName = customerName;
            this.DeliveryLocation = deliveryLocation;
        }
        
        /// <summary>
        /// Gets or Sets LegacyOrderDm
        /// </summary>
        [DataMember(Name="LegacyOrderDm", EmitDefaultValue=false)]
        public OrderDm LegacyOrderDm { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="CustomerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryLocation
        /// </summary>
        [DataMember(Name="DeliveryLocation", EmitDefaultValue=false)]
        public DeliveryLocation DeliveryLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequest {\n");
            sb.Append("  LegacyOrderDm: ").Append(LegacyOrderDm).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  DeliveryLocation: ").Append(DeliveryLocation).Append("\n");
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
            return this.Equals(input as CreateOrderRequest);
        }

        /// <summary>
        /// Returns true if CreateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LegacyOrderDm == input.LegacyOrderDm ||
                    (this.LegacyOrderDm != null &&
                    this.LegacyOrderDm.Equals(input.LegacyOrderDm))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.DeliveryLocation == input.DeliveryLocation ||
                    (this.DeliveryLocation != null &&
                    this.DeliveryLocation.Equals(input.DeliveryLocation))
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
                if (this.LegacyOrderDm != null)
                    hashCode = hashCode * 59 + this.LegacyOrderDm.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.DeliveryLocation != null)
                    hashCode = hashCode * 59 + this.DeliveryLocation.GetHashCode();
                return hashCode;
            }
        }
    }

}
