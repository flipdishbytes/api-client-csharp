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
    /// Update Product
    /// </summary>
    [DataContract]
    public partial class UpdateProduct :  IEquatable<UpdateProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProduct" /> class.
        /// </summary>
        /// <param name="sku">Stock Keeping Unit (SKU).</param>
        /// <param name="name">Product name.</param>
        /// <param name="description">Product description.</param>
        /// <param name="price">Product price.</param>
        /// <param name="alcohol">Product contains alcohol.</param>
        public UpdateProduct(string sku = default(string), string name = default(string), string description = default(string), double? price = default(double?), bool? alcohol = default(bool?))
        {
            this.Sku = sku;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Alcohol = alcohol;
        }
        
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
        /// Product contains alcohol
        /// </summary>
        /// <value>Product contains alcohol</value>
        [DataMember(Name="Alcohol", EmitDefaultValue=false)]
        public bool? Alcohol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProduct {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as UpdateProduct);
        }

        /// <summary>
        /// Returns true if UpdateProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProduct input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Alcohol != null)
                    hashCode = hashCode * 59 + this.Alcohol.GetHashCode();
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

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Price (double?) minimum
            if(this.Price < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Price, must be a value greater than or equal to 0.", new [] { "Price" });
            }

            yield break;
        }
    }

}
