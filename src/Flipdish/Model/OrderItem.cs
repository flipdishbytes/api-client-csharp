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
    /// Order item
    /// </summary>
    [DataContract]
    public partial class OrderItem :  IEquatable<OrderItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        /// <param name="orderItemOptions">Option list.</param>
        /// <param name="metadata">Metadata.</param>
        /// <param name="menuItemPublicId">Public id of the Menu Item.</param>
        /// <param name="menuSectionName">Menu section name.</param>
        /// <param name="menuSectionDisplayOrder">Menu section display order.</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="price">Price.</param>
        /// <param name="taxAmount">Tax currency amount.</param>
        /// <param name="priceIncludingOptionSetItems">Price including option set items.</param>
        /// <param name="menuItemId">Menu item identifier.</param>
        /// <param name="menuItemDisplayOrder">Menu item display order.</param>
        /// <param name="isAvailable">Is available.</param>
        /// <param name="depositReturnFee">Deposit return fee.</param>
        public OrderItem(List<OrderItemOption> orderItemOptions = default(List<OrderItemOption>), Dictionary<string, string> metadata = default(Dictionary<string, string>), Guid? menuItemPublicId = default(Guid?), string menuSectionName = default(string), int? menuSectionDisplayOrder = default(int?), string name = default(string), string description = default(string), double? price = default(double?), double? taxAmount = default(double?), double? priceIncludingOptionSetItems = default(double?), int? menuItemId = default(int?), int? menuItemDisplayOrder = default(int?), bool? isAvailable = default(bool?), double? depositReturnFee = default(double?))
        {
            this.OrderItemOptions = orderItemOptions;
            this.Metadata = metadata;
            this.MenuItemPublicId = menuItemPublicId;
            this.MenuSectionName = menuSectionName;
            this.MenuSectionDisplayOrder = menuSectionDisplayOrder;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.TaxAmount = taxAmount;
            this.PriceIncludingOptionSetItems = priceIncludingOptionSetItems;
            this.MenuItemId = menuItemId;
            this.MenuItemDisplayOrder = menuItemDisplayOrder;
            this.IsAvailable = isAvailable;
            this.DepositReturnFee = depositReturnFee;
        }
        
        /// <summary>
        /// Option list
        /// </summary>
        /// <value>Option list</value>
        [DataMember(Name="OrderItemOptions", EmitDefaultValue=false)]
        public List<OrderItemOption> OrderItemOptions { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        /// <value>Metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Public id of the Menu Item
        /// </summary>
        /// <value>Public id of the Menu Item</value>
        [DataMember(Name="MenuItemPublicId", EmitDefaultValue=false)]
        public Guid? MenuItemPublicId { get; set; }

        /// <summary>
        /// Menu section name
        /// </summary>
        /// <value>Menu section name</value>
        [DataMember(Name="MenuSectionName", EmitDefaultValue=false)]
        public string MenuSectionName { get; set; }

        /// <summary>
        /// Menu section display order
        /// </summary>
        /// <value>Menu section display order</value>
        [DataMember(Name="MenuSectionDisplayOrder", EmitDefaultValue=false)]
        public int? MenuSectionDisplayOrder { get; set; }

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
        /// Price including option set items
        /// </summary>
        /// <value>Price including option set items</value>
        [DataMember(Name="PriceIncludingOptionSetItems", EmitDefaultValue=false)]
        public double? PriceIncludingOptionSetItems { get; set; }

        /// <summary>
        /// Menu item identifier
        /// </summary>
        /// <value>Menu item identifier</value>
        [DataMember(Name="MenuItemId", EmitDefaultValue=false)]
        public int? MenuItemId { get; set; }

        /// <summary>
        /// Menu item display order
        /// </summary>
        /// <value>Menu item display order</value>
        [DataMember(Name="MenuItemDisplayOrder", EmitDefaultValue=false)]
        public int? MenuItemDisplayOrder { get; set; }

        /// <summary>
        /// Is available
        /// </summary>
        /// <value>Is available</value>
        [DataMember(Name="IsAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

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
            sb.Append("class OrderItem {\n");
            sb.Append("  OrderItemOptions: ").Append(OrderItemOptions).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MenuItemPublicId: ").Append(MenuItemPublicId).Append("\n");
            sb.Append("  MenuSectionName: ").Append(MenuSectionName).Append("\n");
            sb.Append("  MenuSectionDisplayOrder: ").Append(MenuSectionDisplayOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  PriceIncludingOptionSetItems: ").Append(PriceIncludingOptionSetItems).Append("\n");
            sb.Append("  MenuItemId: ").Append(MenuItemId).Append("\n");
            sb.Append("  MenuItemDisplayOrder: ").Append(MenuItemDisplayOrder).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
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
            return this.Equals(input as OrderItem);
        }

        /// <summary>
        /// Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderItemOptions == input.OrderItemOptions ||
                    this.OrderItemOptions != null &&
                    this.OrderItemOptions.SequenceEqual(input.OrderItemOptions)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MenuItemPublicId == input.MenuItemPublicId ||
                    (this.MenuItemPublicId != null &&
                    this.MenuItemPublicId.Equals(input.MenuItemPublicId))
                ) && 
                (
                    this.MenuSectionName == input.MenuSectionName ||
                    (this.MenuSectionName != null &&
                    this.MenuSectionName.Equals(input.MenuSectionName))
                ) && 
                (
                    this.MenuSectionDisplayOrder == input.MenuSectionDisplayOrder ||
                    (this.MenuSectionDisplayOrder != null &&
                    this.MenuSectionDisplayOrder.Equals(input.MenuSectionDisplayOrder))
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
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.PriceIncludingOptionSetItems == input.PriceIncludingOptionSetItems ||
                    (this.PriceIncludingOptionSetItems != null &&
                    this.PriceIncludingOptionSetItems.Equals(input.PriceIncludingOptionSetItems))
                ) && 
                (
                    this.MenuItemId == input.MenuItemId ||
                    (this.MenuItemId != null &&
                    this.MenuItemId.Equals(input.MenuItemId))
                ) && 
                (
                    this.MenuItemDisplayOrder == input.MenuItemDisplayOrder ||
                    (this.MenuItemDisplayOrder != null &&
                    this.MenuItemDisplayOrder.Equals(input.MenuItemDisplayOrder))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
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
                if (this.OrderItemOptions != null)
                    hashCode = hashCode * 59 + this.OrderItemOptions.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.MenuItemPublicId != null)
                    hashCode = hashCode * 59 + this.MenuItemPublicId.GetHashCode();
                if (this.MenuSectionName != null)
                    hashCode = hashCode * 59 + this.MenuSectionName.GetHashCode();
                if (this.MenuSectionDisplayOrder != null)
                    hashCode = hashCode * 59 + this.MenuSectionDisplayOrder.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.PriceIncludingOptionSetItems != null)
                    hashCode = hashCode * 59 + this.PriceIncludingOptionSetItems.GetHashCode();
                if (this.MenuItemId != null)
                    hashCode = hashCode * 59 + this.MenuItemId.GetHashCode();
                if (this.MenuItemDisplayOrder != null)
                    hashCode = hashCode * 59 + this.MenuItemDisplayOrder.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.DepositReturnFee != null)
                    hashCode = hashCode * 59 + this.DepositReturnFee.GetHashCode();
                return hashCode;
            }
        }
    }

}
