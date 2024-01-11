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
    /// SubmitOrderRequest
    /// </summary>
    [DataContract]
    public partial class SubmitOrderRequest :  IEquatable<SubmitOrderRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitOrderRequest" /> class.
        /// </summary>
        /// <param name="paymentToken">paymentToken.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="chefNote">chefNote.</param>
        public SubmitOrderRequest(string paymentToken = default(string), string phoneNumber = default(string), string chefNote = default(string))
        {
            this.PaymentToken = paymentToken;
            this.PhoneNumber = phoneNumber;
            this.ChefNote = chefNote;
        }
        
        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name="PaymentToken", EmitDefaultValue=false)]
        public string PaymentToken { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ChefNote
        /// </summary>
        [DataMember(Name="ChefNote", EmitDefaultValue=false)]
        public string ChefNote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitOrderRequest {\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ChefNote: ").Append(ChefNote).Append("\n");
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
            return this.Equals(input as SubmitOrderRequest);
        }

        /// <summary>
        /// Returns true if SubmitOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitOrderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ChefNote == input.ChefNote ||
                    (this.ChefNote != null &&
                    this.ChefNote.Equals(input.ChefNote))
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
                if (this.PaymentToken != null)
                    hashCode = hashCode * 59 + this.PaymentToken.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ChefNote != null)
                    hashCode = hashCode * 59 + this.ChefNote.GetHashCode();
                return hashCode;
            }
        }
    }

}
