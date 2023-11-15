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
    /// Model for updating the onboarding config
    /// </summary>
    [DataContract]
    public partial class OnboardingConfigUpdate :  IEquatable<OnboardingConfigUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingConfigUpdate" /> class.
        /// </summary>
        /// <param name="isEnabled">Gets or sets whether onboarding is enabled.</param>
        /// <param name="isWelcomeScreenEnabled">Gets or sets whether welcome screen is enabled.</param>
        public OnboardingConfigUpdate(bool? isEnabled = default(bool?), bool? isWelcomeScreenEnabled = default(bool?))
        {
            this.IsEnabled = isEnabled;
            this.IsWelcomeScreenEnabled = isWelcomeScreenEnabled;
        }
        
        /// <summary>
        /// Gets or sets whether onboarding is enabled
        /// </summary>
        /// <value>Gets or sets whether onboarding is enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether welcome screen is enabled
        /// </summary>
        /// <value>Gets or sets whether welcome screen is enabled</value>
        [DataMember(Name="IsWelcomeScreenEnabled", EmitDefaultValue=false)]
        public bool? IsWelcomeScreenEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnboardingConfigUpdate {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsWelcomeScreenEnabled: ").Append(IsWelcomeScreenEnabled).Append("\n");
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
            return this.Equals(input as OnboardingConfigUpdate);
        }

        /// <summary>
        /// Returns true if OnboardingConfigUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingConfigUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingConfigUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.IsWelcomeScreenEnabled == input.IsWelcomeScreenEnabled ||
                    (this.IsWelcomeScreenEnabled != null &&
                    this.IsWelcomeScreenEnabled.Equals(input.IsWelcomeScreenEnabled))
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
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.IsWelcomeScreenEnabled != null)
                    hashCode = hashCode * 59 + this.IsWelcomeScreenEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
