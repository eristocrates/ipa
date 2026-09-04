#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cmo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/twc/ontologies/cmo.owl#" "cmo"

    /// <summary>
    ///   <para>rdfs:comment : The conceputal representation of anything that is a property (a thing that is inherent in an entity, like eye color) or an attribute (a thing that has been assigned, or attributed, to an entity, like name or identification number).^^xsd:string</para>
    ///   <para>rdfs:label : Quality^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#Quality">cmo:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>rdfs:comment : A concept representing the relationship between two independent entities.^^xsd:string</para>
    ///   <para>rdfs:label : Relation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#Relation">cmo:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:comment : An abstract or general idea inferred or derived from specific instances, representing a set of those instances.^^xsd:string</para>
    ///   <para>rdfs:label : Type^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#Type">cmo:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:comment : Entities that describe the objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)^^xsd:string</para>
    ///   <para>rdfs:label : Universal^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#Universal">cmo:Universal</a>
    /// </summary>
    let Universal = _prefixId.prefix "Universal"
    /// <summary>
    ///   <para>rdfs:comment : Universal (natural) sets of objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)^^xsd:string</para>
    ///   <para>rdfs:label : Universal Class^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#UniversalClass">cmo:UniversalClass</a>
    /// </summary>
    let UniversalClass = _prefixId.prefix "UniversalClass"
    /// <summary>
    ///   <para>rdfs:seeAlso : Qualities in reality. (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)^^xsd:string</para>
    ///   <para>rdfs:label : Universal Quality^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#UniversalQuality">cmo:UniversalQuality</a>
    /// </summary>
    let UniversalQuality = _prefixId.prefix "UniversalQuality"
    /// <summary>
    ///   <para>rdfs:comment : Relationships in reality. (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)^^xsd:string</para>
    ///   <para>rdfs:label : Universal Relation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#UniversalRelation">cmo:UniversalRelation</a>
    /// </summary>
    let UniversalRelation = _prefixId.prefix "UniversalRelation"
    /// <summary>
    ///   <para>rdfs:label : has primary concept^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasPrimaryConcept">cmo:hasPrimaryConcept</a>
    /// </summary>
    let hasPrimaryConcept = _prefixId.prefix "hasPrimaryConcept"
    /// <summary>
    ///   <para>rdfs:label : has qualifying concept^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasQualifier">cmo:hasQualifier</a>
    /// </summary>
    let hasQualifier = _prefixId.prefix "hasQualifier"
    /// <summary>
    ///   <para>rdfs:comment : A conceptual type can have qualities that describe it.^^xsd:string</para>
    ///   <para>rdfs:label : has quality^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasQuality">cmo:hasQuality</a>
    /// </summary>
    let hasQuality = _prefixId.prefix "hasQuality"
    /// <summary>
    ///   <para>rdfs:label : has role^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasRole">cmo:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has role in relation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasRoleIn">cmo:hasRoleIn</a>
    /// </summary>
    let hasRoleIn = _prefixId.prefix "hasRoleIn"
    /// <summary>
    ///   <para>rdfs:label : has source role^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRole">cmo:hasSourceRole</a>
    /// </summary>
    let hasSourceRole = _prefixId.prefix "hasSourceRole"
    /// <summary>
    ///   <para>rdfs:label : has source role in relation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRoleIn">cmo:hasSourceRoleIn</a>
    /// </summary>
    let hasSourceRoleIn = _prefixId.prefix "hasSourceRoleIn"
    /// <summary>
    ///   <para>rdfs:label : has target role^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRole">cmo:hasTargetRole</a>
    /// </summary>
    let hasTargetRole = _prefixId.prefix "hasTargetRole"
    /// <summary>
    ///   <para>rdfs:label : has target role in relation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRoleIn">cmo:hasTargetRoleIn</a>
    /// </summary>
    let hasTargetRoleIn = _prefixId.prefix "hasTargetRoleIn"
    /// <summary>
    ///   <para>rdfs:label : is quality of^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#qualityOf">cmo:qualityOf</a>
    /// </summary>
    let qualityOf = _prefixId.prefix "qualityOf"
    /// <summary>
    ///   <para>rdfs:comment : Things in the real world can be represented by concepts. This is a link between the concepts and the things those concepts represent. Things, including sets of things, are represented by concepts.^^xsd:string</para>
    ///   <para>rdfs:label : represented by^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#representedBy">cmo:representedBy</a>
    /// </summary>
    let representedBy = _prefixId.prefix "representedBy"
    /// <summary>
    ///   <para>rdfs:comment : Things in the real world can be represented by concepts. This is a link from the concepts and the things those concepts represent. Concepts represent things.^^xsd:string</para>
    ///   <para>rdfs:label : represents^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#represents">cmo:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:comment : Concepts represent universals in the world.^^xsd:string</para>
    ///   <para>rdfs:label : represents universal^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#representsUniversal">cmo:representsUniversal</a>
    /// </summary>
    let representsUniversal = _prefixId.prefix "representsUniversal"
    /// <summary>
    ///   <para>rdfs:label : values can be^^xsd:string</para>
    ///   <a href="http://purl.org/twc/ontologies/cmo.owl#valuesCanBe">cmo:valuesCanBe</a>
    /// </summary>
    let valuesCanBe = _prefixId.prefix "valuesCanBe"
