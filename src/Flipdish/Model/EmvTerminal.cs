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
    /// EMV Payment Terminal
    /// </summary>
    [DataContract]
    public partial class EmvTerminal :  IEquatable<EmvTerminal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmvTerminal" /> class.
        /// </summary>
        /// <param name="emvTerminalId">Flipdish Identifier of Terminal.</param>
        /// <param name="terminalId">External Identifier of Terminal.</param>
        /// <param name="url">URL at which terminal can be accessed.</param>
        /// <param name="token">TOKEN required to access terminal.</param>
        /// <param name="softwareHouseId">Identifies us to Provider.</param>
        /// <param name="installerId">Identifies installer of terminal.</param>
        public EmvTerminal(int? emvTerminalId = default(int?), string terminalId = default(string), string url = default(string), string token = default(string), string softwareHouseId = default(string), string installerId = default(string))
        {
            this.EmvTerminalId = emvTerminalId;
            this.TerminalId = terminalId;
            this.Url = url;
            this.Token = token;
            this.SoftwareHouseId = softwareHouseId;
            this.InstallerId = installerId;
        }
        
        /// <summary>
        /// Flipdish Identifier of Terminal
        /// </summary>
        /// <value>Flipdish Identifier of Terminal</value>
        [DataMember(Name="EmvTerminalId", EmitDefaultValue=false)]
        public int? EmvTerminalId { get; set; }

        /// <summary>
        /// External Identifier of Terminal
        /// </summary>
        /// <value>External Identifier of Terminal</value>
        [DataMember(Name="TerminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// URL at which terminal can be accessed
        /// </summary>
        /// <value>URL at which terminal can be accessed</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// TOKEN required to access terminal
        /// </summary>
        /// <value>TOKEN required to access terminal</value>
        [DataMember(Name="Token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Identifies us to Provider
        /// </summary>
        /// <value>Identifies us to Provider</value>
        [DataMember(Name="SoftwareHouseId", EmitDefaultValue=false)]
        public string SoftwareHouseId { get; set; }

        /// <summary>
        /// Identifies installer of terminal
        /// </summary>
        /// <value>Identifies installer of terminal</value>
        [DataMember(Name="InstallerId", EmitDefaultValue=false)]
        public string InstallerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmvTerminal {\n");
            sb.Append("  EmvTerminalId: ").Append(EmvTerminalId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  SoftwareHouseId: ").Append(SoftwareHouseId).Append("\n");
            sb.Append("  InstallerId: ").Append(InstallerId).Append("\n");
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
            return this.Equals(input as EmvTerminal);
        }

        /// <summary>
        /// Returns true if EmvTerminal instances are equal
        /// </summary>
        /// <param name="input">Instance of EmvTerminal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmvTerminal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmvTerminalId == input.EmvTerminalId ||
                    (this.EmvTerminalId != null &&
                    this.EmvTerminalId.Equals(input.EmvTerminalId))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.SoftwareHouseId == input.SoftwareHouseId ||
                    (this.SoftwareHouseId != null &&
                    this.SoftwareHouseId.Equals(input.SoftwareHouseId))
                ) && 
                (
                    this.InstallerId == input.InstallerId ||
                    (this.InstallerId != null &&
                    this.InstallerId.Equals(input.InstallerId))
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
                if (this.EmvTerminalId != null)
                    hashCode = hashCode * 59 + this.EmvTerminalId.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.SoftwareHouseId != null)
                    hashCode = hashCode * 59 + this.SoftwareHouseId.GetHashCode();
                if (this.InstallerId != null)
                    hashCode = hashCode * 59 + this.InstallerId.GetHashCode();
                return hashCode;
            }
        }
    }

}
