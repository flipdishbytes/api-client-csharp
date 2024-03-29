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
    /// DynamicFormRules
    /// </summary>
    [DataContract]
    public partial class DynamicFormRules :  IEquatable<DynamicFormRules>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicFormRules" /> class.
        /// </summary>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="minLength">minLength.</param>
        /// <param name="required">required.</param>
        /// <param name="pattern">pattern.</param>
        /// <param name="predefined">predefined.</param>
        public DynamicFormRules(DynamicFormRule maxLength = default(DynamicFormRule), DynamicFormRule minLength = default(DynamicFormRule), DynamicFormRule required = default(DynamicFormRule), DynamicFormRule pattern = default(DynamicFormRule), List<DynamicFormFieldOption> predefined = default(List<DynamicFormFieldOption>))
        {
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Required = required;
            this.Pattern = pattern;
            this.Predefined = predefined;
        }
        
        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="MaxLength", EmitDefaultValue=false)]
        public DynamicFormRule MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name="MinLength", EmitDefaultValue=false)]
        public DynamicFormRule MinLength { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="Required", EmitDefaultValue=false)]
        public DynamicFormRule Required { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name="Pattern", EmitDefaultValue=false)]
        public DynamicFormRule Pattern { get; set; }

        /// <summary>
        /// Gets or Sets Predefined
        /// </summary>
        [DataMember(Name="Predefined", EmitDefaultValue=false)]
        public List<DynamicFormFieldOption> Predefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicFormRules {\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Predefined: ").Append(Predefined).Append("\n");
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
            return this.Equals(input as DynamicFormRules);
        }

        /// <summary>
        /// Returns true if DynamicFormRules instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicFormRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicFormRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.MinLength == input.MinLength ||
                    (this.MinLength != null &&
                    this.MinLength.Equals(input.MinLength))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.Predefined == input.Predefined ||
                    this.Predefined != null &&
                    this.Predefined.SequenceEqual(input.Predefined)
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
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MinLength != null)
                    hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Predefined != null)
                    hashCode = hashCode * 59 + this.Predefined.GetHashCode();
                return hashCode;
            }
        }
    }

}
