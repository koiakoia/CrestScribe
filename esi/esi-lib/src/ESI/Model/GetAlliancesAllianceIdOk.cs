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
    public partial class GetAlliancesAllianceIdOk :  IEquatable<GetAlliancesAllianceIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlliancesAllianceIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAlliancesAllianceIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlliancesAllianceIdOk" /> class.
        /// </summary>
        /// <param name="AllianceName">the full name of the alliance (required).</param>
        /// <param name="DateFounded">date_founded string (required).</param>
        /// <param name="ExecutorCorporationId">the executor corporation ID, if this alliance is not closed.</param>
        /// <param name="Ticker">the short name of the alliance (required).</param>
        public GetAlliancesAllianceIdOk(string AllianceName = default(string), DateTime? DateFounded = default(DateTime?), int? ExecutorCorporationId = default(int?), string Ticker = default(string))
        {
            // to ensure "AllianceName" is required (not null)
            if (AllianceName == null)
            {
                throw new InvalidDataException("AllianceName is a required property for GetAlliancesAllianceIdOk and cannot be null");
            }
            else
            {
                this.AllianceName = AllianceName;
            }
            // to ensure "DateFounded" is required (not null)
            if (DateFounded == null)
            {
                throw new InvalidDataException("DateFounded is a required property for GetAlliancesAllianceIdOk and cannot be null");
            }
            else
            {
                this.DateFounded = DateFounded;
            }
            // to ensure "Ticker" is required (not null)
            if (Ticker == null)
            {
                throw new InvalidDataException("Ticker is a required property for GetAlliancesAllianceIdOk and cannot be null");
            }
            else
            {
                this.Ticker = Ticker;
            }
            this.ExecutorCorporationId = ExecutorCorporationId;
        }
        
        /// <summary>
        /// the full name of the alliance
        /// </summary>
        /// <value>the full name of the alliance</value>
        [DataMember(Name="alliance_name", EmitDefaultValue=false)]
        public string AllianceName { get; set; }
        /// <summary>
        /// date_founded string
        /// </summary>
        /// <value>date_founded string</value>
        [DataMember(Name="date_founded", EmitDefaultValue=false)]
        public DateTime? DateFounded { get; set; }
        /// <summary>
        /// the executor corporation ID, if this alliance is not closed
        /// </summary>
        /// <value>the executor corporation ID, if this alliance is not closed</value>
        [DataMember(Name="executor_corporation_id", EmitDefaultValue=false)]
        public int? ExecutorCorporationId { get; set; }
        /// <summary>
        /// the short name of the alliance
        /// </summary>
        /// <value>the short name of the alliance</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAlliancesAllianceIdOk {\n");
            sb.Append("  AllianceName: ").Append(AllianceName).Append("\n");
            sb.Append("  DateFounded: ").Append(DateFounded).Append("\n");
            sb.Append("  ExecutorCorporationId: ").Append(ExecutorCorporationId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
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
            return this.Equals(obj as GetAlliancesAllianceIdOk);
        }

        /// <summary>
        /// Returns true if GetAlliancesAllianceIdOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetAlliancesAllianceIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAlliancesAllianceIdOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllianceName == other.AllianceName ||
                    this.AllianceName != null &&
                    this.AllianceName.Equals(other.AllianceName)
                ) && 
                (
                    this.DateFounded == other.DateFounded ||
                    this.DateFounded != null &&
                    this.DateFounded.Equals(other.DateFounded)
                ) && 
                (
                    this.ExecutorCorporationId == other.ExecutorCorporationId ||
                    this.ExecutorCorporationId != null &&
                    this.ExecutorCorporationId.Equals(other.ExecutorCorporationId)
                ) && 
                (
                    this.Ticker == other.Ticker ||
                    this.Ticker != null &&
                    this.Ticker.Equals(other.Ticker)
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
                if (this.AllianceName != null)
                    hash = hash * 59 + this.AllianceName.GetHashCode();
                if (this.DateFounded != null)
                    hash = hash * 59 + this.DateFounded.GetHashCode();
                if (this.ExecutorCorporationId != null)
                    hash = hash * 59 + this.ExecutorCorporationId.GetHashCode();
                if (this.Ticker != null)
                    hash = hash * 59 + this.Ticker.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
