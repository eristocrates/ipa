namespace http.open_services.net.ns.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oslc =
    let _namespace_iri = Namespace_Iri oslc |> NamespaceIRI
    /// <summary>
    ///   <para>oslc:AllowedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Allowed values for one property.</para>
    /// labels<para>AllowedValues</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#AllowedValues">http://open-services.net/ns/core#AllowedValues</seealso>
    let AllowedValues = Prefixed_Name(oslc, "AllowedValues") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Comment resource represents a single note, or comment, in a discussion thread.</para>
    /// labels<para>Comment</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Comment">http://open-services.net/ns/core#Comment</seealso>
    let Comment = Prefixed_Name(oslc, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>oslc:CreationFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The CreationFactory definition included in a ServiceProvider.</para>
    /// labels<para>CreationFactory</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#CreationFactory">http://open-services.net/ns/core#CreationFactory</seealso>
    let CreationFactory = Prefixed_Name(oslc, "CreationFactory") |> PrefixedName
    /// <summary>
    ///   <para>oslc:oauthAccessTokenURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URI for obtaining OAuth access token.</para>
    /// labels<para>oauthAccessTokenURI</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthAccessTokenURI">http://open-services.net/ns/core#oauthAccessTokenURI</seealso>
    let oauthAccessTokenURI = Prefixed_Name(oslc, "oauthAccessTokenURI") |> PrefixedName
    /// <summary>
    ///   <para>oslc:partOfDiscussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Reference to owning Discussion resource .</para>
    /// labels<para>partOfDiscussion</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#partOfDiscussion">http://open-services.net/ns/core#partOfDiscussion</seealso>
    let partOfDiscussion = Prefixed_Name(oslc, "partOfDiscussion") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefixBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The base URI of the namespace.</para>
    /// labels<para>prefixBase</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefixBase">http://open-services.net/ns/core#prefixBase</seealso>
    let prefixBase = Prefixed_Name(oslc, "prefixBase") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefixDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines a namespace prefix for use in JSON representations and in forming OSLC Query Syntax strings.</para>
    /// labels<para>prefixDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefixDefinition">http://open-services.net/ns/core#prefixDefinition</seealso>
    let prefixDefinition = Prefixed_Name(oslc, "prefixDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:queryCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Enables clients query across a collection of resources.</para>
    /// labels<para>queryCapability</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#queryCapability">http://open-services.net/ns/core#queryCapability</seealso>
    let queryCapability = Prefixed_Name(oslc, "queryCapability") |> PrefixedName
    /// <summary>
    ///   <para>oslc:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Should be http://open-services.net/ns/core#Reference, http://open-services.net/ns/core#Inline or http://open-services.net/ns/core#Either</para>
    /// labels<para>representation</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#representation">http://open-services.net/ns/core#representation</seealso>
    let representation = Prefixed_Name(oslc, "representation") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A hint that indicates that property MAY be hidden when presented in a user interface.</para>
    /// labels<para>hidden</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hidden">http://open-services.net/ns/core#hidden</seealso>
    let hidden = Prefixed_Name(oslc, "hidden") |> PrefixedName
    /// <summary>
    ///   <para>oslc:AnyResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>AnyResource: value is either a Resource or Local Resource.</para>
    /// labels<para>AnyResource</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#AnyResource">http://open-services.net/ns/core#AnyResource</seealso>
    let AnyResource = Prefixed_Name(oslc, "AnyResource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Compact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Compact representation, fetched as application/x-oslc-compact+xml</para>
    /// labels<para>Compact</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Compact">http://open-services.net/ns/core#Compact</seealso>
    let Compact = Prefixed_Name(oslc, "Compact") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Discussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Discussion resource is intended to represent a sequence of comments or notes regarding the associated resource</para>
    /// labels<para>Discussion</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Discussion">http://open-services.net/ns/core#Discussion</seealso>
    let Discussion = Prefixed_Name(oslc, "Discussion") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Either</para>
    /// </summary>
    /// <remarks>
    ///   <para>Representations is either a URI reference or blank node.</para>
    /// labels<para>Either</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Either">http://open-services.net/ns/core#Either</seealso>
    let Either = Prefixed_Name(oslc, "Either") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Basis for forming an error response.</para>
    /// labels<para>Error</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Error">http://open-services.net/ns/core#Error</seealso>
    let Error = Prefixed_Name(oslc, "Error") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Exactly-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>Property with value is required.</para>
    /// labels<para>Exactly-one</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Exactly-one">http://open-services.net/ns/core#Exactly-one</seealso>
    let Exactly_one = Prefixed_Name(oslc, "Exactly-one") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Inline</para>
    /// </summary>
    /// <remarks>
    ///   <para>An inline (RDF blank node) representation.</para>
    /// labels<para>Inline</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Inline">http://open-services.net/ns/core#Inline</seealso>
    let Inline = Prefixed_Name(oslc, "Inline") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The UI Preview representation.</para>
    /// labels<para>Preview</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Preview">http://open-services.net/ns/core#Preview</seealso>
    let Preview = Prefixed_Name(oslc, "Preview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Any</para>
    /// </summary>
    /// <remarks>
    ///   <para>Any value type is allowed.</para>
    /// labels<para>Any</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Any">http://open-services.net/ns/core#Any</seealso>
    let Any = Prefixed_Name(oslc, "Any") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Dialog definition included in ServiceProvider.</para>
    /// labels<para>Dialog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Dialog">http://open-services.net/ns/core#Dialog</seealso>
    let Dialog = Prefixed_Name(oslc, "Dialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:propertyDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URI of the property whose usage is being described.</para>
    /// labels<para>propertyDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#propertyDefinition">http://open-services.net/ns/core#propertyDefinition</seealso>
    let propertyDefinition = Prefixed_Name(oslc, "propertyDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For properties with a resource value-type, Providers MAY also specify the range of possible resource types allowed, each specified by URI. The default range is http://open-services.net/ns/core#Any.</para>
    /// labels<para>range</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#range">http://open-services.net/ns/core#range</seealso>
    let range = Prefixed_Name(oslc, "range") |> PrefixedName
    /// <summary>
    ///   <para>oslc:selectionDialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Enables clients to select a resource via UI.</para>
    /// labels<para>selectionDialog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#selectionDialog">http://open-services.net/ns/core#selectionDialog</seealso>
    let selectionDialog = Prefixed_Name(oslc, "selectionDialog") |> PrefixedName

    /// <summary>
    ///   <para>oslc:serviceProviderCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Additional service provider catalog.</para>
    /// labels<para>serviceProviderCatalog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#serviceProviderCatalog">http://open-services.net/ns/core#serviceProviderCatalog</seealso>
    let serviceProviderCatalog =
        Prefixed_Name(oslc, "serviceProviderCatalog") |> PrefixedName

    /// <summary>
    ///   <para>oslc:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorter form of dcterms:title for the resource.</para>
    /// labels<para>shortTitle</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#shortTitle">http://open-services.net/ns/core#shortTitle</seealso>
    let shortTitle = Prefixed_Name(oslc, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>oslc:discussionAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Reference to associated resource.</para>
    /// labels<para>discussionAbout</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#discussionAbout">http://open-services.net/ns/core#discussionAbout</seealso>
    let discussionAbout = Prefixed_Name(oslc, "discussionAbout") |> PrefixedName
    /// <summary>
    ///   <para>oslc:extendedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Extended (additional) error information.</para>
    /// labels<para>extendedError</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#extendedError">http://open-services.net/ns/core#extendedError</seealso>
    let extendedError = Prefixed_Name(oslc, "extendedError") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hintWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).</para>
    /// labels<para>hintWidth</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hintWidth">http://open-services.net/ns/core#hintWidth</seealso>
    let hintWidth = Prefixed_Name(oslc, "hintWidth") |> PrefixedName
    /// <summary>
    ///   <para>oslc:inReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Reference to comment this comment is in reply to.</para>
    /// labels<para>inReplyTo</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#inReplyTo">http://open-services.net/ns/core#inReplyTo</seealso>
    let inReplyTo = Prefixed_Name(oslc, "inReplyTo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Very short label for use in menu items.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#label">http://open-services.net/ns/core#label</seealso>
    let label = Prefixed_Name(oslc, "label") |> PrefixedName
    /// <summary>
    ///   <para>oslc:largePreview</para>
    /// </summary>
    /// <remarks>
    ///   <para>URI and sizing properties for an HTML document to be used for a large preview.</para>
    /// labels<para>largePreview</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#largePreview">http://open-services.net/ns/core#largePreview</seealso>
    let largePreview = Prefixed_Name(oslc, "largePreview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:maxSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For String properties only, specifies maximum characters allowed. If not set, then there is no maximum or maximum is specified elsewhere.</para>
    /// labels<para>maxSize</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#maxSize">http://open-services.net/ns/core#maxSize</seealso>
    let maxSize = Prefixed_Name(oslc, "maxSize") |> PrefixedName
    /// <summary>
    ///   <para>oslc:modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of a resource describing the entity that most recently modified this resource.  The link target is usually a foaf:Person or foaf:Agent, but could be any type.  This is modeled after dcterms:creator, but Dublin Core currently has no equivalent property.</para>
    /// labels<para>modifiedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#modifiedBy">http://open-services.net/ns/core#modifiedBy</seealso>
    let modifiedBy = Prefixed_Name(oslc, "modifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>oslc:moreInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource giving more information on the error SHOULD be of an HTML content-type.</para>
    /// labels<para>moreInfo</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#moreInfo">http://open-services.net/ns/core#moreInfo</seealso>
    let moreInfo = Prefixed_Name(oslc, "moreInfo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:oauthConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the three OAuth URIs required for a client to act as an OAuth consumer.</para>
    /// labels<para>oauthConfiguration</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthConfiguration">http://open-services.net/ns/core#oauthConfiguration</seealso>
    let oauthConfiguration = Prefixed_Name(oslc, "oauthConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>oslc:occurs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>MUST be either http://open-services.net/ns/core#Exactly-one, http://open-services.net/ns/core#Zero-or-one, http://open-services.net/ns/core#Zero-or-many or http://open-services.net/ns/core#One-or-many.</para>
    /// labels<para>occurs</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#occurs">http://open-services.net/ns/core#occurs</seealso>
    let occurs = Prefixed_Name(oslc, "occurs") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Namespace prefix to be used for this namespace.</para>
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefix">http://open-services.net/ns/core#prefix</seealso>
    let prefix = Prefixed_Name(oslc, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>oslc:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The properties that are allowed or required by this shape.</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#property">http://open-services.net/ns/core#property</seealso>
    let property = Prefixed_Name(oslc, "property") |> PrefixedName
    /// <summary>
    ///   <para>oslc:queryBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The base URI to use for queries. Queries may be invoked either by HTTP GET or HTTP POST. For HTTP GET, a query URI is formed by appending a key=value pair to the base URI. For HTTP POST, the query parameters are encoded as content with media type application/x-www-form-urlencoded and sent in the request body. The base URI MAY accept other query languages and media types in the request body, e.g. application/sparql-query for SPARQL queries.</para>
    /// labels<para>queryBase</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#queryBase">http://open-services.net/ns/core#queryBase</seealso>
    let queryBase = Prefixed_Name(oslc, "queryBase") |> PrefixedName
    /// <summary>
    ///   <para>oslc:readOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>true if the property is read-only. If omitted, or set to false, then the property is writable. Providers SHOULD declare a property read-only when changes to the value of that property will not be accepted after the resource has been created, e.g. on PUT/PATCH requests. Consumers should note that the converse does not apply: Providers MAY reject a change to the value of a writable property.</para>
    /// labels<para>readOnly</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#readOnly">http://open-services.net/ns/core#readOnly</seealso>
    let readOnly = Prefixed_Name(oslc, "readOnly") |> PrefixedName
    /// <summary>
    ///   <para>oslc:rel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If present and set to 'alternate' then indicates that work-around is provided, behavior for other values is undefined.</para>
    /// labels<para>rel</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#rel">http://open-services.net/ns/core#rel</seealso>
    let rel = Prefixed_Name(oslc, "rel") |> PrefixedName
    /// <summary>
    ///   <para>oslc:resourceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Creation Factory MAY provide Resource Shapes that describe shapes of resources that may be created.</para>
    /// labels<para>resourceShape</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#resourceShape">http://open-services.net/ns/core#resourceShape</seealso>
    let resourceShape = Prefixed_Name(oslc, "resourceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The expected resource type URI of the resource that will be created using this creation factory. These would be the URIs found in the result resource's rdf:type property.</para>
    /// labels<para>resourceType</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#resourceType">http://open-services.net/ns/core#resourceType</seealso>
    let resourceType = Prefixed_Name(oslc, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>oslc:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Describes a service offered by the service provider.</para>
    /// labels<para>service</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#service">http://open-services.net/ns/core#service</seealso>
    let service = Prefixed_Name(oslc, "service") |> PrefixedName
    /// <summary>
    ///   <para>oslc:shortId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorter form of dcterms:identifier for the resource.</para>
    /// labels<para>shortId</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#shortId">http://open-services.net/ns/core#shortId</seealso>
    let shortId = Prefixed_Name(oslc, "shortId") |> PrefixedName
    /// <summary>
    ///   <para>oslc:statusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The HTTP status code reported with the error.</para>
    /// labels<para>statusCode</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#statusCode">http://open-services.net/ns/core#statusCode</seealso>
    let statusCode = Prefixed_Name(oslc, "statusCode") |> PrefixedName
    /// <summary>
    ///   <para>oslc:totalCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This optional property indicates the total number of results across all pages,
    /// 		its value should be non-negative. In the context of a query resource, this value SHOULD
    /// 		be the total number of results, i.e. the number of resources that match the query.
    /// 		In the context of other resources, the value SHOULD be the total number of property
    /// 		values (i.e. RDF triples) of the resource. Unless Stable Paging is in effect, the
    /// 		total count MAY vary as a client retrieves subsequent pages.</para>
    /// labels<para>totalCount</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#totalCount">http://open-services.net/ns/core#totalCount</seealso>
    let totalCount = Prefixed_Name(oslc, "totalCount") |> PrefixedName
    /// <summary>
    ///   <para>oslc:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An identifier URI for the domain specified usage of this creation factory. If a service provides multiple creation factories, it may designate the primary or default one that should be used with a property value of http://open-services.net/ns/core#default.</para>
    /// labels<para>usage</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#usage">http://open-services.net/ns/core#usage</seealso>
    let usage = Prefixed_Name(oslc, "usage") |> PrefixedName
    /// <summary>
    ///   <para>oslc:valueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URI that indicates the value type, for example XML Schema or RDF URIs for literal value types, and OSLC-specified for others.  If this property is omitted, then the value type is unconstrained.</para>
    /// labels<para>valueType</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#valueType">http://open-services.net/ns/core#valueType</seealso>
    let valueType = Prefixed_Name(oslc, "valueType") |> PrefixedName
    /// <summary>
    ///   <para>oslc:LocalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>Local Resource: value is an resource available only inside the resource being defined (i.e. a Blank Node).</para>
    /// labels<para>LocalResource</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#LocalResource">http://open-services.net/ns/core#LocalResource</seealso>
    let LocalResource = Prefixed_Name(oslc, "LocalResource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:One-or-many</para>
    /// </summary>
    /// <remarks>
    ///   <para>Property is required and multi-valued.</para>
    /// labels<para>One-or-many</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#One-or-many">http://open-services.net/ns/core#One-or-many</seealso>
    let One_or_many = Prefixed_Name(oslc, "One-or-many") |> PrefixedName
    /// <summary>
    ///   <para>oslc:results</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to hold the results of dialog action or JSON query results (default).
    /// 		The JSON query result attribute 'oslc:results' is used whenever a provider doesn't have
    /// 		a suitable property already in its model for such purposes.</para>
    /// labels<para>results</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#results">http://open-services.net/ns/core#results</seealso>
    let results = Prefixed_Name(oslc, "results") |> PrefixedName
    /// <summary>
    ///   <para>oslc:serviceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the resource's OSLC Service Provider.</para>
    /// labels<para>serviceProvider</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#serviceProvider">http://open-services.net/ns/core#serviceProvider</seealso>
    let serviceProvider = Prefixed_Name(oslc, "serviceProvider") |> PrefixedName
    /// <summary>
    ///   <para>oslc:smallPreview</para>
    /// </summary>
    /// <remarks>
    ///   <para>URI and sizing properties for an HTML document to be used for a small preview.</para>
    /// labels<para>smallPreview</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#smallPreview">http://open-services.net/ns/core#smallPreview</seealso>
    let smallPreview = Prefixed_Name(oslc, "smallPreview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:valueShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>if the value-type is a resource type, then Property MAY provide a shape value to indicate the Resource Shape that applies to the resource.</para>
    /// labels<para>valueShape</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#valueShape">http://open-services.net/ns/core#valueShape</seealso>
    let valueShape = Prefixed_Name(oslc, "valueShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ExtendedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Extended error information.</para>
    /// labels<para>ExtendedError</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ExtendedError">http://open-services.net/ns/core#ExtendedError</seealso>
    let ExtendedError = Prefixed_Name(oslc, "ExtendedError") |> PrefixedName
    /// <summary>
    ///   <para>oslc:OAuthConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The OAuthConfiguration definition included in ServiceProvider.</para>
    /// labels<para>OAuthConfiguration</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#OAuthConfiguration">http://open-services.net/ns/core#OAuthConfiguration</seealso>
    let OAuthConfiguration = Prefixed_Name(oslc, "OAuthConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>oslc:PrefixDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The PrefixDefinition definition included in ServiceProvider.</para>
    /// labels<para>PrefixDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#PrefixDefinition">http://open-services.net/ns/core#PrefixDefinition</seealso>
    let PrefixDefinition = Prefixed_Name(oslc, "PrefixDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Property resource describes one allowed or required property of a resource.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Property">http://open-services.net/ns/core#Property</seealso>
    let Property = Prefixed_Name(oslc, "Property") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Publisher definition included in ServiceProvider.</para>
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Publisher">http://open-services.net/ns/core#Publisher</seealso>
    let Publisher = Prefixed_Name(oslc, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>oslc:QueryCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The QueryCapability definition included in a ServiceProvider.</para>
    /// labels<para>QueryCapability</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#QueryCapability">http://open-services.net/ns/core#QueryCapability</seealso>
    let QueryCapability = Prefixed_Name(oslc, "QueryCapability") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>Resource: value is a resource at a specified URI (i.e. a URI Reference).</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Resource">http://open-services.net/ns/core#Resource</seealso>
    let Resource = Prefixed_Name(oslc, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:instanceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of a Resource Shape that describes the possible properties.</para>
    /// labels<para>instanceShape</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#instanceShape">http://open-services.net/ns/core#instanceShape</seealso>
    let instanceShape = Prefixed_Name(oslc, "instanceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This shape describes resources that are of the RDF type given by the object of the oslc:describes predicate. Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T.</para>
    /// labels<para>describes</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#describes">http://open-services.net/ns/core#describes</seealso>
    let describes = Prefixed_Name(oslc, "describes") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Service definition included in a ServiceProvider.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Service">http://open-services.net/ns/core#Service</seealso>
    let Service = Prefixed_Name(oslc, "Service") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ResourceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Resource Shape used for creation, query and modify.  Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T, or if there is a triple R oslc:instanceShape S.</para>
    /// labels<para>ResourceShape</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ResourceShape">http://open-services.net/ns/core#ResourceShape</seealso>
    let ResourceShape = Prefixed_Name(oslc, "ResourceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>A URI Reference representation to a resource.</para>
    /// labels<para>Reference</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Reference">http://open-services.net/ns/core#Reference</seealso>
    let Reference = Prefixed_Name(oslc, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Service Provider resource</para>
    /// labels<para>ServiceProvider</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ServiceProvider">http://open-services.net/ns/core#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(oslc, "ServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>oslc:ServiceProviderCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Service Provider Catalog resource</para>
    /// labels<para>ServiceProviderCatalog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ServiceProviderCatalog">http://open-services.net/ns/core#ServiceProviderCatalog</seealso>
    let ServiceProviderCatalog =
        Prefixed_Name(oslc, "ServiceProviderCatalog") |> PrefixedName

    /// <summary>
    ///   <para>oslc:allowedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Resource with allowed values for the property being defined. Range of oslc:AllowedValues</para>
    /// labels<para>allowedValues</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#allowedValues">http://open-services.net/ns/core#allowedValues</seealso>
    let allowedValues = Prefixed_Name(oslc, "allowedValues") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ResponseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The ResponseInfo included in query results.</para>
    /// labels<para>ResponseInfo</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ResponseInfo">http://open-services.net/ns/core#ResponseInfo</seealso>
    let ResponseInfo = Prefixed_Name(oslc, "ResponseInfo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Zero-or-many</para>
    /// </summary>
    /// <remarks>
    ///   <para>Property is optional and multi-valued.</para>
    /// labels<para>Zero-or-many</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Zero-or-many">http://open-services.net/ns/core#Zero-or-many</seealso>
    let Zero_or_many = Prefixed_Name(oslc, "Zero-or-many") |> PrefixedName
    /// <summary>
    ///   <para>oslc:allowedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>value allowed for a property.</para>
    /// labels<para>allowedValue</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#allowedValue">http://open-services.net/ns/core#allowedValue</seealso>
    let allowedValue = Prefixed_Name(oslc, "allowedValue") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Zero-or-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>Property is optional and single valued.</para>
    /// labels<para>Zero-or-one</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Zero-or-one">http://open-services.net/ns/core#Zero-or-one</seealso>
    let Zero_or_one = Prefixed_Name(oslc, "Zero-or-one") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To create a new resource via the factory, post it to this URI.</para>
    /// labels<para>creation</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creation">http://open-services.net/ns/core#creation</seealso>
    let creation = Prefixed_Name(oslc, "creation") |> PrefixedName
    /// <summary>
    ///   <para>oslc:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A default value for property, inlined into property definition.</para>
    /// labels<para>defaultValue</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#defaultValue">http://open-services.net/ns/core#defaultValue</seealso>
    let defaultValue = Prefixed_Name(oslc, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>oslc:details</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URL that may be used to retrieve a web page to determine additional details about the service provider.</para>
    /// labels<para>details</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#details">http://open-services.net/ns/core#details</seealso>
    let details = Prefixed_Name(oslc, "details") |> PrefixedName
    /// <summary>
    ///   <para>oslc:dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of the dialog.</para>
    /// labels<para>dialog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#dialog">http://open-services.net/ns/core#dialog</seealso>
    let dialog = Prefixed_Name(oslc, "dialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Comment about the resource.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#comment">http://open-services.net/ns/core#comment</seealso>
    let comment = Prefixed_Name(oslc, "comment") |> PrefixedName
    /// <summary>
    ///   <para>oslc:authorizationURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URI for obtaining OAuth authorization.</para>
    /// labels<para>authorizationURI</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#authorizationURI">http://open-services.net/ns/core#authorizationURI</seealso>
    let authorizationURI = Prefixed_Name(oslc, "authorizationURI") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creationDialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Enables clients to create a resource via UI.</para>
    /// labels<para>creationDialog</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creationDialog">http://open-services.net/ns/core#creationDialog</seealso>
    let creationDialog = Prefixed_Name(oslc, "creationDialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creationFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Enables clients to create new resources.</para>
    /// labels<para>creationFactory</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creationFactory">http://open-services.net/ns/core#creationFactory</seealso>
    let creationFactory = Prefixed_Name(oslc, "creationFactory") |> PrefixedName
    /// <summary>
    ///   <para>oslc:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>Used in conjunction with oslc:usage property used to identify
    /// 		which service is the default usage.</para>
    /// labels<para>default</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#default">http://open-services.net/ns/core#default</seealso>
    let default_ = Prefixed_Name(oslc, "default") |> PrefixedName
    /// <summary>
    ///   <para>oslc:discussedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A series of notes and comments about this resource.</para>
    /// labels<para>discussedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#discussedBy">http://open-services.net/ns/core#discussedBy</seealso>
    let discussedBy = Prefixed_Name(oslc, "discussedBy") |> PrefixedName
    /// <summary>
    ///   <para>oslc:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>The URI of an HTML document to be used for the preview.</para>
    /// labels<para>document</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#document">http://open-services.net/ns/core#document</seealso>
    let document = Prefixed_Name(oslc, "document") |> PrefixedName
    /// <summary>
    ///   <para>oslc:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Namespace URI of the specification that is implemented by this service. In most cases this namespace URI will be for an OSLC domain, but other URIs MAY be used.</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#domain">http://open-services.net/ns/core#domain</seealso>
    let domain = Prefixed_Name(oslc, "domain") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hintHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).</para>
    /// labels<para>hintHeight</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hintHeight">http://open-services.net/ns/core#hintHeight</seealso>
    let hintHeight = Prefixed_Name(oslc, "hintHeight") |> PrefixedName
    /// <summary>
    ///   <para>oslc:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size.</para>
    /// labels<para>icon</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#icon">http://open-services.net/ns/core#icon</seealso>
    let icon = Prefixed_Name(oslc, "icon") |> PrefixedName
    /// <summary>
    ///   <para>oslc:initialHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>Recommended initial height of the preview. The presence of this property indicates that the preview supports dynamically computing its size. Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1). Em and ex units are interpreted relative to the default system font (at 100% size).</para>
    /// labels<para>initialHeight</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#initialHeight">http://open-services.net/ns/core#initialHeight</seealso>
    let initialHeight = Prefixed_Name(oslc, "initialHeight") |> PrefixedName
    /// <summary>
    ///   <para>oslc:isMemberProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to define when a property is a member of a container, useful for query.</para>
    /// labels<para>isMemberProperty</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#isMemberProperty">http://open-services.net/ns/core#isMemberProperty</seealso>
    let isMemberProperty = Prefixed_Name(oslc, "isMemberProperty") |> PrefixedName
    /// <summary>
    ///   <para>oslc:message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An informative message describing the error that occurred.</para>
    /// labels<para>message</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#message">http://open-services.net/ns/core#message</seealso>
    let message = Prefixed_Name(oslc, "message") |> PrefixedName
    /// <summary>
    ///   <para>oslc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of property being defined, i.e. second part of property's Prefixed Name.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#name">http://open-services.net/ns/core#name</seealso>
    let name = Prefixed_Name(oslc, "name") |> PrefixedName
    /// <summary>
    ///   <para>oslc:nextPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to next page of response.</para>
    /// labels<para>nextPage</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#nextPage">http://open-services.net/ns/core#nextPage</seealso>
    let nextPage = Prefixed_Name(oslc, "nextPage") |> PrefixedName

    /// <summary>
    ///   <para>oslc:oauthRequestTokenURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URI for obtaining OAuth request token.</para>
    /// labels<para>oauthRequestTokenURI</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthRequestTokenURI">http://open-services.net/ns/core#oauthRequestTokenURI</seealso>
    let oauthRequestTokenURI =
        Prefixed_Name(oslc, "oauthRequestTokenURI") |> PrefixedName

    /// <summary>
    ///   <para>oslc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Core</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#">http://open-services.net/ns/core#</seealso>
    let _prefix_iri = Prefixed_Name(oslc, "") |> PrefixedName
