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
    /// Client Analytics event
    /// </summary>
    [DataContract]
    public partial class AnalyticsClientEvent :  IEquatable<AnalyticsClientEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientEvent" /> class.
        /// </summary>
        /// <param name="eventName">The event name.</param>
        /// <param name="eventType">Type of the event.</param>
        /// <param name="appType">Type of the app the event is coming from.</param>
        /// <param name="metadata">JSON Metadata.</param>
        /// <param name="userId">User Id.</param>
        /// <param name="latitude">Latitude of the event.</param>
        /// <param name="longitude">Longitude of the event.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        /// <param name="appId">App id.</param>
        /// <param name="orgId">Org id.</param>
        /// <param name="ipAddress">Ip Address.</param>
        public AnalyticsClientEvent(string eventName = default(string), string eventType = default(string), string appType = default(string), string metadata = default(string), int? userId = default(int?), double? latitude = default(double?), double? longitude = default(double?), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?), string appId = default(string), string orgId = default(string), string ipAddress = default(string))
        {
            this.EventName = eventName;
            this.EventType = eventType;
            this.AppType = appType;
            this.Metadata = metadata;
            this.UserId = userId;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
            this.AppId = appId;
            this.OrgId = orgId;
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Type of the event
        /// </summary>
        /// <value>Type of the event</value>
        [DataMember(Name="EventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// Type of the app the event is coming from
        /// </summary>
        /// <value>Type of the app the event is coming from</value>
        [DataMember(Name="AppType", EmitDefaultValue=false)]
        public string AppType { get; set; }

        /// <summary>
        /// JSON Metadata
        /// </summary>
        /// <value>JSON Metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        /// <value>User Id</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Latitude of the event
        /// </summary>
        /// <value>Latitude of the event</value>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude of the event
        /// </summary>
        /// <value>Longitude of the event</value>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

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
            sb.Append("class AnalyticsClientEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AppType: ").Append(AppType).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as AnalyticsClientEvent);
        }

        /// <summary>
        /// Returns true if AnalyticsClientEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsClientEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsClientEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
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
