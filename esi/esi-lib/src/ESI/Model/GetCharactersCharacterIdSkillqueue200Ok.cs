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
    public partial class GetCharactersCharacterIdSkillqueue200Ok :  IEquatable<GetCharactersCharacterIdSkillqueue200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdSkillqueue200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdSkillqueue200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdSkillqueue200Ok" /> class.
        /// </summary>
        /// <param name="FinishDate">finish_date string.</param>
        /// <param name="FinishedLevel">finished_level integer (required).</param>
        /// <param name="LevelEndSp">level_end_sp integer.</param>
        /// <param name="LevelStartSp">Amount of SP that was in the skill when it started training it&#39;s current level. Used to calculate % of current level complete..</param>
        /// <param name="QueuePosition">queue_position integer (required).</param>
        /// <param name="SkillId">skill_id integer (required).</param>
        /// <param name="StartDate">start_date string.</param>
        /// <param name="TrainingStartSp">training_start_sp integer.</param>
        public GetCharactersCharacterIdSkillqueue200Ok(DateTime? FinishDate = default(DateTime?), int? FinishedLevel = default(int?), int? LevelEndSp = default(int?), int? LevelStartSp = default(int?), int? QueuePosition = default(int?), int? SkillId = default(int?), DateTime? StartDate = default(DateTime?), int? TrainingStartSp = default(int?))
        {
            // to ensure "FinishedLevel" is required (not null)
            if (FinishedLevel == null)
            {
                throw new InvalidDataException("FinishedLevel is a required property for GetCharactersCharacterIdSkillqueue200Ok and cannot be null");
            }
            else
            {
                this.FinishedLevel = FinishedLevel;
            }
            // to ensure "QueuePosition" is required (not null)
            if (QueuePosition == null)
            {
                throw new InvalidDataException("QueuePosition is a required property for GetCharactersCharacterIdSkillqueue200Ok and cannot be null");
            }
            else
            {
                this.QueuePosition = QueuePosition;
            }
            // to ensure "SkillId" is required (not null)
            if (SkillId == null)
            {
                throw new InvalidDataException("SkillId is a required property for GetCharactersCharacterIdSkillqueue200Ok and cannot be null");
            }
            else
            {
                this.SkillId = SkillId;
            }
            this.FinishDate = FinishDate;
            this.LevelEndSp = LevelEndSp;
            this.LevelStartSp = LevelStartSp;
            this.StartDate = StartDate;
            this.TrainingStartSp = TrainingStartSp;
        }
        
        /// <summary>
        /// finish_date string
        /// </summary>
        /// <value>finish_date string</value>
        [DataMember(Name="finish_date", EmitDefaultValue=false)]
        public DateTime? FinishDate { get; set; }
        /// <summary>
        /// finished_level integer
        /// </summary>
        /// <value>finished_level integer</value>
        [DataMember(Name="finished_level", EmitDefaultValue=false)]
        public int? FinishedLevel { get; set; }
        /// <summary>
        /// level_end_sp integer
        /// </summary>
        /// <value>level_end_sp integer</value>
        [DataMember(Name="level_end_sp", EmitDefaultValue=false)]
        public int? LevelEndSp { get; set; }
        /// <summary>
        /// Amount of SP that was in the skill when it started training it&#39;s current level. Used to calculate % of current level complete.
        /// </summary>
        /// <value>Amount of SP that was in the skill when it started training it&#39;s current level. Used to calculate % of current level complete.</value>
        [DataMember(Name="level_start_sp", EmitDefaultValue=false)]
        public int? LevelStartSp { get; set; }
        /// <summary>
        /// queue_position integer
        /// </summary>
        /// <value>queue_position integer</value>
        [DataMember(Name="queue_position", EmitDefaultValue=false)]
        public int? QueuePosition { get; set; }
        /// <summary>
        /// skill_id integer
        /// </summary>
        /// <value>skill_id integer</value>
        [DataMember(Name="skill_id", EmitDefaultValue=false)]
        public int? SkillId { get; set; }
        /// <summary>
        /// start_date string
        /// </summary>
        /// <value>start_date string</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// training_start_sp integer
        /// </summary>
        /// <value>training_start_sp integer</value>
        [DataMember(Name="training_start_sp", EmitDefaultValue=false)]
        public int? TrainingStartSp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdSkillqueue200Ok {\n");
            sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  FinishedLevel: ").Append(FinishedLevel).Append("\n");
            sb.Append("  LevelEndSp: ").Append(LevelEndSp).Append("\n");
            sb.Append("  LevelStartSp: ").Append(LevelStartSp).Append("\n");
            sb.Append("  QueuePosition: ").Append(QueuePosition).Append("\n");
            sb.Append("  SkillId: ").Append(SkillId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TrainingStartSp: ").Append(TrainingStartSp).Append("\n");
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
            return this.Equals(obj as GetCharactersCharacterIdSkillqueue200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdSkillqueue200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCharactersCharacterIdSkillqueue200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdSkillqueue200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FinishDate == other.FinishDate ||
                    this.FinishDate != null &&
                    this.FinishDate.Equals(other.FinishDate)
                ) && 
                (
                    this.FinishedLevel == other.FinishedLevel ||
                    this.FinishedLevel != null &&
                    this.FinishedLevel.Equals(other.FinishedLevel)
                ) && 
                (
                    this.LevelEndSp == other.LevelEndSp ||
                    this.LevelEndSp != null &&
                    this.LevelEndSp.Equals(other.LevelEndSp)
                ) && 
                (
                    this.LevelStartSp == other.LevelStartSp ||
                    this.LevelStartSp != null &&
                    this.LevelStartSp.Equals(other.LevelStartSp)
                ) && 
                (
                    this.QueuePosition == other.QueuePosition ||
                    this.QueuePosition != null &&
                    this.QueuePosition.Equals(other.QueuePosition)
                ) && 
                (
                    this.SkillId == other.SkillId ||
                    this.SkillId != null &&
                    this.SkillId.Equals(other.SkillId)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.TrainingStartSp == other.TrainingStartSp ||
                    this.TrainingStartSp != null &&
                    this.TrainingStartSp.Equals(other.TrainingStartSp)
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
                if (this.FinishDate != null)
                    hash = hash * 59 + this.FinishDate.GetHashCode();
                if (this.FinishedLevel != null)
                    hash = hash * 59 + this.FinishedLevel.GetHashCode();
                if (this.LevelEndSp != null)
                    hash = hash * 59 + this.LevelEndSp.GetHashCode();
                if (this.LevelStartSp != null)
                    hash = hash * 59 + this.LevelStartSp.GetHashCode();
                if (this.QueuePosition != null)
                    hash = hash * 59 + this.QueuePosition.GetHashCode();
                if (this.SkillId != null)
                    hash = hash * 59 + this.SkillId.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.TrainingStartSp != null)
                    hash = hash * 59 + this.TrainingStartSp.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // FinishedLevel (int?) maximum
            if(this.FinishedLevel > (int?)5)
            {
                yield return new ValidationResult("Invalid value for FinishedLevel, must be a value less than or equal to 5.", new [] { "FinishedLevel" });
            }

            // FinishedLevel (int?) minimum
            if(this.FinishedLevel < (int?)0)
            {
                yield return new ValidationResult("Invalid value for FinishedLevel, must be a value greater than or equal to 0.", new [] { "FinishedLevel" });
            }

            yield break;
        }
    }

}
