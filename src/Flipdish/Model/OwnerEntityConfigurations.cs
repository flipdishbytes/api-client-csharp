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
    /// Owner Entity Configurations
    /// </summary>
    [DataContract]
    public partial class OwnerEntityConfigurations :  IEquatable<OwnerEntityConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerEntityConfigurations" /> class.
        /// </summary>
        /// <param name="configurations">Owner Entity Configuration.</param>
        public OwnerEntityConfigurations(List<OwnerEntityConfiguration> configurations = default(List<OwnerEntityConfiguration>))
        {
            this.Configurations = configurations;
        }
        
        /// <summary>
        /// Owner Entity Configuration
        /// </summary>
        /// <value>Owner Entity Configuration</value>
        [DataMember(Name="Configurations", EmitDefaultValue=false)]
        public List<OwnerEntityConfiguration> Configurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerEntityConfigurations {\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
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
            return this.Equals(input as OwnerEntityConfigurations);
        }

        /// <summary>
        /// Returns true if OwnerEntityConfigurations instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnerEntityConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerEntityConfigurations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
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
                if (this.Configurations != null)
                    hashCode = hashCode * 59 + this.Configurations.GetHashCode();
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