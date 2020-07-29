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
    /// Application configuration
    /// </summary>
    [DataContract]
    public partial class AppConfigUpdateModel :  IEquatable<AppConfigUpdateModel>, IValidatableObject
    {
        /// <summary>
        /// Application Category
        /// </summary>
        /// <value>Application Category</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationCategoryEnum
        {
            
            /// <summary>
            /// Enum Restaurant for value: Restaurant
            /// </summary>
            [EnumMember(Value = "Restaurant")]
            Restaurant = 1,
            
            /// <summary>
            /// Enum Cafe for value: Cafe
            /// </summary>
            [EnumMember(Value = "Cafe")]
            Cafe = 2,
            
            /// <summary>
            /// Enum Convenience for value: Convenience
            /// </summary>
            [EnumMember(Value = "Convenience")]
            Convenience = 3
        }

        /// <summary>
        /// Application Category
        /// </summary>
        /// <value>Application Category</value>
        [DataMember(Name="ApplicationCategory", EmitDefaultValue=false)]
        public ApplicationCategoryEnum? ApplicationCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigUpdateModel" /> class.
        /// </summary>
        /// <param name="name">App name.</param>
        /// <param name="hostName">HostName on which the app is allowed to be hosted.</param>
        /// <param name="mainColor">Main color of the web \\ android \\ ios applications.</param>
        /// <param name="applicationCategory">Application Category.</param>
        /// <param name="isPanaceaEnabled">Is Panacea Enabled.</param>
        /// <param name="cookieConsentPromptEnabled">Cookie Consent Prompt Enabled.</param>
        public AppConfigUpdateModel(string name = default(string), string hostName = default(string), string mainColor = default(string), ApplicationCategoryEnum? applicationCategory = default(ApplicationCategoryEnum?), bool? isPanaceaEnabled = default(bool?), bool? cookieConsentPromptEnabled = default(bool?))
        {
            this.Name = name;
            this.HostName = hostName;
            this.MainColor = mainColor;
            this.ApplicationCategory = applicationCategory;
            this.IsPanaceaEnabled = isPanaceaEnabled;
            this.CookieConsentPromptEnabled = cookieConsentPromptEnabled;
        }
        
        /// <summary>
        /// App name
        /// </summary>
        /// <value>App name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// HostName on which the app is allowed to be hosted
        /// </summary>
        /// <value>HostName on which the app is allowed to be hosted</value>
        [DataMember(Name="HostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Main color of the web \\ android \\ ios applications
        /// </summary>
        /// <value>Main color of the web \\ android \\ ios applications</value>
        [DataMember(Name="MainColor", EmitDefaultValue=false)]
        public string MainColor { get; set; }


        /// <summary>
        /// Is Panacea Enabled
        /// </summary>
        /// <value>Is Panacea Enabled</value>
        [DataMember(Name="IsPanaceaEnabled", EmitDefaultValue=false)]
        public bool? IsPanaceaEnabled { get; set; }

        /// <summary>
        /// Cookie Consent Prompt Enabled
        /// </summary>
        /// <value>Cookie Consent Prompt Enabled</value>
        [DataMember(Name="CookieConsentPromptEnabled", EmitDefaultValue=false)]
        public bool? CookieConsentPromptEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppConfigUpdateModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  MainColor: ").Append(MainColor).Append("\n");
            sb.Append("  ApplicationCategory: ").Append(ApplicationCategory).Append("\n");
            sb.Append("  IsPanaceaEnabled: ").Append(IsPanaceaEnabled).Append("\n");
            sb.Append("  CookieConsentPromptEnabled: ").Append(CookieConsentPromptEnabled).Append("\n");
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
            return this.Equals(input as AppConfigUpdateModel);
        }

        /// <summary>
        /// Returns true if AppConfigUpdateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AppConfigUpdateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppConfigUpdateModel input)
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
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.MainColor == input.MainColor ||
                    (this.MainColor != null &&
                    this.MainColor.Equals(input.MainColor))
                ) && 
                (
                    this.ApplicationCategory == input.ApplicationCategory ||
                    (this.ApplicationCategory != null &&
                    this.ApplicationCategory.Equals(input.ApplicationCategory))
                ) && 
                (
                    this.IsPanaceaEnabled == input.IsPanaceaEnabled ||
                    (this.IsPanaceaEnabled != null &&
                    this.IsPanaceaEnabled.Equals(input.IsPanaceaEnabled))
                ) && 
                (
                    this.CookieConsentPromptEnabled == input.CookieConsentPromptEnabled ||
                    (this.CookieConsentPromptEnabled != null &&
                    this.CookieConsentPromptEnabled.Equals(input.CookieConsentPromptEnabled))
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.MainColor != null)
                    hashCode = hashCode * 59 + this.MainColor.GetHashCode();
                if (this.ApplicationCategory != null)
                    hashCode = hashCode * 59 + this.ApplicationCategory.GetHashCode();
                if (this.IsPanaceaEnabled != null)
                    hashCode = hashCode * 59 + this.IsPanaceaEnabled.GetHashCode();
                if (this.CookieConsentPromptEnabled != null)
                    hashCode = hashCode * 59 + this.CookieConsentPromptEnabled.GetHashCode();
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
