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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.JuridischeRegelVoorIedereenHal;

/**
 * JuridischeRegelVoorIedereenHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class JuridischeRegelVoorIedereenHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_JURIDISCHEREGELSVOORIEDEREEN = "juridischeregelsvooriedereen";
  @SerializedName(SERIALIZED_NAME_JURIDISCHEREGELSVOORIEDEREEN)
  private List<JuridischeRegelVoorIedereenHal> juridischeregelsvooriedereen = null;


  public JuridischeRegelVoorIedereenHalCollectieEmbedded juridischeregelsvooriedereen(List<JuridischeRegelVoorIedereenHal> juridischeregelsvooriedereen) {
    
    this.juridischeregelsvooriedereen = juridischeregelsvooriedereen;
    return this;
  }

  public JuridischeRegelVoorIedereenHalCollectieEmbedded addJuridischeregelsvooriedereenItem(JuridischeRegelVoorIedereenHal juridischeregelsvooriedereenItem) {
    if (this.juridischeregelsvooriedereen == null) {
      this.juridischeregelsvooriedereen = new ArrayList<>();
    }
    this.juridischeregelsvooriedereen.add(juridischeregelsvooriedereenItem);
    return this;
  }

   /**
   * Get juridischeregelsvooriedereen
   * @return juridischeregelsvooriedereen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<JuridischeRegelVoorIedereenHal> getJuridischeregelsvooriedereen() {
    return juridischeregelsvooriedereen;
  }


  public void setJuridischeregelsvooriedereen(List<JuridischeRegelVoorIedereenHal> juridischeregelsvooriedereen) {
    this.juridischeregelsvooriedereen = juridischeregelsvooriedereen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JuridischeRegelVoorIedereenHalCollectieEmbedded juridischeRegelVoorIedereenHalCollectieEmbedded = (JuridischeRegelVoorIedereenHalCollectieEmbedded) o;
    return Objects.equals(this.juridischeregelsvooriedereen, juridischeRegelVoorIedereenHalCollectieEmbedded.juridischeregelsvooriedereen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(juridischeregelsvooriedereen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JuridischeRegelVoorIedereenHalCollectieEmbedded {\n");
    sb.append("    juridischeregelsvooriedereen: ").append(toIndentedString(juridischeregelsvooriedereen)).append("\n");
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

