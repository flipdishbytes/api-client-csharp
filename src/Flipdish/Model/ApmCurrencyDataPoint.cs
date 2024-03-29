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
    /// A single data point in timeline graphs related to APM
    /// </summary>
    [DataContract]
    public partial class ApmCurrencyDataPoint :  IEquatable<ApmCurrencyDataPoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApmCurrencyDataPoint" /> class.
        /// </summary>
        /// <param name="periodStart">Date from which the data point starts.</param>
        /// <param name="periodLengthInDays">The length in days that this data point covers.</param>
        /// <param name="currencyData">The values of this data point.</param>
        public ApmCurrencyDataPoint(DateTime? periodStart = default(DateTime?), int? periodLengthInDays = default(int?), List<CurrencyData> currencyData = default(List<CurrencyData>))
        {
            this.PeriodStart = periodStart;
            this.PeriodLengthInDays = periodLengthInDays;
            this.CurrencyData = currencyData;
        }
        
        /// <summary>
        /// Date from which the data point starts
        /// </summary>
        /// <value>Date from which the data point starts</value>
        [DataMember(Name="PeriodStart", EmitDefaultValue=false)]
        public DateTime? PeriodStart { get; set; }

        /// <summary>
        /// The length in days that this data point covers
        /// </summary>
        /// <value>The length in days that this data point covers</value>
        [DataMember(Name="PeriodLengthInDays", EmitDefaultValue=false)]
        public int? PeriodLengthInDays { get; set; }

        /// <summary>
        /// The values of this data point
        /// </summary>
        /// <value>The values of this data point</value>
        [DataMember(Name="CurrencyData", EmitDefaultValue=false)]
        public List<CurrencyData> CurrencyData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApmCurrencyDataPoint {\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodLengthInDays: ").Append(PeriodLengthInDays).Append("\n");
            sb.Append("  CurrencyData: ").Append(CurrencyData).Append("\n");
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
            return this.Equals(input as ApmCurrencyDataPoint);
        }

        /// <summary>
        /// Returns true if ApmCurrencyDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ApmCurrencyDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApmCurrencyDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.PeriodLengthInDays == input.PeriodLengthInDays ||
                    (this.PeriodLengthInDays != null &&
                    this.PeriodLengthInDays.Equals(input.PeriodLengthInDays))
                ) && 
                (
                    this.CurrencyData == input.CurrencyData ||
                    this.CurrencyData != null &&
                    this.CurrencyData.SequenceEqual(input.CurrencyData)
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
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.PeriodLengthInDays != null)
                    hashCode = hashCode * 59 + this.PeriodLengthInDays.GetHashCode();
                if (this.CurrencyData != null)
                    hashCode = hashCode * 59 + this.CurrencyData.GetHashCode();
                return hashCode;
            }
        }
    }

}
