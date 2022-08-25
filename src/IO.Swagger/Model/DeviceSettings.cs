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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Device settings for Hydra
    /// </summary>
    [DataContract]
    public partial class DeviceSettings :  IEquatable<DeviceSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSettings" /> class.
        /// </summary>
        /// <param name="volume">Gets or sets the device volume (required).</param>
        /// <param name="fontSize">Gets or sets the font size used on the device (required).</param>
        /// <param name="brightness">Gets or sets the display brightness on the device (required).</param>
        public DeviceSettings(int? volume = default(int?), double? fontSize = default(double?), int? brightness = default(int?))
        {
            // to ensure "volume" is required (not null)
            if (volume == null)
            {
                throw new InvalidDataException("volume is a required property for DeviceSettings and cannot be null");
            }
            else
            {
                this.Volume = volume;
            }
            // to ensure "fontSize" is required (not null)
            if (fontSize == null)
            {
                throw new InvalidDataException("fontSize is a required property for DeviceSettings and cannot be null");
            }
            else
            {
                this.FontSize = fontSize;
            }
            // to ensure "brightness" is required (not null)
            if (brightness == null)
            {
                throw new InvalidDataException("brightness is a required property for DeviceSettings and cannot be null");
            }
            else
            {
                this.Brightness = brightness;
            }
        }
        
        /// <summary>
        /// Gets or sets the device volume
        /// </summary>
        /// <value>Gets or sets the device volume</value>
        [DataMember(Name="Volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }

        /// <summary>
        /// Gets or sets the font size used on the device
        /// </summary>
        /// <value>Gets or sets the font size used on the device</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the display brightness on the device
        /// </summary>
        /// <value>Gets or sets the display brightness on the device</value>
        [DataMember(Name="Brightness", EmitDefaultValue=false)]
        public int? Brightness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceSettings {\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
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
            return this.Equals(input as DeviceSettings);
        }

        /// <summary>
        /// Returns true if DeviceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.Brightness == input.Brightness ||
                    (this.Brightness != null &&
                    this.Brightness.Equals(input.Brightness))
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
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.Brightness != null)
                    hashCode = hashCode * 59 + this.Brightness.GetHashCode();
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
            // Volume (int?) maximum
            if(this.Volume > (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, must be a value less than or equal to 10.", new [] { "Volume" });
            }

            // Volume (int?) minimum
            if(this.Volume < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, must be a value greater than or equal to 0.", new [] { "Volume" });
            }

            // FontSize (double?) maximum
            if(this.FontSize > (double?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontSize, must be a value less than or equal to 100.", new [] { "FontSize" });
            }

            // FontSize (double?) minimum
            if(this.FontSize < (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontSize, must be a value greater than or equal to 1.", new [] { "FontSize" });
            }

            // Brightness (int?) maximum
            if(this.Brightness > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brightness, must be a value less than or equal to 100.", new [] { "Brightness" });
            }

            // Brightness (int?) minimum
            if(this.Brightness < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brightness, must be a value greater than or equal to 0.", new [] { "Brightness" });
            }

            yield break;
        }
    }

}
