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
    /// GoogleGeometry
    /// </summary>
    [DataContract]
    public partial class GoogleGeometry :  IEquatable<GoogleGeometry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleGeometry" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="locationType">locationType.</param>
        /// <param name="viewport">viewport.</param>
        public GoogleGeometry(GoogleLocation location = default(GoogleLocation), string locationType = default(string), GoogleViewport viewport = default(GoogleViewport))
        {
            this.Location = location;
            this.Location_type = locationType;
            this.Viewport = viewport;
        }
        
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public GoogleLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets Location_type
        /// </summary>
        [DataMember(Name="Location_type", EmitDefaultValue=false)]
        public string Location_type { get; set; }

        /// <summary>
        /// Gets or Sets Viewport
        /// </summary>
        [DataMember(Name="Viewport", EmitDefaultValue=false)]
        public GoogleViewport Viewport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleGeometry {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Location_type: ").Append(Location_type).Append("\n");
            sb.Append("  Viewport: ").Append(Viewport).Append("\n");
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
            return this.Equals(input as GoogleGeometry);
        }

        /// <summary>
        /// Returns true if GoogleGeometry instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleGeometry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleGeometry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Location_type == input.Location_type ||
                    (this.Location_type != null &&
                    this.Location_type.Equals(input.Location_type))
                ) && 
                (
                    this.Viewport == input.Viewport ||
                    (this.Viewport != null &&
                    this.Viewport.Equals(input.Viewport))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Location_type != null)
                    hashCode = hashCode * 59 + this.Location_type.GetHashCode();
                if (this.Viewport != null)
                    hashCode = hashCode * 59 + this.Viewport.GetHashCode();
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