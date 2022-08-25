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
    /// Hey
    /// </summary>
    [DataContract]
    public partial class StoreValidationConfig :  IEquatable<StoreValidationConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreValidationConfig" /> class.
        /// </summary>
        /// <param name="storeId">Store identifier.</param>
        /// <param name="name">name.</param>
        /// <param name="isValid">Is Store Valid for Kiosk.</param>
        /// <param name="storeGroupId">Store group Id.</param>
        /// <param name="configValidation">configValidation.</param>
        public StoreValidationConfig(int? storeId = default(int?), string name = default(string), bool? isValid = default(bool?), int? storeGroupId = default(int?), StoreConfig configValidation = default(StoreConfig))
        {
            this.StoreId = storeId;
            this.Name = name;
            this.IsValid = isValid;
            this.StoreGroupId = storeGroupId;
            this.ConfigValidation = configValidation;
        }
        
        /// <summary>
        /// Store identifier
        /// </summary>
        /// <value>Store identifier</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Is Store Valid for Kiosk
        /// </summary>
        /// <value>Is Store Valid for Kiosk</value>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Store group Id
        /// </summary>
        /// <value>Store group Id</value>
        [DataMember(Name="StoreGroupId", EmitDefaultValue=false)]
        public int? StoreGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigValidation
        /// </summary>
        [DataMember(Name="ConfigValidation", EmitDefaultValue=false)]
        public StoreConfig ConfigValidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreValidationConfig {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  StoreGroupId: ").Append(StoreGroupId).Append("\n");
            sb.Append("  ConfigValidation: ").Append(ConfigValidation).Append("\n");
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
            return this.Equals(input as StoreValidationConfig);
        }

        /// <summary>
        /// Returns true if StoreValidationConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreValidationConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreValidationConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.StoreGroupId == input.StoreGroupId ||
                    (this.StoreGroupId != null &&
                    this.StoreGroupId.Equals(input.StoreGroupId))
                ) && 
                (
                    this.ConfigValidation == input.ConfigValidation ||
                    (this.ConfigValidation != null &&
                    this.ConfigValidation.Equals(input.ConfigValidation))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.StoreGroupId != null)
                    hashCode = hashCode * 59 + this.StoreGroupId.GetHashCode();
                if (this.ConfigValidation != null)
                    hashCode = hashCode * 59 + this.ConfigValidation.GetHashCode();
                return hashCode;
            }
        }
    }

}
