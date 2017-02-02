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
    /// Coordinates of the victim in Cartesian space relative to the Sun 
    /// </summary>
    [DataContract]
    public partial class GetKillmailsKillmailIdKillmailHashPosition :  IEquatable<GetKillmailsKillmailIdKillmailHashPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetKillmailsKillmailIdKillmailHashPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetKillmailsKillmailIdKillmailHashPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetKillmailsKillmailIdKillmailHashPosition" /> class.
        /// </summary>
        /// <param name="X">x number (required).</param>
        /// <param name="Y">y number (required).</param>
        /// <param name="Z">z number (required).</param>
        public GetKillmailsKillmailIdKillmailHashPosition(float? X = default(float?), float? Y = default(float?), float? Z = default(float?))
        {
            // to ensure "X" is required (not null)
            if (X == null)
            {
                throw new InvalidDataException("X is a required property for GetKillmailsKillmailIdKillmailHashPosition and cannot be null");
            }
            else
            {
                this.X = X;
            }
            // to ensure "Y" is required (not null)
            if (Y == null)
            {
                throw new InvalidDataException("Y is a required property for GetKillmailsKillmailIdKillmailHashPosition and cannot be null");
            }
            else
            {
                this.Y = Y;
            }
            // to ensure "Z" is required (not null)
            if (Z == null)
            {
                throw new InvalidDataException("Z is a required property for GetKillmailsKillmailIdKillmailHashPosition and cannot be null");
            }
            else
            {
                this.Z = Z;
            }
        }
        
        /// <summary>
        /// x number
        /// </summary>
        /// <value>x number</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public float? X { get; set; }
        /// <summary>
        /// y number
        /// </summary>
        /// <value>y number</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public float? Y { get; set; }
        /// <summary>
        /// z number
        /// </summary>
        /// <value>z number</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public float? Z { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetKillmailsKillmailIdKillmailHashPosition {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(obj as GetKillmailsKillmailIdKillmailHashPosition);
        }

        /// <summary>
        /// Returns true if GetKillmailsKillmailIdKillmailHashPosition instances are equal
        /// </summary>
        /// <param name="other">Instance of GetKillmailsKillmailIdKillmailHashPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetKillmailsKillmailIdKillmailHashPosition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                ) && 
                (
                    this.Z == other.Z ||
                    this.Z != null &&
                    this.Z.Equals(other.Z)
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
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                if (this.Z != null)
                    hash = hash * 59 + this.Z.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
