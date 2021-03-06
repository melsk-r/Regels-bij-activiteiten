/*
 * Regels bij activiteiten
 * <body><p>Deze API maakt het mogelijk om gegevens op te vragen, bij een applicatie die invulling geeft aan de Omgevingswetbeleidcomponent, ook wel aangeduid als plansoftware, over (Omgevingswet-)activiteiten en/of (bijbehorende) juridische regels, regelteksten en locaties.</p></body>
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: robert.melskens@vng.nl
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.DocumentComponent;
import org.openapitools.client.model.Regeltekst;
import org.openapitools.client.model.RegeltekstEmbedded;
import org.openapitools.client.model.RegeltekstHalAllOf;
import org.openapitools.client.model.RegeltekstLinks;

/**
 * RegeltekstHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class RegeltekstHal {
  public static final String SERIALIZED_NAME_BEGINDATUM = "begindatum";
  @SerializedName(SERIALIZED_NAME_BEGINDATUM)
  private LocalDate begindatum;

  public static final String SERIALIZED_NAME_DOCUMENT_COMPONENT = "documentComponent";
  @SerializedName(SERIALIZED_NAME_DOCUMENT_COMPONENT)
  private DocumentComponent documentComponent;

  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_GERELATEERDE_REGELTEKST_IDENTIFICATIES = "gerelateerdeRegeltekstIdentificaties";
  @SerializedName(SERIALIZED_NAME_GERELATEERDE_REGELTEKST_IDENTIFICATIES)
  private List<String> gerelateerdeRegeltekstIdentificaties = null;

  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_LAATSTE_WIJZIGINGSDATUM = "laatsteWijzigingsdatum";
  @SerializedName(SERIALIZED_NAME_LAATSTE_WIJZIGINGSDATUM)
  private LocalDate laatsteWijzigingsdatum;

  public static final String SERIALIZED_NAME_LOCATIE_IDENTIFICATIES = "locatieIdentificaties";
  @SerializedName(SERIALIZED_NAME_LOCATIE_IDENTIFICATIES)
  private List<String> locatieIdentificaties = new ArrayList<>();

  public static final String SERIALIZED_NAME_OMSCHRIJVING = "omschrijving";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING)
  private String omschrijving;

  public static final String SERIALIZED_NAME_WERKPAKKET_CODE = "werkpakketCode";
  @SerializedName(SERIALIZED_NAME_WERKPAKKET_CODE)
  private String werkpakketCode;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private RegeltekstLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private RegeltekstEmbedded embedded;


  public RegeltekstHal begindatum(LocalDate begindatum) {
    
    this.begindatum = begindatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum waarop de regeltekst relevant werd.&lt;/p&gt;&lt;/body&gt;
   * @return begindatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum waarop de regeltekst relevant werd.</p></body>")

  public LocalDate getBegindatum() {
    return begindatum;
  }


  public void setBegindatum(LocalDate begindatum) {
    this.begindatum = begindatum;
  }


  public RegeltekstHal documentComponent(DocumentComponent documentComponent) {
    
    this.documentComponent = documentComponent;
    return this;
  }

   /**
   * Get documentComponent
   * @return documentComponent
  **/
  @ApiModelProperty(required = true, value = "")

  public DocumentComponent getDocumentComponent() {
    return documentComponent;
  }


  public void setDocumentComponent(DocumentComponent documentComponent) {
    this.documentComponent = documentComponent;
  }


  public RegeltekstHal einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum vanaf waarop de regeltekst niet meer relevant was.&lt;/p&gt;&lt;/body&gt;
   * @return einddatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum vanaf waarop de regeltekst niet meer relevant was.</p></body>")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public RegeltekstHal gerelateerdeRegeltekstIdentificaties(List<String> gerelateerdeRegeltekstIdentificaties) {
    
    this.gerelateerdeRegeltekstIdentificaties = gerelateerdeRegeltekstIdentificaties;
    return this;
  }

  public RegeltekstHal addGerelateerdeRegeltekstIdentificatiesItem(String gerelateerdeRegeltekstIdentificatiesItem) {
    if (this.gerelateerdeRegeltekstIdentificaties == null) {
      this.gerelateerdeRegeltekstIdentificaties = new ArrayList<>();
    }
    this.gerelateerdeRegeltekstIdentificaties.add(gerelateerdeRegeltekstIdentificatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificaties van de gerelateerde regelteksten.&lt;/p&gt;&lt;/body&gt;
   * @return gerelateerdeRegeltekstIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Identificaties van de gerelateerde regelteksten.</p></body>")

  public List<String> getGerelateerdeRegeltekstIdentificaties() {
    return gerelateerdeRegeltekstIdentificaties;
  }


  public void setGerelateerdeRegeltekstIdentificaties(List<String> gerelateerdeRegeltekstIdentificaties) {
    this.gerelateerdeRegeltekstIdentificaties = gerelateerdeRegeltekstIdentificaties;
  }


  public RegeltekstHal identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;
   * @return identificatie
  **/
  @ApiModelProperty(required = true, value = "<body><p>Identificatie datatype van Geonovum.</p></body>")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public RegeltekstHal laatsteWijzigingsdatum(LocalDate laatsteWijzigingsdatum) {
    
    this.laatsteWijzigingsdatum = laatsteWijzigingsdatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de regeltekst.&lt;/p&gt;&lt;/body&gt;
   * @return laatsteWijzigingsdatum
  **/
  @ApiModelProperty(required = true, value = "<body><p>De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de regeltekst.</p></body>")

  public LocalDate getLaatsteWijzigingsdatum() {
    return laatsteWijzigingsdatum;
  }


  public void setLaatsteWijzigingsdatum(LocalDate laatsteWijzigingsdatum) {
    this.laatsteWijzigingsdatum = laatsteWijzigingsdatum;
  }


  public RegeltekstHal locatieIdentificaties(List<String> locatieIdentificaties) {
    
    this.locatieIdentificaties = locatieIdentificaties;
    return this;
  }

  public RegeltekstHal addLocatieIdentificatiesItem(String locatieIdentificatiesItem) {
    this.locatieIdentificaties.add(locatieIdentificatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificaties van de gerelateerde locaties die gezamenlijk het werkingsgebied van de regeltekst vormen.&lt;/p&gt;&lt;/body&gt;
   * @return locatieIdentificaties
  **/
  @ApiModelProperty(required = true, value = "<body><p>Identificaties van de gerelateerde locaties die gezamenlijk het werkingsgebied van de regeltekst vormen.</p></body>")

  public List<String> getLocatieIdentificaties() {
    return locatieIdentificaties;
  }


  public void setLocatieIdentificaties(List<String> locatieIdentificaties) {
    this.locatieIdentificaties = locatieIdentificaties;
  }


  public RegeltekstHal omschrijving(String omschrijving) {
    
    this.omschrijving = omschrijving;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De letterlijke tekst waarmee de Regeltekst is omschreven, in een artikel of een lid. Een Regeltekst is altijd één doorlopend stuk juridische tekst, welke juridische regels bevat.&lt;/p&gt;&lt;/body&gt;
   * @return omschrijving
  **/
  @ApiModelProperty(required = true, value = "<body><p>De letterlijke tekst waarmee de Regeltekst is omschreven, in een artikel of een lid. Een Regeltekst is altijd één doorlopend stuk juridische tekst, welke juridische regels bevat.</p></body>")

  public String getOmschrijving() {
    return omschrijving;
  }


  public void setOmschrijving(String omschrijving) {
    this.omschrijving = omschrijving;
  }


  public RegeltekstHal werkpakketCode(String werkpakketCode) {
    
    this.werkpakketCode = werkpakketCode;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Een unieke aanduiding van de verzameling samenhangende activiteiten gericht op het publiceren van een nieuwe versie van een omgevingsdocument.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Er kunnen tegelijkertijd meerdere trajecten gaande zijn waarin bijvoorbeeld een omgevingsplan gewijzigd wordt, die elk leiden tot een apart te publiceren nieuwe versie van het omgevingsplan. De werkpakketcode biedt de mogelijkheid om de regelteksten te markeren die betrokken zijn in zo&#39;n traject. Daarvan kan gebruik gemaakt worden om alleen de regels met bijhorende annotaties op te vragen voor een specifiek werkpakket.&lt;/p&gt;&lt;/body&gt;
   * @return werkpakketCode
  **/
  @ApiModelProperty(required = true, value = "<body><p>Een unieke aanduiding van de verzameling samenhangende activiteiten gericht op het publiceren van een nieuwe versie van een omgevingsdocument.</p></body><body><p>Er kunnen tegelijkertijd meerdere trajecten gaande zijn waarin bijvoorbeeld een omgevingsplan gewijzigd wordt, die elk leiden tot een apart te publiceren nieuwe versie van het omgevingsplan. De werkpakketcode biedt de mogelijkheid om de regelteksten te markeren die betrokken zijn in zo'n traject. Daarvan kan gebruik gemaakt worden om alleen de regels met bijhorende annotaties op te vragen voor een specifiek werkpakket.</p></body>")

  public String getWerkpakketCode() {
    return werkpakketCode;
  }


  public void setWerkpakketCode(String werkpakketCode) {
    this.werkpakketCode = werkpakketCode;
  }


  public RegeltekstHal links(RegeltekstLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RegeltekstLinks getLinks() {
    return links;
  }


  public void setLinks(RegeltekstLinks links) {
    this.links = links;
  }


  public RegeltekstHal embedded(RegeltekstEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RegeltekstEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(RegeltekstEmbedded embedded) {
    this.embedded = embedded;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RegeltekstHal regeltekstHal = (RegeltekstHal) o;
    return Objects.equals(this.begindatum, regeltekstHal.begindatum) &&
        Objects.equals(this.documentComponent, regeltekstHal.documentComponent) &&
        Objects.equals(this.einddatum, regeltekstHal.einddatum) &&
        Objects.equals(this.gerelateerdeRegeltekstIdentificaties, regeltekstHal.gerelateerdeRegeltekstIdentificaties) &&
        Objects.equals(this.identificatie, regeltekstHal.identificatie) &&
        Objects.equals(this.laatsteWijzigingsdatum, regeltekstHal.laatsteWijzigingsdatum) &&
        Objects.equals(this.locatieIdentificaties, regeltekstHal.locatieIdentificaties) &&
        Objects.equals(this.omschrijving, regeltekstHal.omschrijving) &&
        Objects.equals(this.werkpakketCode, regeltekstHal.werkpakketCode) &&
        Objects.equals(this.links, regeltekstHal.links) &&
        Objects.equals(this.embedded, regeltekstHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(begindatum, documentComponent, einddatum, gerelateerdeRegeltekstIdentificaties, identificatie, laatsteWijzigingsdatum, locatieIdentificaties, omschrijving, werkpakketCode, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RegeltekstHal {\n");
    sb.append("    begindatum: ").append(toIndentedString(begindatum)).append("\n");
    sb.append("    documentComponent: ").append(toIndentedString(documentComponent)).append("\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
    sb.append("    gerelateerdeRegeltekstIdentificaties: ").append(toIndentedString(gerelateerdeRegeltekstIdentificaties)).append("\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    laatsteWijzigingsdatum: ").append(toIndentedString(laatsteWijzigingsdatum)).append("\n");
    sb.append("    locatieIdentificaties: ").append(toIndentedString(locatieIdentificaties)).append("\n");
    sb.append("    omschrijving: ").append(toIndentedString(omschrijving)).append("\n");
    sb.append("    werkpakketCode: ").append(toIndentedString(werkpakketCode)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("    embedded: ").append(toIndentedString(embedded)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

