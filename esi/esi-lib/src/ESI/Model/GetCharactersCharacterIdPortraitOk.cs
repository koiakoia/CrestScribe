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
    public partial class GetCharactersCharacterIdPortraitOk :  IEquatable<GetCharactersCharacterIdPortraitOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPortraitOk" /> class.
        /// </summary>
        /// <param name="Px128x128">px128x128 string.</param>
        /// <param name="Px256x256">px256x256 string.</param>
        /// <param name="Px512x512">px512x512 string.</param>
        /// <param name="Px64x64">px64x64 string.</param>
        public GetCharactersCharacterIdPortraitOk(string Px128x128 = default(string), string Px256x256 = default(string), string Px512x512 = default(string), string Px64x64 = default(string))
        {
            this.Px128x128 = Px128x128;
            this.Px256x256 = Px256x256;
            this.Px512x512 = Px512x512;
            this.Px64x64 = Px64x64;
        }
        
        /// <summary>
        /// px128x128 string
        /// </summary>
        /// <value>px128x128 string</value>
        [DataMember(Name="px128x128", EmitDefaultValue=false)]
        public string Px128x128 { get; set; }
        /// <summary>
        /// px256x256 string
        /// </summary>
        /// <value>px256x256 string</value>
        [DataMember(Name="px256x256", EmitDefaultValue=false)]
        public string Px256x256 { get; set; }
        /// <summary>
        /// px512x512 string
        /// </summary>
        /// <value>px512x512 string</value>
        [DataMember(Name="px512x512", EmitDefaultValue=false)]
        public string Px512x512 { get; set; }
        /// <summary>
        /// px64x64 string
        /// </summary>
        /// <value>px64x64 string</value>
        [DataMember(Name="px64x64", EmitDefaultValue=false)]
        public string Px64x64 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPortraitOk {\n");
            sb.Append("  Px128x128: ").Append(Px128x128).Append("\n");
            sb.Append("  Px256x256: ").Append(Px256x256).Append("\n");
            sb.Append("  Px512x512: ").Append(Px512x512).Append("\n");
            sb.Append("  Px64x64: ").Append(Px64x64).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdPortraitOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPortraitOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdPortraitOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPortraitOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Px128x128 == other.Px128x128 ||
                    this.Px128x128 != null &&
                    this.Px128x128.Equals(other.Px128x128)
                ) && 
                (
                    this.Px256x256 == other.Px256x256 ||
                    this.Px256x256 != null &&
                    this.Px256x256.Equals(other.Px256x256)
                ) && 
                (
                    this.Px512x512 == other.Px512x512 ||
                    this.Px512x512 != null &&
                    this.Px512x512.Equals(other.Px512x512)
                ) && 
                (
                    this.Px64x64 == other.Px64x64 ||
                    this.Px64x64 != null &&
                    this.Px64x64.Equals(other.Px64x64)
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
                if (this.Px128x128 != null)
                    hash = hash * 59 + this.Px128x128.GetHashCode();
                if (this.Px256x256 != null)
                    hash = hash * 59 + this.Px256x256.GetHashCode();
                if (this.Px512x512 != null)
                    hash = hash * 59 + this.Px512x512.GetHashCode();
                if (this.Px64x64 != null)
                    hash = hash * 59 + this.Px64x64.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
