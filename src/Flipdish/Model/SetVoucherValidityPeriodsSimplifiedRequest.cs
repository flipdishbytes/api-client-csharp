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
    /// SetVoucherValidityPeriodsSimplifiedRequest
    /// </summary>
    [DataContract]
    public partial class SetVoucherValidityPeriodsSimplifiedRequest :  IEquatable<SetVoucherValidityPeriodsSimplifiedRequest>
    {
        /// <summary>
        /// Defines DaysOfWeek
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DaysOfWeekEnum
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
        /// Days of week when the voucher is valid
        /// </summary>
        /// <value>Days of week when the voucher is valid</value>
        [DataMember(Name="DaysOfWeek", EmitDefaultValue=false)]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetVoucherValidityPeriodsSimplifiedRequest" /> class.
        /// </summary>
        /// <param name="daysOfWeek">Days of week when the voucher is valid.</param>
        /// <param name="startTime">Start time of the day when the voucher is valid.</param>
        /// <param name="endTime">End time of the day when the voucher is valid.  If the end time is before the start time, the end time is assumed to be the next day..</param>
        public SetVoucherValidityPeriodsSimplifiedRequest(List<DaysOfWeekEnum> daysOfWeek = default(List<DaysOfWeekEnum>), string startTime = default(string), string endTime = default(string))
        {
            this.DaysOfWeek = daysOfWeek;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
        

        /// <summary>
        /// Start time of the day when the voucher is valid
        /// </summary>
        /// <value>Start time of the day when the voucher is valid</value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// End time of the day when the voucher is valid.  If the end time is before the start time, the end time is assumed to be the next day.
        /// </summary>
        /// <value>End time of the day when the voucher is valid.  If the end time is before the start time, the end time is assumed to be the next day.</value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetVoucherValidityPeriodsSimplifiedRequest {\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as SetVoucherValidityPeriodsSimplifiedRequest);
        }

        /// <summary>
        /// Returns true if SetVoucherValidityPeriodsSimplifiedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetVoucherValidityPeriodsSimplifiedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetVoucherValidityPeriodsSimplifiedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysOfWeek == input.DaysOfWeek ||
                    this.DaysOfWeek != null &&
                    this.DaysOfWeek.SequenceEqual(input.DaysOfWeek)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.DaysOfWeek != null)
                    hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }

}
