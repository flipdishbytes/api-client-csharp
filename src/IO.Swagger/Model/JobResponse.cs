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
    /// Job Response
    /// </summary>
    [DataContract]
    public partial class JobResponse :  IEquatable<JobResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="createdAt">Created At.</param>
        /// <param name="status">Status.</param>
        /// <param name="packageType">Package Type.</param>
        /// <param name="transportType">Transport Type.</param>
        /// <param name="assignmentCode">Assignment Code.</param>
        /// <param name="pickupAt">Pickup At.</param>
        /// <param name="dropoffAt">Dropoff At.</param>
        /// <param name="comment">Comment.</param>
        /// <param name="distance">Distance.</param>
        /// <param name="duration">Duration.</param>
        /// <param name="deliveries">Deliveries.</param>
        /// <param name="pricing">Pricing.</param>
        /// <param name="driver">Driver.</param>
        public JobResponse(int? id = default(int?), DateTime? createdAt = default(DateTime?), string status = default(string), string packageType = default(string), string transportType = default(string), string assignmentCode = default(string), string pickupAt = default(string), string dropoffAt = default(string), string comment = default(string), double? distance = default(double?), int? duration = default(int?), List<JobDelivery> deliveries = default(List<JobDelivery>), JobPricing pricing = default(JobPricing), JobDriver driver = default(JobDriver))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.PackageType = packageType;
            this.TransportType = transportType;
            this.AssignmentCode = assignmentCode;
            this.PickupAt = pickupAt;
            this.DropoffAt = dropoffAt;
            this.Comment = comment;
            this.Distance = distance;
            this.Duration = duration;
            this.Deliveries = deliveries;
            this.Pricing = pricing;
            this.Driver = driver;
        }
        
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Created At
        /// </summary>
        /// <value>Created At</value>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Package Type
        /// </summary>
        /// <value>Package Type</value>
        [DataMember(Name="PackageType", EmitDefaultValue=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// Transport Type
        /// </summary>
        /// <value>Transport Type</value>
        [DataMember(Name="TransportType", EmitDefaultValue=false)]
        public string TransportType { get; set; }

        /// <summary>
        /// Assignment Code
        /// </summary>
        /// <value>Assignment Code</value>
        [DataMember(Name="AssignmentCode", EmitDefaultValue=false)]
        public string AssignmentCode { get; set; }

        /// <summary>
        /// Pickup At
        /// </summary>
        /// <value>Pickup At</value>
        [DataMember(Name="PickupAt", EmitDefaultValue=false)]
        public string PickupAt { get; set; }

        /// <summary>
        /// Dropoff At
        /// </summary>
        /// <value>Dropoff At</value>
        [DataMember(Name="DropoffAt", EmitDefaultValue=false)]
        public string DropoffAt { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// <value>Comment</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Distance
        /// </summary>
        /// <value>Distance</value>
        [DataMember(Name="Distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        /// <value>Duration</value>
        [DataMember(Name="Duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Deliveries
        /// </summary>
        /// <value>Deliveries</value>
        [DataMember(Name="Deliveries", EmitDefaultValue=false)]
        public List<JobDelivery> Deliveries { get; set; }

        /// <summary>
        /// Pricing
        /// </summary>
        /// <value>Pricing</value>
        [DataMember(Name="Pricing", EmitDefaultValue=false)]
        public JobPricing Pricing { get; set; }

        /// <summary>
        /// Driver
        /// </summary>
        /// <value>Driver</value>
        [DataMember(Name="Driver", EmitDefaultValue=false)]
        public JobDriver Driver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PackageType: ").Append(PackageType).Append("\n");
            sb.Append("  TransportType: ").Append(TransportType).Append("\n");
            sb.Append("  AssignmentCode: ").Append(AssignmentCode).Append("\n");
            sb.Append("  PickupAt: ").Append(PickupAt).Append("\n");
            sb.Append("  DropoffAt: ").Append(DropoffAt).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Deliveries: ").Append(Deliveries).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
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
            return this.Equals(input as JobResponse);
        }

        /// <summary>
        /// Returns true if JobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobResponse input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PackageType == input.PackageType ||
                    (this.PackageType != null &&
                    this.PackageType.Equals(input.PackageType))
                ) && 
                (
                    this.TransportType == input.TransportType ||
                    (this.TransportType != null &&
                    this.TransportType.Equals(input.TransportType))
                ) && 
                (
                    this.AssignmentCode == input.AssignmentCode ||
                    (this.AssignmentCode != null &&
                    this.AssignmentCode.Equals(input.AssignmentCode))
                ) && 
                (
                    this.PickupAt == input.PickupAt ||
                    (this.PickupAt != null &&
                    this.PickupAt.Equals(input.PickupAt))
                ) && 
                (
                    this.DropoffAt == input.DropoffAt ||
                    (this.DropoffAt != null &&
                    this.DropoffAt.Equals(input.DropoffAt))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Deliveries == input.Deliveries ||
                    this.Deliveries != null &&
                    this.Deliveries.SequenceEqual(input.Deliveries)
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    (this.Pricing != null &&
                    this.Pricing.Equals(input.Pricing))
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PackageType != null)
                    hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.TransportType != null)
                    hashCode = hashCode * 59 + this.TransportType.GetHashCode();
                if (this.AssignmentCode != null)
                    hashCode = hashCode * 59 + this.AssignmentCode.GetHashCode();
                if (this.PickupAt != null)
                    hashCode = hashCode * 59 + this.PickupAt.GetHashCode();
                if (this.DropoffAt != null)
                    hashCode = hashCode * 59 + this.DropoffAt.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Deliveries != null)
                    hashCode = hashCode * 59 + this.Deliveries.GetHashCode();
                if (this.Pricing != null)
                    hashCode = hashCode * 59 + this.Pricing.GetHashCode();
                if (this.Driver != null)
                    hashCode = hashCode * 59 + this.Driver.GetHashCode();
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
