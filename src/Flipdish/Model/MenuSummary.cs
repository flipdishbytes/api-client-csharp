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
    /// Menu Summary
    /// </summary>
    [DataContract]
    public partial class MenuSummary :  IEquatable<MenuSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuSummary" /> class.
        /// </summary>
        /// <param name="menuId">Menu identifier.</param>
        /// <param name="modifiedTime">Last modified time.</param>
        /// <param name="versionNumber">Menu version.</param>
        /// <param name="menuUrl">Menu Url.</param>
        /// <param name="name">Name of Menu, only shown in portal.</param>
        /// <param name="locked">Locked: is menu locked against modifcation.</param>
        /// <param name="storeNames">List of stores names which are associated with this menu.</param>
        /// <param name="isIntegrated">Flag to indicate if the menu is integrated (contains metadata).</param>
        public MenuSummary(int? menuId = default(int?), DateTime? modifiedTime = default(DateTime?), int? versionNumber = default(int?), string menuUrl = default(string), string name = default(string), bool? locked = default(bool?), List<string> storeNames = default(List<string>), bool? isIntegrated = default(bool?))
        {
            this.MenuId = menuId;
            this.ModifiedTime = modifiedTime;
            this.VersionNumber = versionNumber;
            this.MenuUrl = menuUrl;
            this.Name = name;
            this.Locked = locked;
            this.StoreNames = storeNames;
            this.IsIntegrated = isIntegrated;
        }
        
        /// <summary>
        /// Menu identifier
        /// </summary>
        /// <value>Menu identifier</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Last modified time
        /// </summary>
        /// <value>Last modified time</value>
        [DataMember(Name="ModifiedTime", EmitDefaultValue=false)]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Menu version
        /// </summary>
        /// <value>Menu version</value>
        [DataMember(Name="VersionNumber", EmitDefaultValue=false)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Menu Url
        /// </summary>
        /// <value>Menu Url</value>
        [DataMember(Name="MenuUrl", EmitDefaultValue=false)]
        public string MenuUrl { get; set; }

        /// <summary>
        /// Name of Menu, only shown in portal
        /// </summary>
        /// <value>Name of Menu, only shown in portal</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Locked: is menu locked against modifcation
        /// </summary>
        /// <value>Locked: is menu locked against modifcation</value>
        [DataMember(Name="Locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// List of stores names which are associated with this menu
        /// </summary>
        /// <value>List of stores names which are associated with this menu</value>
        [DataMember(Name="StoreNames", EmitDefaultValue=false)]
        public List<string> StoreNames { get; set; }

        /// <summary>
        /// Flag to indicate if the menu is integrated (contains metadata)
        /// </summary>
        /// <value>Flag to indicate if the menu is integrated (contains metadata)</value>
        [DataMember(Name="IsIntegrated", EmitDefaultValue=false)]
        public bool? IsIntegrated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuSummary {\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  MenuUrl: ").Append(MenuUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  StoreNames: ").Append(StoreNames).Append("\n");
            sb.Append("  IsIntegrated: ").Append(IsIntegrated).Append("\n");
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
            return this.Equals(input as MenuSummary);
        }

        /// <summary>
        /// Returns true if MenuSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.ModifiedTime == input.ModifiedTime ||
                    (this.ModifiedTime != null &&
                    this.ModifiedTime.Equals(input.ModifiedTime))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.MenuUrl == input.MenuUrl ||
                    (this.MenuUrl != null &&
                    this.MenuUrl.Equals(input.MenuUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.StoreNames == input.StoreNames ||
                    this.StoreNames != null &&
                    this.StoreNames.SequenceEqual(input.StoreNames)
                ) && 
                (
                    this.IsIntegrated == input.IsIntegrated ||
                    (this.IsIntegrated != null &&
                    this.IsIntegrated.Equals(input.IsIntegrated))
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
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.ModifiedTime != null)
                    hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.MenuUrl != null)
                    hashCode = hashCode * 59 + this.MenuUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.StoreNames != null)
                    hashCode = hashCode * 59 + this.StoreNames.GetHashCode();
                if (this.IsIntegrated != null)
                    hashCode = hashCode * 59 + this.IsIntegrated.GetHashCode();
                return hashCode;
            }
        }
    }

}
