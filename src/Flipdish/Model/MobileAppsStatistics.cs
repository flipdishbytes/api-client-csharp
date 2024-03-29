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
    /// Mobile Apps Statistics
    /// </summary>
    [DataContract]
    public partial class MobileAppsStatistics :  IEquatable<MobileAppsStatistics>
    {
        /// <summary>
        /// Platform Type
        /// </summary>
        /// <value>Platform Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 2,
            
            /// <summary>
            /// Enum IOS for value: IOS
            /// </summary>
            [EnumMember(Value = "IOS")]
            IOS = 3
        }

        /// <summary>
        /// Platform Type
        /// </summary>
        /// <value>Platform Type</value>
        [DataMember(Name="PlatformType", EmitDefaultValue=false)]
        public PlatformTypeEnum? PlatformType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppsStatistics" /> class.
        /// </summary>
        /// <param name="numberDownload">Number Download.</param>
        /// <param name="currentRate">Current Rate.</param>
        /// <param name="currentVersion">Current Version.</param>
        /// <param name="playStoreLink">Play Store Link.</param>
        /// <param name="appBundleId">App Bundle Id.</param>
        /// <param name="lastUpdated">Last Updated.</param>
        /// <param name="notes">Last Updated.</param>
        /// <param name="published">Published.</param>
        /// <param name="platformType">Platform Type.</param>
        public MobileAppsStatistics(int? numberDownload = default(int?), int? currentRate = default(int?), string currentVersion = default(string), string playStoreLink = default(string), string appBundleId = default(string), DateTime? lastUpdated = default(DateTime?), string notes = default(string), bool? published = default(bool?), PlatformTypeEnum? platformType = default(PlatformTypeEnum?))
        {
            this.NumberDownload = numberDownload;
            this.CurrentRate = currentRate;
            this.CurrentVersion = currentVersion;
            this.PlayStoreLink = playStoreLink;
            this.AppBundleId = appBundleId;
            this.LastUpdated = lastUpdated;
            this.Notes = notes;
            this.Published = published;
            this.PlatformType = platformType;
        }
        
        /// <summary>
        /// Number Download
        /// </summary>
        /// <value>Number Download</value>
        [DataMember(Name="NumberDownload", EmitDefaultValue=false)]
        public int? NumberDownload { get; set; }

        /// <summary>
        /// Current Rate
        /// </summary>
        /// <value>Current Rate</value>
        [DataMember(Name="CurrentRate", EmitDefaultValue=false)]
        public int? CurrentRate { get; set; }

        /// <summary>
        /// Current Version
        /// </summary>
        /// <value>Current Version</value>
        [DataMember(Name="CurrentVersion", EmitDefaultValue=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Play Store Link
        /// </summary>
        /// <value>Play Store Link</value>
        [DataMember(Name="PlayStoreLink", EmitDefaultValue=false)]
        public string PlayStoreLink { get; set; }

        /// <summary>
        /// App Bundle Id
        /// </summary>
        /// <value>App Bundle Id</value>
        [DataMember(Name="AppBundleId", EmitDefaultValue=false)]
        public string AppBundleId { get; set; }

        /// <summary>
        /// Last Updated
        /// </summary>
        /// <value>Last Updated</value>
        [DataMember(Name="LastUpdated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Last Updated
        /// </summary>
        /// <value>Last Updated</value>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Published
        /// </summary>
        /// <value>Published</value>
        [DataMember(Name="Published", EmitDefaultValue=false)]
        public bool? Published { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileAppsStatistics {\n");
            sb.Append("  NumberDownload: ").Append(NumberDownload).Append("\n");
            sb.Append("  CurrentRate: ").Append(CurrentRate).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  PlayStoreLink: ").Append(PlayStoreLink).Append("\n");
            sb.Append("  AppBundleId: ").Append(AppBundleId).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
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
            return this.Equals(input as MobileAppsStatistics);
        }

        /// <summary>
        /// Returns true if MobileAppsStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileAppsStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileAppsStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberDownload == input.NumberDownload ||
                    (this.NumberDownload != null &&
                    this.NumberDownload.Equals(input.NumberDownload))
                ) && 
                (
                    this.CurrentRate == input.CurrentRate ||
                    (this.CurrentRate != null &&
                    this.CurrentRate.Equals(input.CurrentRate))
                ) && 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
                ) && 
                (
                    this.PlayStoreLink == input.PlayStoreLink ||
                    (this.PlayStoreLink != null &&
                    this.PlayStoreLink.Equals(input.PlayStoreLink))
                ) && 
                (
                    this.AppBundleId == input.AppBundleId ||
                    (this.AppBundleId != null &&
                    this.AppBundleId.Equals(input.AppBundleId))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.PlatformType == input.PlatformType ||
                    (this.PlatformType != null &&
                    this.PlatformType.Equals(input.PlatformType))
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
                if (this.NumberDownload != null)
                    hashCode = hashCode * 59 + this.NumberDownload.GetHashCode();
                if (this.CurrentRate != null)
                    hashCode = hashCode * 59 + this.CurrentRate.GetHashCode();
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.PlayStoreLink != null)
                    hashCode = hashCode * 59 + this.PlayStoreLink.GetHashCode();
                if (this.AppBundleId != null)
                    hashCode = hashCode * 59 + this.AppBundleId.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.PlatformType != null)
                    hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                return hashCode;
            }
        }
    }

}
