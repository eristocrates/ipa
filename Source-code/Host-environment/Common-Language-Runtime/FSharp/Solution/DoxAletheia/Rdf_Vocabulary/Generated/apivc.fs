namespace http.purl.org.linked_data.api.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module apivc =
    let _namespace_iri = Namespace_Iri apivc |> NamespaceIRI
    /// <summary>
    ///   <para>apivc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Configuration vocabulary for the Linked Data API"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#">http://purl.org/linked-data/api/vocab#</seealso>
    let _prefix_iri = Prefixed_Name(apivc, "") |> PrefixedName
    /// <summary>
    ///   <para>apivc:API</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"API"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#API">http://purl.org/linked-data/api/vocab#API</seealso>
    let API = Prefixed_Name(apivc, "API") |> PrefixedName

    /// <summary>
    ///   <para>apivc:ContentNegotiationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Content negotiation type"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#ContentNegotiationStrategy">http://purl.org/linked-data/api/vocab#ContentNegotiationStrategy</seealso>
    let ContentNegotiationStrategy =
        Prefixed_Name(apivc, "ContentNegotiationStrategy") |> PrefixedName

    /// <summary>
    ///   <para>apivc:CsvFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that generates a simple CSV representation of an RDF graph"</para>
    /// labels<para>"CSV Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#CsvFormatter">http://purl.org/linked-data/api/vocab#CsvFormatter</seealso>
    let CsvFormatter = Prefixed_Name(apivc, "CsvFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:Endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An endpoint exposed by the API."</para>
    /// labels<para>"Endpoint"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#Endpoint">http://purl.org/linked-data/api/vocab#Endpoint</seealso>
    let Endpoint = Prefixed_Name(apivc, "Endpoint") |> PrefixedName
    /// <summary>
    ///   <para>apivc:Formatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that creates a representation from an RDF graph."</para>
    /// labels<para>"Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#Formatter">http://purl.org/linked-data/api/vocab#Formatter</seealso>
    let Formatter = Prefixed_Name(apivc, "Formatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:ItemEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An endpoint that returns information about a single instance."</para>
    /// labels<para>"Item Endpoint"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#ItemEndpoint">http://purl.org/linked-data/api/vocab#ItemEndpoint</seealso>
    let ItemEndpoint = Prefixed_Name(apivc, "ItemEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>apivc:JsonFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that generates a simple JSON representation of an RDF graph"</para>
    /// labels<para>"JSON Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#JsonFormatter">http://purl.org/linked-data/api/vocab#JsonFormatter</seealso>
    let JsonFormatter = Prefixed_Name(apivc, "JsonFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a List represents the full set of resources that match the request against the Endpoint; a Page lists a subset of the List."</para>
    /// labels<para>"List"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#List">http://purl.org/linked-data/api/vocab#List</seealso>
    let List = Prefixed_Name(apivc, "List") |> PrefixedName
    /// <summary>
    ///   <para>apivc:ListEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An endpoint that returns information about a list of instances."</para>
    /// labels<para>"List Endpoint"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#ListEndpoint">http://purl.org/linked-data/api/vocab#ListEndpoint</seealso>
    let ListEndpoint = Prefixed_Name(apivc, "ListEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>apivc:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A page returned in response to a request to an Endpoint."</para>
    /// labels<para>"Page"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#Page">http://purl.org/linked-data/api/vocab#Page</seealso>
    let Page = Prefixed_Name(apivc, "Page") |> PrefixedName
    /// <summary>
    ///   <para>apivc:RdfXmlFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that generates an RDF/XML representation of an RDF graph"</para>
    /// labels<para>"RDF/XML Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#RdfXmlFormatter">http://purl.org/linked-data/api/vocab#RdfXmlFormatter</seealso>
    let RdfXmlFormatter = Prefixed_Name(apivc, "RdfXmlFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:Selector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A specification of an ordered list of resources."</para>
    /// labels<para>"Selector"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#Selector">http://purl.org/linked-data/api/vocab#Selector</seealso>
    let Selector = Prefixed_Name(apivc, "Selector") |> PrefixedName
    /// <summary>
    ///   <para>apivc:TurtleFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>apivc:TurtleFormatter</para>
    ///   <para>"A formatter that gives the default Turtle representation of an RDF graph"</para>
    ///   <para>"A formatter that generates an Turtle representation of an RDF graph"</para>
    /// labels<para>"Turtle Formatter"</para><para>"Default Turtle Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#TurtleFormatter">http://purl.org/linked-data/api/vocab#TurtleFormatter</seealso>
    let TurtleFormatter = Prefixed_Name(apivc, "TurtleFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:Viewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A specification of a view of a particular item."</para>
    /// labels<para>"Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#Viewer">http://purl.org/linked-data/api/vocab#Viewer</seealso>
    let Viewer = Prefixed_Name(apivc, "Viewer") |> PrefixedName
    /// <summary>
    ///   <para>apivc:XmlFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that generates a simple XML representation of an RDF graph"</para>
    /// labels<para>"XML Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#XmlFormatter">http://purl.org/linked-data/api/vocab#XmlFormatter</seealso>
    let XmlFormatter = Prefixed_Name(apivc, "XmlFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:XsltFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A formatter that uses an XSLT stylesheet to generates a representation of an RDF graph"</para>
    /// labels<para>"XSLT Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#XsltFormatter">http://purl.org/linked-data/api/vocab#XsltFormatter</seealso>
    let XsltFormatter = Prefixed_Name(apivc, "XsltFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:base</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The base URI of the API, which is distinct from the URI of the SPARQL endpoint that it queries or the base URI of the instances that it returns. This base URI is stripped from the request URI before any matching is done against the endpoints defined for the API."</para>
    /// labels<para>"Base URI"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#base">http://purl.org/linked-data/api/vocab#base</seealso>
    let base_ = Prefixed_Name(apivc, "base") |> PrefixedName
    /// <summary>
    ///   <para>apivc:basicViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:Viewer</para>
    ///   <para>"A viewer that returns the type and label of the item."</para>
    /// labels<para>"Basic Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#basicViewer">http://purl.org/linked-data/api/vocab#basicViewer</seealso>
    let basicViewer = Prefixed_Name(apivc, "basicViewer") |> PrefixedName
    /// <summary>
    ///   <para>apivc:contentNegotiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The mechanism used within the URI to override normal content negotiation and deliver a particular results format."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Content Negotiation"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#contentNegotiation">http://purl.org/linked-data/api/vocab#contentNegotiation</seealso>
    let contentNegotiation = Prefixed_Name(apivc, "contentNegotiation") |> PrefixedName
    /// <summary>
    ///   <para>apivc:csvFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:csvFormatter</para>
    ///   <para>"A formatter that gives the default simple CSV representation of an RDF graph"</para>
    /// labels<para>"Default CSV Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#csvFormatter">http://purl.org/linked-data/api/vocab#csvFormatter</seealso>
    let csvFormatter = Prefixed_Name(apivc, "csvFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:defaultFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The default formatter used if none is explicitly selected within the request URI."</para>
    /// labels<para>"Default Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#defaultFormatter">http://purl.org/linked-data/api/vocab#defaultFormatter</seealso>
    let defaultFormatter = Prefixed_Name(apivc, "defaultFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:defaultPageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The default size of lists that will be returned by the API or endpoint."</para>
    /// labels<para>"Default Page Size"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#defaultPageSize">http://purl.org/linked-data/api/vocab#defaultPageSize</seealso>
    let defaultPageSize = Prefixed_Name(apivc, "defaultPageSize") |> PrefixedName
    /// <summary>
    ///   <para>apivc:defaultViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The default viewer used if none is explicitly selected within the request URI."</para>
    /// labels<para>"Default Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#defaultViewer">http://purl.org/linked-data/api/vocab#defaultViewer</seealso>
    let defaultViewer = Prefixed_Name(apivc, "defaultViewer") |> PrefixedName
    /// <summary>
    ///   <para>apivc:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The API Endpoint "</para>
    /// labels<para>"Definition"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#definition">http://purl.org/linked-data/api/vocab#definition</seealso>
    let definition = Prefixed_Name(apivc, "definition") |> PrefixedName
    /// <summary>
    ///   <para>apivc:describeViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:Viewer</para>
    ///   <para>"A viewer that returns a graph created from a DESCRIBE query."</para>
    /// labels<para>"DESCRIBE Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#describeViewer">http://purl.org/linked-data/api/vocab#describeViewer</seealso>
    let describeViewer = Prefixed_Name(apivc, "describeViewer") |> PrefixedName
    /// <summary>
    ///   <para>apivc:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An endpoint specified by the API, against which requests can be made."</para>
    /// labels<para>"Endpoint"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#endpoint">http://purl.org/linked-data/api/vocab#endpoint</seealso>
    let endpoint = Prefixed_Name(apivc, "endpoint") |> PrefixedName

    /// <summary>
    ///   <para>apivc:extendedMetadataVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a document containing the same data, plus extra document-centric metadata."</para>
    /// labels<para>"Extended Metadata Version"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#extendedMetadataVersion">http://purl.org/linked-data/api/vocab#extendedMetadataVersion</seealso>
    let extendedMetadataVersion =
        Prefixed_Name(apivc, "extendedMetadataVersion") |> PrefixedName

    /// <summary>
    ///   <para>apivc:filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A set of parameter bindings in the same format as is used within the query of a URI, used to provide a simple way of filtering the sequence of items that the selector selects."</para>
    /// labels<para>"Filter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#filter">http://purl.org/linked-data/api/vocab#filter</seealso>
    let filter = Prefixed_Name(apivc, "filter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:formatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A formatter that can be used with the endpoint."</para>
    /// labels<para>"Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#formatter">http://purl.org/linked-data/api/vocab#formatter</seealso>
    let formatter = Prefixed_Name(apivc, "formatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:include</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Other viewers that describe properties that should be incorporated into this view."</para>
    /// labels<para>"Include"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#include">http://purl.org/linked-data/api/vocab#include</seealso>
    let include_ = Prefixed_Name(apivc, "include") |> PrefixedName
    /// <summary>
    ///   <para>apivc:itemTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A template for the URI of the item that the item endpoint should return. Any instances of {varName} within the string are replaced by the value of the relevant variable."</para>
    /// labels<para>"Item template"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#itemTemplate">http://purl.org/linked-data/api/vocab#itemTemplate</seealso>
    let itemTemplate = Prefixed_Name(apivc, "itemTemplate") |> PrefixedName
    /// <summary>
    ///   <para>apivc:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The list of resources described by the page that are in the List the page is part of."</para>
    /// labels<para>"Items"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#items">http://purl.org/linked-data/api/vocab#items</seealso>
    let items = Prefixed_Name(apivc, "items") |> PrefixedName
    /// <summary>
    ///   <para>apivc:jsonFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:jsonFormatter</para>
    ///   <para>"A formatter that gives the default simple JSON representation of an RDF graph"</para>
    /// labels<para>"Default JSON Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#jsonFormatter">http://purl.org/linked-data/api/vocab#jsonFormatter</seealso>
    let jsonFormatter = Prefixed_Name(apivc, "jsonFormatter") |> PrefixedName

    /// <summary>
    ///   <para>apivc:labelledDescribeViewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:Viewer</para>
    ///   <para>"A viewer that returns the graph created from a DESCRIBE query, supplemented by labels for linked resources."</para>
    /// labels<para>"Labelled DESCRIBE Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#labelledDescribeViewer">http://purl.org/linked-data/api/vocab#labelledDescribeViewer</seealso>
    let labelledDescribeViewer =
        Prefixed_Name(apivc, "labelledDescribeViewer") |> PrefixedName

    /// <summary>
    ///   <para>apivc:maxPageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The maximum size of lists that will be returned by the API."</para>
    /// labels<para>"Maximum Page Size"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#maxPageSize">http://purl.org/linked-data/api/vocab#maxPageSize</seealso>
    let maxPageSize = Prefixed_Name(apivc, "maxPageSize") |> PrefixedName
    /// <summary>
    ///   <para>apivc:mimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The mime type that the formatter returns and that it should be used with."</para>
    /// labels<para>"Mime Type"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#mimeType">http://purl.org/linked-data/api/vocab#mimeType</seealso>
    let mimeType = Prefixed_Name(apivc, "mimeType") |> PrefixedName
    /// <summary>
    ///   <para>apivc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the resource."</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#name">http://purl.org/linked-data/api/vocab#name</seealso>
    let name = Prefixed_Name(apivc, "name") |> PrefixedName
    /// <summary>
    ///   <para>apivc:orderBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A space separated sequence of OrderConditions suitable for using in a SPARQL ORDER BY clause. This is used to order the sequence of items that the selector selects."</para>
    /// labels<para>"Order By"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#orderBy">http://purl.org/linked-data/api/vocab#orderBy</seealso>
    let orderBy = Prefixed_Name(apivc, "orderBy") |> PrefixedName
    /// <summary>
    ///   <para>apivc:parameterBased</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:ContentNegotiationStrategy</para>
    ///   <para>"This content negotiation strategy uses the _format parameter within the URI to indicate the formatter that should be used to format the results of the request."</para>
    /// labels<para>"Parameter-Based Content Negotiation"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#parameterBased">http://purl.org/linked-data/api/vocab#parameterBased</seealso>
    let parameterBased = Prefixed_Name(apivc, "parameterBased") |> PrefixedName
    /// <summary>
    ///   <para>apivc:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The parent selector, from which filters and sort specifications may be inherited."</para>
    /// labels<para>"Parent"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#parent">http://purl.org/linked-data/api/vocab#parent</seealso>
    let parent = Prefixed_Name(apivc, "parent") |> PrefixedName
    /// <summary>
    ///   <para>apivc:properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comma-separated list of property paths that indicate the information that should be included in the view."</para>
    /// labels<para>"Properties"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#properties">http://purl.org/linked-data/api/vocab#properties</seealso>
    let properties = Prefixed_Name(apivc, "properties") |> PrefixedName
    /// <summary>
    ///   <para>apivc:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property chain (which may be a single property) that indicates information that should be included in the view."</para>
    /// labels<para>"Property"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#property">http://purl.org/linked-data/api/vocab#property</seealso>
    let property = Prefixed_Name(apivc, "property") |> PrefixedName
    /// <summary>
    ///   <para>apivc:rdfXmlFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:RdfXmlFormatter</para>
    ///   <para>"A formatter that gives the default RDF/XML representation of an RDF graph"</para>
    /// labels<para>"Default RDF/XML Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#rdfXmlFormatter">http://purl.org/linked-data/api/vocab#rdfXmlFormatter</seealso>
    let rdfXmlFormatter = Prefixed_Name(apivc, "rdfXmlFormatter") |> PrefixedName
    /// <summary>
    ///   <para>apivc:select</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A SPARQL WHERE and ORDER BY clause that can be used to select an ordered list of resources. It should include the binding of an ?item variable for the selected items."</para>
    /// labels<para>"Select"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#select">http://purl.org/linked-data/api/vocab#select</seealso>
    let select = Prefixed_Name(apivc, "select") |> PrefixedName
    /// <summary>
    ///   <para>apivc:selector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The selector that should be used to generate the list of items."</para>
    /// labels<para>"Selector"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#selector">http://purl.org/linked-data/api/vocab#selector</seealso>
    let selector = Prefixed_Name(apivc, "selector") |> PrefixedName
    /// <summary>
    ///   <para>apivc:sort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A sequence of comma-separated sort specifications indicating the sorting of the items in the sequence that the selector selects. A leading hyphen indicates a reverse sort."</para>
    /// labels<para>"Sort"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#sort">http://purl.org/linked-data/api/vocab#sort</seealso>
    let sort = Prefixed_Name(apivc, "sort") |> PrefixedName
    /// <summary>
    ///   <para>apivc:sparqlEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The endpoint used to serve up the results that are exposed by the API. This should not include the query parameters within the URI."</para>
    /// labels<para>"SPARQL endpoint"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#sparqlEndpoint">http://purl.org/linked-data/api/vocab#sparqlEndpoint</seealso>
    let sparqlEndpoint = Prefixed_Name(apivc, "sparqlEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>apivc:stylesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The XSLT stylesheet that should be used by an XSLT formatter to generate a representation of the RDF graph"</para>
    /// labels<para>"Stylesheet"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#stylesheet">http://purl.org/linked-data/api/vocab#stylesheet</seealso>
    let stylesheet = Prefixed_Name(apivc, "stylesheet") |> PrefixedName
    /// <summary>
    ///   <para>apivc:suffixBased</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:ContentNegotiationStrategy</para>
    ///   <para>"This content negotiation strategy uses the suffix used on the last segment within the request URI to indicate the formatter that should be used to format the results of the request."</para>
    /// labels<para>"Suffix-Based Content Negotiation"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#suffixBased">http://purl.org/linked-data/api/vocab#suffixBased</seealso>
    let suffixBased = Prefixed_Name(apivc, "suffixBased") |> PrefixedName
    /// <summary>
    ///   <para>apivc:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"SPARQL that can be used to construct a graph based on an item (identified in the SPARQL as ?item)."</para>
    /// labels<para>"Template"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#template">http://purl.org/linked-data/api/vocab#template</seealso>
    let template = Prefixed_Name(apivc, "template") |> PrefixedName
    /// <summary>
    ///   <para>apivc:uriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A template that can be used to match against request URIs. This template can contain variable names within {}s; when the URI is matched then the substrings that appear in these locations are bound to the named variable."</para>
    /// labels<para>"URI template"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#uriTemplate">http://purl.org/linked-data/api/vocab#uriTemplate</seealso>
    let uriTemplate = Prefixed_Name(apivc, "uriTemplate") |> PrefixedName
    /// <summary>
    ///   <para>apivc:viewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A viewer that can be used with the endpoint."</para>
    /// labels<para>"Viewer"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#viewer">http://purl.org/linked-data/api/vocab#viewer</seealso>
    let viewer = Prefixed_Name(apivc, "viewer") |> PrefixedName
    /// <summary>
    ///   <para>apivc:vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A vocabulary that should be used by the configuration to provide labels for properties. To be recognised for filtering, a property must be defined either within this vocabulary or in the configuration file itself."</para>
    /// labels<para>"Vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#vocabulary">http://purl.org/linked-data/api/vocab#vocabulary</seealso>
    let vocabulary = Prefixed_Name(apivc, "vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>apivc:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A GroupGraphPattern suitable for embedding within a SPARQL WHERE clause. This is used for filtering the set of items that the selector selects."</para>
    /// labels<para>"Where"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#where">http://purl.org/linked-data/api/vocab#where</seealso>
    let where = Prefixed_Name(apivc, "where") |> PrefixedName
    /// <summary>
    ///   <para>apivc:xmlFormatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>apivc:xmlFormatter</para>
    ///   <para>"A formatter that gives the default simple XML representation of an RDF graph"</para>
    /// labels<para>"Default XML Formatter"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/api/vocab#xmlFormatter">http://purl.org/linked-data/api/vocab#xmlFormatter</seealso>
    let xmlFormatter = Prefixed_Name(apivc, "xmlFormatter") |> PrefixedName
