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
    /// Create a Catalog Item
    /// </summary>
    [DataContract]
    public partial class CreateCatalogItem :  IEquatable<CreateCatalogItem>
    {
        /// <summary>
        /// Type of item (Product, Modifier, etc)
        /// </summary>
        /// <value>Type of item (Product, Modifier, etc)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            
            /// <summary>
            /// Enum Product for value: Product
            /// </summary>
            [EnumMember(Value = "Product")]
            Product = 1,
            
            /// <summary>
            /// Enum Modifier for value: Modifier
            /// </summary>
            [EnumMember(Value = "Modifier")]
            Modifier = 2
        }

        /// <summary>
        /// Type of item (Product, Modifier, etc)
        /// </summary>
        /// <value>Type of item (Product, Modifier, etc)</value>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public ItemTypeEnum ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCatalogItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogItem" /> class.
        /// </summary>
        /// <param name="groups">Collection of groups associated with this item.</param>
        /// <param name="metafields">Collection of metafields.</param>
        /// <param name="itemType">Type of item (Product, Modifier, etc) (required).</param>
        /// <param name="sku">Stock Keeping Unit (SKU) (required).</param>
        /// <param name="name">Item name (required).</param>
        /// <param name="description">Item description.</param>
        /// <param name="price">Item price (required).</param>
        /// <param name="imageFileName">Image File Name.</param>
        /// <param name="alcohol">item contains alcohol.</param>
        public CreateCatalogItem(List<CreateCatalogGroupReference> groups = default(List<CreateCatalogGroupReference>), List<Metafield> metafields = default(List<Metafield>), ItemTypeEnum itemType = default(ItemTypeEnum), string sku = default(string), string name = default(string), string description = default(string), double? price = default(double?), string imageFileName = default(string), bool? alcohol = default(bool?))
        {
            // to ensure "itemType" is required (not null)
            if (itemType == null)
            {
                throw new InvalidDataException("itemType is a required property for CreateCatalogItem and cannot be null");
            }
            else
            {
                this.ItemType = itemType;
            }
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for CreateCatalogItem and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateCatalogItem and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for CreateCatalogItem and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            this.Groups = groups;
            this.Metafields = metafields;
            this.Description = description;
            this.ImageFileName = imageFileName;
            this.Alcohol = alcohol;
        }
        
        /// <summary>
        /// Collection of groups associated with this item
        /// </summary>
        /// <value>Collection of groups associated with this item</value>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public List<CreateCatalogGroupReference> Groups { get; set; }

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
        /// Item name
        /// </summary>
        /// <value>Item name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        /// <value>Item description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Item price
        /// </summary>
        /// <value>Item price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Image File Name
        /// </summary>
        /// <value>Image File Name</value>
        [DataMember(Name="ImageFileName", EmitDefaultValue=false)]
        public string ImageFileName { get; set; }

        /// <summary>
        /// item contains alcohol
        /// </summary>
        /// <value>item contains alcohol</value>
        [DataMember(Name="Alcohol", EmitDefaultValue=false)]
        public bool? Alcohol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCatalogItem {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Metafields: ").Append(Metafields).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ImageFileName: ").Append(ImageFileName).Append("\n");
            sb.Append("  Alcohol: ").Append(Alcohol).Append("\n");
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
            return this.Equals(input as CreateCatalogItem);
        }

        /// <summary>
        /// Returns true if CreateCatalogItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCatalogItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCatalogItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Metafields == input.Metafields ||
                    this.Metafields != null &&
                    this.Metafields.SequenceEqual(input.Metafields)
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.ImageFileName == input.ImageFileName ||
                    (this.ImageFileName != null &&
                    this.ImageFileName.Equals(input.ImageFileName))
                ) && 
                (
                    this.Alcohol == input.Alcohol ||
                    (this.Alcohol != null &&
                    this.Alcohol.Equals(input.Alcohol))
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Metafields != null)
                    hashCode = hashCode * 59 + this.Metafields.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.ImageFileName != null)
                    hashCode = hashCode * 59 + this.ImageFileName.GetHashCode();
                if (this.Alcohol != null)
                    hashCode = hashCode * 59 + this.Alcohol.GetHashCode();
                return hashCode;
            }
        }
    }

}
