#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module irw =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/web/irw.owl#" "irw"

    /// <summary>
    ///   <para>rdfs:comment : Abstract things. They are combinatorial spaces. They cannot be located in space-time. Examples are: the infinite set of integers, real numbers, formal entities, relations, functions, the infinite set of names that can be defined in namespaces.^^xsd:string</para>
    ///   <para>rdfs:label : abstract resource^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#AbstractResource">irw:AbstractResource</a>
    /// </summary>
    let AbstractResource = _prefixId.prefix "AbstractResource"
    /// <summary>
    ///   <para>rdfs:comment : Resources that are created in the social communication process. A conceptual resource does not exist if it's not in a social communication. For example: legal entities, political entities, social relations, concepts, etc.^^xsd:string</para>
    ///   <para>rdfs:label : conceptual resource^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#ConceptualResource">irw:ConceptualResource</a>
    /// </summary>
    let ConceptualResource = _prefixId.prefix "ConceptualResource"
    /// <summary>
    ///   <para>rdfs:comment : They are *about* something, this something can be everything (rdfs:Resource, owl:Thing, ire:Entity) including AnalogResource. Their essential characteristics can be conveyed in a single message. They can be associated with a URI, and can have a WebRepresentation, in this case they are called WebResource. They have some realization, for example: the text of Moby Dick is an InformationResource, a book containing the text of Moby Dick is one of its realization. The intuition behind the class InformationResource is the same behind the class ir:InformationRealization (cloned from Dolce Ultra Lite).^^xsd:string</para>
    ///   <para>rdfs:label : information resource^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#InformationResource">irw:InformationResource</a>
    /// </summary>
    let InformationResource = _prefixId.prefix "InformationResource"
    /// <summary>
    ///   <para>rdfs:label : media type^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#MediaType">irw:MediaType</a>
    /// </summary>
    let MediaType = _prefixId.prefix "MediaType"
    /// <summary>
    ///   <para>rdfs:comment : All Semantic Web resources that are not information resources. They include abstract, conceptual, and physical resources.^^xsd:string</para>
    ///   <para>rdfs:label : non-information resources^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#NonInformationResource">irw:NonInformationResource</a>
    /// </summary>
    let NonInformationResource = _prefixId.prefix "NonInformationResource"
    /// <summary>
    ///   <para>rdfs:label : physical resource^^xsd:string</para>
    ///   <para>rdfs:comment : Something that occupies its own space and has its own mass in the real world, and can have a "virtual delegate" on the Web. For example physical people, artifacts, places, bodies, chimical substances, biological entities, etc.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#PhysicalEntityResource">irw:PhysicalEntityResource</a>
    /// </summary>
    let PhysicalEntityResource = _prefixId.prefix "PhysicalEntityResource"
    /// <summary>
    ///   <para>rdfs:label : resource^^xsd:string</para>
    ///   <para>rdfs:comment : This class is meant to express the same intuition of rdfs:Resource but it is defined here in order to have OWL-DL compaibility. In an OWL Full version of this ontology we would have this class owl:equivalentClass rdfs:Resource.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#Resource">irw:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : semantic web uri^^xsd:string</para>
    ///   <para>rdfs:comment : The subset of URI that identify typically analog things. In general they identify any resource but are not directly resolvable. They do not identify an accessible information resource.They act as a virtual delegate for exactly one resource, typically analog. They cause a re-direct or any other type of mechanism that makes the web server resolve another URI that is associated with a WebReource (see range of redirectTo)^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#SemanticWebURI">irw:SemanticWebURI</a>
    /// </summary>
    let SemanticWebURI = _prefixId.prefix "SemanticWebURI"
    /// <summary>
    ///   <para>rdfs:label : uri^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#URI">irw:URI</a>
    /// </summary>
    let URI = _prefixId.prefix "URI"
    /// <summary>
    ///   <para>rdfs:label : web client^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebClient">irw:WebClient</a>
    /// </summary>
    let WebClient = _prefixId.prefix "WebClient"
    /// <summary>
    ///   <para>rdfs:label : awww representation^^xsd:string</para>
    ///   <para>rdfs:comment : The realization of a message encoding that 'goes on the wire' according to an interaction protocol (e.g. http) in order to resolve a Web accessible resource. Representation have neither a URL nor a URI, they are associated with the URL of the Web Resource they represent. Representation are disjoint with Web resources^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation">irw:WebRepresentation</a>
    /// </summary>
    let WebRepresentation = _prefixId.prefix "WebRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : InformationResources that have at least one WebRepresentation and at least a URI. For example, a WebResource containing the text of Moby Dick and its WebRepresentation encoded in HTML in English language.^^xsd:string</para>
    ///   <para>rdfs:label : web resource^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebResource">irw:WebResource</a>
    /// </summary>
    let WebResource = _prefixId.prefix "WebResource"
    /// <summary>
    ///   <para>rdfs:label : web server^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#WebServer">irw:WebServer</a>
    /// </summary>
    let WebServer = _prefixId.prefix "WebServer"
    /// <summary>
    ///   <para>rdfs:label : accesses^^xsd:string</para>
    ///   <para>rdfs:comment : A causal connection from a resource to the thing identiﬁed.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#accesses">irw:accesses</a>
    /// </summary>
    let accesses = _prefixId.prefix "accesses"
    /// <summary>
    ///   <para>rdfs:label : encodes^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#encodes">irw:encodes</a>
    /// </summary>
    let encodes = _prefixId.prefix "encodes"
    /// <summary>
    ///   <para>rdfs:comment : The name of this datatype property previously was "hasURI", but in this ontology a URI is modelled as a class, hence I though that it's better to clarify, even in the property name that it refers to the string value of a URI.^^xsd:stringrdfs:comment : The value of the URI, a string compliant with the URI specification.^^xsd:string</para>
    ///   <para>rdfs:label : has URI string value^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#hasURIString">irw:hasURIString</a>
    /// </summary>
    let hasURIString = _prefixId.prefix "hasURIString"
    /// <summary>
    ///   <para>rdfs:comment : The relashionship between a URI and a resource. A URI identify only one resource, it acts as a "virtual" delegate for that resource on the Web. This is different from the refersTo relashionships. This latter holds between Resources, and it's not  functional. For example, http://www.example.com#me identifies only john, while john's homepage http://www.example.com/john.html refersTo me, the place where he works, his job, his personal interests, etc. If I want to describe John's characteristics e.g. his name, age, etc. on the Web, I will attach them to http://www.example.com#john. On the other hand, http://www.example.com/john.html identifies john's homepage, which is an information resource.^^xsd:string</para>
    ///   <para>rdfs:label : identifies^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#identifies">irw:identifies</a>
    /// </summary>
    let identifies = _prefixId.prefix "identifies"
    /// <summary>
    ///   <para>rdfs:label : is about^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAbout">irw:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : requests^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isAccessedBy">irw:isAccessedBy</a>
    /// </summary>
    let isAccessedBy = _prefixId.prefix "isAccessedBy"
    /// <summary>
    ///   <para>rdfs:label : encoded in^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isEncodedIn">irw:isEncodedIn</a>
    /// </summary>
    let isEncodedIn = _prefixId.prefix "isEncodedIn"
    /// <summary>
    ///   <para>rdfs:label : is identified by^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isIdentifiedBy">irw:isIdentifiedBy</a>
    /// </summary>
    let isIdentifiedBy = _prefixId.prefix "isIdentifiedBy"
    /// <summary>
    ///   <para>rdfs:label : is location of^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a WebServer and a WebRepresentation. It indicates that a WebServer concretely can respond to an HTTP request with a particular Web Representation.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isLocationOf">irw:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a resource and the information resource that is about it.^^xsd:string</para>
    ///   <para>rdfs:label : is referenced by^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isReferencedBy">irw:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>rdfs:comment : WebClients that have requested a URI, like in typical HTTP GET requests.^^xsd:string</para>
    ///   <para>rdfs:label : is requested by^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isRequestedBy">irw:isRequestedBy</a>
    /// </summary>
    let isRequestedBy = _prefixId.prefix "isRequestedBy"
    /// <summary>
    ///   <para>rdfs:label : is resolution of^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isResolutionOf">irw:isResolutionOf</a>
    /// </summary>
    let isResolutionOf = _prefixId.prefix "isResolutionOf"
    /// <summary>
    ///   <para>rdfs:label : is topic of^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#isTopicOf">irw:isTopicOf</a>
    /// </summary>
    let isTopicOf = _prefixId.prefix "isTopicOf"
    /// <summary>
    ///   <para>rdfs:label : located on^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a WebRepresentation and a WebServer, indicating that the WebRepresentation can be obtained by e.g. an HTTP request to the WebServer.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#locatedOn">irw:locatedOn</a>
    /// </summary>
    let locatedOn = _prefixId.prefix "locatedOn"
    /// <summary>
    ///   <para>rdfs:comment : Redirections can be used outside the Semantic Web between just normal information resources, their domain and range says nothing about the type of resource. The only important aspect is that the reseource that is the destination of the redirection must be associated with a WebRepresentation, hence it must be a WebResource. This property can be used as top property for expressing special types of redirections e.g. TAG's 303 redirection or hash convention.^^xsd:string</para>
    ///   <para>rdfs:label : redirects to^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#redirectsTo">irw:redirectsTo</a>
    /// </summary>
    let redirectsTo = _prefixId.prefix "redirectsTo"
    /// <summary>
    ///   <para>rdfs:label : refers to^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a URI and the resources it refers to.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#refersTo">irw:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:comment : Expresses the notion behind of a request operation of a web client, exempliﬁed by a typical HTTP GET request.^^xsd:string</para>
    ///   <para>rdfs:label : requests^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#requests">irw:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:label : resolves to^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a URI to a concrete Web server, which currently is done by mapping a URI to an IP address or addresses.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/web/irw.owl#resolvesTo">irw:resolvesTo</a>
    /// </summary>
    let resolvesTo = _prefixId.prefix "resolvesTo"
