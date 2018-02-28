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
    /// BusinessHoursPeriod
    /// </summary>
    [DataContract]
    public partial class BusinessHoursPeriod :  IEquatable<BusinessHoursPeriod>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {
            
            /// <summary>
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday,
            
            /// <summary>
            /// Enum Monday for "Monday"
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday,
            
            /// <summary>
            /// Enum Tuesday for "Tuesday"
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday,
            
            /// <summary>
            /// Enum Wednesday for "Wednesday"
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday,
            
            /// <summary>
            /// Enum Thursday for "Thursday"
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday,
            
            /// <summary>
            /// Enum Friday for "Friday"
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday,
            
            /// <summary>
            /// Enum Saturday for "Saturday"
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday
        }

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHoursPeriod" /> class.
        /// </summary>
        /// <param name="DayOfWeek">DayOfWeek.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="Period">Period.</param>
        /// <param name="StartTimeEarly">StartTimeEarly.</param>
        /// <param name="PeriodEarly">PeriodEarly.</param>
        /// <param name="Early">Early.</param>
        /// <param name="Late">Late.</param>
        /// <param name="Ranges">Ranges.</param>
        public BusinessHoursPeriod(DayOfWeekEnum? DayOfWeek = default(DayOfWeekEnum?), string StartTime = default(string), string Period = default(string), string StartTimeEarly = default(string), string PeriodEarly = default(string), Range Early = default(Range), Range Late = default(Range), List<Range> Ranges = default(List<Range>))
        {
            this.DayOfWeek = DayOfWeek;
            this.StartTime = StartTime;
            this.Period = Period;
            this.StartTimeEarly = StartTimeEarly;
            this.PeriodEarly = PeriodEarly;
            this.Early = Early;
            this.Late = Late;
            this.Ranges = Ranges;
        }
        

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="Period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeEarly
        /// </summary>
        [DataMember(Name="StartTimeEarly", EmitDefaultValue=false)]
        public string StartTimeEarly { get; set; }

        /// <summary>
        /// Gets or Sets PeriodEarly
        /// </summary>
        [DataMember(Name="PeriodEarly", EmitDefaultValue=false)]
        public string PeriodEarly { get; set; }

        /// <summary>
        /// Gets or Sets Early
        /// </summary>
        [DataMember(Name="Early", EmitDefaultValue=false)]
        public Range Early { get; set; }

        /// <summary>
        /// Gets or Sets Late
        /// </summary>
        [DataMember(Name="Late", EmitDefaultValue=false)]
        public Range Late { get; set; }

        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name="Ranges", EmitDefaultValue=false)]
        public List<Range> Ranges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHoursPeriod {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  StartTimeEarly: ").Append(StartTimeEarly).Append("\n");
            sb.Append("  PeriodEarly: ").Append(PeriodEarly).Append("\n");
            sb.Append("  Early: ").Append(Early).Append("\n");
            sb.Append("  Late: ").Append(Late).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BusinessHoursPeriod);
        }

        /// <summary>
        /// Returns true if BusinessHoursPeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessHoursPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHoursPeriod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DayOfWeek == other.DayOfWeek ||
                    this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(other.DayOfWeek)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.StartTimeEarly == other.StartTimeEarly ||
                    this.StartTimeEarly != null &&
                    this.StartTimeEarly.Equals(other.StartTimeEarly)
                ) && 
                (
                    this.PeriodEarly == other.PeriodEarly ||
                    this.PeriodEarly != null &&
                    this.PeriodEarly.Equals(other.PeriodEarly)
                ) && 
                (
                    this.Early == other.Early ||
                    this.Early != null &&
                    this.Early.Equals(other.Early)
                ) && 
                (
                    this.Late == other.Late ||
                    this.Late != null &&
                    this.Late.Equals(other.Late)
                ) && 
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(other.Ranges)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DayOfWeek != null)
                    hash = hash * 59 + this.DayOfWeek.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.StartTimeEarly != null)
                    hash = hash * 59 + this.StartTimeEarly.GetHashCode();
                if (this.PeriodEarly != null)
                    hash = hash * 59 + this.PeriodEarly.GetHashCode();
                if (this.Early != null)
                    hash = hash * 59 + this.Early.GetHashCode();
                if (this.Late != null)
                    hash = hash * 59 + this.Late.GetHashCode();
                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();
                return hash;
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
