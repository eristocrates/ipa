namespace http.open_services.net.ns.core.hash

open DoxAletheia

module oslc =
    let _namespace_name = "http://open-services.net/ns/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Allowed values for one property.
    /// <see href="http://open-services.net/ns/core#AllowedValues"></see></summary>
    let AllowedValues = _prefix "AllowedValues"
    /// <summary>
    /// Any value type is allowed.
    /// <see href="http://open-services.net/ns/core#Any"></see></summary>
    let Any = _prefix "Any"
    /// <summary>
    /// AnyResource: value is either a Resource or Local Resource.
    /// <see href="http://open-services.net/ns/core#AnyResource"></see></summary>
    let AnyResource = _prefix "AnyResource"
    /// <summary>
    /// A Comment resource represents a single note, or comment, in a discussion thread.
    /// <see href="http://open-services.net/ns/core#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// The Compact representation, fetched as application/x-oslc-compact+xml
    /// <see href="http://open-services.net/ns/core#Compact"></see></summary>
    let Compact = _prefix "Compact"
    /// <summary>
    /// The CreationFactory definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#CreationFactory"></see></summary>
    let CreationFactory = _prefix "CreationFactory"
    /// <summary>
    /// The Dialog definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Dialog"></see></summary>
    let Dialog = _prefix "Dialog"
    /// <summary>
    /// A Discussion resource is intended to represent a sequence of comments or notes regarding the associated resource
    /// <see href="http://open-services.net/ns/core#Discussion"></see></summary>
    let Discussion = _prefix "Discussion"
    /// <summary>
    /// Representations is either a URI reference or blank node.
    /// <see href="http://open-services.net/ns/core#Either"></see></summary>
    let Either = _prefix "Either"
    /// <summary>
    /// Basis for forming an error response.
    /// <see href="http://open-services.net/ns/core#Error"></see></summary>
    let Error = _prefix "Error"
    /// <summary>
    /// Property with value is required.
    /// <see href="http://open-services.net/ns/core#Exactly-one"></see></summary>
    let ``Exactly-one`` = _prefix "Exactly-one"
    /// <summary>
    /// Extended error information.
    /// <see href="http://open-services.net/ns/core#ExtendedError"></see></summary>
    let ExtendedError = _prefix "ExtendedError"
    /// <summary>
    /// An inline (RDF blank node) representation.
    /// <see href="http://open-services.net/ns/core#Inline"></see></summary>
    let Inline = _prefix "Inline"
    /// <summary>
    /// Local Resource: value is an resource available only inside the resource being defined (i.e. a Blank Node).
    /// <see href="http://open-services.net/ns/core#LocalResource"></see></summary>
    let LocalResource = _prefix "LocalResource"
    /// <summary>
    /// The OAuthConfiguration definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#OAuthConfiguration"></see></summary>
    let OAuthConfiguration = _prefix "OAuthConfiguration"
    /// <summary>
    /// Property is required and multi-valued.
    /// <see href="http://open-services.net/ns/core#One-or-many"></see></summary>
    let ``One-or-many`` = _prefix "One-or-many"
    /// <summary>
    /// The PrefixDefinition definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#PrefixDefinition"></see></summary>
    let PrefixDefinition = _prefix "PrefixDefinition"
    /// <summary>
    /// The UI Preview representation.
    /// <see href="http://open-services.net/ns/core#Preview"></see></summary>
    let Preview = _prefix "Preview"
    /// <summary>
    /// A Property resource describes one allowed or required property of a resource.
    /// <see href="http://open-services.net/ns/core#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// The Publisher definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Publisher"></see></summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// The QueryCapability definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#QueryCapability"></see></summary>
    let QueryCapability = _prefix "QueryCapability"
    /// <summary>
    /// A URI Reference representation to a resource.
    /// <see href="http://open-services.net/ns/core#Reference"></see></summary>
    let Reference = _prefix "Reference"
    /// <summary>
    /// Resource: value is a resource at a specified URI (i.e. a URI Reference).
    /// <see href="http://open-services.net/ns/core#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// The Resource Shape used for creation, query and modify.  Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T, or if there is a triple R oslc:instanceShape S.
    /// <see href="http://open-services.net/ns/core#ResourceShape"></see></summary>
    let ResourceShape = _prefix "ResourceShape"
    /// <summary>
    /// The URI of a Resource Shape that describes the possible properties.
    /// <see href="http://open-services.net/ns/core#instanceShape"></see></summary>
    let instanceShape = _prefix "instanceShape"
    /// <summary>
    /// This shape describes resources that are of the RDF type given by the object of the oslc:describes predicate. Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T.
    /// <see href="http://open-services.net/ns/core#describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// The ResponseInfo included in query results.
    /// <see href="http://open-services.net/ns/core#ResponseInfo"></see></summary>
    let ResponseInfo = _prefix "ResponseInfo"
    /// <summary>
    /// The Service definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// The Service Provider resource
    /// <see href="http://open-services.net/ns/core#ServiceProvider"></see></summary>
    let ServiceProvider = _prefix "ServiceProvider"
    /// <summary>
    /// The Service Provider Catalog resource
    /// <see href="http://open-services.net/ns/core#ServiceProviderCatalog"></see></summary>
    let ServiceProviderCatalog = _prefix "ServiceProviderCatalog"
    /// <summary>
    /// Property is optional and multi-valued.
    /// <see href="http://open-services.net/ns/core#Zero-or-many"></see></summary>
    let ``Zero-or-many`` = _prefix "Zero-or-many"
    /// <summary>
    /// Property is optional and single valued.
    /// <see href="http://open-services.net/ns/core#Zero-or-one"></see></summary>
    let ``Zero-or-one`` = _prefix "Zero-or-one"
    /// <summary>
    /// value allowed for a property.
    /// <see href="http://open-services.net/ns/core#allowedValue"></see></summary>
    let allowedValue = _prefix "allowedValue"
    /// <summary>
    /// Resource with allowed values for the property being defined. Range of oslc:AllowedValues
    /// <see href="http://open-services.net/ns/core#allowedValues"></see></summary>
    let allowedValues = _prefix "allowedValues"
    /// <summary>
    /// URI for obtaining OAuth authorization.
    /// <see href="http://open-services.net/ns/core#authorizationURI"></see></summary>
    let authorizationURI = _prefix "authorizationURI"
    /// <summary>
    /// Comment about the resource.
    /// <see href="http://open-services.net/ns/core#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// To create a new resource via the factory, post it to this URI.
    /// <see href="http://open-services.net/ns/core#creation"></see></summary>
    let creation = _prefix "creation"
    /// <summary>
    /// Enables clients to create a resource via UI.
    /// <see href="http://open-services.net/ns/core#creationDialog"></see></summary>
    let creationDialog = _prefix "creationDialog"
    /// <summary>
    /// Enables clients to create new resources.
    /// <see href="http://open-services.net/ns/core#creationFactory"></see></summary>
    let creationFactory = _prefix "creationFactory"
    /// <summary>
    /// Used in conjunction with oslc:usage property used to identify
    /// 		which service is the default usage.
    /// <see href="http://open-services.net/ns/core#default"></see></summary>
    let default_ = _prefix "default"
    /// <summary>
    /// A default value for property, inlined into property definition.
    /// <see href="http://open-services.net/ns/core#defaultValue"></see></summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// A URL that may be used to retrieve a web page to determine additional details about the service provider.
    /// <see href="http://open-services.net/ns/core#details"></see></summary>
    let details = _prefix "details"
    /// <summary>
    /// The URI of the dialog.
    /// <see href="http://open-services.net/ns/core#dialog"></see></summary>
    let dialog = _prefix "dialog"
    /// <summary>
    /// A series of notes and comments about this resource.
    /// <see href="http://open-services.net/ns/core#discussedBy"></see></summary>
    let discussedBy = _prefix "discussedBy"
    /// <summary>
    /// Reference to associated resource.
    /// <see href="http://open-services.net/ns/core#discussionAbout"></see></summary>
    let discussionAbout = _prefix "discussionAbout"
    /// <summary>
    /// The URI of an HTML document to be used for the preview.
    /// <see href="http://open-services.net/ns/core#document"></see></summary>
    let document = _prefix "document"
    /// <summary>
    /// Namespace URI of the specification that is implemented by this service. In most cases this namespace URI will be for an OSLC domain, but other URIs MAY be used.
    /// <see href="http://open-services.net/ns/core#domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// Extended (additional) error information.
    /// <see href="http://open-services.net/ns/core#extendedError"></see></summary>
    let extendedError = _prefix "extendedError"
    /// <summary>
    /// A hint that indicates that property MAY be hidden when presented in a user interface.
    /// <see href="http://open-services.net/ns/core#hidden"></see></summary>
    let hidden = _prefix "hidden"
    /// <summary>
    /// Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#hintHeight"></see></summary>
    let hintHeight = _prefix "hintHeight"
    /// <summary>
    /// Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#hintWidth"></see></summary>
    let hintWidth = _prefix "hintWidth"
    /// <summary>
    /// URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size.
    /// <see href="http://open-services.net/ns/core#icon"></see></summary>
    let icon = _prefix "icon"
    /// <summary>
    /// Reference to comment this comment is in reply to.
    /// <see href="http://open-services.net/ns/core#inReplyTo"></see></summary>
    let inReplyTo = _prefix "inReplyTo"
    /// <summary>
    /// Recommended initial height of the preview. The presence of this property indicates that the preview supports dynamically computing its size. Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1). Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#initialHeight"></see></summary>
    let initialHeight = _prefix "initialHeight"
    /// <summary>
    /// Used to define when a property is a member of a container, useful for query.
    /// <see href="http://open-services.net/ns/core#isMemberProperty"></see></summary>
    let isMemberProperty = _prefix "isMemberProperty"
    /// <summary>
    /// Very short label for use in menu items.
    /// <see href="http://open-services.net/ns/core#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// URI and sizing properties for an HTML document to be used for a large preview.
    /// <see href="http://open-services.net/ns/core#largePreview"></see></summary>
    let largePreview = _prefix "largePreview"
    /// <summary>
    /// For String properties only, specifies maximum characters allowed. If not set, then there is no maximum or maximum is specified elsewhere.
    /// <see href="http://open-services.net/ns/core#maxSize"></see></summary>
    let maxSize = _prefix "maxSize"
    /// <summary>
    /// An informative message describing the error that occurred.
    /// <see href="http://open-services.net/ns/core#message"></see></summary>
    let message = _prefix "message"
    /// <summary>
    /// The URI of a resource describing the entity that most recently modified this resource.  The link target is usually a foaf:Person or foaf:Agent, but could be any type.  This is modeled after dcterms:creator, but Dublin Core currently has no equivalent property.
    /// <see href="http://open-services.net/ns/core#modifiedBy"></see></summary>
    let modifiedBy = _prefix "modifiedBy"
    /// <summary>
    /// A resource giving more information on the error SHOULD be of an HTML content-type.
    /// <see href="http://open-services.net/ns/core#moreInfo"></see></summary>
    let moreInfo = _prefix "moreInfo"
    /// <summary>
    /// Name of property being defined, i.e. second part of property's Prefixed Name.
    /// <see href="http://open-services.net/ns/core#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Link to next page of response.
    /// <see href="http://open-services.net/ns/core#nextPage"></see></summary>
    let nextPage = _prefix "nextPage"
    /// <summary>
    /// URI for obtaining OAuth access token.
    /// <see href="http://open-services.net/ns/core#oauthAccessTokenURI"></see></summary>
    let oauthAccessTokenURI = _prefix "oauthAccessTokenURI"
    /// <summary>
    /// Defines the three OAuth URIs required for a client to act as an OAuth consumer.
    /// <see href="http://open-services.net/ns/core#oauthConfiguration"></see></summary>
    let oauthConfiguration = _prefix "oauthConfiguration"
    /// <summary>
    /// URI for obtaining OAuth request token.
    /// <see href="http://open-services.net/ns/core#oauthRequestTokenURI"></see></summary>
    let oauthRequestTokenURI = _prefix "oauthRequestTokenURI"
    /// <summary>
    /// MUST be either http://open-services.net/ns/core#Exactly-one, http://open-services.net/ns/core#Zero-or-one, http://open-services.net/ns/core#Zero-or-many or http://open-services.net/ns/core#One-or-many.
    /// <see href="http://open-services.net/ns/core#occurs"></see></summary>
    let occurs = _prefix "occurs"
    /// <summary>
    /// Reference to owning Discussion resource .
    /// <see href="http://open-services.net/ns/core#partOfDiscussion"></see></summary>
    let partOfDiscussion = _prefix "partOfDiscussion"
    /// <summary>
    /// Namespace prefix to be used for this namespace.
    /// <see href="http://open-services.net/ns/core#prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// The base URI of the namespace.
    /// <see href="http://open-services.net/ns/core#prefixBase"></see></summary>
    let prefixBase = _prefix "prefixBase"
    /// <summary>
    /// Defines a namespace prefix for use in JSON representations and in forming OSLC Query Syntax strings.
    /// <see href="http://open-services.net/ns/core#prefixDefinition"></see></summary>
    let prefixDefinition = _prefix "prefixDefinition"
    /// <summary>
    /// The properties that are allowed or required by this shape.
    /// <see href="http://open-services.net/ns/core#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// URI of the property whose usage is being described.
    /// <see href="http://open-services.net/ns/core#propertyDefinition"></see></summary>
    let propertyDefinition = _prefix "propertyDefinition"
    /// <summary>
    /// The base URI to use for queries. Queries may be invoked either by HTTP GET or HTTP POST. For HTTP GET, a query URI is formed by appending a key=value pair to the base URI. For HTTP POST, the query parameters are encoded as content with media type application/x-www-form-urlencoded and sent in the request body. The base URI MAY accept other query languages and media types in the request body, e.g. application/sparql-query for SPARQL queries.
    /// <see href="http://open-services.net/ns/core#queryBase"></see></summary>
    let queryBase = _prefix "queryBase"
    /// <summary>
    /// Enables clients query across a collection of resources.
    /// <see href="http://open-services.net/ns/core#queryCapability"></see></summary>
    let queryCapability = _prefix "queryCapability"
    /// <summary>
    /// For properties with a resource value-type, Providers MAY also specify the range of possible resource types allowed, each specified by URI. The default range is http://open-services.net/ns/core#Any.
    /// <see href="http://open-services.net/ns/core#range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// true if the property is read-only. If omitted, or set to false, then the property is writable. Providers SHOULD declare a property read-only when changes to the value of that property will not be accepted after the resource has been created, e.g. on PUT/PATCH requests. Consumers should note that the converse does not apply: Providers MAY reject a change to the value of a writable property.
    /// <see href="http://open-services.net/ns/core#readOnly"></see></summary>
    let readOnly = _prefix "readOnly"
    /// <summary>
    /// If present and set to 'alternate' then indicates that work-around is provided, behavior for other values is undefined.
    /// <see href="http://open-services.net/ns/core#rel"></see></summary>
    let rel = _prefix "rel"
    /// <summary>
    /// Should be http://open-services.net/ns/core#Reference, http://open-services.net/ns/core#Inline or http://open-services.net/ns/core#Either
    /// <see href="http://open-services.net/ns/core#representation"></see></summary>
    let representation = _prefix "representation"
    /// <summary>
    /// A Creation Factory MAY provide Resource Shapes that describe shapes of resources that may be created.
    /// <see href="http://open-services.net/ns/core#resourceShape"></see></summary>
    let resourceShape = _prefix "resourceShape"
    /// <summary>
    /// The expected resource type URI of the resource that will be created using this creation factory. These would be the URIs found in the result resource's rdf:type property.
    /// <see href="http://open-services.net/ns/core#resourceType"></see></summary>
    let resourceType = _prefix "resourceType"
    /// <summary>
    /// Used to hold the results of dialog action or JSON query results (default).
    /// 		The JSON query result attribute 'oslc:results' is used whenever a provider doesn't have
    /// 		a suitable property already in its model for such purposes.
    /// <see href="http://open-services.net/ns/core#results"></see></summary>
    let results = _prefix "results"
    /// <summary>
    /// Enables clients to select a resource via UI.
    /// <see href="http://open-services.net/ns/core#selectionDialog"></see></summary>
    let selectionDialog = _prefix "selectionDialog"
    /// <summary>
    /// Describes a service offered by the service provider.
    /// <see href="http://open-services.net/ns/core#service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    /// A link to the resource's OSLC Service Provider.
    /// <see href="http://open-services.net/ns/core#serviceProvider"></see></summary>
    let serviceProvider = _prefix "serviceProvider"
    /// <summary>
    /// Additional service provider catalog.
    /// <see href="http://open-services.net/ns/core#serviceProviderCatalog"></see></summary>
    let serviceProviderCatalog = _prefix "serviceProviderCatalog"
    /// <summary>
    /// Shorter form of dcterms:identifier for the resource.
    /// <see href="http://open-services.net/ns/core#shortId"></see></summary>
    let shortId = _prefix "shortId"
    /// <summary>
    /// Shorter form of dcterms:title for the resource.
    /// <see href="http://open-services.net/ns/core#shortTitle"></see></summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    /// URI and sizing properties for an HTML document to be used for a small preview.
    /// <see href="http://open-services.net/ns/core#smallPreview"></see></summary>
    let smallPreview = _prefix "smallPreview"
    /// <summary>
    /// The HTTP status code reported with the error.
    /// <see href="http://open-services.net/ns/core#statusCode"></see></summary>
    let statusCode = _prefix "statusCode"
    /// <summary>
    /// This optional property indicates the total number of results across all pages,
    /// 		its value should be non-negative. In the context of a query resource, this value SHOULD
    /// 		be the total number of results, i.e. the number of resources that match the query.
    /// 		In the context of other resources, the value SHOULD be the total number of property
    /// 		values (i.e. RDF triples) of the resource. Unless Stable Paging is in effect, the
    /// 		total count MAY vary as a client retrieves subsequent pages.
    /// <see href="http://open-services.net/ns/core#totalCount"></see></summary>
    let totalCount = _prefix "totalCount"
    /// <summary>
    /// An identifier URI for the domain specified usage of this creation factory. If a service provides multiple creation factories, it may designate the primary or default one that should be used with a property value of http://open-services.net/ns/core#default.
    /// <see href="http://open-services.net/ns/core#usage"></see></summary>
    let usage = _prefix "usage"
    /// <summary>
    /// if the value-type is a resource type, then Property MAY provide a shape value to indicate the Resource Shape that applies to the resource.
    /// <see href="http://open-services.net/ns/core#valueShape"></see></summary>
    let valueShape = _prefix "valueShape"
    /// <summary>
    /// A URI that indicates the value type, for example XML Schema or RDF URIs for literal value types, and OSLC-specified for others.  If this property is omitted, then the value type is unconstrained.
    /// <see href="http://open-services.net/ns/core#valueType"></see></summary>
    let valueType = _prefix "valueType"
