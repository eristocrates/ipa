#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vaem =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/vaem#" "vaem"

    /// <summary>
    ///   <para>dcterms:description : Aspect is used to distinguish among sets of features of a domain or subject area. The term is borrowed from "aspect-oriented" programming, where it is used to separate concerns. An ontology may be characterized by this dimension so as to parition features that are orthogonal. For example,  in a systems ontology there may be aspects for "structure", "function", "behavior" and "interface" or "interoperability". A viewpoint can be distinguished by "aspects". For example the "information viewpoint" of an application can be partitioned into separate graphs for the "security", "operational" and"data retention" aspects.^^xsd:string</para>
    ///   <para>rdfs:label : Aspect Dimension^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Aspect">vaem:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    let CatalogEntry = _prefixId.prefix "CatalogEntry"
    let CollectionGraph = _prefixId.prefix "CollectionGraph"
    let ConstraintsGraph = _prefixId.prefix "ConstraintsGraph"
    let ControllersGraph = _prefixId.prefix "ControllersGraph"
    let CurationGraph = _prefixId.prefix "CurationGraph"
    let DataGraph = _prefixId.prefix "DataGraph"
    /// <summary>
    ///   <para>dcterms:description : A dimension identifies a separation of concens that serves as a way to categorize an ontology graph. In VAEM,  the notion of "Dimension" is partitioned into "Aspect", "Discipline", "Domain" and "Viewpoint".^^xsd:string</para>
    ///   <para>rdfs:label : Domain^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Dimension">vaem:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>dcterms:description : A discipline is a specific area of work or study. Examples of disciplines in the engineering domain are electrical engineering, mechanical engineering and, in the financial domain, risk assessment, investment analysis.  In VAEM, discipline is used as a dimension for characterizing an ontology graph^^xsd:string</para>
    ///   <para>rdfs:label : Discipline Dimension^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Discipline">vaem:Discipline</a>
    /// </summary>
    let Discipline = _prefixId.prefix "Discipline"
    let DocumentationGraph = _prefixId.prefix "DocumentationGraph"
    /// <summary>
    ///   <para>dcterms:description : A domain is a subject area of interest. Examples of domains are "enterprise", "process", "organization" and "system". In VAEM, "Domain" is used as a dimension for characterizing an ontology graph^^xsd:string</para>
    ///   <para>rdfs:label : Domain Dimension^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Domain">vaem:Domain</a>
    /// </summary>
    let Domain = _prefixId.prefix "Domain"
    let FunctionsGraph = _prefixId.prefix "FunctionsGraph"
    let GMD_VAEM = _prefixId.prefix "GMD_VAEM"
    /// <summary>
    ///   <para>dcterms:description : "vaem:GraphMetaData" defines basic metadata for the registration and publishing of a graph.  For specificaiton of governance the vocabulary "VOAG" may be used.^^xsd:string</para>
    ///   <para>rdfs:label : Graph Metadata^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#GraphMetaData">vaem:GraphMetaData</a>
    /// </summary>
    let GraphMetaData = _prefixId.prefix "GraphMetaData"
    /// <summary>
    ///   <para>dcterms:description : GraphRole is used to characterize how a graph of resources participates in an ontology set.  For example, a graph can be a schema, vocabulary, dataset, script, or ruleset^^xsd:string</para>
    ///   <para>rdfs:label : Graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#GraphRole">vaem:GraphRole</a>
    /// </summary>
    let GraphRole = _prefixId.prefix "GraphRole"
    let LinkSetGraph = _prefixId.prefix "LinkSetGraph"
    let MappingGraph = _prefixId.prefix "MappingGraph"
    /// <summary>
    ///   <para>dcterms:description : A "Party" is a generalization for an actor that may be realized as a person, organizaiton or named role.^^xsd:string</para>
    ///   <para>rdfs:label : Party^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Party">vaem:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    let ProxyGraph = _prefixId.prefix "ProxyGraph"
    let RulesGraph = _prefixId.prefix "RulesGraph"
    let SchemaGraph = _prefixId.prefix "SchemaGraph"
    let ScriptGraph = _prefixId.prefix "ScriptGraph"
    let TopQuadrant = _prefixId.prefix "TopQuadrant"
    let TransformsGraph = _prefixId.prefix "TransformsGraph"
    let ViewGraph = _prefixId.prefix "ViewGraph"
    /// <summary>
    ///   <para>dcterms:description : Viewpoint is used to denote how a set of resources, or an individual resource, is relevant to a context of use. The term "viewpoint" is adopted from the ISO RM-ODP specifications and its more recent use in enterprise architecture descriptions. The RM-ODP introducesd the concept of viewpoint to describe a system from a particular set of concerns. RM-ODP defines five viewpoints. Together they provide a complete description of a system: enterprise viewpoint, information viewpoint, computational viewpoint, engineering viewpoint, and technology viewpoint.  In VAEM, "Viewpoint" is used as a dimension for characterizing an ontology graph.  The viewpoints of an ontology may not always correpsond directly to those of a system but the idea of describing a subject area of interest from distinct viewpoints is still relevant. A viewpoint can be further distinguished by "aspects". For example the "information viewpoint" of an application can be partitioned into separate graphs for the "security", "operational" and"data retention" aspects.^^xsd:string</para>
    ///   <para>rdfs:label : ViewpointDimension^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Viewpoint">vaem:Viewpoint</a>
    /// </summary>
    let Viewpoint = _prefixId.prefix "Viewpoint"
    let VocabularyGraph = _prefixId.prefix "VocabularyGraph"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:abbreviation" provides a common way to define a commonly used abbreviation on a resource^^xsd:string</para>
    ///   <para>rdfs:label : abbreviation^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#abbreviation">vaem:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:acronym" provides a common way to define a commonly used abbreviation on a resource^^xsd:string</para>
    ///   <para>rdfs:label : acronym^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#acronym">vaem:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>dcterms:description : An annotation property that can be freely used on any kind of resource. The range of the property is "xsd:string"^^xsd:string</para>
    ///   <para>rdfs:label : definition^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#comment">vaem:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:date" is intended for general use as the name implies.  The range of the property is set as "vaem:dateUnion" so as to allow a value to have a number of forms from a  year only to a full timestamp. The property is also the parent of all dates so that queries can be made for any date on an ontology^^xsd:string</para>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#date">vaem:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#description">vaem:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:filePrefix" is for specifying a preferred file prefix for a graph. For example a schema graph may be given the file prefix "SCHEMA" followed by an underscore "_".^^xsd:string</para>
    ///   <para>rdfs:label : file prefix^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#filePrefix">vaem:filePrefix</a>
    /// </summary>
    let filePrefix = _prefixId.prefix "filePrefix"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasAspect" is used to distinguish among sets of features of a domain or subject area. The term is borrowed from "aspect-oriented" programming, where it is used to separate concerns. An ontology may be characterized by this dimension so as to parition features that are orthogonal. For example,  in a systems ontology we can distinguish aspects for "structure", "function", "behavior" and "interface".  The property is an "rdf:Property" to allow both scalar and object values^^xsd:string</para>
    ///   <para>rdfs:label : has aspect^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasAspect">vaem:hasAspect</a>
    /// </summary>
    let hasAspect = _prefixId.prefix "hasAspect"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasDimension" is used categorize an ontology.  In VAEM, the property is used to characterize an ontology graph.^^xsd:string</para>
    ///   <para>rdfs:label : has dimension^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasDimension">vaem:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasDiscipline" is used to indicate relevance of a set of resources, or a resource itself, to a specific discipline of work or study. Examples of disciplines in the engineering domain are electrical engineering, mechanical engineering and, in the financial domain, risk assessment, investment analysis.  In VAEM, the property is used as a dimension for characterizing an ontology graph.  The property is an "rdf:Property" to allow both scalar and object values^^xsd:string</para>
    ///   <para>rdfs:label : has discipline^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasDiscipline">vaem:hasDiscipline</a>
    /// </summary>
    let hasDiscipline = _prefixId.prefix "hasDiscipline"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasDomain" is used to specify how  a set of resources, or an individual resource is grounded in a domain, that is, a subject area of interest. Examples of domains are "enterprise", "process", "organization" and "system". In VAEM, the property is used as a dimension for characterizing an ontology graph. The property is an "rdf:Property" to allow both scalar and object values^^xsd:string</para>
    ///   <para>rdfs:label : has domain^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasDomain">vaem:hasDomain</a>
    /// </summary>
    let hasDomain = _prefixId.prefix "hasDomain"
    let hasGraphMetadata = _prefixId.prefix "hasGraphMetadata"
    /// <summary>
    ///   <para>dcterms:description : The property "lms:hasGraphRole" is used to characterize how a resource participates in an ontology set.  The property is used to specify the role that a graph plays, for example, an ontology graph can be a schema, vocabulary, dataset, script, or ruleset^^xsd:string</para>
    ///   <para>rdfs:label : has graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasGraphRole">vaem:hasGraphRole</a>
    /// </summary>
    let hasGraphRole = _prefixId.prefix "hasGraphRole"
    /// <summary>
    ///   <para>dcterms:description : The property "vaemhasIdentifier" is intended for general use as a means to specifiy a unique reference to something. This is an object property that is a sub-property of "vame:id"^^xsd:string</para>
    ///   <para>rdfs:label : has identifier^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasIdentifier">vaem:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasLicenseType" points to an entry in the VOAG ontology for licenses^^xsd:string</para>
    ///   <para>rdfs:label : has license type</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasLicenseType">vaem:hasLicenseType</a>
    /// </summary>
    let hasLicenseType = _prefixId.prefix "hasLicenseType"
    /// <summary>
    ///   <para>dcterms:description : The property "hasMetadata" is used to reference a metadata information structure.^^xsd:string</para>
    ///   <para>rdfs:label : has metadata^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasMetadata">vaem:hasMetadata</a>
    /// </summary>
    let hasMetadata = _prefixId.prefix "hasMetadata"
    /// <summary>
    ///   <para>rdfs:label : has owner^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasOwner">vaem:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>dcterms:description : A property that is used to refer to a "Steward", that is, the party or role that is responsible for maintaining an asset, in the case of VAEM, an ontology graph.^^xsd:string</para>
    ///   <para>rdfs:label : has steward^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasSteward">vaem:hasSteward</a>
    /// </summary>
    let hasSteward = _prefixId.prefix "hasSteward"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:hasViewpoint" is used to denote how a set of resources, or an individual resource, is relevant to a context of use. The term "viewpoint" is adopted from the ISO RM-ODP specifications and its more recent use in enterprise architecture descriptions.  In VAEM, the property is used as a dimension for characterizing an ontology graph.  The property is an "rdf:Property" to allow both scalar and object values^^xsd:string</para>
    ///   <para>rdfs:label : has viewpoint^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasViewpoint">vaem:hasViewpoint</a>
    /// </summary>
    let hasViewpoint = _prefixId.prefix "hasViewpoint"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:id" is intended for general use as a means to specifiy an identifier. The type of this property is intentionally set to "rdf:Property" so that use of the property can allow both object and scaler values.  For this reason, the property is rangeless^^xsd:string</para>
    ///   <para>rdfs:label : id^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#id">vaem:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    let idString = _prefixId.prefix "idString"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:intent" is used to outline  a statement of purpose. This typically expresses one or more desired outcomes^^xsd:string</para>
    ///   <para>rdfs:label : intent^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#intent">vaem:intent</a>
    /// </summary>
    let intent = _prefixId.prefix "intent"
    /// <summary>
    ///   <para>dcterms:description : An annotation used to reference a graph that elaborates (adds properties and axioms to) a resource^^xsd:string</para>
    ///   <para>rdfs:label : isDefinedBy^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#isElaboratedIn">vaem:isElaboratedIn</a>
    /// </summary>
    let isElaboratedIn = _prefixId.prefix "isElaboratedIn"
    let lastUpdated = _prefixId.prefix "lastUpdated"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:latestPublishedVersion"is a URL to documentation for the latest version of a graph.^^xsd:string</para>
    ///   <para>rdfs:label : latest published version^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#latestPublishedVersion">vaem:latestPublishedVersion</a>
    /// </summary>
    let latestPublishedVersion = _prefixId.prefix "latestPublishedVersion"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:logo" is a reference to an image that is used for publishing the ontology"^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#logo">vaem:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:name" is intended for general use. In many cases "rdfs:label" could be used give names to resources. In the case where compliance with a specific naming rule is needed,  "vaem:name" allows  a resource to carry a name that is used in more specific contexts.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#name">vaem:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:namespace" is the onotlogy URI with which a graph is primarily associated. The intent is to allow multiple graphs to define statements for resources in the same Ontology namespace. For example, a foundation level graph with the base URI of "http://www.somesite.com/1.0/schema/OurOntology"  may define general  concepts for "OurOntology". Another graph with the base URI "http://www.somesite.com/1.0/schema/level2/OurOntology"  may add more specific details to the same "OurOntology". Each of these two graphs would carry the same value for "vaem:namespace", that is, "http://www.somesite.com/schema/OurOntology".    In other words, an ontology URI is the URI associated with the resources of a controlled namespace. On the other hand the graph URIs (the base URIs) identify the graphs that hold resources that make up an ontology^^xsd:string</para>
    ///   <para>rdfs:label : namespace^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespace">vaem:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:namespacePrefix" specifes a short handle or label for the URI of an Ontology.  Multiple graphs can define statements for resources in the same Ontololgy namespace. For example, a foundation level graph with the base URI of "http://www.somesite.com/1.0/schema/OurOntology"  may define general  concepts for "OurOntology". Another graph with the base URI "http://www.somesite.com/1.0/schema/level2/OurOntology"  may add more specific details to the same "OurOntology". Each of these two graphs would carry the same value for "vaem:namespacePrefix", for this example, perhaps, "ourOntology"^^xsd:string</para>
    ///   <para>rdfs:label : namespace prefix^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespacePrefix">vaem:namespacePrefix</a>
    /// </summary>
    let namespacePrefix = _prefixId.prefix "namespacePrefix"
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#owner">vaem:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    let owningParty = _prefixId.prefix "owningParty"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:previousPublishedVersion"is a URL to documentation for the previous version of a graph.^^xsd:string</para>
    ///   <para>rdfs:label : previous published version^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#previousPublishedVersion">vaem:previousPublishedVersion</a>
    /// </summary>
    let previousPublishedVersion = _prefixId.prefix "previousPublishedVersion"
    /// <summary>
    ///   <para>dcterms:description : A description of a justification for some other assertion or value^^xsd:string</para>
    ///   <para>rdfs:label : rationale^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#rationale">vaem:rationale</a>
    /// </summary>
    let rationale = _prefixId.prefix "rationale"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:rdfxmlFileURL" is used to provide a link to the location of the ontology's RDF/XML file^^xsd:string</para>
    ///   <para>rdfs:label : RDF/XML file URL^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#rdfxmlFileURL">vaem:rdfxmlFileURL</a>
    /// </summary>
    let rdfxmlFileURL = _prefixId.prefix "rdfxmlFileURL"
    /// <summary>
    ///   <para>dcterms:description : To express how statements in a model can be reifiable, this property is used to explicitly associate a property with a user-defined sub-class of "rdf:Statement". A recommended way of using this is to declare the properties that share the same reification constructs as sub-properties of a parent property that carries the "vaem:reifiableBy" property. The parent property should be of type "rdf:Property" so that it can have both datatype and object properties as sub-properties. By this means use and transformations of a model can be understood through a fully specified metamodel. "vaem:reifiableBy" is rangeless in order to comply with OWL DL semantics. Its range would have been rdfs:Class in order to refer to "rdf:Statement" sub-classes^^xsd:string</para>
    ///   <para>rdfs:label : reifiable by^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#reifiableBy">vaem:reifiableBy</a>
    /// </summary>
    let reifiableBy = _prefixId.prefix "reifiableBy"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:releaseDate" is intended for general use as the name implies.  The range of the property is set as "vaem:dateUnion" so as to allow a value to have a number of forms from a  year only to a full timestamp^^xsd:string</para>
    ///   <para>rdfs:label : release date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#releaseDate">vaem:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:revision" is a property intended for general use as the name implies.^^xsd:string</para>
    ///   <para>rdfs:label : revision^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#revision">vaem:revision</a>
    /// </summary>
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:specificity" is intended to specify the level of detail of an ontology.  The values that can be set for this property are restriced to an integer from 1 to 5. An ontology at level 1 has concepts of more general applicability than one at level 5. By having graphs at different levels of specificity it is possible to support greater modularity for selective imports^^xsd:string</para>
    ///   <para>rdfs:label : specificity^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#specificity">vaem:specificity</a>
    /// </summary>
    let specificity = _prefixId.prefix "specificity"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#title">vaem:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>dcterms:description : As it name implies, a way to attach an annotation about a "todo" task^^xsd:string</para>
    ///   <para>rdfs:label : todo^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#todo">vaem:todo</a>
    /// </summary>
    let todo = _prefixId.prefix "todo"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:turtleFileURL" is used to provide a link to the location of the ontology's turtle file^^xsd:string</para>
    ///   <para>rdfs:label : turtle file URL^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#turtleFileURL">vaem:turtleFileURL</a>
    /// </summary>
    let turtleFileURL = _prefixId.prefix "turtleFileURL"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:url" is intended for general use as the name implies.  The range of the property is set as an XSD URI^^xsd:string</para>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#url">vaem:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:usesNonImportedResource" is used to express dependencies on resources from graphs that are not imported^^xsd:string</para>
    ///   <para>rdfs:label : uses non-imported resource^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource">vaem:usesNonImportedResource</a>
    /// </summary>
    let usesNonImportedResource = _prefixId.prefix "usesNonImportedResource"
    /// <summary>
    ///   <para>dcterms:description : The property "vaem:withAttributionTo" is an annotation property that is either used to hold either a string or a reference to an instance of "voag:Attribution", from the VOAG ontology^^xsd:string</para>
    ///   <para>rdfs:label : with attribution to^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#withAttributionTo">vaem:withAttributionTo</a>
    /// </summary>
    let withAttributionTo = _prefixId.prefix "withAttributionTo"
