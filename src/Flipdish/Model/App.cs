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
    /// App
    /// </summary>
    [DataContract]
    public partial class App :  IEquatable<App>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="AppId">App Identifier.</param>
        /// <param name="Name">App name.</param>
        /// <param name="IconUrl">Icon url.</param>
        /// <param name="IconThumbnailUrl">Icon thumbnail url.</param>
        /// <param name="CountryId">Country identifier.</param>
        public App(string AppId = default(string), string Name = default(string), string IconUrl = default(string), string IconThumbnailUrl = default(string), string CountryId = default(string))
        {
            this.AppId = AppId;
            this.Name = Name;
            this.IconUrl = IconUrl;
            this.IconThumbnailUrl = IconThumbnailUrl;
            this.CountryId = CountryId;
        }
        
        /// <summary>
        /// App Identifier
        /// </summary>
        /// <value>App Identifier</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// App name
        /// </summary>
        /// <value>App name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Icon url
        /// </summary>
        /// <value>Icon url</value>
        [DataMember(Name="IconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Icon thumbnail url
        /// </summary>
        /// <value>Icon thumbnail url</value>
        [DataMember(Name="IconThumbnailUrl", EmitDefaultValue=false)]
        public string IconThumbnailUrl { get; set; }

        /// <summary>
        /// Country identifier
        /// </summary>
        /// <value>Country identifier</value>
        [DataMember(Name="CountryId", EmitDefaultValue=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class App {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  IconThumbnailUrl: ").Append(IconThumbnailUrl).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.IconThumbnailUrl == input.IconThumbnailUrl ||
                    (this.IconThumbnailUrl != null &&
                    this.IconThumbnailUrl.Equals(input.IconThumbnailUrl))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.IconThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.IconThumbnailUrl.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
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
            // CountryId (string) maxLength
            if(this.CountryId != null && this.CountryId.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryId, length must be less than 2.", new [] { "CountryId" });
            }

            // CountryId (string) minLength
            if(this.CountryId != null && this.CountryId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryId, length must be greater than 0.", new [] { "CountryId" });
            }

            yield break;
        }
    }

}
