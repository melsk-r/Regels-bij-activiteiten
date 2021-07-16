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
import org.openapitools.client.model.HalPaginationLinks;
import org.openapitools.client.model.RegeltekstHalCollectieEmbedded;

/**
 * RegeltekstHalCollectie
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class RegeltekstHalCollectie {
  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private HalPaginationLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private RegeltekstHalCollectieEmbedded embedded;


  public RegeltekstHalCollectie links(HalPaginationLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalPaginationLinks getLinks() {
    return links;
  }


  public void setLinks(HalPaginationLinks links) {
    this.links = links;
  }


  public RegeltekstHalCollectie embedded(RegeltekstHalCollectieEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RegeltekstHalCollectieEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(RegeltekstHalCollectieEmbedded embedded) {
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
    RegeltekstHalCollectie regeltekstHalCollectie = (RegeltekstHalCollectie) o;
    return Objects.equals(this.links, regeltekstHalCollectie.links) &&
        Objects.equals(this.embedded, regeltekstHalCollectie.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RegeltekstHalCollectie {\n");
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

