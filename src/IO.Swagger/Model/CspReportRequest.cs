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
    /// CspReportRequest
    /// </summary>
    [DataContract]
    public partial class CspReportRequest :  IEquatable<CspReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CspReportRequest" /> class.
        /// </summary>
        /// <param name="cspReport">cspReport.</param>
        public CspReportRequest(CspReport cspReport = default(CspReport))
        {
            this.CspReport = cspReport;
        }
        
        /// <summary>
        /// Gets or Sets CspReport
        /// </summary>
        [DataMember(Name="Csp-report", EmitDefaultValue=false)]
        public CspReport CspReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CspReportRequest {\n");
            sb.Append("  CspReport: ").Append(CspReport).Append("\n");
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
            return this.Equals(input as CspReportRequest);
        }

        /// <summary>
        /// Returns true if CspReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CspReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CspReportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CspReport == input.CspReport ||
                    (this.CspReport != null &&
                    this.CspReport.Equals(input.CspReport))
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
                if (this.CspReport != null)
                    hashCode = hashCode * 59 + this.CspReport.GetHashCode();
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
