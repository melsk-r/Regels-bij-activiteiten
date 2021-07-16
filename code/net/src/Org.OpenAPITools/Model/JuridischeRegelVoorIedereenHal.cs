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
    /// JuridischeRegelVoorIedereenHal
    /// </summary>
    [DataContract]
    public partial class JuridischeRegelVoorIedereenHal :  IEquatable<JuridischeRegelVoorIedereenHal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereenHal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JuridischeRegelVoorIedereenHal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereenHal" /> class.
        /// </summary>
        /// <param name="begindatum">&lt;body&gt;&lt;p&gt;Datum waarop de juridischeRegelVoorIedereen relevant werd.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="einddatum">&lt;body&gt;&lt;p&gt;Datum vanaf waarop de juridischeRegelVoorIedereen niet meer relevant was.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="gedefinieerdeLocatieIdentificaties">&lt;body&gt;&lt;p&gt;Identificatie van de gedefinieerde locaties.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="idealisatie">idealisatie.</param>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="normeertActiviteiten">normeertActiviteiten.</param>
        /// <param name="omschrijving">&lt;body&gt;&lt;p&gt;&amp;#201;&amp;#233;n doorlopend stuk juridische tekst zijnde een geheel of gedeelte van de tekst van een artikel of een lid.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="regeltekstIdentificatie">&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="themas">themas.</param>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public JuridischeRegelVoorIedereenHal(DateTime begindatum = default(DateTime), DateTime einddatum = default(DateTime), List<string> gedefinieerdeLocatieIdentificaties = default(List<string>), Idealisatie idealisatie = default(Idealisatie), string identificatie = default(string), List<ActiviteitLocatieaanduiding> normeertActiviteiten = default(List<ActiviteitLocatieaanduiding>), string omschrijving = default(string), string regeltekstIdentificatie = default(string), List<Thema> themas = default(List<Thema>), JuridischeRegelVoorIedereenLinks links = default(JuridischeRegelVoorIedereenLinks), JuridischeRegelVoorIedereenEmbedded embedded = default(JuridischeRegelVoorIedereenEmbedded))
        {
            // to ensure "gedefinieerdeLocatieIdentificaties" is required (not null)
            if (gedefinieerdeLocatieIdentificaties == null)
            {
                throw new InvalidDataException("gedefinieerdeLocatieIdentificaties is a required property for JuridischeRegelVoorIedereenHal and cannot be null");
            }
            else
            {
                this.GedefinieerdeLocatieIdentificaties = gedefinieerdeLocatieIdentificaties;
            }

            // to ensure "identificatie" is required (not null)
            if (identificatie == null)
            {
                throw new InvalidDataException("identificatie is a required property for JuridischeRegelVoorIedereenHal and cannot be null");
            }
            else
            {
                this.Identificatie = identificatie;
            }

            // to ensure "omschrijving" is required (not null)
            if (omschrijving == null)
            {
                throw new InvalidDataException("omschrijving is a required property for JuridischeRegelVoorIedereenHal and cannot be null");
            }
            else
            {
                this.Omschrijving = omschrijving;
            }

            // to ensure "regeltekstIdentificatie" is required (not null)
            if (regeltekstIdentificatie == null)
            {
                throw new InvalidDataException("regeltekstIdentificatie is a required property for JuridischeRegelVoorIedereenHal and cannot be null");
            }
            else
            {
                this.RegeltekstIdentificatie = regeltekstIdentificatie;
            }

            this.Begindatum = begindatum;
            this.Einddatum = einddatum;
            this.Idealisatie = idealisatie;
            this.NormeertActiviteiten = normeertActiviteiten;
            this.Themas = themas;
            this.Links = links;
            this.Embedded = embedded;
        }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Datum waarop de juridischeRegelVoorIedereen relevant werd.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Datum waarop de juridischeRegelVoorIedereen relevant werd.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="begindatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Begindatum { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Datum vanaf waarop de juridischeRegelVoorIedereen niet meer relevant was.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Datum vanaf waarop de juridischeRegelVoorIedereen niet meer relevant was.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="einddatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Identificatie van de gedefinieerde locaties.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Identificatie van de gedefinieerde locaties.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="gedefinieerdeLocatieIdentificaties", EmitDefaultValue=true)]
        public List<string> GedefinieerdeLocatieIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets Idealisatie
        /// </summary>
        [DataMember(Name="idealisatie", EmitDefaultValue=false)]
        public Idealisatie Idealisatie { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="identificatie", EmitDefaultValue=true)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Gets or Sets NormeertActiviteiten
        /// </summary>
        [DataMember(Name="normeertActiviteiten", EmitDefaultValue=false)]
        public List<ActiviteitLocatieaanduiding> NormeertActiviteiten { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;&amp;#201;&amp;#233;n doorlopend stuk juridische tekst zijnde een geheel of gedeelte van de tekst van een artikel of een lid.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;&amp;#201;&amp;#233;n doorlopend stuk juridische tekst zijnde een geheel of gedeelte van de tekst van een artikel of een lid.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="omschrijving", EmitDefaultValue=true)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="regeltekstIdentificatie", EmitDefaultValue=true)]
        public string RegeltekstIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets Themas
        /// </summary>
        [DataMember(Name="themas", EmitDefaultValue=false)]
        public List<Thema> Themas { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public JuridischeRegelVoorIedereenLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public JuridischeRegelVoorIedereenEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JuridischeRegelVoorIedereenHal {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  GedefinieerdeLocatieIdentificaties: ").Append(GedefinieerdeLocatieIdentificaties).Append("\n");
            sb.Append("  Idealisatie: ").Append(Idealisatie).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  NormeertActiviteiten: ").Append(NormeertActiviteiten).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  RegeltekstIdentificatie: ").Append(RegeltekstIdentificatie).Append("\n");
            sb.Append("  Themas: ").Append(Themas).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(input as JuridischeRegelVoorIedereenHal);
        }

        /// <summary>
        /// Returns true if JuridischeRegelVoorIedereenHal instances are equal
        /// </summary>
        /// <param name="input">Instance of JuridischeRegelVoorIedereenHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JuridischeRegelVoorIedereenHal input)
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
                    this.GedefinieerdeLocatieIdentificaties == input.GedefinieerdeLocatieIdentificaties ||
                    this.GedefinieerdeLocatieIdentificaties != null &&
                    input.GedefinieerdeLocatieIdentificaties != null &&
                    this.GedefinieerdeLocatieIdentificaties.SequenceEqual(input.GedefinieerdeLocatieIdentificaties)
                ) && 
                (
                    this.Idealisatie == input.Idealisatie ||
                    (this.Idealisatie != null &&
                    this.Idealisatie.Equals(input.Idealisatie))
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.NormeertActiviteiten == input.NormeertActiviteiten ||
                    this.NormeertActiviteiten != null &&
                    input.NormeertActiviteiten != null &&
                    this.NormeertActiviteiten.SequenceEqual(input.NormeertActiviteiten)
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
                ) && 
                (
                    this.RegeltekstIdentificatie == input.RegeltekstIdentificatie ||
                    (this.RegeltekstIdentificatie != null &&
                    this.RegeltekstIdentificatie.Equals(input.RegeltekstIdentificatie))
                ) && 
                (
                    this.Themas == input.Themas ||
                    this.Themas != null &&
                    input.Themas != null &&
                    this.Themas.SequenceEqual(input.Themas)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
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
                if (this.GedefinieerdeLocatieIdentificaties != null)
                    hashCode = hashCode * 59 + this.GedefinieerdeLocatieIdentificaties.GetHashCode();
                if (this.Idealisatie != null)
                    hashCode = hashCode * 59 + this.Idealisatie.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.NormeertActiviteiten != null)
                    hashCode = hashCode * 59 + this.NormeertActiviteiten.GetHashCode();
                if (this.Omschrijving != null)
                    hashCode = hashCode * 59 + this.Omschrijving.GetHashCode();
                if (this.RegeltekstIdentificatie != null)
                    hashCode = hashCode * 59 + this.RegeltekstIdentificatie.GetHashCode();
                if (this.Themas != null)
                    hashCode = hashCode * 59 + this.Themas.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Embedded != null)
                    hashCode = hashCode * 59 + this.Embedded.GetHashCode();
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
 

            // Omschrijving (string) minLength
            if(this.Omschrijving != null && this.Omschrijving.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Omschrijving, length must be greater than 1.", new [] { "Omschrijving" });
            }
 

            // RegeltekstIdentificatie (string) minLength
            if(this.RegeltekstIdentificatie != null && this.RegeltekstIdentificatie.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegeltekstIdentificatie, length must be greater than 1.", new [] { "RegeltekstIdentificatie" });
            }
 
            yield break;
        }
    }

}
