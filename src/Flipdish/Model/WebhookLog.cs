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
    /// WebhookLog
    /// </summary>
    [DataContract]
    public partial class WebhookLog :  IEquatable<WebhookLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLog" /> class.
        /// </summary>
        /// <param name="WebhookSubscriptionOwnerUserId">WebhookSubscriptionOwnerUserId.</param>
        /// <param name="EventCreated">EventCreated.</param>
        /// <param name="WebhookTriggered">WebhookTriggered.</param>
        /// <param name="WebhookEventName">WebhookEventName.</param>
        /// <param name="WebhookSubscriptionCallbackUrl">WebhookSubscriptionCallbackUrl.</param>
        /// <param name="HttpResponseStatusCode">HttpResponseStatusCode.</param>
        /// <param name="HttpResponseStatus">HttpResponseStatus.</param>
        /// <param name="RequestHeaders">RequestHeaders.</param>
        /// <param name="RequestBody">RequestBody.</param>
        /// <param name="ResponseHeaders">ResponseHeaders.</param>
        /// <param name="ResponseBody">ResponseBody.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="RetryCount">RetryCount.</param>
        /// <param name="FlipdishWebhookId">FlipdishWebhookId.</param>
        public WebhookLog(int? WebhookSubscriptionOwnerUserId = default(int?), string EventCreated = default(string), string WebhookTriggered = default(string), string WebhookEventName = default(string), string WebhookSubscriptionCallbackUrl = default(string), string HttpResponseStatusCode = default(string), string HttpResponseStatus = default(string), string RequestHeaders = default(string), string RequestBody = default(string), string ResponseHeaders = default(string), string ResponseBody = default(string), string Duration = default(string), int? RetryCount = default(int?), Guid? FlipdishWebhookId = default(Guid?))
        {
            this.WebhookSubscriptionOwnerUserId = WebhookSubscriptionOwnerUserId;
            this.EventCreated = EventCreated;
            this.WebhookTriggered = WebhookTriggered;
            this.WebhookEventName = WebhookEventName;
            this.WebhookSubscriptionCallbackUrl = WebhookSubscriptionCallbackUrl;
            this.HttpResponseStatusCode = HttpResponseStatusCode;
            this.HttpResponseStatus = HttpResponseStatus;
            this.RequestHeaders = RequestHeaders;
            this.RequestBody = RequestBody;
            this.ResponseHeaders = ResponseHeaders;
            this.ResponseBody = ResponseBody;
            this.Duration = Duration;
            this.RetryCount = RetryCount;
            this.FlipdishWebhookId = FlipdishWebhookId;
        }
        
        /// <summary>
        /// Gets or Sets WebhookSubscriptionOwnerUserId
        /// </summary>
        [DataMember(Name="webhookSubscriptionOwnerUserId", EmitDefaultValue=false)]
        public int? WebhookSubscriptionOwnerUserId { get; set; }

        /// <summary>
        /// Gets or Sets EventCreated
        /// </summary>
        [DataMember(Name="eventCreated", EmitDefaultValue=false)]
        public string EventCreated { get; set; }

        /// <summary>
        /// Gets or Sets WebhookTriggered
        /// </summary>
        [DataMember(Name="webhookTriggered", EmitDefaultValue=false)]
        public string WebhookTriggered { get; set; }

        /// <summary>
        /// Gets or Sets WebhookEventName
        /// </summary>
        [DataMember(Name="webhookEventName", EmitDefaultValue=false)]
        public string WebhookEventName { get; set; }

        /// <summary>
        /// Gets or Sets WebhookSubscriptionCallbackUrl
        /// </summary>
        [DataMember(Name="webhookSubscriptionCallbackUrl", EmitDefaultValue=false)]
        public string WebhookSubscriptionCallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets HttpResponseStatusCode
        /// </summary>
        [DataMember(Name="httpResponseStatusCode", EmitDefaultValue=false)]
        public string HttpResponseStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets HttpResponseStatus
        /// </summary>
        [DataMember(Name="httpResponseStatus", EmitDefaultValue=false)]
        public string HttpResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets RequestHeaders
        /// </summary>
        [DataMember(Name="requestHeaders", EmitDefaultValue=false)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// Gets or Sets RequestBody
        /// </summary>
        [DataMember(Name="requestBody", EmitDefaultValue=false)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Gets or Sets ResponseHeaders
        /// </summary>
        [DataMember(Name="responseHeaders", EmitDefaultValue=false)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// Gets or Sets ResponseBody
        /// </summary>
        [DataMember(Name="responseBody", EmitDefaultValue=false)]
        public string ResponseBody { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets RetryCount
        /// </summary>
        [DataMember(Name="retryCount", EmitDefaultValue=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// Gets or Sets FlipdishWebhookId
        /// </summary>
        [DataMember(Name="flipdishWebhookId", EmitDefaultValue=false)]
        public Guid? FlipdishWebhookId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLog {\n");
            sb.Append("  WebhookSubscriptionOwnerUserId: ").Append(WebhookSubscriptionOwnerUserId).Append("\n");
            sb.Append("  EventCreated: ").Append(EventCreated).Append("\n");
            sb.Append("  WebhookTriggered: ").Append(WebhookTriggered).Append("\n");
            sb.Append("  WebhookEventName: ").Append(WebhookEventName).Append("\n");
            sb.Append("  WebhookSubscriptionCallbackUrl: ").Append(WebhookSubscriptionCallbackUrl).Append("\n");
            sb.Append("  HttpResponseStatusCode: ").Append(HttpResponseStatusCode).Append("\n");
            sb.Append("  HttpResponseStatus: ").Append(HttpResponseStatus).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  FlipdishWebhookId: ").Append(FlipdishWebhookId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as WebhookLog);
        }

        /// <summary>
        /// Returns true if WebhookLog instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebhookSubscriptionOwnerUserId == input.WebhookSubscriptionOwnerUserId ||
                    (this.WebhookSubscriptionOwnerUserId != null &&
                    this.WebhookSubscriptionOwnerUserId.Equals(input.WebhookSubscriptionOwnerUserId))
                ) && 
                (
                    this.EventCreated == input.EventCreated ||
                    (this.EventCreated != null &&
                    this.EventCreated.Equals(input.EventCreated))
                ) && 
                (
                    this.WebhookTriggered == input.WebhookTriggered ||
                    (this.WebhookTriggered != null &&
                    this.WebhookTriggered.Equals(input.WebhookTriggered))
                ) && 
                (
                    this.WebhookEventName == input.WebhookEventName ||
                    (this.WebhookEventName != null &&
                    this.WebhookEventName.Equals(input.WebhookEventName))
                ) && 
                (
                    this.WebhookSubscriptionCallbackUrl == input.WebhookSubscriptionCallbackUrl ||
                    (this.WebhookSubscriptionCallbackUrl != null &&
                    this.WebhookSubscriptionCallbackUrl.Equals(input.WebhookSubscriptionCallbackUrl))
                ) && 
                (
                    this.HttpResponseStatusCode == input.HttpResponseStatusCode ||
                    (this.HttpResponseStatusCode != null &&
                    this.HttpResponseStatusCode.Equals(input.HttpResponseStatusCode))
                ) && 
                (
                    this.HttpResponseStatus == input.HttpResponseStatus ||
                    (this.HttpResponseStatus != null &&
                    this.HttpResponseStatus.Equals(input.HttpResponseStatus))
                ) && 
                (
                    this.RequestHeaders == input.RequestHeaders ||
                    (this.RequestHeaders != null &&
                    this.RequestHeaders.Equals(input.RequestHeaders))
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.ResponseHeaders == input.ResponseHeaders ||
                    (this.ResponseHeaders != null &&
                    this.ResponseHeaders.Equals(input.ResponseHeaders))
                ) && 
                (
                    this.ResponseBody == input.ResponseBody ||
                    (this.ResponseBody != null &&
                    this.ResponseBody.Equals(input.ResponseBody))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.FlipdishWebhookId == input.FlipdishWebhookId ||
                    (this.FlipdishWebhookId != null &&
                    this.FlipdishWebhookId.Equals(input.FlipdishWebhookId))
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
                if (this.WebhookSubscriptionOwnerUserId != null)
                    hashCode = hashCode * 59 + this.WebhookSubscriptionOwnerUserId.GetHashCode();
                if (this.EventCreated != null)
                    hashCode = hashCode * 59 + this.EventCreated.GetHashCode();
                if (this.WebhookTriggered != null)
                    hashCode = hashCode * 59 + this.WebhookTriggered.GetHashCode();
                if (this.WebhookEventName != null)
                    hashCode = hashCode * 59 + this.WebhookEventName.GetHashCode();
                if (this.WebhookSubscriptionCallbackUrl != null)
                    hashCode = hashCode * 59 + this.WebhookSubscriptionCallbackUrl.GetHashCode();
                if (this.HttpResponseStatusCode != null)
                    hashCode = hashCode * 59 + this.HttpResponseStatusCode.GetHashCode();
                if (this.HttpResponseStatus != null)
                    hashCode = hashCode * 59 + this.HttpResponseStatus.GetHashCode();
                if (this.RequestHeaders != null)
                    hashCode = hashCode * 59 + this.RequestHeaders.GetHashCode();
                if (this.RequestBody != null)
                    hashCode = hashCode * 59 + this.RequestBody.GetHashCode();
                if (this.ResponseHeaders != null)
                    hashCode = hashCode * 59 + this.ResponseHeaders.GetHashCode();
                if (this.ResponseBody != null)
                    hashCode = hashCode * 59 + this.ResponseBody.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.FlipdishWebhookId != null)
                    hashCode = hashCode * 59 + this.FlipdishWebhookId.GetHashCode();
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
