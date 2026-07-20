namespace http.www.ontologydesignpatterns.org.ont.web.irw.owl.hash

open DoxAletheia

module irw =
    let _namespace_name = "http://www.ontologydesignpatterns.org/ont/web/irw.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class is meant to express the same intuition of rdfs:Resource but it is defined here in order to have OWL-DL compaibility. In an OWL Full version of this ontology we would have this class owl:equivalentClass rdfs:Resource.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// They are *about* something, this something can be everything (rdfs:Resource, owl:Thing, ire:Entity) including AnalogResource. Their essential characteristics can be conveyed in a single message. They can be associated with a URI, and can have a WebRepresentation, in this case they are called WebResource. They have some realization, for example: the text of Moby Dick is an InformationResource, a book containing the text of Moby Dick is one of its realization. The intuition behind the class InformationResource is the same behind the class ir:InformationRealization (cloned from Dolce Ultra Lite).
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#InformationResource"></see></summary>
    let InformationResource = _prefix "InformationResource"
    /// <summary>
    /// Something that occupies its own space and has its own mass in the real world, and can have a "virtual delegate" on the Web. For example physical people, artifacts, places, bodies, chimical substances, biological entities, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#PhysicalEntityResource"></see></summary>
    let PhysicalEntityResource = _prefix "PhysicalEntityResource"
    /// <summary>
    /// Abstract things. They are combinatorial spaces. They cannot be located in space-time. Examples are: the infinite set of integers, real numbers, formal entities, relations, functions, the infinite set of names that can be defined in namespaces.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#AbstractResource"></see></summary>
    let AbstractResource = _prefix "AbstractResource"
    /// <summary>
    /// All Semantic Web resources that are not information resources. They include abstract, conceptual, and physical resources.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#NonInformationResource"></see></summary>
    let NonInformationResource = _prefix "NonInformationResource"
    /// <summary>
    /// Resources that are created in the social communication process. A conceptual resource does not exist if it's not in a social communication. For example: legal entities, political entities, social relations, concepts, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#ConceptualResource"></see></summary>
    let ConceptualResource = _prefix "ConceptualResource"
    /// <summary>
    /// The realization of a message encoding that 'goes on the wire' according to an interaction protocol (e.g. http) in order to resolve a Web accessible resource. Representation have neither a URL nor a URI, they are associated with the URL of the Web Resource they represent. Representation are disjoint with Web resources
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation"></see></summary>
    let WebRepresentation = _prefix "WebRepresentation"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#MediaType"></see>
    /// </summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    /// The subset of URI that identify typically analog things. In general they identify any resource but are not directly resolvable. They do not identify an accessible information resource.They act as a virtual delegate for exactly one resource, typically analog. They cause a re-direct or any other type of mechanism that makes the web server resolve another URI that is associated with a WebReource (see range of redirectTo)
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#SemanticWebURI"></see></summary>
    let SemanticWebURI = _prefix "SemanticWebURI"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isIdentifiedBy"></see>
    /// </summary>
    let isIdentifiedBy = _prefix "isIdentifiedBy"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#URI"></see>
    /// </summary>
    let URI = _prefix "URI"
    /// <summary>
    /// Redirections can be used outside the Semantic Web between just normal information resources, their domain and range says nothing about the type of resource. The only important aspect is that the reseource that is the destination of the redirection must be associated with a WebRepresentation, hence it must be a WebResource. This property can be used as top property for expressing special types of redirections e.g. TAG's 303 redirection or hash convention.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#redirectsTo"></see></summary>
    let redirectsTo = _prefix "redirectsTo"
    /// <summary>
    /// The relashionship between a URI and a resource. A URI identify only one resource, it acts as a "virtual" delegate for that resource on the Web. This is different from the refersTo relashionships. This latter holds between Resources, and it's not  functional. For example, http://www.example.com#me identifies only john, while john's homepage http://www.example.com/john.html refersTo me, the place where he works, his job, his personal interests, etc. If I want to describe John's characteristics e.g. his name, age, etc. on the Web, I will attach them to http://www.example.com#john. On the other hand, http://www.example.com/john.html identifies john's homepage, which is an information resource.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#identifies"></see></summary>
    let identifies = _prefix "identifies"
    /// <summary>
    /// The name of this datatype property previously was "hasURI", but in this ontology a URI is modelled as a class, hence I though that it's better to clarify, even in the property name that it refers to the string value of a URI.
    /// The value of the URI, a string compliant with the URI specification.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#hasURIString"></see></summary>
    let hasURIString = _prefix "hasURIString"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebClient"></see>
    /// </summary>
    let WebClient = _prefix "WebClient"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isEncodedIn"></see>
    /// </summary>
    let isEncodedIn = _prefix "isEncodedIn"
    /// <summary>
    /// InformationResources that have at least one WebRepresentation and at least a URI. For example, a WebResource containing the text of Moby Dick and its WebRepresentation encoded in HTML in English language.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebResource"></see></summary>
    let WebResource = _prefix "WebResource"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebServer"></see>
    /// </summary>
    let WebServer = _prefix "WebServer"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isResolutionOf"></see>
    /// </summary>
    let isResolutionOf = _prefix "isResolutionOf"
    /// <summary>
    /// A causal connection from a resource to the thing identiﬁed.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#accesses"></see></summary>
    let accesses = _prefix "accesses"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAccessedBy"></see>
    /// </summary>
    let isAccessedBy = _prefix "isAccessedBy"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#encodes"></see>
    /// </summary>
    let encodes = _prefix "encodes"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAbout"></see>
    /// </summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isTopicOf"></see>
    /// </summary>
    let isTopicOf = _prefix "isTopicOf"
    /// <summary>
    /// A relation between a WebServer and a WebRepresentation. It indicates that a WebServer concretely can respond to an HTTP request with a particular Web Representation.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// A relation between a WebRepresentation and a WebServer, indicating that the WebRepresentation can be obtained by e.g. an HTTP request to the WebServer.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#locatedOn"></see></summary>
    let locatedOn = _prefix "locatedOn"
    /// <summary>
    /// The relation between a resource and the information resource that is about it.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isReferencedBy"></see></summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    /// The relation between a URI and the resources it refers to.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// WebClients that have requested a URI, like in typical HTTP GET requests.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isRequestedBy"></see></summary>
    let isRequestedBy = _prefix "isRequestedBy"
    /// <summary>
    /// Expresses the notion behind of a request operation of a web client, exempliﬁed by a typical HTTP GET request.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#requests"></see></summary>
    let requests = _prefix "requests"
    /// <summary>
    /// Relates a URI to a concrete Web server, which currently is done by mapping a URI to an IP address or addresses.
    /// <see href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#resolvesTo"></see></summary>
    let resolvesTo = _prefix "resolvesTo"
