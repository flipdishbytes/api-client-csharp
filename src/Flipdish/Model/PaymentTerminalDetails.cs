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
    /// Details of Payment Terminal
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalDetails :  IEquatable<PaymentTerminalDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalDetails" /> class.
        /// </summary>
        /// <param name="terminalId">Terminal Id (tid).</param>
        /// <param name="status">Status of Terminal.</param>
        /// <param name="currency">Currency configured on the terminal.</param>
        /// <param name="uri">Location to Device.</param>
        public PaymentTerminalDetails(string terminalId = default(string), string status = default(string), string currency = default(string), string uri = default(string))
        {
            this.TerminalId = terminalId;
            this.Status = status;
            this.Currency = currency;
            this.Uri = uri;
        }
        
        /// <summary>
        /// Terminal Id (tid)
        /// </summary>
        /// <value>Terminal Id (tid)</value>
        [DataMember(Name="TerminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Status of Terminal
        /// </summary>
        /// <value>Status of Terminal</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Currency configured on the terminal
        /// </summary>
        /// <value>Currency configured on the terminal</value>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Location to Device
        /// </summary>
        /// <value>Location to Device</value>
        [DataMember(Name="Uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalDetails {\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as PaymentTerminalDetails);
        }

        /// <summary>
        /// Returns true if PaymentTerminalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
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
