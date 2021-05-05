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
    /// EMV Payment Terminal
    /// </summary>
    [DataContract]
    public partial class EmvTerminalWithAssignments :  IEquatable<EmvTerminalWithAssignments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmvTerminalWithAssignments" /> class.
        /// </summary>
        /// <param name="emvTerminalId">Flipdish Internal identifier of the Terminal.</param>
        /// <param name="terminalId">External Identifier of the Terminal.</param>
        /// <param name="isAssignedToHydraDevice">true if the terminal is assigned to a hydra device (e.g. a kiosk).</param>
        /// <param name="hydraConfigId">hydra device id (null if the terminal is not assigned to any hydra device).</param>
        /// <param name="hydraDeviceId">external hydra device id (null if the terminal is not assigned to any hydra device).</param>
        /// <param name="hydraName">hydra device name (null if the terminal is not assigned to any hydra device).</param>
        public EmvTerminalWithAssignments(string emvTerminalId = default(string), string terminalId = default(string), bool? isAssignedToHydraDevice = default(bool?), int? hydraConfigId = default(int?), string hydraDeviceId = default(string), string hydraName = default(string))
        {
            this.EmvTerminalId = emvTerminalId;
            this.TerminalId = terminalId;
            this.IsAssignedToHydraDevice = isAssignedToHydraDevice;
            this.HydraConfigId = hydraConfigId;
            this.HydraDeviceId = hydraDeviceId;
            this.HydraName = hydraName;
        }
        
        /// <summary>
        /// Flipdish Internal identifier of the Terminal
        /// </summary>
        /// <value>Flipdish Internal identifier of the Terminal</value>
        [DataMember(Name="EmvTerminalId", EmitDefaultValue=false)]
        public string EmvTerminalId { get; set; }

        /// <summary>
        /// External Identifier of the Terminal
        /// </summary>
        /// <value>External Identifier of the Terminal</value>
        [DataMember(Name="TerminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// true if the terminal is assigned to a hydra device (e.g. a kiosk)
        /// </summary>
        /// <value>true if the terminal is assigned to a hydra device (e.g. a kiosk)</value>
        [DataMember(Name="IsAssignedToHydraDevice", EmitDefaultValue=false)]
        public bool? IsAssignedToHydraDevice { get; set; }

        /// <summary>
        /// hydra device id (null if the terminal is not assigned to any hydra device)
        /// </summary>
        /// <value>hydra device id (null if the terminal is not assigned to any hydra device)</value>
        [DataMember(Name="HydraConfigId", EmitDefaultValue=false)]
        public int? HydraConfigId { get; set; }

        /// <summary>
        /// external hydra device id (null if the terminal is not assigned to any hydra device)
        /// </summary>
        /// <value>external hydra device id (null if the terminal is not assigned to any hydra device)</value>
        [DataMember(Name="HydraDeviceId", EmitDefaultValue=false)]
        public string HydraDeviceId { get; set; }

        /// <summary>
        /// hydra device name (null if the terminal is not assigned to any hydra device)
        /// </summary>
        /// <value>hydra device name (null if the terminal is not assigned to any hydra device)</value>
        [DataMember(Name="HydraName", EmitDefaultValue=false)]
        public string HydraName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmvTerminalWithAssignments {\n");
            sb.Append("  EmvTerminalId: ").Append(EmvTerminalId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  IsAssignedToHydraDevice: ").Append(IsAssignedToHydraDevice).Append("\n");
            sb.Append("  HydraConfigId: ").Append(HydraConfigId).Append("\n");
            sb.Append("  HydraDeviceId: ").Append(HydraDeviceId).Append("\n");
            sb.Append("  HydraName: ").Append(HydraName).Append("\n");
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
            return this.Equals(input as EmvTerminalWithAssignments);
        }

        /// <summary>
        /// Returns true if EmvTerminalWithAssignments instances are equal
        /// </summary>
        /// <param name="input">Instance of EmvTerminalWithAssignments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmvTerminalWithAssignments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmvTerminalId == input.EmvTerminalId ||
                    (this.EmvTerminalId != null &&
                    this.EmvTerminalId.Equals(input.EmvTerminalId))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.IsAssignedToHydraDevice == input.IsAssignedToHydraDevice ||
                    (this.IsAssignedToHydraDevice != null &&
                    this.IsAssignedToHydraDevice.Equals(input.IsAssignedToHydraDevice))
                ) && 
                (
                    this.HydraConfigId == input.HydraConfigId ||
                    (this.HydraConfigId != null &&
                    this.HydraConfigId.Equals(input.HydraConfigId))
                ) && 
                (
                    this.HydraDeviceId == input.HydraDeviceId ||
                    (this.HydraDeviceId != null &&
                    this.HydraDeviceId.Equals(input.HydraDeviceId))
                ) && 
                (
                    this.HydraName == input.HydraName ||
                    (this.HydraName != null &&
                    this.HydraName.Equals(input.HydraName))
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
                if (this.EmvTerminalId != null)
                    hashCode = hashCode * 59 + this.EmvTerminalId.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.IsAssignedToHydraDevice != null)
                    hashCode = hashCode * 59 + this.IsAssignedToHydraDevice.GetHashCode();
                if (this.HydraConfigId != null)
                    hashCode = hashCode * 59 + this.HydraConfigId.GetHashCode();
                if (this.HydraDeviceId != null)
                    hashCode = hashCode * 59 + this.HydraDeviceId.GetHashCode();
                if (this.HydraName != null)
                    hashCode = hashCode * 59 + this.HydraName.GetHashCode();
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
