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
    /// Kiosk bluetooth Cancel Update Install Event
    /// </summary>
    [DataContract]
    public partial class KioskBluetoothTerminalCancelUpdateEvent :  IEquatable<KioskBluetoothTerminalCancelUpdateEvent>
    {
        /// <summary>
        /// Terminal Type
        /// </summary>
        /// <value>Terminal Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BluetoothTerminalTypeEnum
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
        /// Terminal Type
        /// </summary>
        /// <value>Terminal Type</value>
        [DataMember(Name="BluetoothTerminalType", EmitDefaultValue=false)]
        public BluetoothTerminalTypeEnum? BluetoothTerminalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KioskBluetoothTerminalCancelUpdateEvent" /> class.
        /// </summary>
        /// <param name="deviceId">Device Id of the Kiosk.</param>
        /// <param name="bluetoothTerminalType">Terminal Type.</param>
        /// <param name="user">User who made the change.</param>
        /// <param name="eventName">The event name.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        /// <param name="appId">App id.</param>
        /// <param name="orgId">Org id.</param>
        /// <param name="ipAddress">Ip Address.</param>
        public KioskBluetoothTerminalCancelUpdateEvent(string deviceId = default(string), BluetoothTerminalTypeEnum? bluetoothTerminalType = default(BluetoothTerminalTypeEnum?), UserEventInfo user = default(UserEventInfo), string eventName = default(string), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?), string appId = default(string), string orgId = default(string), string ipAddress = default(string))
        {
            this.DeviceId = deviceId;
            this.BluetoothTerminalType = bluetoothTerminalType;
            this.User = user;
            this.EventName = eventName;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
            this.AppId = appId;
            this.OrgId = orgId;
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// Device Id of the Kiosk
        /// </summary>
        /// <value>Device Id of the Kiosk</value>
        [DataMember(Name="DeviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }


        /// <summary>
        /// User who made the change
        /// </summary>
        /// <value>User who made the change</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The identitfier of the event
        /// </summary>
        /// <value>The identitfier of the event</value>
        [DataMember(Name="FlipdishEventId", EmitDefaultValue=false)]
        public Guid? FlipdishEventId { get; set; }

        /// <summary>
        /// The time of creation of the event
        /// </summary>
        /// <value>The time of creation of the event</value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        /// <value>Position</value>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// App id
        /// </summary>
        /// <value>App id</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Org id
        /// </summary>
        /// <value>Org id</value>
        [DataMember(Name="OrgId", EmitDefaultValue=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// Ip Address
        /// </summary>
        /// <value>Ip Address</value>
        [DataMember(Name="IpAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KioskBluetoothTerminalCancelUpdateEvent {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  BluetoothTerminalType: ").Append(BluetoothTerminalType).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
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
            return this.Equals(input as KioskBluetoothTerminalCancelUpdateEvent);
        }

        /// <summary>
        /// Returns true if KioskBluetoothTerminalCancelUpdateEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of KioskBluetoothTerminalCancelUpdateEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KioskBluetoothTerminalCancelUpdateEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.BluetoothTerminalType == input.BluetoothTerminalType ||
                    (this.BluetoothTerminalType != null &&
                    this.BluetoothTerminalType.Equals(input.BluetoothTerminalType))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.FlipdishEventId == input.FlipdishEventId ||
                    (this.FlipdishEventId != null &&
                    this.FlipdishEventId.Equals(input.FlipdishEventId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.OrgId == input.OrgId ||
                    (this.OrgId != null &&
                    this.OrgId.Equals(input.OrgId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.BluetoothTerminalType != null)
                    hashCode = hashCode * 59 + this.BluetoothTerminalType.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                return hashCode;
            }
        }
    }

}
