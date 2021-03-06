/*
 * Regels bij activiteiten
 *
 * <body><p>Deze API maakt het mogelijk om gegevens op te vragen, bij een applicatie die invulling geeft aan de Omgevingswetbeleidcomponent, ook wel aangeduid als plansoftware, over (Omgevingswet-)activiteiten en/of (bijbehorende) juridische regels, regelteksten en locaties.</p></body>
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: robert.melskens@vng.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Geometrie in GeoJSON formaat (RFC 7946). Een property die dit datatype heeft mag slechts 1 van de opgenomen properties bevatten. Deze constructie vervangt de oneOf vanwege codegeneratie-issues.
    /// </summary>
    [DataContract(Name = "GeoJSONGeometrie")]
    public partial class GeoJSONGeometrie : IEquatable<GeoJSONGeometrie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoJSONGeometrie" /> class.
        /// </summary>
        /// <param name="point">point.</param>
        /// <param name="lineString">lineString.</param>
        /// <param name="polygon">polygon.</param>
        /// <param name="multiPoint">multiPoint.</param>
        /// <param name="multiLineString">multiLineString.</param>
        /// <param name="multiPolygon">multiPolygon.</param>
        public GeoJSONGeometrie(PointGeoJSON point = default(PointGeoJSON), LinestringGeoJSON lineString = default(LinestringGeoJSON), PolygonGeoJSON polygon = default(PolygonGeoJSON), MultipointGeoJSON multiPoint = default(MultipointGeoJSON), MultilinestringGeoJSON multiLineString = default(MultilinestringGeoJSON), MultipolygonGeoJSON multiPolygon = default(MultipolygonGeoJSON))
        {
            this.Point = point;
            this.LineString = lineString;
            this.Polygon = polygon;
            this.MultiPoint = multiPoint;
            this.MultiLineString = multiLineString;
            this.MultiPolygon = multiPolygon;
        }

        /// <summary>
        /// Gets or Sets Point
        /// </summary>
        [DataMember(Name = "point", EmitDefaultValue = false)]
        public PointGeoJSON Point { get; set; }

        /// <summary>
        /// Gets or Sets LineString
        /// </summary>
        [DataMember(Name = "lineString", EmitDefaultValue = false)]
        public LinestringGeoJSON LineString { get; set; }

        /// <summary>
        /// Gets or Sets Polygon
        /// </summary>
        [DataMember(Name = "polygon", EmitDefaultValue = false)]
        public PolygonGeoJSON Polygon { get; set; }

        /// <summary>
        /// Gets or Sets MultiPoint
        /// </summary>
        [DataMember(Name = "multiPoint", EmitDefaultValue = false)]
        public MultipointGeoJSON MultiPoint { get; set; }

        /// <summary>
        /// Gets or Sets MultiLineString
        /// </summary>
        [DataMember(Name = "multiLineString", EmitDefaultValue = false)]
        public MultilinestringGeoJSON MultiLineString { get; set; }

        /// <summary>
        /// Gets or Sets MultiPolygon
        /// </summary>
        [DataMember(Name = "multiPolygon", EmitDefaultValue = false)]
        public MultipolygonGeoJSON MultiPolygon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoJSONGeometrie {\n");
            sb.Append("  Point: ").Append(Point).Append("\n");
            sb.Append("  LineString: ").Append(LineString).Append("\n");
            sb.Append("  Polygon: ").Append(Polygon).Append("\n");
            sb.Append("  MultiPoint: ").Append(MultiPoint).Append("\n");
            sb.Append("  MultiLineString: ").Append(MultiLineString).Append("\n");
            sb.Append("  MultiPolygon: ").Append(MultiPolygon).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeoJSONGeometrie);
        }

        /// <summary>
        /// Returns true if GeoJSONGeometrie instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoJSONGeometrie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoJSONGeometrie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Point == input.Point ||
                    (this.Point != null &&
                    this.Point.Equals(input.Point))
                ) && 
                (
                    this.LineString == input.LineString ||
                    (this.LineString != null &&
                    this.LineString.Equals(input.LineString))
                ) && 
                (
                    this.Polygon == input.Polygon ||
                    (this.Polygon != null &&
                    this.Polygon.Equals(input.Polygon))
                ) && 
                (
                    this.MultiPoint == input.MultiPoint ||
                    (this.MultiPoint != null &&
                    this.MultiPoint.Equals(input.MultiPoint))
                ) && 
                (
                    this.MultiLineString == input.MultiLineString ||
                    (this.MultiLineString != null &&
                    this.MultiLineString.Equals(input.MultiLineString))
                ) && 
                (
                    this.MultiPolygon == input.MultiPolygon ||
                    (this.MultiPolygon != null &&
                    this.MultiPolygon.Equals(input.MultiPolygon))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Point != null)
                    hashCode = hashCode * 59 + this.Point.GetHashCode();
                if (this.LineString != null)
                    hashCode = hashCode * 59 + this.LineString.GetHashCode();
                if (this.Polygon != null)
                    hashCode = hashCode * 59 + this.Polygon.GetHashCode();
                if (this.MultiPoint != null)
                    hashCode = hashCode * 59 + this.MultiPoint.GetHashCode();
                if (this.MultiLineString != null)
                    hashCode = hashCode * 59 + this.MultiLineString.GetHashCode();
                if (this.MultiPolygon != null)
                    hashCode = hashCode * 59 + this.MultiPolygon.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
