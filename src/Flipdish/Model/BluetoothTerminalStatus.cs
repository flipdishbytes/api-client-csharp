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
    /// Status of the bluetooth terminal
    /// </summary>
    [DataContract]
    public partial class BluetoothTerminalStatus :  IEquatable<BluetoothTerminalStatus>
    {
        /// <summary>
        /// Device Type
        /// </summary>
        /// <value>Device Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            
            /// <summary>
            /// Enum CHIPPER2X for value: CHIPPER_2X
            /// </summary>
            [EnumMember(Value = "CHIPPER_2X")]
            CHIPPER2X = 1,
            
            /// <summary>
            /// Enum COTSDEVICE for value: COTS_DEVICE
            /// </summary>
            [EnumMember(Value = "COTS_DEVICE")]
            COTSDEVICE = 2,
            
            /// <summary>
            /// Enum VERIFONEP400 for value: VERIFONE_P400
            /// </summary>
            [EnumMember(Value = "VERIFONE_P400")]
            VERIFONEP400 = 3,
            
            /// <summary>
            /// Enum WISEPAD3 for value: WISEPAD_3
            /// </summary>
            [EnumMember(Value = "WISEPAD_3")]
            WISEPAD3 = 4,
            
            /// <summary>
            /// Enum WISEPOSE for value: WISEPOS_E
            /// </summary>
            [EnumMember(Value = "WISEPOS_E")]
            WISEPOSE = 5
        }

        /// <summary>
        /// Device Type
        /// </summary>
        /// <value>Device Type</value>
        [DataMember(Name="DeviceType", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Device Status
        /// </summary>
        /// <value>Device Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NotConnected for value: Not_Connected
            /// </summary>
            [EnumMember(Value = "Not_Connected")]
            NotConnected = 1,
            
            /// <summary>
            /// Enum Connecting for value: Connecting
            /// </summary>
            [EnumMember(Value = "Connecting")]
            Connecting = 2,
            
            /// <summary>
            /// Enum Connected for value: Connected
            /// </summary>
            [EnumMember(Value = "Connected")]
            Connected = 3,
            
            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 4,
            
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 5
        }

        /// <summary>
        /// Device Status
        /// </summary>
        /// <value>Device Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BluetoothTerminalStatus" /> class.
        /// </summary>
        /// <param name="serialNumber">Serial Number.</param>
        /// <param name="softwareVersion">Software Version.</param>
        /// <param name="deviceType">Device Type.</param>
        /// <param name="status">Device Status.</param>
        /// <param name="batteryLevel">Indication of the battery level from 0 to 1.</param>
        /// <param name="updateTime">Last time the status was updated.</param>
        /// <param name="readerId">ReaderId for Stripe Terminal.</param>
        public BluetoothTerminalStatus(string serialNumber = default(string), string softwareVersion = default(string), DeviceTypeEnum? deviceType = default(DeviceTypeEnum?), StatusEnum? status = default(StatusEnum?), float? batteryLevel = default(float?), DateTime? updateTime = default(DateTime?), string readerId = default(string))
        {
            this.SerialNumber = serialNumber;
            this.SoftwareVersion = softwareVersion;
            this.DeviceType = deviceType;
            this.Status = status;
            this.BatteryLevel = batteryLevel;
            this.UpdateTime = updateTime;
            this.ReaderId = readerId;
        }
        
        /// <summary>
        /// Serial Number
        /// </summary>
        /// <value>Serial Number</value>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Software Version
        /// </summary>
        /// <value>Software Version</value>
        [DataMember(Name="SoftwareVersion", EmitDefaultValue=false)]
        public string SoftwareVersion { get; set; }



        /// <summary>
        /// Indication of the battery level from 0 to 1
        /// </summary>
        /// <value>Indication of the battery level from 0 to 1</value>
        [DataMember(Name="BatteryLevel", EmitDefaultValue=false)]
        public float? BatteryLevel { get; set; }

        /// <summary>
        /// Last time the status was updated
        /// </summary>
        /// <value>Last time the status was updated</value>
        [DataMember(Name="UpdateTime", EmitDefaultValue=false)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// ReaderId for Stripe Terminal
        /// </summary>
        /// <value>ReaderId for Stripe Terminal</value>
        [DataMember(Name="ReaderId", EmitDefaultValue=false)]
        public string ReaderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BluetoothTerminalStatus {\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BatteryLevel: ").Append(BatteryLevel).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  ReaderId: ").Append(ReaderId).Append("\n");
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
            return this.Equals(input as BluetoothTerminalStatus);
        }

        /// <summary>
        /// Returns true if BluetoothTerminalStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of BluetoothTerminalStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BluetoothTerminalStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
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
                    this.BatteryLevel == input.BatteryLevel ||
                    (this.BatteryLevel != null &&
                    this.BatteryLevel.Equals(input.BatteryLevel))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.ReaderId == input.ReaderId ||
                    (this.ReaderId != null &&
                    this.ReaderId.Equals(input.ReaderId))
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
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.SoftwareVersion != null)
                    hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BatteryLevel != null)
                    hashCode = hashCode * 59 + this.BatteryLevel.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ReaderId != null)
                    hashCode = hashCode * 59 + this.ReaderId.GetHashCode();
                return hashCode;
            }
        }
    }

}
