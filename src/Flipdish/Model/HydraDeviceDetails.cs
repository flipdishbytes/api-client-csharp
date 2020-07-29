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
    /// Hydra device details
    /// </summary>
    [DataContract]
    public partial class HydraDeviceDetails :  IEquatable<HydraDeviceDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of the device
        /// </summary>
        /// <value>Type of the device</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            
            /// <summary>
            /// Enum Kiosk for value: Kiosk
            /// </summary>
            [EnumMember(Value = "Kiosk")]
            Kiosk = 1,
            
            /// <summary>
            /// Enum Terminal for value: Terminal
            /// </summary>
            [EnumMember(Value = "Terminal")]
            Terminal = 2,
            
            /// <summary>
            /// Enum LegacyPrinter for value: LegacyPrinter
            /// </summary>
            [EnumMember(Value = "LegacyPrinter")]
            LegacyPrinter = 3
        }

        /// <summary>
        /// Type of the device
        /// </summary>
        /// <value>Type of the device</value>
        [DataMember(Name="DeviceType", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Status of the device
        /// </summary>
        /// <value>Status of the device</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 1,
            
            /// <summary>
            /// Enum PossiblyOffline for value: PossiblyOffline
            /// </summary>
            [EnumMember(Value = "PossiblyOffline")]
            PossiblyOffline = 2,
            
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 3
        }

        /// <summary>
        /// Status of the device
        /// </summary>
        /// <value>Status of the device</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraDeviceDetails" /> class.
        /// </summary>
        /// <param name="hydraConfigId">Flipdish internal device identifier.</param>
        /// <param name="deviceId">Device Id or Serial Number.</param>
        /// <param name="deviceType">Type of the device.</param>
        /// <param name="status">Status of the device.</param>
        /// <param name="deviceName">Device Name.</param>
        /// <param name="storeNames">Store Names.</param>
        /// <param name="lastPollUtc">Last poll time in UTC.</param>
        /// <param name="version">Version of the device.</param>
        /// <param name="buildNumber">Build number of the device.</param>
        /// <param name="gitSha">SHA of the commit.</param>
        /// <param name="gitBranch">Build branch.</param>
        public HydraDeviceDetails(int? hydraConfigId = default(int?), string deviceId = default(string), DeviceTypeEnum? deviceType = default(DeviceTypeEnum?), StatusEnum? status = default(StatusEnum?), string deviceName = default(string), List<HydraStoreData> storeNames = default(List<HydraStoreData>), DateTime? lastPollUtc = default(DateTime?), string version = default(string), string buildNumber = default(string), string gitSha = default(string), string gitBranch = default(string))
        {
            this.HydraConfigId = hydraConfigId;
            this.DeviceId = deviceId;
            this.DeviceType = deviceType;
            this.Status = status;
            this.DeviceName = deviceName;
            this.StoreNames = storeNames;
            this.LastPollUtc = lastPollUtc;
            this.Version = version;
            this.BuildNumber = buildNumber;
            this.GitSha = gitSha;
            this.GitBranch = gitBranch;
        }
        
        /// <summary>
        /// Flipdish internal device identifier
        /// </summary>
        /// <value>Flipdish internal device identifier</value>
        [DataMember(Name="HydraConfigId", EmitDefaultValue=false)]
        public int? HydraConfigId { get; set; }

        /// <summary>
        /// Device Id or Serial Number
        /// </summary>
        /// <value>Device Id or Serial Number</value>
        [DataMember(Name="DeviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }



        /// <summary>
        /// Device Name
        /// </summary>
        /// <value>Device Name</value>
        [DataMember(Name="DeviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Store Names
        /// </summary>
        /// <value>Store Names</value>
        [DataMember(Name="StoreNames", EmitDefaultValue=false)]
        public List<HydraStoreData> StoreNames { get; set; }

        /// <summary>
        /// Last poll time in UTC
        /// </summary>
        /// <value>Last poll time in UTC</value>
        [DataMember(Name="LastPollUtc", EmitDefaultValue=false)]
        public DateTime? LastPollUtc { get; set; }

        /// <summary>
        /// Version of the device
        /// </summary>
        /// <value>Version of the device</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Build number of the device
        /// </summary>
        /// <value>Build number of the device</value>
        [DataMember(Name="BuildNumber", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }

        /// <summary>
        /// SHA of the commit
        /// </summary>
        /// <value>SHA of the commit</value>
        [DataMember(Name="GitSha", EmitDefaultValue=false)]
        public string GitSha { get; set; }

        /// <summary>
        /// Build branch
        /// </summary>
        /// <value>Build branch</value>
        [DataMember(Name="GitBranch", EmitDefaultValue=false)]
        public string GitBranch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HydraDeviceDetails {\n");
            sb.Append("  HydraConfigId: ").Append(HydraConfigId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  StoreNames: ").Append(StoreNames).Append("\n");
            sb.Append("  LastPollUtc: ").Append(LastPollUtc).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  GitSha: ").Append(GitSha).Append("\n");
            sb.Append("  GitBranch: ").Append(GitBranch).Append("\n");
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
            return this.Equals(input as HydraDeviceDetails);
        }

        /// <summary>
        /// Returns true if HydraDeviceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraDeviceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraDeviceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HydraConfigId == input.HydraConfigId ||
                    (this.HydraConfigId != null &&
                    this.HydraConfigId.Equals(input.HydraConfigId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.StoreNames == input.StoreNames ||
                    this.StoreNames != null &&
                    this.StoreNames.SequenceEqual(input.StoreNames)
                ) && 
                (
                    this.LastPollUtc == input.LastPollUtc ||
                    (this.LastPollUtc != null &&
                    this.LastPollUtc.Equals(input.LastPollUtc))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
                ) && 
                (
                    this.GitSha == input.GitSha ||
                    (this.GitSha != null &&
                    this.GitSha.Equals(input.GitSha))
                ) && 
                (
                    this.GitBranch == input.GitBranch ||
                    (this.GitBranch != null &&
                    this.GitBranch.Equals(input.GitBranch))
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
                if (this.HydraConfigId != null)
                    hashCode = hashCode * 59 + this.HydraConfigId.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.StoreNames != null)
                    hashCode = hashCode * 59 + this.StoreNames.GetHashCode();
                if (this.LastPollUtc != null)
                    hashCode = hashCode * 59 + this.LastPollUtc.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.GitSha != null)
                    hashCode = hashCode * 59 + this.GitSha.GetHashCode();
                if (this.GitBranch != null)
                    hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
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
