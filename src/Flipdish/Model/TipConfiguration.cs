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
    /// Describes the configuration of tipping
    /// </summary>
    [DataContract]
    public partial class TipConfiguration :  IEquatable<TipConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipConfiguration" /> class.
        /// </summary>
        /// <param name="storeId">Configuration is for this StoreId.</param>
        /// <param name="isEnabled">Are tips enabled?.</param>
        /// <param name="allowCustomTips">Are custom tips allowed?.</param>
        /// <param name="allowRoundUp">Is round up allowed?.</param>
        /// <param name="allowEmojis">Are emojis allowed?.</param>
        /// <param name="percentages">Ordered list of tip breakpoints (smallest -&amp;gt; largest).</param>
        /// <param name="defaultPercentage">Defines a default percentage, it must be in the list of Percentages.</param>
        public TipConfiguration(int? storeId = default(int?), bool? isEnabled = default(bool?), bool? allowCustomTips = default(bool?), bool? allowRoundUp = default(bool?), bool? allowEmojis = default(bool?), List<double?> percentages = default(List<double?>), double? defaultPercentage = default(double?))
        {
            this.StoreId = storeId;
            this.IsEnabled = isEnabled;
            this.AllowCustomTips = allowCustomTips;
            this.AllowRoundUp = allowRoundUp;
            this.AllowEmojis = allowEmojis;
            this.Percentages = percentages;
            this.DefaultPercentage = defaultPercentage;
        }
        
        /// <summary>
        /// Configuration is for this StoreId
        /// </summary>
        /// <value>Configuration is for this StoreId</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Are tips enabled?
        /// </summary>
        /// <value>Are tips enabled?</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Are custom tips allowed?
        /// </summary>
        /// <value>Are custom tips allowed?</value>
        [DataMember(Name="AllowCustomTips", EmitDefaultValue=false)]
        public bool? AllowCustomTips { get; set; }

        /// <summary>
        /// Is round up allowed?
        /// </summary>
        /// <value>Is round up allowed?</value>
        [DataMember(Name="AllowRoundUp", EmitDefaultValue=false)]
        public bool? AllowRoundUp { get; set; }

        /// <summary>
        /// Are emojis allowed?
        /// </summary>
        /// <value>Are emojis allowed?</value>
        [DataMember(Name="AllowEmojis", EmitDefaultValue=false)]
        public bool? AllowEmojis { get; set; }

        /// <summary>
        /// Ordered list of tip breakpoints (smallest -&amp;gt; largest)
        /// </summary>
        /// <value>Ordered list of tip breakpoints (smallest -&amp;gt; largest)</value>
        [DataMember(Name="Percentages", EmitDefaultValue=false)]
        public List<double?> Percentages { get; set; }

        /// <summary>
        /// Defines a default percentage, it must be in the list of Percentages
        /// </summary>
        /// <value>Defines a default percentage, it must be in the list of Percentages</value>
        [DataMember(Name="DefaultPercentage", EmitDefaultValue=false)]
        public double? DefaultPercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipConfiguration {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  AllowCustomTips: ").Append(AllowCustomTips).Append("\n");
            sb.Append("  AllowRoundUp: ").Append(AllowRoundUp).Append("\n");
            sb.Append("  AllowEmojis: ").Append(AllowEmojis).Append("\n");
            sb.Append("  Percentages: ").Append(Percentages).Append("\n");
            sb.Append("  DefaultPercentage: ").Append(DefaultPercentage).Append("\n");
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
            return this.Equals(input as TipConfiguration);
        }

        /// <summary>
        /// Returns true if TipConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of TipConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.AllowCustomTips == input.AllowCustomTips ||
                    (this.AllowCustomTips != null &&
                    this.AllowCustomTips.Equals(input.AllowCustomTips))
                ) && 
                (
                    this.AllowRoundUp == input.AllowRoundUp ||
                    (this.AllowRoundUp != null &&
                    this.AllowRoundUp.Equals(input.AllowRoundUp))
                ) && 
                (
                    this.AllowEmojis == input.AllowEmojis ||
                    (this.AllowEmojis != null &&
                    this.AllowEmojis.Equals(input.AllowEmojis))
                ) && 
                (
                    this.Percentages == input.Percentages ||
                    this.Percentages != null &&
                    this.Percentages.SequenceEqual(input.Percentages)
                ) && 
                (
                    this.DefaultPercentage == input.DefaultPercentage ||
                    (this.DefaultPercentage != null &&
                    this.DefaultPercentage.Equals(input.DefaultPercentage))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.AllowCustomTips != null)
                    hashCode = hashCode * 59 + this.AllowCustomTips.GetHashCode();
                if (this.AllowRoundUp != null)
                    hashCode = hashCode * 59 + this.AllowRoundUp.GetHashCode();
                if (this.AllowEmojis != null)
                    hashCode = hashCode * 59 + this.AllowEmojis.GetHashCode();
                if (this.Percentages != null)
                    hashCode = hashCode * 59 + this.Percentages.GetHashCode();
                if (this.DefaultPercentage != null)
                    hashCode = hashCode * 59 + this.DefaultPercentage.GetHashCode();
                return hashCode;
            }
        }
    }

}
