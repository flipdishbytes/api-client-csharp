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
    /// Subscription account
    /// </summary>
    [DataContract]
    public partial class AppStoreAppSubscriptionAccount :  IEquatable<AppStoreAppSubscriptionAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppSubscriptionAccount" /> class.
        /// </summary>
        /// <param name="email">Email of the account user.</param>
        public AppStoreAppSubscriptionAccount(string email = default(string))
        {
            this.Email = email;
        }
        
        /// <summary>
        /// Email of the account user
        /// </summary>
        /// <value>Email of the account user</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreAppSubscriptionAccount {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as AppStoreAppSubscriptionAccount);
        }

        /// <summary>
        /// Returns true if AppStoreAppSubscriptionAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppSubscriptionAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppSubscriptionAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                return hashCode;
            }
        }
    }

}
