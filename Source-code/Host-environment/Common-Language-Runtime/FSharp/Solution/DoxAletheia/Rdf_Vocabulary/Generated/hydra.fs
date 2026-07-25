namespace http.www.w3.org.ns.hydra.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hydra =
    let _namespace_iri = Namespace_Iri hydra |> NamespaceIRI

    /// <summary>
    ///   <para>hydra:BasicRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A representation that serializes just the lexical form, but omits language and type information.</para>
    /// labels<para>basic value representation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#BasicRepresentation">http://www.w3.org/ns/hydra/core#BasicRepresentation</seealso>
    let BasicRepresentation =
        Prefixed_Name(hydra, "BasicRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>An operation.</para>
    /// labels<para>Operation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Operation">http://www.w3.org/ns/hydra/core#Operation</seealso>
    let Operation = Prefixed_Name(hydra, "Operation") |> PrefixedName
    /// <summary>
    ///   <para>hydra:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>Additional information about a status code that might be returned.</para>
    /// labels<para>Status code description</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Status">http://www.w3.org/ns/hydra/core#Status</seealso>
    let Status = Prefixed_Name(hydra, "Status") |> PrefixedName
    /// <summary>
    ///   <para>hydra:ApiDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>The Hydra API documentation class</para>
    /// labels<para>ApiDocumentation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#ApiDocumentation">http://www.w3.org/ns/hydra/core#ApiDocumentation</seealso>
    let ApiDocumentation = Prefixed_Name(hydra, "ApiDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:CreateResourceOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A CreateResourceOperation is a HTTP operation which expects an input of the type specified by hydra:expects and creates a resource of the type specified by hydra:returns.</para>
    /// labels<para>CreateResourceOperation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#CreateResourceOperation">http://www.w3.org/ns/hydra/core#CreateResourceOperation</seealso>
    let CreateResourceOperation =
        Prefixed_Name(hydra, "CreateResourceOperation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A runtime error, used to report information beyond the returned status code.</para>
    /// labels<para>Error</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Error">http://www.w3.org/ns/hydra/core#Error</seealso>
    let Error = Prefixed_Name(hydra, "Error") |> PrefixedName
    /// <summary>
    ///   <para>hydra:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#property">http://www.w3.org/ns/hydra/core#property</seealso>
    let property = Prefixed_Name(hydra, "property") |> PrefixedName
    /// <summary>
    ///   <para>hydra:required</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True if the property is required, false otherwise.</para>
    /// labels<para>required</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#required">http://www.w3.org/ns/hydra/core#required</seealso>
    let required = Prefixed_Name(hydra, "required") |> PrefixedName
    /// <summary>
    ///   <para>hydra:statusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The HTTP status code</para>
    /// labels<para>status code</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#statusCode">http://www.w3.org/ns/hydra/core#statusCode</seealso>
    let statusCode = Prefixed_Name(hydra, "statusCode") |> PrefixedName
    /// <summary>
    ///   <para>hydra:supportedOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>An operation supported by instances of the specific Hydra class or the target of the Hydra link</para>
    /// labels<para>supported operation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#supportedOperation">http://www.w3.org/ns/hydra/core#supportedOperation</seealso>
    let supportedOperation = Prefixed_Name(hydra, "supportedOperation") |> PrefixedName
    /// <summary>
    ///   <para>hydra:supportedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The properties known to be supported by a Hydra class</para>
    /// labels<para>supported properties</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#supportedProperty">http://www.w3.org/ns/hydra/core#supportedProperty</seealso>
    let supportedProperty = Prefixed_Name(hydra, "supportedProperty") |> PrefixedName
    /// <summary>
    ///   <para>hydra:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A title, often used along with a description.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#title">http://www.w3.org/ns/hydra/core#title</seealso>
    let title = Prefixed_Name(hydra, "title") |> PrefixedName
    /// <summary>
    ///   <para>hydra:totalItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of items referenced by a collection or a set of interlinked PagedCollections.</para>
    /// labels<para>total items</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#totalItems">http://www.w3.org/ns/hydra/core#totalItems</seealso>
    let totalItems = Prefixed_Name(hydra, "totalItems") |> PrefixedName
    /// <summary>
    ///   <para>hydra:variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An IRI template variable</para>
    /// labels<para>variable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#variable">http://www.w3.org/ns/hydra/core#variable</seealso>
    let variable = Prefixed_Name(hydra, "variable") |> PrefixedName
    /// <summary>
    ///   <para>hydra:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>The class of dereferenceable resources.</para>
    /// labels<para>Hydra Resource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Resource">http://www.w3.org/ns/hydra/core#Resource</seealso>
    let Resource = Prefixed_Name(hydra, "Resource") |> PrefixedName

    /// <summary>
    ///   <para>hydra:DeleteResourceOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A DeleteResourceOperation is a HTTP operation that deletes a resource.</para>
    /// labels<para>DeleteResourceOperation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#DeleteResourceOperation">http://www.w3.org/ns/hydra/core#DeleteResourceOperation</seealso>
    let DeleteResourceOperation =
        Prefixed_Name(hydra, "DeleteResourceOperation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:IriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>The class of IRI templates.</para>
    /// labels<para>IRI Template</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#IriTemplate">http://www.w3.org/ns/hydra/core#IriTemplate</seealso>
    let IriTemplate = Prefixed_Name(hydra, "IriTemplate") |> PrefixedName
    /// <summary>
    ///   <para>hydra:IriTemplateMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A mapping from an IRI template variable to a property.</para>
    /// labels<para>IriTemplateMapping</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#IriTemplateMapping">http://www.w3.org/ns/hydra/core#IriTemplateMapping</seealso>
    let IriTemplateMapping = Prefixed_Name(hydra, "IriTemplateMapping") |> PrefixedName

    /// <summary>
    ///   <para>hydra:ReplaceResourceOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A ReplaceResourceOperation is a HTTP operation which overwrites a resource. It expects data of the type specified in hydra:expects and results in a resource of the type specified by hydra:returns.</para>
    /// labels<para>ReplaceResourceOperation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#ReplaceResourceOperation">http://www.w3.org/ns/hydra/core#ReplaceResourceOperation</seealso>
    let ReplaceResourceOperation =
        Prefixed_Name(hydra, "ReplaceResourceOperation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:ExplicitRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A representation that serializes a value including its language and type information and thus differentiating between IRIs and literals.</para>
    /// labels<para>explicit value representation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#ExplicitRepresentation">http://www.w3.org/ns/hydra/core#ExplicitRepresentation</seealso>
    let ExplicitRepresentation =
        Prefixed_Name(hydra, "ExplicitRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>The class of properties representing links.</para>
    /// labels<para>Link</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Link">http://www.w3.org/ns/hydra/core#Link</seealso>
    let Link = Prefixed_Name(hydra, "Link") |> PrefixedName
    /// <summary>
    ///   <para>hydra:TemplatedLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A templated link.</para>
    /// labels<para>Templated Link</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#TemplatedLink">http://www.w3.org/ns/hydra/core#TemplatedLink</seealso>
    let TemplatedLink = Prefixed_Name(hydra, "TemplatedLink") |> PrefixedName
    /// <summary>
    ///   <para>hydra:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A description.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#description">http://www.w3.org/ns/hydra/core#description</seealso>
    let description = Prefixed_Name(hydra, "description") |> PrefixedName
    /// <summary>
    ///   <para>hydra:entrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>A link to main entry point of the Web API</para>
    /// labels<para>entrypoint</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#entrypoint">http://www.w3.org/ns/hydra/core#entrypoint</seealso>
    let entrypoint = Prefixed_Name(hydra, "entrypoint") |> PrefixedName
    /// <summary>
    ///   <para>hydra:PagedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A PagedCollection is a subclass of Collection with the only difference that its members are sorted and only a subset of all members are returned in a single PagedCollection. To get the other members, the nextPage/previousPage properties have to be used.</para>
    /// labels<para>PagedCollection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#PagedCollection">http://www.w3.org/ns/hydra/core#PagedCollection</seealso>
    let PagedCollection = Prefixed_Name(hydra, "PagedCollection") |> PrefixedName
    /// <summary>
    ///   <para>hydra:SupportedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A property known to be supported by a Hydra class.</para>
    /// labels<para>Supported Property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#SupportedProperty">http://www.w3.org/ns/hydra/core#SupportedProperty</seealso>
    let SupportedProperty = Prefixed_Name(hydra, "SupportedProperty") |> PrefixedName
    /// <summary>
    ///   <para>hydra:apiDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>A link to the API documentation</para>
    /// labels<para>apiDocumentation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#apiDocumentation">http://www.w3.org/ns/hydra/core#apiDocumentation</seealso>
    let apiDocumentation = Prefixed_Name(hydra, "apiDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>hydra:expects</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The information expected by the Web API.</para>
    /// labels<para>expects</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#expects">http://www.w3.org/ns/hydra/core#expects</seealso>
    let expects = Prefixed_Name(hydra, "expects") |> PrefixedName
    /// <summary>
    ///   <para>hydra:firstPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The first page of an interlinked set of PagedCollections</para>
    /// labels<para>first page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#firstPage">http://www.w3.org/ns/hydra/core#firstPage</seealso>
    let firstPage = Prefixed_Name(hydra, "firstPage") |> PrefixedName
    /// <summary>
    ///   <para>hydra:freetextQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property representing a freetext query.</para>
    /// labels<para>freetext query</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#freetextQuery">http://www.w3.org/ns/hydra/core#freetextQuery</seealso>
    let freetextQuery = Prefixed_Name(hydra, "freetextQuery") |> PrefixedName
    /// <summary>
    ///   <para>hydra:itemsPerPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The maximum number of items referenced by each single PagedCollection in a set of interlinked PagedCollections.</para>
    /// labels<para>items per page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#itemsPerPage">http://www.w3.org/ns/hydra/core#itemsPerPage</seealso>
    let itemsPerPage = Prefixed_Name(hydra, "itemsPerPage") |> PrefixedName
    /// <summary>
    ///   <para>hydra:mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A variable-to-property mapping of the IRI template.</para>
    /// labels<para>mapping</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#mapping">http://www.w3.org/ns/hydra/core#mapping</seealso>
    let mapping = Prefixed_Name(hydra, "mapping") |> PrefixedName
    /// <summary>
    ///   <para>hydra:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The HTTP method.</para>
    /// labels<para>method</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#method">http://www.w3.org/ns/hydra/core#method</seealso>
    let method = Prefixed_Name(hydra, "method") |> PrefixedName
    /// <summary>
    ///   <para>hydra:lastPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The last page of an interlinked set of PagedCollections</para>
    /// labels<para>last page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#lastPage">http://www.w3.org/ns/hydra/core#lastPage</seealso>
    let lastPage = Prefixed_Name(hydra, "lastPage") |> PrefixedName
    /// <summary>
    ///   <para>hydra:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>A member of the collection</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#member">http://www.w3.org/ns/hydra/core#member</seealso>
    let member_ = Prefixed_Name(hydra, "member") |> PrefixedName
    /// <summary>
    ///   <para>hydra:operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>An operation supported by the Hydra resource</para>
    /// labels<para>operation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#operation">http://www.w3.org/ns/hydra/core#operation</seealso>
    let operation = Prefixed_Name(hydra, "operation") |> PrefixedName
    /// <summary>
    ///   <para>hydra:nextPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The page following the current instance in an interlinked set of PagedCollections</para>
    /// labels<para>next page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#nextPage">http://www.w3.org/ns/hydra/core#nextPage</seealso>
    let nextPage = Prefixed_Name(hydra, "nextPage") |> PrefixedName
    /// <summary>
    ///   <para>hydra:possibleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>A status that might be returned by the Web API (other statuses should be expected and properly handled as well)</para>
    /// labels<para>possible status</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#possibleStatus">http://www.w3.org/ns/hydra/core#possibleStatus</seealso>
    let possibleStatus = Prefixed_Name(hydra, "possibleStatus") |> PrefixedName
    /// <summary>
    ///   <para>hydra:previousPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The page preceding the current instance in an interlinked set of PagedCollections</para>
    /// labels<para>previous page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#previousPage">http://www.w3.org/ns/hydra/core#previousPage</seealso>
    let previousPage = Prefixed_Name(hydra, "previousPage") |> PrefixedName
    /// <summary>
    ///   <para>hydra:readable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True if the client can retrieve the property's value, false otherwise.</para>
    /// labels<para>readable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#readable">http://www.w3.org/ns/hydra/core#readable</seealso>
    let readable = Prefixed_Name(hydra, "readable") |> PrefixedName
    /// <summary>
    ///   <para>hydra:returns</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>The information returned by the Web API on success</para>
    /// labels<para>returns</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#returns">http://www.w3.org/ns/hydra/core#returns</seealso>
    let returns = Prefixed_Name(hydra, "returns") |> PrefixedName
    /// <summary>
    ///   <para>hydra:search</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:TemplatedLink</para>
    ///   <para>A IRI template that can be used to query a collection</para>
    /// labels<para>search</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#search">http://www.w3.org/ns/hydra/core#search</seealso>
    let search = Prefixed_Name(hydra, "search") |> PrefixedName
    /// <summary>
    ///   <para>hydra:supportedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Link</para>
    ///   <para>A class known to be supported by the Web API</para>
    /// labels<para>supported classes</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#supportedClass">http://www.w3.org/ns/hydra/core#supportedClass</seealso>
    let supportedClass = Prefixed_Name(hydra, "supportedClass") |> PrefixedName
    /// <summary>
    ///   <para>hydra:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An IRI template as defined by RFC6570.</para>
    /// labels<para>template</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#template">http://www.w3.org/ns/hydra/core#template</seealso>
    let template = Prefixed_Name(hydra, "template") |> PrefixedName

    /// <summary>
    ///   <para>hydra:variableRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The representation format to use when expanding the IRI template.</para>
    /// labels<para>variable representation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#variableRepresentation">http://www.w3.org/ns/hydra/core#variableRepresentation</seealso>
    let variableRepresentation =
        Prefixed_Name(hydra, "variableRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>hydra:writeable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True if the client can change the property's value, false otherwise.</para>
    /// labels<para>writeable</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#writeable">http://www.w3.org/ns/hydra/core#writeable</seealso>
    let writeable = Prefixed_Name(hydra, "writeable") |> PrefixedName
    /// <summary>
    ///   <para>hydra:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Resource</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of Hydra classes. Hydra classes and their instances are dereferenceable resources.</para>
    /// labels<para>Hydra Class</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Class">http://www.w3.org/ns/hydra/core#Class</seealso>
    let Class = Prefixed_Name(hydra, "Class") |> PrefixedName
    /// <summary>
    ///   <para>hydra:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>hydra:Class</para>
    ///   <para>A collection holding references to a number of related resources.</para>
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/hydra/core#Collection">http://www.w3.org/ns/hydra/core#Collection</seealso>
    let Collection = Prefixed_Name(hydra, "Collection") |> PrefixedName
