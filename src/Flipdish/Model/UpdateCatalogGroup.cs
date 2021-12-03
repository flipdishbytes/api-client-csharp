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
    /// Update Catalog Group
    /// </summary>
    [DataContract]
    public partial class UpdateCatalogGroup :  IEquatable<UpdateCatalogGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogGroup" /> class.
        /// </summary>
        /// <param name="sku">Stock Keeping Unit (SKU).</param>
        /// <param name="name">Group name.</param>
        /// <param name="minSelectCount">Minimum number of items that the user has to select.</param>
        /// <param name="maxSelectCount">Maximum number of items that the user has to select.</param>
        /// <param name="items">Collection of items associated with this group.</param>
        public UpdateCatalogGroup(string sku = default(string), string name = default(string), int? minSelectCount = default(int?), int? maxSelectCount = default(int?), List<UpdateCatalogItemReference> items = default(List<UpdateCatalogItemReference>))
        {
            this.Sku = sku;
            this.Name = name;
            this.MinSelectCount = minSelectCount;
            this.MaxSelectCount = maxSelectCount;
            this.Items = items;
        }
        
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
        /// Collection of items associated with this group
        /// </summary>
        /// <value>Collection of items associated with this group</value>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<UpdateCatalogItemReference> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCatalogGroup {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinSelectCount: ").Append(MinSelectCount).Append("\n");
            sb.Append("  MaxSelectCount: ").Append(MaxSelectCount).Append("\n");
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
            return this.Equals(input as UpdateCatalogGroup);
        }

        /// <summary>
        /// Returns true if UpdateCatalogGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCatalogGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCatalogGroup input)
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
                if (this.MinSelectCount != null)
                    hashCode = hashCode * 59 + this.MinSelectCount.GetHashCode();
                if (this.MaxSelectCount != null)
                    hashCode = hashCode * 59 + this.MaxSelectCount.GetHashCode();
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
