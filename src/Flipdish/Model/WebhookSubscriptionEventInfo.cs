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
    /// WebhookSubscriptionEventInfo
    /// </summary>
    [DataContract]
    public partial class WebhookSubscriptionEventInfo :  IEquatable<WebhookSubscriptionEventInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionEventInfo" /> class.
        /// </summary>
        /// <param name="ownerUserId">Webhook subscription owner user identifier.</param>
        /// <param name="webhookSubscriptionId">Webhook subscription identifier.</param>
        /// <param name="clientId">Oauth client identifier.</param>
        /// <param name="callbackUrl">Webhook callback url.</param>
        public WebhookSubscriptionEventInfo(int? ownerUserId = default(int?), int? webhookSubscriptionId = default(int?), string clientId = default(string), string callbackUrl = default(string))
        {
            this.OwnerUserId = ownerUserId;
            this.WebhookSubscriptionId = webhookSubscriptionId;
            this.ClientId = clientId;
            this.CallbackUrl = callbackUrl;
        }
        
        /// <summary>
        /// Webhook subscription owner user identifier
        /// </summary>
        /// <value>Webhook subscription owner user identifier</value>
        [DataMember(Name="OwnerUserId", EmitDefaultValue=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// Webhook subscription identifier
        /// </summary>
        /// <value>Webhook subscription identifier</value>
        [DataMember(Name="WebhookSubscriptionId", EmitDefaultValue=false)]
        public int? WebhookSubscriptionId { get; set; }

        /// <summary>
        /// Oauth client identifier
        /// </summary>
        /// <value>Oauth client identifier</value>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Webhook callback url
        /// </summary>
        /// <value>Webhook callback url</value>
        [DataMember(Name="CallbackUrl", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSubscriptionEventInfo {\n");
            sb.Append("  OwnerUserId: ").Append(OwnerUserId).Append("\n");
            sb.Append("  WebhookSubscriptionId: ").Append(WebhookSubscriptionId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as WebhookSubscriptionEventInfo);
        }

        /// <summary>
        /// Returns true if WebhookSubscriptionEventInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSubscriptionEventInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSubscriptionEventInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerUserId == input.OwnerUserId ||
                    (this.OwnerUserId != null &&
                    this.OwnerUserId.Equals(input.OwnerUserId))
                ) && 
                (
                    this.WebhookSubscriptionId == input.WebhookSubscriptionId ||
                    (this.WebhookSubscriptionId != null &&
                    this.WebhookSubscriptionId.Equals(input.WebhookSubscriptionId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                if (this.OwnerUserId != null)
                    hashCode = hashCode * 59 + this.OwnerUserId.GetHashCode();
                if (this.WebhookSubscriptionId != null)
                    hashCode = hashCode * 59 + this.WebhookSubscriptionId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
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
