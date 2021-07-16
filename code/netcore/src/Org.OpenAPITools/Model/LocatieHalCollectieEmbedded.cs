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
    /// LocatieHalCollectieEmbedded
    /// </summary>
    [DataContract(Name = "LocatieHalCollectie__embedded")]
    public partial class LocatieHalCollectieEmbedded : IEquatable<LocatieHalCollectieEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatieHalCollectieEmbedded" /> class.
        /// </summary>
        /// <param name="locaties">locaties.</param>
        public LocatieHalCollectieEmbedded(List<LocatieHal> locaties = default(List<LocatieHal>))
        {
            this.Locaties = locaties;
        }

        /// <summary>
        /// Gets or Sets Locaties
        /// </summary>
        [DataMember(Name = "locaties", EmitDefaultValue = false)]
        public List<LocatieHal> Locaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocatieHalCollectieEmbedded {\n");
            sb.Append("  Locaties: ").Append(Locaties).Append("\n");
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
            return this.Equals(input as LocatieHalCollectieEmbedded);
        }

        /// <summary>
        /// Returns true if LocatieHalCollectieEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of LocatieHalCollectieEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocatieHalCollectieEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locaties == input.Locaties ||
                    this.Locaties != null &&
                    input.Locaties != null &&
                    this.Locaties.SequenceEqual(input.Locaties)
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
                if (this.Locaties != null)
                    hashCode = hashCode * 59 + this.Locaties.GetHashCode();
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
