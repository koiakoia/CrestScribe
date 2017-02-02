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
    public partial class GetCharactersCharacterIdBookmarks200Ok :  IEquatable<GetCharactersCharacterIdBookmarks200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarks200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdBookmarks200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarks200Ok" /> class.
        /// </summary>
        /// <param name="BookmarkId">bookmark_id integer (required).</param>
        /// <param name="CreateDate">create_date string (required).</param>
        /// <param name="CreatorId">creator_id integer (required).</param>
        /// <param name="FolderId">folder_id integer.</param>
        /// <param name="Memo">memo string (required).</param>
        /// <param name="Note">note string (required).</param>
        /// <param name="OwnerId">owner_id integer (required).</param>
        /// <param name="Target">Target.</param>
        public GetCharactersCharacterIdBookmarks200Ok(long? BookmarkId = default(long?), DateTime? CreateDate = default(DateTime?), int? CreatorId = default(int?), int? FolderId = default(int?), string Memo = default(string), string Note = default(string), int? OwnerId = default(int?), GetCharactersCharacterIdBookmarksTarget Target = default(GetCharactersCharacterIdBookmarksTarget))
        {
            // to ensure "BookmarkId" is required (not null)
            if (BookmarkId == null)
            {
                throw new InvalidDataException("BookmarkId is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.BookmarkId = BookmarkId;
            }
            // to ensure "CreateDate" is required (not null)
            if (CreateDate == null)
            {
                throw new InvalidDataException("CreateDate is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.CreateDate = CreateDate;
            }
            // to ensure "CreatorId" is required (not null)
            if (CreatorId == null)
            {
                throw new InvalidDataException("CreatorId is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.CreatorId = CreatorId;
            }
            // to ensure "Memo" is required (not null)
            if (Memo == null)
            {
                throw new InvalidDataException("Memo is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.Memo = Memo;
            }
            // to ensure "Note" is required (not null)
            if (Note == null)
            {
                throw new InvalidDataException("Note is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.Note = Note;
            }
            // to ensure "OwnerId" is required (not null)
            if (OwnerId == null)
            {
                throw new InvalidDataException("OwnerId is a required property for GetCharactersCharacterIdBookmarks200Ok and cannot be null");
            }
            else
            {
                this.OwnerId = OwnerId;
            }
            this.FolderId = FolderId;
            this.Target = Target;
        }
        
        /// <summary>
        /// bookmark_id integer
        /// </summary>
        /// <value>bookmark_id integer</value>
        [DataMember(Name="bookmark_id", EmitDefaultValue=false)]
        public long? BookmarkId { get; set; }
        /// <summary>
        /// create_date string
        /// </summary>
        /// <value>create_date string</value>
        [DataMember(Name="create_date", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// creator_id integer
        /// </summary>
        /// <value>creator_id integer</value>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public int? CreatorId { get; set; }
        /// <summary>
        /// folder_id integer
        /// </summary>
        /// <value>folder_id integer</value>
        [DataMember(Name="folder_id", EmitDefaultValue=false)]
        public int? FolderId { get; set; }
        /// <summary>
        /// memo string
        /// </summary>
        /// <value>memo string</value>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }
        /// <summary>
        /// note string
        /// </summary>
        /// <value>note string</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// owner_id integer
        /// </summary>
        /// <value>owner_id integer</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public GetCharactersCharacterIdBookmarksTarget Target { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdBookmarks200Ok {\n");
            sb.Append("  BookmarkId: ").Append(BookmarkId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdBookmarks200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdBookmarks200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdBookmarks200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdBookmarks200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BookmarkId == other.BookmarkId ||
                    this.BookmarkId != null &&
                    this.BookmarkId.Equals(other.BookmarkId)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.CreatorId == other.CreatorId ||
                    this.CreatorId != null &&
                    this.CreatorId.Equals(other.CreatorId)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.Memo == other.Memo ||
                    this.Memo != null &&
                    this.Memo.Equals(other.Memo)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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
                if (this.BookmarkId != null)
                    hash = hash * 59 + this.BookmarkId.GetHashCode();
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                if (this.CreatorId != null)
                    hash = hash * 59 + this.CreatorId.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.Memo != null)
                    hash = hash * 59 + this.Memo.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
