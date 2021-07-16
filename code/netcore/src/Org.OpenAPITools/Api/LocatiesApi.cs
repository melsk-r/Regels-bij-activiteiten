/*
 * Regels bij activiteiten
 *
 * <body><p>Deze API maakt het mogelijk om gegevens op te vragen, bij een applicatie die invulling geeft aan de Omgevingswetbeleidcomponent, ook wel aangeduid als plansoftware, over (Omgevingswet-)activiteiten en/of (bijbehorende) juridische regels, regelteksten en locaties.</p></body>
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: robert.melskens@vng.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocatiesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <returns>LocatieHal</returns>
        LocatieHal Getlocatie(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <returns>ApiResponse of LocatieHal</returns>
        ApiResponse<LocatieHal> GetlocatieWithHttpInfo(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <returns>LocatieHalCollectie</returns>
        LocatieHalCollectie Getlocaties(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <returns>ApiResponse of LocatieHalCollectie</returns>
        ApiResponse<LocatieHalCollectie> GetlocatiesWithHttpInfo(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocatiesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LocatieHal</returns>
        System.Threading.Tasks.Task<LocatieHal> GetlocatieAsync(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LocatieHal)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocatieHal>> GetlocatieWithHttpInfoAsync(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LocatieHalCollectie</returns>
        System.Threading.Tasks.Task<LocatieHalCollectie> GetlocatiesAsync(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LocatieHalCollectie)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocatieHalCollectie>> GetlocatiesWithHttpInfoAsync(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocatiesApi : ILocatiesApiSync, ILocatiesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocatiesApi : ILocatiesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocatiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocatiesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocatiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocatiesApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocatiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocatiesApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocatiesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LocatiesApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <returns>LocatieHal</returns>
        public LocatieHal Getlocatie(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?))
        {
            Org.OpenAPITools.Client.ApiResponse<LocatieHal> localVarResponse = GetlocatieWithHttpInfo(identificatie, acceptCrs);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <returns>ApiResponse of LocatieHal</returns>
        public Org.OpenAPITools.Client.ApiResponse<LocatieHal> GetlocatieWithHttpInfo(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?))
        {
            // verify the required parameter 'identificatie' is set
            if (identificatie == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'identificatie' when calling LocatiesApi->Getlocatie");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("identificatie", Org.OpenAPITools.Client.ClientUtils.ParameterToString(identificatie)); // path parameter
            if (acceptCrs != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Crs", Org.OpenAPITools.Client.ClientUtils.ParameterToString(acceptCrs)); // header parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<LocatieHal>("/locaties/{identificatie}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getlocatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LocatieHal</returns>
        public async System.Threading.Tasks.Task<LocatieHal> GetlocatieAsync(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<LocatieHal> localVarResponse = await GetlocatieWithHttpInfoAsync(identificatie, acceptCrs, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identificatie">&lt;body&gt;&lt;p&gt;De unieke identificatie van de locatie.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;De verzameling van waarden die gegevens van dit attribuutsoort kunnen hebben, dat wil zeggen het waardenbereik, uitgedrukt in een specifieke structuur.&lt;/p&gt;&lt;/body&gt;</param>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LocatieHal)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<LocatieHal>> GetlocatieWithHttpInfoAsync(string identificatie, CrsEnum? acceptCrs = default(CrsEnum?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'identificatie' is set
            if (identificatie == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'identificatie' when calling LocatiesApi->Getlocatie");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("identificatie", Org.OpenAPITools.Client.ClientUtils.ParameterToString(identificatie)); // path parameter
            if (acceptCrs != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Crs", Org.OpenAPITools.Client.ClientUtils.ParameterToString(acceptCrs)); // header parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<LocatieHal>("/locaties/{identificatie}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getlocatie", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <returns>LocatieHalCollectie</returns>
        public LocatieHalCollectie Getlocaties(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<LocatieHalCollectie> localVarResponse = GetlocatiesWithHttpInfo(acceptCrs, page, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <returns>ApiResponse of LocatieHalCollectie</returns>
        public Org.OpenAPITools.Client.ApiResponse<LocatieHalCollectie> GetlocatiesWithHttpInfo(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }
            if (acceptCrs != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Crs", Org.OpenAPITools.Client.ClientUtils.ParameterToString(acceptCrs)); // header parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<LocatieHalCollectie>("/locaties", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getlocaties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LocatieHalCollectie</returns>
        public async System.Threading.Tasks.Task<LocatieHalCollectie> GetlocatiesAsync(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<LocatieHalCollectie> localVarResponse = await GetlocatiesWithHttpInfoAsync(acceptCrs, page, pageSize, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;body&gt;&lt;p&gt;Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptCrs">Gewenste CRS van de coördinaten in de response. (optional)</param>
        /// <param name="page">Een pagina binnen de gepagineerde resultatenset. (optional)</param>
        /// <param name="pageSize"> (optional, default to 20)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LocatieHalCollectie)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<LocatieHalCollectie>> GetlocatiesWithHttpInfoAsync(CrsEnum? acceptCrs = default(CrsEnum?), int? page = default(int?), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/hal+json",
                "application/problem+json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }
            if (acceptCrs != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Crs", Org.OpenAPITools.Client.ClientUtils.ParameterToString(acceptCrs)); // header parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<LocatieHalCollectie>("/locaties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Getlocaties", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
