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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// TeammateBase
    /// </summary>
    [DataContract]
    public partial class TeammateBase :  IEquatable<TeammateBase>, IValidatableObject
    {
        /// <summary>
        /// App access level
        /// </summary>
        /// <value>App access level</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppAccessLevelEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Owner for value: Owner
            /// </summary>
            [EnumMember(Value = "Owner")]
            Owner = 2,
            
            /// <summary>
            /// Enum StoreOwner for value: StoreOwner
            /// </summary>
            [EnumMember(Value = "StoreOwner")]
            StoreOwner = 3,
            
            /// <summary>
            /// Enum ManagedOwner for value: ManagedOwner
            /// </summary>
            [EnumMember(Value = "ManagedOwner")]
            ManagedOwner = 4,
            
            /// <summary>
            /// Enum StoreManager for value: StoreManager
            /// </summary>
            [EnumMember(Value = "StoreManager")]
            StoreManager = 5,
            
            /// <summary>
            /// Enum StoreStaff for value: StoreStaff
            /// </summary>
            [EnumMember(Value = "StoreStaff")]
            StoreStaff = 6,
            
            /// <summary>
            /// Enum StoreReadOnlyAccess for value: StoreReadOnlyAccess
            /// </summary>
            [EnumMember(Value = "StoreReadOnlyAccess")]
            StoreReadOnlyAccess = 7,
            
            /// <summary>
            /// Enum FinanceManger for value: FinanceManger
            /// </summary>
            [EnumMember(Value = "FinanceManger")]
            FinanceManger = 8
        }

        /// <summary>
        /// App access level
        /// </summary>
        /// <value>App access level</value>
        [DataMember(Name="AppAccessLevel", EmitDefaultValue=false)]
        public AppAccessLevelEnum? AppAccessLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeammateBase" /> class.
        /// </summary>
        /// <param name="appAccessLevel">App access level.</param>
        /// <param name="hasAccessToAllStores">The user has access to all stores for the app (including new stores that added later).</param>
        /// <param name="storeIds">Store IDs the user has access to (if HasAccessToAllStores is false).</param>
        public TeammateBase(AppAccessLevelEnum? appAccessLevel = default(AppAccessLevelEnum?), bool? hasAccessToAllStores = default(bool?), List<int?> storeIds = default(List<int?>))
        {
            this.AppAccessLevel = appAccessLevel;
            this.HasAccessToAllStores = hasAccessToAllStores;
            this.StoreIds = storeIds;
        }
        

        /// <summary>
        /// The user has access to all stores for the app (including new stores that added later)
        /// </summary>
        /// <value>The user has access to all stores for the app (including new stores that added later)</value>
        [DataMember(Name="HasAccessToAllStores", EmitDefaultValue=false)]
        public bool? HasAccessToAllStores { get; set; }

        /// <summary>
        /// Store IDs the user has access to (if HasAccessToAllStores is false)
        /// </summary>
        /// <value>Store IDs the user has access to (if HasAccessToAllStores is false)</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeammateBase {\n");
            sb.Append("  AppAccessLevel: ").Append(AppAccessLevel).Append("\n");
            sb.Append("  HasAccessToAllStores: ").Append(HasAccessToAllStores).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
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
            return this.Equals(input as TeammateBase);
        }

        /// <summary>
        /// Returns true if TeammateBase instances are equal
        /// </summary>
        /// <param name="input">Instance of TeammateBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeammateBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppAccessLevel == input.AppAccessLevel ||
                    (this.AppAccessLevel != null &&
                    this.AppAccessLevel.Equals(input.AppAccessLevel))
                ) && 
                (
                    this.HasAccessToAllStores == input.HasAccessToAllStores ||
                    (this.HasAccessToAllStores != null &&
                    this.HasAccessToAllStores.Equals(input.HasAccessToAllStores))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
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
                if (this.AppAccessLevel != null)
                    hashCode = hashCode * 59 + this.AppAccessLevel.GetHashCode();
                if (this.HasAccessToAllStores != null)
                    hashCode = hashCode * 59 + this.HasAccessToAllStores.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
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
