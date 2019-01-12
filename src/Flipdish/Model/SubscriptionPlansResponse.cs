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
    /// Available plans and mandatory fields to subscribe
    /// </summary>
    [DataContract]
    public partial class SubscriptionPlansResponse :  IEquatable<SubscriptionPlansResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansResponse" /> class.
        /// </summary>
        /// <param name="publishableApiKey">Stripe publishable api key.</param>
        /// <param name="email">User email.</param>
        /// <param name="subscriptionPlans">Available plans.</param>
        /// <param name="appIds">App ids (string name) to which the user belongs.</param>
        public SubscriptionPlansResponse(string publishableApiKey = default(string), string email = default(string), List<SubscriptionPlan> subscriptionPlans = default(List<SubscriptionPlan>), List<string> appIds = default(List<string>))
        {
            this.PublishableApiKey = publishableApiKey;
            this.Email = email;
            this.SubscriptionPlans = subscriptionPlans;
            this.AppIds = appIds;
        }
        
        /// <summary>
        /// Stripe publishable api key
        /// </summary>
        /// <value>Stripe publishable api key</value>
        [DataMember(Name="PublishableApiKey", EmitDefaultValue=false)]
        public string PublishableApiKey { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        /// <value>User email</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Available plans
        /// </summary>
        /// <value>Available plans</value>
        [DataMember(Name="SubscriptionPlans", EmitDefaultValue=false)]
        public List<SubscriptionPlan> SubscriptionPlans { get; set; }

        /// <summary>
        /// App ids (string name) to which the user belongs
        /// </summary>
        /// <value>App ids (string name) to which the user belongs</value>
        [DataMember(Name="AppIds", EmitDefaultValue=false)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlansResponse {\n");
            sb.Append("  PublishableApiKey: ").Append(PublishableApiKey).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SubscriptionPlans: ").Append(SubscriptionPlans).Append("\n");
            sb.Append("  AppIds: ").Append(AppIds).Append("\n");
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
            return this.Equals(input as SubscriptionPlansResponse);
        }

        /// <summary>
        /// Returns true if SubscriptionPlansResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPlansResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlansResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublishableApiKey == input.PublishableApiKey ||
                    (this.PublishableApiKey != null &&
                    this.PublishableApiKey.Equals(input.PublishableApiKey))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SubscriptionPlans == input.SubscriptionPlans ||
                    this.SubscriptionPlans != null &&
                    this.SubscriptionPlans.SequenceEqual(input.SubscriptionPlans)
                ) && 
                (
                    this.AppIds == input.AppIds ||
                    this.AppIds != null &&
                    this.AppIds.SequenceEqual(input.AppIds)
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
                if (this.PublishableApiKey != null)
                    hashCode = hashCode * 59 + this.PublishableApiKey.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.SubscriptionPlans != null)
                    hashCode = hashCode * 59 + this.SubscriptionPlans.GetHashCode();
                if (this.AppIds != null)
                    hashCode = hashCode * 59 + this.AppIds.GetHashCode();
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
