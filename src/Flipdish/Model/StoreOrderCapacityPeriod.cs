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
    /// Represents a single order capacity period
    /// </summary>
    [DataContract]
    public partial class StoreOrderCapacityPeriod :  IEquatable<StoreOrderCapacityPeriod>, IValidatableObject
    {
        /// <summary>
        /// Day of the week the period pertains to
        /// </summary>
        /// <value>Day of the week the period pertains to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfTheWeekEnum
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
        /// Day of the week the period pertains to
        /// </summary>
        /// <value>Day of the week the period pertains to</value>
        [DataMember(Name="DayOfTheWeek", EmitDefaultValue=false)]
        public DayOfTheWeekEnum? DayOfTheWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderCapacityPeriod" /> class.
        /// </summary>
        /// <param name="maxOrderNumberPerStoreInterval">The maximum number of orders per each store order interval in this order capacity period.  E.g. for a period from 9:00 till 11:00, if the store&#39;s interval is 10 minutes, and MaxOrderNumberPerStoreInterval is set to 5,  it means that within each 10-minute interval between 9:00 and 11:00 (i.e. 9:00-9:10, 9:10-9:20, .. , 10:50-11:00) it will be possible to  request at most 5 orders..</param>
        /// <param name="dayOfTheWeek">Day of the week the period pertains to.</param>
        /// <param name="periodStartHour">The hour the period starts at.</param>
        /// <param name="periodStartMinutes">The minutes after the hour the period starts at.</param>
        /// <param name="periodEndHour">The hour the period ends at.</param>
        /// <param name="periodEndMinutes">The minutes after the hour the period ends at.</param>
        public StoreOrderCapacityPeriod(int? maxOrderNumberPerStoreInterval = default(int?), DayOfTheWeekEnum? dayOfTheWeek = default(DayOfTheWeekEnum?), int? periodStartHour = default(int?), int? periodStartMinutes = default(int?), int? periodEndHour = default(int?), int? periodEndMinutes = default(int?))
        {
            this.MaxOrderNumberPerStoreInterval = maxOrderNumberPerStoreInterval;
            this.DayOfTheWeek = dayOfTheWeek;
            this.PeriodStartHour = periodStartHour;
            this.PeriodStartMinutes = periodStartMinutes;
            this.PeriodEndHour = periodEndHour;
            this.PeriodEndMinutes = periodEndMinutes;
        }
        
        /// <summary>
        /// The maximum number of orders per each store order interval in this order capacity period.  E.g. for a period from 9:00 till 11:00, if the store&#39;s interval is 10 minutes, and MaxOrderNumberPerStoreInterval is set to 5,  it means that within each 10-minute interval between 9:00 and 11:00 (i.e. 9:00-9:10, 9:10-9:20, .. , 10:50-11:00) it will be possible to  request at most 5 orders.
        /// </summary>
        /// <value>The maximum number of orders per each store order interval in this order capacity period.  E.g. for a period from 9:00 till 11:00, if the store&#39;s interval is 10 minutes, and MaxOrderNumberPerStoreInterval is set to 5,  it means that within each 10-minute interval between 9:00 and 11:00 (i.e. 9:00-9:10, 9:10-9:20, .. , 10:50-11:00) it will be possible to  request at most 5 orders.</value>
        [DataMember(Name="MaxOrderNumberPerStoreInterval", EmitDefaultValue=false)]
        public int? MaxOrderNumberPerStoreInterval { get; set; }


        /// <summary>
        /// The hour the period starts at
        /// </summary>
        /// <value>The hour the period starts at</value>
        [DataMember(Name="PeriodStartHour", EmitDefaultValue=false)]
        public int? PeriodStartHour { get; set; }

        /// <summary>
        /// The minutes after the hour the period starts at
        /// </summary>
        /// <value>The minutes after the hour the period starts at</value>
        [DataMember(Name="PeriodStartMinutes", EmitDefaultValue=false)]
        public int? PeriodStartMinutes { get; set; }

        /// <summary>
        /// The hour the period ends at
        /// </summary>
        /// <value>The hour the period ends at</value>
        [DataMember(Name="PeriodEndHour", EmitDefaultValue=false)]
        public int? PeriodEndHour { get; set; }

        /// <summary>
        /// The minutes after the hour the period ends at
        /// </summary>
        /// <value>The minutes after the hour the period ends at</value>
        [DataMember(Name="PeriodEndMinutes", EmitDefaultValue=false)]
        public int? PeriodEndMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreOrderCapacityPeriod {\n");
            sb.Append("  MaxOrderNumberPerStoreInterval: ").Append(MaxOrderNumberPerStoreInterval).Append("\n");
            sb.Append("  DayOfTheWeek: ").Append(DayOfTheWeek).Append("\n");
            sb.Append("  PeriodStartHour: ").Append(PeriodStartHour).Append("\n");
            sb.Append("  PeriodStartMinutes: ").Append(PeriodStartMinutes).Append("\n");
            sb.Append("  PeriodEndHour: ").Append(PeriodEndHour).Append("\n");
            sb.Append("  PeriodEndMinutes: ").Append(PeriodEndMinutes).Append("\n");
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
            return this.Equals(input as StoreOrderCapacityPeriod);
        }

        /// <summary>
        /// Returns true if StoreOrderCapacityPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreOrderCapacityPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreOrderCapacityPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxOrderNumberPerStoreInterval == input.MaxOrderNumberPerStoreInterval ||
                    (this.MaxOrderNumberPerStoreInterval != null &&
                    this.MaxOrderNumberPerStoreInterval.Equals(input.MaxOrderNumberPerStoreInterval))
                ) && 
                (
                    this.DayOfTheWeek == input.DayOfTheWeek ||
                    (this.DayOfTheWeek != null &&
                    this.DayOfTheWeek.Equals(input.DayOfTheWeek))
                ) && 
                (
                    this.PeriodStartHour == input.PeriodStartHour ||
                    (this.PeriodStartHour != null &&
                    this.PeriodStartHour.Equals(input.PeriodStartHour))
                ) && 
                (
                    this.PeriodStartMinutes == input.PeriodStartMinutes ||
                    (this.PeriodStartMinutes != null &&
                    this.PeriodStartMinutes.Equals(input.PeriodStartMinutes))
                ) && 
                (
                    this.PeriodEndHour == input.PeriodEndHour ||
                    (this.PeriodEndHour != null &&
                    this.PeriodEndHour.Equals(input.PeriodEndHour))
                ) && 
                (
                    this.PeriodEndMinutes == input.PeriodEndMinutes ||
                    (this.PeriodEndMinutes != null &&
                    this.PeriodEndMinutes.Equals(input.PeriodEndMinutes))
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
                if (this.MaxOrderNumberPerStoreInterval != null)
                    hashCode = hashCode * 59 + this.MaxOrderNumberPerStoreInterval.GetHashCode();
                if (this.DayOfTheWeek != null)
                    hashCode = hashCode * 59 + this.DayOfTheWeek.GetHashCode();
                if (this.PeriodStartHour != null)
                    hashCode = hashCode * 59 + this.PeriodStartHour.GetHashCode();
                if (this.PeriodStartMinutes != null)
                    hashCode = hashCode * 59 + this.PeriodStartMinutes.GetHashCode();
                if (this.PeriodEndHour != null)
                    hashCode = hashCode * 59 + this.PeriodEndHour.GetHashCode();
                if (this.PeriodEndMinutes != null)
                    hashCode = hashCode * 59 + this.PeriodEndMinutes.GetHashCode();
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
