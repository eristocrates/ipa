namespace http.purl.org.net.provenance.types.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prvtypes =
    let _namespace_iri = Namespace_Iri prvtypes |> NamespaceIRI
    /// <summary>
    ///   <para>prvtypes:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/provenance/types#">http://purl.org/net/provenance/types#</seealso>
    let _prefix_iri = Prefixed_Name(prvtypes, "") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:SQLQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SQL Query</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#SQLQuery">http://purl.org/net/provenance/types#SQLQuery</seealso>
    let SQLQuery = Prefixed_Name(prvtypes, "SQLQuery") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:exchangedHTTPMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property refers to an HTTP message (request or response) that has been exchanged during an HTTP based data access.</para>
    /// labels<para>involved exchange of</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#exchangedHTTPMessage">http://purl.org/net/provenance/types#exchangedHTTPMessage</seealso>
    let exchangedHTTPMessage =
        Prefixed_Name(prvtypes, "exchangedHTTPMessage") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:TriplifyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>TriplifyMapping is a concept that represents the mapping defined in a Triplify configuration file.</para>
    /// labels<para>Triplify Mapping</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#TriplifyMapping">http://purl.org/net/provenance/types#TriplifyMapping</seealso>
    let TriplifyMapping = Prefixed_Name(prvtypes, "TriplifyMapping") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:DataAccessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataAccessor is a concept that represents a system (i.e. a non-human agent) which performed the data access in order to retrieve an information resource from the Web.</para>
    /// labels<para>Data Accessor</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#DataAccessor">http://purl.org/net/provenance/types#DataAccessor</seealso>
    let DataAccessor = Prefixed_Name(prvtypes, "DataAccessor") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:DataCreatingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataCreatingDevice is a concept that represents a device which performed the creation of a data item. Examples for data creating devices are sensors.</para>
    /// labels<para>Data Creating Device</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#DataCreatingDevice">http://purl.org/net/provenance/types#DataCreatingDevice</seealso>
    let DataCreatingDevice =
        Prefixed_Name(prvtypes, "DataCreatingDevice") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:DataCreatingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataCreatingEntity is a concept that represents a human agent who performed the creation of a data item, either directly or by being responsible for a non-human data creator (see the concepts prvTypes:DataCreatingService and prvTypes:DataCreatingDevice).</para>
    /// labels<para>Data Creating Entity</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#DataCreatingEntity">http://purl.org/net/provenance/types#DataCreatingEntity</seealso>
    let DataCreatingEntity =
        Prefixed_Name(prvtypes, "DataCreatingEntity") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:DataCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataCreator is a concept that represents an agent which performed the creation of a data item.</para>
    /// labels<para>Data Creator</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#DataCreator">http://purl.org/net/provenance/types#DataCreator</seealso>
    let DataCreator = Prefixed_Name(prvtypes, "DataCreator") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:HTTPBasedDataAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An HTTPBasedDataAccess represents the completed execution of accessing a data item using the HTTP protocol.</para>
    /// labels<para>HTTP-based Data Access</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#HTTPBasedDataAccess">http://purl.org/net/provenance/types#HTTPBasedDataAccess</seealso>
    let HTTPBasedDataAccess =
        Prefixed_Name(prvtypes, "HTTPBasedDataAccess") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Query</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#Query">http://purl.org/net/provenance/types#Query</seealso>
    let Query = Prefixed_Name(prvtypes, "Query") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement is a concept that represents the execution of a measurement.</para>
    /// labels<para>Measurement</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#Measurement">http://purl.org/net/provenance/types#Measurement</seealso>
    let Measurement = Prefixed_Name(prvtypes, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:QueryExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Query Execution</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#QueryExecution">http://purl.org/net/provenance/types#QueryExecution</seealso>
    let QueryExecution = Prefixed_Name(prvtypes, "QueryExecution") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:QueryResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>QueryResult is the result of a query execution.</para>
    /// labels<para>Query Result</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#QueryResult">http://purl.org/net/provenance/types#QueryResult</seealso>
    let QueryResult = Prefixed_Name(prvtypes, "QueryResult") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:QueryTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A QueryTemplate is a query that contains placeholders which are replaced by actual data to create an executable query.</para>
    /// labels<para>Query Template</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#QueryTemplate">http://purl.org/net/provenance/types#QueryTemplate</seealso>
    let QueryTemplate = Prefixed_Name(prvtypes, "QueryTemplate") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#Sensor">http://purl.org/net/provenance/types#Sensor</seealso>
    let Sensor = Prefixed_Name(prvtypes, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>prvtypes:SPARQLQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SPARQL Query</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#SPARQLQuery">http://purl.org/net/provenance/types#SPARQLQuery</seealso>
    let SPARQLQuery = Prefixed_Name(prvtypes, "SPARQLQuery") |> PrefixedName

    /// <summary>
    ///   <para>prvtypes:DataCreatingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataCreatingService is a concept that represents a software service which performed the creation of a data item. Examples for data creating services are reasoners, query engines, and workflow engines.</para>
    /// labels<para>Data Creating Service</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/types#DataCreatingService">http://purl.org/net/provenance/types#DataCreatingService</seealso>
    let DataCreatingService =
        Prefixed_Name(prvtypes, "DataCreatingService") |> PrefixedName
