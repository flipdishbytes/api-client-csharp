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
    /// Mobile Apps Status
    /// </summary>
    [DataContract]
    public partial class MobileAppsSubmissionStatus :  IEquatable<MobileAppsSubmissionStatus>
    {
        /// <summary>
        /// Mobile Type
        /// </summary>
        /// <value>Mobile Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
        /// Mobile Type
        /// </summary>
        /// <value>Mobile Type</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Mobile App Status
        /// </summary>
        /// <value>Mobile App Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppStatusEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Published for value: Published
            /// </summary>
            [EnumMember(Value = "Published")]
            Published = 2,
            
            /// <summary>
            /// Enum Unpublished for value: Unpublished
            /// </summary>
            [EnumMember(Value = "Unpublished")]
            Unpublished = 3
        }

        /// <summary>
        /// Mobile App Status
        /// </summary>
        /// <value>Mobile App Status</value>
        [DataMember(Name="AppStatus", EmitDefaultValue=false)]
        public AppStatusEnum? AppStatus { get; set; }
        /// <summary>
        /// Mobile App Status
        /// </summary>
        /// <value>Mobile App Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpdateStatusEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Submitted for value: Submitted
            /// </summary>
            [EnumMember(Value = "Submitted")]
            Submitted = 2,
            
            /// <summary>
            /// Enum InReview for value: InReview
            /// </summary>
            [EnumMember(Value = "InReview")]
            InReview = 3,
            
            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 4,
            
            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 5,
            
            /// <summary>
            /// Enum Published for value: Published
            /// </summary>
            [EnumMember(Value = "Published")]
            Published = 6
        }

        /// <summary>
        /// Mobile App Status
        /// </summary>
        /// <value>Mobile App Status</value>
        [DataMember(Name="UpdateStatus", EmitDefaultValue=false)]
        public UpdateStatusEnum? UpdateStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppsSubmissionStatus" /> class.
        /// </summary>
        /// <param name="mobileAppsSubmissionStatusId">Mobile Apps Submission Status Id.</param>
        /// <param name="mobileAppsSubmissionId">Mobile Apps Submission Id.</param>
        /// <param name="type">Mobile Type.</param>
        /// <param name="appStatus">Mobile App Status.</param>
        /// <param name="updateStatus">Mobile App Status.</param>
        /// <param name="lastUpdateStatusTime">Mobile LastUpdateStatusTime.</param>
        /// <param name="createTime">Mobile CreateTime.</param>
        /// <param name="updateTime">Mobile UpdateTime.</param>
        /// <param name="notes">Mobile Notes.</param>
        public MobileAppsSubmissionStatus(int? mobileAppsSubmissionStatusId = default(int?), int? mobileAppsSubmissionId = default(int?), TypeEnum? type = default(TypeEnum?), AppStatusEnum? appStatus = default(AppStatusEnum?), UpdateStatusEnum? updateStatus = default(UpdateStatusEnum?), DateTime? lastUpdateStatusTime = default(DateTime?), DateTime? createTime = default(DateTime?), DateTime? updateTime = default(DateTime?), string notes = default(string))
        {
            this.MobileAppsSubmissionStatusId = mobileAppsSubmissionStatusId;
            this.MobileAppsSubmissionId = mobileAppsSubmissionId;
            this.Type = type;
            this.AppStatus = appStatus;
            this.UpdateStatus = updateStatus;
            this.LastUpdateStatusTime = lastUpdateStatusTime;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Mobile Apps Submission Status Id
        /// </summary>
        /// <value>Mobile Apps Submission Status Id</value>
        [DataMember(Name="MobileAppsSubmissionStatusId", EmitDefaultValue=false)]
        public int? MobileAppsSubmissionStatusId { get; set; }

        /// <summary>
        /// Mobile Apps Submission Id
        /// </summary>
        /// <value>Mobile Apps Submission Id</value>
        [DataMember(Name="MobileAppsSubmissionId", EmitDefaultValue=false)]
        public int? MobileAppsSubmissionId { get; set; }




        /// <summary>
        /// Mobile LastUpdateStatusTime
        /// </summary>
        /// <value>Mobile LastUpdateStatusTime</value>
        [DataMember(Name="LastUpdateStatusTime", EmitDefaultValue=false)]
        public DateTime? LastUpdateStatusTime { get; set; }

        /// <summary>
        /// Mobile CreateTime
        /// </summary>
        /// <value>Mobile CreateTime</value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Mobile UpdateTime
        /// </summary>
        /// <value>Mobile UpdateTime</value>
        [DataMember(Name="UpdateTime", EmitDefaultValue=false)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Mobile Notes
        /// </summary>
        /// <value>Mobile Notes</value>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileAppsSubmissionStatus {\n");
            sb.Append("  MobileAppsSubmissionStatusId: ").Append(MobileAppsSubmissionStatusId).Append("\n");
            sb.Append("  MobileAppsSubmissionId: ").Append(MobileAppsSubmissionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AppStatus: ").Append(AppStatus).Append("\n");
            sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  LastUpdateStatusTime: ").Append(LastUpdateStatusTime).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as MobileAppsSubmissionStatus);
        }

        /// <summary>
        /// Returns true if MobileAppsSubmissionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileAppsSubmissionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileAppsSubmissionStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MobileAppsSubmissionStatusId == input.MobileAppsSubmissionStatusId ||
                    (this.MobileAppsSubmissionStatusId != null &&
                    this.MobileAppsSubmissionStatusId.Equals(input.MobileAppsSubmissionStatusId))
                ) && 
                (
                    this.MobileAppsSubmissionId == input.MobileAppsSubmissionId ||
                    (this.MobileAppsSubmissionId != null &&
                    this.MobileAppsSubmissionId.Equals(input.MobileAppsSubmissionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AppStatus == input.AppStatus ||
                    (this.AppStatus != null &&
                    this.AppStatus.Equals(input.AppStatus))
                ) && 
                (
                    this.UpdateStatus == input.UpdateStatus ||
                    (this.UpdateStatus != null &&
                    this.UpdateStatus.Equals(input.UpdateStatus))
                ) && 
                (
                    this.LastUpdateStatusTime == input.LastUpdateStatusTime ||
                    (this.LastUpdateStatusTime != null &&
                    this.LastUpdateStatusTime.Equals(input.LastUpdateStatusTime))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.MobileAppsSubmissionStatusId != null)
                    hashCode = hashCode * 59 + this.MobileAppsSubmissionStatusId.GetHashCode();
                if (this.MobileAppsSubmissionId != null)
                    hashCode = hashCode * 59 + this.MobileAppsSubmissionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AppStatus != null)
                    hashCode = hashCode * 59 + this.AppStatus.GetHashCode();
                if (this.UpdateStatus != null)
                    hashCode = hashCode * 59 + this.UpdateStatus.GetHashCode();
                if (this.LastUpdateStatusTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateStatusTime.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }
    }

}
