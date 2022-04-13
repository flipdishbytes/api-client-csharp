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
    /// App store app configuration webhook event
    /// </summary>
    [DataContract]
    public partial class UpdateAppStoreAppConfigurationWebhookDTO :  IEquatable<UpdateAppStoreAppConfigurationWebhookDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppStoreAppConfigurationWebhookDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAppStoreAppConfigurationWebhookDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppStoreAppConfigurationWebhookDTO" /> class.
        /// </summary>
        /// <param name="id">Unique App store app configuration id (required).</param>
        /// <param name="isEnabled">Is enabled (required).</param>
        /// <param name="storeIds">Store id&#39;s.</param>
        /// <param name="settings">Settings.</param>
        public UpdateAppStoreAppConfigurationWebhookDTO(string id = default(string), bool? isEnabled = default(bool?), List<int?> storeIds = default(List<int?>), List<Setting> settings = default(List<Setting>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UpdateAppStoreAppConfigurationWebhookDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "isEnabled" is required (not null)
            if (isEnabled == null)
            {
                throw new InvalidDataException("isEnabled is a required property for UpdateAppStoreAppConfigurationWebhookDTO and cannot be null");
            }
            else
            {
                this.IsEnabled = isEnabled;
            }
            this.StoreIds = storeIds;
            this.Settings = settings;
        }
        
        /// <summary>
        /// Unique App store app configuration id
        /// </summary>
        /// <value>Unique App store app configuration id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Is enabled
        /// </summary>
        /// <value>Is enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Store id&#39;s
        /// </summary>
        /// <value>Store id&#39;s</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        /// <value>Settings</value>
        [DataMember(Name="Settings", EmitDefaultValue=false)]
        public List<Setting> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppStoreAppConfigurationWebhookDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as UpdateAppStoreAppConfigurationWebhookDTO);
        }

        /// <summary>
        /// Returns true if UpdateAppStoreAppConfigurationWebhookDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAppStoreAppConfigurationWebhookDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAppStoreAppConfigurationWebhookDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
