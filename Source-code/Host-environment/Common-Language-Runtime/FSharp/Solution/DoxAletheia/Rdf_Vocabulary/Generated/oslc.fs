namespace http.open_services.net.ns.core.hash

open DoxAletheia.Rdf_Vocabulary

module oslc =
    let _namespace_name = "http://open-services.net/ns/core#"

    /// <summary>
    /// Allowed values for one property.
    /// <see href="http://open-services.net/ns/core#AllowedValues"></see></summary>
    let AllowedValues =
        Namespaced_IRI.parse _namespace_name "AllowedValues" |> NamespacedName

    /// <summary>
    /// Any value type is allowed.
    /// <see href="http://open-services.net/ns/core#Any"></see></summary>
    let Any = Namespaced_IRI.parse _namespace_name "Any" |> NamespacedName

    /// <summary>
    /// AnyResource: value is either a Resource or Local Resource.
    /// <see href="http://open-services.net/ns/core#AnyResource"></see></summary>
    let AnyResource =
        Namespaced_IRI.parse _namespace_name "AnyResource" |> NamespacedName

    /// <summary>
    /// A Comment resource represents a single note, or comment, in a discussion thread.
    /// <see href="http://open-services.net/ns/core#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    /// The Compact representation, fetched as application/x-oslc-compact+xml
    /// <see href="http://open-services.net/ns/core#Compact"></see></summary>
    let Compact = Namespaced_IRI.parse _namespace_name "Compact" |> NamespacedName

    /// <summary>
    /// The CreationFactory definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#CreationFactory"></see></summary>
    let CreationFactory =
        Namespaced_IRI.parse _namespace_name "CreationFactory" |> NamespacedName

    /// <summary>
    /// The Dialog definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Dialog"></see></summary>
    let Dialog = Namespaced_IRI.parse _namespace_name "Dialog" |> NamespacedName
    /// <summary>
    /// A Discussion resource is intended to represent a sequence of comments or notes regarding the associated resource
    /// <see href="http://open-services.net/ns/core#Discussion"></see></summary>
    let Discussion = Namespaced_IRI.parse _namespace_name "Discussion" |> NamespacedName
    /// <summary>
    /// Representations is either a URI reference or blank node.
    /// <see href="http://open-services.net/ns/core#Either"></see></summary>
    let Either = Namespaced_IRI.parse _namespace_name "Either" |> NamespacedName
    /// <summary>
    /// Basis for forming an error response.
    /// <see href="http://open-services.net/ns/core#Error"></see></summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName

    /// <summary>
    /// Property with value is required.
    /// <see href="http://open-services.net/ns/core#Exactly-one"></see></summary>
    let ``Exactly-one`` =
        Namespaced_IRI.parse _namespace_name "Exactly-one" |> NamespacedName

    /// <summary>
    /// Extended error information.
    /// <see href="http://open-services.net/ns/core#ExtendedError"></see></summary>
    let ExtendedError =
        Namespaced_IRI.parse _namespace_name "ExtendedError" |> NamespacedName

    /// <summary>
    /// An inline (RDF blank node) representation.
    /// <see href="http://open-services.net/ns/core#Inline"></see></summary>
    let Inline = Namespaced_IRI.parse _namespace_name "Inline" |> NamespacedName

    /// <summary>
    /// Local Resource: value is an resource available only inside the resource being defined (i.e. a Blank Node).
    /// <see href="http://open-services.net/ns/core#LocalResource"></see></summary>
    let LocalResource =
        Namespaced_IRI.parse _namespace_name "LocalResource" |> NamespacedName

    /// <summary>
    /// The OAuthConfiguration definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#OAuthConfiguration"></see></summary>
    let OAuthConfiguration =
        Namespaced_IRI.parse _namespace_name "OAuthConfiguration" |> NamespacedName

    /// <summary>
    /// Property is required and multi-valued.
    /// <see href="http://open-services.net/ns/core#One-or-many"></see></summary>
    let ``One-or-many`` =
        Namespaced_IRI.parse _namespace_name "One-or-many" |> NamespacedName

    /// <summary>
    /// The PrefixDefinition definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#PrefixDefinition"></see></summary>
    let PrefixDefinition =
        Namespaced_IRI.parse _namespace_name "PrefixDefinition" |> NamespacedName

    /// <summary>
    /// The UI Preview representation.
    /// <see href="http://open-services.net/ns/core#Preview"></see></summary>
    let Preview = Namespaced_IRI.parse _namespace_name "Preview" |> NamespacedName
    /// <summary>
    /// A Property resource describes one allowed or required property of a resource.
    /// <see href="http://open-services.net/ns/core#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// The Publisher definition included in ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Publisher"></see></summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    /// The QueryCapability definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#QueryCapability"></see></summary>
    let QueryCapability =
        Namespaced_IRI.parse _namespace_name "QueryCapability" |> NamespacedName

    /// <summary>
    /// A URI Reference representation to a resource.
    /// <see href="http://open-services.net/ns/core#Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// Resource: value is a resource at a specified URI (i.e. a URI Reference).
    /// <see href="http://open-services.net/ns/core#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// The Resource Shape used for creation, query and modify.  Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T, or if there is a triple R oslc:instanceShape S.
    /// <see href="http://open-services.net/ns/core#ResourceShape"></see></summary>
    let ResourceShape =
        Namespaced_IRI.parse _namespace_name "ResourceShape" |> NamespacedName

    /// <summary>
    /// The URI of a Resource Shape that describes the possible properties.
    /// <see href="http://open-services.net/ns/core#instanceShape"></see></summary>
    let instanceShape =
        Namespaced_IRI.parse _namespace_name "instanceShape" |> NamespacedName

    /// <summary>
    /// This shape describes resources that are of the RDF type given by the object of the oslc:describes predicate. Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T.
    /// <see href="http://open-services.net/ns/core#describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// The ResponseInfo included in query results.
    /// <see href="http://open-services.net/ns/core#ResponseInfo"></see></summary>
    let ResponseInfo =
        Namespaced_IRI.parse _namespace_name "ResponseInfo" |> NamespacedName

    /// <summary>
    /// The Service definition included in a ServiceProvider.
    /// <see href="http://open-services.net/ns/core#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// The Service Provider resource
    /// <see href="http://open-services.net/ns/core#ServiceProvider"></see></summary>
    let ServiceProvider =
        Namespaced_IRI.parse _namespace_name "ServiceProvider" |> NamespacedName

    /// <summary>
    /// The Service Provider Catalog resource
    /// <see href="http://open-services.net/ns/core#ServiceProviderCatalog"></see></summary>
    let ServiceProviderCatalog =
        Namespaced_IRI.parse _namespace_name "ServiceProviderCatalog" |> NamespacedName

    /// <summary>
    /// Property is optional and multi-valued.
    /// <see href="http://open-services.net/ns/core#Zero-or-many"></see></summary>
    let ``Zero-or-many`` =
        Namespaced_IRI.parse _namespace_name "Zero-or-many" |> NamespacedName

    /// <summary>
    /// Property is optional and single valued.
    /// <see href="http://open-services.net/ns/core#Zero-or-one"></see></summary>
    let ``Zero-or-one`` =
        Namespaced_IRI.parse _namespace_name "Zero-or-one" |> NamespacedName

    /// <summary>
    /// value allowed for a property.
    /// <see href="http://open-services.net/ns/core#allowedValue"></see></summary>
    let allowedValue =
        Namespaced_IRI.parse _namespace_name "allowedValue" |> NamespacedName

    /// <summary>
    /// Resource with allowed values for the property being defined. Range of oslc:AllowedValues
    /// <see href="http://open-services.net/ns/core#allowedValues"></see></summary>
    let allowedValues =
        Namespaced_IRI.parse _namespace_name "allowedValues" |> NamespacedName

    /// <summary>
    /// URI for obtaining OAuth authorization.
    /// <see href="http://open-services.net/ns/core#authorizationURI"></see></summary>
    let authorizationURI =
        Namespaced_IRI.parse _namespace_name "authorizationURI" |> NamespacedName

    /// <summary>
    /// Comment about the resource.
    /// <see href="http://open-services.net/ns/core#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    /// To create a new resource via the factory, post it to this URI.
    /// <see href="http://open-services.net/ns/core#creation"></see></summary>
    let creation = Namespaced_IRI.parse _namespace_name "creation" |> NamespacedName

    /// <summary>
    /// Enables clients to create a resource via UI.
    /// <see href="http://open-services.net/ns/core#creationDialog"></see></summary>
    let creationDialog =
        Namespaced_IRI.parse _namespace_name "creationDialog" |> NamespacedName

    /// <summary>
    /// Enables clients to create new resources.
    /// <see href="http://open-services.net/ns/core#creationFactory"></see></summary>
    let creationFactory =
        Namespaced_IRI.parse _namespace_name "creationFactory" |> NamespacedName

    /// <summary>
    /// Used in conjunction with oslc:usage property used to identify
    /// 		which service is the default usage.
    /// <see href="http://open-services.net/ns/core#default"></see></summary>
    let default_ = Namespaced_IRI.parse _namespace_name "default" |> NamespacedName

    /// <summary>
    /// A default value for property, inlined into property definition.
    /// <see href="http://open-services.net/ns/core#defaultValue"></see></summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    /// A URL that may be used to retrieve a web page to determine additional details about the service provider.
    /// <see href="http://open-services.net/ns/core#details"></see></summary>
    let details = Namespaced_IRI.parse _namespace_name "details" |> NamespacedName
    /// <summary>
    /// The URI of the dialog.
    /// <see href="http://open-services.net/ns/core#dialog"></see></summary>
    let dialog = Namespaced_IRI.parse _namespace_name "dialog" |> NamespacedName

    /// <summary>
    /// A series of notes and comments about this resource.
    /// <see href="http://open-services.net/ns/core#discussedBy"></see></summary>
    let discussedBy =
        Namespaced_IRI.parse _namespace_name "discussedBy" |> NamespacedName

    /// <summary>
    /// Reference to associated resource.
    /// <see href="http://open-services.net/ns/core#discussionAbout"></see></summary>
    let discussionAbout =
        Namespaced_IRI.parse _namespace_name "discussionAbout" |> NamespacedName

    /// <summary>
    /// The URI of an HTML document to be used for the preview.
    /// <see href="http://open-services.net/ns/core#document"></see></summary>
    let document = Namespaced_IRI.parse _namespace_name "document" |> NamespacedName
    /// <summary>
    /// Namespace URI of the specification that is implemented by this service. In most cases this namespace URI will be for an OSLC domain, but other URIs MAY be used.
    /// <see href="http://open-services.net/ns/core#domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName

    /// <summary>
    /// Extended (additional) error information.
    /// <see href="http://open-services.net/ns/core#extendedError"></see></summary>
    let extendedError =
        Namespaced_IRI.parse _namespace_name "extendedError" |> NamespacedName

    /// <summary>
    /// A hint that indicates that property MAY be hidden when presented in a user interface.
    /// <see href="http://open-services.net/ns/core#hidden"></see></summary>
    let hidden = Namespaced_IRI.parse _namespace_name "hidden" |> NamespacedName
    /// <summary>
    /// Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#hintHeight"></see></summary>
    let hintHeight = Namespaced_IRI.parse _namespace_name "hintHeight" |> NamespacedName
    /// <summary>
    /// Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#hintWidth"></see></summary>
    let hintWidth = Namespaced_IRI.parse _namespace_name "hintWidth" |> NamespacedName
    /// <summary>
    /// URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size.
    /// <see href="http://open-services.net/ns/core#icon"></see></summary>
    let icon = Namespaced_IRI.parse _namespace_name "icon" |> NamespacedName
    /// <summary>
    /// Reference to comment this comment is in reply to.
    /// <see href="http://open-services.net/ns/core#inReplyTo"></see></summary>
    let inReplyTo = Namespaced_IRI.parse _namespace_name "inReplyTo" |> NamespacedName

    /// <summary>
    /// Recommended initial height of the preview. The presence of this property indicates that the preview supports dynamically computing its size. Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1). Em and ex units are interpreted relative to the default system font (at 100% size).
    /// <see href="http://open-services.net/ns/core#initialHeight"></see></summary>
    let initialHeight =
        Namespaced_IRI.parse _namespace_name "initialHeight" |> NamespacedName

    /// <summary>
    /// Used to define when a property is a member of a container, useful for query.
    /// <see href="http://open-services.net/ns/core#isMemberProperty"></see></summary>
    let isMemberProperty =
        Namespaced_IRI.parse _namespace_name "isMemberProperty" |> NamespacedName

    /// <summary>
    /// Very short label for use in menu items.
    /// <see href="http://open-services.net/ns/core#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    /// URI and sizing properties for an HTML document to be used for a large preview.
    /// <see href="http://open-services.net/ns/core#largePreview"></see></summary>
    let largePreview =
        Namespaced_IRI.parse _namespace_name "largePreview" |> NamespacedName

    /// <summary>
    /// For String properties only, specifies maximum characters allowed. If not set, then there is no maximum or maximum is specified elsewhere.
    /// <see href="http://open-services.net/ns/core#maxSize"></see></summary>
    let maxSize = Namespaced_IRI.parse _namespace_name "maxSize" |> NamespacedName
    /// <summary>
    /// An informative message describing the error that occurred.
    /// <see href="http://open-services.net/ns/core#message"></see></summary>
    let message = Namespaced_IRI.parse _namespace_name "message" |> NamespacedName
    /// <summary>
    /// The URI of a resource describing the entity that most recently modified this resource.  The link target is usually a foaf:Person or foaf:Agent, but could be any type.  This is modeled after dcterms:creator, but Dublin Core currently has no equivalent property.
    /// <see href="http://open-services.net/ns/core#modifiedBy"></see></summary>
    let modifiedBy = Namespaced_IRI.parse _namespace_name "modifiedBy" |> NamespacedName
    /// <summary>
    /// A resource giving more information on the error SHOULD be of an HTML content-type.
    /// <see href="http://open-services.net/ns/core#moreInfo"></see></summary>
    let moreInfo = Namespaced_IRI.parse _namespace_name "moreInfo" |> NamespacedName
    /// <summary>
    /// Name of property being defined, i.e. second part of property's Prefixed Name.
    /// <see href="http://open-services.net/ns/core#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Link to next page of response.
    /// <see href="http://open-services.net/ns/core#nextPage"></see></summary>
    let nextPage = Namespaced_IRI.parse _namespace_name "nextPage" |> NamespacedName

    /// <summary>
    /// URI for obtaining OAuth access token.
    /// <see href="http://open-services.net/ns/core#oauthAccessTokenURI"></see></summary>
    let oauthAccessTokenURI =
        Namespaced_IRI.parse _namespace_name "oauthAccessTokenURI" |> NamespacedName

    /// <summary>
    /// Defines the three OAuth URIs required for a client to act as an OAuth consumer.
    /// <see href="http://open-services.net/ns/core#oauthConfiguration"></see></summary>
    let oauthConfiguration =
        Namespaced_IRI.parse _namespace_name "oauthConfiguration" |> NamespacedName

    /// <summary>
    /// URI for obtaining OAuth request token.
    /// <see href="http://open-services.net/ns/core#oauthRequestTokenURI"></see></summary>
    let oauthRequestTokenURI =
        Namespaced_IRI.parse _namespace_name "oauthRequestTokenURI" |> NamespacedName

    /// <summary>
    /// MUST be either http://open-services.net/ns/core#Exactly-one, http://open-services.net/ns/core#Zero-or-one, http://open-services.net/ns/core#Zero-or-many or http://open-services.net/ns/core#One-or-many.
    /// <see href="http://open-services.net/ns/core#occurs"></see></summary>
    let occurs = Namespaced_IRI.parse _namespace_name "occurs" |> NamespacedName

    /// <summary>
    /// Reference to owning Discussion resource .
    /// <see href="http://open-services.net/ns/core#partOfDiscussion"></see></summary>
    let partOfDiscussion =
        Namespaced_IRI.parse _namespace_name "partOfDiscussion" |> NamespacedName

    /// <summary>
    /// Namespace prefix to be used for this namespace.
    /// <see href="http://open-services.net/ns/core#prefix"></see></summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    /// The base URI of the namespace.
    /// <see href="http://open-services.net/ns/core#prefixBase"></see></summary>
    let prefixBase = Namespaced_IRI.parse _namespace_name "prefixBase" |> NamespacedName

    /// <summary>
    /// Defines a namespace prefix for use in JSON representations and in forming OSLC Query Syntax strings.
    /// <see href="http://open-services.net/ns/core#prefixDefinition"></see></summary>
    let prefixDefinition =
        Namespaced_IRI.parse _namespace_name "prefixDefinition" |> NamespacedName

    /// <summary>
    /// The properties that are allowed or required by this shape.
    /// <see href="http://open-services.net/ns/core#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// URI of the property whose usage is being described.
    /// <see href="http://open-services.net/ns/core#propertyDefinition"></see></summary>
    let propertyDefinition =
        Namespaced_IRI.parse _namespace_name "propertyDefinition" |> NamespacedName

    /// <summary>
    /// The base URI to use for queries. Queries may be invoked either by HTTP GET or HTTP POST. For HTTP GET, a query URI is formed by appending a key=value pair to the base URI. For HTTP POST, the query parameters are encoded as content with media type application/x-www-form-urlencoded and sent in the request body. The base URI MAY accept other query languages and media types in the request body, e.g. application/sparql-query for SPARQL queries.
    /// <see href="http://open-services.net/ns/core#queryBase"></see></summary>
    let queryBase = Namespaced_IRI.parse _namespace_name "queryBase" |> NamespacedName

    /// <summary>
    /// Enables clients query across a collection of resources.
    /// <see href="http://open-services.net/ns/core#queryCapability"></see></summary>
    let queryCapability =
        Namespaced_IRI.parse _namespace_name "queryCapability" |> NamespacedName

    /// <summary>
    /// For properties with a resource value-type, Providers MAY also specify the range of possible resource types allowed, each specified by URI. The default range is http://open-services.net/ns/core#Any.
    /// <see href="http://open-services.net/ns/core#range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName
    /// <summary>
    /// true if the property is read-only. If omitted, or set to false, then the property is writable. Providers SHOULD declare a property read-only when changes to the value of that property will not be accepted after the resource has been created, e.g. on PUT/PATCH requests. Consumers should note that the converse does not apply: Providers MAY reject a change to the value of a writable property.
    /// <see href="http://open-services.net/ns/core#readOnly"></see></summary>
    let readOnly = Namespaced_IRI.parse _namespace_name "readOnly" |> NamespacedName
    /// <summary>
    /// If present and set to 'alternate' then indicates that work-around is provided, behavior for other values is undefined.
    /// <see href="http://open-services.net/ns/core#rel"></see></summary>
    let rel = Namespaced_IRI.parse _namespace_name "rel" |> NamespacedName

    /// <summary>
    /// Should be http://open-services.net/ns/core#Reference, http://open-services.net/ns/core#Inline or http://open-services.net/ns/core#Either
    /// <see href="http://open-services.net/ns/core#representation"></see></summary>
    let representation =
        Namespaced_IRI.parse _namespace_name "representation" |> NamespacedName

    /// <summary>
    /// A Creation Factory MAY provide Resource Shapes that describe shapes of resources that may be created.
    /// <see href="http://open-services.net/ns/core#resourceShape"></see></summary>
    let resourceShape =
        Namespaced_IRI.parse _namespace_name "resourceShape" |> NamespacedName

    /// <summary>
    /// The expected resource type URI of the resource that will be created using this creation factory. These would be the URIs found in the result resource's rdf:type property.
    /// <see href="http://open-services.net/ns/core#resourceType"></see></summary>
    let resourceType =
        Namespaced_IRI.parse _namespace_name "resourceType" |> NamespacedName

    /// <summary>
    /// Used to hold the results of dialog action or JSON query results (default).
    /// 		The JSON query result attribute 'oslc:results' is used whenever a provider doesn't have
    /// 		a suitable property already in its model for such purposes.
    /// <see href="http://open-services.net/ns/core#results"></see></summary>
    let results = Namespaced_IRI.parse _namespace_name "results" |> NamespacedName

    /// <summary>
    /// Enables clients to select a resource via UI.
    /// <see href="http://open-services.net/ns/core#selectionDialog"></see></summary>
    let selectionDialog =
        Namespaced_IRI.parse _namespace_name "selectionDialog" |> NamespacedName

    /// <summary>
    /// Describes a service offered by the service provider.
    /// <see href="http://open-services.net/ns/core#service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    /// A link to the resource's OSLC Service Provider.
    /// <see href="http://open-services.net/ns/core#serviceProvider"></see></summary>
    let serviceProvider =
        Namespaced_IRI.parse _namespace_name "serviceProvider" |> NamespacedName

    /// <summary>
    /// Additional service provider catalog.
    /// <see href="http://open-services.net/ns/core#serviceProviderCatalog"></see></summary>
    let serviceProviderCatalog =
        Namespaced_IRI.parse _namespace_name "serviceProviderCatalog" |> NamespacedName

    /// <summary>
    /// Shorter form of dcterms:identifier for the resource.
    /// <see href="http://open-services.net/ns/core#shortId"></see></summary>
    let shortId = Namespaced_IRI.parse _namespace_name "shortId" |> NamespacedName
    /// <summary>
    /// Shorter form of dcterms:title for the resource.
    /// <see href="http://open-services.net/ns/core#shortTitle"></see></summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName

    /// <summary>
    /// URI and sizing properties for an HTML document to be used for a small preview.
    /// <see href="http://open-services.net/ns/core#smallPreview"></see></summary>
    let smallPreview =
        Namespaced_IRI.parse _namespace_name "smallPreview" |> NamespacedName

    /// <summary>
    /// The HTTP status code reported with the error.
    /// <see href="http://open-services.net/ns/core#statusCode"></see></summary>
    let statusCode = Namespaced_IRI.parse _namespace_name "statusCode" |> NamespacedName
    /// <summary>
    /// This optional property indicates the total number of results across all pages,
    /// 		its value should be non-negative. In the context of a query resource, this value SHOULD
    /// 		be the total number of results, i.e. the number of resources that match the query.
    /// 		In the context of other resources, the value SHOULD be the total number of property
    /// 		values (i.e. RDF triples) of the resource. Unless Stable Paging is in effect, the
    /// 		total count MAY vary as a client retrieves subsequent pages.
    /// <see href="http://open-services.net/ns/core#totalCount"></see></summary>
    let totalCount = Namespaced_IRI.parse _namespace_name "totalCount" |> NamespacedName
    /// <summary>
    /// An identifier URI for the domain specified usage of this creation factory. If a service provides multiple creation factories, it may designate the primary or default one that should be used with a property value of http://open-services.net/ns/core#default.
    /// <see href="http://open-services.net/ns/core#usage"></see></summary>
    let usage = Namespaced_IRI.parse _namespace_name "usage" |> NamespacedName
    /// <summary>
    /// if the value-type is a resource type, then Property MAY provide a shape value to indicate the Resource Shape that applies to the resource.
    /// <see href="http://open-services.net/ns/core#valueShape"></see></summary>
    let valueShape = Namespaced_IRI.parse _namespace_name "valueShape" |> NamespacedName
    /// <summary>
    /// A URI that indicates the value type, for example XML Schema or RDF URIs for literal value types, and OSLC-specified for others.  If this property is omitted, then the value type is unconstrained.
    /// <see href="http://open-services.net/ns/core#valueType"></see></summary>
    let valueType = Namespaced_IRI.parse _namespace_name "valueType" |> NamespacedName
