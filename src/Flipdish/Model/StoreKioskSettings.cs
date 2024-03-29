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
    /// Store Kiosk Settings
    /// </summary>
    [DataContract]
    public partial class StoreKioskSettings :  IEquatable<StoreKioskSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreKioskSettings" /> class.
        /// </summary>
        /// <param name="kioskStoreSettings">List of Store Kiosk Settings.</param>
        /// <param name="storeLogoUrl">Store Logo Url.</param>
        public StoreKioskSettings(List<StoreKioskSettingModel> kioskStoreSettings = default(List<StoreKioskSettingModel>), string storeLogoUrl = default(string))
        {
            this.KioskStoreSettings = kioskStoreSettings;
            this.StoreLogoUrl = storeLogoUrl;
        }
        
        /// <summary>
        /// List of Store Kiosk Settings
        /// </summary>
        /// <value>List of Store Kiosk Settings</value>
        [DataMember(Name="KioskStoreSettings", EmitDefaultValue=false)]
        public List<StoreKioskSettingModel> KioskStoreSettings { get; set; }

        /// <summary>
        /// Store Logo Url
        /// </summary>
        /// <value>Store Logo Url</value>
        [DataMember(Name="StoreLogoUrl", EmitDefaultValue=false)]
        public string StoreLogoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreKioskSettings {\n");
            sb.Append("  KioskStoreSettings: ").Append(KioskStoreSettings).Append("\n");
            sb.Append("  StoreLogoUrl: ").Append(StoreLogoUrl).Append("\n");
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
            return this.Equals(input as StoreKioskSettings);
        }

        /// <summary>
        /// Returns true if StoreKioskSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreKioskSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreKioskSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KioskStoreSettings == input.KioskStoreSettings ||
                    this.KioskStoreSettings != null &&
                    this.KioskStoreSettings.SequenceEqual(input.KioskStoreSettings)
                ) && 
                (
                    this.StoreLogoUrl == input.StoreLogoUrl ||
                    (this.StoreLogoUrl != null &&
                    this.StoreLogoUrl.Equals(input.StoreLogoUrl))
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
                if (this.KioskStoreSettings != null)
                    hashCode = hashCode * 59 + this.KioskStoreSettings.GetHashCode();
                if (this.StoreLogoUrl != null)
                    hashCode = hashCode * 59 + this.StoreLogoUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
