namespace http.purl.org.linked_data.api.vocab.hash

open DoxAletheia

module apivc =
    let _namespace_name = "http://purl.org/linked-data/api/vocab#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/api/vocab#API"></see>
    /// </summary>
    let API = _prefix "API"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/api/vocab#ContentNegotiationStrategy"></see>
    /// </summary>
    let ContentNegotiationStrategy = _prefix "ContentNegotiationStrategy"
    /// <summary>
    /// A formatter that generates a simple CSV representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#CsvFormatter"></see></summary>
    let CsvFormatter = _prefix "CsvFormatter"
    /// <summary>
    /// A formatter that creates a representation from an RDF graph.
    /// <see href="http://purl.org/linked-data/api/vocab#Formatter"></see></summary>
    let Formatter = _prefix "Formatter"
    /// <summary>
    /// An endpoint exposed by the API.
    /// <see href="http://purl.org/linked-data/api/vocab#Endpoint"></see></summary>
    let Endpoint = _prefix "Endpoint"
    /// <summary>
    /// An endpoint that returns information about a single instance.
    /// <see href="http://purl.org/linked-data/api/vocab#ItemEndpoint"></see></summary>
    let ItemEndpoint = _prefix "ItemEndpoint"
    /// <summary>
    /// A formatter that generates a simple JSON representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#JsonFormatter"></see></summary>
    let JsonFormatter = _prefix "JsonFormatter"
    /// <summary>
    /// a List represents the full set of resources that match the request against the Endpoint; a Page lists a subset of the List.
    /// <see href="http://purl.org/linked-data/api/vocab#List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// An endpoint that returns information about a list of instances.
    /// <see href="http://purl.org/linked-data/api/vocab#ListEndpoint"></see></summary>
    let ListEndpoint = _prefix "ListEndpoint"
    /// <summary>
    /// A page returned in response to a request to an Endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// A formatter that generates an RDF/XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#RdfXmlFormatter"></see></summary>
    let RdfXmlFormatter = _prefix "RdfXmlFormatter"
    /// <summary>
    /// A specification of an ordered list of resources.
    /// <see href="http://purl.org/linked-data/api/vocab#Selector"></see></summary>
    let Selector = _prefix "Selector"
    /// <summary>
    /// A formatter that gives the default Turtle representation of an RDF graph
    /// A formatter that generates an Turtle representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#TurtleFormatter"></see></summary>
    let TurtleFormatter = _prefix "TurtleFormatter"
    /// <summary>
    /// A specification of a view of a particular item.
    /// <see href="http://purl.org/linked-data/api/vocab#Viewer"></see></summary>
    let Viewer = _prefix "Viewer"
    /// <summary>
    /// A formatter that generates a simple XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#XmlFormatter"></see></summary>
    let XmlFormatter = _prefix "XmlFormatter"
    /// <summary>
    /// A formatter that uses an XSLT stylesheet to generates a representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#XsltFormatter"></see></summary>
    let XsltFormatter = _prefix "XsltFormatter"
    /// <summary>
    /// The base URI of the API, which is distinct from the URI of the SPARQL endpoint that it queries or the base URI of the instances that it returns. This base URI is stripped from the request URI before any matching is done against the endpoints defined for the API.
    /// <see href="http://purl.org/linked-data/api/vocab#base"></see></summary>
    let base_ = _prefix "base"
    /// <summary>
    /// A viewer that returns the type and label of the item.
    /// <see href="http://purl.org/linked-data/api/vocab#basicViewer"></see></summary>
    let basicViewer = _prefix "basicViewer"
    /// <summary>
    /// The name of the resource.
    /// <see href="http://purl.org/linked-data/api/vocab#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A property chain (which may be a single property) that indicates information that should be included in the view.
    /// <see href="http://purl.org/linked-data/api/vocab#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// The mechanism used within the URI to override normal content negotiation and deliver a particular results format.
    /// <see href="http://purl.org/linked-data/api/vocab#contentNegotiation"></see></summary>
    let contentNegotiation = _prefix "contentNegotiation"
    /// <summary>
    /// A formatter that gives the default simple CSV representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#csvFormatter"></see></summary>
    let csvFormatter = _prefix "csvFormatter"
    /// <summary>
    /// The default formatter used if none is explicitly selected within the request URI.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultFormatter"></see></summary>
    let defaultFormatter = _prefix "defaultFormatter"
    /// <summary>
    /// The default size of lists that will be returned by the API or endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultPageSize"></see></summary>
    let defaultPageSize = _prefix "defaultPageSize"
    /// <summary>
    /// The default viewer used if none is explicitly selected within the request URI.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultViewer"></see></summary>
    let defaultViewer = _prefix "defaultViewer"
    /// <summary>
    /// The API Endpoint
    /// <see href="http://purl.org/linked-data/api/vocab#definition"></see></summary>
    let definition = _prefix "definition"
    /// <summary>
    /// A viewer that returns a graph created from a DESCRIBE query.
    /// <see href="http://purl.org/linked-data/api/vocab#describeViewer"></see></summary>
    let describeViewer = _prefix "describeViewer"
    /// <summary>
    /// An endpoint specified by the API, against which requests can be made.
    /// <see href="http://purl.org/linked-data/api/vocab#endpoint"></see></summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    /// a document containing the same data, plus extra document-centric metadata.
    /// <see href="http://purl.org/linked-data/api/vocab#extendedMetadataVersion"></see></summary>
    let extendedMetadataVersion = _prefix "extendedMetadataVersion"
    /// <summary>
    /// A set of parameter bindings in the same format as is used within the query of a URI, used to provide a simple way of filtering the sequence of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#filter"></see></summary>
    let filter = _prefix "filter"
    /// <summary>
    /// A formatter that can be used with the endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#formatter"></see></summary>
    let formatter = _prefix "formatter"
    /// <summary>
    /// Other viewers that describe properties that should be incorporated into this view.
    /// <see href="http://purl.org/linked-data/api/vocab#include"></see></summary>
    let include_ = _prefix "include"
    /// <summary>
    /// A template for the URI of the item that the item endpoint should return. Any instances of {varName} within the string are replaced by the value of the relevant variable.
    /// <see href="http://purl.org/linked-data/api/vocab#itemTemplate"></see></summary>
    let itemTemplate = _prefix "itemTemplate"
    /// <summary>
    /// The list of resources described by the page that are in the List the page is part of.
    /// <see href="http://purl.org/linked-data/api/vocab#items"></see></summary>
    let items = _prefix "items"
    /// <summary>
    /// A formatter that gives the default simple JSON representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#jsonFormatter"></see></summary>
    let jsonFormatter = _prefix "jsonFormatter"
    /// <summary>
    /// A viewer that returns the graph created from a DESCRIBE query, supplemented by labels for linked resources.
    /// <see href="http://purl.org/linked-data/api/vocab#labelledDescribeViewer"></see></summary>
    let labelledDescribeViewer = _prefix "labelledDescribeViewer"
    /// <summary>
    /// The maximum size of lists that will be returned by the API.
    /// <see href="http://purl.org/linked-data/api/vocab#maxPageSize"></see></summary>
    let maxPageSize = _prefix "maxPageSize"
    /// <summary>
    /// The mime type that the formatter returns and that it should be used with.
    /// <see href="http://purl.org/linked-data/api/vocab#mimeType"></see></summary>
    let mimeType = _prefix "mimeType"
    /// <summary>
    /// A space separated sequence of OrderConditions suitable for using in a SPARQL ORDER BY clause. This is used to order the sequence of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#orderBy"></see></summary>
    let orderBy = _prefix "orderBy"
    /// <summary>
    /// This content negotiation strategy uses the _format parameter within the URI to indicate the formatter that should be used to format the results of the request.
    /// <see href="http://purl.org/linked-data/api/vocab#parameterBased"></see></summary>
    let parameterBased = _prefix "parameterBased"
    /// <summary>
    /// The parent selector, from which filters and sort specifications may be inherited.
    /// <see href="http://purl.org/linked-data/api/vocab#parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// A comma-separated list of property paths that indicate the information that should be included in the view.
    /// <see href="http://purl.org/linked-data/api/vocab#properties"></see></summary>
    let properties = _prefix "properties"
    /// <summary>
    /// A formatter that gives the default RDF/XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#rdfXmlFormatter"></see></summary>
    let rdfXmlFormatter = _prefix "rdfXmlFormatter"
    /// <summary>
    /// A SPARQL WHERE and ORDER BY clause that can be used to select an ordered list of resources. It should include the binding of an ?item variable for the selected items.
    /// <see href="http://purl.org/linked-data/api/vocab#select"></see></summary>
    let select = _prefix "select"
    /// <summary>
    /// The selector that should be used to generate the list of items.
    /// <see href="http://purl.org/linked-data/api/vocab#selector"></see></summary>
    let selector = _prefix "selector"
    /// <summary>
    /// A sequence of comma-separated sort specifications indicating the sorting of the items in the sequence that the selector selects. A leading hyphen indicates a reverse sort.
    /// <see href="http://purl.org/linked-data/api/vocab#sort"></see></summary>
    let sort = _prefix "sort"
    /// <summary>
    /// The endpoint used to serve up the results that are exposed by the API. This should not include the query parameters within the URI.
    /// <see href="http://purl.org/linked-data/api/vocab#sparqlEndpoint"></see></summary>
    let sparqlEndpoint = _prefix "sparqlEndpoint"
    /// <summary>
    /// The XSLT stylesheet that should be used by an XSLT formatter to generate a representation of the RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#stylesheet"></see></summary>
    let stylesheet = _prefix "stylesheet"
    /// <summary>
    /// This content negotiation strategy uses the suffix used on the last segment within the request URI to indicate the formatter that should be used to format the results of the request.
    /// <see href="http://purl.org/linked-data/api/vocab#suffixBased"></see></summary>
    let suffixBased = _prefix "suffixBased"
    /// <summary>
    /// SPARQL that can be used to construct a graph based on an item (identified in the SPARQL as ?item).
    /// <see href="http://purl.org/linked-data/api/vocab#template"></see></summary>
    let template = _prefix "template"
    /// <summary>
    /// A template that can be used to match against request URIs. This template can contain variable names within {}s; when the URI is matched then the substrings that appear in these locations are bound to the named variable.
    /// <see href="http://purl.org/linked-data/api/vocab#uriTemplate"></see></summary>
    let uriTemplate = _prefix "uriTemplate"
    /// <summary>
    /// A viewer that can be used with the endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#viewer"></see></summary>
    let viewer = _prefix "viewer"
    /// <summary>
    /// A vocabulary that should be used by the configuration to provide labels for properties. To be recognised for filtering, a property must be defined either within this vocabulary or in the configuration file itself.
    /// <see href="http://purl.org/linked-data/api/vocab#vocabulary"></see></summary>
    let vocabulary = _prefix "vocabulary"
    /// <summary>
    /// A GroupGraphPattern suitable for embedding within a SPARQL WHERE clause. This is used for filtering the set of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#where"></see></summary>
    let where = _prefix "where"
    /// <summary>
    /// A formatter that gives the default simple XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#xmlFormatter"></see></summary>
    let xmlFormatter = _prefix "xmlFormatter"
