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
    /// CatalogGroup
    /// </summary>
    [DataContract]
    public partial class CatalogGroup :  IEquatable<CatalogGroup>, IValidatableObject
    {
        /// <summary>
        /// ModifierGroup, etc
        /// </summary>
        /// <value>ModifierGroup, etc</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum ModifierGroup for value: ModifierGroup
            /// </summary>
            [EnumMember(Value = "ModifierGroup")]
            ModifierGroup = 2
        }

        /// <summary>
        /// ModifierGroup, etc
        /// </summary>
        /// <value>ModifierGroup, etc</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogGroup" /> class.
        /// </summary>
        /// <param name="catalogGroupId">Unique catalog group id.</param>
        /// <param name="sku">Stock Keeping Unit (SKU).</param>
        /// <param name="name">Group name.</param>
        /// <param name="isArchived">Returns true if the group is archived.</param>
        /// <param name="minSelection">Minimum number of items that the user has to select.</param>
        /// <param name="maxSelection">Maximum number of items that the user has to select.</param>
        /// <param name="type">ModifierGroup, etc.</param>
        /// <param name="items">Collection of items associated with this product.</param>
        public CatalogGroup(string catalogGroupId = default(string), string sku = default(string), string name = default(string), bool? isArchived = default(bool?), int? minSelection = default(int?), int? maxSelection = default(int?), TypeEnum? type = default(TypeEnum?), List<CatalogItemReference> items = default(List<CatalogItemReference>))
        {
            this.CatalogGroupId = catalogGroupId;
            this.Sku = sku;
            this.Name = name;
            this.IsArchived = isArchived;
            this.MinSelection = minSelection;
            this.MaxSelection = maxSelection;
            this.Type = type;
            this.Items = items;
        }
        
        /// <summary>
        /// Unique catalog group id
        /// </summary>
        /// <value>Unique catalog group id</value>
        [DataMember(Name="CatalogGroupId", EmitDefaultValue=false)]
        public string CatalogGroupId { get; set; }

        /// <summary>
        /// Stock Keeping Unit (SKU)
        /// </summary>
        /// <value>Stock Keeping Unit (SKU)</value>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        /// <value>Group name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns true if the group is archived
        /// </summary>
        /// <value>Returns true if the group is archived</value>
        [DataMember(Name="IsArchived", EmitDefaultValue=false)]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Minimum number of items that the user has to select
        /// </summary>
        /// <value>Minimum number of items that the user has to select</value>
        [DataMember(Name="MinSelection", EmitDefaultValue=false)]
        public int? MinSelection { get; set; }

        /// <summary>
        /// Maximum number of items that the user has to select
        /// </summary>
        /// <value>Maximum number of items that the user has to select</value>
        [DataMember(Name="MaxSelection", EmitDefaultValue=false)]
        public int? MaxSelection { get; set; }


        /// <summary>
        /// Collection of items associated with this product
        /// </summary>
        /// <value>Collection of items associated with this product</value>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<CatalogItemReference> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogGroup {\n");
            sb.Append("  CatalogGroupId: ").Append(CatalogGroupId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  MinSelection: ").Append(MinSelection).Append("\n");
            sb.Append("  MaxSelection: ").Append(MaxSelection).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as CatalogGroup);
        }

        /// <summary>
        /// Returns true if CatalogGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatalogGroupId == input.CatalogGroupId ||
                    (this.CatalogGroupId != null &&
                    this.CatalogGroupId.Equals(input.CatalogGroupId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsArchived == input.IsArchived ||
                    (this.IsArchived != null &&
                    this.IsArchived.Equals(input.IsArchived))
                ) && 
                (
                    this.MinSelection == input.MinSelection ||
                    (this.MinSelection != null &&
                    this.MinSelection.Equals(input.MinSelection))
                ) && 
                (
                    this.MaxSelection == input.MaxSelection ||
                    (this.MaxSelection != null &&
                    this.MaxSelection.Equals(input.MaxSelection))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.CatalogGroupId != null)
                    hashCode = hashCode * 59 + this.CatalogGroupId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsArchived != null)
                    hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                if (this.MinSelection != null)
                    hashCode = hashCode * 59 + this.MinSelection.GetHashCode();
                if (this.MaxSelection != null)
                    hashCode = hashCode * 59 + this.MaxSelection.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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

            // Sku (string) maxLength
            if(this.Sku != null && this.Sku.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sku, length must be less than 30.", new [] { "Sku" });
            }

            // Sku (string) minLength
            if(this.Sku != null && this.Sku.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sku, length must be greater than 0.", new [] { "Sku" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}