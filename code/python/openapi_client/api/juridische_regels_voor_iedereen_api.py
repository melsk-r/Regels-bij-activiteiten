"""
    Regels bij activiteiten

    <body><p>Deze API maakt het mogelijk om gegevens op te vragen, bij een applicatie die invulling geeft aan de Omgevingswetbeleidcomponent, ook wel aangeduid als plansoftware, over (Omgevingswet-)activiteiten en/of (bijbehorende) juridische regels, regelteksten en locaties.</p></body>  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: robert.melskens@vng.nl
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.api_client import ApiClient, Endpoint as _Endpoint
from openapi_client.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from openapi_client.model.bad_request_foutbericht import BadRequestFoutbericht
from openapi_client.model.crs_enum import CrsEnum
from openapi_client.model.foutbericht import Foutbericht
from openapi_client.model.identificatie import Identificatie
from openapi_client.model.juridische_regel_voor_iedereen_hal import JuridischeRegelVoorIedereenHal
from openapi_client.model.juridische_regel_voor_iedereen_hal_collectie import JuridischeRegelVoorIedereenHalCollectie


class JuridischeRegelsVoorIedereenApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

        def __getjuridische_regel_voor_iedereen(
            self,
            identificatie,
            **kwargs
        ):
            """getjuridische_regel_voor_iedereen  # noqa: E501

            <body><p>Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert. I.h.k.v. deze API zijn alleen juridische regels die minimaal één activiteit bevatten van belang.</p></body>  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.getjuridische_regel_voor_iedereen(identificatie, async_req=True)
            >>> result = thread.get()

            Args:
                identificatie (Identificatie): <body><p>De unieke identificatie van de juridischeRegelVoorIedereen.</p></body><body><p>De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.</p></body>

            Keyword Args:
                accept_crs (CrsEnum): Gewenste CRS van de coördinaten in de response.. [optional]
                expand (str): Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature).. [optional]
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (int/float/tuple): timeout setting for this request. If
                    one number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                JuridischeRegelVoorIedereenHal
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['identificatie'] = \
                identificatie
            return self.call_with_http_info(**kwargs)

        self.getjuridische_regel_voor_iedereen = _Endpoint(
            settings={
                'response_type': (JuridischeRegelVoorIedereenHal,),
                'auth': [],
                'endpoint_path': '/juridischeregelsvooriedereen/{identificatie}',
                'operation_id': 'getjuridische_regel_voor_iedereen',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'identificatie',
                    'accept_crs',
                    'expand',
                ],
                'required': [
                    'identificatie',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'identificatie':
                        (Identificatie,),
                    'accept_crs':
                        (CrsEnum,),
                    'expand':
                        (str,),
                },
                'attribute_map': {
                    'identificatie': 'identificatie',
                    'accept_crs': 'Accept-Crs',
                    'expand': 'expand',
                },
                'location_map': {
                    'identificatie': 'path',
                    'accept_crs': 'header',
                    'expand': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__getjuridische_regel_voor_iedereen
        )

        def __getjuridische_regels_voor_iedereen(
            self,
            **kwargs
        ):
            """getjuridische_regels_voor_iedereen  # noqa: E501

            <body><p>Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert. I.h.k.v. deze API zijn alleen juridische regels die minimaal één activiteit bevatten van belang.</p></body>  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.getjuridische_regels_voor_iedereen(async_req=True)
            >>> result = thread.get()


            Keyword Args:
                accept_crs (CrsEnum): Gewenste CRS van de coördinaten in de response.. [optional]
                page (int): Een pagina binnen de gepagineerde resultatenset.. [optional]
                expand (str): Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature).. [optional]
                page_size (int): [optional] if omitted the server will use the default value of 20
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (int/float/tuple): timeout setting for this request. If
                    one number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                JuridischeRegelVoorIedereenHalCollectie
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            return self.call_with_http_info(**kwargs)

        self.getjuridische_regels_voor_iedereen = _Endpoint(
            settings={
                'response_type': (JuridischeRegelVoorIedereenHalCollectie,),
                'auth': [],
                'endpoint_path': '/juridischeregelsvooriedereen',
                'operation_id': 'getjuridische_regels_voor_iedereen',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'accept_crs',
                    'page',
                    'expand',
                    'page_size',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'page',
                    'page_size',
                ]
            },
            root_map={
                'validations': {
                    ('page',): {

                        'inclusive_minimum': 1,
                    },
                    ('page_size',): {

                        'inclusive_maximum': 100,
                        'inclusive_minimum': 1,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'accept_crs':
                        (CrsEnum,),
                    'page':
                        (int,),
                    'expand':
                        (str,),
                    'page_size':
                        (int,),
                },
                'attribute_map': {
                    'accept_crs': 'Accept-Crs',
                    'page': 'page',
                    'expand': 'expand',
                    'page_size': 'pageSize',
                },
                'location_map': {
                    'accept_crs': 'header',
                    'page': 'query',
                    'expand': 'query',
                    'page_size': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__getjuridische_regels_voor_iedereen
        )
