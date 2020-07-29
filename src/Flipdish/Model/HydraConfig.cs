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
    /// Hydra configuration
    /// </summary>
    [DataContract]
    public partial class HydraConfig :  IEquatable<HydraConfig>, IValidatableObject
    {
        /// <summary>
        /// Defines PaymentOptions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentOptionsEnum
        {
            
            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 1,
            
            /// <summary>
            /// Enum Emv for value: Emv
            /// </summary>
            [EnumMember(Value = "Emv")]
            Emv = 2,
            
            /// <summary>
            /// Enum Counter for value: Counter
            /// </summary>
            [EnumMember(Value = "Counter")]
            Counter = 3
        }


        /// <summary>
        /// Payment options
        /// </summary>
        /// <value>Payment options</value>
        [DataMember(Name="PaymentOptions", EmitDefaultValue=false)]
        public List<PaymentOptionsEnum> PaymentOptions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraConfig" /> class.
        /// </summary>
        /// <param name="minimumVersion">Minimum version (required).</param>
        /// <param name="paymentOptions">Payment options (required).</param>
        /// <param name="deviceSettings">Device settings (required).</param>
        /// <param name="version">Version of the device.</param>
        /// <param name="buildNumber">Build number of the device.</param>
        /// <param name="gitSha">SHA of the commit.</param>
        /// <param name="gitBranch">Build branch.</param>
        public HydraConfig(string minimumVersion = default(string), List<PaymentOptionsEnum> paymentOptions = default(List<PaymentOptionsEnum>), DeviceSettings deviceSettings = default(DeviceSettings), string version = default(string), string buildNumber = default(string), string gitSha = default(string), string gitBranch = default(string))
        {
            // to ensure "minimumVersion" is required (not null)
            if (minimumVersion == null)
            {
                throw new InvalidDataException("minimumVersion is a required property for HydraConfig and cannot be null");
            }
            else
            {
                this.MinimumVersion = minimumVersion;
            }
            // to ensure "paymentOptions" is required (not null)
            if (paymentOptions == null)
            {
                throw new InvalidDataException("paymentOptions is a required property for HydraConfig and cannot be null");
            }
            else
            {
                this.PaymentOptions = paymentOptions;
            }
            // to ensure "deviceSettings" is required (not null)
            if (deviceSettings == null)
            {
                throw new InvalidDataException("deviceSettings is a required property for HydraConfig and cannot be null");
            }
            else
            {
                this.DeviceSettings = deviceSettings;
            }
            this.Version = version;
            this.BuildNumber = buildNumber;
            this.GitSha = gitSha;
            this.GitBranch = gitBranch;
        }
        
        /// <summary>
        /// Minimum version
        /// </summary>
        /// <value>Minimum version</value>
        [DataMember(Name="MinimumVersion", EmitDefaultValue=false)]
        public string MinimumVersion { get; set; }


        /// <summary>
        /// Device settings
        /// </summary>
        /// <value>Device settings</value>
        [DataMember(Name="DeviceSettings", EmitDefaultValue=false)]
        public DeviceSettings DeviceSettings { get; set; }

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
            sb.Append("class HydraConfig {\n");
            sb.Append("  MinimumVersion: ").Append(MinimumVersion).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  DeviceSettings: ").Append(DeviceSettings).Append("\n");
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
            return this.Equals(input as HydraConfig);
        }

        /// <summary>
        /// Returns true if HydraConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinimumVersion == input.MinimumVersion ||
                    (this.MinimumVersion != null &&
                    this.MinimumVersion.Equals(input.MinimumVersion))
                ) && 
                (
                    this.PaymentOptions == input.PaymentOptions ||
                    this.PaymentOptions != null &&
                    this.PaymentOptions.SequenceEqual(input.PaymentOptions)
                ) && 
                (
                    this.DeviceSettings == input.DeviceSettings ||
                    (this.DeviceSettings != null &&
                    this.DeviceSettings.Equals(input.DeviceSettings))
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
                if (this.MinimumVersion != null)
                    hashCode = hashCode * 59 + this.MinimumVersion.GetHashCode();
                if (this.PaymentOptions != null)
                    hashCode = hashCode * 59 + this.PaymentOptions.GetHashCode();
                if (this.DeviceSettings != null)
                    hashCode = hashCode * 59 + this.DeviceSettings.GetHashCode();
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
