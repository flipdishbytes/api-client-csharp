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
    /// List of field definitions per country
    /// </summary>
    [DataContract]
    public partial class CountryWithAccountFieldsDefinitions :  IEquatable<CountryWithAccountFieldsDefinitions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryWithAccountFieldsDefinitions" /> class.
        /// </summary>
        /// <param name="countryCode">Country 2-letter ISO code.</param>
        /// <param name="displayName">Display name of the country.</param>
        /// <param name="supportType">Country support type (supported-by-stripe-cc, supported-by-flipdish,not-supported).</param>
        /// <param name="fieldDefinitions">Bank Account field definitions.</param>
        public CountryWithAccountFieldsDefinitions(string countryCode = default(string), string displayName = default(string), string supportType = default(string), List<AccountFieldDefinition> fieldDefinitions = default(List<AccountFieldDefinition>))
        {
            this.CountryCode = countryCode;
            this.DisplayName = displayName;
            this.SupportType = supportType;
            this.FieldDefinitions = fieldDefinitions;
        }
        
        /// <summary>
        /// Country 2-letter ISO code
        /// </summary>
        /// <value>Country 2-letter ISO code</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Display name of the country
        /// </summary>
        /// <value>Display name of the country</value>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Country support type (supported-by-stripe-cc, supported-by-flipdish,not-supported)
        /// </summary>
        /// <value>Country support type (supported-by-stripe-cc, supported-by-flipdish,not-supported)</value>
        [DataMember(Name="SupportType", EmitDefaultValue=false)]
        public string SupportType { get; set; }

        /// <summary>
        /// Bank Account field definitions
        /// </summary>
        /// <value>Bank Account field definitions</value>
        [DataMember(Name="FieldDefinitions", EmitDefaultValue=false)]
        public List<AccountFieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryWithAccountFieldsDefinitions {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SupportType: ").Append(SupportType).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
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
            return this.Equals(input as CountryWithAccountFieldsDefinitions);
        }

        /// <summary>
        /// Returns true if CountryWithAccountFieldsDefinitions instances are equal
        /// </summary>
        /// <param name="input">Instance of CountryWithAccountFieldsDefinitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryWithAccountFieldsDefinitions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.SupportType == input.SupportType ||
                    (this.SupportType != null &&
                    this.SupportType.Equals(input.SupportType))
                ) && 
                (
                    this.FieldDefinitions == input.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(input.FieldDefinitions)
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SupportType != null)
                    hashCode = hashCode * 59 + this.SupportType.GetHashCode();
                if (this.FieldDefinitions != null)
                    hashCode = hashCode * 59 + this.FieldDefinitions.GetHashCode();
                return hashCode;
            }
        }
    }

}
