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
    /// Input model for updating a LocationArea
    /// </summary>
    [DataContract]
    public partial class UpdateLocationArea :  IEquatable<UpdateLocationArea>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLocationArea" /> class.
        /// </summary>
        /// <param name="locationAreaId">Location Area Id.</param>
        /// <param name="locationAreaName">Descriptive LocationArea name.</param>
        /// <param name="isDeleted">Sets if the Location Area should be soft deleted or not.</param>
        public UpdateLocationArea(int? locationAreaId = default(int?), string locationAreaName = default(string), bool? isDeleted = default(bool?))
        {
            this.LocationAreaId = locationAreaId;
            this.LocationAreaName = locationAreaName;
            this.IsDeleted = isDeleted;
        }
        
        /// <summary>
        /// Location Area Id
        /// </summary>
        /// <value>Location Area Id</value>
        [DataMember(Name="LocationAreaId", EmitDefaultValue=false)]
        public int? LocationAreaId { get; set; }

        /// <summary>
        /// Descriptive LocationArea name
        /// </summary>
        /// <value>Descriptive LocationArea name</value>
        [DataMember(Name="LocationAreaName", EmitDefaultValue=false)]
        public string LocationAreaName { get; set; }

        /// <summary>
        /// Sets if the Location Area should be soft deleted or not
        /// </summary>
        /// <value>Sets if the Location Area should be soft deleted or not</value>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLocationArea {\n");
            sb.Append("  LocationAreaId: ").Append(LocationAreaId).Append("\n");
            sb.Append("  LocationAreaName: ").Append(LocationAreaName).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as UpdateLocationArea);
        }

        /// <summary>
        /// Returns true if UpdateLocationArea instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLocationArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLocationArea input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationAreaId == input.LocationAreaId ||
                    (this.LocationAreaId != null &&
                    this.LocationAreaId.Equals(input.LocationAreaId))
                ) && 
                (
                    this.LocationAreaName == input.LocationAreaName ||
                    (this.LocationAreaName != null &&
                    this.LocationAreaName.Equals(input.LocationAreaName))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.LocationAreaId != null)
                    hashCode = hashCode * 59 + this.LocationAreaId.GetHashCode();
                if (this.LocationAreaName != null)
                    hashCode = hashCode * 59 + this.LocationAreaName.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
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
