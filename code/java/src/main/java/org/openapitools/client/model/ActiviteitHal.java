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
import org.openapitools.client.model.Activiteit;
import org.openapitools.client.model.ActiviteitEmbedded;
import org.openapitools.client.model.ActiviteitHalAllOf;
import org.openapitools.client.model.ActiviteitLinks;
import org.openapitools.client.model.Activiteitengroep;

/**
 * ActiviteitHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class ActiviteitHal {
  public static final String SERIALIZED_NAME_BEGINDATUM = "begindatum";
  @SerializedName(SERIALIZED_NAME_BEGINDATUM)
  private LocalDate begindatum;

  public static final String SERIALIZED_NAME_BOVENLIGGENDE_ACTIVITEIT_IDENTIFICATIE = "bovenliggendeActiviteitIdentificatie";
  @SerializedName(SERIALIZED_NAME_BOVENLIGGENDE_ACTIVITEIT_IDENTIFICATIE)
  private String bovenliggendeActiviteitIdentificatie;

  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_GERELATEERDE_ACTIVITEIT_IDENTIFICATIES = "gerelateerdeActiviteitIdentificaties";
  @SerializedName(SERIALIZED_NAME_GERELATEERDE_ACTIVITEIT_IDENTIFICATIES)
  private List<String> gerelateerdeActiviteitIdentificaties = null;

  public static final String SERIALIZED_NAME_GROEP = "groep";
  @SerializedName(SERIALIZED_NAME_GROEP)
  private Activiteitengroep groep;

  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_JURIDISCHE_REGEL_VOOR_IEDEREEN_IDENTIFICATIES = "juridischeRegelVoorIedereenIdentificaties";
  @SerializedName(SERIALIZED_NAME_JURIDISCHE_REGEL_VOOR_IEDEREEN_IDENTIFICATIES)
  private List<String> juridischeRegelVoorIedereenIdentificaties = new ArrayList<>();

  public static final String SERIALIZED_NAME_LAATSTE_WIJZIGINGSDATUM = "laatsteWijzigingsdatum";
  @SerializedName(SERIALIZED_NAME_LAATSTE_WIJZIGINGSDATUM)
  private LocalDate laatsteWijzigingsdatum;

  public static final String SERIALIZED_NAME_NAAM = "naam";
  @SerializedName(SERIALIZED_NAME_NAAM)
  private String naam;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private ActiviteitLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private ActiviteitEmbedded embedded;


  public ActiviteitHal begindatum(LocalDate begindatum) {
    
    this.begindatum = begindatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum waarop de activiteit relevant werd.&lt;/p&gt;&lt;/body&gt;
   * @return begindatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum waarop de activiteit relevant werd.</p></body>")

  public LocalDate getBegindatum() {
    return begindatum;
  }


  public void setBegindatum(LocalDate begindatum) {
    this.begindatum = begindatum;
  }


  public ActiviteitHal bovenliggendeActiviteitIdentificatie(String bovenliggendeActiviteitIdentificatie) {
    
    this.bovenliggendeActiviteitIdentificatie = bovenliggendeActiviteitIdentificatie;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificatie datatype van Geonovum.&lt;/p&gt;&lt;/body&gt;
   * @return bovenliggendeActiviteitIdentificatie
  **/
  @ApiModelProperty(required = true, value = "<body><p>Identificatie datatype van Geonovum.</p></body>")

  public String getBovenliggendeActiviteitIdentificatie() {
    return bovenliggendeActiviteitIdentificatie;
  }


  public void setBovenliggendeActiviteitIdentificatie(String bovenliggendeActiviteitIdentificatie) {
    this.bovenliggendeActiviteitIdentificatie = bovenliggendeActiviteitIdentificatie;
  }


  public ActiviteitHal einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum vanaf waarop de activiteit niet meer relevant was.&lt;/p&gt;&lt;/body&gt;
   * @return einddatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum vanaf waarop de activiteit niet meer relevant was.</p></body>")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public ActiviteitHal gerelateerdeActiviteitIdentificaties(List<String> gerelateerdeActiviteitIdentificaties) {
    
    this.gerelateerdeActiviteitIdentificaties = gerelateerdeActiviteitIdentificaties;
    return this;
  }

  public ActiviteitHal addGerelateerdeActiviteitIdentificatiesItem(String gerelateerdeActiviteitIdentificatiesItem) {
    if (this.gerelateerdeActiviteitIdentificaties == null) {
      this.gerelateerdeActiviteitIdentificaties = new ArrayList<>();
    }
    this.gerelateerdeActiviteitIdentificaties.add(gerelateerdeActiviteitIdentificatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificatie van de gerelateerde activiteiten.&lt;/p&gt;&lt;/body&gt;
   * @return gerelateerdeActiviteitIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Identificatie van de gerelateerde activiteiten.</p></body>")

  public List<String> getGerelateerdeActiviteitIdentificaties() {
    return gerelateerdeActiviteitIdentificaties;
  }


  public void setGerelateerdeActiviteitIdentificaties(List<String> gerelateerdeActiviteitIdentificaties) {
    this.gerelateerdeActiviteitIdentificaties = gerelateerdeActiviteitIdentificaties;
  }


  public ActiviteitHal groep(Activiteitengroep groep) {
    
    this.groep = groep;
    return this;
  }

   /**
   * Get groep
   * @return groep
  **/
  @ApiModelProperty(required = true, value = "")

  public Activiteitengroep getGroep() {
    return groep;
  }


  public void setGroep(Activiteitengroep groep) {
    this.groep = groep;
  }


  public ActiviteitHal identificatie(String identificatie) {
    
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


  public ActiviteitHal juridischeRegelVoorIedereenIdentificaties(List<String> juridischeRegelVoorIedereenIdentificaties) {
    
    this.juridischeRegelVoorIedereenIdentificaties = juridischeRegelVoorIedereenIdentificaties;
    return this;
  }

  public ActiviteitHal addJuridischeRegelVoorIedereenIdentificatiesItem(String juridischeRegelVoorIedereenIdentificatiesItem) {
    this.juridischeRegelVoorIedereenIdentificaties.add(juridischeRegelVoorIedereenIdentificatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificatie van de met de activiteit gerelateerde juridischeRegelsVoorIedereen.&lt;/p&gt;&lt;/body&gt;
   * @return juridischeRegelVoorIedereenIdentificaties
  **/
  @ApiModelProperty(required = true, value = "<body><p>Identificatie van de met de activiteit gerelateerde juridischeRegelsVoorIedereen.</p></body>")

  public List<String> getJuridischeRegelVoorIedereenIdentificaties() {
    return juridischeRegelVoorIedereenIdentificaties;
  }


  public void setJuridischeRegelVoorIedereenIdentificaties(List<String> juridischeRegelVoorIedereenIdentificaties) {
    this.juridischeRegelVoorIedereenIdentificaties = juridischeRegelVoorIedereenIdentificaties;
  }


  public ActiviteitHal laatsteWijzigingsdatum(LocalDate laatsteWijzigingsdatum) {
    
    this.laatsteWijzigingsdatum = laatsteWijzigingsdatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de activiteit.&lt;/p&gt;&lt;/body&gt;
   * @return laatsteWijzigingsdatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de activiteit.</p></body>")

  public LocalDate getLaatsteWijzigingsdatum() {
    return laatsteWijzigingsdatum;
  }


  public void setLaatsteWijzigingsdatum(LocalDate laatsteWijzigingsdatum) {
    this.laatsteWijzigingsdatum = laatsteWijzigingsdatum;
  }


  public ActiviteitHal naam(String naam) {
    
    this.naam = naam;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Een (korte) omschrijving van de activiteit.&lt;/p&gt;&lt;/body&gt;
   * @return naam
  **/
  @ApiModelProperty(required = true, value = "<body><p>Een (korte) omschrijving van de activiteit.</p></body>")

  public String getNaam() {
    return naam;
  }


  public void setNaam(String naam) {
    this.naam = naam;
  }


  public ActiviteitHal links(ActiviteitLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public ActiviteitLinks getLinks() {
    return links;
  }


  public void setLinks(ActiviteitLinks links) {
    this.links = links;
  }


  public ActiviteitHal embedded(ActiviteitEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public ActiviteitEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(ActiviteitEmbedded embedded) {
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
    ActiviteitHal activiteitHal = (ActiviteitHal) o;
    return Objects.equals(this.begindatum, activiteitHal.begindatum) &&
        Objects.equals(this.bovenliggendeActiviteitIdentificatie, activiteitHal.bovenliggendeActiviteitIdentificatie) &&
        Objects.equals(this.einddatum, activiteitHal.einddatum) &&
        Objects.equals(this.gerelateerdeActiviteitIdentificaties, activiteitHal.gerelateerdeActiviteitIdentificaties) &&
        Objects.equals(this.groep, activiteitHal.groep) &&
        Objects.equals(this.identificatie, activiteitHal.identificatie) &&
        Objects.equals(this.juridischeRegelVoorIedereenIdentificaties, activiteitHal.juridischeRegelVoorIedereenIdentificaties) &&
        Objects.equals(this.laatsteWijzigingsdatum, activiteitHal.laatsteWijzigingsdatum) &&
        Objects.equals(this.naam, activiteitHal.naam) &&
        Objects.equals(this.links, activiteitHal.links) &&
        Objects.equals(this.embedded, activiteitHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(begindatum, bovenliggendeActiviteitIdentificatie, einddatum, gerelateerdeActiviteitIdentificaties, groep, identificatie, juridischeRegelVoorIedereenIdentificaties, laatsteWijzigingsdatum, naam, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ActiviteitHal {\n");
    sb.append("    begindatum: ").append(toIndentedString(begindatum)).append("\n");
    sb.append("    bovenliggendeActiviteitIdentificatie: ").append(toIndentedString(bovenliggendeActiviteitIdentificatie)).append("\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
    sb.append("    gerelateerdeActiviteitIdentificaties: ").append(toIndentedString(gerelateerdeActiviteitIdentificaties)).append("\n");
    sb.append("    groep: ").append(toIndentedString(groep)).append("\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    juridischeRegelVoorIedereenIdentificaties: ").append(toIndentedString(juridischeRegelVoorIedereenIdentificaties)).append("\n");
    sb.append("    laatsteWijzigingsdatum: ").append(toIndentedString(laatsteWijzigingsdatum)).append("\n");
    sb.append("    naam: ").append(toIndentedString(naam)).append("\n");
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

