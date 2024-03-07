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
    /// PayoutReport3DetailsSalesLine
    /// </summary>
    [DataContract]
    public partial class PayoutReport3DetailsSalesLine :  IEquatable<PayoutReport3DetailsSalesLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutReport3DetailsSalesLine" /> class.
        /// </summary>
        /// <param name="online">online.</param>
        /// <param name="pos">pos.</param>
        /// <param name="other">other.</param>
        /// <param name="total">total.</param>
        public PayoutReport3DetailsSalesLine(double? online = default(double?), double? pos = default(double?), double? other = default(double?), double? total = default(double?))
        {
            this.Online = online;
            this.Pos = pos;
            this.Other = other;
            this.Total = total;
        }
        
        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name="Online", EmitDefaultValue=false)]
        public double? Online { get; set; }

        /// <summary>
        /// Gets or Sets Pos
        /// </summary>
        [DataMember(Name="Pos", EmitDefaultValue=false)]
        public double? Pos { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="Other", EmitDefaultValue=false)]
        public double? Other { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutReport3DetailsSalesLine {\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Pos: ").Append(Pos).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as PayoutReport3DetailsSalesLine);
        }

        /// <summary>
        /// Returns true if PayoutReport3DetailsSalesLine instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutReport3DetailsSalesLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutReport3DetailsSalesLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
                ) && 
                (
                    this.Pos == input.Pos ||
                    (this.Pos != null &&
                    this.Pos.Equals(input.Pos))
                ) && 
                (
                    this.Other == input.Other ||
                    (this.Other != null &&
                    this.Other.Equals(input.Other))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.Pos != null)
                    hashCode = hashCode * 59 + this.Pos.GetHashCode();
                if (this.Other != null)
                    hashCode = hashCode * 59 + this.Other.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }

}
