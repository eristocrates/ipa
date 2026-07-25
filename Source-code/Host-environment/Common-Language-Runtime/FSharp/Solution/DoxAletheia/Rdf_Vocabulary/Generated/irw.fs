namespace http.www.ontologydesignpatterns.org.ont.web.irw.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module irw =
    let _namespace_iri = Namespace_Iri irw |> NamespaceIRI
    /// <summary>
    ///   <para>irw:InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>They are *about* something, this something can be everything (rdfs:Resource, owl:Thing, ire:Entity) including AnalogResource. Their essential characteristics can be conveyed in a single message. They can be associated with a URI, and can have a WebRepresentation, in this case they are called WebResource. They have some realization, for example: the text of Moby Dick is an InformationResource, a book containing the text of Moby Dick is one of its realization. The intuition behind the class InformationResource is the same behind the class ir:InformationRealization (cloned from Dolce Ultra Lite).</para>
    /// labels<para>information resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#InformationResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#InformationResource</seealso>
    let InformationResource = Prefixed_Name(irw, "InformationResource") |> PrefixedName

    /// <summary>
    ///   <para>irw:NonInformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All Semantic Web resources that are not information resources. They include abstract, conceptual, and physical resources.</para>
    /// labels<para>non-information resources</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#NonInformationResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#NonInformationResource</seealso>
    let NonInformationResource =
        Prefixed_Name(irw, "NonInformationResource") |> PrefixedName

    /// <summary>
    ///   <para>irw:WebRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The realization of a message encoding that 'goes on the wire' according to an interaction protocol (e.g. http) in order to resolve a Web accessible resource. Representation have neither a URL nor a URI, they are associated with the URL of the Web Resource they represent. Representation are disjoint with Web resources</para>
    /// labels<para>awww representation</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation">http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation</seealso>
    let WebRepresentation = Prefixed_Name(irw, "WebRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>irw:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>media type</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#MediaType">http://www.ontologydesignpatterns.org/ont/web/irw.owl#MediaType</seealso>
    let MediaType = Prefixed_Name(irw, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>irw:ConceptualResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resources that are created in the social communication process. A conceptual resource does not exist if it's not in a social communication. For example: legal entities, political entities, social relations, concepts, etc.</para>
    /// labels<para>conceptual resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#ConceptualResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#ConceptualResource</seealso>
    let ConceptualResource = Prefixed_Name(irw, "ConceptualResource") |> PrefixedName
    /// <summary>
    ///   <para>irw:resolvesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a URI to a concrete Web server, which currently is done by mapping a URI to an IP address or addresses.</para>
    /// labels<para>resolves to</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#resolvesTo">http://www.ontologydesignpatterns.org/ont/web/irw.owl#resolvesTo</seealso>
    let resolvesTo = Prefixed_Name(irw, "resolvesTo") |> PrefixedName
    /// <summary>
    ///   <para>irw:isIdentifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is identified by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isIdentifiedBy">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isIdentifiedBy</seealso>
    let isIdentifiedBy = Prefixed_Name(irw, "isIdentifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>irw:redirectsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Redirections can be used outside the Semantic Web between just normal information resources, their domain and range says nothing about the type of resource. The only important aspect is that the reseource that is the destination of the redirection must be associated with a WebRepresentation, hence it must be a WebResource. This property can be used as top property for expressing special types of redirections e.g. TAG's 303 redirection or hash convention.</para>
    /// labels<para>redirects to</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#redirectsTo">http://www.ontologydesignpatterns.org/ont/web/irw.owl#redirectsTo</seealso>
    let redirectsTo = Prefixed_Name(irw, "redirectsTo") |> PrefixedName
    /// <summary>
    ///   <para>irw:WebClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>web client</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebClient">http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebClient</seealso>
    let WebClient = Prefixed_Name(irw, "WebClient") |> PrefixedName
    /// <summary>
    ///   <para>irw:WebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>InformationResources that have at least one WebRepresentation and at least a URI. For example, a WebResource containing the text of Moby Dick and its WebRepresentation encoded in HTML in English language.</para>
    /// labels<para>web resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebResource</seealso>
    let WebResource = Prefixed_Name(irw, "WebResource") |> PrefixedName
    /// <summary>
    ///   <para>irw:SemanticWebURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subset of URI that identify typically analog things. In general they identify any resource but are not directly resolvable. They do not identify an accessible information resource.They act as a virtual delegate for exactly one resource, typically analog. They cause a re-direct or any other type of mechanism that makes the web server resolve another URI that is associated with a WebReource (see range of redirectTo)</para>
    /// labels<para>semantic web uri</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#SemanticWebURI">http://www.ontologydesignpatterns.org/ont/web/irw.owl#SemanticWebURI</seealso>
    let SemanticWebURI = Prefixed_Name(irw, "SemanticWebURI") |> PrefixedName
    /// <summary>
    ///   <para>irw:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>uri</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#URI">http://www.ontologydesignpatterns.org/ont/web/irw.owl#URI</seealso>
    let URI = Prefixed_Name(irw, "URI") |> PrefixedName
    /// <summary>
    ///   <para>irw:identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The relashionship between a URI and a resource. A URI identify only one resource, it acts as a "virtual" delegate for that resource on the Web. This is different from the refersTo relashionships. This latter holds between Resources, and it's not  functional. For example, http://www.example.com#me identifies only john, while john's homepage http://www.example.com/john.html refersTo me, the place where he works, his job, his personal interests, etc. If I want to describe John's characteristics e.g. his name, age, etc. on the Web, I will attach them to http://www.example.com#john. On the other hand, http://www.example.com/john.html identifies john's homepage, which is an information resource.</para>
    /// labels<para>identifies</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#identifies">http://www.ontologydesignpatterns.org/ont/web/irw.owl#identifies</seealso>
    let identifies = Prefixed_Name(irw, "identifies") |> PrefixedName
    /// <summary>
    ///   <para>irw:hasURIString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of this datatype property previously was "hasURI", but in this ontology a URI is modelled as a class, hence I though that it's better to clarify, even in the property name that it refers to the string value of a URI.</para>
    ///   <para>The value of the URI, a string compliant with the URI specification.</para>
    /// labels<para>has URI string value</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#hasURIString">http://www.ontologydesignpatterns.org/ont/web/irw.owl#hasURIString</seealso>
    let hasURIString = Prefixed_Name(irw, "hasURIString") |> PrefixedName
    /// <summary>
    ///   <para>irw:isEncodedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>encoded in</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isEncodedIn">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isEncodedIn</seealso>
    let isEncodedIn = Prefixed_Name(irw, "isEncodedIn") |> PrefixedName
    /// <summary>
    ///   <para>irw:isResolutionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is resolution of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isResolutionOf">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isResolutionOf</seealso>
    let isResolutionOf = Prefixed_Name(irw, "isResolutionOf") |> PrefixedName
    /// <summary>
    ///   <para>irw:accesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A causal connection from a resource to the thing identiﬁed.</para>
    /// labels<para>accesses</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#accesses">http://www.ontologydesignpatterns.org/ont/web/irw.owl#accesses</seealso>
    let accesses = Prefixed_Name(irw, "accesses") |> PrefixedName
    /// <summary>
    ///   <para>irw:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is about</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAbout">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAbout</seealso>
    let isAbout = Prefixed_Name(irw, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>irw:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a WebServer and a WebRepresentation. It indicates that a WebServer concretely can respond to an HTTP request with a particular Web Representation.</para>
    /// labels<para>is location of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isLocationOf">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(irw, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>irw:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a resource and the information resource that is about it.</para>
    /// labels<para>is referenced by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isReferencedBy">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(irw, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>irw:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a URI and the resources it refers to.</para>
    /// labels<para>refers to</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#refersTo">http://www.ontologydesignpatterns.org/ont/web/irw.owl#refersTo</seealso>
    let refersTo = Prefixed_Name(irw, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>irw:isRequestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>WebClients that have requested a URI, like in typical HTTP GET requests.</para>
    /// labels<para>is requested by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isRequestedBy">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isRequestedBy</seealso>
    let isRequestedBy = Prefixed_Name(irw, "isRequestedBy") |> PrefixedName
    /// <summary>
    ///   <para>irw:WebServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>web server</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebServer">http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebServer</seealso>
    let WebServer = Prefixed_Name(irw, "WebServer") |> PrefixedName
    /// <summary>
    ///   <para>irw:isAccessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>requests</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAccessedBy">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAccessedBy</seealso>
    let isAccessedBy = Prefixed_Name(irw, "isAccessedBy") |> PrefixedName
    /// <summary>
    ///   <para>irw:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is meant to express the same intuition of rdfs:Resource but it is defined here in order to have OWL-DL compaibility. In an OWL Full version of this ontology we would have this class owl:equivalentClass rdfs:Resource.</para>
    /// labels<para>resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#Resource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#Resource</seealso>
    let Resource = Prefixed_Name(irw, "Resource") |> PrefixedName

    /// <summary>
    ///   <para>irw:PhysicalEntityResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that occupies its own space and has its own mass in the real world, and can have a "virtual delegate" on the Web. For example physical people, artifacts, places, bodies, chimical substances, biological entities, etc.</para>
    /// labels<para>physical resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#PhysicalEntityResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#PhysicalEntityResource</seealso>
    let PhysicalEntityResource =
        Prefixed_Name(irw, "PhysicalEntityResource") |> PrefixedName

    /// <summary>
    ///   <para>irw:AbstractResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract things. They are combinatorial spaces. They cannot be located in space-time. Examples are: the infinite set of integers, real numbers, formal entities, relations, functions, the infinite set of names that can be defined in namespaces.</para>
    /// labels<para>abstract resource</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#AbstractResource">http://www.ontologydesignpatterns.org/ont/web/irw.owl#AbstractResource</seealso>
    let AbstractResource = Prefixed_Name(irw, "AbstractResource") |> PrefixedName
    /// <summary>
    ///   <para>irw:encodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>encodes</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#encodes">http://www.ontologydesignpatterns.org/ont/web/irw.owl#encodes</seealso>
    let encodes = Prefixed_Name(irw, "encodes") |> PrefixedName
    /// <summary>
    ///   <para>irw:isTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is topic of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isTopicOf">http://www.ontologydesignpatterns.org/ont/web/irw.owl#isTopicOf</seealso>
    let isTopicOf = Prefixed_Name(irw, "isTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>irw:locatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a WebRepresentation and a WebServer, indicating that the WebRepresentation can be obtained by e.g. an HTTP request to the WebServer.</para>
    /// labels<para>located on</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#locatedOn">http://www.ontologydesignpatterns.org/ont/web/irw.owl#locatedOn</seealso>
    let locatedOn = Prefixed_Name(irw, "locatedOn") |> PrefixedName
    /// <summary>
    ///   <para>irw:requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Expresses the notion behind of a request operation of a web client, exempliﬁed by a typical HTTP GET request.</para>
    /// labels<para>requests</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#requests">http://www.ontologydesignpatterns.org/ont/web/irw.owl#requests</seealso>
    let requests = Prefixed_Name(irw, "requests") |> PrefixedName
