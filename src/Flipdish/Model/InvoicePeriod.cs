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
    /// Invoice Period
    /// </summary>
    [DataContract]
    public partial class InvoicePeriod :  IEquatable<InvoicePeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePeriod" /> class.
        /// </summary>
        /// <param name="start">Start.</param>
        /// <param name="end">End.</param>
        public InvoicePeriod(DateTime? start = default(DateTime?), DateTime? end = default(DateTime?))
        {
            this.Start = start;
            this.End = end;
        }
        
        /// <summary>
        /// Start
        /// </summary>
        /// <value>Start</value>
        [DataMember(Name="Start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// End
        /// </summary>
        /// <value>End</value>
        [DataMember(Name="End", EmitDefaultValue=false)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicePeriod {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as InvoicePeriod);
        }

        /// <summary>
        /// Returns true if InvoicePeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                return hashCode;
            }
        }
    }

}
