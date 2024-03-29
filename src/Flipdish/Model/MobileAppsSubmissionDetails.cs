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
    /// Mobile Apps form submission
    /// </summary>
    [DataContract]
    public partial class MobileAppsSubmissionDetails :  IEquatable<MobileAppsSubmissionDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppsSubmissionDetails" /> class.
        /// </summary>
        /// <param name="mobileAppsSubmissionId">Mobile Apps Submission Id.</param>
        /// <param name="appName">App Name.</param>
        /// <param name="appDescription">App Description.</param>
        /// <param name="appShortDescription">App Description.</param>
        /// <param name="keywords">Keywords.</param>
        /// <param name="appLogoUrl">Logo URL.</param>
        /// <param name="autoPublish">Publish automatically.</param>
        /// <param name="status">Mobile App Status.</param>
        public MobileAppsSubmissionDetails(int? mobileAppsSubmissionId = default(int?), string appName = default(string), string appDescription = default(string), string appShortDescription = default(string), List<string> keywords = default(List<string>), string appLogoUrl = default(string), bool? autoPublish = default(bool?), List<MobileAppsSubmissionStatus> status = default(List<MobileAppsSubmissionStatus>))
        {
            this.MobileAppsSubmissionId = mobileAppsSubmissionId;
            this.AppName = appName;
            this.AppDescription = appDescription;
            this.AppShortDescription = appShortDescription;
            this.Keywords = keywords;
            this.AppLogoUrl = appLogoUrl;
            this.AutoPublish = autoPublish;
            this.Status = status;
        }
        
        /// <summary>
        /// Mobile Apps Submission Id
        /// </summary>
        /// <value>Mobile Apps Submission Id</value>
        [DataMember(Name="MobileAppsSubmissionId", EmitDefaultValue=false)]
        public int? MobileAppsSubmissionId { get; set; }

        /// <summary>
        /// App Name
        /// </summary>
        /// <value>App Name</value>
        [DataMember(Name="AppName", EmitDefaultValue=false)]
        public string AppName { get; set; }

        /// <summary>
        /// App Description
        /// </summary>
        /// <value>App Description</value>
        [DataMember(Name="AppDescription", EmitDefaultValue=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// App Description
        /// </summary>
        /// <value>App Description</value>
        [DataMember(Name="AppShortDescription", EmitDefaultValue=false)]
        public string AppShortDescription { get; set; }

        /// <summary>
        /// Keywords
        /// </summary>
        /// <value>Keywords</value>
        [DataMember(Name="Keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Logo URL
        /// </summary>
        /// <value>Logo URL</value>
        [DataMember(Name="AppLogoUrl", EmitDefaultValue=false)]
        public string AppLogoUrl { get; set; }

        /// <summary>
        /// Publish automatically
        /// </summary>
        /// <value>Publish automatically</value>
        [DataMember(Name="AutoPublish", EmitDefaultValue=false)]
        public bool? AutoPublish { get; set; }

        /// <summary>
        /// Mobile App Status
        /// </summary>
        /// <value>Mobile App Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public List<MobileAppsSubmissionStatus> Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileAppsSubmissionDetails {\n");
            sb.Append("  MobileAppsSubmissionId: ").Append(MobileAppsSubmissionId).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppDescription: ").Append(AppDescription).Append("\n");
            sb.Append("  AppShortDescription: ").Append(AppShortDescription).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  AppLogoUrl: ").Append(AppLogoUrl).Append("\n");
            sb.Append("  AutoPublish: ").Append(AutoPublish).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MobileAppsSubmissionDetails);
        }

        /// <summary>
        /// Returns true if MobileAppsSubmissionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileAppsSubmissionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileAppsSubmissionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MobileAppsSubmissionId == input.MobileAppsSubmissionId ||
                    (this.MobileAppsSubmissionId != null &&
                    this.MobileAppsSubmissionId.Equals(input.MobileAppsSubmissionId))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppDescription == input.AppDescription ||
                    (this.AppDescription != null &&
                    this.AppDescription.Equals(input.AppDescription))
                ) && 
                (
                    this.AppShortDescription == input.AppShortDescription ||
                    (this.AppShortDescription != null &&
                    this.AppShortDescription.Equals(input.AppShortDescription))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.AppLogoUrl == input.AppLogoUrl ||
                    (this.AppLogoUrl != null &&
                    this.AppLogoUrl.Equals(input.AppLogoUrl))
                ) && 
                (
                    this.AutoPublish == input.AutoPublish ||
                    (this.AutoPublish != null &&
                    this.AutoPublish.Equals(input.AutoPublish))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    this.Status.SequenceEqual(input.Status)
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
                if (this.MobileAppsSubmissionId != null)
                    hashCode = hashCode * 59 + this.MobileAppsSubmissionId.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppDescription != null)
                    hashCode = hashCode * 59 + this.AppDescription.GetHashCode();
                if (this.AppShortDescription != null)
                    hashCode = hashCode * 59 + this.AppShortDescription.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.AppLogoUrl != null)
                    hashCode = hashCode * 59 + this.AppLogoUrl.GetHashCode();
                if (this.AutoPublish != null)
                    hashCode = hashCode * 59 + this.AutoPublish.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }

}
