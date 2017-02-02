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
    public partial class GetWarsWarIdKillmails200Ok :  IEquatable<GetWarsWarIdKillmails200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdKillmails200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWarsWarIdKillmails200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdKillmails200Ok" /> class.
        /// </summary>
        /// <param name="KillmailHash">A hash of this killmail (required).</param>
        /// <param name="KillmailId">ID of this killmail (required).</param>
        public GetWarsWarIdKillmails200Ok(string KillmailHash = default(string), int? KillmailId = default(int?))
        {
            // to ensure "KillmailHash" is required (not null)
            if (KillmailHash == null)
            {
                throw new InvalidDataException("KillmailHash is a required property for GetWarsWarIdKillmails200Ok and cannot be null");
            }
            else
            {
                this.KillmailHash = KillmailHash;
            }
            // to ensure "KillmailId" is required (not null)
            if (KillmailId == null)
            {
                throw new InvalidDataException("KillmailId is a required property for GetWarsWarIdKillmails200Ok and cannot be null");
            }
            else
            {
                this.KillmailId = KillmailId;
            }
        }
        
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        /// <value>A hash of this killmail</value>
        [DataMember(Name="killmail_hash", EmitDefaultValue=false)]
        public string KillmailHash { get; set; }
        /// <summary>
        /// ID of this killmail
        /// </summary>
        /// <value>ID of this killmail</value>
        [DataMember(Name="killmail_id", EmitDefaultValue=false)]
        public int? KillmailId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWarsWarIdKillmails200Ok {\n");
            sb.Append("  KillmailHash: ").Append(KillmailHash).Append("\n");
            sb.Append("  KillmailId: ").Append(KillmailId).Append("\n");
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
            return this.Equals(obj as GetWarsWarIdKillmails200Ok);
        }

        /// <summary>
        /// Returns true if GetWarsWarIdKillmails200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetWarsWarIdKillmails200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWarsWarIdKillmails200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.KillmailHash == other.KillmailHash ||
                    this.KillmailHash != null &&
                    this.KillmailHash.Equals(other.KillmailHash)
                ) && 
                (
                    this.KillmailId == other.KillmailId ||
                    this.KillmailId != null &&
                    this.KillmailId.Equals(other.KillmailId)
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
                if (this.KillmailHash != null)
                    hash = hash * 59 + this.KillmailHash.GetHashCode();
                if (this.KillmailId != null)
                    hash = hash * 59 + this.KillmailId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
