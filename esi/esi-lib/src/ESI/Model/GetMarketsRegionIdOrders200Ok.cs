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
    public partial class GetMarketsRegionIdOrders200Ok :  IEquatable<GetMarketsRegionIdOrders200Ok>, IValidatableObject
    {
        /// <summary>
        /// range string
        /// </summary>
        /// <value>range string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RangeEnum
        {
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum Region for "region"
            /// </summary>
            [EnumMember(Value = "region")]
            Region,
            
            /// <summary>
            /// Enum Solarsystem for "solarsystem"
            /// </summary>
            [EnumMember(Value = "solarsystem")]
            Solarsystem,
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _2 for "2"
            /// </summary>
            [EnumMember(Value = "2")]
            _2,
            
            /// <summary>
            /// Enum _3 for "3"
            /// </summary>
            [EnumMember(Value = "3")]
            _3,
            
            /// <summary>
            /// Enum _4 for "4"
            /// </summary>
            [EnumMember(Value = "4")]
            _4,
            
            /// <summary>
            /// Enum _5 for "5"
            /// </summary>
            [EnumMember(Value = "5")]
            _5,
            
            /// <summary>
            /// Enum _10 for "10"
            /// </summary>
            [EnumMember(Value = "10")]
            _10,
            
            /// <summary>
            /// Enum _20 for "20"
            /// </summary>
            [EnumMember(Value = "20")]
            _20,
            
            /// <summary>
            /// Enum _30 for "30"
            /// </summary>
            [EnumMember(Value = "30")]
            _30,
            
            /// <summary>
            /// Enum _40 for "40"
            /// </summary>
            [EnumMember(Value = "40")]
            _40
        }

        /// <summary>
        /// range string
        /// </summary>
        /// <value>range string</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public RangeEnum? Range { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMarketsRegionIdOrders200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMarketsRegionIdOrders200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMarketsRegionIdOrders200Ok" /> class.
        /// </summary>
        /// <param name="Duration">duration integer (required).</param>
        /// <param name="IsBuyOrder">is_buy_order boolean (required).</param>
        /// <param name="Issued">issued string (required).</param>
        /// <param name="LocationId">location_id integer (required).</param>
        /// <param name="MinVolume">min_volume integer (required).</param>
        /// <param name="OrderId">order_id integer (required).</param>
        /// <param name="Price">price number (required).</param>
        /// <param name="Range">range string (required).</param>
        /// <param name="TypeId">type_id integer (required).</param>
        /// <param name="VolumeRemain">volume_remain integer (required).</param>
        /// <param name="VolumeTotal">volume_total integer (required).</param>
        public GetMarketsRegionIdOrders200Ok(int? Duration = default(int?), bool? IsBuyOrder = default(bool?), DateTime? Issued = default(DateTime?), long? LocationId = default(long?), int? MinVolume = default(int?), long? OrderId = default(long?), float? Price = default(float?), RangeEnum? Range = default(RangeEnum?), int? TypeId = default(int?), int? VolumeRemain = default(int?), int? VolumeTotal = default(int?))
        {
            // to ensure "Duration" is required (not null)
            if (Duration == null)
            {
                throw new InvalidDataException("Duration is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.Duration = Duration;
            }
            // to ensure "IsBuyOrder" is required (not null)
            if (IsBuyOrder == null)
            {
                throw new InvalidDataException("IsBuyOrder is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.IsBuyOrder = IsBuyOrder;
            }
            // to ensure "Issued" is required (not null)
            if (Issued == null)
            {
                throw new InvalidDataException("Issued is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.Issued = Issued;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "MinVolume" is required (not null)
            if (MinVolume == null)
            {
                throw new InvalidDataException("MinVolume is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.MinVolume = MinVolume;
            }
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "Range" is required (not null)
            if (Range == null)
            {
                throw new InvalidDataException("Range is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.Range = Range;
            }
            // to ensure "TypeId" is required (not null)
            if (TypeId == null)
            {
                throw new InvalidDataException("TypeId is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.TypeId = TypeId;
            }
            // to ensure "VolumeRemain" is required (not null)
            if (VolumeRemain == null)
            {
                throw new InvalidDataException("VolumeRemain is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.VolumeRemain = VolumeRemain;
            }
            // to ensure "VolumeTotal" is required (not null)
            if (VolumeTotal == null)
            {
                throw new InvalidDataException("VolumeTotal is a required property for GetMarketsRegionIdOrders200Ok and cannot be null");
            }
            else
            {
                this.VolumeTotal = VolumeTotal;
            }
        }
        
        /// <summary>
        /// duration integer
        /// </summary>
        /// <value>duration integer</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// is_buy_order boolean
        /// </summary>
        /// <value>is_buy_order boolean</value>
        [DataMember(Name="is_buy_order", EmitDefaultValue=false)]
        public bool? IsBuyOrder { get; set; }
        /// <summary>
        /// issued string
        /// </summary>
        /// <value>issued string</value>
        [DataMember(Name="issued", EmitDefaultValue=false)]
        public DateTime? Issued { get; set; }
        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }
        /// <summary>
        /// min_volume integer
        /// </summary>
        /// <value>min_volume integer</value>
        [DataMember(Name="min_volume", EmitDefaultValue=false)]
        public int? MinVolume { get; set; }
        /// <summary>
        /// order_id integer
        /// </summary>
        /// <value>order_id integer</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public long? OrderId { get; set; }
        /// <summary>
        /// price number
        /// </summary>
        /// <value>price number</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public float? Price { get; set; }
        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }
        /// <summary>
        /// volume_remain integer
        /// </summary>
        /// <value>volume_remain integer</value>
        [DataMember(Name="volume_remain", EmitDefaultValue=false)]
        public int? VolumeRemain { get; set; }
        /// <summary>
        /// volume_total integer
        /// </summary>
        /// <value>volume_total integer</value>
        [DataMember(Name="volume_total", EmitDefaultValue=false)]
        public int? VolumeTotal { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMarketsRegionIdOrders200Ok {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  IsBuyOrder: ").Append(IsBuyOrder).Append("\n");
            sb.Append("  Issued: ").Append(Issued).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  MinVolume: ").Append(MinVolume).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  VolumeRemain: ").Append(VolumeRemain).Append("\n");
            sb.Append("  VolumeTotal: ").Append(VolumeTotal).Append("\n");
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
            return this.Equals(obj as GetMarketsRegionIdOrders200Ok);
        }

        /// <summary>
        /// Returns true if GetMarketsRegionIdOrders200Ok instances are equal
        /// </summary>
        /// <param name="other">Instance of GetMarketsRegionIdOrders200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMarketsRegionIdOrders200Ok other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.IsBuyOrder == other.IsBuyOrder ||
                    this.IsBuyOrder != null &&
                    this.IsBuyOrder.Equals(other.IsBuyOrder)
                ) && 
                (
                    this.Issued == other.Issued ||
                    this.Issued != null &&
                    this.Issued.Equals(other.Issued)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.MinVolume == other.MinVolume ||
                    this.MinVolume != null &&
                    this.MinVolume.Equals(other.MinVolume)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
                ) && 
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) && 
                (
                    this.VolumeRemain == other.VolumeRemain ||
                    this.VolumeRemain != null &&
                    this.VolumeRemain.Equals(other.VolumeRemain)
                ) && 
                (
                    this.VolumeTotal == other.VolumeTotal ||
                    this.VolumeTotal != null &&
                    this.VolumeTotal.Equals(other.VolumeTotal)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.IsBuyOrder != null)
                    hash = hash * 59 + this.IsBuyOrder.GetHashCode();
                if (this.Issued != null)
                    hash = hash * 59 + this.Issued.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.MinVolume != null)
                    hash = hash * 59 + this.MinVolume.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                if (this.TypeId != null)
                    hash = hash * 59 + this.TypeId.GetHashCode();
                if (this.VolumeRemain != null)
                    hash = hash * 59 + this.VolumeRemain.GetHashCode();
                if (this.VolumeTotal != null)
                    hash = hash * 59 + this.VolumeTotal.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
