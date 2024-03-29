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
    /// Response with any menu elements that had issues being hidden/shown
    /// </summary>
    [DataContract]
    public partial class MenuElementListItemResponse :  IEquatable<MenuElementListItemResponse>
    {
        /// <summary>
        /// Type of menu element
        /// </summary>
        /// <value>Type of menu element</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MenuElementTypeEnum
        {
            
            /// <summary>
            /// Enum Item for value: Item
            /// </summary>
            [EnumMember(Value = "Item")]
            Item = 1,
            
            /// <summary>
            /// Enum OptionSetItem for value: OptionSetItem
            /// </summary>
            [EnumMember(Value = "OptionSetItem")]
            OptionSetItem = 2
        }

        /// <summary>
        /// Type of menu element
        /// </summary>
        /// <value>Type of menu element</value>
        [DataMember(Name="MenuElementType", EmitDefaultValue=false)]
        public MenuElementTypeEnum? MenuElementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuElementListItemResponse" /> class.
        /// </summary>
        /// <param name="menuElementId">Holds the information for the A and CNAME Records of a domain..</param>
        /// <param name="menuElementType">Type of menu element.</param>
        public MenuElementListItemResponse(int? menuElementId = default(int?), MenuElementTypeEnum? menuElementType = default(MenuElementTypeEnum?))
        {
            this.MenuElementId = menuElementId;
            this.MenuElementType = menuElementType;
        }
        
        /// <summary>
        /// Holds the information for the A and CNAME Records of a domain.
        /// </summary>
        /// <value>Holds the information for the A and CNAME Records of a domain.</value>
        [DataMember(Name="MenuElementId", EmitDefaultValue=false)]
        public int? MenuElementId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuElementListItemResponse {\n");
            sb.Append("  MenuElementId: ").Append(MenuElementId).Append("\n");
            sb.Append("  MenuElementType: ").Append(MenuElementType).Append("\n");
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
            return this.Equals(input as MenuElementListItemResponse);
        }

        /// <summary>
        /// Returns true if MenuElementListItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuElementListItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuElementListItemResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuElementId == input.MenuElementId ||
                    (this.MenuElementId != null &&
                    this.MenuElementId.Equals(input.MenuElementId))
                ) && 
                (
                    this.MenuElementType == input.MenuElementType ||
                    (this.MenuElementType != null &&
                    this.MenuElementType.Equals(input.MenuElementType))
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
                if (this.MenuElementId != null)
                    hashCode = hashCode * 59 + this.MenuElementId.GetHashCode();
                if (this.MenuElementType != null)
                    hashCode = hashCode * 59 + this.MenuElementType.GetHashCode();
                return hashCode;
            }
        }
    }

}
