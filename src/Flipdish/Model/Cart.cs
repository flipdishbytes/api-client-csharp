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
    /// Defines the cart
    /// </summary>
    [DataContract]
    public partial class Cart :  IEquatable<Cart>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        /// <param name="lineItems">Line items from the cart.</param>
        /// <param name="cartAmount">Total cart price.</param>
        /// <param name="tip">Total tip amount.</param>
        public Cart(List<LineItem> lineItems = default(List<LineItem>), Price cartAmount = default(Price), Price tip = default(Price))
        {
            this.LineItems = lineItems;
            this.CartAmount = cartAmount;
            this.Tip = tip;
        }
        
        /// <summary>
        /// Line items from the cart
        /// </summary>
        /// <value>Line items from the cart</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Total cart price
        /// </summary>
        /// <value>Total cart price</value>
        [DataMember(Name="CartAmount", EmitDefaultValue=false)]
        public Price CartAmount { get; set; }

        /// <summary>
        /// Total tip amount
        /// </summary>
        /// <value>Total tip amount</value>
        [DataMember(Name="Tip", EmitDefaultValue=false)]
        public Price Tip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cart {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  CartAmount: ").Append(CartAmount).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
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
            return this.Equals(input as Cart);
        }

        /// <summary>
        /// Returns true if Cart instances are equal
        /// </summary>
        /// <param name="input">Instance of Cart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.CartAmount == input.CartAmount ||
                    (this.CartAmount != null &&
                    this.CartAmount.Equals(input.CartAmount))
                ) && 
                (
                    this.Tip == input.Tip ||
                    (this.Tip != null &&
                    this.Tip.Equals(input.Tip))
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
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.CartAmount != null)
                    hashCode = hashCode * 59 + this.CartAmount.GetHashCode();
                if (this.Tip != null)
                    hashCode = hashCode * 59 + this.Tip.GetHashCode();
                return hashCode;
            }
        }
    }

}
