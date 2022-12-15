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
    /// Request login PIN response
    /// </summary>
    [DataContract]
    public partial class RequestLoginPinResponse :  IEquatable<RequestLoginPinResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLoginPinResponse" /> class.
        /// </summary>
        /// <param name="loginPinSentViaEmail">Login PIN sent via email to user.</param>
        /// <param name="forceOktaLogin">All flipdishers must login via Okta.</param>
        public RequestLoginPinResponse(bool? loginPinSentViaEmail = default(bool?), bool? forceOktaLogin = default(bool?))
        {
            this.LoginPinSentViaEmail = loginPinSentViaEmail;
            this.ForceOktaLogin = forceOktaLogin;
        }
        
        /// <summary>
        /// Login PIN sent via email to user
        /// </summary>
        /// <value>Login PIN sent via email to user</value>
        [DataMember(Name="LoginPinSentViaEmail", EmitDefaultValue=false)]
        public bool? LoginPinSentViaEmail { get; set; }

        /// <summary>
        /// All flipdishers must login via Okta
        /// </summary>
        /// <value>All flipdishers must login via Okta</value>
        [DataMember(Name="ForceOktaLogin", EmitDefaultValue=false)]
        public bool? ForceOktaLogin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestLoginPinResponse {\n");
            sb.Append("  LoginPinSentViaEmail: ").Append(LoginPinSentViaEmail).Append("\n");
            sb.Append("  ForceOktaLogin: ").Append(ForceOktaLogin).Append("\n");
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
            return this.Equals(input as RequestLoginPinResponse);
        }

        /// <summary>
        /// Returns true if RequestLoginPinResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestLoginPinResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestLoginPinResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoginPinSentViaEmail == input.LoginPinSentViaEmail ||
                    (this.LoginPinSentViaEmail != null &&
                    this.LoginPinSentViaEmail.Equals(input.LoginPinSentViaEmail))
                ) && 
                (
                    this.ForceOktaLogin == input.ForceOktaLogin ||
                    (this.ForceOktaLogin != null &&
                    this.ForceOktaLogin.Equals(input.ForceOktaLogin))
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
                if (this.LoginPinSentViaEmail != null)
                    hashCode = hashCode * 59 + this.LoginPinSentViaEmail.GetHashCode();
                if (this.ForceOktaLogin != null)
                    hashCode = hashCode * 59 + this.ForceOktaLogin.GetHashCode();
                return hashCode;
            }
        }
    }

}
