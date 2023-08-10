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
    /// Menu item
    /// </summary>
    [DataContract]
    public partial class MenuSectionItem :  IEquatable<MenuSectionItem>
    {
        /// <summary>
        /// Spiciness rating
        /// </summary>
        /// <value>Spiciness rating</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SpicinessRatingEnum
        {
            
            /// <summary>
            /// Enum NotRated for value: NotRated
            /// </summary>
            [EnumMember(Value = "NotRated")]
            NotRated = 1,
            
            /// <summary>
            /// Enum Mild for value: Mild
            /// </summary>
            [EnumMember(Value = "Mild")]
            Mild = 2,
            
            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 3,
            
            /// <summary>
            /// Enum Hot for value: Hot
            /// </summary>
            [EnumMember(Value = "Hot")]
            Hot = 4
        }

        /// <summary>
        /// Spiciness rating
        /// </summary>
        /// <value>Spiciness rating</value>
        [DataMember(Name="SpicinessRating", EmitDefaultValue=false)]
        public SpicinessRatingEnum? SpicinessRating { get; set; }
        /// <summary>
        /// Small | Medium | Large  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large  Affects the layout of the menu.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CellLayoutTypeEnum
        {
            
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 1,
            
            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,
            
            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 3,
            
            /// <summary>
            /// Enum HiddenImage for value: HiddenImage
            /// </summary>
            [EnumMember(Value = "HiddenImage")]
            HiddenImage = 4
        }

        /// <summary>
        /// Small | Medium | Large  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large  Affects the layout of the menu.</value>
        [DataMember(Name="CellLayoutType", EmitDefaultValue=false)]
        public CellLayoutTypeEnum? CellLayoutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuSectionItem" /> class.
        /// </summary>
        /// <param name="actualPrice">Actual price - the minimum price possible when all required option set items prices are included..</param>
        /// <param name="menuItemOptionSets">Menu item option sets.</param>
        /// <param name="dailySpecialHours">Daily special hours.</param>
        /// <param name="publicId">Permanent reference to the item..</param>
        /// <param name="taxRateName">Tax rate name.</param>
        /// <param name="taxRateId">TaxRate.</param>
        /// <param name="taxValue">TaxValue - the tax associated with this item, based on TaxRate / TaxType and Currency (currency determines decimal point precision).</param>
        /// <param name="metadata">List of metadata.</param>
        /// <param name="catalogItemId">Catalog item Id when the Item is associated to a Product.</param>
        /// <param name="name">Menu item name (like \&quot;Korma\&quot;).</param>
        /// <param name="description">Description (like \&quot;A lovely dish from the east\&quot;).</param>
        /// <param name="spicinessRating">Spiciness rating.</param>
        /// <param name="price">Price - this is only used when there is no master option set and should be set to 0 if a master option set exists..</param>
        /// <param name="displayOrder">Display order.</param>
        /// <param name="alcohol">To be set true if the item or an option of the item contains an alcoholic drink..</param>
        /// <param name="isAvailable">True if we accept orders for this item still.</param>
        /// <param name="cellLayoutType">Small | Medium | Large  Affects the layout of the menu..</param>
        /// <param name="disableVouchers">If true, then vouchers won&#39;t be applied for this item.</param>
        /// <param name="imageName">Image url.</param>
        /// <param name="imageUrl">Image url.</param>
        /// <param name="menuItemId">Menu Item Id.</param>
        public MenuSectionItem(double? actualPrice = default(double?), List<MenuItemOptionSet> menuItemOptionSets = default(List<MenuItemOptionSet>), List<BusinessHoursPeriod> dailySpecialHours = default(List<BusinessHoursPeriod>), Guid? publicId = default(Guid?), string taxRateName = default(string), int? taxRateId = default(int?), double? taxValue = default(double?), List<CreateMetadata> metadata = default(List<CreateMetadata>), string catalogItemId = default(string), string name = default(string), string description = default(string), SpicinessRatingEnum? spicinessRating = default(SpicinessRatingEnum?), double? price = default(double?), int? displayOrder = default(int?), bool? alcohol = default(bool?), bool? isAvailable = default(bool?), CellLayoutTypeEnum? cellLayoutType = default(CellLayoutTypeEnum?), bool? disableVouchers = default(bool?), string imageName = default(string), string imageUrl = default(string), int? menuItemId = default(int?))
        {
            this.ActualPrice = actualPrice;
            this.MenuItemOptionSets = menuItemOptionSets;
            this.DailySpecialHours = dailySpecialHours;
            this.PublicId = publicId;
            this.TaxRateName = taxRateName;
            this.TaxRateId = taxRateId;
            this.TaxValue = taxValue;
            this.Metadata = metadata;
            this.CatalogItemId = catalogItemId;
            this.Name = name;
            this.Description = description;
            this.SpicinessRating = spicinessRating;
            this.Price = price;
            this.DisplayOrder = displayOrder;
            this.Alcohol = alcohol;
            this.IsAvailable = isAvailable;
            this.CellLayoutType = cellLayoutType;
            this.DisableVouchers = disableVouchers;
            this.ImageName = imageName;
            this.ImageUrl = imageUrl;
            this.MenuItemId = menuItemId;
        }
        
        /// <summary>
        /// Actual price - the minimum price possible when all required option set items prices are included.
        /// </summary>
        /// <value>Actual price - the minimum price possible when all required option set items prices are included.</value>
        [DataMember(Name="ActualPrice", EmitDefaultValue=false)]
        public double? ActualPrice { get; set; }

        /// <summary>
        /// Menu item option sets
        /// </summary>
        /// <value>Menu item option sets</value>
        [DataMember(Name="MenuItemOptionSets", EmitDefaultValue=false)]
        public List<MenuItemOptionSet> MenuItemOptionSets { get; set; }

        /// <summary>
        /// Daily special hours
        /// </summary>
        /// <value>Daily special hours</value>
        [DataMember(Name="DailySpecialHours", EmitDefaultValue=false)]
        public List<BusinessHoursPeriod> DailySpecialHours { get; set; }

        /// <summary>
        /// Permanent reference to the item.
        /// </summary>
        /// <value>Permanent reference to the item.</value>
        [DataMember(Name="PublicId", EmitDefaultValue=false)]
        public Guid? PublicId { get; set; }

        /// <summary>
        /// Tax rate name
        /// </summary>
        /// <value>Tax rate name</value>
        [DataMember(Name="TaxRateName", EmitDefaultValue=false)]
        public string TaxRateName { get; set; }

        /// <summary>
        /// TaxRate
        /// </summary>
        /// <value>TaxRate</value>
        [DataMember(Name="TaxRateId", EmitDefaultValue=false)]
        public int? TaxRateId { get; set; }

        /// <summary>
        /// TaxValue - the tax associated with this item, based on TaxRate / TaxType and Currency (currency determines decimal point precision)
        /// </summary>
        /// <value>TaxValue - the tax associated with this item, based on TaxRate / TaxType and Currency (currency determines decimal point precision)</value>
        [DataMember(Name="TaxValue", EmitDefaultValue=false)]
        public double? TaxValue { get; set; }

        /// <summary>
        /// List of metadata
        /// </summary>
        /// <value>List of metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public List<CreateMetadata> Metadata { get; set; }

        /// <summary>
        /// Catalog item Id when the Item is associated to a Product
        /// </summary>
        /// <value>Catalog item Id when the Item is associated to a Product</value>
        [DataMember(Name="CatalogItemId", EmitDefaultValue=false)]
        public string CatalogItemId { get; set; }

        /// <summary>
        /// Menu item name (like \&quot;Korma\&quot;)
        /// </summary>
        /// <value>Menu item name (like \&quot;Korma\&quot;)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description (like \&quot;A lovely dish from the east\&quot;)
        /// </summary>
        /// <value>Description (like \&quot;A lovely dish from the east\&quot;)</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Price - this is only used when there is no master option set and should be set to 0 if a master option set exists.
        /// </summary>
        /// <value>Price - this is only used when there is no master option set and should be set to 0 if a master option set exists.</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Display order
        /// </summary>
        /// <value>Display order</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// To be set true if the item or an option of the item contains an alcoholic drink.
        /// </summary>
        /// <value>To be set true if the item or an option of the item contains an alcoholic drink.</value>
        [DataMember(Name="Alcohol", EmitDefaultValue=false)]
        public bool? Alcohol { get; set; }

        /// <summary>
        /// True if we accept orders for this item still
        /// </summary>
        /// <value>True if we accept orders for this item still</value>
        [DataMember(Name="IsAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }


        /// <summary>
        /// If true, then vouchers won&#39;t be applied for this item
        /// </summary>
        /// <value>If true, then vouchers won&#39;t be applied for this item</value>
        [DataMember(Name="DisableVouchers", EmitDefaultValue=false)]
        public bool? DisableVouchers { get; set; }

        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageName", EmitDefaultValue=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Menu Item Id
        /// </summary>
        /// <value>Menu Item Id</value>
        [DataMember(Name="MenuItemId", EmitDefaultValue=false)]
        public int? MenuItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuSectionItem {\n");
            sb.Append("  ActualPrice: ").Append(ActualPrice).Append("\n");
            sb.Append("  MenuItemOptionSets: ").Append(MenuItemOptionSets).Append("\n");
            sb.Append("  DailySpecialHours: ").Append(DailySpecialHours).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  TaxRateId: ").Append(TaxRateId).Append("\n");
            sb.Append("  TaxValue: ").Append(TaxValue).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CatalogItemId: ").Append(CatalogItemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SpicinessRating: ").Append(SpicinessRating).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Alcohol: ").Append(Alcohol).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  CellLayoutType: ").Append(CellLayoutType).Append("\n");
            sb.Append("  DisableVouchers: ").Append(DisableVouchers).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  MenuItemId: ").Append(MenuItemId).Append("\n");
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
            return this.Equals(input as MenuSectionItem);
        }

        /// <summary>
        /// Returns true if MenuSectionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuSectionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuSectionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActualPrice == input.ActualPrice ||
                    (this.ActualPrice != null &&
                    this.ActualPrice.Equals(input.ActualPrice))
                ) && 
                (
                    this.MenuItemOptionSets == input.MenuItemOptionSets ||
                    this.MenuItemOptionSets != null &&
                    this.MenuItemOptionSets.SequenceEqual(input.MenuItemOptionSets)
                ) && 
                (
                    this.DailySpecialHours == input.DailySpecialHours ||
                    this.DailySpecialHours != null &&
                    this.DailySpecialHours.SequenceEqual(input.DailySpecialHours)
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.TaxRateName == input.TaxRateName ||
                    (this.TaxRateName != null &&
                    this.TaxRateName.Equals(input.TaxRateName))
                ) && 
                (
                    this.TaxRateId == input.TaxRateId ||
                    (this.TaxRateId != null &&
                    this.TaxRateId.Equals(input.TaxRateId))
                ) && 
                (
                    this.TaxValue == input.TaxValue ||
                    (this.TaxValue != null &&
                    this.TaxValue.Equals(input.TaxValue))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.CatalogItemId == input.CatalogItemId ||
                    (this.CatalogItemId != null &&
                    this.CatalogItemId.Equals(input.CatalogItemId))
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
                    this.SpicinessRating == input.SpicinessRating ||
                    (this.SpicinessRating != null &&
                    this.SpicinessRating.Equals(input.SpicinessRating))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.Alcohol == input.Alcohol ||
                    (this.Alcohol != null &&
                    this.Alcohol.Equals(input.Alcohol))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    this.CellLayoutType == input.CellLayoutType ||
                    (this.CellLayoutType != null &&
                    this.CellLayoutType.Equals(input.CellLayoutType))
                ) && 
                (
                    this.DisableVouchers == input.DisableVouchers ||
                    (this.DisableVouchers != null &&
                    this.DisableVouchers.Equals(input.DisableVouchers))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MenuItemId == input.MenuItemId ||
                    (this.MenuItemId != null &&
                    this.MenuItemId.Equals(input.MenuItemId))
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
                if (this.ActualPrice != null)
                    hashCode = hashCode * 59 + this.ActualPrice.GetHashCode();
                if (this.MenuItemOptionSets != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSets.GetHashCode();
                if (this.DailySpecialHours != null)
                    hashCode = hashCode * 59 + this.DailySpecialHours.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.TaxRateName != null)
                    hashCode = hashCode * 59 + this.TaxRateName.GetHashCode();
                if (this.TaxRateId != null)
                    hashCode = hashCode * 59 + this.TaxRateId.GetHashCode();
                if (this.TaxValue != null)
                    hashCode = hashCode * 59 + this.TaxValue.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.CatalogItemId != null)
                    hashCode = hashCode * 59 + this.CatalogItemId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SpicinessRating != null)
                    hashCode = hashCode * 59 + this.SpicinessRating.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.Alcohol != null)
                    hashCode = hashCode * 59 + this.Alcohol.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.CellLayoutType != null)
                    hashCode = hashCode * 59 + this.CellLayoutType.GetHashCode();
                if (this.DisableVouchers != null)
                    hashCode = hashCode * 59 + this.DisableVouchers.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MenuItemId != null)
                    hashCode = hashCode * 59 + this.MenuItemId.GetHashCode();
                return hashCode;
            }
        }
    }

}
