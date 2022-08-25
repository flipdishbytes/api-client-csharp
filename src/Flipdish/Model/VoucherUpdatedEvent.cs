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
    /// Voucher Updated Event
    /// </summary>
    [DataContract]
    public partial class VoucherUpdatedEvent :  IEquatable<VoucherUpdatedEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUpdatedEvent" /> class.
        /// </summary>
        /// <param name="voucherId">Voucher Id.</param>
        /// <param name="eventName">The event name.</param>
        /// <param name="user">User which updated this voucher.</param>
        /// <param name="description">Description.</param>
        /// <param name="voucher">Updated voucher.</param>
        /// <param name="flipdishEventId">The identitfier of the event.</param>
        /// <param name="createTime">The time of creation of the event.</param>
        /// <param name="position">Position.</param>
        /// <param name="appId">App id.</param>
        /// <param name="ipAddress">Ip Address.</param>
        public VoucherUpdatedEvent(int? voucherId = default(int?), string eventName = default(string), UserEventInfo user = default(UserEventInfo), string description = default(string), Voucher voucher = default(Voucher), Guid? flipdishEventId = default(Guid?), DateTime? createTime = default(DateTime?), int? position = default(int?), string appId = default(string), string ipAddress = default(string))
        {
            this.VoucherId = voucherId;
            this.EventName = eventName;
            this.User = user;
            this.Description = description;
            this.Voucher = voucher;
            this.FlipdishEventId = flipdishEventId;
            this.CreateTime = createTime;
            this.Position = position;
            this.AppId = appId;
            this.IpAddress = ipAddress;
        }
        
        /// <summary>
        /// Voucher Id
        /// </summary>
        /// <value>Voucher Id</value>
        [DataMember(Name="VoucherId", EmitDefaultValue=false)]
        public int? VoucherId { get; set; }

        /// <summary>
        /// The event name
        /// </summary>
        /// <value>The event name</value>
        [DataMember(Name="EventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// User which updated this voucher
        /// </summary>
        /// <value>User which updated this voucher</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public UserEventInfo User { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Updated voucher
        /// </summary>
        /// <value>Updated voucher</value>
        [DataMember(Name="Voucher", EmitDefaultValue=false)]
        public Voucher Voucher { get; set; }

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
            sb.Append("class VoucherUpdatedEvent {\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Voucher: ").Append(Voucher).Append("\n");
            sb.Append("  FlipdishEventId: ").Append(FlipdishEventId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
            return this.Equals(input as VoucherUpdatedEvent);
        }

        /// <summary>
        /// Returns true if VoucherUpdatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUpdatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUpdatedEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Voucher == input.Voucher ||
                    (this.Voucher != null &&
                    this.Voucher.Equals(input.Voucher))
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
                if (this.VoucherId != null)
                    hashCode = hashCode * 59 + this.VoucherId.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Voucher != null)
                    hashCode = hashCode * 59 + this.Voucher.GetHashCode();
                if (this.FlipdishEventId != null)
                    hashCode = hashCode * 59 + this.FlipdishEventId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                return hashCode;
            }
        }
    }

}
