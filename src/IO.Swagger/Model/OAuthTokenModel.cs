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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OAuth token model
    /// </summary>
    [DataContract]
    public partial class OAuthTokenModel :  IEquatable<OAuthTokenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenModel" /> class.
        /// </summary>
        /// <param name="key">Identitifier key.</param>
        /// <param name="tokenType">Token type.</param>
        /// <param name="subjectId">Oauth subject identifier.</param>
        /// <param name="clientId">Oauth client identifier.</param>
        /// <param name="expiry">Token expiry.</param>
        public OAuthTokenModel(string key = default(string), string tokenType = default(string), string subjectId = default(string), string clientId = default(string), DateTime? expiry = default(DateTime?))
        {
            this.Key = key;
            this.TokenType = tokenType;
            this.SubjectId = subjectId;
            this.ClientId = clientId;
            this.Expiry = expiry;
        }
        
        /// <summary>
        /// Identitifier key
        /// </summary>
        /// <value>Identitifier key</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Token type
        /// </summary>
        /// <value>Token type</value>
        [DataMember(Name="TokenType", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Oauth subject identifier
        /// </summary>
        /// <value>Oauth subject identifier</value>
        [DataMember(Name="SubjectId", EmitDefaultValue=false)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Oauth client identifier
        /// </summary>
        /// <value>Oauth client identifier</value>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Token expiry
        /// </summary>
        /// <value>Token expiry</value>
        [DataMember(Name="Expiry", EmitDefaultValue=false)]
        public DateTime? Expiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthTokenModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
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
            return this.Equals(input as OAuthTokenModel);
        }

        /// <summary>
        /// Returns true if OAuthTokenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthTokenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthTokenModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.SubjectId == input.SubjectId ||
                    (this.SubjectId != null &&
                    this.SubjectId.Equals(input.SubjectId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.SubjectId != null)
                    hashCode = hashCode * 59 + this.SubjectId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
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
