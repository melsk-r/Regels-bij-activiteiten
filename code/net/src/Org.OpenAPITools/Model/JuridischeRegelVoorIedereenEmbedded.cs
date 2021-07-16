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
    /// JuridischeRegelVoorIedereenEmbedded
    /// </summary>
    [DataContract]
    public partial class JuridischeRegelVoorIedereenEmbedded :  IEquatable<JuridischeRegelVoorIedereenEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereenEmbedded" /> class.
        /// </summary>
        /// <param name="gedefinieerdeLocaties">&lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="regeltekst">regeltekst.</param>
        public JuridischeRegelVoorIedereenEmbedded(List<LocatieHal> gedefinieerdeLocaties = default(List<LocatieHal>), RegeltekstHal regeltekst = default(RegeltekstHal))
        {
            this.GedefinieerdeLocaties = gedefinieerdeLocaties;
            this.Regeltekst = regeltekst;
        }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="gedefinieerdeLocaties", EmitDefaultValue=false)]
        public List<LocatieHal> GedefinieerdeLocaties { get; set; }

        /// <summary>
        /// Gets or Sets Regeltekst
        /// </summary>
        [DataMember(Name="regeltekst", EmitDefaultValue=false)]
        public RegeltekstHal Regeltekst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JuridischeRegelVoorIedereenEmbedded {\n");
            sb.Append("  GedefinieerdeLocaties: ").Append(GedefinieerdeLocaties).Append("\n");
            sb.Append("  Regeltekst: ").Append(Regeltekst).Append("\n");
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
            return this.Equals(input as JuridischeRegelVoorIedereenEmbedded);
        }

        /// <summary>
        /// Returns true if JuridischeRegelVoorIedereenEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of JuridischeRegelVoorIedereenEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JuridischeRegelVoorIedereenEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GedefinieerdeLocaties == input.GedefinieerdeLocaties ||
                    this.GedefinieerdeLocaties != null &&
                    input.GedefinieerdeLocaties != null &&
                    this.GedefinieerdeLocaties.SequenceEqual(input.GedefinieerdeLocaties)
                ) && 
                (
                    this.Regeltekst == input.Regeltekst ||
                    (this.Regeltekst != null &&
                    this.Regeltekst.Equals(input.Regeltekst))
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
                if (this.GedefinieerdeLocaties != null)
                    hashCode = hashCode * 59 + this.GedefinieerdeLocaties.GetHashCode();
                if (this.Regeltekst != null)
                    hashCode = hashCode * 59 + this.Regeltekst.GetHashCode();
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
