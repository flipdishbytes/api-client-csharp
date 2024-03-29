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
    /// CatalogGroup
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>
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
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Group() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="catalogGroupId">Unique catalog group id.</param>
        /// <param name="catalogItemId">Unique catalog item id.</param>
        /// <param name="isArchived">Returns true if the group is archived.</param>
        /// <param name="minSelectCount">Minimum number of items that the user has to select.</param>
        /// <param name="maxSelectCount">Maximum number of items that the user has to select.</param>
        /// <param name="products">Collection of items associated with this product.</param>
        /// <param name="metafields">Collection of metafields.</param>
        /// <param name="groupType">Type of group (ModifierGroup, etc) (required).</param>
        /// <param name="sku">Stock Keeping Unit (SKU) (required).</param>
        /// <param name="name">Group name (required).</param>
        /// <param name="autogenerateDisplayText">Autogenerate display text in ordering applications.</param>
        /// <param name="imageFileName">Image File Name.</param>
        public Group(string catalogGroupId = default(string), string catalogItemId = default(string), bool? isArchived = default(bool?), int? minSelectCount = default(int?), int? maxSelectCount = default(int?), List<ProductReference> products = default(List<ProductReference>), List<Metafield> metafields = default(List<Metafield>), GroupTypeEnum groupType = default(GroupTypeEnum), string sku = default(string), string name = default(string), bool? autogenerateDisplayText = default(bool?), string imageFileName = default(string))
        {
            // to ensure "groupType" is required (not null)
            if (groupType == null)
            {
                throw new InvalidDataException("groupType is a required property for Group and cannot be null");
            }
            else
            {
                this.GroupType = groupType;
            }
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for Group and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Group and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.CatalogGroupId = catalogGroupId;
            this.CatalogItemId = catalogItemId;
            this.IsArchived = isArchived;
            this.MinSelectCount = minSelectCount;
            this.MaxSelectCount = maxSelectCount;
            this.Products = products;
            this.Metafields = metafields;
            this.AutogenerateDisplayText = autogenerateDisplayText;
            this.ImageFileName = imageFileName;
        }
        
        /// <summary>
        /// Unique catalog group id
        /// </summary>
        /// <value>Unique catalog group id</value>
        [DataMember(Name="CatalogGroupId", EmitDefaultValue=false)]
        public string CatalogGroupId { get; set; }

        /// <summary>
        /// Unique catalog item id
        /// </summary>
        /// <value>Unique catalog item id</value>
        [DataMember(Name="CatalogItemId", EmitDefaultValue=false)]
        public string CatalogItemId { get; set; }

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
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<ProductReference> Products { get; set; }

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
        /// Autogenerate display text in ordering applications
        /// </summary>
        /// <value>Autogenerate display text in ordering applications</value>
        [DataMember(Name="AutogenerateDisplayText", EmitDefaultValue=false)]
        public bool? AutogenerateDisplayText { get; set; }

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
            sb.Append("class Group {\n");
            sb.Append("  CatalogGroupId: ").Append(CatalogGroupId).Append("\n");
            sb.Append("  CatalogItemId: ").Append(CatalogItemId).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  MinSelectCount: ").Append(MinSelectCount).Append("\n");
            sb.Append("  MaxSelectCount: ").Append(MaxSelectCount).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Metafields: ").Append(Metafields).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AutogenerateDisplayText: ").Append(AutogenerateDisplayText).Append("\n");
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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
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
                    this.CatalogItemId == input.CatalogItemId ||
                    (this.CatalogItemId != null &&
                    this.CatalogItemId.Equals(input.CatalogItemId))
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
                    this.Products == input.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(input.Products)
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
                    this.AutogenerateDisplayText == input.AutogenerateDisplayText ||
                    (this.AutogenerateDisplayText != null &&
                    this.AutogenerateDisplayText.Equals(input.AutogenerateDisplayText))
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
                if (this.CatalogItemId != null)
                    hashCode = hashCode * 59 + this.CatalogItemId.GetHashCode();
                if (this.IsArchived != null)
                    hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                if (this.MinSelectCount != null)
                    hashCode = hashCode * 59 + this.MinSelectCount.GetHashCode();
                if (this.MaxSelectCount != null)
                    hashCode = hashCode * 59 + this.MaxSelectCount.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Metafields != null)
                    hashCode = hashCode * 59 + this.Metafields.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AutogenerateDisplayText != null)
                    hashCode = hashCode * 59 + this.AutogenerateDisplayText.GetHashCode();
                if (this.ImageFileName != null)
                    hashCode = hashCode * 59 + this.ImageFileName.GetHashCode();
                return hashCode;
            }
        }
    }

}
