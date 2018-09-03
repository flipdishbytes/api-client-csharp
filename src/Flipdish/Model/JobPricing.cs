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
    /// Job Pricing
    /// </summary>
    [DataContract]
    public partial class JobPricing :  IEquatable<JobPricing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobPricing" /> class.
        /// </summary>
        /// <param name="Currency">Currency.</param>
        /// <param name="TaxPercentage">Tax Percentage.</param>
        /// <param name="PriceTaxIncluded">Price Tax Included.</param>
        /// <param name="PriceTaxExcluded">Price Tax Excluded.</param>
        /// <param name="TaxAmount">Tax Amount.</param>
        /// <param name="InvoiceUrl">Invoice Url.</param>
        public JobPricing(string Currency = default(string), double? TaxPercentage = default(double?), double? PriceTaxIncluded = default(double?), double? PriceTaxExcluded = default(double?), double? TaxAmount = default(double?), string InvoiceUrl = default(string))
        {
            this.Currency = Currency;
            this.TaxPercentage = TaxPercentage;
            this.PriceTaxIncluded = PriceTaxIncluded;
            this.PriceTaxExcluded = PriceTaxExcluded;
            this.TaxAmount = TaxAmount;
            this.InvoiceUrl = InvoiceUrl;
        }
        
        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Tax Percentage
        /// </summary>
        /// <value>Tax Percentage</value>
        [DataMember(Name="TaxPercentage", EmitDefaultValue=false)]
        public double? TaxPercentage { get; set; }

        /// <summary>
        /// Price Tax Included
        /// </summary>
        /// <value>Price Tax Included</value>
        [DataMember(Name="PriceTaxIncluded", EmitDefaultValue=false)]
        public double? PriceTaxIncluded { get; set; }

        /// <summary>
        /// Price Tax Excluded
        /// </summary>
        /// <value>Price Tax Excluded</value>
        [DataMember(Name="PriceTaxExcluded", EmitDefaultValue=false)]
        public double? PriceTaxExcluded { get; set; }

        /// <summary>
        /// Tax Amount
        /// </summary>
        /// <value>Tax Amount</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Invoice Url
        /// </summary>
        /// <value>Invoice Url</value>
        [DataMember(Name="InvoiceUrl", EmitDefaultValue=false)]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobPricing {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
            sb.Append("  PriceTaxIncluded: ").Append(PriceTaxIncluded).Append("\n");
            sb.Append("  PriceTaxExcluded: ").Append(PriceTaxExcluded).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  InvoiceUrl: ").Append(InvoiceUrl).Append("\n");
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
            return this.Equals(input as JobPricing);
        }

        /// <summary>
        /// Returns true if JobPricing instances are equal
        /// </summary>
        /// <param name="input">Instance of JobPricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobPricing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.TaxPercentage == input.TaxPercentage ||
                    (this.TaxPercentage != null &&
                    this.TaxPercentage.Equals(input.TaxPercentage))
                ) && 
                (
                    this.PriceTaxIncluded == input.PriceTaxIncluded ||
                    (this.PriceTaxIncluded != null &&
                    this.PriceTaxIncluded.Equals(input.PriceTaxIncluded))
                ) && 
                (
                    this.PriceTaxExcluded == input.PriceTaxExcluded ||
                    (this.PriceTaxExcluded != null &&
                    this.PriceTaxExcluded.Equals(input.PriceTaxExcluded))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.InvoiceUrl == input.InvoiceUrl ||
                    (this.InvoiceUrl != null &&
                    this.InvoiceUrl.Equals(input.InvoiceUrl))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.TaxPercentage != null)
                    hashCode = hashCode * 59 + this.TaxPercentage.GetHashCode();
                if (this.PriceTaxIncluded != null)
                    hashCode = hashCode * 59 + this.PriceTaxIncluded.GetHashCode();
                if (this.PriceTaxExcluded != null)
                    hashCode = hashCode * 59 + this.PriceTaxExcluded.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.InvoiceUrl != null)
                    hashCode = hashCode * 59 + this.InvoiceUrl.GetHashCode();
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
