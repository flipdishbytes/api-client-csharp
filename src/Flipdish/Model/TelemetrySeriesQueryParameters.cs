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
    /// TelemetrySeriesQueryParameters
    /// </summary>
    [DataContract]
    public partial class TelemetrySeriesQueryParameters :  IEquatable<TelemetrySeriesQueryParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetrySeriesQueryParameters" /> class.
        /// </summary>
        /// <param name="kioskId">kioskId.</param>
        /// <param name="variables">variables.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        public TelemetrySeriesQueryParameters(string kioskId = default(string), List<string> variables = default(List<string>), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?))
        {
            this.KioskId = kioskId;
            this.Variables = variables;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        
        /// <summary>
        /// Gets or Sets KioskId
        /// </summary>
        [DataMember(Name="KioskId", EmitDefaultValue=false)]
        public string KioskId { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="Variables", EmitDefaultValue=false)]
        public List<string> Variables { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelemetrySeriesQueryParameters {\n");
            sb.Append("  KioskId: ").Append(KioskId).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as TelemetrySeriesQueryParameters);
        }

        /// <summary>
        /// Returns true if TelemetrySeriesQueryParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TelemetrySeriesQueryParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelemetrySeriesQueryParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KioskId == input.KioskId ||
                    (this.KioskId != null &&
                    this.KioskId.Equals(input.KioskId))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.KioskId != null)
                    hashCode = hashCode * 59 + this.KioskId.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
