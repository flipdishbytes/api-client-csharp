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
    /// Represents a request for Stripe account link creation
    /// </summary>
    [DataContract]
    public partial class StripeAccountLinkRequest :  IEquatable<StripeAccountLinkRequest>, IValidatableObject
    {
        /// <summary>
        /// Which information to collect from users at this stage
        /// </summary>
        /// <value>Which information to collect from users at this stage</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CollectEnum
        {
            
            /// <summary>
            /// Enum CurrentlyDue for value: CurrentlyDue
            /// </summary>
            [EnumMember(Value = "CurrentlyDue")]
            CurrentlyDue = 1,
            
            /// <summary>
            /// Enum EventuallyDue for value: EventuallyDue
            /// </summary>
            [EnumMember(Value = "EventuallyDue")]
            EventuallyDue = 2
        }

        /// <summary>
        /// Which information to collect from users at this stage
        /// </summary>
        /// <value>Which information to collect from users at this stage</value>
        [DataMember(Name="Collect", EmitDefaultValue=false)]
        public CollectEnum? Collect { get; set; }
        /// <summary>
        /// Either onboarding or edit user information
        /// </summary>
        /// <value>Either onboarding or edit user information</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Onboarding for value: Onboarding
            /// </summary>
            [EnumMember(Value = "Onboarding")]
            Onboarding = 1,
            
            /// <summary>
            /// Enum Update for value: Update
            /// </summary>
            [EnumMember(Value = "Update")]
            Update = 2
        }

        /// <summary>
        /// Either onboarding or edit user information
        /// </summary>
        /// <value>Either onboarding or edit user information</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountLinkRequest" /> class.
        /// </summary>
        /// <param name="stripeId">Stripe&#39;s own connected account identifier.</param>
        /// <param name="returnUrl">URL to be hit if link creation succeeds.</param>
        /// <param name="collect">Which information to collect from users at this stage.</param>
        /// <param name="type">Either onboarding or edit user information.</param>
        public StripeAccountLinkRequest(string stripeId = default(string), string returnUrl = default(string), CollectEnum? collect = default(CollectEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.StripeId = stripeId;
            this.ReturnUrl = returnUrl;
            this.Collect = collect;
            this.Type = type;
        }
        
        /// <summary>
        /// Stripe&#39;s own connected account identifier
        /// </summary>
        /// <value>Stripe&#39;s own connected account identifier</value>
        [DataMember(Name="StripeId", EmitDefaultValue=false)]
        public string StripeId { get; set; }

        /// <summary>
        /// URL to be hit if link creation succeeds
        /// </summary>
        /// <value>URL to be hit if link creation succeeds</value>
        [DataMember(Name="ReturnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeAccountLinkRequest {\n");
            sb.Append("  StripeId: ").Append(StripeId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  Collect: ").Append(Collect).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StripeAccountLinkRequest);
        }

        /// <summary>
        /// Returns true if StripeAccountLinkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeAccountLinkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeAccountLinkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StripeId == input.StripeId ||
                    (this.StripeId != null &&
                    this.StripeId.Equals(input.StripeId))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && 
                (
                    this.Collect == input.Collect ||
                    (this.Collect != null &&
                    this.Collect.Equals(input.Collect))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.StripeId != null)
                    hashCode = hashCode * 59 + this.StripeId.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.Collect != null)
                    hashCode = hashCode * 59 + this.Collect.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
