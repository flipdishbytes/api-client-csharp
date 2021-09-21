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
    /// Field Group
    /// </summary>
    [DataContract]
    public partial class FieldGroup :  IEquatable<FieldGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldGroup" /> class.
        /// </summary>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description.</param>
        /// <param name="tooltip">Tooltip  &lt;remarks&gt;Displays on text hover&lt;/remarks&gt;.</param>
        /// <param name="position">Position  &lt;remarks&gt;Position order in the field groups to display&lt;/remarks&gt; (required).</param>
        /// <param name="fields">Fields.</param>
        public FieldGroup(string name = default(string), string description = default(string), string tooltip = default(string), int? position = default(int?), List<Field> fields = default(List<Field>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FieldGroup and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for FieldGroup and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            this.Description = description;
            this.Tooltip = tooltip;
            this.Fields = fields;
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
        /// Tooltip  &lt;remarks&gt;Displays on text hover&lt;/remarks&gt;
        /// </summary>
        /// <value>Tooltip  &lt;remarks&gt;Displays on text hover&lt;/remarks&gt;</value>
        [DataMember(Name="Tooltip", EmitDefaultValue=false)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Position  &lt;remarks&gt;Position order in the field groups to display&lt;/remarks&gt;
        /// </summary>
        /// <value>Position  &lt;remarks&gt;Position order in the field groups to display&lt;/remarks&gt;</value>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="Fields", EmitDefaultValue=false)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as FieldGroup);
        }

        /// <summary>
        /// Returns true if FieldGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldGroup input)
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
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Tooltip != null)
                    hashCode = hashCode * 59 + this.Tooltip.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
