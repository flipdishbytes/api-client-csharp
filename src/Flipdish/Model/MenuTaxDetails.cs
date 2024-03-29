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
    /// Tax information for Menu
    /// </summary>
    [DataContract]
    public partial class MenuTaxDetails :  IEquatable<MenuTaxDetails>
    {
        /// <summary>
        /// TaxType
        /// </summary>
        /// <value>TaxType</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxTypeEnum
        {
            
            /// <summary>
            /// Enum IncludedInBasePrice for value: IncludedInBasePrice
            /// </summary>
            [EnumMember(Value = "IncludedInBasePrice")]
            IncludedInBasePrice = 1,
            
            /// <summary>
            /// Enum ExcludedFromBasePrice for value: ExcludedFromBasePrice
            /// </summary>
            [EnumMember(Value = "ExcludedFromBasePrice")]
            ExcludedFromBasePrice = 2
        }

        /// <summary>
        /// TaxType
        /// </summary>
        /// <value>TaxType</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public TaxTypeEnum? TaxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuTaxDetails" /> class.
        /// </summary>
        /// <param name="taxRates">Tax Rates.</param>
        /// <param name="displayTax">Display tax for Menu.</param>
        /// <param name="taxType">TaxType.</param>
        /// <param name="itemTaxes">ItemIds and TaxIds.</param>
        /// <param name="setItemTaxes">SetItemIds and TaxIds.</param>
        public MenuTaxDetails(List<MenuTaxRate> taxRates = default(List<MenuTaxRate>), bool? displayTax = default(bool?), TaxTypeEnum? taxType = default(TaxTypeEnum?), Dictionary<string, int?> itemTaxes = default(Dictionary<string, int?>), Dictionary<string, int?> setItemTaxes = default(Dictionary<string, int?>))
        {
            this.TaxRates = taxRates;
            this.DisplayTax = displayTax;
            this.TaxType = taxType;
            this.ItemTaxes = itemTaxes;
            this.SetItemTaxes = setItemTaxes;
        }
        
        /// <summary>
        /// Tax Rates
        /// </summary>
        /// <value>Tax Rates</value>
        [DataMember(Name="TaxRates", EmitDefaultValue=false)]
        public List<MenuTaxRate> TaxRates { get; set; }

        /// <summary>
        /// Display tax for Menu
        /// </summary>
        /// <value>Display tax for Menu</value>
        [DataMember(Name="DisplayTax", EmitDefaultValue=false)]
        public bool? DisplayTax { get; set; }


        /// <summary>
        /// ItemIds and TaxIds
        /// </summary>
        /// <value>ItemIds and TaxIds</value>
        [DataMember(Name="ItemTaxes", EmitDefaultValue=false)]
        public Dictionary<string, int?> ItemTaxes { get; set; }

        /// <summary>
        /// SetItemIds and TaxIds
        /// </summary>
        /// <value>SetItemIds and TaxIds</value>
        [DataMember(Name="SetItemTaxes", EmitDefaultValue=false)]
        public Dictionary<string, int?> SetItemTaxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuTaxDetails {\n");
            sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
            sb.Append("  DisplayTax: ").Append(DisplayTax).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  ItemTaxes: ").Append(ItemTaxes).Append("\n");
            sb.Append("  SetItemTaxes: ").Append(SetItemTaxes).Append("\n");
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
            return this.Equals(input as MenuTaxDetails);
        }

        /// <summary>
        /// Returns true if MenuTaxDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuTaxDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuTaxDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaxRates == input.TaxRates ||
                    this.TaxRates != null &&
                    this.TaxRates.SequenceEqual(input.TaxRates)
                ) && 
                (
                    this.DisplayTax == input.DisplayTax ||
                    (this.DisplayTax != null &&
                    this.DisplayTax.Equals(input.DisplayTax))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.ItemTaxes == input.ItemTaxes ||
                    this.ItemTaxes != null &&
                    this.ItemTaxes.SequenceEqual(input.ItemTaxes)
                ) && 
                (
                    this.SetItemTaxes == input.SetItemTaxes ||
                    this.SetItemTaxes != null &&
                    this.SetItemTaxes.SequenceEqual(input.SetItemTaxes)
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
                if (this.TaxRates != null)
                    hashCode = hashCode * 59 + this.TaxRates.GetHashCode();
                if (this.DisplayTax != null)
                    hashCode = hashCode * 59 + this.DisplayTax.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.ItemTaxes != null)
                    hashCode = hashCode * 59 + this.ItemTaxes.GetHashCode();
                if (this.SetItemTaxes != null)
                    hashCode = hashCode * 59 + this.SetItemTaxes.GetHashCode();
                return hashCode;
            }
        }
    }

}
