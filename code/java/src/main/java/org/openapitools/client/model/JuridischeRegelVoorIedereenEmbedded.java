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
import org.openapitools.client.model.LocatieHal;
import org.openapitools.client.model.RegeltekstHal;

/**
 * JuridischeRegelVoorIedereenEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class JuridischeRegelVoorIedereenEmbedded {
  public static final String SERIALIZED_NAME_GEDEFINIEERDE_LOCATIES = "gedefinieerdeLocaties";
  @SerializedName(SERIALIZED_NAME_GEDEFINIEERDE_LOCATIES)
  private List<LocatieHal> gedefinieerdeLocaties = null;

  public static final String SERIALIZED_NAME_REGELTEKST = "regeltekst";
  @SerializedName(SERIALIZED_NAME_REGELTEKST)
  private RegeltekstHal regeltekst;


  public JuridischeRegelVoorIedereenEmbedded gedefinieerdeLocaties(List<LocatieHal> gedefinieerdeLocaties) {
    
    this.gedefinieerdeLocaties = gedefinieerdeLocaties;
    return this;
  }

  public JuridischeRegelVoorIedereenEmbedded addGedefinieerdeLocatiesItem(LocatieHal gedefinieerdeLocatiesItem) {
    if (this.gedefinieerdeLocaties == null) {
      this.gedefinieerdeLocaties = new ArrayList<>();
    }
    this.gedefinieerdeLocaties.add(gedefinieerdeLocatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;
   * @return gedefinieerdeLocaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.</p></body>")

  public List<LocatieHal> getGedefinieerdeLocaties() {
    return gedefinieerdeLocaties;
  }


  public void setGedefinieerdeLocaties(List<LocatieHal> gedefinieerdeLocaties) {
    this.gedefinieerdeLocaties = gedefinieerdeLocaties;
  }


  public JuridischeRegelVoorIedereenEmbedded regeltekst(RegeltekstHal regeltekst) {
    
    this.regeltekst = regeltekst;
    return this;
  }

   /**
   * Get regeltekst
   * @return regeltekst
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RegeltekstHal getRegeltekst() {
    return regeltekst;
  }


  public void setRegeltekst(RegeltekstHal regeltekst) {
    this.regeltekst = regeltekst;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JuridischeRegelVoorIedereenEmbedded juridischeRegelVoorIedereenEmbedded = (JuridischeRegelVoorIedereenEmbedded) o;
    return Objects.equals(this.gedefinieerdeLocaties, juridischeRegelVoorIedereenEmbedded.gedefinieerdeLocaties) &&
        Objects.equals(this.regeltekst, juridischeRegelVoorIedereenEmbedded.regeltekst);
  }

  @Override
  public int hashCode() {
    return Objects.hash(gedefinieerdeLocaties, regeltekst);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JuridischeRegelVoorIedereenEmbedded {\n");
    sb.append("    gedefinieerdeLocaties: ").append(toIndentedString(gedefinieerdeLocaties)).append("\n");
    sb.append("    regeltekst: ").append(toIndentedString(regeltekst)).append("\n");
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

