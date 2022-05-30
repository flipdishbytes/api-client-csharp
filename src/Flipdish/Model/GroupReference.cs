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
    /// Reference to an existing {Flipdish.PublicModels.V1.Catalog.Groups.CatalogGroup}
    /// </summary>
    [DataContract]
    public partial class GroupReference :  IEquatable<GroupReference>, IValidatableObject
    {
        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupTypeEnum
        {
            
            /// <summary>
            /// Enum ModifierGroup for value: ModifierGroup
            /// </summary>
            [EnumMember(Value = "ModifierGroup")]
            ModifierGroup = 1
        }

        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [DataMember(Name="GroupType", EmitDefaultValue=false)]
        public GroupTypeEnum GroupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReference" /> class.
        /// </summary>
        /// <param name="group">Details of the referenced {Flipdish.PublicModels.V1.Catalog.Products.Product}.</param>
        /// <param name="catalogGroupId">Identifier of the ProductId to use as SubProduct (required).</param>
        /// <param name="catalogItemId">Identifier of the ProductId to use as SubProduct.</param>
        /// <param name="groupType">Type of the SupProduct (required).</param>
        public GroupReference(CatalogGroup group = default(CatalogGroup), string catalogGroupId = default(string), string catalogItemId = default(string), GroupTypeEnum groupType = default(GroupTypeEnum))
        {
            // to ensure "catalogGroupId" is required (not null)
            if (catalogGroupId == null)
            {
                throw new InvalidDataException("catalogGroupId is a required property for GroupReference and cannot be null");
            }
            else
            {
                this.CatalogGroupId = catalogGroupId;
            }
            // to ensure "groupType" is required (not null)
            if (groupType == null)
            {
                throw new InvalidDataException("groupType is a required property for GroupReference and cannot be null");
            }
            else
            {
                this.GroupType = groupType;
            }
            this.Group = group;
            this.CatalogItemId = catalogItemId;
        }
        
        /// <summary>
        /// Details of the referenced {Flipdish.PublicModels.V1.Catalog.Products.Product}
        /// </summary>
        /// <value>Details of the referenced {Flipdish.PublicModels.V1.Catalog.Products.Product}</value>
        [DataMember(Name="Group", EmitDefaultValue=false)]
        public CatalogGroup Group { get; set; }

        /// <summary>
        /// Identifier of the ProductId to use as SubProduct
        /// </summary>
        /// <value>Identifier of the ProductId to use as SubProduct</value>
        [DataMember(Name="CatalogGroupId", EmitDefaultValue=false)]
        public string CatalogGroupId { get; set; }

        /// <summary>
        /// Identifier of the ProductId to use as SubProduct
        /// </summary>
        /// <value>Identifier of the ProductId to use as SubProduct</value>
        [DataMember(Name="CatalogItemId", EmitDefaultValue=false)]
        public string CatalogItemId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupReference {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  CatalogGroupId: ").Append(CatalogGroupId).Append("\n");
            sb.Append("  CatalogItemId: ").Append(CatalogItemId).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
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
            return this.Equals(input as GroupReference);
        }

        /// <summary>
        /// Returns true if GroupReference instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.CatalogGroupId == input.CatalogGroupId ||
                    (this.CatalogGroupId != null &&
                    this.CatalogGroupId.Equals(input.CatalogGroupId))
                ) && 
                (
                    this.CatalogItemId == input.CatalogItemId ||
                    (this.CatalogItemId != null &&
                    this.CatalogItemId.Equals(input.CatalogItemId))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.CatalogGroupId != null)
                    hashCode = hashCode * 59 + this.CatalogGroupId.GetHashCode();
                if (this.CatalogItemId != null)
                    hashCode = hashCode * 59 + this.CatalogItemId.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
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
            // CatalogGroupId (string) maxLength
            if(this.CatalogGroupId != null && this.CatalogGroupId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogGroupId, length must be less than 30.", new [] { "CatalogGroupId" });
            }

            // CatalogGroupId (string) minLength
            if(this.CatalogGroupId != null && this.CatalogGroupId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogGroupId, length must be greater than 0.", new [] { "CatalogGroupId" });
            }

            // CatalogItemId (string) maxLength
            if(this.CatalogItemId != null && this.CatalogItemId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogItemId, length must be less than 30.", new [] { "CatalogItemId" });
            }

            // CatalogItemId (string) minLength
            if(this.CatalogItemId != null && this.CatalogItemId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogItemId, length must be greater than 0.", new [] { "CatalogItemId" });
            }

            yield break;
        }
    }

}
