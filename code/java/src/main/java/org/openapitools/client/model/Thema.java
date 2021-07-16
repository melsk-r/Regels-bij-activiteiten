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

/**
 * &lt;body&gt;&lt;p&gt;Een limitatieve lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.&lt;/p&gt;&lt;/body&gt;
 */
@ApiModel(description = "<body><p>Een limitatieve lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.</p></body>")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-07-16T14:41:30.043160Z[Etc/UTC]")
public class Thema {
  public static final String SERIALIZED_NAME_CODE = "code";
  @SerializedName(SERIALIZED_NAME_CODE)
  private String code;

  public static final String SERIALIZED_NAME_WAARDE = "waarde";
  @SerializedName(SERIALIZED_NAME_WAARDE)
  private String waarde;


  public Thema code(String code) {
    
    this.code = code;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Combinatie van tekens die het thema uniek duidt.&lt;/p&gt;&lt;/body&gt;
   * @return code
  **/
  @ApiModelProperty(required = true, value = "<body><p>Combinatie van tekens die het thema uniek duidt.</p></body>")

  public String getCode() {
    return code;
  }


  public void setCode(String code) {
    this.code = code;
  }


  public Thema waarde(String waarde) {
    
    this.waarde = waarde;
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De naam van het thema.&lt;/p&gt;&lt;/body&gt;
   * @return waarde
  **/
  @ApiModelProperty(required = true, value = "<body><p>De naam van het thema.</p></body>")

  public String getWaarde() {
    return waarde;
  }


  public void setWaarde(String waarde) {
    this.waarde = waarde;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Thema thema = (Thema) o;
    return Objects.equals(this.code, thema.code) &&
        Objects.equals(this.waarde, thema.waarde);
  }

  @Override
  public int hashCode() {
    return Objects.hash(code, waarde);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Thema {\n");
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    waarde: ").append(toIndentedString(waarde)).append("\n");
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

