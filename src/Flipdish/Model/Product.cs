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
    /// Product Information
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="productId">Unique product id.</param>
        /// <param name="sku">Stock Keeping Unit (SKU).</param>
        /// <param name="name">Product name.</param>
        /// <param name="description">Product description.</param>
        /// <param name="price">Product price.</param>
        public Product(string productId = default(string), string sku = default(string), string name = default(string), string description = default(string), double? price = default(double?))
        {
            this.ProductId = productId;
            this.Sku = sku;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        
        /// <summary>
        /// Unique product id
        /// </summary>
        /// <value>Unique product id</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Stock Keeping Unit (SKU)
        /// </summary>
        /// <value>Stock Keeping Unit (SKU)</value>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        /// <value>Product name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        /// <value>Product description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        /// <value>Product price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
