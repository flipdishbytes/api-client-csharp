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
    /// Oauth client (also knowns as &#39;app&#39;)
    /// </summary>
    [DataContract]
    public partial class OAuthClient :  IEquatable<OAuthClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClient" /> class.
        /// </summary>
        /// <param name="ClientId">Oauth client identifier.</param>
        /// <param name="ClientName">Oauth client name.</param>
        /// <param name="OwnerUserId">Oauth client owner user identifier.</param>
        /// <param name="LogoUri">Oauth client logo uri.</param>
        public OAuthClient(string ClientId = default(string), string ClientName = default(string), int? OwnerUserId = default(int?), string LogoUri = default(string))
        {
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.OwnerUserId = OwnerUserId;
            this.LogoUri = LogoUri;
        }
        
        /// <summary>
        /// Oauth client identifier
        /// </summary>
        /// <value>Oauth client identifier</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Oauth client name
        /// </summary>
        /// <value>Oauth client name</value>
        [DataMember(Name="clientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Oauth client owner user identifier
        /// </summary>
        /// <value>Oauth client owner user identifier</value>
        [DataMember(Name="ownerUserId", EmitDefaultValue=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// Oauth client logo uri
        /// </summary>
        /// <value>Oauth client logo uri</value>
        [DataMember(Name="logoUri", EmitDefaultValue=false)]
        public string LogoUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthClient {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  OwnerUserId: ").Append(OwnerUserId).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
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
            return this.Equals(input as OAuthClient);
        }

        /// <summary>
        /// Returns true if OAuthClient instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthClient input)
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
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.OwnerUserId == input.OwnerUserId ||
                    (this.OwnerUserId != null &&
                    this.OwnerUserId.Equals(input.OwnerUserId))
                ) && 
                (
                    this.LogoUri == input.LogoUri ||
                    (this.LogoUri != null &&
                    this.LogoUri.Equals(input.LogoUri))
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
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.OwnerUserId != null)
                    hashCode = hashCode * 59 + this.OwnerUserId.GetHashCode();
                if (this.LogoUri != null)
                    hashCode = hashCode * 59 + this.LogoUri.GetHashCode();
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
