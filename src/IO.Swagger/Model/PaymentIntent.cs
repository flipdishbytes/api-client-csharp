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
    /// Represents stripe PaymentIntent
    /// </summary>
    [DataContract]
    public partial class PaymentIntent :  IEquatable<PaymentIntent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntent" /> class.
        /// </summary>
        /// <param name="id">Id of payment intent.</param>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="currency">Three-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-4217-currency-codes.html\&quot;&gt;ISO currency  code&lt;/a&gt;, in lowercase. Must be a &lt;a href&#x3D;\&quot;https://stripe.com/docs/currencies\&quot;&gt;supported  currency&lt;/a&gt;..</param>
        /// <param name="status">Status of this PaymentIntent, one of requires_payment_method,  requires_confirmation, requires_action, processing,  requires_capture, canceled, or succeeded. Read more about each  PaymentIntent &lt;a href&#x3D;\&quot;https://stripe.com/docs/payments/intents#intent-statuses\&quot;&gt;status&lt;/a&gt;.  One of: canceled, processing, requires_action,  requires_capture, requires_confirmation, requires_payment_method,  or succeeded..</param>
        /// <param name="created">Time at which the object was created. Measured in seconds since the Unix epoch..</param>
        /// <param name="lastPaymentError">Failed payment intent Errors.</param>
        public PaymentIntent(string id = default(string), string description = default(string), string currency = default(string), string status = default(string), DateTime? created = default(DateTime?), LastPaymentError lastPaymentError = default(LastPaymentError))
        {
            this.Id = id;
            this.Description = description;
            this.Currency = currency;
            this.Status = status;
            this.Created = created;
            this.LastPaymentError = lastPaymentError;
        }
        
        /// <summary>
        /// Id of payment intent
        /// </summary>
        /// <value>Id of payment intent</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Three-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-4217-currency-codes.html\&quot;&gt;ISO currency  code&lt;/a&gt;, in lowercase. Must be a &lt;a href&#x3D;\&quot;https://stripe.com/docs/currencies\&quot;&gt;supported  currency&lt;/a&gt;.
        /// </summary>
        /// <value>Three-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-4217-currency-codes.html\&quot;&gt;ISO currency  code&lt;/a&gt;, in lowercase. Must be a &lt;a href&#x3D;\&quot;https://stripe.com/docs/currencies\&quot;&gt;supported  currency&lt;/a&gt;.</value>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Status of this PaymentIntent, one of requires_payment_method,  requires_confirmation, requires_action, processing,  requires_capture, canceled, or succeeded. Read more about each  PaymentIntent &lt;a href&#x3D;\&quot;https://stripe.com/docs/payments/intents#intent-statuses\&quot;&gt;status&lt;/a&gt;.  One of: canceled, processing, requires_action,  requires_capture, requires_confirmation, requires_payment_method,  or succeeded.
        /// </summary>
        /// <value>Status of this PaymentIntent, one of requires_payment_method,  requires_confirmation, requires_action, processing,  requires_capture, canceled, or succeeded. Read more about each  PaymentIntent &lt;a href&#x3D;\&quot;https://stripe.com/docs/payments/intents#intent-statuses\&quot;&gt;status&lt;/a&gt;.  One of: canceled, processing, requires_action,  requires_capture, requires_confirmation, requires_payment_method,  or succeeded.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        /// <value>Time at which the object was created. Measured in seconds since the Unix epoch.</value>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Failed payment intent Errors
        /// </summary>
        /// <value>Failed payment intent Errors</value>
        [DataMember(Name="LastPaymentError", EmitDefaultValue=false)]
        public LastPaymentError LastPaymentError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentIntent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastPaymentError: ").Append(LastPaymentError).Append("\n");
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
            return this.Equals(input as PaymentIntent);
        }

        /// <summary>
        /// Returns true if PaymentIntent instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentIntent input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.LastPaymentError == input.LastPaymentError ||
                    (this.LastPaymentError != null &&
                    this.LastPaymentError.Equals(input.LastPaymentError))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.LastPaymentError != null)
                    hashCode = hashCode * 59 + this.LastPaymentError.GetHashCode();
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
