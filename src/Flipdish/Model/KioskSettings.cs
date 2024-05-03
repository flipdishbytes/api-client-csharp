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
    /// Kiosk level settings
    /// </summary>
    [DataContract]
    public partial class KioskSettings :  IEquatable<KioskSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KioskSettings" /> class.
        /// </summary>
        /// <param name="hideLogoFromFrontPage">Hide logo from front page.</param>
        /// <param name="twoColumnMenuLayout">2 Column Menu Layout.</param>
        public KioskSettings(bool? hideLogoFromFrontPage = default(bool?), bool? twoColumnMenuLayout = default(bool?))
        {
            this.HideLogoFromFrontPage = hideLogoFromFrontPage;
            this.TwoColumnMenuLayout = twoColumnMenuLayout;
        }
        
        /// <summary>
        /// Hide logo from front page
        /// </summary>
        /// <value>Hide logo from front page</value>
        [DataMember(Name="HideLogoFromFrontPage", EmitDefaultValue=false)]
        public bool? HideLogoFromFrontPage { get; set; }

        /// <summary>
        /// 2 Column Menu Layout
        /// </summary>
        /// <value>2 Column Menu Layout</value>
        [DataMember(Name="TwoColumnMenuLayout", EmitDefaultValue=false)]
        public bool? TwoColumnMenuLayout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KioskSettings {\n");
            sb.Append("  HideLogoFromFrontPage: ").Append(HideLogoFromFrontPage).Append("\n");
            sb.Append("  TwoColumnMenuLayout: ").Append(TwoColumnMenuLayout).Append("\n");
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
            return this.Equals(input as KioskSettings);
        }

        /// <summary>
        /// Returns true if KioskSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of KioskSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KioskSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HideLogoFromFrontPage == input.HideLogoFromFrontPage ||
                    (this.HideLogoFromFrontPage != null &&
                    this.HideLogoFromFrontPage.Equals(input.HideLogoFromFrontPage))
                ) && 
                (
                    this.TwoColumnMenuLayout == input.TwoColumnMenuLayout ||
                    (this.TwoColumnMenuLayout != null &&
                    this.TwoColumnMenuLayout.Equals(input.TwoColumnMenuLayout))
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
                if (this.HideLogoFromFrontPage != null)
                    hashCode = hashCode * 59 + this.HideLogoFromFrontPage.GetHashCode();
                if (this.TwoColumnMenuLayout != null)
                    hashCode = hashCode * 59 + this.TwoColumnMenuLayout.GetHashCode();
                return hashCode;
            }
        }
    }

}
