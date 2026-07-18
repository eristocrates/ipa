namespace http.purl.org.linked_data.api.vocab.hash

open DoxAletheia.Rdf_Vocabulary

module apivc =
    let _namespace_name = "http://purl.org/linked-data/api/vocab#"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/api/vocab#API"></see>
    /// </summary>
    let API = Namespaced_IRI.parse _namespace_name "API" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/api/vocab#ContentNegotiationStrategy"></see>
    /// </summary>
    let ContentNegotiationStrategy =
        Namespaced_IRI.parse _namespace_name "ContentNegotiationStrategy" |> NamespacedName

    /// <summary>
    /// A formatter that generates a simple CSV representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#CsvFormatter"></see></summary>
    let CsvFormatter =
        Namespaced_IRI.parse _namespace_name "CsvFormatter" |> NamespacedName

    /// <summary>
    /// A formatter that creates a representation from an RDF graph.
    /// <see href="http://purl.org/linked-data/api/vocab#Formatter"></see></summary>
    let Formatter = Namespaced_IRI.parse _namespace_name "Formatter" |> NamespacedName
    /// <summary>
    /// An endpoint exposed by the API.
    /// <see href="http://purl.org/linked-data/api/vocab#Endpoint"></see></summary>
    let Endpoint = Namespaced_IRI.parse _namespace_name "Endpoint" |> NamespacedName

    /// <summary>
    /// An endpoint that returns information about a single instance.
    /// <see href="http://purl.org/linked-data/api/vocab#ItemEndpoint"></see></summary>
    let ItemEndpoint =
        Namespaced_IRI.parse _namespace_name "ItemEndpoint" |> NamespacedName

    /// <summary>
    /// A formatter that generates a simple JSON representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#JsonFormatter"></see></summary>
    let JsonFormatter =
        Namespaced_IRI.parse _namespace_name "JsonFormatter" |> NamespacedName

    /// <summary>
    /// a List represents the full set of resources that match the request against the Endpoint; a Page lists a subset of the List.
    /// <see href="http://purl.org/linked-data/api/vocab#List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName

    /// <summary>
    /// An endpoint that returns information about a list of instances.
    /// <see href="http://purl.org/linked-data/api/vocab#ListEndpoint"></see></summary>
    let ListEndpoint =
        Namespaced_IRI.parse _namespace_name "ListEndpoint" |> NamespacedName

    /// <summary>
    /// A page returned in response to a request to an Endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName

    /// <summary>
    /// A formatter that generates an RDF/XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#RdfXmlFormatter"></see></summary>
    let RdfXmlFormatter =
        Namespaced_IRI.parse _namespace_name "RdfXmlFormatter" |> NamespacedName

    /// <summary>
    /// A specification of an ordered list of resources.
    /// <see href="http://purl.org/linked-data/api/vocab#Selector"></see></summary>
    let Selector = Namespaced_IRI.parse _namespace_name "Selector" |> NamespacedName

    /// <summary>
    /// A formatter that gives the default Turtle representation of an RDF graph
    /// A formatter that generates an Turtle representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#TurtleFormatter"></see></summary>
    let TurtleFormatter =
        Namespaced_IRI.parse _namespace_name "TurtleFormatter" |> NamespacedName

    /// <summary>
    /// A specification of a view of a particular item.
    /// <see href="http://purl.org/linked-data/api/vocab#Viewer"></see></summary>
    let Viewer = Namespaced_IRI.parse _namespace_name "Viewer" |> NamespacedName

    /// <summary>
    /// A formatter that generates a simple XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#XmlFormatter"></see></summary>
    let XmlFormatter =
        Namespaced_IRI.parse _namespace_name "XmlFormatter" |> NamespacedName

    /// <summary>
    /// A formatter that uses an XSLT stylesheet to generates a representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#XsltFormatter"></see></summary>
    let XsltFormatter =
        Namespaced_IRI.parse _namespace_name "XsltFormatter" |> NamespacedName

    /// <summary>
    /// The base URI of the API, which is distinct from the URI of the SPARQL endpoint that it queries or the base URI of the instances that it returns. This base URI is stripped from the request URI before any matching is done against the endpoints defined for the API.
    /// <see href="http://purl.org/linked-data/api/vocab#base"></see></summary>
    let base_ = Namespaced_IRI.parse _namespace_name "base" |> NamespacedName

    /// <summary>
    /// A viewer that returns the type and label of the item.
    /// <see href="http://purl.org/linked-data/api/vocab#basicViewer"></see></summary>
    let basicViewer =
        Namespaced_IRI.parse _namespace_name "basicViewer" |> NamespacedName

    /// <summary>
    /// The name of the resource.
    /// <see href="http://purl.org/linked-data/api/vocab#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// A property chain (which may be a single property) that indicates information that should be included in the view.
    /// <see href="http://purl.org/linked-data/api/vocab#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// The mechanism used within the URI to override normal content negotiation and deliver a particular results format.
    /// <see href="http://purl.org/linked-data/api/vocab#contentNegotiation"></see></summary>
    let contentNegotiation =
        Namespaced_IRI.parse _namespace_name "contentNegotiation" |> NamespacedName

    /// <summary>
    /// A formatter that gives the default simple CSV representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#csvFormatter"></see></summary>
    let csvFormatter =
        Namespaced_IRI.parse _namespace_name "csvFormatter" |> NamespacedName

    /// <summary>
    /// The default formatter used if none is explicitly selected within the request URI.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultFormatter"></see></summary>
    let defaultFormatter =
        Namespaced_IRI.parse _namespace_name "defaultFormatter" |> NamespacedName

    /// <summary>
    /// The default size of lists that will be returned by the API or endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultPageSize"></see></summary>
    let defaultPageSize =
        Namespaced_IRI.parse _namespace_name "defaultPageSize" |> NamespacedName

    /// <summary>
    /// The default viewer used if none is explicitly selected within the request URI.
    /// <see href="http://purl.org/linked-data/api/vocab#defaultViewer"></see></summary>
    let defaultViewer =
        Namespaced_IRI.parse _namespace_name "defaultViewer" |> NamespacedName

    /// <summary>
    /// The API Endpoint
    /// <see href="http://purl.org/linked-data/api/vocab#definition"></see></summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName

    /// <summary>
    /// A viewer that returns a graph created from a DESCRIBE query.
    /// <see href="http://purl.org/linked-data/api/vocab#describeViewer"></see></summary>
    let describeViewer =
        Namespaced_IRI.parse _namespace_name "describeViewer" |> NamespacedName

    /// <summary>
    /// An endpoint specified by the API, against which requests can be made.
    /// <see href="http://purl.org/linked-data/api/vocab#endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    /// a document containing the same data, plus extra document-centric metadata.
    /// <see href="http://purl.org/linked-data/api/vocab#extendedMetadataVersion"></see></summary>
    let extendedMetadataVersion =
        Namespaced_IRI.parse _namespace_name "extendedMetadataVersion" |> NamespacedName

    /// <summary>
    /// A set of parameter bindings in the same format as is used within the query of a URI, used to provide a simple way of filtering the sequence of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#filter"></see></summary>
    let filter = Namespaced_IRI.parse _namespace_name "filter" |> NamespacedName
    /// <summary>
    /// A formatter that can be used with the endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#formatter"></see></summary>
    let formatter = Namespaced_IRI.parse _namespace_name "formatter" |> NamespacedName
    /// <summary>
    /// Other viewers that describe properties that should be incorporated into this view.
    /// <see href="http://purl.org/linked-data/api/vocab#include"></see></summary>
    let include_ = Namespaced_IRI.parse _namespace_name "include" |> NamespacedName

    /// <summary>
    /// A template for the URI of the item that the item endpoint should return. Any instances of {varName} within the string are replaced by the value of the relevant variable.
    /// <see href="http://purl.org/linked-data/api/vocab#itemTemplate"></see></summary>
    let itemTemplate =
        Namespaced_IRI.parse _namespace_name "itemTemplate" |> NamespacedName

    /// <summary>
    /// The list of resources described by the page that are in the List the page is part of.
    /// <see href="http://purl.org/linked-data/api/vocab#items"></see></summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName

    /// <summary>
    /// A formatter that gives the default simple JSON representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#jsonFormatter"></see></summary>
    let jsonFormatter =
        Namespaced_IRI.parse _namespace_name "jsonFormatter" |> NamespacedName

    /// <summary>
    /// A viewer that returns the graph created from a DESCRIBE query, supplemented by labels for linked resources.
    /// <see href="http://purl.org/linked-data/api/vocab#labelledDescribeViewer"></see></summary>
    let labelledDescribeViewer =
        Namespaced_IRI.parse _namespace_name "labelledDescribeViewer" |> NamespacedName

    /// <summary>
    /// The maximum size of lists that will be returned by the API.
    /// <see href="http://purl.org/linked-data/api/vocab#maxPageSize"></see></summary>
    let maxPageSize =
        Namespaced_IRI.parse _namespace_name "maxPageSize" |> NamespacedName

    /// <summary>
    /// The mime type that the formatter returns and that it should be used with.
    /// <see href="http://purl.org/linked-data/api/vocab#mimeType"></see></summary>
    let mimeType = Namespaced_IRI.parse _namespace_name "mimeType" |> NamespacedName
    /// <summary>
    /// A space separated sequence of OrderConditions suitable for using in a SPARQL ORDER BY clause. This is used to order the sequence of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#orderBy"></see></summary>
    let orderBy = Namespaced_IRI.parse _namespace_name "orderBy" |> NamespacedName

    /// <summary>
    /// This content negotiation strategy uses the _format parameter within the URI to indicate the formatter that should be used to format the results of the request.
    /// <see href="http://purl.org/linked-data/api/vocab#parameterBased"></see></summary>
    let parameterBased =
        Namespaced_IRI.parse _namespace_name "parameterBased" |> NamespacedName

    /// <summary>
    /// The parent selector, from which filters and sort specifications may be inherited.
    /// <see href="http://purl.org/linked-data/api/vocab#parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// A comma-separated list of property paths that indicate the information that should be included in the view.
    /// <see href="http://purl.org/linked-data/api/vocab#properties"></see></summary>
    let properties = Namespaced_IRI.parse _namespace_name "properties" |> NamespacedName

    /// <summary>
    /// A formatter that gives the default RDF/XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#rdfXmlFormatter"></see></summary>
    let rdfXmlFormatter =
        Namespaced_IRI.parse _namespace_name "rdfXmlFormatter" |> NamespacedName

    /// <summary>
    /// A SPARQL WHERE and ORDER BY clause that can be used to select an ordered list of resources. It should include the binding of an ?item variable for the selected items.
    /// <see href="http://purl.org/linked-data/api/vocab#select"></see></summary>
    let select = Namespaced_IRI.parse _namespace_name "select" |> NamespacedName
    /// <summary>
    /// The selector that should be used to generate the list of items.
    /// <see href="http://purl.org/linked-data/api/vocab#selector"></see></summary>
    let selector = Namespaced_IRI.parse _namespace_name "selector" |> NamespacedName
    /// <summary>
    /// A sequence of comma-separated sort specifications indicating the sorting of the items in the sequence that the selector selects. A leading hyphen indicates a reverse sort.
    /// <see href="http://purl.org/linked-data/api/vocab#sort"></see></summary>
    let sort = Namespaced_IRI.parse _namespace_name "sort" |> NamespacedName

    /// <summary>
    /// The endpoint used to serve up the results that are exposed by the API. This should not include the query parameters within the URI.
    /// <see href="http://purl.org/linked-data/api/vocab#sparqlEndpoint"></see></summary>
    let sparqlEndpoint =
        Namespaced_IRI.parse _namespace_name "sparqlEndpoint" |> NamespacedName

    /// <summary>
    /// The XSLT stylesheet that should be used by an XSLT formatter to generate a representation of the RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#stylesheet"></see></summary>
    let stylesheet = Namespaced_IRI.parse _namespace_name "stylesheet" |> NamespacedName

    /// <summary>
    /// This content negotiation strategy uses the suffix used on the last segment within the request URI to indicate the formatter that should be used to format the results of the request.
    /// <see href="http://purl.org/linked-data/api/vocab#suffixBased"></see></summary>
    let suffixBased =
        Namespaced_IRI.parse _namespace_name "suffixBased" |> NamespacedName

    /// <summary>
    /// SPARQL that can be used to construct a graph based on an item (identified in the SPARQL as ?item).
    /// <see href="http://purl.org/linked-data/api/vocab#template"></see></summary>
    let template = Namespaced_IRI.parse _namespace_name "template" |> NamespacedName

    /// <summary>
    /// A template that can be used to match against request URIs. This template can contain variable names within {}s; when the URI is matched then the substrings that appear in these locations are bound to the named variable.
    /// <see href="http://purl.org/linked-data/api/vocab#uriTemplate"></see></summary>
    let uriTemplate =
        Namespaced_IRI.parse _namespace_name "uriTemplate" |> NamespacedName

    /// <summary>
    /// A viewer that can be used with the endpoint.
    /// <see href="http://purl.org/linked-data/api/vocab#viewer"></see></summary>
    let viewer = Namespaced_IRI.parse _namespace_name "viewer" |> NamespacedName
    /// <summary>
    /// A vocabulary that should be used by the configuration to provide labels for properties. To be recognised for filtering, a property must be defined either within this vocabulary or in the configuration file itself.
    /// <see href="http://purl.org/linked-data/api/vocab#vocabulary"></see></summary>
    let vocabulary = Namespaced_IRI.parse _namespace_name "vocabulary" |> NamespacedName
    /// <summary>
    /// A GroupGraphPattern suitable for embedding within a SPARQL WHERE clause. This is used for filtering the set of items that the selector selects.
    /// <see href="http://purl.org/linked-data/api/vocab#where"></see></summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName

    /// <summary>
    /// A formatter that gives the default simple XML representation of an RDF graph
    /// <see href="http://purl.org/linked-data/api/vocab#xmlFormatter"></see></summary>
    let xmlFormatter =
        Namespaced_IRI.parse _namespace_name "xmlFormatter" |> NamespacedName
