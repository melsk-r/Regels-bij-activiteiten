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
    /// &lt;body&gt;&lt;p&gt;Een limitatieve lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract(Name = "Thema")]
    public partial class Thema : IEquatable<Thema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Thema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Thema" /> class.
        /// </summary>
        /// <param name="code">&lt;body&gt;&lt;p&gt;Combinatie van tekens die het thema uniek duidt.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="waarde">&lt;body&gt;&lt;p&gt;De naam van het thema.&lt;/p&gt;&lt;/body&gt; (required).</param>
        public Thema(string code = default(string), string waarde = default(string))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for Thema and cannot be null");
            // to ensure "waarde" is required (not null)
            this.Waarde = waarde ?? throw new ArgumentNullException("waarde is a required property for Thema and cannot be null");
        }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Combinatie van tekens die het thema uniek duidt.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Combinatie van tekens die het thema uniek duidt.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;De naam van het thema.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De naam van het thema.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name = "waarde", IsRequired = true, EmitDefaultValue = false)]
        public string Waarde { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Thema {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Waarde: ").Append(Waarde).Append("\n");
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
            return this.Equals(input as Thema);
        }

        /// <summary>
        /// Returns true if Thema instances are equal
        /// </summary>
        /// <param name="input">Instance of Thema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Thema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Waarde == input.Waarde ||
                    (this.Waarde != null &&
                    this.Waarde.Equals(input.Waarde))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Waarde != null)
                    hashCode = hashCode * 59 + this.Waarde.GetHashCode();
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
            // Code (string) minLength
            if(this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // Waarde (string) minLength
            if(this.Waarde != null && this.Waarde.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Waarde, length must be greater than 1.", new [] { "Waarde" });
            }

            yield break;
        }
    }

}
