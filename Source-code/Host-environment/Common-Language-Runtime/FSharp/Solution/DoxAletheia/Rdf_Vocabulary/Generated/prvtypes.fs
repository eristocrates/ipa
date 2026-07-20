namespace http.purl.org.net.provenance.types.hash

open DoxAletheia

module prvtypes =
    let _namespace_name = "http://purl.org/net/provenance/types#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// DataAccessor is a concept that represents a system (i.e. a non-human agent) which performed the data access in order to retrieve an information resource from the Web.
    /// <see href="http://purl.org/net/provenance/types#DataAccessor"></see></summary>
    let DataAccessor = _prefix "DataAccessor"
    /// <summary>
    /// DataCreatingDevice is a concept that represents a device which performed the creation of a data item. Examples for data creating devices are sensors.
    /// <see href="http://purl.org/net/provenance/types#DataCreatingDevice"></see></summary>
    let DataCreatingDevice = _prefix "DataCreatingDevice"
    /// <summary>
    /// DataCreator is a concept that represents an agent which performed the creation of a data item.
    /// <see href="http://purl.org/net/provenance/types#DataCreator"></see></summary>
    let DataCreator = _prefix "DataCreator"
    /// <summary>
    /// DataCreatingService is a concept that represents a software service which performed the creation of a data item. Examples for data creating services are reasoners, query engines, and workflow engines.
    /// <see href="http://purl.org/net/provenance/types#DataCreatingService"></see></summary>
    let DataCreatingService = _prefix "DataCreatingService"
    /// <summary>
    /// DataCreatingEntity is a concept that represents a human agent who performed the creation of a data item, either directly or by being responsible for a non-human data creator (see the concepts prvTypes:DataCreatingService and prvTypes:DataCreatingDevice).
    /// <see href="http://purl.org/net/provenance/types#DataCreatingEntity"></see></summary>
    let DataCreatingEntity = _prefix "DataCreatingEntity"
    /// <summary>
    /// An HTTPBasedDataAccess represents the completed execution of accessing a data item using the HTTP protocol.
    /// <see href="http://purl.org/net/provenance/types#HTTPBasedDataAccess"></see></summary>
    let HTTPBasedDataAccess = _prefix "HTTPBasedDataAccess"
    /// <summary>
    /// Measurement is a concept that represents the execution of a measurement.
    /// <see href="http://purl.org/net/provenance/types#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#QueryExecution"></see>
    /// </summary>
    let QueryExecution = _prefix "QueryExecution"
    /// <summary>
    /// QueryResult is the result of a query execution.
    /// <see href="http://purl.org/net/provenance/types#QueryResult"></see></summary>
    let QueryResult = _prefix "QueryResult"
    /// <summary>
    /// A QueryTemplate is a query that contains placeholders which are replaced by actual data to create an executable query.
    /// <see href="http://purl.org/net/provenance/types#QueryTemplate"></see></summary>
    let QueryTemplate = _prefix "QueryTemplate"
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#SPARQLQuery"></see>
    /// </summary>
    let SPARQLQuery = _prefix "SPARQLQuery"
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#SQLQuery"></see>
    /// </summary>
    let SQLQuery = _prefix "SQLQuery"
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// TriplifyMapping is a concept that represents the mapping defined in a Triplify configuration file.
    /// <see href="http://purl.org/net/provenance/types#TriplifyMapping"></see></summary>
    let TriplifyMapping = _prefix "TriplifyMapping"
    /// <summary>
    /// This property refers to an HTTP message (request or response) that has been exchanged during an HTTP based data access.
    /// <see href="http://purl.org/net/provenance/types#exchangedHTTPMessage"></see></summary>
    let exchangedHTTPMessage = _prefix "exchangedHTTPMessage"
