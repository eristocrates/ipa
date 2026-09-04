#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vaem =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/vaem#" "vaem"

    let AnnotationsGraph = _prefixId.prefix "AnnotationsGraph"
    /// <summary>
    ///   <para>dce:description : A mininal treatment of attribution. This serves as a placeholder class for voag:Attribution.^^xsd:string</para>
    ///   <para>rdfs:label : Attribution^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Attribution">vaem:Attribution</a>
    /// </summary>
    let Attribution = _prefixId.prefix "Attribution"
    let BridgeGraph = _prefixId.prefix "BridgeGraph"
    /// <summary>
    ///   <para>dce:description : VAEM Governed Object class is a placeholder for concepts that are fully defined by the voag:GovernedObject concept hierarchy for building a catalog of ontologies and graphs.^^xsd:string</para>
    ///   <para>rdfs:label : Governed object^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#CatalogEntry">vaem:CatalogEntry</a>
    /// </summary>
    let CatalogEntry = _prefixId.prefix "CatalogEntry"
    let CollectionGraph = _prefixId.prefix "CollectionGraph"
    let CurationGraph = _prefixId.prefix "CurationGraph"
    let DataGraph = _prefixId.prefix "DataGraph"
    let FunctionsGraph = _prefixId.prefix "FunctionsGraph"
    /// <summary>
    ///   <para>rdfs:comment : GraphRole is used to characterize how a graph of resources participates in an ontology set.  For example, a graph can be a schema, vocabulary, dataset, script, or ruleset.^^xsd:string</para>
    ///   <para>rdfs:label : Graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#GraphRole">vaem:GraphRole</a>
    /// </summary>
    let GraphRole = _prefixId.prefix "GraphRole"
    /// <summary>
    ///   <para>dce:description : The VAEM Licence Model class is a placeholder for concepts that are fully defined by VOAG.^^xsd:string</para>
    ///   <para>rdfs:label : License model^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#LicenseModel">vaem:LicenseModel</a>
    /// </summary>
    let LicenseModel = _prefixId.prefix "LicenseModel"
    let MappingGraph = _prefixId.prefix "MappingGraph"
    let ProxyGraph = _prefixId.prefix "ProxyGraph"
    let RulesGraph = _prefixId.prefix "RulesGraph"
    let SchemaGraph = _prefixId.prefix "SchemaGraph"
    let ScriptGraph = _prefixId.prefix "ScriptGraph"
    let ViewGraph = _prefixId.prefix "ViewGraph"
    let VocabularyGraph = _prefixId.prefix "VocabularyGraph"
    /// <summary>
    ///   <para>rdfs:comment : An annotation property that can be freely used on any kind of resource. The range of the property is 'xsd:string'.^^xsd:string</para>
    ///   <para>rdfs:label : definition^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#comment">vaem:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:date' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp. The property is also the parent of all dates so that queries can be made for any date on an ontology.^^xsd:string</para>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#date">vaem:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:dateCreated' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : date created^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#dateCreated">vaem:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    let dateUnion = _prefixId.prefix "dateUnion"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:description' is intended for general use as the name implies.  Unlike 'rdfs:comment',  'vaem:description' is an 'owl:DatatypeProperty'. As such it can play a stronger role in the model, for example, as a predicate in an axiom.^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#description">vaem:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : has catalog entry^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasCatalogEntry">vaem:hasCatalogEntry</a>
    /// </summary>
    let hasCatalogEntry = _prefixId.prefix "hasCatalogEntry"
    /// <summary>
    ///   <para>rdfs:comment : The property 'lms:hasGraphRole' is used to characterize how a resource participates in an ontology set.  The property is used to specify the role that a graph plays, for example, an ontology graph can be a schema, vocabulary, dataset, script, or ruleset.^^xsd:string</para>
    ///   <para>rdfs:label : has graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasGraphRole">vaem:hasGraphRole</a>
    /// </summary>
    let hasGraphRole = _prefixId.prefix "hasGraphRole"
    /// <summary>
    ///   <para>rdfs:label : has license type</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasLicenseType">vaem:hasLicenseType</a>
    /// </summary>
    let hasLicenseType = _prefixId.prefix "hasLicenseType"
    /// <summary>
    ///   <para>rdfs:comment : A refinement of the subject resource. Modelled after rdfs:isDefinedBy for the purpose of referring to layered graphs that further define a subject.^^xsd:string</para>
    ///   <para>rdfs:label : isRefinedBy^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#isRefinedBy">vaem:isRefinedBy</a>
    /// </summary>
    let isRefinedBy = _prefixId.prefix "isRefinedBy"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:lastUpdated' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : last updated^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#lastUpdated">vaem:lastUpdated</a>
    /// </summary>
    let lastUpdated = _prefixId.prefix "lastUpdated"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:name' is intended for general use. In many cases 'rdfs:label' could be used give names to resources. In the case where compliance with a specific naming rule is needed,  'vaem:name' allows  a resource to carry a name that is used in more specific contexts. Making 'vaem:name' a sub-property of 'rdfs:label' allows 'vaem:name' to serve in the same way as an 'rdfs:label'.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#name">vaem:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:namespace' provides a means to specify the onotlogy URI with which a graph is primarily associated. The intent is to allow multiple graphs to define statements for resources in the same Ontology namespace. For example, a foundation level graph with the base URI of 'http://www.somesite.com/1.0/schema/OurOntology'  may define general  concepts for 'OurOntology'. Another graph with the base URI 'http://www.somesite.com/1.0/schema/level2/OurOntology'  may add more specific details to the same 'OurOntology'. Each of these two graphs would carry the same value for 'vaem:namespace', that is, 'http://www.somesite.com/schema/OurOntology'.    In other words, an ontology URI is the URI associated with the resources of a controlled namespace. On the other hand the graph URIs (the base URIs) identify the graphs that hold resources that make up an ontology.^^xsd:string</para>
    ///   <para>rdfs:label : namespace^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespace">vaem:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:namespacePrefix' specifes a short handle or label for the URI of an Ontology.  Multiple graphs can define statements for resources in the same Ontololgy namespace. For example, a foundation level graph with the base URI of 'http://www.somesite.com/1.0/schema/OurOntology'  may define general  concepts for 'OurOntology'. Another graph with the base URI 'http://www.somesite.com/1.0/schema/level2/OurOntology'  may add more specific details to the same 'OurOntology'. Each of these two graphs would carry the same value for 'vaem:namespacePrefix', for this example, perhaps, 'ourOntology'.^^xsd:string</para>
    ///   <para>rdfs:label : namespace prefix^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespacePrefix">vaem:namespacePrefix</a>
    /// </summary>
    let namespacePrefix = _prefixId.prefix "namespacePrefix"
    let numericUnion = _prefixId.prefix "numericUnion"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:ownedBy' is a general property that in some cases could have scalar values or may refer to some concept of 'Party'.  For this reason, the  type of this property is set as 'rdf:Property' and the property is rangeless. There are two sub-properties of 'vaem:ownedBy', namely 'vaem:owner' for string values and 'vaem:owningParty' for referencing a 'party'.  Ownership applies to thos ontologies that are proprietary. Other governance and provenance specifications are held in the VOAG ontology.^^xsd:string</para>
    ///   <para>rdfs:label : owned by^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#ownedBy">vaem:ownedBy</a>
    /// </summary>
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#owner">vaem:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:owningParty' is used to refer to some concept of 'Party' and is a sub-property of 'vaem:ownedBy'.^^xsd:string</para>
    ///   <para>rdfs:label : owning party^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#owningParty">vaem:owningParty</a>
    /// </summary>
    let owningParty = _prefixId.prefix "owningParty"
    /// <summary>
    ///   <para>rdfs:comment : To express how statements in a model can be reifiable, this property is used to explicitly associate a property with a user-defined sub-class of 'rdf:Statement'. A recommended way of using this is to declare the properties that share the same reification constructs as sub-properties of a parent property that carries the 'vaem:reifiableBy' property. The parent property should be of type 'rdf:Property' so that it can have both datatype and object properties as sub-properties. By this means use and transformations of a model can be understood through a fully specified metamodel. 'vaem:reifiableBy' is rangeless in order to comply with OWL DL semantics. Its range would have been rdfs:Class in order to refer to 'rdf:Statement' sub-classes.^^xsd:string</para>
    ///   <para>rdfs:label : reifiable by^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#reifiableBy">vaem:reifiableBy</a>
    /// </summary>
    let reifiableBy = _prefixId.prefix "reifiableBy"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:releaseDate' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : release date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#releaseDate">vaem:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:revision' is a property intended for general use as the name implies. ^^xsd:string</para>
    ///   <para>rdfs:label : revision^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#revision">vaem:revision</a>
    /// </summary>
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#title">vaem:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : As it name implies, a way to attach an annotation about a 'todo' task^^xsd:string</para>
    ///   <para>rdfs:label : todo^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#todo">vaem:todo</a>
    /// </summary>
    let todo = _prefixId.prefix "todo"
    /// <summary>
    ///   <para>dce:description : The property 'vaem:url' is intended for general use as the name implies.  The range of the property is set as an XSD URI.^^xsd:string</para>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#url">vaem:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:comment : A property that is used to express dependencies on resources from graphs that are not imported.^^xsd:string</para>
    ///   <para>rdfs:label : uses non-imported resource^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource">vaem:usesNonImportedResource</a>
    /// </summary>
    let usesNonImportedResource = _prefixId.prefix "usesNonImportedResource"
    /// <summary>
    ///   <para>rdfs:label : with attribution to^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#withAttributionTo">vaem:withAttributionTo</a>
    /// </summary>
    let withAttributionTo = _prefixId.prefix "withAttributionTo"
