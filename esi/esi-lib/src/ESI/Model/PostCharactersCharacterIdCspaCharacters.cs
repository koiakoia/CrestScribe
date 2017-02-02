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
    /// characters schema
    /// </summary>
    [DataContract]
    public partial class PostCharactersCharacterIdCspaCharacters :  IEquatable<PostCharactersCharacterIdCspaCharacters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdCspaCharacters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersCharacterIdCspaCharacters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdCspaCharacters" /> class.
        /// </summary>
        /// <param name="Characters">characters array (required).</param>
        public PostCharactersCharacterIdCspaCharacters(List<int?> Characters = default(List<int?>))
        {
            // to ensure "Characters" is required (not null)
            if (Characters == null)
            {
                throw new InvalidDataException("Characters is a required property for PostCharactersCharacterIdCspaCharacters and cannot be null");
            }
            else
            {
                this.Characters = Characters;
            }
        }
        
        /// <summary>
        /// characters array
        /// </summary>
        /// <value>characters array</value>
        [DataMember(Name="characters", EmitDefaultValue=false)]
        public List<int?> Characters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCharactersCharacterIdCspaCharacters {\n");
            sb.Append("  Characters: ").Append(Characters).Append("\n");
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
            return this.Equals(obj as PostCharactersCharacterIdCspaCharacters);
        }

        /// <summary>
        /// Returns true if PostCharactersCharacterIdCspaCharacters instances are equal
        /// </summary>
        /// <param name="other">Instance of PostCharactersCharacterIdCspaCharacters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersCharacterIdCspaCharacters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Characters == other.Characters ||
                    this.Characters != null &&
                    this.Characters.SequenceEqual(other.Characters)
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
                if (this.Characters != null)
                    hash = hash * 59 + this.Characters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
