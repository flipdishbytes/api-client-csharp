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
    /// Field
    /// </summary>
    [DataContract]
    public partial class Field :  IEquatable<Field>, IValidatableObject
    {
        /// <summary>
        /// Field Type
        /// </summary>
        /// <value>Field Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
        {
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 1,
            
            /// <summary>
            /// Enum TextArea for value: TextArea
            /// </summary>
            [EnumMember(Value = "TextArea")]
            TextArea = 2,
            
            /// <summary>
            /// Enum Integer for value: Integer
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer = 3,
            
            /// <summary>
            /// Enum Decimal for value: Decimal
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal = 4,
            
            /// <summary>
            /// Enum Date for value: Date
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 5,
            
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 6,
            
            /// <summary>
            /// Enum Time for value: Time
            /// </summary>
            [EnumMember(Value = "Time")]
            Time = 7,
            
            /// <summary>
            /// Enum Select for value: Select
            /// </summary>
            [EnumMember(Value = "Select")]
            Select = 8,
            
            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 9
        }

        /// <summary>
        /// Field Type
        /// </summary>
        /// <value>Field Type</value>
        [DataMember(Name="FieldType", EmitDefaultValue=false)]
        public FieldTypeEnum FieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Field() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="key">Key (required).</param>
        /// <param name="tooltip">Tooltip.</param>
        /// <param name="position">Position (required).</param>
        /// <param name="defaultValue">Default Value.</param>
        /// <param name="validValues">Valid Values  &lt;remarks&gt;Used typically for dropdown/select&lt;/remarks&gt;.</param>
        /// <param name="validationRegex">Validation Regex.</param>
        /// <param name="fieldType">Field Type (required).</param>
        public Field(string name = default(string), string description = default(string), string key = default(string), string tooltip = default(string), int? position = default(int?), string defaultValue = default(string), List<ValidValue> validValues = default(List<ValidValue>), string validationRegex = default(string), FieldTypeEnum fieldType = default(FieldTypeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Field and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Field and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for Field and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for Field and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
            {
                throw new InvalidDataException("fieldType is a required property for Field and cannot be null");
            }
            else
            {
                this.FieldType = fieldType;
            }
            this.Tooltip = tooltip;
            this.DefaultValue = defaultValue;
            this.ValidValues = validValues;
            this.ValidationRegex = validationRegex;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        /// <value>Key</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Tooltip
        /// </summary>
        /// <value>Tooltip</value>
        [DataMember(Name="Tooltip", EmitDefaultValue=false)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        /// <value>Position</value>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Default Value
        /// </summary>
        /// <value>Default Value</value>
        [DataMember(Name="DefaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Valid Values  &lt;remarks&gt;Used typically for dropdown/select&lt;/remarks&gt;
        /// </summary>
        /// <value>Valid Values  &lt;remarks&gt;Used typically for dropdown/select&lt;/remarks&gt;</value>
        [DataMember(Name="ValidValues", EmitDefaultValue=false)]
        public List<ValidValue> ValidValues { get; set; }

        /// <summary>
        /// Validation Regex
        /// </summary>
        /// <value>Validation Regex</value>
        [DataMember(Name="ValidationRegex", EmitDefaultValue=false)]
        public string ValidationRegex { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Field {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  ValidValues: ").Append(ValidValues).Append("\n");
            sb.Append("  ValidationRegex: ").Append(ValidationRegex).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
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
            return this.Equals(input as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="input">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Tooltip == input.Tooltip ||
                    (this.Tooltip != null &&
                    this.Tooltip.Equals(input.Tooltip))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.ValidValues == input.ValidValues ||
                    this.ValidValues != null &&
                    this.ValidValues.SequenceEqual(input.ValidValues)
                ) && 
                (
                    this.ValidationRegex == input.ValidationRegex ||
                    (this.ValidationRegex != null &&
                    this.ValidationRegex.Equals(input.ValidationRegex))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Tooltip != null)
                    hashCode = hashCode * 59 + this.Tooltip.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.ValidValues != null)
                    hashCode = hashCode * 59 + this.ValidValues.GetHashCode();
                if (this.ValidationRegex != null)
                    hashCode = hashCode * 59 + this.ValidationRegex.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
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
            // Position (int?) maximum
            if(this.Position > (int?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Position, must be a value less than or equal to 1000.", new [] { "Position" });
            }

            // Position (int?) minimum
            if(this.Position < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Position, must be a value greater than or equal to 1.", new [] { "Position" });
            }

            yield break;
        }
    }

}
