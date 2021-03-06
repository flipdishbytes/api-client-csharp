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
    /// Metadata
    /// </summary>
    [DataContract]
    public partial class Metadata :  IEquatable<Metadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="menuEntityId">Menu entity identifier (eg: MenuItemId, MenuItemOptionSetItemId).</param>
        /// <param name="key">Metadata key (Unique identifier).</param>
        /// <param name="value">Metadata value.</param>
        public Metadata(int? menuEntityId = default(int?), string key = default(string), string value = default(string))
        {
            this.MenuEntityId = menuEntityId;
            this.Key = key;
            this.Value = value;
        }
        
        /// <summary>
        /// Menu entity identifier (eg: MenuItemId, MenuItemOptionSetItemId)
        /// </summary>
        /// <value>Menu entity identifier (eg: MenuItemId, MenuItemOptionSetItemId)</value>
        [DataMember(Name="MenuEntityId", EmitDefaultValue=false)]
        public int? MenuEntityId { get; set; }

        /// <summary>
        /// Metadata key (Unique identifier)
        /// </summary>
        /// <value>Metadata key (Unique identifier)</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Metadata value
        /// </summary>
        /// <value>Metadata value</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metadata {\n");
            sb.Append("  MenuEntityId: ").Append(MenuEntityId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as Metadata);
        }

        /// <summary>
        /// Returns true if Metadata instances are equal
        /// </summary>
        /// <param name="input">Instance of Metadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuEntityId == input.MenuEntityId ||
                    (this.MenuEntityId != null &&
                    this.MenuEntityId.Equals(input.MenuEntityId))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.MenuEntityId != null)
                    hashCode = hashCode * 59 + this.MenuEntityId.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
            // Key (string) maxLength
            if(this.Key != null && this.Key.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 128.", new [] { "Key" });
            }

            // Key (string) minLength
            if(this.Key != null && this.Key.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 0.", new [] { "Key" });
            }

            // Value (string) maxLength
            if(this.Value != null && this.Value.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 128.", new [] { "Value" });
            }

            // Value (string) minLength
            if(this.Value != null && this.Value.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 0.", new [] { "Value" });
            }

            yield break;
        }
    }

}
