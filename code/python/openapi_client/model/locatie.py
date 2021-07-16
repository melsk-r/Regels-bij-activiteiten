"""
    Regels bij activiteiten

    <body><p>Deze API maakt het mogelijk om gegevens op te vragen, bij een applicatie die invulling geeft aan de Omgevingswetbeleidcomponent, ook wel aangeduid als plansoftware, over (Omgevingswet-)activiteiten en/of (bijbehorende) juridische regels, regelteksten en locaties.</p></body>  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: robert.melskens@vng.nl
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
)
from ..model_utils import OpenApiModel
from openapi_client.exceptions import ApiAttributeError


def lazy_import():
    from openapi_client.model.geo_json_geometrie import GeoJSONGeometrie
    from openapi_client.model.identificatie import Identificatie
    from openapi_client.model.locatie_type import LocatieType
    globals()['GeoJSONGeometrie'] = GeoJSONGeometrie
    globals()['Identificatie'] = Identificatie
    globals()['LocatieType'] = LocatieType


class Locatie(ModelNormal):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
    }

    validations = {
        ('omvattende_locatie_identificaties',): {
            'min_items': 0,
        },
    }

    @cached_property
    def additional_properties_type():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded
        """
        lazy_import()
        return (bool, date, datetime, dict, float, int, list, str, none_type,)  # noqa: E501

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        lazy_import()
        return {
            'identificatie': (Identificatie,),  # noqa: E501
            'type': (LocatieType,),  # noqa: E501
            'begindatum': (date,),  # noqa: E501
            'einddatum': (date,),  # noqa: E501
            'geometrie': (GeoJSONGeometrie,),  # noqa: E501
            'geometrie_bron': (str,),  # noqa: E501
            'noemer': (str,),  # noqa: E501
            'omvattende_locatie_identificaties': ([Identificatie],),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'identificatie': 'identificatie',  # noqa: E501
        'type': 'type',  # noqa: E501
        'begindatum': 'begindatum',  # noqa: E501
        'einddatum': 'einddatum',  # noqa: E501
        'geometrie': 'geometrie',  # noqa: E501
        'geometrie_bron': 'geometrieBron',  # noqa: E501
        'noemer': 'noemer',  # noqa: E501
        'omvattende_locatie_identificaties': 'omvattendeLocatieIdentificaties',  # noqa: E501
    }

    read_only_vars = {
    }

    _composed_schemas = {}

    @classmethod
    @convert_js_args_to_python_args
    def _from_openapi_data(cls, identificatie, type, *args, **kwargs):  # noqa: E501
        """Locatie - a model defined in OpenAPI

        Args:
            identificatie (Identificatie):
            type (LocatieType):

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            begindatum (date): <body><p>Datum waarop de locatie relevant werd.</p></body>. [optional]  # noqa: E501
            einddatum (date): <body><p>Datum vanaf waarop de locatie niet meer relevant was.</p></body>. [optional]  # noqa: E501
            geometrie (GeoJSONGeometrie): [optional]  # noqa: E501
            geometrie_bron (str): <body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body>. [optional]  # noqa: E501
            noemer (str): <body><p>Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.</p></body><body><p>Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals 'Het Koninkrijk der Nederlanden' of gemeente 'Amersfoort'. Bijvoorbeeld een natuurgebied zoals de 'Veluwe' of de rivier de 'Rijn' of het centrum van een woonplaats 'centrum Apeldoorn'.</p></body>. [optional]  # noqa: E501
            omvattende_locatie_identificaties ([Identificatie]): <body><p>Identificatie van de omvattende locaties.</p></body>. [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        self = super(OpenApiModel, cls).__new__(cls)

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        self.identificatie = identificatie
        self.type = type
        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
        return self

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
    ])

    @convert_js_args_to_python_args
    def __init__(self, identificatie, type, *args, **kwargs):  # noqa: E501
        """Locatie - a model defined in OpenAPI

        Args:
            identificatie (Identificatie):
            type (LocatieType):

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            begindatum (date): <body><p>Datum waarop de locatie relevant werd.</p></body>. [optional]  # noqa: E501
            einddatum (date): <body><p>Datum vanaf waarop de locatie niet meer relevant was.</p></body>. [optional]  # noqa: E501
            geometrie (GeoJSONGeometrie): [optional]  # noqa: E501
            geometrie_bron (str): <body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body><body><p>De bron die is gebruikt voor, dan wel de wijze van inwinning van de geometrie.</p></body>. [optional]  # noqa: E501
            noemer (str): <body><p>Tekstuele beschrijving van een Locatie, zodat er als zodanig over deze locatie gesproken kan worden. De beschrijving kan een bepaalde naam zijn waaronder de Locatie bekend staat, maar (lang) niet elke Locatie heef een naam.</p></body><body><p>Bijvoorbeeld het hele werkingsgebied van bevoegd gezag, zoals 'Het Koninkrijk der Nederlanden' of gemeente 'Amersfoort'. Bijvoorbeeld een natuurgebied zoals de 'Veluwe' of de rivier de 'Rijn' of het centrum van een woonplaats 'centrum Apeldoorn'.</p></body>. [optional]  # noqa: E501
            omvattende_locatie_identificaties ([Identificatie]): <body><p>Identificatie van de omvattende locaties.</p></body>. [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        self.identificatie = identificatie
        self.type = type
        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
            if var_name in self.read_only_vars:
                raise ApiAttributeError(f"`{var_name}` is a read-only attribute. Use `from_openapi_data` to instantiate "
                                     f"class with read only attributes.")
