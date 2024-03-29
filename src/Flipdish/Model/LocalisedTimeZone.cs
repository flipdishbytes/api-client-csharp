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
    /// Represents a localised time zone
    /// </summary>
    [DataContract]
    public partial class LocalisedTimeZone :  IEquatable<LocalisedTimeZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalisedTimeZone" /> class.
        /// </summary>
        /// <param name="timeZoneId">Microsoft Time Zone Id.</param>
        /// <param name="ianaTimeZoneId">Iana Time Zone Id.</param>
        /// <param name="displayName">Display name in users language.</param>
        public LocalisedTimeZone(string timeZoneId = default(string), string ianaTimeZoneId = default(string), string displayName = default(string))
        {
            this.TimeZoneId = timeZoneId;
            this.IanaTimeZoneId = ianaTimeZoneId;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Microsoft Time Zone Id
        /// </summary>
        /// <value>Microsoft Time Zone Id</value>
        [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Iana Time Zone Id
        /// </summary>
        /// <value>Iana Time Zone Id</value>
        [DataMember(Name="IanaTimeZoneId", EmitDefaultValue=false)]
        public string IanaTimeZoneId { get; set; }

        /// <summary>
        /// Display name in users language
        /// </summary>
        /// <value>Display name in users language</value>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalisedTimeZone {\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  IanaTimeZoneId: ").Append(IanaTimeZoneId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as LocalisedTimeZone);
        }

        /// <summary>
        /// Returns true if LocalisedTimeZone instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalisedTimeZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalisedTimeZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeZoneId == input.TimeZoneId ||
                    (this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(input.TimeZoneId))
                ) && 
                (
                    this.IanaTimeZoneId == input.IanaTimeZoneId ||
                    (this.IanaTimeZoneId != null &&
                    this.IanaTimeZoneId.Equals(input.IanaTimeZoneId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.TimeZoneId != null)
                    hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                if (this.IanaTimeZoneId != null)
                    hashCode = hashCode * 59 + this.IanaTimeZoneId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }

}
