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
    /// Order batch
    /// </summary>
    [DataContract]
    public partial class OrderBatch :  IEquatable<OrderBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBatch" /> class.
        /// </summary>
        /// <param name="id">Order batch id.</param>
        /// <param name="displayCode">Order batch 6-sign human readable code.</param>
        /// <param name="createTime">Batch creation date and time.</param>
        /// <param name="isPublished">If the batch is already published.</param>
        /// <param name="orderIds">Orders&#39; ids on the batch.</param>
        public OrderBatch(int? id = default(int?), string displayCode = default(string), DateTime? createTime = default(DateTime?), bool? isPublished = default(bool?), List<int?> orderIds = default(List<int?>))
        {
            this.Id = id;
            this.DisplayCode = displayCode;
            this.CreateTime = createTime;
            this.IsPublished = isPublished;
            this.OrderIds = orderIds;
        }
        
        /// <summary>
        /// Order batch id
        /// </summary>
        /// <value>Order batch id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Order batch 6-sign human readable code
        /// </summary>
        /// <value>Order batch 6-sign human readable code</value>
        [DataMember(Name="DisplayCode", EmitDefaultValue=false)]
        public string DisplayCode { get; set; }

        /// <summary>
        /// Batch creation date and time
        /// </summary>
        /// <value>Batch creation date and time</value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// If the batch is already published
        /// </summary>
        /// <value>If the batch is already published</value>
        [DataMember(Name="IsPublished", EmitDefaultValue=false)]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Orders&#39; ids on the batch
        /// </summary>
        /// <value>Orders&#39; ids on the batch</value>
        [DataMember(Name="OrderIds", EmitDefaultValue=false)]
        public List<int?> OrderIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBatch {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayCode: ").Append(DisplayCode).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
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
            return this.Equals(input as OrderBatch);
        }

        /// <summary>
        /// Returns true if OrderBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayCode == input.DisplayCode ||
                    (this.DisplayCode != null &&
                    this.DisplayCode.Equals(input.DisplayCode))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.IsPublished == input.IsPublished ||
                    (this.IsPublished != null &&
                    this.IsPublished.Equals(input.IsPublished))
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayCode != null)
                    hashCode = hashCode * 59 + this.DisplayCode.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.IsPublished != null)
                    hashCode = hashCode * 59 + this.IsPublished.GetHashCode();
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
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
