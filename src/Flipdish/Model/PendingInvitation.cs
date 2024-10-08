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
    /// An invitation to join a team at Flipdish.
    /// </summary>
    [DataContract]
    public partial class PendingInvitation :  IEquatable<PendingInvitation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingInvitation" /> class.
        /// </summary>
        /// <param name="appName">The name of the brand that you have been invited to join..</param>
        /// <param name="email">The email address that the invitation was sent to..</param>
        /// <param name="otc">The one-time code that can be used to accept the invitation..</param>
        /// <param name="createdAt">The time that the invitation was created..</param>
        public PendingInvitation(string appName = default(string), string email = default(string), string otc = default(string), DateTime? createdAt = default(DateTime?))
        {
            this.AppName = appName;
            this.Email = email;
            this.Otc = otc;
            this.CreatedAt = createdAt;
        }
        
        /// <summary>
        /// The name of the brand that you have been invited to join.
        /// </summary>
        /// <value>The name of the brand that you have been invited to join.</value>
        [DataMember(Name="AppName", EmitDefaultValue=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The email address that the invitation was sent to.
        /// </summary>
        /// <value>The email address that the invitation was sent to.</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The one-time code that can be used to accept the invitation.
        /// </summary>
        /// <value>The one-time code that can be used to accept the invitation.</value>
        [DataMember(Name="Otc", EmitDefaultValue=false)]
        public string Otc { get; set; }

        /// <summary>
        /// The time that the invitation was created.
        /// </summary>
        /// <value>The time that the invitation was created.</value>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingInvitation {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Otc: ").Append(Otc).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as PendingInvitation);
        }

        /// <summary>
        /// Returns true if PendingInvitation instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingInvitation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Otc == input.Otc ||
                    (this.Otc != null &&
                    this.Otc.Equals(input.Otc))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Otc != null)
                    hashCode = hashCode * 59 + this.Otc.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}