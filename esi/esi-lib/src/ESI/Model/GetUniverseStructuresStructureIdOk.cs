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
    public partial class GetUniverseStructuresStructureIdOk :  IEquatable<GetUniverseStructuresStructureIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseStructuresStructureIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseStructuresStructureIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseStructuresStructureIdOk" /> class.
        /// </summary>
        /// <param name="Name">The full name of the structure (required).</param>
        /// <param name="Position">Position.</param>
        /// <param name="SolarSystemId">solar_system_id integer (required).</param>
        /// <param name="TypeId">type_id integer.</param>
        public GetUniverseStructuresStructureIdOk(string Name = default(string), GetUniverseStructuresStructureIdPosition Position = default(GetUniverseStructuresStructureIdPosition), int? SolarSystemId = default(int?), int? TypeId = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GetUniverseStructuresStructureIdOk and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "SolarSystemId" is required (not null)
            if (SolarSystemId == null)
            {
                throw new InvalidDataException("SolarSystemId is a required property for GetUniverseStructuresStructureIdOk and cannot be null");
            }
            else
            {
                this.SolarSystemId = SolarSystemId;
            }
            this.Position = Position;
            this.TypeId = TypeId;
        }
        
        /// <summary>
        /// The full name of the structure
        /// </summary>
        /// <value>The full name of the structure</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public GetUniverseStructuresStructureIdPosition Position { get; set; }
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }
        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseStructuresStructureIdOk {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(obj as GetUniverseStructuresStructureIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseStructuresStructureIdOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetUniverseStructuresStructureIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseStructuresStructureIdOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.SolarSystemId == other.SolarSystemId ||
                    this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(other.SolarSystemId)
                ) && 
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.SolarSystemId != null)
                    hash = hash * 59 + this.SolarSystemId.GetHashCode();
                if (this.TypeId != null)
                    hash = hash * 59 + this.TypeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
