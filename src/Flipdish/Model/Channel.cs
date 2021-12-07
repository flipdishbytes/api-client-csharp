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
    /// Channel
    /// </summary>
    [DataContract]
    public partial class Channel :  IEquatable<Channel>, IValidatableObject
    {
        /// <summary>
        /// Channel Source
        /// </summary>
        /// <value>Channel Source</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Internal for value: Internal
            /// </summary>
            [EnumMember(Value = "Internal")]
            Internal = 1,
            
            /// <summary>
            /// Enum External for value: External
            /// </summary>
            [EnumMember(Value = "External")]
            External = 2
        }

        /// <summary>
        /// Channel Source
        /// </summary>
        /// <value>Channel Source</value>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="channelId">Channel Id.</param>
        /// <param name="translationKey">Channel TranslationKey.</param>
        /// <param name="source">Channel Source.</param>
        /// <param name="logoUri">Channel Logo URl.</param>
        /// <param name="available">Channel is Available or not.</param>
        /// <param name="maintainedExternally">Channel is Maintained Externally or not.</param>
        public Channel(int? channelId = default(int?), string translationKey = default(string), SourceEnum? source = default(SourceEnum?), string logoUri = default(string), bool? available = default(bool?), bool? maintainedExternally = default(bool?))
        {
            this.ChannelId = channelId;
            this.TranslationKey = translationKey;
            this.Source = source;
            this.LogoUri = logoUri;
            this.Available = available;
            this.MaintainedExternally = maintainedExternally;
        }
        
        /// <summary>
        /// Channel Id
        /// </summary>
        /// <value>Channel Id</value>
        [DataMember(Name="ChannelId", EmitDefaultValue=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// Channel TranslationKey
        /// </summary>
        /// <value>Channel TranslationKey</value>
        [DataMember(Name="TranslationKey", EmitDefaultValue=false)]
        public string TranslationKey { get; set; }


        /// <summary>
        /// Channel Logo URl
        /// </summary>
        /// <value>Channel Logo URl</value>
        [DataMember(Name="LogoUri", EmitDefaultValue=false)]
        public string LogoUri { get; set; }

        /// <summary>
        /// Channel is Available or not
        /// </summary>
        /// <value>Channel is Available or not</value>
        [DataMember(Name="Available", EmitDefaultValue=false)]
        public bool? Available { get; set; }

        /// <summary>
        /// Channel is Maintained Externally or not
        /// </summary>
        /// <value>Channel is Maintained Externally or not</value>
        [DataMember(Name="MaintainedExternally", EmitDefaultValue=false)]
        public bool? MaintainedExternally { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Channel {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  TranslationKey: ").Append(TranslationKey).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  MaintainedExternally: ").Append(MaintainedExternally).Append("\n");
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
            return this.Equals(input as Channel);
        }

        /// <summary>
        /// Returns true if Channel instances are equal
        /// </summary>
        /// <param name="input">Instance of Channel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Channel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.TranslationKey == input.TranslationKey ||
                    (this.TranslationKey != null &&
                    this.TranslationKey.Equals(input.TranslationKey))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.LogoUri == input.LogoUri ||
                    (this.LogoUri != null &&
                    this.LogoUri.Equals(input.LogoUri))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.MaintainedExternally == input.MaintainedExternally ||
                    (this.MaintainedExternally != null &&
                    this.MaintainedExternally.Equals(input.MaintainedExternally))
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
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.TranslationKey != null)
                    hashCode = hashCode * 59 + this.TranslationKey.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.LogoUri != null)
                    hashCode = hashCode * 59 + this.LogoUri.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.MaintainedExternally != null)
                    hashCode = hashCode * 59 + this.MaintainedExternally.GetHashCode();
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
