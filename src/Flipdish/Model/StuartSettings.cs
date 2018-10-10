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
    /// Stuart settings
    /// </summary>
    [DataContract]
    public partial class StuartSettings :  IEquatable<StuartSettings>, IValidatableObject
    {
        /// <summary>
        /// PackageType
        /// </summary>
        /// <value>PackageType</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PackageTypeEnum
        {
            
            /// <summary>
            /// Enum Xsmall for value: Xsmall
            /// </summary>
            [EnumMember(Value = "Xsmall")]
            Xsmall = 1,
            
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 2,
            
            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 3,
            
            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 4,
            
            /// <summary>
            /// Enum Xlarge for value: Xlarge
            /// </summary>
            [EnumMember(Value = "Xlarge")]
            Xlarge = 5
        }

        /// <summary>
        /// PackageType
        /// </summary>
        /// <value>PackageType</value>
        [DataMember(Name="PackageType", EmitDefaultValue=false)]
        public PackageTypeEnum? PackageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StuartSettings" /> class.
        /// </summary>
        /// <param name="ClientId">Client Id.</param>
        /// <param name="ClientSecret">Client Secret.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="WebhookUrlBasicAuthentication">Webhook url to settle in the Stuart portal.</param>
        /// <param name="MinutesToPickupBeforeThanDeliveryTime">MinutesToPickupBeforeThanDeliveryTime.</param>
        /// <param name="PackageType">PackageType.</param>
        public StuartSettings(string ClientId = default(string), string ClientSecret = default(string), bool? Enabled = default(bool?), string WebhookUrlBasicAuthentication = default(string), int? MinutesToPickupBeforeThanDeliveryTime = default(int?), PackageTypeEnum? PackageType = default(PackageTypeEnum?))
        {
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.Enabled = Enabled;
            this.WebhookUrlBasicAuthentication = WebhookUrlBasicAuthentication;
            this.MinutesToPickupBeforeThanDeliveryTime = MinutesToPickupBeforeThanDeliveryTime;
            this.PackageType = PackageType;
        }
        
        /// <summary>
        /// Client Id
        /// </summary>
        /// <value>Client Id</value>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret
        /// </summary>
        /// <value>Client Secret</value>
        [DataMember(Name="ClientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Webhook url to settle in the Stuart portal
        /// </summary>
        /// <value>Webhook url to settle in the Stuart portal</value>
        [DataMember(Name="WebhookUrlBasicAuthentication", EmitDefaultValue=false)]
        public string WebhookUrlBasicAuthentication { get; set; }

        /// <summary>
        /// MinutesToPickupBeforeThanDeliveryTime
        /// </summary>
        /// <value>MinutesToPickupBeforeThanDeliveryTime</value>
        [DataMember(Name="MinutesToPickupBeforeThanDeliveryTime", EmitDefaultValue=false)]
        public int? MinutesToPickupBeforeThanDeliveryTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StuartSettings {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  WebhookUrlBasicAuthentication: ").Append(WebhookUrlBasicAuthentication).Append("\n");
            sb.Append("  MinutesToPickupBeforeThanDeliveryTime: ").Append(MinutesToPickupBeforeThanDeliveryTime).Append("\n");
            sb.Append("  PackageType: ").Append(PackageType).Append("\n");
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
            return this.Equals(input as StuartSettings);
        }

        /// <summary>
        /// Returns true if StuartSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StuartSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StuartSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.WebhookUrlBasicAuthentication == input.WebhookUrlBasicAuthentication ||
                    (this.WebhookUrlBasicAuthentication != null &&
                    this.WebhookUrlBasicAuthentication.Equals(input.WebhookUrlBasicAuthentication))
                ) && 
                (
                    this.MinutesToPickupBeforeThanDeliveryTime == input.MinutesToPickupBeforeThanDeliveryTime ||
                    (this.MinutesToPickupBeforeThanDeliveryTime != null &&
                    this.MinutesToPickupBeforeThanDeliveryTime.Equals(input.MinutesToPickupBeforeThanDeliveryTime))
                ) && 
                (
                    this.PackageType == input.PackageType ||
                    (this.PackageType != null &&
                    this.PackageType.Equals(input.PackageType))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.WebhookUrlBasicAuthentication != null)
                    hashCode = hashCode * 59 + this.WebhookUrlBasicAuthentication.GetHashCode();
                if (this.MinutesToPickupBeforeThanDeliveryTime != null)
                    hashCode = hashCode * 59 + this.MinutesToPickupBeforeThanDeliveryTime.GetHashCode();
                if (this.PackageType != null)
                    hashCode = hashCode * 59 + this.PackageType.GetHashCode();
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