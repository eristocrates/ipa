namespace http.open_services.net.ns.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oslc =
    let _namespace_iri = Namespace_Iri oslc |> NamespaceIRI
    /// <summary>
    ///   <para>oslc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#">http://open-services.net/ns/core#</seealso>
    let _prefix_iri = Prefixed_Name(oslc, "") |> PrefixedName
    /// <summary>
    ///   <para>oslc:AllowedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Allowed values for one property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AllowedValues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#AllowedValues">http://open-services.net/ns/core#AllowedValues</seealso>
    let AllowedValues = Prefixed_Name(oslc, "AllowedValues") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Any</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Any value type is allowed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Any"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Any">http://open-services.net/ns/core#Any</seealso>
    let Any = Prefixed_Name(oslc, "Any") |> PrefixedName
    /// <summary>
    ///   <para>oslc:AnyResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>"AnyResource: value is either a Resource or Local Resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnyResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#AnyResource">http://open-services.net/ns/core#AnyResource</seealso>
    let AnyResource = Prefixed_Name(oslc, "AnyResource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Comment resource represents a single note, or comment, in a discussion thread."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Comment">http://open-services.net/ns/core#Comment</seealso>
    let Comment = Prefixed_Name(oslc, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Compact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Compact representation, fetched as application/x-oslc-compact+xml"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Compact">http://open-services.net/ns/core#Compact</seealso>
    let Compact = Prefixed_Name(oslc, "Compact") |> PrefixedName
    /// <summary>
    ///   <para>oslc:CreationFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The CreationFactory definition included in a ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CreationFactory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#CreationFactory">http://open-services.net/ns/core#CreationFactory</seealso>
    let CreationFactory = Prefixed_Name(oslc, "CreationFactory") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Dialog definition included in ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dialog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Dialog">http://open-services.net/ns/core#Dialog</seealso>
    let Dialog = Prefixed_Name(oslc, "Dialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Discussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Discussion resource is intended to represent a sequence of comments or notes regarding the associated resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Discussion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Discussion">http://open-services.net/ns/core#Discussion</seealso>
    let Discussion = Prefixed_Name(oslc, "Discussion") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Either</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Representations is either a URI reference or blank node."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Either"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Either">http://open-services.net/ns/core#Either</seealso>
    let Either = Prefixed_Name(oslc, "Either") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Basis for forming an error response."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Error">http://open-services.net/ns/core#Error</seealso>
    let Error = Prefixed_Name(oslc, "Error") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Exactly-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Property with value is required."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exactly-one"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Exactly-one">http://open-services.net/ns/core#Exactly-one</seealso>
    let Exactly_one = Prefixed_Name(oslc, "Exactly-one") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ExtendedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Extended error information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExtendedError"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ExtendedError">http://open-services.net/ns/core#ExtendedError</seealso>
    let ExtendedError = Prefixed_Name(oslc, "ExtendedError") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Inline</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An inline (RDF blank node) representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Inline">http://open-services.net/ns/core#Inline</seealso>
    let Inline = Prefixed_Name(oslc, "Inline") |> PrefixedName
    /// <summary>
    ///   <para>oslc:LocalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Local Resource: value is an resource available only inside the resource being defined (i.e. a Blank Node)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LocalResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#LocalResource">http://open-services.net/ns/core#LocalResource</seealso>
    let LocalResource = Prefixed_Name(oslc, "LocalResource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:OAuthConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The OAuthConfiguration definition included in ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OAuthConfiguration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#OAuthConfiguration">http://open-services.net/ns/core#OAuthConfiguration</seealso>
    let OAuthConfiguration = Prefixed_Name(oslc, "OAuthConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>oslc:One-or-many</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Property is required and multi-valued."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"One-or-many"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#One-or-many">http://open-services.net/ns/core#One-or-many</seealso>
    let One_or_many = Prefixed_Name(oslc, "One-or-many") |> PrefixedName
    /// <summary>
    ///   <para>oslc:PrefixDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The PrefixDefinition definition included in ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PrefixDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#PrefixDefinition">http://open-services.net/ns/core#PrefixDefinition</seealso>
    let PrefixDefinition = Prefixed_Name(oslc, "PrefixDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The UI Preview representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preview"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Preview">http://open-services.net/ns/core#Preview</seealso>
    let Preview = Prefixed_Name(oslc, "Preview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Property resource describes one allowed or required property of a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Property">http://open-services.net/ns/core#Property</seealso>
    let Property = Prefixed_Name(oslc, "Property") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Publisher definition included in ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Publisher">http://open-services.net/ns/core#Publisher</seealso>
    let Publisher = Prefixed_Name(oslc, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>oslc:QueryCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The QueryCapability definition included in a ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QueryCapability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#QueryCapability">http://open-services.net/ns/core#QueryCapability</seealso>
    let QueryCapability = Prefixed_Name(oslc, "QueryCapability") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A URI Reference representation to a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Reference">http://open-services.net/ns/core#Reference</seealso>
    let Reference = Prefixed_Name(oslc, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Resource: value is a resource at a specified URI (i.e. a URI Reference)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Resource">http://open-services.net/ns/core#Resource</seealso>
    let Resource = Prefixed_Name(oslc, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ResourceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Resource Shape used for creation, query and modify.  Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T, or if there is a triple R oslc:instanceShape S."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ResourceShape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ResourceShape">http://open-services.net/ns/core#ResourceShape</seealso>
    let ResourceShape = Prefixed_Name(oslc, "ResourceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ResponseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The ResponseInfo included in query results."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ResponseInfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ResponseInfo">http://open-services.net/ns/core#ResponseInfo</seealso>
    let ResponseInfo = Prefixed_Name(oslc, "ResponseInfo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Service definition included in a ServiceProvider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Service">http://open-services.net/ns/core#Service</seealso>
    let Service = Prefixed_Name(oslc, "Service") |> PrefixedName
    /// <summary>
    ///   <para>oslc:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Service Provider resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceProvider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ServiceProvider">http://open-services.net/ns/core#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(oslc, "ServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>oslc:ServiceProviderCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Service Provider Catalog resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ServiceProviderCatalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#ServiceProviderCatalog">http://open-services.net/ns/core#ServiceProviderCatalog</seealso>
    let ServiceProviderCatalog =
        Prefixed_Name(oslc, "ServiceProviderCatalog") |> PrefixedName

    /// <summary>
    ///   <para>oslc:Zero-or-many</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Property is optional and multi-valued."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zero-or-many"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Zero-or-many">http://open-services.net/ns/core#Zero-or-many</seealso>
    let Zero_or_many = Prefixed_Name(oslc, "Zero-or-many") |> PrefixedName
    /// <summary>
    ///   <para>oslc:Zero-or-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Property is optional and single valued."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zero-or-one"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#Zero-or-one">http://open-services.net/ns/core#Zero-or-one</seealso>
    let Zero_or_one = Prefixed_Name(oslc, "Zero-or-one") |> PrefixedName
    /// <summary>
    ///   <para>oslc:allowedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"value allowed for a property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"allowedValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#allowedValue">http://open-services.net/ns/core#allowedValue</seealso>
    let allowedValue = Prefixed_Name(oslc, "allowedValue") |> PrefixedName
    /// <summary>
    ///   <para>oslc:allowedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Resource with allowed values for the property being defined. Range of oslc:AllowedValues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"allowedValues"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#allowedValues">http://open-services.net/ns/core#allowedValues</seealso>
    let allowedValues = Prefixed_Name(oslc, "allowedValues") |> PrefixedName
    /// <summary>
    ///   <para>oslc:authorizationURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI for obtaining OAuth authorization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"authorizationURI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#authorizationURI">http://open-services.net/ns/core#authorizationURI</seealso>
    let authorizationURI = Prefixed_Name(oslc, "authorizationURI") |> PrefixedName
    /// <summary>
    ///   <para>oslc:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Comment about the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#comment">http://open-services.net/ns/core#comment</seealso>
    let comment = Prefixed_Name(oslc, "comment") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To create a new resource via the factory, post it to this URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creation">http://open-services.net/ns/core#creation</seealso>
    let creation = Prefixed_Name(oslc, "creation") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creationDialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Enables clients to create a resource via UI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creationDialog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creationDialog">http://open-services.net/ns/core#creationDialog</seealso>
    let creationDialog = Prefixed_Name(oslc, "creationDialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:creationFactory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Enables clients to create new resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creationFactory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#creationFactory">http://open-services.net/ns/core#creationFactory</seealso>
    let creationFactory = Prefixed_Name(oslc, "creationFactory") |> PrefixedName
    /// <summary>
    ///   <para>oslc:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Used in conjunction with oslc:usage property used to identify
    /// 		which service is the default usage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"default"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#default">http://open-services.net/ns/core#default</seealso>
    let default_ = Prefixed_Name(oslc, "default") |> PrefixedName
    /// <summary>
    ///   <para>oslc:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A default value for property, inlined into property definition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"defaultValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#defaultValue">http://open-services.net/ns/core#defaultValue</seealso>
    let defaultValue = Prefixed_Name(oslc, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>oslc:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This shape describes resources that are of the RDF type given by the object of the oslc:describes predicate. Formally, a shape S applies to a resource R if there is a triple R rdf:type T and there is a triple S oslc:describes T."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"describes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#describes">http://open-services.net/ns/core#describes</seealso>
    let describes = Prefixed_Name(oslc, "describes") |> PrefixedName
    /// <summary>
    ///   <para>oslc:details</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A URL that may be used to retrieve a web page to determine additional details about the service provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"details"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#details">http://open-services.net/ns/core#details</seealso>
    let details = Prefixed_Name(oslc, "details") |> PrefixedName
    /// <summary>
    ///   <para>oslc:dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URI of the dialog."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dialog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#dialog">http://open-services.net/ns/core#dialog</seealso>
    let dialog = Prefixed_Name(oslc, "dialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:discussedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A series of notes and comments about this resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"discussedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#discussedBy">http://open-services.net/ns/core#discussedBy</seealso>
    let discussedBy = Prefixed_Name(oslc, "discussedBy") |> PrefixedName
    /// <summary>
    ///   <para>oslc:discussionAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Reference to associated resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"discussionAbout"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#discussionAbout">http://open-services.net/ns/core#discussionAbout</seealso>
    let discussionAbout = Prefixed_Name(oslc, "discussionAbout") |> PrefixedName
    /// <summary>
    ///   <para>oslc:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The URI of an HTML document to be used for the preview."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#document">http://open-services.net/ns/core#document</seealso>
    let document = Prefixed_Name(oslc, "document") |> PrefixedName
    /// <summary>
    ///   <para>oslc:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Namespace URI of the specification that is implemented by this service. In most cases this namespace URI will be for an OSLC domain, but other URIs MAY be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#domain">http://open-services.net/ns/core#domain</seealso>
    let domain = Prefixed_Name(oslc, "domain") |> PrefixedName
    /// <summary>
    ///   <para>oslc:extendedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Extended (additional) error information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"extendedError"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#extendedError">http://open-services.net/ns/core#extendedError</seealso>
    let extendedError = Prefixed_Name(oslc, "extendedError") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A hint that indicates that property MAY be hidden when presented in a user interface."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hidden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hidden">http://open-services.net/ns/core#hidden</seealso>
    let hidden = Prefixed_Name(oslc, "hidden") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hintHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hintHeight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hintHeight">http://open-services.net/ns/core#hintHeight</seealso>
    let hintHeight = Prefixed_Name(oslc, "hintHeight") |> PrefixedName
    /// <summary>
    ///   <para>oslc:hintWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1) Em and ex units are interpreted relative to the default system font (at 100% size)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hintWidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#hintWidth">http://open-services.net/ns/core#hintWidth</seealso>
    let hintWidth = Prefixed_Name(oslc, "hintWidth") |> PrefixedName
    /// <summary>
    ///   <para>oslc:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"icon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#icon">http://open-services.net/ns/core#icon</seealso>
    let icon = Prefixed_Name(oslc, "icon") |> PrefixedName
    /// <summary>
    ///   <para>oslc:inReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Reference to comment this comment is in reply to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inReplyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#inReplyTo">http://open-services.net/ns/core#inReplyTo</seealso>
    let inReplyTo = Prefixed_Name(oslc, "inReplyTo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:initialHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Recommended initial height of the preview. The presence of this property indicates that the preview supports dynamically computing its size. Values MUST be expressed in relative length units as defined in the W3C Cascading Style Sheets Specification (CSS 2.1). Em and ex units are interpreted relative to the default system font (at 100% size)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"initialHeight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#initialHeight">http://open-services.net/ns/core#initialHeight</seealso>
    let initialHeight = Prefixed_Name(oslc, "initialHeight") |> PrefixedName
    /// <summary>
    ///   <para>oslc:instanceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URI of a Resource Shape that describes the possible properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"instanceShape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#instanceShape">http://open-services.net/ns/core#instanceShape</seealso>
    let instanceShape = Prefixed_Name(oslc, "instanceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:inverseLabel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open-services.net/ns/core#inverseLabel">http://open-services.net/ns/core#inverseLabel</seealso>
    let inverseLabel = Prefixed_Name(oslc, "inverseLabel") |> PrefixedName
    /// <summary>
    ///   <para>oslc:isMemberProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to define when a property is a member of a container, useful for query."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isMemberProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#isMemberProperty">http://open-services.net/ns/core#isMemberProperty</seealso>
    let isMemberProperty = Prefixed_Name(oslc, "isMemberProperty") |> PrefixedName
    /// <summary>
    ///   <para>oslc:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Very short label for use in menu items."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#label">http://open-services.net/ns/core#label</seealso>
    let label = Prefixed_Name(oslc, "label") |> PrefixedName
    /// <summary>
    ///   <para>oslc:largePreview</para>
    /// </summary>
    /// <remarks>
    ///   <para>"URI and sizing properties for an HTML document to be used for a large preview."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"largePreview"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#largePreview">http://open-services.net/ns/core#largePreview</seealso>
    let largePreview = Prefixed_Name(oslc, "largePreview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:maxSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For String properties only, specifies maximum characters allowed. If not set, then there is no maximum or maximum is specified elsewhere."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maxSize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#maxSize">http://open-services.net/ns/core#maxSize</seealso>
    let maxSize = Prefixed_Name(oslc, "maxSize") |> PrefixedName
    /// <summary>
    ///   <para>oslc:message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An informative message describing the error that occurred."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#message">http://open-services.net/ns/core#message</seealso>
    let message = Prefixed_Name(oslc, "message") |> PrefixedName
    /// <summary>
    ///   <para>oslc:modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URI of a resource describing the entity that most recently modified this resource.  The link target is usually a foaf:Person or foaf:Agent, but could be any type.  This is modeled after dcterms:creator, but Dublin Core currently has no equivalent property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modifiedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#modifiedBy">http://open-services.net/ns/core#modifiedBy</seealso>
    let modifiedBy = Prefixed_Name(oslc, "modifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>oslc:moreInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A resource giving more information on the error SHOULD be of an HTML content-type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"moreInfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#moreInfo">http://open-services.net/ns/core#moreInfo</seealso>
    let moreInfo = Prefixed_Name(oslc, "moreInfo") |> PrefixedName
    /// <summary>
    ///   <para>oslc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of property being defined, i.e. second part of property's Prefixed Name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#name">http://open-services.net/ns/core#name</seealso>
    let name = Prefixed_Name(oslc, "name") |> PrefixedName
    /// <summary>
    ///   <para>oslc:nextPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to next page of response."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nextPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#nextPage">http://open-services.net/ns/core#nextPage</seealso>
    let nextPage = Prefixed_Name(oslc, "nextPage") |> PrefixedName
    /// <summary>
    ///   <para>oslc:oauthAccessTokenURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI for obtaining OAuth access token."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"oauthAccessTokenURI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthAccessTokenURI">http://open-services.net/ns/core#oauthAccessTokenURI</seealso>
    let oauthAccessTokenURI = Prefixed_Name(oslc, "oauthAccessTokenURI") |> PrefixedName
    /// <summary>
    ///   <para>oslc:oauthConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines the three OAuth URIs required for a client to act as an OAuth consumer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"oauthConfiguration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthConfiguration">http://open-services.net/ns/core#oauthConfiguration</seealso>
    let oauthConfiguration = Prefixed_Name(oslc, "oauthConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>oslc:oauthRequestTokenURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI for obtaining OAuth request token."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"oauthRequestTokenURI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#oauthRequestTokenURI">http://open-services.net/ns/core#oauthRequestTokenURI</seealso>
    let oauthRequestTokenURI =
        Prefixed_Name(oslc, "oauthRequestTokenURI") |> PrefixedName

    /// <summary>
    ///   <para>oslc:occurs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"MUST be either http://open-services.net/ns/core#Exactly-one, http://open-services.net/ns/core#Zero-or-one, http://open-services.net/ns/core#Zero-or-many or http://open-services.net/ns/core#One-or-many."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occurs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#occurs">http://open-services.net/ns/core#occurs</seealso>
    let occurs = Prefixed_Name(oslc, "occurs") |> PrefixedName
    /// <summary>
    ///   <para>oslc:partOfDiscussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Reference to owning Discussion resource ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partOfDiscussion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#partOfDiscussion">http://open-services.net/ns/core#partOfDiscussion</seealso>
    let partOfDiscussion = Prefixed_Name(oslc, "partOfDiscussion") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Namespace prefix to be used for this namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefix">http://open-services.net/ns/core#prefix</seealso>
    let prefix = Prefixed_Name(oslc, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefixBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The base URI of the namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prefixBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefixBase">http://open-services.net/ns/core#prefixBase</seealso>
    let prefixBase = Prefixed_Name(oslc, "prefixBase") |> PrefixedName
    /// <summary>
    ///   <para>oslc:prefixDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines a namespace prefix for use in JSON representations and in forming OSLC Query Syntax strings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prefixDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#prefixDefinition">http://open-services.net/ns/core#prefixDefinition</seealso>
    let prefixDefinition = Prefixed_Name(oslc, "prefixDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The properties that are allowed or required by this shape."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#property">http://open-services.net/ns/core#property</seealso>
    let property = Prefixed_Name(oslc, "property") |> PrefixedName
    /// <summary>
    ///   <para>oslc:propertyDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI of the property whose usage is being described."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"propertyDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#propertyDefinition">http://open-services.net/ns/core#propertyDefinition</seealso>
    let propertyDefinition = Prefixed_Name(oslc, "propertyDefinition") |> PrefixedName
    /// <summary>
    ///   <para>oslc:queryBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The base URI to use for queries. Queries may be invoked either by HTTP GET or HTTP POST. For HTTP GET, a query URI is formed by appending a key=value pair to the base URI. For HTTP POST, the query parameters are encoded as content with media type application/x-www-form-urlencoded and sent in the request body. The base URI MAY accept other query languages and media types in the request body, e.g. application/sparql-query for SPARQL queries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"queryBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#queryBase">http://open-services.net/ns/core#queryBase</seealso>
    let queryBase = Prefixed_Name(oslc, "queryBase") |> PrefixedName
    /// <summary>
    ///   <para>oslc:queryCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Enables clients query across a collection of resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"queryCapability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#queryCapability">http://open-services.net/ns/core#queryCapability</seealso>
    let queryCapability = Prefixed_Name(oslc, "queryCapability") |> PrefixedName
    /// <summary>
    ///   <para>oslc:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For properties with a resource value-type, Providers MAY also specify the range of possible resource types allowed, each specified by URI. The default range is http://open-services.net/ns/core#Any."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#range">http://open-services.net/ns/core#range</seealso>
    let range = Prefixed_Name(oslc, "range") |> PrefixedName
    /// <summary>
    ///   <para>oslc:readOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"true if the property is read-only. If omitted, or set to false, then the property is writable. Providers SHOULD declare a property read-only when changes to the value of that property will not be accepted after the resource has been created, e.g. on PUT/PATCH requests. Consumers should note that the converse does not apply: Providers MAY reject a change to the value of a writable property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"readOnly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#readOnly">http://open-services.net/ns/core#readOnly</seealso>
    let readOnly = Prefixed_Name(oslc, "readOnly") |> PrefixedName
    /// <summary>
    ///   <para>oslc:rel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If present and set to 'alternate' then indicates that work-around is provided, behavior for other values is undefined."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#rel">http://open-services.net/ns/core#rel</seealso>
    let rel = Prefixed_Name(oslc, "rel") |> PrefixedName
    /// <summary>
    ///   <para>oslc:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Should be http://open-services.net/ns/core#Reference, http://open-services.net/ns/core#Inline or http://open-services.net/ns/core#Either"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#representation">http://open-services.net/ns/core#representation</seealso>
    let representation = Prefixed_Name(oslc, "representation") |> PrefixedName
    /// <summary>
    ///   <para>oslc:resourceShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Creation Factory MAY provide Resource Shapes that describe shapes of resources that may be created."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resourceShape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#resourceShape">http://open-services.net/ns/core#resourceShape</seealso>
    let resourceShape = Prefixed_Name(oslc, "resourceShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The expected resource type URI of the resource that will be created using this creation factory. These would be the URIs found in the result resource's rdf:type property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resourceType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#resourceType">http://open-services.net/ns/core#resourceType</seealso>
    let resourceType = Prefixed_Name(oslc, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>oslc:results</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to hold the results of dialog action or JSON query results (default).
    /// 		The JSON query result attribute 'oslc:results' is used whenever a provider doesn't have
    /// 		a suitable property already in its model for such purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#results">http://open-services.net/ns/core#results</seealso>
    let results = Prefixed_Name(oslc, "results") |> PrefixedName
    /// <summary>
    ///   <para>oslc:selectionDialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Enables clients to select a resource via UI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"selectionDialog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#selectionDialog">http://open-services.net/ns/core#selectionDialog</seealso>
    let selectionDialog = Prefixed_Name(oslc, "selectionDialog") |> PrefixedName
    /// <summary>
    ///   <para>oslc:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes a service offered by the service provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#service">http://open-services.net/ns/core#service</seealso>
    let service = Prefixed_Name(oslc, "service") |> PrefixedName
    /// <summary>
    ///   <para>oslc:serviceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to the resource's OSLC Service Provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serviceProvider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#serviceProvider">http://open-services.net/ns/core#serviceProvider</seealso>
    let serviceProvider = Prefixed_Name(oslc, "serviceProvider") |> PrefixedName

    /// <summary>
    ///   <para>oslc:serviceProviderCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Additional service provider catalog."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serviceProviderCatalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#serviceProviderCatalog">http://open-services.net/ns/core#serviceProviderCatalog</seealso>
    let serviceProviderCatalog =
        Prefixed_Name(oslc, "serviceProviderCatalog") |> PrefixedName

    /// <summary>
    ///   <para>oslc:shortId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Shorter form of dcterms:identifier for the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"shortId"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#shortId">http://open-services.net/ns/core#shortId</seealso>
    let shortId = Prefixed_Name(oslc, "shortId") |> PrefixedName
    /// <summary>
    ///   <para>oslc:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Shorter form of dcterms:title for the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"shortTitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#shortTitle">http://open-services.net/ns/core#shortTitle</seealso>
    let shortTitle = Prefixed_Name(oslc, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>oslc:smallPreview</para>
    /// </summary>
    /// <remarks>
    ///   <para>"URI and sizing properties for an HTML document to be used for a small preview."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"smallPreview"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#smallPreview">http://open-services.net/ns/core#smallPreview</seealso>
    let smallPreview = Prefixed_Name(oslc, "smallPreview") |> PrefixedName
    /// <summary>
    ///   <para>oslc:statusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The HTTP status code reported with the error."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statusCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#statusCode">http://open-services.net/ns/core#statusCode</seealso>
    let statusCode = Prefixed_Name(oslc, "statusCode") |> PrefixedName
    /// <summary>
    ///   <para>oslc:totalCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This optional property indicates the total number of results across all pages,
    /// 		its value should be non-negative. In the context of a query resource, this value SHOULD
    /// 		be the total number of results, i.e. the number of resources that match the query.
    /// 		In the context of other resources, the value SHOULD be the total number of property
    /// 		values (i.e. RDF triples) of the resource. Unless Stable Paging is in effect, the
    /// 		total count MAY vary as a client retrieves subsequent pages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"totalCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#totalCount">http://open-services.net/ns/core#totalCount</seealso>
    let totalCount = Prefixed_Name(oslc, "totalCount") |> PrefixedName
    /// <summary>
    ///   <para>oslc:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An identifier URI for the domain specified usage of this creation factory. If a service provides multiple creation factories, it may designate the primary or default one that should be used with a property value of http://open-services.net/ns/core#default."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#usage">http://open-services.net/ns/core#usage</seealso>
    let usage = Prefixed_Name(oslc, "usage") |> PrefixedName
    /// <summary>
    ///   <para>oslc:valueShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"if the value-type is a resource type, then Property MAY provide a shape value to indicate the Resource Shape that applies to the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valueShape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#valueShape">http://open-services.net/ns/core#valueShape</seealso>
    let valueShape = Prefixed_Name(oslc, "valueShape") |> PrefixedName
    /// <summary>
    ///   <para>oslc:valueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A URI that indicates the value type, for example XML Schema or RDF URIs for literal value types, and OSLC-specified for others.  If this property is omitted, then the value type is unconstrained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"valueType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core#valueType">http://open-services.net/ns/core#valueType</seealso>
    let valueType = Prefixed_Name(oslc, "valueType") |> PrefixedName
