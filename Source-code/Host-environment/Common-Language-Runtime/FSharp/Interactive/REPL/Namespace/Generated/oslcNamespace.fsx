#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://open-services.net/ns/core#" "oslc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Allowed values for one property.^^xsd:string</para>
    ///   <para>rdfs:label : AllowedValues^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#AllowedValues">oslc:AllowedValues</a>
    /// </summary>
    let AllowedValues = _prefixId.prefix "AllowedValues"
    let Any = _prefixId.prefix "Any"
    let AnyResource = _prefixId.prefix "AnyResource"
    /// <summary>
    ///   <para>rdfs:comment : A Comment resource represents a single note, or comment, in a discussion thread.^^xsd:string</para>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Comment">oslc:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:comment : The Compact representation, fetched as application/x-oslc-compact+xml^^xsd:string</para>
    ///   <para>rdfs:label : Compact^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Compact">oslc:Compact</a>
    /// </summary>
    let Compact = _prefixId.prefix "Compact"
    /// <summary>
    ///   <para>rdfs:comment : The CreationFactory definition included in a ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : CreationFactory^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#CreationFactory">oslc:CreationFactory</a>
    /// </summary>
    let CreationFactory = _prefixId.prefix "CreationFactory"
    /// <summary>
    ///   <para>rdfs:comment : The Dialog definition included in ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : Dialog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Dialog">oslc:Dialog</a>
    /// </summary>
    let Dialog = _prefixId.prefix "Dialog"
    /// <summary>
    ///   <para>rdfs:comment : A Discussion resource is intended to represent a sequence of comments or notes regarding the associated resource^^xsd:string</para>
    ///   <para>rdfs:label : Discussion^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Discussion">oslc:Discussion</a>
    /// </summary>
    let Discussion = _prefixId.prefix "Discussion"
    let Either = _prefixId.prefix "Either"
    /// <summary>
    ///   <para>rdfs:comment : Basis for forming an error response.^^xsd:string</para>
    ///   <para>rdfs:label : Error^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Error">oslc:Error</a>
    /// </summary>
    let Error = _prefixId.prefix "Error"
    let Exactly_one = _prefixId.prefix "Exactly-one"
    /// <summary>
    ///   <para>rdfs:comment : Extended error information.^^xsd:string</para>
    ///   <para>rdfs:label : ExtendedError^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#ExtendedError">oslc:ExtendedError</a>
    /// </summary>
    let ExtendedError = _prefixId.prefix "ExtendedError"
    let Inline = _prefixId.prefix "Inline"
    let LocalResource = _prefixId.prefix "LocalResource"
    /// <summary>
    ///   <para>rdfs:comment : The OAuthConfiguration definition included in ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : OAuthConfiguration^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#OAuthConfiguration">oslc:OAuthConfiguration</a>
    /// </summary>
    let OAuthConfiguration = _prefixId.prefix "OAuthConfiguration"
    let One_or_many = _prefixId.prefix "One-or-many"
    /// <summary>
    ///   <para>rdfs:comment : The PrefixDefinition definition included in ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : PrefixDefinition^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#PrefixDefinition">oslc:PrefixDefinition</a>
    /// </summary>
    let PrefixDefinition = _prefixId.prefix "PrefixDefinition"
    /// <summary>
    ///   <para>rdfs:comment : The UI Preview representation.^^xsd:string</para>
    ///   <para>rdfs:label : Preview^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Preview">oslc:Preview</a>
    /// </summary>
    let Preview = _prefixId.prefix "Preview"
    /// <summary>
    ///   <para>rdfs:comment : A Property resource describes one allowed or required property of a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Property">oslc:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:comment : The Publisher definition included in ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Publisher">oslc:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>rdfs:comment : The QueryCapability definition included in a ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : QueryCapability^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#QueryCapability">oslc:QueryCapability</a>
    /// </summary>
    let QueryCapability = _prefixId.prefix "QueryCapability"
    let Reference = _prefixId.prefix "Reference"
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:comment : The Resource Shape used for creation, query and modify.  Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T, or if there is a triple R oslc:instanceShape S.^^xsd:string</para>
    ///   <para>rdfs:label : ResourceShape^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#ResourceShape">oslc:ResourceShape</a>
    /// </summary>
    let ResourceShape = _prefixId.prefix "ResourceShape"
    /// <summary>
    ///   <para>rdfs:comment : The ResponseInfo included in query results.^^xsd:string</para>
    ///   <para>rdfs:label : ResponseInfo^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#ResponseInfo">oslc:ResponseInfo</a>
    /// </summary>
    let ResponseInfo = _prefixId.prefix "ResponseInfo"
    /// <summary>
    ///   <para>rdfs:comment : The Service definition included in a ServiceProvider.^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#Service">oslc:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : The Service Provider resource^^xsd:string</para>
    ///   <para>rdfs:label : ServiceProvider^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#ServiceProvider">oslc:ServiceProvider</a>
    /// </summary>
    let ServiceProvider = _prefixId.prefix "ServiceProvider"
    /// <summary>
    ///   <para>rdfs:comment : The Service Provider Catalog resource^^xsd:string</para>
    ///   <para>rdfs:label : ServiceProviderCatalog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#ServiceProviderCatalog">oslc:ServiceProviderCatalog</a>
    /// </summary>
    let ServiceProviderCatalog = _prefixId.prefix "ServiceProviderCatalog"
    let Zero_or_many = _prefixId.prefix "Zero-or-many"
    let Zero_or_one = _prefixId.prefix "Zero-or-one"
    /// <summary>
    ///   <para>rdfs:comment : value allowed for a property.^^xsd:string</para>
    ///   <para>rdfs:label : allowedValue^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#allowedValue">oslc:allowedValue</a>
    /// </summary>
    let allowedValue = _prefixId.prefix "allowedValue"
    /// <summary>
    ///   <para>rdfs:comment : Resource with allowed values for the property being defined. Range of oslc:AllowedValues^^xsd:string</para>
    ///   <para>rdfs:label : allowedValues^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#allowedValues">oslc:allowedValues</a>
    /// </summary>
    let allowedValues = _prefixId.prefix "allowedValues"
    /// <summary>
    ///   <para>rdfs:comment : URI for obtaining OAuth authorization.^^xsd:string</para>
    ///   <para>rdfs:label : authorizationURI^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#authorizationURI">oslc:authorizationURI</a>
    /// </summary>
    let authorizationURI = _prefixId.prefix "authorizationURI"
    /// <summary>
    ///   <para>rdfs:comment : Comment about the resource.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#comment">oslc:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : To create a new resource via the factory, post it to this URI.^^xsd:string</para>
    ///   <para>rdfs:label : creation^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#creation">oslc:creation</a>
    /// </summary>
    let creation = _prefixId.prefix "creation"
    /// <summary>
    ///   <para>rdfs:comment : Enables clients to create a resource via UI.^^xsd:string</para>
    ///   <para>rdfs:label : creationDialog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#creationDialog">oslc:creationDialog</a>
    /// </summary>
    let creationDialog = _prefixId.prefix "creationDialog"
    /// <summary>
    ///   <para>rdfs:comment : Enables clients to create new resources.^^xsd:string</para>
    ///   <para>rdfs:label : creationFactory^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#creationFactory">oslc:creationFactory</a>
    /// </summary>
    let creationFactory = _prefixId.prefix "creationFactory"
    let default_ = _prefixId.prefix "default"
    /// <summary>
    ///   <para>rdfs:comment : A default value for property, inlined into property definition.^^xsd:string</para>
    ///   <para>rdfs:label : defaultValue^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#defaultValue">oslc:defaultValue</a>
    /// </summary>
    let defaultValue = _prefixId.prefix "defaultValue"
    /// <summary>
    ///   <para>rdfs:comment : This shape describes resources that are of the RDF type given by the object of the oslc:describes predicate. Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T.^^xsd:string</para>
    ///   <para>rdfs:label : describes^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#describes">oslc:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : A URL that may be used to retrieve a web page to determine additional details about the service provider.^^xsd:string</para>
    ///   <para>rdfs:label : details^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#details">oslc:details</a>
    /// </summary>
    let details = _prefixId.prefix "details"
    /// <summary>
    ///   <para>rdfs:comment : The URI of the dialog.^^xsd:string</para>
    ///   <para>rdfs:label : dialog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#dialog">oslc:dialog</a>
    /// </summary>
    let dialog = _prefixId.prefix "dialog"
    /// <summary>
    ///   <para>rdfs:comment : A series of notes and comments about this resource.^^xsd:string</para>
    ///   <para>rdfs:label : discussedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#discussedBy">oslc:discussedBy</a>
    /// </summary>
    let discussedBy = _prefixId.prefix "discussedBy"
    /// <summary>
    ///   <para>rdfs:comment : Reference to associated resource.^^xsd:string</para>
    ///   <para>rdfs:label : discussionAbout^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#discussionAbout">oslc:discussionAbout</a>
    /// </summary>
    let discussionAbout = _prefixId.prefix "discussionAbout"
    let document = _prefixId.prefix "document"
    /// <summary>
    ///   <para>rdfs:comment : Namespace URI of the specification that is implemented by this service. In most cases this namespace URI will be for an OSLC domain, but other URIs MAY be used.^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#domain">oslc:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : Extended (additional) error information.^^xsd:string</para>
    ///   <para>rdfs:label : extendedError^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#extendedError">oslc:extendedError</a>
    /// </summary>
    let extendedError = _prefixId.prefix "extendedError"
    /// <summary>
    ///   <para>rdfs:comment : A hint that indicates that property MAY be hidden when presented in a user interface.^^xsd:string</para>
    ///   <para>rdfs:label : hidden^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#hidden">oslc:hidden</a>
    /// </summary>
    let hidden = _prefixId.prefix "hidden"
    /// <summary>
    ///   <para>rdfs:comment : Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).^^xsd:string</para>
    ///   <para>rdfs:label : hintHeight^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#hintHeight">oslc:hintHeight</a>
    /// </summary>
    let hintHeight = _prefixId.prefix "hintHeight"
    /// <summary>
    ///   <para>rdfs:comment : Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).^^xsd:string</para>
    ///   <para>rdfs:label : hintWidth^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#hintWidth">oslc:hintWidth</a>
    /// </summary>
    let hintWidth = _prefixId.prefix "hintWidth"
    /// <summary>
    ///   <para>rdfs:comment : URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size.^^xsd:string</para>
    ///   <para>rdfs:label : icon^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#icon">oslc:icon</a>
    /// </summary>
    let icon = _prefixId.prefix "icon"
    /// <summary>
    ///   <para>rdfs:comment : Reference to comment this comment is in reply to.^^xsd:string</para>
    ///   <para>rdfs:label : inReplyTo^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#inReplyTo">oslc:inReplyTo</a>
    /// </summary>
    let inReplyTo = _prefixId.prefix "inReplyTo"
    let initialHeight = _prefixId.prefix "initialHeight"
    /// <summary>
    ///   <para>rdfs:comment : The URI of a Resource Shape that describes the possible properties.^^xsd:string</para>
    ///   <para>rdfs:label : instanceShape^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#instanceShape">oslc:instanceShape</a>
    /// </summary>
    let instanceShape = _prefixId.prefix "instanceShape"
    /// <summary>
    ///   <para>rdfs:comment : Used to define when a property is a member of a container, useful for query.^^xsd:string</para>
    ///   <para>rdfs:label : isMemberProperty^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#isMemberProperty">oslc:isMemberProperty</a>
    /// </summary>
    let isMemberProperty = _prefixId.prefix "isMemberProperty"
    /// <summary>
    ///   <para>rdfs:comment : Very short label for use in menu items.^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#label">oslc:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    let largePreview = _prefixId.prefix "largePreview"
    /// <summary>
    ///   <para>rdfs:comment : For String properties only, specifies maximum characters allowed. If not set, then there is no maximum or maximum is specified elsewhere.^^xsd:string</para>
    ///   <para>rdfs:label : maxSize^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#maxSize">oslc:maxSize</a>
    /// </summary>
    let maxSize = _prefixId.prefix "maxSize"
    /// <summary>
    ///   <para>rdfs:comment : An informative message describing the error that occurred.^^xsd:string</para>
    ///   <para>rdfs:label : message^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#message">oslc:message</a>
    /// </summary>
    let message = _prefixId.prefix "message"
    /// <summary>
    ///   <para>rdfs:comment : The URI of a resource describing the entity that most recently modified this resource.  The link target is usually a foaf:Person or foaf:Agent, but could be any type.  This is modeled after dcterms:creator, but Dublin Core currently has no equivalent property.^^xsd:string</para>
    ///   <para>rdfs:label : modifiedBy^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#modifiedBy">oslc:modifiedBy</a>
    /// </summary>
    let modifiedBy = _prefixId.prefix "modifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : A resource giving more information on the error SHOULD be of an HTML content-type.^^xsd:string</para>
    ///   <para>rdfs:label : moreInfo^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#moreInfo">oslc:moreInfo</a>
    /// </summary>
    let moreInfo = _prefixId.prefix "moreInfo"
    /// <summary>
    ///   <para>rdfs:comment : Name of property being defined, i.e. second part of property's Prefixed Name.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#name">oslc:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Link to next page of response.^^xsd:string</para>
    ///   <para>rdfs:label : nextPage^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#nextPage">oslc:nextPage</a>
    /// </summary>
    let nextPage = _prefixId.prefix "nextPage"
    /// <summary>
    ///   <para>rdfs:comment : URI for obtaining OAuth access token.^^xsd:string</para>
    ///   <para>rdfs:label : oauthAccessTokenURI^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#oauthAccessTokenURI">oslc:oauthAccessTokenURI</a>
    /// </summary>
    let oauthAccessTokenURI = _prefixId.prefix "oauthAccessTokenURI"
    /// <summary>
    ///   <para>rdfs:comment : Defines the three OAuth URIs required for a client to act as an OAuth consumer.^^xsd:string</para>
    ///   <para>rdfs:label : oauthConfiguration^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#oauthConfiguration">oslc:oauthConfiguration</a>
    /// </summary>
    let oauthConfiguration = _prefixId.prefix "oauthConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : URI for obtaining OAuth request token.^^xsd:string</para>
    ///   <para>rdfs:label : oauthRequestTokenURI^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#oauthRequestTokenURI">oslc:oauthRequestTokenURI</a>
    /// </summary>
    let oauthRequestTokenURI = _prefixId.prefix "oauthRequestTokenURI"
    /// <summary>
    ///   <para>rdfs:comment : MUST be either http://open-services.net/ns/core#Exactly-one, http://open-services.net/ns/core#Zero-or-one, http://open-services.net/ns/core#Zero-or-many or http://open-services.net/ns/core#One-or-many.^^xsd:string</para>
    ///   <para>rdfs:label : occurs^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#occurs">oslc:occurs</a>
    /// </summary>
    let occurs = _prefixId.prefix "occurs"
    /// <summary>
    ///   <para>rdfs:comment : Reference to owning Discussion resource .^^xsd:string</para>
    ///   <para>rdfs:label : partOfDiscussion^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#partOfDiscussion">oslc:partOfDiscussion</a>
    /// </summary>
    let partOfDiscussion = _prefixId.prefix "partOfDiscussion"
    /// <summary>
    ///   <para>rdfs:comment : Namespace prefix to be used for this namespace.^^xsd:string</para>
    ///   <para>rdfs:label : prefix^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#prefix">oslc:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:comment : The base URI of the namespace.^^xsd:string</para>
    ///   <para>rdfs:label : prefixBase^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#prefixBase">oslc:prefixBase</a>
    /// </summary>
    let prefixBase = _prefixId.prefix "prefixBase"
    /// <summary>
    ///   <para>rdfs:comment : Defines a namespace prefix for use in JSON representations and in forming OSLC Query Syntax strings.^^xsd:string</para>
    ///   <para>rdfs:label : prefixDefinition^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#prefixDefinition">oslc:prefixDefinition</a>
    /// </summary>
    let prefixDefinition = _prefixId.prefix "prefixDefinition"
    /// <summary>
    ///   <para>rdfs:comment : The properties that are allowed or required by this shape.^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#property">oslc:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : URI of the property whose usage is being described.^^xsd:string</para>
    ///   <para>rdfs:label : propertyDefinition^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#propertyDefinition">oslc:propertyDefinition</a>
    /// </summary>
    let propertyDefinition = _prefixId.prefix "propertyDefinition"
    /// <summary>
    ///   <para>rdfs:comment : The base URI to use for queries. Queries may be invoked either by HTTP GET or HTTP POST. For HTTP GET, a query URI is formed by appending a key=value pair to the base URI. For HTTP POST, the query parameters are encoded as content with media type application/x-www-form-urlencoded and sent in the request body. The base URI MAY accept other query languages and media types in the request body, e.g. application/sparql-query for SPARQL queries.^^xsd:string</para>
    ///   <para>rdfs:label : queryBase^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#queryBase">oslc:queryBase</a>
    /// </summary>
    let queryBase = _prefixId.prefix "queryBase"
    /// <summary>
    ///   <para>rdfs:comment : Enables clients query across a collection of resources.^^xsd:string</para>
    ///   <para>rdfs:label : queryCapability^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#queryCapability">oslc:queryCapability</a>
    /// </summary>
    let queryCapability = _prefixId.prefix "queryCapability"
    /// <summary>
    ///   <para>rdfs:comment : For properties with a resource value-type, Providers MAY also specify the range of possible resource types allowed, each specified by URI. The default range is http://open-services.net/ns/core#Any.^^xsd:string</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#range">oslc:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : true if the property is read-only. If omitted, or set to false, then the property is writable. Providers SHOULD declare a property read-only when changes to the value of that property will not be accepted after the resource has been created, e.g. on PUT/PATCH requests. Consumers should note that the converse does not apply: Providers MAY reject a change to the value of a writable property.^^xsd:string</para>
    ///   <para>rdfs:label : readOnly^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#readOnly">oslc:readOnly</a>
    /// </summary>
    let readOnly = _prefixId.prefix "readOnly"
    /// <summary>
    ///   <para>rdfs:comment : If present and set to 'alternate' then indicates that work-around is provided, behavior for other values is undefined.^^xsd:string</para>
    ///   <para>rdfs:label : rel^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#rel">oslc:rel</a>
    /// </summary>
    let rel = _prefixId.prefix "rel"
    /// <summary>
    ///   <para>rdfs:comment : Should be http://open-services.net/ns/core#Reference, http://open-services.net/ns/core#Inline or http://open-services.net/ns/core#Either^^xsd:string</para>
    ///   <para>rdfs:label : representation^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#representation">oslc:representation</a>
    /// </summary>
    let representation = _prefixId.prefix "representation"
    /// <summary>
    ///   <para>rdfs:comment : A Creation Factory MAY provide Resource Shapes that describe shapes of resources that may be created.^^xsd:string</para>
    ///   <para>rdfs:label : resourceShape^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#resourceShape">oslc:resourceShape</a>
    /// </summary>
    let resourceShape = _prefixId.prefix "resourceShape"
    /// <summary>
    ///   <para>rdfs:comment : The expected resource type URI of the resource that will be created using this creation factory. These would be the URIs found in the result resource's rdf:type property.^^xsd:string</para>
    ///   <para>rdfs:label : resourceType^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#resourceType">oslc:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
    /// <summary>
    ///   <para>rdfs:comment : Used to hold the results of dialog action or JSON query results (default).
    /// 		The JSON query result attribute 'oslc:results' is used whenever a provider doesn't have
    /// 		a suitable property already in its model for such purposes.^^xsd:string</para>
    ///   <para>rdfs:label : results^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#results">oslc:results</a>
    /// </summary>
    let results = _prefixId.prefix "results"
    /// <summary>
    ///   <para>rdfs:comment : Enables clients to select a resource via UI.^^xsd:string</para>
    ///   <para>rdfs:label : selectionDialog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#selectionDialog">oslc:selectionDialog</a>
    /// </summary>
    let selectionDialog = _prefixId.prefix "selectionDialog"
    /// <summary>
    ///   <para>rdfs:comment : Describes a service offered by the service provider.^^xsd:string</para>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#service">oslc:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>rdfs:comment : A link to the resource's OSLC Service Provider.^^xsd:string</para>
    ///   <para>rdfs:label : serviceProvider^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#serviceProvider">oslc:serviceProvider</a>
    /// </summary>
    let serviceProvider = _prefixId.prefix "serviceProvider"
    /// <summary>
    ///   <para>rdfs:comment : Additional service provider catalog.^^xsd:string</para>
    ///   <para>rdfs:label : serviceProviderCatalog^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#serviceProviderCatalog">oslc:serviceProviderCatalog</a>
    /// </summary>
    let serviceProviderCatalog = _prefixId.prefix "serviceProviderCatalog"
    /// <summary>
    ///   <para>rdfs:comment : Shorter form of dcterms:identifier for the resource.^^xsd:string</para>
    ///   <para>rdfs:label : shortId^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#shortId">oslc:shortId</a>
    /// </summary>
    let shortId = _prefixId.prefix "shortId"
    /// <summary>
    ///   <para>rdfs:comment : Shorter form of dcterms:title for the resource.^^xsd:string</para>
    ///   <para>rdfs:label : shortTitle^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#shortTitle">oslc:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    let smallPreview = _prefixId.prefix "smallPreview"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP status code reported with the error.^^xsd:string</para>
    ///   <para>rdfs:label : statusCode^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#statusCode">oslc:statusCode</a>
    /// </summary>
    let statusCode = _prefixId.prefix "statusCode"
    /// <summary>
    ///   <para>rdfs:comment : This optional property indicates the total number of results across all pages,
    /// 		its value should be non-negative. In the context of a query resource, this value SHOULD
    /// 		be the total number of results, i.e. the number of resources that match the query.
    /// 		In the context of other resources, the value SHOULD be the total number of property
    /// 		values (i.e. RDF triples) of the resource. Unless Stable Paging is in effect, the
    /// 		total count MAY vary as a client retrieves subsequent pages.^^xsd:string</para>
    ///   <para>rdfs:label : totalCount^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#totalCount">oslc:totalCount</a>
    /// </summary>
    let totalCount = _prefixId.prefix "totalCount"
    /// <summary>
    ///   <para>rdfs:comment : An identifier URI for the domain specified usage of this creation factory. If a service provides multiple creation factories, it may designate the primary or default one that should be used with a property value of http://open-services.net/ns/core#default.^^xsd:string</para>
    ///   <para>rdfs:label : usage^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#usage">oslc:usage</a>
    /// </summary>
    let usage = _prefixId.prefix "usage"
    /// <summary>
    ///   <para>rdfs:comment : if the value-type is a resource type, then Property MAY provide a shape value to indicate the Resource Shape that applies to the resource.^^xsd:string</para>
    ///   <para>rdfs:label : valueShape^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#valueShape">oslc:valueShape</a>
    /// </summary>
    let valueShape = _prefixId.prefix "valueShape"
    /// <summary>
    ///   <para>rdfs:comment : A URI that indicates the value type, for example XML Schema or RDF URIs for literal value types, and OSLC-specified for others.  If this property is omitted, then the value type is unconstrained.^^xsd:string</para>
    ///   <para>rdfs:label : valueType^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core#valueType">oslc:valueType</a>
    /// </summary>
    let valueType = _prefixId.prefix "valueType"
