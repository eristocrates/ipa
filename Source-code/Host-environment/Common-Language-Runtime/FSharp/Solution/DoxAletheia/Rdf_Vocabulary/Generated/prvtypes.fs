namespace http.purl.org.net.provenance.types.hash

open DoxAletheia.Rdf_Vocabulary

module prvtypes =
    let _namespace_name = "http://purl.org/net/provenance/types#"

    /// <summary>
    /// DataAccessor is a concept that represents a system (i.e. a non-human agent) which performed the data access in order to retrieve an information resource from the Web.
    /// <see href="http://purl.org/net/provenance/types#DataAccessor"></see></summary>
    let DataAccessor =
        Namespaced_IRI.parse _namespace_name "DataAccessor" |> NamespacedName

    /// <summary>
    /// DataCreatingDevice is a concept that represents a device which performed the creation of a data item. Examples for data creating devices are sensors.
    /// <see href="http://purl.org/net/provenance/types#DataCreatingDevice"></see></summary>
    let DataCreatingDevice =
        Namespaced_IRI.parse _namespace_name "DataCreatingDevice" |> NamespacedName

    /// <summary>
    /// DataCreator is a concept that represents an agent which performed the creation of a data item.
    /// <see href="http://purl.org/net/provenance/types#DataCreator"></see></summary>
    let DataCreator =
        Namespaced_IRI.parse _namespace_name "DataCreator" |> NamespacedName

    /// <summary>
    /// DataCreatingService is a concept that represents a software service which performed the creation of a data item. Examples for data creating services are reasoners, query engines, and workflow engines.
    /// <see href="http://purl.org/net/provenance/types#DataCreatingService"></see></summary>
    let DataCreatingService =
        Namespaced_IRI.parse _namespace_name "DataCreatingService" |> NamespacedName

    /// <summary>
    /// DataCreatingEntity is a concept that represents a human agent who performed the creation of a data item, either directly or by being responsible for a non-human data creator (see the concepts prvTypes:DataCreatingService and prvTypes:DataCreatingDevice).
    /// <see href="http://purl.org/net/provenance/types#DataCreatingEntity"></see></summary>
    let DataCreatingEntity =
        Namespaced_IRI.parse _namespace_name "DataCreatingEntity" |> NamespacedName

    /// <summary>
    /// An HTTPBasedDataAccess represents the completed execution of accessing a data item using the HTTP protocol.
    /// <see href="http://purl.org/net/provenance/types#HTTPBasedDataAccess"></see></summary>
    let HTTPBasedDataAccess =
        Namespaced_IRI.parse _namespace_name "HTTPBasedDataAccess" |> NamespacedName

    /// <summary>
    /// Measurement is a concept that represents the execution of a measurement.
    /// <see href="http://purl.org/net/provenance/types#Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#QueryExecution"></see>
    /// </summary>
    let QueryExecution =
        Namespaced_IRI.parse _namespace_name "QueryExecution" |> NamespacedName

    /// <summary>
    /// QueryResult is the result of a query execution.
    /// <see href="http://purl.org/net/provenance/types#QueryResult"></see></summary>
    let QueryResult =
        Namespaced_IRI.parse _namespace_name "QueryResult" |> NamespacedName

    /// <summary>
    /// A QueryTemplate is a query that contains placeholders which are replaced by actual data to create an executable query.
    /// <see href="http://purl.org/net/provenance/types#QueryTemplate"></see></summary>
    let QueryTemplate =
        Namespaced_IRI.parse _namespace_name "QueryTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#SPARQLQuery"></see>
    /// </summary>
    let SPARQLQuery =
        Namespaced_IRI.parse _namespace_name "SPARQLQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#SQLQuery"></see>
    /// </summary>
    let SQLQuery = Namespaced_IRI.parse _namespace_name "SQLQuery" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/provenance/types#Sensor"></see>
    /// </summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    /// TriplifyMapping is a concept that represents the mapping defined in a Triplify configuration file.
    /// <see href="http://purl.org/net/provenance/types#TriplifyMapping"></see></summary>
    let TriplifyMapping =
        Namespaced_IRI.parse _namespace_name "TriplifyMapping" |> NamespacedName

    /// <summary>
    /// This property refers to an HTTP message (request or response) that has been exchanged during an HTTP based data access.
    /// <see href="http://purl.org/net/provenance/types#exchangedHTTPMessage"></see></summary>
    let exchangedHTTPMessage =
        Namespaced_IRI.parse _namespace_name "exchangedHTTPMessage" |> NamespacedName
