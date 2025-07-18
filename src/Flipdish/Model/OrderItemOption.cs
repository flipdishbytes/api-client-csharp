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
    /// Order item option
    /// </summary>
    [DataContract]
    public partial class OrderItemOption :  IEquatable<OrderItemOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemOption" /> class.
        /// </summary>
        /// <param name="metadata">Metadata.</param>
        /// <param name="menuItemOptionPublicId">Public id of the Menu Item Option.</param>
        /// <param name="menuItemOptionId">Menu item option identifier.</param>
        /// <param name="isMasterOptionSetItem">Is master option set item.</param>
        /// <param name="name">Name.</param>
        /// <param name="price">Price.</param>
        /// <param name="taxAmount">Tax currency amount.</param>
        /// <param name="menuItemOptionDisplayOrder">Menu item option display order.</param>
        /// <param name="menuItemOptionSetDisplayOrder">Menu item option set display order.</param>
        /// <param name="depositReturnFee">Deposit return fee.</param>
        public OrderItemOption(Dictionary<string, string> metadata = default(Dictionary<string, string>), Guid? menuItemOptionPublicId = default(Guid?), int? menuItemOptionId = default(int?), bool? isMasterOptionSetItem = default(bool?), string name = default(string), double? price = default(double?), double? taxAmount = default(double?), int? menuItemOptionDisplayOrder = default(int?), int? menuItemOptionSetDisplayOrder = default(int?), double? depositReturnFee = default(double?))
        {
            this.Metadata = metadata;
            this.MenuItemOptionPublicId = menuItemOptionPublicId;
            this.MenuItemOptionId = menuItemOptionId;
            this.IsMasterOptionSetItem = isMasterOptionSetItem;
            this.Name = name;
            this.Price = price;
            this.TaxAmount = taxAmount;
            this.MenuItemOptionDisplayOrder = menuItemOptionDisplayOrder;
            this.MenuItemOptionSetDisplayOrder = menuItemOptionSetDisplayOrder;
            this.DepositReturnFee = depositReturnFee;
        }
        
        /// <summary>
        /// Metadata
        /// </summary>
        /// <value>Metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Public id of the Menu Item Option
        /// </summary>
        /// <value>Public id of the Menu Item Option</value>
        [DataMember(Name="MenuItemOptionPublicId", EmitDefaultValue=false)]
        public Guid? MenuItemOptionPublicId { get; set; }

        /// <summary>
        /// Menu item option identifier
        /// </summary>
        /// <value>Menu item option identifier</value>
        [DataMember(Name="MenuItemOptionId", EmitDefaultValue=false)]
        public int? MenuItemOptionId { get; set; }

        /// <summary>
        /// Is master option set item
        /// </summary>
        /// <value>Is master option set item</value>
        [DataMember(Name="IsMasterOptionSetItem", EmitDefaultValue=false)]
        public bool? IsMasterOptionSetItem { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Tax currency amount
        /// </summary>
        /// <value>Tax currency amount</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Menu item option display order
        /// </summary>
        /// <value>Menu item option display order</value>
        [DataMember(Name="MenuItemOptionDisplayOrder", EmitDefaultValue=false)]
        public int? MenuItemOptionDisplayOrder { get; set; }

        /// <summary>
        /// Menu item option set display order
        /// </summary>
        /// <value>Menu item option set display order</value>
        [DataMember(Name="MenuItemOptionSetDisplayOrder", EmitDefaultValue=false)]
        public int? MenuItemOptionSetDisplayOrder { get; set; }

        /// <summary>
        /// Deposit return fee
        /// </summary>
        /// <value>Deposit return fee</value>
        [DataMember(Name="DepositReturnFee", EmitDefaultValue=false)]
        public double? DepositReturnFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemOption {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MenuItemOptionPublicId: ").Append(MenuItemOptionPublicId).Append("\n");
            sb.Append("  MenuItemOptionId: ").Append(MenuItemOptionId).Append("\n");
            sb.Append("  IsMasterOptionSetItem: ").Append(IsMasterOptionSetItem).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  MenuItemOptionDisplayOrder: ").Append(MenuItemOptionDisplayOrder).Append("\n");
            sb.Append("  MenuItemOptionSetDisplayOrder: ").Append(MenuItemOptionSetDisplayOrder).Append("\n");
            sb.Append("  DepositReturnFee: ").Append(DepositReturnFee).Append("\n");
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
            return this.Equals(input as OrderItemOption);
        }

        /// <summary>
        /// Returns true if OrderItemOption instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MenuItemOptionPublicId == input.MenuItemOptionPublicId ||
                    (this.MenuItemOptionPublicId != null &&
                    this.MenuItemOptionPublicId.Equals(input.MenuItemOptionPublicId))
                ) && 
                (
                    this.MenuItemOptionId == input.MenuItemOptionId ||
                    (this.MenuItemOptionId != null &&
                    this.MenuItemOptionId.Equals(input.MenuItemOptionId))
                ) && 
                (
                    this.IsMasterOptionSetItem == input.IsMasterOptionSetItem ||
                    (this.IsMasterOptionSetItem != null &&
                    this.IsMasterOptionSetItem.Equals(input.IsMasterOptionSetItem))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.MenuItemOptionDisplayOrder == input.MenuItemOptionDisplayOrder ||
                    (this.MenuItemOptionDisplayOrder != null &&
                    this.MenuItemOptionDisplayOrder.Equals(input.MenuItemOptionDisplayOrder))
                ) && 
                (
                    this.MenuItemOptionSetDisplayOrder == input.MenuItemOptionSetDisplayOrder ||
                    (this.MenuItemOptionSetDisplayOrder != null &&
                    this.MenuItemOptionSetDisplayOrder.Equals(input.MenuItemOptionSetDisplayOrder))
                ) && 
                (
                    this.DepositReturnFee == input.DepositReturnFee ||
                    (this.DepositReturnFee != null &&
                    this.DepositReturnFee.Equals(input.DepositReturnFee))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.MenuItemOptionPublicId != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionPublicId.GetHashCode();
                if (this.MenuItemOptionId != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionId.GetHashCode();
                if (this.IsMasterOptionSetItem != null)
                    hashCode = hashCode * 59 + this.IsMasterOptionSetItem.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.MenuItemOptionDisplayOrder != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionDisplayOrder.GetHashCode();
                if (this.MenuItemOptionSetDisplayOrder != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetDisplayOrder.GetHashCode();
                if (this.DepositReturnFee != null)
                    hashCode = hashCode * 59 + this.DepositReturnFee.GetHashCode();
                return hashCode;
            }
        }
    }

}
