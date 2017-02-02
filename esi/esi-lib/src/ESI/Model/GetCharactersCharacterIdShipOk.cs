/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
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

namespace ESI.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdShipOk :  IEquatable<GetCharactersCharacterIdShipOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdShipOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdShipOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdShipOk" /> class.
        /// </summary>
        /// <param name="ShipItemId">Item id&#39;s are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type. (required).</param>
        /// <param name="ShipName">ship_name string (required).</param>
        /// <param name="ShipTypeId">ship_type_id integer (required).</param>
        public GetCharactersCharacterIdShipOk(long? ShipItemId = default(long?), string ShipName = default(string), int? ShipTypeId = default(int?))
        {
            // to ensure "ShipItemId" is required (not null)
            if (ShipItemId == null)
            {
                throw new InvalidDataException("ShipItemId is a required property for GetCharactersCharacterIdShipOk and cannot be null");
            }
            else
            {
                this.ShipItemId = ShipItemId;
            }
            // to ensure "ShipName" is required (not null)
            if (ShipName == null)
            {
                throw new InvalidDataException("ShipName is a required property for GetCharactersCharacterIdShipOk and cannot be null");
            }
            else
            {
                this.ShipName = ShipName;
            }
            // to ensure "ShipTypeId" is required (not null)
            if (ShipTypeId == null)
            {
                throw new InvalidDataException("ShipTypeId is a required property for GetCharactersCharacterIdShipOk and cannot be null");
            }
            else
            {
                this.ShipTypeId = ShipTypeId;
            }
        }
        
        /// <summary>
        /// Item id&#39;s are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type.
        /// </summary>
        /// <value>Item id&#39;s are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type.</value>
        [DataMember(Name="ship_item_id", EmitDefaultValue=false)]
        public long? ShipItemId { get; set; }
        /// <summary>
        /// ship_name string
        /// </summary>
        /// <value>ship_name string</value>
        [DataMember(Name="ship_name", EmitDefaultValue=false)]
        public string ShipName { get; set; }
        /// <summary>
        /// ship_type_id integer
        /// </summary>
        /// <value>ship_type_id integer</value>
        [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
        public int? ShipTypeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdShipOk {\n");
            sb.Append("  ShipItemId: ").Append(ShipItemId).Append("\n");
            sb.Append("  ShipName: ").Append(ShipName).Append("\n");
            sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetCharactersCharacterIdShipOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdShipOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdShipOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdShipOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShipItemId == other.ShipItemId ||
                    this.ShipItemId != null &&
                    this.ShipItemId.Equals(other.ShipItemId)
                ) && 
                (
                    this.ShipName == other.ShipName ||
                    this.ShipName != null &&
                    this.ShipName.Equals(other.ShipName)
                ) && 
                (
                    this.ShipTypeId == other.ShipTypeId ||
                    this.ShipTypeId != null &&
                    this.ShipTypeId.Equals(other.ShipTypeId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ShipItemId != null)
                    hash = hash * 59 + this.ShipItemId.GetHashCode();
                if (this.ShipName != null)
                    hash = hash * 59 + this.ShipName.GetHashCode();
                if (this.ShipTypeId != null)
                    hash = hash * 59 + this.ShipTypeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
