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
    /// ExecuteConfigurationActionResult
    /// </summary>
    [DataContract]
    public partial class ExecuteConfigurationActionResult :  IEquatable<ExecuteConfigurationActionResult>
    {
        /// <summary>
        /// Defines RedirectTarget
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RedirectTargetEnum
        {
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,
            
            /// <summary>
            /// Enum NewWindow for value: NewWindow
            /// </summary>
            [EnumMember(Value = "NewWindow")]
            NewWindow = 2,
            
            /// <summary>
            /// Enum Popup for value: Popup
            /// </summary>
            [EnumMember(Value = "Popup")]
            Popup = 3
        }

        /// <summary>
        /// Gets or Sets RedirectTarget
        /// </summary>
        [DataMember(Name="RedirectTarget", EmitDefaultValue=false)]
        public RedirectTargetEnum? RedirectTarget { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteConfigurationActionResult" /> class.
        /// </summary>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="infoMessage">infoMessage.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="redirectTarget">redirectTarget.</param>
        public ExecuteConfigurationActionResult(string errorMessage = default(string), string infoMessage = default(string), string redirectUrl = default(string), RedirectTargetEnum? redirectTarget = default(RedirectTargetEnum?))
        {
            this.ErrorMessage = errorMessage;
            this.InfoMessage = infoMessage;
            this.RedirectUrl = redirectUrl;
            this.RedirectTarget = redirectTarget;
        }
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets InfoMessage
        /// </summary>
        [DataMember(Name="InfoMessage", EmitDefaultValue=false)]
        public string InfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="RedirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteConfigurationActionResult {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  InfoMessage: ").Append(InfoMessage).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  RedirectTarget: ").Append(RedirectTarget).Append("\n");
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
            return this.Equals(input as ExecuteConfigurationActionResult);
        }

        /// <summary>
        /// Returns true if ExecuteConfigurationActionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteConfigurationActionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteConfigurationActionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.InfoMessage == input.InfoMessage ||
                    (this.InfoMessage != null &&
                    this.InfoMessage.Equals(input.InfoMessage))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.RedirectTarget == input.RedirectTarget ||
                    (this.RedirectTarget != null &&
                    this.RedirectTarget.Equals(input.RedirectTarget))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.InfoMessage != null)
                    hashCode = hashCode * 59 + this.InfoMessage.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.RedirectTarget != null)
                    hashCode = hashCode * 59 + this.RedirectTarget.GetHashCode();
                return hashCode;
            }
        }
    }

}
