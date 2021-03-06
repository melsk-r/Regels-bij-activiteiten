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
import org.openapitools.client.model.GeoJSONGeometrie;
import org.openapitools.client.model.Locatie;
import org.openapitools.client.model.LocatieHalAllOf;
import org.openapitools.client.model.LocatieLinks;
import org.openapitools.client.model.LocatieType;

/**
 * LocatieHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class LocatieHal {
  public static final String SERIALIZED_NAME_BEGINDATUM = "begindatum";
  @SerializedName(SERIALIZED_NAME_BEGINDATUM)
  private LocalDate begindatum;

  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_GEOMETRIE = "geometrie";
  @SerializedName(SERIALIZED_NAME_GEOMETRIE)
  private GeoJSONGeometrie geometrie;

  public static final String SERIALIZED_NAME_GEOMETRIE_BRON = "geometrieBron";
  @SerializedName(SERIALIZED_NAME_GEOMETRIE_BRON)
  private String geometrieBron;

  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_NOEMER = "noemer";
  @SerializedName(SERIALIZED_NAME_NOEMER)
  private String noemer;

  public static final String SERIALIZED_NAME_OMVATTENDE_LOCATIE_IDENTIFICATIES = "omvattendeLocatieIdentificaties";
  @SerializedName(SERIALIZED_NAME_OMVATTENDE_LOCATIE_IDENTIFICATIES)
  private List<String> omvattendeLocatieIdentificaties = null;

  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private LocatieType type;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private LocatieLinks links;


  public LocatieHal begindatum(LocalDate begindatum) {
    
    this.begindatum = begindatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum waarop de locatie relevant werd.&lt;/p&gt;&lt;/body&gt;
   * @return begindatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum waarop de locatie relevant werd.</p></body>")

  public LocalDate getBegindatum() {
    return begindatum;
  }


  public void setBegindatum(LocalDate begindatum) {
    this.begindatum = begindatum;
  }


  public LocatieHal einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Datum vanaf waarop de locatie niet meer relevant was.&lt;/p&gt;&lt;/body&gt;
   * @return einddatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Datum vanaf waarop de locatie niet meer relevant was.</p></body>")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public LocatieHal geometrie(GeoJSONGeometrie geometrie) {
    
    this.geometrie = geometrie;
    return this;
  }

   /**
   * Get geometrie
   * @return geometrie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public GeoJSONGeometrie getGeometrie() {
    return geometrie;
  }


  public void setGeometrie(GeoJSONGeometrie geometrie) {
    this.geometrie = geometrie;
  }


  public LocatieHal geometrieBron(String geometrieBron) {
    
    this.geometrieBron = geometrieBron;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.&lt;/p&gt;&lt;/body&gt;
   * @return geometrieBron
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body>")

  public String getGeometrieBron() {
    return geometrieBron;
  }


  public void setGeometrieBron(String geometrieBron) {
    this.geometrieBron = geometrieBron;
  }


  public LocatieHal identificatie(String identificatie) {
    
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


  public LocatieHal noemer(String noemer) {
    
    this.noemer = noemer;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals &#39;Het Koninkrijk der Nederlanden&#39; of gemeente &#39;Amersfoort&#39;. Bijvoorbeeld een natuurgebied zoals de &#39;Veluwe&#39; of de rivier de &#39;Rijn&#39; of het centrum van een woonplaats &#39;centrum Apeldoorn&#39;.&lt;/p&gt;&lt;/body&gt;
   * @return noemer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.</p></body><body><p>Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals 'Het Koninkrijk der Nederlanden' of gemeente 'Amersfoort'. Bijvoorbeeld een natuurgebied zoals de 'Veluwe' of de rivier de 'Rijn' of het centrum van een woonplaats 'centrum Apeldoorn'.</p></body>")

  public String getNoemer() {
    return noemer;
  }


  public void setNoemer(String noemer) {
    this.noemer = noemer;
  }


  public LocatieHal omvattendeLocatieIdentificaties(List<String> omvattendeLocatieIdentificaties) {
    
    this.omvattendeLocatieIdentificaties = omvattendeLocatieIdentificaties;
    return this;
  }

  public LocatieHal addOmvattendeLocatieIdentificatiesItem(String omvattendeLocatieIdentificatiesItem) {
    if (this.omvattendeLocatieIdentificaties == null) {
      this.omvattendeLocatieIdentificaties = new ArrayList<>();
    }
    this.omvattendeLocatieIdentificaties.add(omvattendeLocatieIdentificatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Identificatie van de omvattende locaties.&lt;/p&gt;&lt;/body&gt;
   * @return omvattendeLocatieIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Identificatie van de omvattende locaties.</p></body>")

  public List<String> getOmvattendeLocatieIdentificaties() {
    return omvattendeLocatieIdentificaties;
  }


  public void setOmvattendeLocatieIdentificaties(List<String> omvattendeLocatieIdentificaties) {
    this.omvattendeLocatieIdentificaties = omvattendeLocatieIdentificaties;
  }


  public LocatieHal type(LocatieType type) {
    
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @ApiModelProperty(required = true, value = "")

  public LocatieType getType() {
    return type;
  }


  public void setType(LocatieType type) {
    this.type = type;
  }


  public LocatieHal links(LocatieLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public LocatieLinks getLinks() {
    return links;
  }


  public void setLinks(LocatieLinks links) {
    this.links = links;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LocatieHal locatieHal = (LocatieHal) o;
    return Objects.equals(this.begindatum, locatieHal.begindatum) &&
        Objects.equals(this.einddatum, locatieHal.einddatum) &&
        Objects.equals(this.geometrie, locatieHal.geometrie) &&
        Objects.equals(this.geometrieBron, locatieHal.geometrieBron) &&
        Objects.equals(this.identificatie, locatieHal.identificatie) &&
        Objects.equals(this.noemer, locatieHal.noemer) &&
        Objects.equals(this.omvattendeLocatieIdentificaties, locatieHal.omvattendeLocatieIdentificaties) &&
        Objects.equals(this.type, locatieHal.type) &&
        Objects.equals(this.links, locatieHal.links);
  }

  @Override
  public int hashCode() {
    return Objects.hash(begindatum, einddatum, geometrie, geometrieBron, identificatie, noemer, omvattendeLocatieIdentificaties, type, links);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LocatieHal {\n");
    sb.append("    begindatum: ").append(toIndentedString(begindatum)).append("\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
    sb.append("    geometrie: ").append(toIndentedString(geometrie)).append("\n");
    sb.append("    geometrieBron: ").append(toIndentedString(geometrieBron)).append("\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    noemer: ").append(toIndentedString(noemer)).append("\n");
    sb.append("    omvattendeLocatieIdentificaties: ").append(toIndentedString(omvattendeLocatieIdentificaties)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
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

