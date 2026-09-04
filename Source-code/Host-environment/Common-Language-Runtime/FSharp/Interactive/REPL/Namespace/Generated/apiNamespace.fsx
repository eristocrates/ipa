#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module api =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/linked-data/api/vocab#" "api"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : API</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#API">api:API</a>
    /// </summary>
    let API = _prefixId.prefix "API"
    /// <summary>
    ///   <para>rdfs:label : Content negotiation type</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#ContentNegotiationStrategy">api:ContentNegotiationStrategy</a>
    /// </summary>
    let ContentNegotiationStrategy = _prefixId.prefix "ContentNegotiationStrategy"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that generates a simple CSV representation of an RDF graph</para>
    ///   <para>rdfs:label : CSV Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#CsvFormatter">api:CsvFormatter</a>
    /// </summary>
    let CsvFormatter = _prefixId.prefix "CsvFormatter"
    /// <summary>
    ///   <para>rdfs:comment : An endpoint exposed by the API.</para>
    ///   <para>rdfs:label : Endpoint</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#Endpoint">api:Endpoint</a>
    /// </summary>
    let Endpoint = _prefixId.prefix "Endpoint"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that creates a representation from an RDF graph.</para>
    ///   <para>rdfs:label : Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#Formatter">api:Formatter</a>
    /// </summary>
    let Formatter = _prefixId.prefix "Formatter"
    /// <summary>
    ///   <para>rdfs:comment : An endpoint that returns information about a single instance.</para>
    ///   <para>rdfs:label : Item Endpoint</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#ItemEndpoint">api:ItemEndpoint</a>
    /// </summary>
    let ItemEndpoint = _prefixId.prefix "ItemEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that generates a simple JSON representation of an RDF graph</para>
    ///   <para>rdfs:label : JSON Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#JsonFormatter">api:JsonFormatter</a>
    /// </summary>
    let JsonFormatter = _prefixId.prefix "JsonFormatter"
    /// <summary>
    ///   <para>rdfs:comment : a List represents the full set of resources that match the request against the Endpoint; a Page lists a subset of the List.</para>
    ///   <para>rdfs:label : List</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#List">api:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:comment : An endpoint that returns information about a list of instances.</para>
    ///   <para>rdfs:label : List Endpoint</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#ListEndpoint">api:ListEndpoint</a>
    /// </summary>
    let ListEndpoint = _prefixId.prefix "ListEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : A page returned in response to a request to an Endpoint.</para>
    ///   <para>rdfs:label : Page</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#Page">api:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that generates an RDF/XML representation of an RDF graph</para>
    ///   <para>rdfs:label : RDF/XML Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#RdfXmlFormatter">api:RdfXmlFormatter</a>
    /// </summary>
    let RdfXmlFormatter = _prefixId.prefix "RdfXmlFormatter"
    /// <summary>
    ///   <para>rdfs:comment : A specification of an ordered list of resources.</para>
    ///   <para>rdfs:label : Selector</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#Selector">api:Selector</a>
    /// </summary>
    let Selector = _prefixId.prefix "Selector"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that gives the default Turtle representation of an RDF graphrdfs:comment : A formatter that generates an Turtle representation of an RDF graph</para>
    ///   <para>rdfs:label : Default Turtle Formatterrdfs:label : Turtle Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#TurtleFormatter">api:TurtleFormatter</a>
    /// </summary>
    let TurtleFormatter = _prefixId.prefix "TurtleFormatter"
    /// <summary>
    ///   <para>rdfs:comment : A specification of a view of a particular item.</para>
    ///   <para>rdfs:label : Viewer</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#Viewer">api:Viewer</a>
    /// </summary>
    let Viewer = _prefixId.prefix "Viewer"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that generates a simple XML representation of an RDF graph</para>
    ///   <para>rdfs:label : XML Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#XmlFormatter">api:XmlFormatter</a>
    /// </summary>
    let XmlFormatter = _prefixId.prefix "XmlFormatter"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that uses an XSLT stylesheet to generates a representation of an RDF graph</para>
    ///   <para>rdfs:label : XSLT Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#XsltFormatter">api:XsltFormatter</a>
    /// </summary>
    let XsltFormatter = _prefixId.prefix "XsltFormatter"
    /// <summary>
    ///   <para>rdfs:comment : The base URI of the API, which is distinct from the URI of the SPARQL endpoint that it queries or the base URI of the instances that it returns. This base URI is stripped from the request URI before any matching is done against the endpoints defined for the API.</para>
    ///   <para>rdfs:label : Base URI</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#base">api:base</a>
    /// </summary>
    let base_ = _prefixId.prefix "base"
    let basicViewer = _prefixId.prefix "basicViewer"
    /// <summary>
    ///   <para>rdfs:comment : The mechanism used within the URI to override normal content negotiation and deliver a particular results format.^^xsd:string</para>
    ///   <para>rdfs:label : Content Negotiation</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#contentNegotiation">api:contentNegotiation</a>
    /// </summary>
    let contentNegotiation = _prefixId.prefix "contentNegotiation"
    let csvFormatter = _prefixId.prefix "csvFormatter"
    /// <summary>
    ///   <para>rdfs:comment : The default formatter used if none is explicitly selected within the request URI.</para>
    ///   <para>rdfs:label : Default Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#defaultFormatter">api:defaultFormatter</a>
    /// </summary>
    let defaultFormatter = _prefixId.prefix "defaultFormatter"
    /// <summary>
    ///   <para>rdfs:comment : The default size of lists that will be returned by the API or endpoint.</para>
    ///   <para>rdfs:label : Default Page Size</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#defaultPageSize">api:defaultPageSize</a>
    /// </summary>
    let defaultPageSize = _prefixId.prefix "defaultPageSize"
    /// <summary>
    ///   <para>rdfs:comment : The default viewer used if none is explicitly selected within the request URI.</para>
    ///   <para>rdfs:label : Default Viewer</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#defaultViewer">api:defaultViewer</a>
    /// </summary>
    let defaultViewer = _prefixId.prefix "defaultViewer"
    /// <summary>
    ///   <para>rdfs:comment : The API Endpoint </para>
    ///   <para>rdfs:label : Definition</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#definition">api:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    let describeViewer = _prefixId.prefix "describeViewer"
    /// <summary>
    ///   <para>rdfs:comment : An endpoint specified by the API, against which requests can be made.</para>
    ///   <para>rdfs:label : Endpoint</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#endpoint">api:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:comment : a document containing the same data, plus extra document-centric metadata.</para>
    ///   <para>rdfs:label : Extended Metadata Version</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#extendedMetadataVersion">api:extendedMetadataVersion</a>
    /// </summary>
    let extendedMetadataVersion = _prefixId.prefix "extendedMetadataVersion"
    /// <summary>
    ///   <para>rdfs:comment : A set of parameter bindings in the same format as is used within the query of a URI, used to provide a simple way of filtering the sequence of items that the selector selects.</para>
    ///   <para>rdfs:label : Filter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#filter">api:filter</a>
    /// </summary>
    let filter = _prefixId.prefix "filter"
    /// <summary>
    ///   <para>rdfs:comment : A formatter that can be used with the endpoint.</para>
    ///   <para>rdfs:label : Formatter</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#formatter">api:formatter</a>
    /// </summary>
    let formatter = _prefixId.prefix "formatter"
    /// <summary>
    ///   <para>rdfs:comment : Other viewers that describe properties that should be incorporated into this view.</para>
    ///   <para>rdfs:label : Include</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#include">api:include</a>
    /// </summary>
    let include_ = _prefixId.prefix "include"
    /// <summary>
    ///   <para>rdfs:comment : A template for the URI of the item that the item endpoint should return. Any instances of {varName} within the string are replaced by the value of the relevant variable.</para>
    ///   <para>rdfs:label : Item template</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#itemTemplate">api:itemTemplate</a>
    /// </summary>
    let itemTemplate = _prefixId.prefix "itemTemplate"
    /// <summary>
    ///   <para>rdfs:comment : The list of resources described by the page that are in the List the page is part of.</para>
    ///   <para>rdfs:label : Items</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#items">api:items</a>
    /// </summary>
    let items = _prefixId.prefix "items"
    let jsonFormatter = _prefixId.prefix "jsonFormatter"
    let labelledDescribeViewer = _prefixId.prefix "labelledDescribeViewer"
    /// <summary>
    ///   <para>rdfs:comment : The maximum size of lists that will be returned by the API.</para>
    ///   <para>rdfs:label : Maximum Page Size</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#maxPageSize">api:maxPageSize</a>
    /// </summary>
    let maxPageSize = _prefixId.prefix "maxPageSize"
    /// <summary>
    ///   <para>rdfs:comment : The mime type that the formatter returns and that it should be used with.</para>
    ///   <para>rdfs:label : Mime Type</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#mimeType">api:mimeType</a>
    /// </summary>
    let mimeType = _prefixId.prefix "mimeType"
    /// <summary>
    ///   <para>rdfs:comment : The name of the resource.</para>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#name">api:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : A space separated sequence of OrderConditions suitable for using in a SPARQL ORDER BY clause. This is used to order the sequence of items that the selector selects.</para>
    ///   <para>rdfs:label : Order By</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#orderBy">api:orderBy</a>
    /// </summary>
    let orderBy = _prefixId.prefix "orderBy"
    let parameterBased = _prefixId.prefix "parameterBased"
    /// <summary>
    ///   <para>rdfs:comment : The parent selector, from which filters and sort specifications may be inherited.</para>
    ///   <para>rdfs:label : Parent</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#parent">api:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    /// <summary>
    ///   <para>rdfs:comment : A comma-separated list of property paths that indicate the information that should be included in the view.</para>
    ///   <para>rdfs:label : Properties</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#properties">api:properties</a>
    /// </summary>
    let properties = _prefixId.prefix "properties"
    /// <summary>
    ///   <para>rdfs:comment : A property chain (which may be a single property) that indicates information that should be included in the view.</para>
    ///   <para>rdfs:label : Property</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#property">api:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    let rdfXmlFormatter = _prefixId.prefix "rdfXmlFormatter"
    /// <summary>
    ///   <para>rdfs:comment : A SPARQL WHERE and ORDER BY clause that can be used to select an ordered list of resources. It should include the binding of an ?item variable for the selected items.</para>
    ///   <para>rdfs:label : Select</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#select">api:select</a>
    /// </summary>
    let select = _prefixId.prefix "select"
    /// <summary>
    ///   <para>rdfs:comment : The selector that should be used to generate the list of items.</para>
    ///   <para>rdfs:label : Selector</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#selector">api:selector</a>
    /// </summary>
    let selector = _prefixId.prefix "selector"
    /// <summary>
    ///   <para>rdfs:comment : A sequence of comma-separated sort specifications indicating the sorting of the items in the sequence that the selector selects. A leading hyphen indicates a reverse sort.</para>
    ///   <para>rdfs:label : Sort</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#sort">api:sort</a>
    /// </summary>
    let sort = _prefixId.prefix "sort"
    /// <summary>
    ///   <para>rdfs:comment : The endpoint used to serve up the results that are exposed by the API. This should not include the query parameters within the URI.</para>
    ///   <para>rdfs:label : SPARQL endpoint</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#sparqlEndpoint">api:sparqlEndpoint</a>
    /// </summary>
    let sparqlEndpoint = _prefixId.prefix "sparqlEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : The XSLT stylesheet that should be used by an XSLT formatter to generate a representation of the RDF graph</para>
    ///   <para>rdfs:label : Stylesheet</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#stylesheet">api:stylesheet</a>
    /// </summary>
    let stylesheet = _prefixId.prefix "stylesheet"
    let suffixBased = _prefixId.prefix "suffixBased"
    /// <summary>
    ///   <para>rdfs:comment : SPARQL that can be used to construct a graph based on an item (identified in the SPARQL as ?item).</para>
    ///   <para>rdfs:label : Template</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#template">api:template</a>
    /// </summary>
    let template = _prefixId.prefix "template"
    /// <summary>
    ///   <para>rdfs:comment : A template that can be used to match against request URIs. This template can contain variable names within {}s; when the URI is matched then the substrings that appear in these locations are bound to the named variable.</para>
    ///   <para>rdfs:label : URI template</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#uriTemplate">api:uriTemplate</a>
    /// </summary>
    let uriTemplate = _prefixId.prefix "uriTemplate"
    /// <summary>
    ///   <para>rdfs:comment : A viewer that can be used with the endpoint.</para>
    ///   <para>rdfs:label : Viewer</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#viewer">api:viewer</a>
    /// </summary>
    let viewer = _prefixId.prefix "viewer"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary that should be used by the configuration to provide labels for properties. To be recognised for filtering, a property must be defined either within this vocabulary or in the configuration file itself.</para>
    ///   <para>rdfs:label : Vocabulary</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#vocabulary">api:vocabulary</a>
    /// </summary>
    let vocabulary = _prefixId.prefix "vocabulary"
    /// <summary>
    ///   <para>rdfs:comment : A GroupGraphPattern suitable for embedding within a SPARQL WHERE clause. This is used for filtering the set of items that the selector selects.</para>
    ///   <para>rdfs:label : Where</para>
    ///   <a href="http://purl.org/linked-data/api/vocab#where">api:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
    let xmlFormatter = _prefixId.prefix "xmlFormatter"
