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
    /// Range
    /// </summary>
    [DataContract]
    public partial class Range :  IEquatable<Range>, IValidatableObject
    {
        /// <summary>
        /// Defines DayOfWeek
        /// </summary>
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
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="Period">Period.</param>
        /// <param name="DayOfWeek">DayOfWeek.</param>
        public Range(string StartTime = default(string), string Period = default(string), DayOfWeekEnum? DayOfWeek = default(DayOfWeekEnum?))
        {
            this.StartTime = StartTime;
            this.Period = Period;
            this.DayOfWeek = DayOfWeek;
        }
        
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Range {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
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
            return this.Equals(input as Range);
        }

        /// <summary>
        /// Returns true if Range instances are equal
        /// </summary>
        /// <param name="input">Instance of Range to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Range input)
        {
            if (input == null)
                return false;

            return 
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
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
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
