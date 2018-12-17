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
    /// Provides an average value for a single hour of day of the week
    /// </summary>
    [DataContract]
    public partial class ApmAverageHourlyDataPoint :  IEquatable<ApmAverageHourlyDataPoint>, IValidatableObject
    {
        /// <summary>
        /// Day of the week
        /// </summary>
        /// <value>Day of the week</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayEnum
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
        /// Day of the week
        /// </summary>
        /// <value>Day of the week</value>
        [DataMember(Name="Day", EmitDefaultValue=false)]
        public DayEnum? Day { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApmAverageHourlyDataPoint" /> class.
        /// </summary>
        /// <param name="Day">Day of the week.</param>
        /// <param name="Hour">Hour in the day.</param>
        /// <param name="AverageValue">Average Value.</param>
        public ApmAverageHourlyDataPoint(DayEnum? Day = default(DayEnum?), int? Hour = default(int?), double? AverageValue = default(double?))
        {
            this.Day = Day;
            this.Hour = Hour;
            this.AverageValue = AverageValue;
        }
        

        /// <summary>
        /// Hour in the day
        /// </summary>
        /// <value>Hour in the day</value>
        [DataMember(Name="Hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// Average Value
        /// </summary>
        /// <value>Average Value</value>
        [DataMember(Name="AverageValue", EmitDefaultValue=false)]
        public double? AverageValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApmAverageHourlyDataPoint {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
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
            return this.Equals(input as ApmAverageHourlyDataPoint);
        }

        /// <summary>
        /// Returns true if ApmAverageHourlyDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ApmAverageHourlyDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApmAverageHourlyDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
                ) && 
                (
                    this.AverageValue == input.AverageValue ||
                    (this.AverageValue != null &&
                    this.AverageValue.Equals(input.AverageValue))
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
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                if (this.AverageValue != null)
                    hashCode = hashCode * 59 + this.AverageValue.GetHashCode();
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
