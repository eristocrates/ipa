#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module edm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.europeana.eu/schemas/edm/" "edm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:scopeNote : Rationale: This class is a domain of edm:wasPresentAt^^xsd:string</para>
    ///   <para>skos:example : Leonardo da Vinci, the British Museum, W3C^^xsd:string</para>
    ///   <para>skos:definition : This class comprises people, either individually or in groups, who have the
    /// potential to perform intentional actions for which they can be held responsible.^^xsd:string</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/Agent">edm:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>skos:example : The 56th issue of "Le Temps" is a (different) Cultural Heritage Object represented in Europeana by another EuropeanaAggregation instanceskos:example : The painting Mona Lisa is a Cultural Heritage Object represented in Europeana by one EuropeanaAggregation instanceskos:example : The journal "Le Temps" is a Cultural Heritage Object represented in Europeana by one EuropeanaAggregation instance</para>
    ///   <para>skos:note : An instance of EuropeanaAggregation is created at ingestion time for each different Cultural Heritage Object recognized by Europeana. Such instance is associated to the Cultural Heritage Object that it is about, by the property edm:aggregatedCHO</para>
    ///   <para>skos:scopeNote : Rationale: This class is used in Europeana to gather in a single conceptual unit all the information about a Cultural Heritage Object, necessary for all operations on these objects.skos:scopeNote : Obligation and Occurence: The relation between the Cultural Heritage Objects represented in Europeana and the instances of the class EuropeanaAggregation is one-to-one, in the data maintained by Europeana: every Cultural Heritage Object is represented by an instance of EuropeanaAggregation, and every instance of EuropeanaAggregation represent a Cultural Heritage Object.</para>
    ///   <para>skos:definition : The set of resources related to a single Cultural Heritage Object that
    /// collectively represent that object in Europeana. Such set consists of: all
    /// descriptions about the object that Europeana collects from (possibly different) content providers, including thumbnails and other forms of abstractions, as well as of the description of the object Europeana builds.^^xsd:string</para>
    ///   <para>rdfs:label : Europeana Aggregation^^xsd:string</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/EuropeanaAggregation">edm:EuropeanaAggregation</a>
    /// </summary>
    let EuropeanaAggregation = _prefixId.prefix "EuropeanaAggregation"
    /// <summary>
    ///   <para>skos:scopeNote : Rationale: This class is used to tag objects that are the result of activity of Europeana, and, as such, objects on which Europeana holds rights</para>
    ///   <para>skos:example : Any content created by the users through the service made available by Europeana for that purposeskos:example : An annotation created by a user through the Europeana portalskos:example : Any instance of the class EuropeanaAggregation</para>
    ///   <para>skos:definition : Any object that is the result of Europeana’s activities</para>
    ///   <para>rdfs:label : Europeana Object</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/EuropeanaObject">edm:EuropeanaObject</a>
    /// </summary>
    let EuropeanaObject = _prefixId.prefix "EuropeanaObject"
    /// <summary>
    ///   <para>skos:example : the change of custody of Mona Lisaskos:example : the act of painting Mona Lisaskos:example : the 2nd World War</para>
    ///   <para>skos:note : Events are identified either by the content provider or by Europeana enrichment at ingestion time</para>
    ///   <para>skos:scopeNote : Rationale:This class is a domain of edm:happenedAt and the domain of edm:occurredAt</para>
    ///   <para>skos:definition : An event is a change "of states in cultural, social or physical systems,
    ///  regardless of scale, brought about by a series or group of coherent physical,
    /// cultural, technological or legal phenomena" (E5 Event in CIDOC CRM) or a "set of coherent phenomena or cultural manifestations bounded in time and  space" (E4 Period in CIDOC CRM)</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/Event">edm:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:definition : An information resource is a resource whose essential characteristics can be conveyed in a single message. It can be associated with a URI, it can have a representation, for example: a text is an InformationResource.</para>
    ///   <para>rdfs:label : Information Resource</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/InformationResource">edm:InformationResource</a>
    /// </summary>
    let InformationResource = _prefixId.prefix "InformationResource"
    /// <summary>
    ///   <para>skos:definition : All resources that are not information resources.</para>
    ///   <para>rdfs:label : Non-Information Resource</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/NonInformationResource">edm:NonInformationResource</a>
    /// </summary>
    let NonInformationResource = _prefixId.prefix "NonInformationResource"
    /// <summary>
    ///   <para>skos:definition : A persistent physical item such as a painting, a building, a book or a stone.
    /// Persons are not items. This class represents Cultural Heritage Objects known to Europeana to be physical things (such as Mona Lisa) as well as all physical things Europeana refers to in the descriptions of Cultural Heritage Objects (such as the Rosetta Stone).</para>
    ///   <para>rdfs:label : Physical Thing</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/PhysicalThing">edm:PhysicalThing</a>
    /// </summary>
    let PhysicalThing = _prefixId.prefix "PhysicalThing"
    /// <summary>
    ///   <para>skos:definition : An "extent in space, in particular on the surface of the earth, in the pure sense of physics: independent from temporal phenomena and matter" (CIDOC CRM)</para>
    ///   <para>rdfs:label : Place</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/Place">edm:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>skos:scopeNote : Rationale: This class is the range of edm:aggregatedCHO. A resource of type ProvidedCHO can be the subject of statements using edm:isRelatedTo or any more specific property.</para>
    ///   <para>skos:example : Mona Lisa, Winged Victory of Samothrace</para>
    ///   <para>skos:note : This class has been mostly motivated by the need to assign a type to the “central node” in the EDM pattern, during the ingestion process, related to the XML expression of EDM at that stage. It was especially intended to fit the cases where edm:PhysicalThing  cannot be used as the type of the resource standing for the real-world object (independently of any specific data contributor perspective).</para>
    ///   <para>skos:definition : This class comprises the Cultural Heritage objects that Europeana collects descriptions about.</para>
    ///   <para>rdfs:label : Provided CHO</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/ProvidedCHO">edm:ProvidedCHO</a>
    /// </summary>
    let ProvidedCHO = _prefixId.prefix "ProvidedCHO"
    /// <summary>
    ///   <para>skos:definition : The class of "abstract temporal extents, in the sense of Galilean physics,
    ///  having a beginning, an end and a duration" (CIDOC CRM)</para>
    ///   <para>rdfs:label : Time Span</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/TimeSpan">edm:TimeSpan</a>
    /// </summary>
    let TimeSpan = _prefixId.prefix "TimeSpan"
    /// <summary>
    ///   <para>skos:definition : Information Resources that have at least one Web Representation and at least
    /// a URI.</para>
    ///   <para>rdfs:label : Web Resource</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/WebResource">edm:WebResource</a>
    /// </summary>
    let WebResource = _prefixId.prefix "WebResource"
    /// <summary>
    ///   <para>skos:definition : This property associates an ORE aggregation with the Cultural Heritage
    /// Object(s) (CHO for short) it is about.</para>
    ///   <para>rdfs:label : Aggregated Cultural Heritage Object</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/aggregatedCHO">edm:aggregatedCHO</a>
    /// </summary>
    let aggregatedCHO = _prefixId.prefix "aggregatedCHO"
    /// <summary>
    ///   <para>skos:definition : This property denotes the start date of a period of time.</para>
    ///   <para>rdfs:label : Begin</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/begin">edm:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/country">edm:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>skos:definition : The geographic location and/or name of the repository, building, site, or other entity whose boundaries presently include the resource.</para>
    ///   <para>rdfs:label : Current Location</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/currentLocation">edm:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>skos:definition : This element is specifically included to allow the name of the organisation who supplies data to Europeana indirectly via an aggregator to be recorded and displayed in the portal. Aggregator names are recorded in edm:provider. If an organisation provides data directly to Europeana (i.e. not via an aggregator) the values in edm:dataProvider and edm:provider will be the same. Organisation names should be provided as an ordinary text string until the Europeana Authority File for Organisations has been established. At that point providers will be able to send an identifier from the file instead of a text string. The name provided should be the preferred form of the name in the language the provider chooses as the default language for display in the portal. Countries with multiple languages may prefer to concatenate the name in more than one language (See the example below.) Note: Europeana Data Provider is not necessarily the institution where the physical object is located.</para>
    ///   <para>rdfs:label : Europeana Data Provider</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/dataProvider">edm:dataProvider</a>
    /// </summary>
    let dataProvider = _prefixId.prefix "dataProvider"
    /// <summary>
    ///   <para>skos:definition : This property denotes the end date of a period of time.</para>
    ///   <para>rdfs:label : End</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/end">edm:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>skos:definition : This property associates an event with the place at which the event
    /// happened.</para>
    ///   <para>rdfs:label : Happened At</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/happenedAt">edm:happenedAt</a>
    /// </summary>
    let happenedAt = _prefixId.prefix "happenedAt"
    /// <summary>
    ///   <para>skos:definition : edm:hasMet relates a resource with the objects or phenomena that have happened to or have happened together with the resource under consideration. We can abstractly think of history and the present as a series of “meetings” between people and other things in space-time. Therefore we name this relationship as the things the object “has met” in the course of its existence. These meetings are events in the proper sense, in which other people and things participate in any role.</para>
    ///   <para>rdfs:label : Has Met</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/hasMet">edm:hasMet</a>
    /// </summary>
    let hasMet = _prefixId.prefix "hasMet"
    /// <summary>
    ///   <para>skos:definition : This property relates a resource with the concepts it belongs to in a suitable
    /// type system such as MIME or any thesaurus that captures categories of objects in a given field (e.g., the “Objects” facet in Getty’s Art and Architecture Thesaurus). It does not capture aboutness.</para>
    ///   <para>rdfs:label : Has Type</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/hasType">edm:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>skos:definition : This property relates a ORE aggregation about a CHO with a web resource
    /// providing a view of that CHO. Examples of view are: a thumbnail, a textual
    /// abstract and a table of contents. The ORE aggregation may be a Europeana
    /// Aggregation, in which case the view is an object owned by Europeana (i.e., an instance of edm:EuropeanaObject) or an aggregation contributed by a content provider. In order to capture both these cases, the domain of edm:hasView is ore:Aggregation and its range is edm:WebResource</para>
    ///   <para>rdfs:label : Has View</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/hasView">edm:hasView</a>
    /// </summary>
    let hasView = _prefixId.prefix "hasView"
    /// <summary>
    ///   <para>skos:definition : This property captures the use of some resource to add value to another
    /// resource. Such resources may be nested, such as performing a theater play text, and then recording the performance, or creating an artful edition of a collection of poems or just aggregating various poems in an anthology. There may be no single part that contains ultimately the incorporated object, which may be dispersed in the presentation. Therefore, incorporated resources do in general not form proper parts. Incorporated resources are not part of the same resource, but are taken from other resources, and have an independent history. Therefore edm:incorporates is not a sub-property of dcterm:hasPart.</para>
    ///   <para>rdfs:label : Incorporates</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/incorporates">edm:incorporates</a>
    /// </summary>
    let incorporates = _prefixId.prefix "incorporates"
    /// <summary>
    ///   <para>skos:definition : This property relates an annotation (a Europeana object) with the resource
    /// that it annotates.</para>
    ///   <para>rdfs:label : Is Annotation Of</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isAnnotationOf">edm:isAnnotationOf</a>
    /// </summary>
    let isAnnotationOf = _prefixId.prefix "isAnnotationOf"
    /// <summary>
    ///   <para>skos:definition : This property captures a narrower notion of derivation than edm:isSimilarTo, in the sense that it relates a resource to another one, obtained by reworking, reducing, expanding, parts or the whole contents of the former, and possibly adding some minor parts. Versions have an even narrower meaning, in that it requires common identity between the related resources. Translations, summaries, abstractions etc. do not qualify as versions, but do qualify as derivatives.</para>
    ///   <para>rdfs:label : Is Derivative Of</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isDerivativeOf">edm:isDerivativeOf</a>
    /// </summary>
    let isDerivativeOf = _prefixId.prefix "isDerivativeOf"
    /// <summary>
    ///   <para>skos:definition : edm:isNextInSequence relates two resources S and R that are ordered parts of the same resource A, and such that R comes immediately after R in the order created by their being parts of S.</para>
    ///   <para>rdfs:label : Is Next In Sequence Of</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isNextInSequence">edm:isNextInSequence</a>
    /// </summary>
    let isNextInSequence = _prefixId.prefix "isNextInSequence"
    /// <summary>
    ///   <para>skos:definition : edm:isRelatedTo is the most general contextual property in EDM. Contextual
    /// properties have typically to do either with the things that have happened to or together with the object under consideration, or what the object refers to by its shape, form or features in a figural or encoded form. For sake of simplicity, we include in the contextual relationships also the scholarly classification, which may have either to do with the role and cultural connections of the object in the past, or its kind of structure, substance or contents as it can be verified at present.</para>
    ///   <para>rdfs:label : Is Related To</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isRelatedTo">edm:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>skos:definition : This property associates an information resource to the resource (if any) that it represents</para>
    ///   <para>rdfs:label : Is Representation Of</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isRepresentationOf">edm:isRepresentationOf</a>
    /// </summary>
    let isRepresentationOf = _prefixId.prefix "isRepresentationOf"
    /// <summary>
    ///   <para>skos:definition : An unambiguous URL reference to the digital object on the provider’s web site in its full information context.</para>
    ///   <para>rdfs:label : Is Shown At</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isShownAt">edm:isShownAt</a>
    /// </summary>
    let isShownAt = _prefixId.prefix "isShownAt"
    /// <summary>
    ///   <para>skos:definition : An unambiguous URL reference to the digital object on the provider’s web site in the best available resolution/quality.</para>
    ///   <para>rdfs:label : Is Shown By</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isShownBy">edm:isShownBy</a>
    /// </summary>
    let isShownBy = _prefixId.prefix "isShownBy"
    /// <summary>
    ///   <para>skos:definition : The most generic derivation property, covering also the case of questionable derivation. Is Similar To asserts that parts of the contents of one resource exhibit common features with respect to ideas, shapes, structures, colors, words, plots, topics with the contents of the related resource. Those common features may be attributed to a common origin or influence (in particular for derivation), but also to more generic cultural or psychological factors.</para>
    ///   <para>rdfs:label : Is Similar To</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isSimilarTo">edm:isSimilarTo</a>
    /// </summary>
    let isSimilarTo = _prefixId.prefix "isSimilarTo"
    /// <summary>
    ///   <para>skos:definition : This property captures the relation between the continuation of a resource and that resource. This applies to a story, a serial, a journal etc. No content of the successor resource is identical or has a similar form with that of the precursor. The similarity is only in the context, subjects and figures of a plot. Successors typically form part of a common whole – such as a trilogy, a journal, etc.</para>
    ///   <para>rdfs:label : Is Successor Of</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/isSuccessorOf">edm:isSuccessorOf</a>
    /// </summary>
    let isSuccessorOf = _prefixId.prefix "isSuccessorOf"
    /// <summary>
    ///   <para>skos:definition : This property captures the relation between an aggregation representing a
    /// Cultural Heritage Object and the Web Resource representing that Object on
    /// the provider’s web site.</para>
    ///   <para>rdfs:label : Landing Page</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/landingPage">edm:landingPage</a>
    /// </summary>
    let landingPage = _prefixId.prefix "landingPage"
    /// <summary>
    ///   <para>rdfs:comment : The recommended best practice is to use a controlled vocabulary such as
    /// RFC 4646 (http://www.rfc-archive.org/getrfc.php?rfc=4646) which, in
    /// conjunction with ISO 639, defines two- and three-letter primary language tags. Either a coded value or text string can be represented here.</para>
    ///   <para>skos:definition : A language assigned to the resource with reference to the Provider.</para>
    ///   <para>rdfs:label : Europeana Language</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/language">edm:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>skos:definition : The URL of a thumbnail representing the digital object or, if there is no such
    /// thumbnail, the URL of the digital object in the best resolution available on the
    /// web site of the data provider from which a thumbnail could be generated. This will often be the same URL as given in edm:isShownBy.</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/object">edm:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>skos:definition : This property associates an event to the smallest known time span that
    /// overlaps with the occurrence of that event</para>
    ///   <para>rdfs:label : Occured At</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/occurredAt">edm:occurredAt</a>
    /// </summary>
    let occurredAt = _prefixId.prefix "occurredAt"
    /// <summary>
    ///   <para>skos:definition : The URL of a thumbnail representing the digital object, generated by Europeana.</para>
    ///   <para>rdfs:label : Preview</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/preview">edm:preview</a>
    /// </summary>
    let preview = _prefixId.prefix "preview"
    /// <summary>
    ///   <para>skos:definition : Name of the organization that delivers data to Europeana</para>
    ///   <para>rdfs:label : Europeana Provider</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/provider">edm:provider</a>
    /// </summary>
    let provider = _prefixId.prefix "provider"
    /// <summary>
    ///   <para>skos:definition : This property describes a relation between a physical thing and the information resource that is contained in it, visible at it or otherwise carried by it, if applicable.</para>
    ///   <para>rdfs:label : Realizes</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/realizes">edm:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>skos:definition : Information about copyright of the digital object as specified by isShownBy
    /// and isShownAt</para>
    ///   <para>rdfs:label : Europeana Rights</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/rights">edm:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>skos:definition : The Europeana material type of the resource</para>
    ///   <para>rdfs:label : Europeana Type</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/type">edm:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>skos:definition : This element is used to identify user generated content (also called user created content).  It should be applied to all digitised or born digital content contributed by the general public and collected by Europeana through a crowdsourcing initiative or project.</para>
    ///   <para>rdfs:label : UGC</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/ugc">edm:ugc</a>
    /// </summary>
    let ugc = _prefixId.prefix "ugc"
    /// <summary>
    ///   <para>skos:definition : This is a container element which includes all relevant information that
    /// otherwise cannot be mapped to another element in the ESE.</para>
    ///   <para>rdfs:label : Unstored</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/unstored">edm:unstored</a>
    /// </summary>
    let unstored = _prefixId.prefix "unstored"
    /// <summary>
    ///   <para>skos:definition : This is a tag created by a user through the Europeana interface.</para>
    ///   <para>rdfs:label : Europeana URI</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/uri">edm:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>skos:definition : This is a tag created by a user through the Europeana interface.</para>
    ///   <para>rdfs:label : User Tag</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/userTag">edm:userTag</a>
    /// </summary>
    let userTag = _prefixId.prefix "userTag"
    /// <summary>
    ///   <para>skos:definition : This property associates the people, things or information resources with an event at which they were present</para>
    ///   <para>rdfs:label : Was Present At</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/wasPresentAt">edm:wasPresentAt</a>
    /// </summary>
    let wasPresentAt = _prefixId.prefix "wasPresentAt"
    /// <summary>
    ///   <para>skos:definition : A point of time associated with an event in the life of the original analog or
    /// born digital object.</para>
    ///   <para>rdfs:label : Europeana Year</para>
    ///   <a href="http://www.europeana.eu/schemas/edm/year">edm:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
