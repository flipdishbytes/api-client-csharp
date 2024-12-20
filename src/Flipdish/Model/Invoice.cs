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
    /// Represents an ordering invoice for a period of time.
    /// </summary>
    [DataContract]
    public partial class Invoice :  IEquatable<Invoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="invoiceNumber">Invoice Number.</param>
        /// <param name="startDay">The start day of the invoice period..</param>
        /// <param name="endDay">The end day of the invoice period..</param>
        public Invoice(string invoiceNumber = default(string), DateTime? startDay = default(DateTime?), DateTime? endDay = default(DateTime?))
        {
            this.InvoiceNumber = invoiceNumber;
            this.StartDay = startDay;
            this.EndDay = endDay;
        }
        
        /// <summary>
        /// Invoice Number
        /// </summary>
        /// <value>Invoice Number</value>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The start day of the invoice period.
        /// </summary>
        /// <value>The start day of the invoice period.</value>
        [DataMember(Name="StartDay", EmitDefaultValue=false)]
        public DateTime? StartDay { get; set; }

        /// <summary>
        /// The end day of the invoice period.
        /// </summary>
        /// <value>The end day of the invoice period.</value>
        [DataMember(Name="EndDay", EmitDefaultValue=false)]
        public DateTime? EndDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoice {\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  StartDay: ").Append(StartDay).Append("\n");
            sb.Append("  EndDay: ").Append(EndDay).Append("\n");
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
            return this.Equals(input as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.StartDay == input.StartDay ||
                    (this.StartDay != null &&
                    this.StartDay.Equals(input.StartDay))
                ) && 
                (
                    this.EndDay == input.EndDay ||
                    (this.EndDay != null &&
                    this.EndDay.Equals(input.EndDay))
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
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.StartDay != null)
                    hashCode = hashCode * 59 + this.StartDay.GetHashCode();
                if (this.EndDay != null)
                    hashCode = hashCode * 59 + this.EndDay.GetHashCode();
                return hashCode;
            }
        }
    }

}
