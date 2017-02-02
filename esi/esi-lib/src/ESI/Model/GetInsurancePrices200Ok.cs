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
    public partial class GetInsurancePrices200Ok :  IEquatable<GetInsurancePrices200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInsurancePrices200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetInsurancePrices200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInsurancePrices200Ok" /> class.
        /// </summary>
        /// <param name="Levels">A list of a available insurance levels for this ship type (required).</param>
        /// <param name="TypeId">type_id integer (required).</param>
        public GetInsurancePrices200Ok(List<GetInsurancePricesLevel> Levels = default(List<GetInsurancePricesLevel>), int? TypeId = default(int?))
        {
            // to ensure "Levels" is required (not null)
            if (Levels == null)
            {
                throw new InvalidDataException("Levels is a required property for GetInsurancePrices200Ok and cannot be null");
            }
            else
            {
                this.Levels = Levels;
            }
            // to ensure "TypeId" is required (not null)
            if (TypeId == null)
            {
                throw new InvalidDataException("TypeId is a required property for GetInsurancePrices200Ok and cannot be null");
            }
            else
            {
                this.TypeId = TypeId;
            }
        }
        
        /// <summary>
        /// A list of a available insurance levels for this ship type
        /// </summary>
        /// <value>A list of a available insurance levels for this ship type</value>
        [DataMember(Name="levels", EmitDefaultValue=false)]
        public List<GetInsurancePricesLevel> Levels { get; set; }
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
            sb.Append("class GetInsurancePrices200Ok {\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
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
            return this.Equals(obj as GetInsurancePrices200Ok);
        }

        /// <summary>
        /// Returns true if GetInsurancePrices200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetInsurancePrices200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInsurancePrices200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Levels == other.Levels ||
                    this.Levels != null &&
                    this.Levels.SequenceEqual(other.Levels)
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
                if (this.Levels != null)
                    hash = hash * 59 + this.Levels.GetHashCode();
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
