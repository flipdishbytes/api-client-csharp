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
    /// Pending Menu Changes
    /// </summary>
    [DataContract]
    public partial class PendingMenuChanges :  IEquatable<PendingMenuChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingMenuChanges" /> class.
        /// </summary>
        /// <param name="catalogElementId">Unique catalog element id.</param>
        /// <param name="menuId">Unique menu id.</param>
        /// <param name="lastUpdatedAt">Update date and time.</param>
        public PendingMenuChanges(string catalogElementId = default(string), int? menuId = default(int?), DateTime? lastUpdatedAt = default(DateTime?))
        {
            this.CatalogElementId = catalogElementId;
            this.MenuId = menuId;
            this.LastUpdatedAt = lastUpdatedAt;
        }
        
        /// <summary>
        /// Unique catalog element id
        /// </summary>
        /// <value>Unique catalog element id</value>
        [DataMember(Name="CatalogElementId", EmitDefaultValue=false)]
        public string CatalogElementId { get; set; }

        /// <summary>
        /// Unique menu id
        /// </summary>
        /// <value>Unique menu id</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Update date and time
        /// </summary>
        /// <value>Update date and time</value>
        [DataMember(Name="LastUpdatedAt", EmitDefaultValue=false)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingMenuChanges {\n");
            sb.Append("  CatalogElementId: ").Append(CatalogElementId).Append("\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
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
            return this.Equals(input as PendingMenuChanges);
        }

        /// <summary>
        /// Returns true if PendingMenuChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingMenuChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingMenuChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatalogElementId == input.CatalogElementId ||
                    (this.CatalogElementId != null &&
                    this.CatalogElementId.Equals(input.CatalogElementId))
                ) && 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
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
                if (this.CatalogElementId != null)
                    hashCode = hashCode * 59 + this.CatalogElementId.GetHashCode();
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.LastUpdatedAt != null)
                    hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
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
            // CatalogElementId (string) maxLength
            if(this.CatalogElementId != null && this.CatalogElementId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogElementId, length must be less than 30.", new [] { "CatalogElementId" });
            }

            // CatalogElementId (string) minLength
            if(this.CatalogElementId != null && this.CatalogElementId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogElementId, length must be greater than 0.", new [] { "CatalogElementId" });
            }

            yield break;
        }
    }

}