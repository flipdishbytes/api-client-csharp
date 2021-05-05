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
    /// Processing fee config
    /// </summary>
    [DataContract]
    public partial class ProcessingFeeConfig :  IEquatable<ProcessingFeeConfig>, IValidatableObject
    {
        /// <summary>
        /// Payment account type
        /// </summary>
        /// <value>Payment account type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentAccountTypeEnum
        {
            
            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 1,
            
            /// <summary>
            /// Enum Cash for value: Cash
            /// </summary>
            [EnumMember(Value = "Cash")]
            Cash = 2,
            
            /// <summary>
            /// Enum Ideal for value: Ideal
            /// </summary>
            [EnumMember(Value = "Ideal")]
            Ideal = 3,
            
            /// <summary>
            /// Enum Bancontact for value: Bancontact
            /// </summary>
            [EnumMember(Value = "Bancontact")]
            Bancontact = 4,
            
            /// <summary>
            /// Enum Giropay for value: Giropay
            /// </summary>
            [EnumMember(Value = "Giropay")]
            Giropay = 5,
            
            /// <summary>
            /// Enum Eps for value: Eps
            /// </summary>
            [EnumMember(Value = "Eps")]
            Eps = 6,
            
            /// <summary>
            /// Enum Emv for value: Emv
            /// </summary>
            [EnumMember(Value = "Emv")]
            Emv = 7,
            
            /// <summary>
            /// Enum PayPal for value: PayPal
            /// </summary>
            [EnumMember(Value = "PayPal")]
            PayPal = 8
        }

        /// <summary>
        /// Payment account type
        /// </summary>
        /// <value>Payment account type</value>
        [DataMember(Name="PaymentAccountType", EmitDefaultValue=false)]
        public PaymentAccountTypeEnum? PaymentAccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingFeeConfig" /> class.
        /// </summary>
        /// <param name="storeId">Store Id.</param>
        /// <param name="paymentAccountType">Payment account type.</param>
        /// <param name="percentFee">Percent fee to customer, including VAT.</param>
        /// <param name="fixedFee">Fixed fee to customer, including VAT.</param>
        public ProcessingFeeConfig(int? storeId = default(int?), PaymentAccountTypeEnum? paymentAccountType = default(PaymentAccountTypeEnum?), double? percentFee = default(double?), double? fixedFee = default(double?))
        {
            this.StoreId = storeId;
            this.PaymentAccountType = paymentAccountType;
            this.PercentFee = percentFee;
            this.FixedFee = fixedFee;
        }
        
        /// <summary>
        /// Store Id
        /// </summary>
        /// <value>Store Id</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }


        /// <summary>
        /// Percent fee to customer, including VAT
        /// </summary>
        /// <value>Percent fee to customer, including VAT</value>
        [DataMember(Name="PercentFee", EmitDefaultValue=false)]
        public double? PercentFee { get; set; }

        /// <summary>
        /// Fixed fee to customer, including VAT
        /// </summary>
        /// <value>Fixed fee to customer, including VAT</value>
        [DataMember(Name="FixedFee", EmitDefaultValue=false)]
        public double? FixedFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingFeeConfig {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  PaymentAccountType: ").Append(PaymentAccountType).Append("\n");
            sb.Append("  PercentFee: ").Append(PercentFee).Append("\n");
            sb.Append("  FixedFee: ").Append(FixedFee).Append("\n");
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
            return this.Equals(input as ProcessingFeeConfig);
        }

        /// <summary>
        /// Returns true if ProcessingFeeConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessingFeeConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingFeeConfig input)
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
                    this.PaymentAccountType == input.PaymentAccountType ||
                    (this.PaymentAccountType != null &&
                    this.PaymentAccountType.Equals(input.PaymentAccountType))
                ) && 
                (
                    this.PercentFee == input.PercentFee ||
                    (this.PercentFee != null &&
                    this.PercentFee.Equals(input.PercentFee))
                ) && 
                (
                    this.FixedFee == input.FixedFee ||
                    (this.FixedFee != null &&
                    this.FixedFee.Equals(input.FixedFee))
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
                if (this.PaymentAccountType != null)
                    hashCode = hashCode * 59 + this.PaymentAccountType.GetHashCode();
                if (this.PercentFee != null)
                    hashCode = hashCode * 59 + this.PercentFee.GetHashCode();
                if (this.FixedFee != null)
                    hashCode = hashCode * 59 + this.FixedFee.GetHashCode();
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
