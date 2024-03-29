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
    /// LeadTime
    /// </summary>
    [DataContract]
    public partial class LeadTime :  IEquatable<LeadTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LeadTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadTime" /> class.
        /// </summary>
        /// <param name="dispatchType">There are two valid values for this field - &#x60;collection&#x60; and &#x60;delivery&#x60;. (required).</param>
        /// <param name="leadTimeMinutes">This must be a positive integer. (required).</param>
        public LeadTime(string dispatchType = default(string), int? leadTimeMinutes = default(int?))
        {
            // to ensure "dispatchType" is required (not null)
            if (dispatchType == null)
            {
                throw new InvalidDataException("dispatchType is a required property for LeadTime and cannot be null");
            }
            else
            {
                this.DispatchType = dispatchType;
            }
            // to ensure "leadTimeMinutes" is required (not null)
            if (leadTimeMinutes == null)
            {
                throw new InvalidDataException("leadTimeMinutes is a required property for LeadTime and cannot be null");
            }
            else
            {
                this.LeadTimeMinutes = leadTimeMinutes;
            }
        }
        
        /// <summary>
        /// There are two valid values for this field - &#x60;collection&#x60; and &#x60;delivery&#x60;.
        /// </summary>
        /// <value>There are two valid values for this field - &#x60;collection&#x60; and &#x60;delivery&#x60;.</value>
        [DataMember(Name="DispatchType", EmitDefaultValue=false)]
        public string DispatchType { get; set; }

        /// <summary>
        /// This must be a positive integer.
        /// </summary>
        /// <value>This must be a positive integer.</value>
        [DataMember(Name="LeadTimeMinutes", EmitDefaultValue=false)]
        public int? LeadTimeMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadTime {\n");
            sb.Append("  DispatchType: ").Append(DispatchType).Append("\n");
            sb.Append("  LeadTimeMinutes: ").Append(LeadTimeMinutes).Append("\n");
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
            return this.Equals(input as LeadTime);
        }

        /// <summary>
        /// Returns true if LeadTime instances are equal
        /// </summary>
        /// <param name="input">Instance of LeadTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeadTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DispatchType == input.DispatchType ||
                    (this.DispatchType != null &&
                    this.DispatchType.Equals(input.DispatchType))
                ) && 
                (
                    this.LeadTimeMinutes == input.LeadTimeMinutes ||
                    (this.LeadTimeMinutes != null &&
                    this.LeadTimeMinutes.Equals(input.LeadTimeMinutes))
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
                if (this.DispatchType != null)
                    hashCode = hashCode * 59 + this.DispatchType.GetHashCode();
                if (this.LeadTimeMinutes != null)
                    hashCode = hashCode * 59 + this.LeadTimeMinutes.GetHashCode();
                return hashCode;
            }
        }
    }

}
