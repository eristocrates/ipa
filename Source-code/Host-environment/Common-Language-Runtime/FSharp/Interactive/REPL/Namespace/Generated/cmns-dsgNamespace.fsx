#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-dsg`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Designators/" "cmns-dsg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : designation^^xsd:string</para>
    ///   <para>skos:definition : representation for something, or for a conceptualization thereof, that denotes it in a domain or subject^^xsd:string</para>
    ///   <para>skos:note : A designation can be a term including appellations, a proper name, or a symbol.^^xsd:stringskos:note : A designation can be linguistic or non-linguistic. It can consist of various types of characters, but also punctuation marks such as hyphens and parentheses, governed by domain-, subject-, or language-specific conventions.^^xsd:stringskos:note : Note that the use of the min 0 cardinality restriction in the definition of this class is provided as a reminder that designators are expected, in many cases, to have a text value associated with them. There are cases where this is not true, however, including symbols. And, there may be cases where the value is not known. Additionally, not all tools support rdf:langString, thus its use in the definition of the Text datatype may cause errors, for example in value and some number restrictions. Min 0 cardinality constraints are ignored by reasoners and other processors, so this allows us to say that the possible values for this property are likely either xsd:string or rdf:langString, but does not require it depending on the environment in which the ontology is deployed.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09, clause 3.4.1^^xsd:stringcmns-av:adaptedFrom : ISO 704 Terminology work - Principles and methods, Fourth edition, 2022-07, Figure 1^^xsd:string</para>
    ///   <para>cmns-av:synonym : designator^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/Designation">cmns-dsg:Designation</a>
    /// </summary>
    let Designation = _prefixId.prefix "Designation"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>skos:definition : designation for something by a linguistic expression^^xsd:string</para>
    ///   <para>skos:note : In ISO 1087, a name may be an appellation and is defined as a term that is applied to a group of objects whose relevant properties are identical, whereas a proper name is a designation that represents an individual object.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Registry metamodel and basic attributes, Third edition, 2013-02-15, clause 3.2.83^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that unlike symbols and other designations, a name is explicitly not linguistically neutral.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/Name">cmns-dsg:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:label : defines^^xsd:string</para>
    ///   <para>skos:definition : specifies the meaning of something in terms of one or more of its essential qualities^^xsd:string</para>
    ///   <para>skos:note : A quality is an elementary characteristic of something. An 'essential quality' is one that provides a necessary criteria for being that thing and differentiating criteria for not being something else.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/defines">cmns-dsg:defines</a>
    /// </summary>
    let defines = _prefixId.prefix "defines"
    /// <summary>
    ///   <para>rdfs:label : denotes^^xsd:string</para>
    ///   <para>skos:definition : serves as a sign for something, or for a conceptualization thereof^^xsd:string</para>
    ///   <para>skos:note : Note that in some references, such as the semiotics ontology from Ontology Design Patterns,'denotes' can be used to talk about e.g. entities denoted by proper nouns: the proper noun 'Leonardo da Vinci' denotes the person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' denotes the collection of all persons in a domain of discourse. Other references that may be useful for interpreting 'denotes' include OntoLex. The interpretation of 'denotes' in this context is more general, but intended to reflect its usage in the semiotic triangle.^^xsd:string</para>
    ///   <para>skos:scopeNote : This property could be specialized to differentiate the notion of referring to something, i.e., a referent, from the notion of evoking a concept. Consider that in OntoLex, the term denotes is used to designate the sign referent relationship specifically, which in ISO 704:2022 is called 'refers to' in Figure 1. This definition is also meant to cover the OntoLex notion of evokes, which in ISO 704:2022 is called designates or represents.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09, clause 3.4.1^^xsd:stringcmns-av:adaptedFrom : ISO 704 Terminology work - Principles and methods, Fourth edition, 2022-07, Figure 1^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/denotes">cmns-dsg:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>rdfs:label : describes^^xsd:string</para>
    ///   <para>skos:definition : conveys the nature of^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that the describes property defined herein as an object property has an implicit range of owl:Class. This is purposeful, so that users can specify any concept, such as a document, contract, specification, situation, or other domain-specific concept, as the thing being described by the domain of this property, which might also be a document, reference, or something else.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/describes">cmns-dsg:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : has description^^xsd:string</para>
    ///   <para>skos:definition : provides a textual statement, picture in words, or account that describes something^^xsd:string</para>
    ///   <para>skos:note : Note that the hasDescription property defined herein has an implicit range of rdfs:Literal. This is purposeful, so that users can specify any element that has a name with or without a language tag without concern for conflicting datatypes (i.e., xsd:string vs. rdf:langString, which are logically disjoint).^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is a data property, rather than an annotation such as dct:description, enabling it to be used for mapping controlled vocabularies and other literals that are explicit, required attributes of other models.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/hasDescription">cmns-dsg:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : has name^^xsd:string</para>
    ///   <para>skos:definition : is known by^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/hasName">cmns-dsg:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : has tag^^xsd:string</para>
    ///   <para>skos:definition : associates unique combination of alphanumeric characters corresponding to a designator for something^^xsd:string</para>
    ///   <para>skos:note : Text-valued tags can be useful for controlled vocabulary encoding or transformation, such as those used to produce IETF compliant language tags in XML.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/hasTag">cmns-dsg:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : has textual name^^xsd:string</para>
    ///   <para>skos:definition : associates a name, reference name, or appellation with an individual concept^^xsd:string</para>
    ///   <para>skos:note : Note that the hasTextualName property defined herein has an implicit range of rdfs:Literal. This is purposeful, so that users can specify any element that has a name with or without a language tag without concern for conflicting datatypes (i.e., xsd:string vs. rdf:langString, which are logically disjoint).^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 639:2023 Code for individual languages and language groups, Second edition, 2023-11^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/hasTextualName">cmns-dsg:hasTextualName</a>
    /// </summary>
    let hasTextualName = _prefixId.prefix "hasTextualName"
    /// <summary>
    ///   <para>rdfs:label : is defined in^^xsd:string</para>
    ///   <para>skos:definition : indicates something that specifies the meaning associated with the subject^^xsd:string</para>
    ///   <para>skos:note : Typically, a concept, such as a classifier or identifier, will be defined in terms of a scheme, contract, specification, standard, or other reference.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/isDefinedIn">cmns-dsg:isDefinedIn</a>
    /// </summary>
    let isDefinedIn = _prefixId.prefix "isDefinedIn"
    /// <summary>
    ///   <para>rdfs:label : is described by^^xsd:string</para>
    ///   <para>skos:definition : has general nature or description of^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that the 'is described by' property defined herein as an object property has an implicit range of owl:Class. This is purposeful, so that users can specify any concept, such as a document, reference, or other domain-specific concept, as the descriptive thing describing the domain of this property.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/isDescribedBy">cmns-dsg:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : is name of^^xsd:string</para>
    ///   <para>skos:definition : denotes in some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/isNameOf">cmns-dsg:isNameOf</a>
    /// </summary>
    let isNameOf = _prefixId.prefix "isNameOf"
    /// <summary>
    ///   <para>rdfs:label : is signified by^^xsd:string</para>
    ///   <para>skos:definition : has representation, denotation or sign of^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Designators/isSignifiedBy">cmns-dsg:isSignifiedBy</a>
    /// </summary>
    let isSignifiedBy = _prefixId.prefix "isSignifiedBy"
