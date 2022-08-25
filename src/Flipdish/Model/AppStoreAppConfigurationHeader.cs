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
    /// App store app configuration header information
    /// </summary>
    [DataContract]
    public partial class AppStoreAppConfigurationHeader :  IEquatable<AppStoreAppConfigurationHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppConfigurationHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreAppConfigurationHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppConfigurationHeader" /> class.
        /// </summary>
        /// <param name="appStoreAppId">Unique App store app id (required).</param>
        /// <param name="name">Name of Appstore app (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="logo">Logo.</param>
        /// <param name="developerName">Developer name.</param>
        public AppStoreAppConfigurationHeader(string appStoreAppId = default(string), string name = default(string), string description = default(string), string logo = default(string), string developerName = default(string))
        {
            // to ensure "appStoreAppId" is required (not null)
            if (appStoreAppId == null)
            {
                throw new InvalidDataException("appStoreAppId is a required property for AppStoreAppConfigurationHeader and cannot be null");
            }
            else
            {
                this.AppStoreAppId = appStoreAppId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AppStoreAppConfigurationHeader and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AppStoreAppConfigurationHeader and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.Logo = logo;
            this.DeveloperName = developerName;
        }
        
        /// <summary>
        /// Unique App store app id
        /// </summary>
        /// <value>Unique App store app id</value>
        [DataMember(Name="AppStoreAppId", EmitDefaultValue=false)]
        public string AppStoreAppId { get; set; }

        /// <summary>
        /// Name of Appstore app
        /// </summary>
        /// <value>Name of Appstore app</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        /// <value>Logo</value>
        [DataMember(Name="Logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Developer name
        /// </summary>
        /// <value>Developer name</value>
        [DataMember(Name="DeveloperName", EmitDefaultValue=false)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreAppConfigurationHeader {\n");
            sb.Append("  AppStoreAppId: ").Append(AppStoreAppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  DeveloperName: ").Append(DeveloperName).Append("\n");
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
            return this.Equals(input as AppStoreAppConfigurationHeader);
        }

        /// <summary>
        /// Returns true if AppStoreAppConfigurationHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppConfigurationHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppConfigurationHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppStoreAppId == input.AppStoreAppId ||
                    (this.AppStoreAppId != null &&
                    this.AppStoreAppId.Equals(input.AppStoreAppId))
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
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.DeveloperName == input.DeveloperName ||
                    (this.DeveloperName != null &&
                    this.DeveloperName.Equals(input.DeveloperName))
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
                if (this.AppStoreAppId != null)
                    hashCode = hashCode * 59 + this.AppStoreAppId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.DeveloperName != null)
                    hashCode = hashCode * 59 + this.DeveloperName.GetHashCode();
                return hashCode;
            }
        }
    }

}
