/*
 * Plan SW - Toepasbare regel SW
 * Nog in te voorzien
 *
 * The version of the OpenAPI document: 0.0.1
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
import org.openapitools.client.model.HalLink;

/**
 * LocatieLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T09:19:26.366Z[Etc/UTC]")
public class LocatieLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_OMVATTENDE_LOCATIES = "omvattendeLocaties";
  @SerializedName(SERIALIZED_NAME_OMVATTENDE_LOCATIES)
  private List<HalLink> omvattendeLocaties = null;


  public LocatieLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public LocatieLinks omvattendeLocaties(List<HalLink> omvattendeLocaties) {
    
    this.omvattendeLocaties = omvattendeLocaties;
    return this;
  }

  public LocatieLinks addOmvattendeLocatiesItem(HalLink omvattendeLocatiesItem) {
    if (this.omvattendeLocaties == null) {
      this.omvattendeLocaties = new ArrayList<>();
    }
    this.omvattendeLocaties.add(omvattendeLocatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Een lijn van een lijnengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een punt van een puntengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een gebied van een gebiedengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Deze relatie mag alleen lopen van een locatie van het type:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;puntengroep&lt;/li&gt;&lt;li&gt;lijnengroep&lt;/li&gt;&lt;li&gt;gebiedengroep&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;in dat geval mag deze dan ook alleen lopen naar resp. een punt, een lijn en een gebied.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
   * @return omvattendeLocaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Een lijn van een lijnengroep.</p></body><body><p>Een punt van een puntengroep.</p></body><body><p>Een gebied van een gebiedengroep.</p></body><body><p>Deze relatie mag alleen lopen van een locatie van het type:</p><ul><li>puntengroep</li><li>lijnengroep</li><li>gebiedengroep</li></ul><p>in dat geval mag deze dan ook alleen lopen naar resp. een punt, een lijn en een gebied.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body>")

  public List<HalLink> getOmvattendeLocaties() {
    return omvattendeLocaties;
  }


  public void setOmvattendeLocaties(List<HalLink> omvattendeLocaties) {
    this.omvattendeLocaties = omvattendeLocaties;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LocatieLinks locatieLinks = (LocatieLinks) o;
    return Objects.equals(this.self, locatieLinks.self) &&
        Objects.equals(this.omvattendeLocaties, locatieLinks.omvattendeLocaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, omvattendeLocaties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LocatieLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    omvattendeLocaties: ").append(toIndentedString(omvattendeLocaties)).append("\n");
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
