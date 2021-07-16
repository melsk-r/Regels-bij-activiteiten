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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// LocatieHal
    /// </summary>
    [DataContract]
    public partial class LocatieHal :  IEquatable<LocatieHal>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public LocatieType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatieHal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocatieHal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatieHal" /> class.
        /// </summary>
        /// <param name="begindatum">&lt;body&gt;&lt;p&gt;Datum waarop de locatie relevant werd.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="einddatum">&lt;body&gt;&lt;p&gt;Datum vanaf waarop de locatie niet meer relevant was.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="geometrie">geometrie.</param>
        /// <param name="geometrieBron">&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="noemer">&lt;body&gt;&lt;p&gt;Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals &#39;Het Koninkrijk der Nederlanden&#39; of gemeente &#39;Amersfoort&#39;. Bijvoorbeeld een natuurgebied zoals de &#39;Veluwe&#39; of de rivier de &#39;Rijn&#39; of het centrum van een woonplaats &#39;centrum Apeldoorn&#39;.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="omvattendeLocatieIdentificaties">&lt;body&gt;&lt;p&gt;Identificatie van de omvattende locaties.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="type">type (required).</param>
        /// <param name="links">links.</param>
        public LocatieHal(DateTime begindatum = default(DateTime), DateTime einddatum = default(DateTime), GeoJSONGeometrie geometrie = default(GeoJSONGeometrie), string geometrieBron = default(string), string identificatie = default(string), string noemer = default(string), List<string> omvattendeLocatieIdentificaties = default(List<string>), LocatieType type = default(LocatieType), LocatieLinks links = default(LocatieLinks))
        {
            // to ensure "identificatie" is required (not null)
            if (identificatie == null)
            {
                throw new InvalidDataException("identificatie is a required property for LocatieHal and cannot be null");
            }
            else
            {
                this.Identificatie = identificatie;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LocatieHal and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.Begindatum = begindatum;
            this.Einddatum = einddatum;
            this.Geometrie = geometrie;
            this.GeometrieBron = geometrieBron;
            this.Noemer = noemer;
            this.OmvattendeLocatieIdentificaties = omvattendeLocatieIdentificaties;
            this.Links = links;
        }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Datum waarop de locatie relevant werd.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Datum waarop de locatie relevant werd.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="begindatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Begindatum { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Datum vanaf waarop de locatie niet meer relevant was.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Datum vanaf waarop de locatie niet meer relevant was.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="einddatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Gets or Sets Geometrie
        /// </summary>
        [DataMember(Name="geometrie", EmitDefaultValue=false)]
        public GeoJSONGeometrie Geometrie { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="geometrieBron", EmitDefaultValue=false)]
        public string GeometrieBron { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="identificatie", EmitDefaultValue=true)]
        public string Identificatie { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals &#39;Het Koninkrijk der Nederlanden&#39; of gemeente &#39;Amersfoort&#39;. Bijvoorbeeld een natuurgebied zoals de &#39;Veluwe&#39; of de rivier de &#39;Rijn&#39; of het centrum van een woonplaats &#39;centrum Apeldoorn&#39;.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals &#39;Het Koninkrijk der Nederlanden&#39; of gemeente &#39;Amersfoort&#39;. Bijvoorbeeld een natuurgebied zoals de &#39;Veluwe&#39; of de rivier de &#39;Rijn&#39; of het centrum van een woonplaats &#39;centrum Apeldoorn&#39;.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="noemer", EmitDefaultValue=false)]
        public string Noemer { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Identificatie van de omvattende locaties.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Identificatie van de omvattende locaties.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="omvattendeLocatieIdentificaties", EmitDefaultValue=false)]
        public List<string> OmvattendeLocatieIdentificaties { get; set; }


        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public LocatieLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocatieHal {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
            sb.Append("  GeometrieBron: ").Append(GeometrieBron).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Noemer: ").Append(Noemer).Append("\n");
            sb.Append("  OmvattendeLocatieIdentificaties: ").Append(OmvattendeLocatieIdentificaties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as LocatieHal);
        }

        /// <summary>
        /// Returns true if LocatieHal instances are equal
        /// </summary>
        /// <param name="input">Instance of LocatieHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocatieHal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Begindatum == input.Begindatum ||
                    (this.Begindatum != null &&
                    this.Begindatum.Equals(input.Begindatum))
                ) && 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
                ) && 
                (
                    this.Geometrie == input.Geometrie ||
                    (this.Geometrie != null &&
                    this.Geometrie.Equals(input.Geometrie))
                ) && 
                (
                    this.GeometrieBron == input.GeometrieBron ||
                    (this.GeometrieBron != null &&
                    this.GeometrieBron.Equals(input.GeometrieBron))
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Noemer == input.Noemer ||
                    (this.Noemer != null &&
                    this.Noemer.Equals(input.Noemer))
                ) && 
                (
                    this.OmvattendeLocatieIdentificaties == input.OmvattendeLocatieIdentificaties ||
                    this.OmvattendeLocatieIdentificaties != null &&
                    input.OmvattendeLocatieIdentificaties != null &&
                    this.OmvattendeLocatieIdentificaties.SequenceEqual(input.OmvattendeLocatieIdentificaties)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Begindatum != null)
                    hashCode = hashCode * 59 + this.Begindatum.GetHashCode();
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                if (this.Geometrie != null)
                    hashCode = hashCode * 59 + this.Geometrie.GetHashCode();
                if (this.GeometrieBron != null)
                    hashCode = hashCode * 59 + this.GeometrieBron.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Noemer != null)
                    hashCode = hashCode * 59 + this.Noemer.GetHashCode();
                if (this.OmvattendeLocatieIdentificaties != null)
                    hashCode = hashCode * 59 + this.OmvattendeLocatieIdentificaties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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

            // Identificatie (string) minLength
            if(this.Identificatie != null && this.Identificatie.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identificatie, length must be greater than 1.", new [] { "Identificatie" });
            }
 

 
            yield break;
        }
    }

}
