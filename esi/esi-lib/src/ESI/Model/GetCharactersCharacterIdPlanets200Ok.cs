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
    public partial class GetCharactersCharacterIdPlanets200Ok :  IEquatable<GetCharactersCharacterIdPlanets200Ok>, IValidatableObject
    {
        /// <summary>
        /// planet_type string
        /// </summary>
        /// <value>planet_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlanetTypeEnum
        {
            
            /// <summary>
            /// Enum Temperate for "temperate"
            /// </summary>
            [EnumMember(Value = "temperate")]
            Temperate,
            
            /// <summary>
            /// Enum Barren for "barren"
            /// </summary>
            [EnumMember(Value = "barren")]
            Barren,
            
            /// <summary>
            /// Enum Oceanic for "oceanic"
            /// </summary>
            [EnumMember(Value = "oceanic")]
            Oceanic,
            
            /// <summary>
            /// Enum Ice for "ice"
            /// </summary>
            [EnumMember(Value = "ice")]
            Ice,
            
            /// <summary>
            /// Enum Gas for "gas"
            /// </summary>
            [EnumMember(Value = "gas")]
            Gas,
            
            /// <summary>
            /// Enum Lava for "lava"
            /// </summary>
            [EnumMember(Value = "lava")]
            Lava,
            
            /// <summary>
            /// Enum Storm for "storm"
            /// </summary>
            [EnumMember(Value = "storm")]
            Storm,
            
            /// <summary>
            /// Enum Plasma for "plasma"
            /// </summary>
            [EnumMember(Value = "plasma")]
            Plasma
        }

        /// <summary>
        /// planet_type string
        /// </summary>
        /// <value>planet_type string</value>
        [DataMember(Name="planet_type", EmitDefaultValue=false)]
        public PlanetTypeEnum? PlanetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanets200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdPlanets200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanets200Ok" /> class.
        /// </summary>
        /// <param name="LastUpdate">last_update string (required).</param>
        /// <param name="NumPins">num_pins integer (required).</param>
        /// <param name="OwnerId">owner_id integer (required).</param>
        /// <param name="PlanetId">planet_id integer (required).</param>
        /// <param name="PlanetType">planet_type string (required).</param>
        /// <param name="SolarSystemId">solar_system_id integer (required).</param>
        /// <param name="UpgradeLevel">upgrade_level integer (required).</param>
        public GetCharactersCharacterIdPlanets200Ok(DateTime? LastUpdate = default(DateTime?), int? NumPins = default(int?), int? OwnerId = default(int?), int? PlanetId = default(int?), PlanetTypeEnum? PlanetType = default(PlanetTypeEnum?), int? SolarSystemId = default(int?), int? UpgradeLevel = default(int?))
        {
            // to ensure "LastUpdate" is required (not null)
            if (LastUpdate == null)
            {
                throw new InvalidDataException("LastUpdate is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.LastUpdate = LastUpdate;
            }
            // to ensure "NumPins" is required (not null)
            if (NumPins == null)
            {
                throw new InvalidDataException("NumPins is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.NumPins = NumPins;
            }
            // to ensure "OwnerId" is required (not null)
            if (OwnerId == null)
            {
                throw new InvalidDataException("OwnerId is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.OwnerId = OwnerId;
            }
            // to ensure "PlanetId" is required (not null)
            if (PlanetId == null)
            {
                throw new InvalidDataException("PlanetId is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.PlanetId = PlanetId;
            }
            // to ensure "PlanetType" is required (not null)
            if (PlanetType == null)
            {
                throw new InvalidDataException("PlanetType is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.PlanetType = PlanetType;
            }
            // to ensure "SolarSystemId" is required (not null)
            if (SolarSystemId == null)
            {
                throw new InvalidDataException("SolarSystemId is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = SolarSystemId;
            }
            // to ensure "UpgradeLevel" is required (not null)
            if (UpgradeLevel == null)
            {
                throw new InvalidDataException("UpgradeLevel is a required property for GetCharactersCharacterIdPlanets200Ok and cannot be null");
            }
            else
            {
                this.UpgradeLevel = UpgradeLevel;
            }
        }
        
        /// <summary>
        /// last_update string
        /// </summary>
        /// <value>last_update string</value>
        [DataMember(Name="last_update", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }
        /// <summary>
        /// num_pins integer
        /// </summary>
        /// <value>num_pins integer</value>
        [DataMember(Name="num_pins", EmitDefaultValue=false)]
        public int? NumPins { get; set; }
        /// <summary>
        /// owner_id integer
        /// </summary>
        /// <value>owner_id integer</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }
        /// <summary>
        /// planet_id integer
        /// </summary>
        /// <value>planet_id integer</value>
        [DataMember(Name="planet_id", EmitDefaultValue=false)]
        public int? PlanetId { get; set; }
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }
        /// <summary>
        /// upgrade_level integer
        /// </summary>
        /// <value>upgrade_level integer</value>
        [DataMember(Name="upgrade_level", EmitDefaultValue=false)]
        public int? UpgradeLevel { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanets200Ok {\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  NumPins: ").Append(NumPins).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
            sb.Append("  PlanetType: ").Append(PlanetType).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  UpgradeLevel: ").Append(UpgradeLevel).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdPlanets200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanets200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdPlanets200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanets200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastUpdate == other.LastUpdate ||
                    this.LastUpdate != null &&
                    this.LastUpdate.Equals(other.LastUpdate)
                ) && 
                (
                    this.NumPins == other.NumPins ||
                    this.NumPins != null &&
                    this.NumPins.Equals(other.NumPins)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.PlanetId == other.PlanetId ||
                    this.PlanetId != null &&
                    this.PlanetId.Equals(other.PlanetId)
                ) && 
                (
                    this.PlanetType == other.PlanetType ||
                    this.PlanetType != null &&
                    this.PlanetType.Equals(other.PlanetType)
                ) && 
                (
                    this.SolarSystemId == other.SolarSystemId ||
                    this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(other.SolarSystemId)
                ) && 
                (
                    this.UpgradeLevel == other.UpgradeLevel ||
                    this.UpgradeLevel != null &&
                    this.UpgradeLevel.Equals(other.UpgradeLevel)
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
                if (this.LastUpdate != null)
                    hash = hash * 59 + this.LastUpdate.GetHashCode();
                if (this.NumPins != null)
                    hash = hash * 59 + this.NumPins.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.PlanetId != null)
                    hash = hash * 59 + this.PlanetId.GetHashCode();
                if (this.PlanetType != null)
                    hash = hash * 59 + this.PlanetType.GetHashCode();
                if (this.SolarSystemId != null)
                    hash = hash * 59 + this.SolarSystemId.GetHashCode();
                if (this.UpgradeLevel != null)
                    hash = hash * 59 + this.UpgradeLevel.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // NumPins (int?) minimum
            if(this.NumPins < (int?)1)
            {
                yield return new ValidationResult("Invalid value for NumPins, must be a value greater than or equal to 1.", new [] { "NumPins" });
            }

            // UpgradeLevel (int?) maximum
            if(this.UpgradeLevel > (int?)5)
            {
                yield return new ValidationResult("Invalid value for UpgradeLevel, must be a value less than or equal to 5.", new [] { "UpgradeLevel" });
            }

            // UpgradeLevel (int?) minimum
            if(this.UpgradeLevel < (int?)0)
            {
                yield return new ValidationResult("Invalid value for UpgradeLevel, must be a value greater than or equal to 0.", new [] { "UpgradeLevel" });
            }

            yield break;
        }
    }

}
