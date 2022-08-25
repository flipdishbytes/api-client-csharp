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
    /// Validation error result
    /// </summary>
    [DataContract]
    public partial class ValidationErrorResult :  IEquatable<ValidationErrorResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorResult" /> class.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <param name="errors">List of errors relates to field.</param>
        public ValidationErrorResult(string fieldName = default(string), List<string> errors = default(List<string>))
        {
            this.FieldName = fieldName;
            this.Errors = errors;
        }
        
        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        [DataMember(Name="FieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// List of errors relates to field
        /// </summary>
        /// <value>List of errors relates to field</value>
        [DataMember(Name="Errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationErrorResult {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as ValidationErrorResult);
        }

        /// <summary>
        /// Returns true if ValidationErrorResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationErrorResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationErrorResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }
    }

}
