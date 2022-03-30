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
    /// DynamicFormField
    /// </summary>
    [DataContract]
    public partial class DynamicFormField :  IEquatable<DynamicFormField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicFormField" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="label">label.</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="rules">rules.</param>
        /// <param name="mapping">mapping.</param>
        /// <param name="value">value.</param>
        public DynamicFormField(string identifier = default(string), string label = default(string), string placeholder = default(string), DynamicFormRules rules = default(DynamicFormRules), DynamicFormFieldMapping mapping = default(DynamicFormFieldMapping), Object value = default(Object))
        {
            this.Identifier = identifier;
            this.Label = label;
            this.Placeholder = placeholder;
            this.Rules = rules;
            this.Mapping = mapping;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="Identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="Label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name="Placeholder", EmitDefaultValue=false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="Rules", EmitDefaultValue=false)]
        public DynamicFormRules Rules { get; set; }

        /// <summary>
        /// Gets or Sets Mapping
        /// </summary>
        [DataMember(Name="Mapping", EmitDefaultValue=false)]
        public DynamicFormFieldMapping Mapping { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicFormField {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DynamicFormField);
        }

        /// <summary>
        /// Returns true if DynamicFormField instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicFormField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicFormField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Placeholder == input.Placeholder ||
                    (this.Placeholder != null &&
                    this.Placeholder.Equals(input.Placeholder))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Placeholder != null)
                    hashCode = hashCode * 59 + this.Placeholder.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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