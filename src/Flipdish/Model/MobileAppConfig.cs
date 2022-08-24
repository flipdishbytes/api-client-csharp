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
    /// Mobile Apps form submission
    /// </summary>
    [DataContract]
    public partial class MobileAppConfig :  IEquatable<MobileAppConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppConfig" /> class.
        /// </summary>
        /// <param name="autoPublish">App Name.</param>
        public MobileAppConfig(bool? autoPublish = default(bool?))
        {
            this.AutoPublish = autoPublish;
        }
        
        /// <summary>
        /// App Name
        /// </summary>
        /// <value>App Name</value>
        [DataMember(Name="AutoPublish", EmitDefaultValue=false)]
        public bool? AutoPublish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileAppConfig {\n");
            sb.Append("  AutoPublish: ").Append(AutoPublish).Append("\n");
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
            return this.Equals(input as MobileAppConfig);
        }

        /// <summary>
        /// Returns true if MobileAppConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileAppConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileAppConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoPublish == input.AutoPublish ||
                    (this.AutoPublish != null &&
                    this.AutoPublish.Equals(input.AutoPublish))
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
                if (this.AutoPublish != null)
                    hashCode = hashCode * 59 + this.AutoPublish.GetHashCode();
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