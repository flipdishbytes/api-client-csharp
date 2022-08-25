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
    /// Describes the configuration of OrderBatching
    /// </summary>
    [DataContract]
    public partial class SetOrderBatchingConfiguration :  IEquatable<SetOrderBatchingConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetOrderBatchingConfiguration" /> class.
        /// </summary>
        /// <param name="batchIntervalInMinutes">Batch sending interval in minutes.</param>
        /// <param name="enabled">OrderBatching is enabled or not.</param>
        public SetOrderBatchingConfiguration(int? batchIntervalInMinutes = default(int?), bool? enabled = default(bool?))
        {
            this.BatchIntervalInMinutes = batchIntervalInMinutes;
            this.Enabled = enabled;
        }
        
        /// <summary>
        /// Batch sending interval in minutes
        /// </summary>
        /// <value>Batch sending interval in minutes</value>
        [DataMember(Name="BatchIntervalInMinutes", EmitDefaultValue=false)]
        public int? BatchIntervalInMinutes { get; set; }

        /// <summary>
        /// OrderBatching is enabled or not
        /// </summary>
        /// <value>OrderBatching is enabled or not</value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetOrderBatchingConfiguration {\n");
            sb.Append("  BatchIntervalInMinutes: ").Append(BatchIntervalInMinutes).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as SetOrderBatchingConfiguration);
        }

        /// <summary>
        /// Returns true if SetOrderBatchingConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SetOrderBatchingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetOrderBatchingConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchIntervalInMinutes == input.BatchIntervalInMinutes ||
                    (this.BatchIntervalInMinutes != null &&
                    this.BatchIntervalInMinutes.Equals(input.BatchIntervalInMinutes))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.BatchIntervalInMinutes != null)
                    hashCode = hashCode * 59 + this.BatchIntervalInMinutes.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
