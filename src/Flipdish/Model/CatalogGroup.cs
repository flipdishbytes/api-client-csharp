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
        /// Type of group (ModifierGroup, etc)
        /// </summary>
        /// <value>Type of group (ModifierGroup, etc)</value>
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
        /// Type of group (ModifierGroup, etc)
        /// </summary>
        /// <value>Type of group (ModifierGroup, etc)</value>
        [DataMember(Name="GroupType", EmitDefaultValue=false)]
        public GroupTypeEnum GroupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogGroup" /> class.
        /// </summary>
        /// <param name="catalogGroupId">Unique catalog group id.</param>
        /// <param name="isArchived">Returns true if the group is archived.</param>
        /// <param name="minSelectCount">Minimum number of items that the user has to select.</param>
        /// <param name="maxSelectCount">Maximum number of items that the user has to select.</param>
        /// <param name="items">Collection of items associated with this product.</param>
        /// <param name="metafields">Collection of metafields.</param>
        /// <param name="groupType">Type of group (ModifierGroup, etc) (required).</param>
        /// <param name="sku">Stock Keeping Unit (SKU) (required).</param>
        /// <param name="name">Group name (required).</param>
        /// <param name="imageFileName">Image File Name.</param>
        public CatalogGroup(string catalogGroupId = default(string), bool? isArchived = default(bool?), int? minSelectCount = default(int?), int? maxSelectCount = default(int?), List<CatalogItemReference> items = default(List<CatalogItemReference>), List<Metafield> metafields = default(List<Metafield>), GroupTypeEnum groupType = default(GroupTypeEnum), string sku = default(string), string name = default(string), string imageFileName = default(string))
        {
            // to ensure "groupType" is required (not null)
            if (groupType == null)
            {
                throw new InvalidDataException("groupType is a required property for CatalogGroup and cannot be null");
            }
            else
            {
                this.GroupType = groupType;
            }
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for CatalogGroup and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CatalogGroup and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.CatalogGroupId = catalogGroupId;
            this.IsArchived = isArchived;
            this.MinSelectCount = minSelectCount;
            this.MaxSelectCount = maxSelectCount;
            this.Items = items;
            this.Metafields = metafields;
            this.ImageFileName = imageFileName;
        }
        
        /// <summary>
        /// Unique catalog group id
        /// </summary>
        /// <value>Unique catalog group id</value>
        [DataMember(Name="CatalogGroupId", EmitDefaultValue=false)]
        public string CatalogGroupId { get; set; }

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
        [DataMember(Name="MinSelectCount", EmitDefaultValue=false)]
        public int? MinSelectCount { get; set; }

        /// <summary>
        /// Maximum number of items that the user has to select
        /// </summary>
        /// <value>Maximum number of items that the user has to select</value>
        [DataMember(Name="MaxSelectCount", EmitDefaultValue=false)]
        public int? MaxSelectCount { get; set; }

        /// <summary>
        /// Collection of items associated with this product
        /// </summary>
        /// <value>Collection of items associated with this product</value>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<CatalogItemReference> Items { get; set; }

        /// <summary>
        /// Collection of metafields
        /// </summary>
        /// <value>Collection of metafields</value>
        [DataMember(Name="Metafields", EmitDefaultValue=false)]
        public List<Metafield> Metafields { get; set; }


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
        /// Image File Name
        /// </summary>
        /// <value>Image File Name</value>
        [DataMember(Name="ImageFileName", EmitDefaultValue=false)]
        public string ImageFileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogGroup {\n");
            sb.Append("  CatalogGroupId: ").Append(CatalogGroupId).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  MinSelectCount: ").Append(MinSelectCount).Append("\n");
            sb.Append("  MaxSelectCount: ").Append(MaxSelectCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Metafields: ").Append(Metafields).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageFileName: ").Append(ImageFileName).Append("\n");
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
                    this.IsArchived == input.IsArchived ||
                    (this.IsArchived != null &&
                    this.IsArchived.Equals(input.IsArchived))
                ) && 
                (
                    this.MinSelectCount == input.MinSelectCount ||
                    (this.MinSelectCount != null &&
                    this.MinSelectCount.Equals(input.MinSelectCount))
                ) && 
                (
                    this.MaxSelectCount == input.MaxSelectCount ||
                    (this.MaxSelectCount != null &&
                    this.MaxSelectCount.Equals(input.MaxSelectCount))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Metafields == input.Metafields ||
                    this.Metafields != null &&
                    this.Metafields.SequenceEqual(input.Metafields)
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
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
                    this.ImageFileName == input.ImageFileName ||
                    (this.ImageFileName != null &&
                    this.ImageFileName.Equals(input.ImageFileName))
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
                if (this.IsArchived != null)
                    hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                if (this.MinSelectCount != null)
                    hashCode = hashCode * 59 + this.MinSelectCount.GetHashCode();
                if (this.MaxSelectCount != null)
                    hashCode = hashCode * 59 + this.MaxSelectCount.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Metafields != null)
                    hashCode = hashCode * 59 + this.Metafields.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ImageFileName != null)
                    hashCode = hashCode * 59 + this.ImageFileName.GetHashCode();
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

            // ImageFileName (string) maxLength
            if(this.ImageFileName != null && this.ImageFileName.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageFileName, length must be less than 512.", new [] { "ImageFileName" });
            }

            // ImageFileName (string) minLength
            if(this.ImageFileName != null && this.ImageFileName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageFileName, length must be greater than 0.", new [] { "ImageFileName" });
            }

            yield break;
        }
    }

}
