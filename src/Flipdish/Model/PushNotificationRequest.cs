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
    /// Push Notification Details
    /// </summary>
    [DataContract]
    public partial class PushNotificationRequest :  IEquatable<PushNotificationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushNotificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushNotificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushNotificationRequest" /> class.
        /// </summary>
        /// <param name="scheduledTime">UTC Time at which to send the push notification.</param>
        /// <param name="title">Title of the notification.</param>
        /// <param name="message">Message of the notification (required).</param>
        public PushNotificationRequest(DateTime? scheduledTime = default(DateTime?), string title = default(string), string message = default(string))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for PushNotificationRequest and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            this.ScheduledTime = scheduledTime;
            this.Title = title;
        }
        
        /// <summary>
        /// UTC Time at which to send the push notification
        /// </summary>
        /// <value>UTC Time at which to send the push notification</value>
        [DataMember(Name="ScheduledTime", EmitDefaultValue=false)]
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Title of the notification
        /// </summary>
        /// <value>Title of the notification</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Message of the notification
        /// </summary>
        /// <value>Message of the notification</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushNotificationRequest {\n");
            sb.Append("  ScheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as PushNotificationRequest);
        }

        /// <summary>
        /// Returns true if PushNotificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PushNotificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushNotificationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduledTime == input.ScheduledTime ||
                    (this.ScheduledTime != null &&
                    this.ScheduledTime.Equals(input.ScheduledTime))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.ScheduledTime != null)
                    hashCode = hashCode * 59 + this.ScheduledTime.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }

}
