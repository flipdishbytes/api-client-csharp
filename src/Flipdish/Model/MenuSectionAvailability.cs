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
    /// Menu section availability
    /// </summary>
    [DataContract]
    public partial class MenuSectionAvailability :  IEquatable<MenuSectionAvailability>, IValidatableObject
    {
        /// <summary>
        /// Availability mode
        /// </summary>
        /// <value>Availability mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityModeEnum
        {
            
            /// <summary>
            /// Enum DisplayAlways for value: DisplayAlways
            /// </summary>
            [EnumMember(Value = "DisplayAlways")]
            DisplayAlways = 1,
            
            /// <summary>
            /// Enum DisplayBasedOnTimes for value: DisplayBasedOnTimes
            /// </summary>
            [EnumMember(Value = "DisplayBasedOnTimes")]
            DisplayBasedOnTimes = 2,
            
            /// <summary>
            /// Enum DisplayAlwaysStartCollapsed for value: DisplayAlwaysStartCollapsed
            /// </summary>
            [EnumMember(Value = "DisplayAlwaysStartCollapsed")]
            DisplayAlwaysStartCollapsed = 3,
            
            /// <summary>
            /// Enum DisplayAlwaysStartCollapsedBasedOnTimes for value: DisplayAlwaysStartCollapsedBasedOnTimes
            /// </summary>
            [EnumMember(Value = "DisplayAlwaysStartCollapsedBasedOnTimes")]
            DisplayAlwaysStartCollapsedBasedOnTimes = 4
        }

        /// <summary>
        /// Availability mode
        /// </summary>
        /// <value>Availability mode</value>
        [DataMember(Name="availabilityMode", EmitDefaultValue=false)]
        public AvailabilityModeEnum? AvailabilityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuSectionAvailability" /> class.
        /// </summary>
        /// <param name="AvailableTimes">Available times.</param>
        /// <param name="AvailabilityMode">Availability mode.</param>
        public MenuSectionAvailability(List<BusinessHoursPeriod> AvailableTimes = default(List<BusinessHoursPeriod>), AvailabilityModeEnum? AvailabilityMode = default(AvailabilityModeEnum?))
        {
            this.AvailableTimes = AvailableTimes;
            this.AvailabilityMode = AvailabilityMode;
        }
        
        /// <summary>
        /// Available times
        /// </summary>
        /// <value>Available times</value>
        [DataMember(Name="availableTimes", EmitDefaultValue=false)]
        public List<BusinessHoursPeriod> AvailableTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuSectionAvailability {\n");
            sb.Append("  AvailableTimes: ").Append(AvailableTimes).Append("\n");
            sb.Append("  AvailabilityMode: ").Append(AvailabilityMode).Append("\n");
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
            return this.Equals(input as MenuSectionAvailability);
        }

        /// <summary>
        /// Returns true if MenuSectionAvailability instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuSectionAvailability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuSectionAvailability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableTimes == input.AvailableTimes ||
                    this.AvailableTimes != null &&
                    this.AvailableTimes.SequenceEqual(input.AvailableTimes)
                ) && 
                (
                    this.AvailabilityMode == input.AvailabilityMode ||
                    (this.AvailabilityMode != null &&
                    this.AvailabilityMode.Equals(input.AvailabilityMode))
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
                if (this.AvailableTimes != null)
                    hashCode = hashCode * 59 + this.AvailableTimes.GetHashCode();
                if (this.AvailabilityMode != null)
                    hashCode = hashCode * 59 + this.AvailabilityMode.GetHashCode();
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
