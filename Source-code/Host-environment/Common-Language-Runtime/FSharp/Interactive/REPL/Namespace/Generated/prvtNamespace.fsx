#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prvt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/provenance/types#" "prvt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : DataAccessor is a concept that represents a system (i.e. a non-human agent) which performed the data access in order to retrieve an information resource from the Web.</para>
    ///   <para>rdfs:label : Data Accessor</para>
    ///   <a href="http://purl.org/net/provenance/types#DataAccessor">prvt:DataAccessor</a>
    /// </summary>
    let DataAccessor = _prefixId.prefix "DataAccessor"
    /// <summary>
    ///   <para>rdfs:comment : DataCreatingDevice is a concept that represents a device which performed the creation of a data item. Examples for data creating devices are sensors.</para>
    ///   <para>rdfs:label : Data Creating Device</para>
    ///   <a href="http://purl.org/net/provenance/types#DataCreatingDevice">prvt:DataCreatingDevice</a>
    /// </summary>
    let DataCreatingDevice = _prefixId.prefix "DataCreatingDevice"
    /// <summary>
    ///   <para>rdfs:comment : DataCreatingEntity is a concept that represents a human agent who performed the creation of a data item, either directly or by being responsible for a non-human data creator (see the concepts prvTypes:DataCreatingService and prvTypes:DataCreatingDevice).</para>
    ///   <para>rdfs:label : Data Creating Entity</para>
    ///   <a href="http://purl.org/net/provenance/types#DataCreatingEntity">prvt:DataCreatingEntity</a>
    /// </summary>
    let DataCreatingEntity = _prefixId.prefix "DataCreatingEntity"
    /// <summary>
    ///   <para>rdfs:comment : DataCreatingService is a concept that represents a software service which performed the creation of a data item. Examples for data creating services are reasoners, query engines, and workflow engines.</para>
    ///   <para>rdfs:label : Data Creating Service</para>
    ///   <a href="http://purl.org/net/provenance/types#DataCreatingService">prvt:DataCreatingService</a>
    /// </summary>
    let DataCreatingService = _prefixId.prefix "DataCreatingService"
    /// <summary>
    ///   <para>rdfs:comment : DataCreator is a concept that represents an agent which performed the creation of a data item.</para>
    ///   <para>rdfs:label : Data Creator</para>
    ///   <a href="http://purl.org/net/provenance/types#DataCreator">prvt:DataCreator</a>
    /// </summary>
    let DataCreator = _prefixId.prefix "DataCreator"
    /// <summary>
    ///   <para>rdfs:comment : An HTTPBasedDataAccess represents the completed execution of accessing a data item using the HTTP protocol.</para>
    ///   <para>rdfs:label : HTTP-based Data Access</para>
    ///   <a href="http://purl.org/net/provenance/types#HTTPBasedDataAccess">prvt:HTTPBasedDataAccess</a>
    /// </summary>
    let HTTPBasedDataAccess = _prefixId.prefix "HTTPBasedDataAccess"
    /// <summary>
    ///   <para>rdfs:comment : Measurement is a concept that represents the execution of a measurement.</para>
    ///   <para>rdfs:label : Measurement</para>
    ///   <a href="http://purl.org/net/provenance/types#Measurement">prvt:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Query</para>
    ///   <a href="http://purl.org/net/provenance/types#Query">prvt:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Query Execution</para>
    ///   <a href="http://purl.org/net/provenance/types#QueryExecution">prvt:QueryExecution</a>
    /// </summary>
    let QueryExecution = _prefixId.prefix "QueryExecution"
    /// <summary>
    ///   <para>rdfs:comment : QueryResult is the result of a query execution.</para>
    ///   <para>rdfs:label : Query Result</para>
    ///   <a href="http://purl.org/net/provenance/types#QueryResult">prvt:QueryResult</a>
    /// </summary>
    let QueryResult = _prefixId.prefix "QueryResult"
    /// <summary>
    ///   <para>rdfs:comment : A QueryTemplate is a query that contains placeholders which are replaced by actual data to create an executable query.</para>
    ///   <para>rdfs:label : Query Template</para>
    ///   <a href="http://purl.org/net/provenance/types#QueryTemplate">prvt:QueryTemplate</a>
    /// </summary>
    let QueryTemplate = _prefixId.prefix "QueryTemplate"
    /// <summary>
    ///   <para>rdfs:label : SPARQL Query</para>
    ///   <a href="http://purl.org/net/provenance/types#SPARQLQuery">prvt:SPARQLQuery</a>
    /// </summary>
    let SPARQLQuery = _prefixId.prefix "SPARQLQuery"
    /// <summary>
    ///   <para>rdfs:label : SQL Query</para>
    ///   <a href="http://purl.org/net/provenance/types#SQLQuery">prvt:SQLQuery</a>
    /// </summary>
    let SQLQuery = _prefixId.prefix "SQLQuery"
    /// <summary>
    ///   <para>rdfs:label : Sensor</para>
    ///   <a href="http://purl.org/net/provenance/types#Sensor">prvt:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:comment : TriplifyMapping is a concept that represents the mapping defined in a Triplify configuration file.</para>
    ///   <para>rdfs:label : Triplify Mapping</para>
    ///   <a href="http://purl.org/net/provenance/types#TriplifyMapping">prvt:TriplifyMapping</a>
    /// </summary>
    let TriplifyMapping = _prefixId.prefix "TriplifyMapping"
    /// <summary>
    ///   <para>rdfs:comment : This property refers to an HTTP message (request or response) that has been exchanged during an HTTP based data access.</para>
    ///   <para>rdfs:label : involved exchange of</para>
    ///   <a href="http://purl.org/net/provenance/types#exchangedHTTPMessage">prvt:exchangedHTTPMessage</a>
    /// </summary>
    let exchangedHTTPMessage = _prefixId.prefix "exchangedHTTPMessage"
