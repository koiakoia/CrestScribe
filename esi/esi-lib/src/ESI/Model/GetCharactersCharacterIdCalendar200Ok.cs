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
    /// event
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdCalendar200Ok :  IEquatable<GetCharactersCharacterIdCalendar200Ok>, IValidatableObject
    {
        /// <summary>
        /// event_response string
        /// </summary>
        /// <value>event_response string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventResponseEnum
        {
            
            /// <summary>
            /// Enum Declined for "declined"
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined,
            
            /// <summary>
            /// Enum Notresponded for "not_responded"
            /// </summary>
            [EnumMember(Value = "not_responded")]
            Notresponded,
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Tentative for "tentative"
            /// </summary>
            [EnumMember(Value = "tentative")]
            Tentative
        }

        /// <summary>
        /// event_response string
        /// </summary>
        /// <value>event_response string</value>
        [DataMember(Name="event_response", EmitDefaultValue=false)]
        public EventResponseEnum? EventResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdCalendar200Ok" /> class.
        /// </summary>
        /// <param name="EventDate">event_date string.</param>
        /// <param name="EventId">event_id integer.</param>
        /// <param name="EventResponse">event_response string.</param>
        /// <param name="Importance">importance integer.</param>
        /// <param name="Title">title string.</param>
        public GetCharactersCharacterIdCalendar200Ok(DateTime? EventDate = default(DateTime?), int? EventId = default(int?), EventResponseEnum? EventResponse = default(EventResponseEnum?), int? Importance = default(int?), string Title = default(string))
        {
            this.EventDate = EventDate;
            this.EventId = EventId;
            this.EventResponse = EventResponse;
            this.Importance = Importance;
            this.Title = Title;
        }
        
        /// <summary>
        /// event_date string
        /// </summary>
        /// <value>event_date string</value>
        [DataMember(Name="event_date", EmitDefaultValue=false)]
        public DateTime? EventDate { get; set; }
        /// <summary>
        /// event_id integer
        /// </summary>
        /// <value>event_id integer</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public int? EventId { get; set; }
        /// <summary>
        /// importance integer
        /// </summary>
        /// <value>importance integer</value>
        [DataMember(Name="importance", EmitDefaultValue=false)]
        public int? Importance { get; set; }
        /// <summary>
        /// title string
        /// </summary>
        /// <value>title string</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdCalendar200Ok {\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventResponse: ").Append(EventResponse).Append("\n");
            sb.Append("  Importance: ").Append(Importance).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdCalendar200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdCalendar200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdCalendar200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdCalendar200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) && 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.EventResponse == other.EventResponse ||
                    this.EventResponse != null &&
                    this.EventResponse.Equals(other.EventResponse)
                ) && 
                (
                    this.Importance == other.Importance ||
                    this.Importance != null &&
                    this.Importance.Equals(other.Importance)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                if (this.EventResponse != null)
                    hash = hash * 59 + this.EventResponse.GetHashCode();
                if (this.Importance != null)
                    hash = hash * 59 + this.Importance.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
