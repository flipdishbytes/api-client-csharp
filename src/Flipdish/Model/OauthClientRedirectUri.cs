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
    /// OAuth client redirect uri
    /// </summary>
    [DataContract]
    public partial class OauthClientRedirectUri :  IEquatable<OauthClientRedirectUri>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthClientRedirectUri" /> class.
        /// </summary>
        /// <param name="id">Redirect uri identifier.</param>
        /// <param name="uri">Redirect uri.</param>
        public OauthClientRedirectUri(int? id = default(int?), string uri = default(string))
        {
            this.Id = id;
            this.Uri = uri;
        }
        
        /// <summary>
        /// Redirect uri identifier
        /// </summary>
        /// <value>Redirect uri identifier</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Redirect uri
        /// </summary>
        /// <value>Redirect uri</value>
        [DataMember(Name="Uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OauthClientRedirectUri {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as OauthClientRedirectUri);
        }

        /// <summary>
        /// Returns true if OauthClientRedirectUri instances are equal
        /// </summary>
        /// <param name="input">Instance of OauthClientRedirectUri to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OauthClientRedirectUri input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                return hashCode;
            }
        }
    }

}
