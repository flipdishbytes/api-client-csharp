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
    /// Menu section
    /// </summary>
    [DataContract]
    public partial class MenuSectionBase :  IEquatable<MenuSectionBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuSectionBase" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DisplayOrder">Display order.</param>
        /// <param name="IsAvailable">Is available.</param>
        /// <param name="IsHiddenFromCustomers">Is hidden from customer. Perhaps when the item is out of stock..</param>
        public MenuSectionBase(string Name = default(string), string Description = default(string), int? DisplayOrder = default(int?), bool? IsAvailable = default(bool?), bool? IsHiddenFromCustomers = default(bool?))
        {
            this.Name = Name;
            this.Description = Description;
            this.DisplayOrder = DisplayOrder;
            this.IsAvailable = IsAvailable;
            this.IsHiddenFromCustomers = IsHiddenFromCustomers;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Display order
        /// </summary>
        /// <value>Display order</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Is available
        /// </summary>
        /// <value>Is available</value>
        [DataMember(Name="IsAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Is hidden from customer. Perhaps when the item is out of stock.
        /// </summary>
        /// <value>Is hidden from customer. Perhaps when the item is out of stock.</value>
        [DataMember(Name="IsHiddenFromCustomers", EmitDefaultValue=false)]
        public bool? IsHiddenFromCustomers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuSectionBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  IsHiddenFromCustomers: ").Append(IsHiddenFromCustomers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as MenuSectionBase);
        }

        /// <summary>
        /// Returns true if MenuSectionBase instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuSectionBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuSectionBase input)
        {
            if (input == null)
                return false;

            return 
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
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    this.IsHiddenFromCustomers == input.IsHiddenFromCustomers ||
                    (this.IsHiddenFromCustomers != null &&
                    this.IsHiddenFromCustomers.Equals(input.IsHiddenFromCustomers))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.IsHiddenFromCustomers != null)
                    hashCode = hashCode * 59 + this.IsHiddenFromCustomers.GetHashCode();
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
