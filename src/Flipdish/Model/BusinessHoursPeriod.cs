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
    /// Business hours period
    /// </summary>
    [DataContract]
    public partial class BusinessHoursPeriod :  IEquatable<BusinessHoursPeriod>, IValidatableObject
    {
        /// <summary>
        /// Day of week
        /// </summary>
        /// <value>Day of week</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {
            
            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 1,
            
            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 2,
            
            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 3,
            
            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 4,
            
            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 5,
            
            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 6,
            
            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 7
        }

        /// <summary>
        /// Day of week
        /// </summary>
        /// <value>Day of week</value>
        [DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHoursPeriod" /> class.
        /// </summary>
        /// <param name="Early">Early.</param>
        /// <param name="Late">Late.</param>
        /// <param name="Ranges">Ranges.</param>
        /// <param name="DayOfWeek">Day of week.</param>
        /// <param name="StartTime">Start time.</param>
        /// <param name="Period">Period.</param>
        /// <param name="StartTimeEarly">Start time early.</param>
        /// <param name="PeriodEarly">Period early.</param>
        public BusinessHoursPeriod(Range Early = default(Range), Range Late = default(Range), List<Range> Ranges = default(List<Range>), DayOfWeekEnum? DayOfWeek = default(DayOfWeekEnum?), string StartTime = default(string), string Period = default(string), string StartTimeEarly = default(string), string PeriodEarly = default(string))
        {
            this.Early = Early;
            this.Late = Late;
            this.Ranges = Ranges;
            this.DayOfWeek = DayOfWeek;
            this.StartTime = StartTime;
            this.Period = Period;
            this.StartTimeEarly = StartTimeEarly;
            this.PeriodEarly = PeriodEarly;
        }
        
        /// <summary>
        /// Early
        /// </summary>
        /// <value>Early</value>
        [DataMember(Name="Early", EmitDefaultValue=false)]
        public Range Early { get; set; }

        /// <summary>
        /// Late
        /// </summary>
        /// <value>Late</value>
        [DataMember(Name="Late", EmitDefaultValue=false)]
        public Range Late { get; set; }

        /// <summary>
        /// Ranges
        /// </summary>
        /// <value>Ranges</value>
        [DataMember(Name="Ranges", EmitDefaultValue=false)]
        public List<Range> Ranges { get; set; }


        /// <summary>
        /// Start time
        /// </summary>
        /// <value>Start time</value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Period
        /// </summary>
        /// <value>Period</value>
        [DataMember(Name="Period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Start time early
        /// </summary>
        /// <value>Start time early</value>
        [DataMember(Name="StartTimeEarly", EmitDefaultValue=false)]
        public string StartTimeEarly { get; set; }

        /// <summary>
        /// Period early
        /// </summary>
        /// <value>Period early</value>
        [DataMember(Name="PeriodEarly", EmitDefaultValue=false)]
        public string PeriodEarly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHoursPeriod {\n");
            sb.Append("  Early: ").Append(Early).Append("\n");
            sb.Append("  Late: ").Append(Late).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  StartTimeEarly: ").Append(StartTimeEarly).Append("\n");
            sb.Append("  PeriodEarly: ").Append(PeriodEarly).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessHoursPeriod);
        }

        /// <summary>
        /// Returns true if BusinessHoursPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessHoursPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHoursPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Early == input.Early ||
                    (this.Early != null &&
                    this.Early.Equals(input.Early))
                ) && 
                (
                    this.Late == input.Late ||
                    (this.Late != null &&
                    this.Late.Equals(input.Late))
                ) && 
                (
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(input.Ranges)
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.StartTimeEarly == input.StartTimeEarly ||
                    (this.StartTimeEarly != null &&
                    this.StartTimeEarly.Equals(input.StartTimeEarly))
                ) && 
                (
                    this.PeriodEarly == input.PeriodEarly ||
                    (this.PeriodEarly != null &&
                    this.PeriodEarly.Equals(input.PeriodEarly))
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
                if (this.Early != null)
                    hashCode = hashCode * 59 + this.Early.GetHashCode();
                if (this.Late != null)
                    hashCode = hashCode * 59 + this.Late.GetHashCode();
                if (this.Ranges != null)
                    hashCode = hashCode * 59 + this.Ranges.GetHashCode();
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.StartTimeEarly != null)
                    hashCode = hashCode * 59 + this.StartTimeEarly.GetHashCode();
                if (this.PeriodEarly != null)
                    hashCode = hashCode * 59 + this.PeriodEarly.GetHashCode();
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
