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
    /// route object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdPlanetsPlanetIdRoute :  IEquatable<GetCharactersCharacterIdPlanetsPlanetIdRoute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdRoute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdPlanetsPlanetIdRoute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdRoute" /> class.
        /// </summary>
        /// <param name="ContentTypeId">content_type_id integer (required).</param>
        /// <param name="DestinationPinId">destination_pin_id integer (required).</param>
        /// <param name="Quantity">quantity integer (required).</param>
        /// <param name="RouteId">route_id integer (required).</param>
        /// <param name="SourcePinId">source_pin_id integer (required).</param>
        /// <param name="Waypoints">waypoints array.</param>
        public GetCharactersCharacterIdPlanetsPlanetIdRoute(int? ContentTypeId = default(int?), long? DestinationPinId = default(long?), long? Quantity = default(long?), long? RouteId = default(long?), long? SourcePinId = default(long?), List<GetCharactersCharacterIdPlanetsPlanetIdWaypoint> Waypoints = default(List<GetCharactersCharacterIdPlanetsPlanetIdWaypoint>))
        {
            // to ensure "ContentTypeId" is required (not null)
            if (ContentTypeId == null)
            {
                throw new InvalidDataException("ContentTypeId is a required property for GetCharactersCharacterIdPlanetsPlanetIdRoute and cannot be null");
            }
            else
            {
                this.ContentTypeId = ContentTypeId;
            }
            // to ensure "DestinationPinId" is required (not null)
            if (DestinationPinId == null)
            {
                throw new InvalidDataException("DestinationPinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdRoute and cannot be null");
            }
            else
            {
                this.DestinationPinId = DestinationPinId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for GetCharactersCharacterIdPlanetsPlanetIdRoute and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "RouteId" is required (not null)
            if (RouteId == null)
            {
                throw new InvalidDataException("RouteId is a required property for GetCharactersCharacterIdPlanetsPlanetIdRoute and cannot be null");
            }
            else
            {
                this.RouteId = RouteId;
            }
            // to ensure "SourcePinId" is required (not null)
            if (SourcePinId == null)
            {
                throw new InvalidDataException("SourcePinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdRoute and cannot be null");
            }
            else
            {
                this.SourcePinId = SourcePinId;
            }
            this.Waypoints = Waypoints;
        }
        
        /// <summary>
        /// content_type_id integer
        /// </summary>
        /// <value>content_type_id integer</value>
        [DataMember(Name="content_type_id", EmitDefaultValue=false)]
        public int? ContentTypeId { get; set; }
        /// <summary>
        /// destination_pin_id integer
        /// </summary>
        /// <value>destination_pin_id integer</value>
        [DataMember(Name="destination_pin_id", EmitDefaultValue=false)]
        public long? DestinationPinId { get; set; }
        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }
        /// <summary>
        /// route_id integer
        /// </summary>
        /// <value>route_id integer</value>
        [DataMember(Name="route_id", EmitDefaultValue=false)]
        public long? RouteId { get; set; }
        /// <summary>
        /// source_pin_id integer
        /// </summary>
        /// <value>source_pin_id integer</value>
        [DataMember(Name="source_pin_id", EmitDefaultValue=false)]
        public long? SourcePinId { get; set; }
        /// <summary>
        /// waypoints array
        /// </summary>
        /// <value>waypoints array</value>
        [DataMember(Name="waypoints", EmitDefaultValue=false)]
        public List<GetCharactersCharacterIdPlanetsPlanetIdWaypoint> Waypoints { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdRoute {\n");
            sb.Append("  ContentTypeId: ").Append(ContentTypeId).Append("\n");
            sb.Append("  DestinationPinId: ").Append(DestinationPinId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RouteId: ").Append(RouteId).Append("\n");
            sb.Append("  SourcePinId: ").Append(SourcePinId).Append("\n");
            sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdPlanetsPlanetIdRoute);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanetsPlanetIdRoute instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdPlanetsPlanetIdRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanetsPlanetIdRoute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContentTypeId == other.ContentTypeId ||
                    this.ContentTypeId != null &&
                    this.ContentTypeId.Equals(other.ContentTypeId)
                ) && 
                (
                    this.DestinationPinId == other.DestinationPinId ||
                    this.DestinationPinId != null &&
                    this.DestinationPinId.Equals(other.DestinationPinId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.RouteId == other.RouteId ||
                    this.RouteId != null &&
                    this.RouteId.Equals(other.RouteId)
                ) && 
                (
                    this.SourcePinId == other.SourcePinId ||
                    this.SourcePinId != null &&
                    this.SourcePinId.Equals(other.SourcePinId)
                ) && 
                (
                    this.Waypoints == other.Waypoints ||
                    this.Waypoints != null &&
                    this.Waypoints.SequenceEqual(other.Waypoints)
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
                if (this.ContentTypeId != null)
                    hash = hash * 59 + this.ContentTypeId.GetHashCode();
                if (this.DestinationPinId != null)
                    hash = hash * 59 + this.DestinationPinId.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.RouteId != null)
                    hash = hash * 59 + this.RouteId.GetHashCode();
                if (this.SourcePinId != null)
                    hash = hash * 59 + this.SourcePinId.GetHashCode();
                if (this.Waypoints != null)
                    hash = hash * 59 + this.Waypoints.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
