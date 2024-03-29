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
    /// Http Request and Response Log
    /// </summary>
    [DataContract]
    public partial class HttpRequestAndResponseLog :  IEquatable<HttpRequestAndResponseLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestAndResponseLog" /> class.
        /// </summary>
        /// <param name="guid">Id of the log.</param>
        /// <param name="verb">Verb associated with the HTTP call..</param>
        /// <param name="requestUri">Http request URI..</param>
        /// <param name="statusCode">Http response status code..</param>
        /// <param name="reasonPhrase">Http response status line..</param>
        /// <param name="callDurationInMilliseconds">Call duration representing the duration of the HTTP call in milliseconds..</param>
        /// <param name="userId">Identity of the caller..</param>
        /// <param name="ipAddress">Ip address of the caller.</param>
        /// <param name="createdDateTime">Timestamp at which the HTTP call took place..</param>
        /// <param name="requestHeaders">Http request headers..</param>
        /// <param name="requestBody">Http request body, if any..</param>
        /// <param name="requestLength">Http request content-length.</param>
        /// <param name="responseHeaders">Http response headers..</param>
        /// <param name="responseBody">Http response body..</param>
        /// <param name="responseLength">Http response content-length.</param>
        public HttpRequestAndResponseLog(Guid? guid = default(Guid?), string verb = default(string), string requestUri = default(string), int? statusCode = default(int?), string reasonPhrase = default(string), long? callDurationInMilliseconds = default(long?), string userId = default(string), string ipAddress = default(string), string createdDateTime = default(string), Dictionary<string, string> requestHeaders = default(Dictionary<string, string>), string requestBody = default(string), long? requestLength = default(long?), Dictionary<string, string> responseHeaders = default(Dictionary<string, string>), string responseBody = default(string), long? responseLength = default(long?))
        {
            this.Guid = guid;
            this.Verb = verb;
            this.RequestUri = requestUri;
            this.StatusCode = statusCode;
            this.ReasonPhrase = reasonPhrase;
            this.CallDurationInMilliseconds = callDurationInMilliseconds;
            this.UserId = userId;
            this.IpAddress = ipAddress;
            this.CreatedDateTime = createdDateTime;
            this.RequestHeaders = requestHeaders;
            this.RequestBody = requestBody;
            this.RequestLength = requestLength;
            this.ResponseHeaders = responseHeaders;
            this.ResponseBody = responseBody;
            this.ResponseLength = responseLength;
        }
        
        /// <summary>
        /// Id of the log
        /// </summary>
        /// <value>Id of the log</value>
        [DataMember(Name="Guid", EmitDefaultValue=false)]
        public Guid? Guid { get; set; }

        /// <summary>
        /// Verb associated with the HTTP call.
        /// </summary>
        /// <value>Verb associated with the HTTP call.</value>
        [DataMember(Name="Verb", EmitDefaultValue=false)]
        public string Verb { get; set; }

        /// <summary>
        /// Http request URI.
        /// </summary>
        /// <value>Http request URI.</value>
        [DataMember(Name="RequestUri", EmitDefaultValue=false)]
        public string RequestUri { get; set; }

        /// <summary>
        /// Http response status code.
        /// </summary>
        /// <value>Http response status code.</value>
        [DataMember(Name="StatusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Http response status line.
        /// </summary>
        /// <value>Http response status line.</value>
        [DataMember(Name="ReasonPhrase", EmitDefaultValue=false)]
        public string ReasonPhrase { get; set; }

        /// <summary>
        /// Call duration representing the duration of the HTTP call in milliseconds.
        /// </summary>
        /// <value>Call duration representing the duration of the HTTP call in milliseconds.</value>
        [DataMember(Name="CallDurationInMilliseconds", EmitDefaultValue=false)]
        public long? CallDurationInMilliseconds { get; set; }

        /// <summary>
        /// Identity of the caller.
        /// </summary>
        /// <value>Identity of the caller.</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Ip address of the caller
        /// </summary>
        /// <value>Ip address of the caller</value>
        [DataMember(Name="IpAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Timestamp at which the HTTP call took place.
        /// </summary>
        /// <value>Timestamp at which the HTTP call took place.</value>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Http request headers.
        /// </summary>
        /// <value>Http request headers.</value>
        [DataMember(Name="RequestHeaders", EmitDefaultValue=false)]
        public Dictionary<string, string> RequestHeaders { get; set; }

        /// <summary>
        /// Http request body, if any.
        /// </summary>
        /// <value>Http request body, if any.</value>
        [DataMember(Name="RequestBody", EmitDefaultValue=false)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Http request content-length
        /// </summary>
        /// <value>Http request content-length</value>
        [DataMember(Name="RequestLength", EmitDefaultValue=false)]
        public long? RequestLength { get; set; }

        /// <summary>
        /// Http response headers.
        /// </summary>
        /// <value>Http response headers.</value>
        [DataMember(Name="ResponseHeaders", EmitDefaultValue=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

        /// <summary>
        /// Http response body.
        /// </summary>
        /// <value>Http response body.</value>
        [DataMember(Name="ResponseBody", EmitDefaultValue=false)]
        public string ResponseBody { get; set; }

        /// <summary>
        /// Http response content-length
        /// </summary>
        /// <value>Http response content-length</value>
        [DataMember(Name="ResponseLength", EmitDefaultValue=false)]
        public long? ResponseLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpRequestAndResponseLog {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
            sb.Append("  RequestUri: ").Append(RequestUri).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ReasonPhrase: ").Append(ReasonPhrase).Append("\n");
            sb.Append("  CallDurationInMilliseconds: ").Append(CallDurationInMilliseconds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  RequestLength: ").Append(RequestLength).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  ResponseLength: ").Append(ResponseLength).Append("\n");
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
            return this.Equals(input as HttpRequestAndResponseLog);
        }

        /// <summary>
        /// Returns true if HttpRequestAndResponseLog instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpRequestAndResponseLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpRequestAndResponseLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Verb == input.Verb ||
                    (this.Verb != null &&
                    this.Verb.Equals(input.Verb))
                ) && 
                (
                    this.RequestUri == input.RequestUri ||
                    (this.RequestUri != null &&
                    this.RequestUri.Equals(input.RequestUri))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ReasonPhrase == input.ReasonPhrase ||
                    (this.ReasonPhrase != null &&
                    this.ReasonPhrase.Equals(input.ReasonPhrase))
                ) && 
                (
                    this.CallDurationInMilliseconds == input.CallDurationInMilliseconds ||
                    (this.CallDurationInMilliseconds != null &&
                    this.CallDurationInMilliseconds.Equals(input.CallDurationInMilliseconds))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.RequestHeaders == input.RequestHeaders ||
                    this.RequestHeaders != null &&
                    this.RequestHeaders.SequenceEqual(input.RequestHeaders)
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.RequestLength == input.RequestLength ||
                    (this.RequestLength != null &&
                    this.RequestLength.Equals(input.RequestLength))
                ) && 
                (
                    this.ResponseHeaders == input.ResponseHeaders ||
                    this.ResponseHeaders != null &&
                    this.ResponseHeaders.SequenceEqual(input.ResponseHeaders)
                ) && 
                (
                    this.ResponseBody == input.ResponseBody ||
                    (this.ResponseBody != null &&
                    this.ResponseBody.Equals(input.ResponseBody))
                ) && 
                (
                    this.ResponseLength == input.ResponseLength ||
                    (this.ResponseLength != null &&
                    this.ResponseLength.Equals(input.ResponseLength))
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
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Verb != null)
                    hashCode = hashCode * 59 + this.Verb.GetHashCode();
                if (this.RequestUri != null)
                    hashCode = hashCode * 59 + this.RequestUri.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ReasonPhrase != null)
                    hashCode = hashCode * 59 + this.ReasonPhrase.GetHashCode();
                if (this.CallDurationInMilliseconds != null)
                    hashCode = hashCode * 59 + this.CallDurationInMilliseconds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.RequestHeaders != null)
                    hashCode = hashCode * 59 + this.RequestHeaders.GetHashCode();
                if (this.RequestBody != null)
                    hashCode = hashCode * 59 + this.RequestBody.GetHashCode();
                if (this.RequestLength != null)
                    hashCode = hashCode * 59 + this.RequestLength.GetHashCode();
                if (this.ResponseHeaders != null)
                    hashCode = hashCode * 59 + this.ResponseHeaders.GetHashCode();
                if (this.ResponseBody != null)
                    hashCode = hashCode * 59 + this.ResponseBody.GetHashCode();
                if (this.ResponseLength != null)
                    hashCode = hashCode * 59 + this.ResponseLength.GetHashCode();
                return hashCode;
            }
        }
    }

}
