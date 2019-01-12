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
    /// Teammate
    /// </summary>
    [DataContract]
    public partial class Teammate :  IEquatable<Teammate>, IValidatableObject
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
            /// Enum ManagedOwner for value: ManagedOwner
            /// </summary>
            [EnumMember(Value = "ManagedOwner")]
            ManagedOwner = 3,
            
            /// <summary>
            /// Enum StoreManager for value: StoreManager
            /// </summary>
            [EnumMember(Value = "StoreManager")]
            StoreManager = 4,
            
            /// <summary>
            /// Enum StoreStaff for value: StoreStaff
            /// </summary>
            [EnumMember(Value = "StoreStaff")]
            StoreStaff = 5,
            
            /// <summary>
            /// Enum FinanceManger for value: FinanceManger
            /// </summary>
            [EnumMember(Value = "FinanceManger")]
            FinanceManger = 6
        }

        /// <summary>
        /// App access level
        /// </summary>
        /// <value>App access level</value>
        [DataMember(Name="AppAccessLevel", EmitDefaultValue=false)]
        public AppAccessLevelEnum? AppAccessLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Teammate" /> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="lastAcitivity">Last activity.</param>
        /// <param name="appId">Access level is for this App.</param>
        /// <param name="email">Email address.</param>
        /// <param name="appAccessLevel">App access level.</param>
        /// <param name="hasAccessToAllStores">The user has access to all stores for the app (including new stores that added later).</param>
        /// <param name="storeIds">Store IDs the user has access to (if HasAccessToAllStores is false).</param>
        public Teammate(string name = default(string), DateTime? lastAcitivity = default(DateTime?), string appId = default(string), string email = default(string), AppAccessLevelEnum? appAccessLevel = default(AppAccessLevelEnum?), bool? hasAccessToAllStores = default(bool?), List<int?> storeIds = default(List<int?>))
        {
            this.Name = name;
            this.LastAcitivity = lastAcitivity;
            this.AppId = appId;
            this.Email = email;
            this.AppAccessLevel = appAccessLevel;
            this.HasAccessToAllStores = hasAccessToAllStores;
            this.StoreIds = storeIds;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Last activity
        /// </summary>
        /// <value>Last activity</value>
        [DataMember(Name="LastAcitivity", EmitDefaultValue=false)]
        public DateTime? LastAcitivity { get; set; }

        /// <summary>
        /// Access level is for this App
        /// </summary>
        /// <value>Access level is for this App</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }


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
            sb.Append("class Teammate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastAcitivity: ").Append(LastAcitivity).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as Teammate);
        }

        /// <summary>
        /// Returns true if Teammate instances are equal
        /// </summary>
        /// <param name="input">Instance of Teammate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Teammate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastAcitivity == input.LastAcitivity ||
                    (this.LastAcitivity != null &&
                    this.LastAcitivity.Equals(input.LastAcitivity))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LastAcitivity != null)
                    hashCode = hashCode * 59 + this.LastAcitivity.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
