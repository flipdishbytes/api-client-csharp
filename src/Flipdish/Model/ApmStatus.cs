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
    /// APM status
    /// </summary>
    [DataContract]
    public partial class ApmStatus :  IEquatable<ApmStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApmStatus" /> class.
        /// </summary>
        /// <param name="isApmEnabled">Indicates if APM is active or otherwise.</param>
        public ApmStatus(bool? isApmEnabled = default(bool?))
        {
            this.IsApmEnabled = isApmEnabled;
        }
        
        /// <summary>
        /// Indicates if APM is active or otherwise
        /// </summary>
        /// <value>Indicates if APM is active or otherwise</value>
        [DataMember(Name="IsApmEnabled", EmitDefaultValue=false)]
        public bool? IsApmEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApmStatus {\n");
            sb.Append("  IsApmEnabled: ").Append(IsApmEnabled).Append("\n");
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
            return this.Equals(input as ApmStatus);
        }

        /// <summary>
        /// Returns true if ApmStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ApmStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApmStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsApmEnabled == input.IsApmEnabled ||
                    (this.IsApmEnabled != null &&
                    this.IsApmEnabled.Equals(input.IsApmEnabled))
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
                if (this.IsApmEnabled != null)
                    hashCode = hashCode * 59 + this.IsApmEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
