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
    /// A list of orders.
    /// </summary>
    [DataContract]
    public partial class OrderList :  IEquatable<OrderList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderList" /> class.
        /// </summary>
        /// <param name="orders">A list of orders..</param>
        public OrderList(List<OrderReference> orders = default(List<OrderReference>))
        {
            this.Orders = orders;
        }
        
        /// <summary>
        /// A list of orders.
        /// </summary>
        /// <value>A list of orders.</value>
        [DataMember(Name="Orders", EmitDefaultValue=false)]
        public List<OrderReference> Orders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderList {\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
            return this.Equals(input as OrderList);
        }

        /// <summary>
        /// Returns true if OrderList instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
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
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
                return hashCode;
            }
        }
    }

}
