#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module skos =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2004/02/skos/core#" "skos"

    /// <summary>
    ///   <para>skos:scopeNote : Labelled collections can be used where you would like a set of concepts to be displayed under a 'node label' in the hierarchy.</para>
    ///   <para>skos:definition : A meaningful collection of concepts.</para>
    ///   <para>rdfs:label : Collection</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#Collection">skos:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>skos:definition : An idea or notion; a unit of thought.</para>
    ///   <para>rdfs:label : Concept</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#Concept">skos:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>skos:example : Thesauri, classification schemes, subject heading lists, taxonomies, 'folksonomies', and other types of controlled vocabulary are all examples of concept schemes. Concept schemes are also embedded in glossaries and terminologies.</para>
    ///   <para>skos:scopeNote : A concept scheme may be defined to include concepts from different sources.</para>
    ///   <para>skos:definition : A set of concepts, optionally including statements about semantic relationships between those concepts.</para>
    ///   <para>rdfs:label : Concept Scheme</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#ConceptScheme">skos:ConceptScheme</a>
    /// </summary>
    let ConceptScheme = _prefixId.prefix "ConceptScheme"
    /// <summary>
    ///   <para>skos:scopeNote : Ordered collections can be used where you would like a set of concepts to be displayed in a specific order, and optionally under a 'node label'.</para>
    ///   <para>skos:definition : An ordered collection of concepts, where both the grouping and the ordering are meaningful.</para>
    ///   <para>rdfs:label : Ordered Collection</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#OrderedCollection">skos:OrderedCollection</a>
    /// </summary>
    let OrderedCollection = _prefixId.prefix "OrderedCollection"
    /// <summary>
    ///   <para>rdfs:comment : skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.rdfs:comment : The range of skos:altLabel is the class of RDF plain literals.</para>
    ///   <para>skos:example : Acronyms, abbreviations, spelling variants, and irregular plural/singular forms may be included among the alternative labels for a concept. Mis-spelled terms are normally included as hidden labels (see skos:hiddenLabel).</para>
    ///   <para>skos:definition : An alternative lexical label for a resource.</para>
    ///   <para>rdfs:label : alternative label</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#altLabel">skos:altLabel</a>
    /// </summary>
    let altLabel = _prefixId.prefix "altLabel"
    /// <summary>
    ///   <para>skos:definition : skos:broadMatch is used to state a hierarchical mapping link between two conceptual resources in different concept schemes.</para>
    ///   <para>rdfs:label : has broader match</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#broadMatch">skos:broadMatch</a>
    /// </summary>
    let broadMatch = _prefixId.prefix "broadMatch"
    /// <summary>
    ///   <para>skos:scopeNote : By convention, skos:broader is only used to assert an immediate (i.e. direct) hierarchical link between two conceptual resources.</para>
    ///   <para>rdfs:comment : Broader concepts are typically rendered as parents in a concept hierarchy (tree).</para>
    ///   <para>skos:definition : Relates a concept to a concept that is more general in meaning.</para>
    ///   <para>rdfs:label : has broader</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#broader">skos:broader</a>
    /// </summary>
    let broader = _prefixId.prefix "broader"
    /// <summary>
    ///   <para>skos:scopeNote : By convention, skos:broaderTransitive is not used to make assertions. Rather, the properties can be used to draw inferences about the transitive closure of the hierarchical relation, which is useful e.g. when implementing a simple query expansion algorithm in a search application.</para>
    ///   <para>skos:definition : skos:broaderTransitive is a transitive superproperty of skos:broader.^^xsd:string</para>
    ///   <para>rdfs:label : has broader transitive</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#broaderTransitive">skos:broaderTransitive</a>
    /// </summary>
    let broaderTransitive = _prefixId.prefix "broaderTransitive"
    /// <summary>
    ///   <para>skos:definition : A note about a modification to a concept.</para>
    ///   <para>rdfs:label : change note</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#changeNote">skos:changeNote</a>
    /// </summary>
    let changeNote = _prefixId.prefix "changeNote"
    /// <summary>
    ///   <para>skos:definition : skos:closeMatch is used to link two concepts that are sufficiently similar that they can be used interchangeably in some information retrieval applications. In order to avoid the possibility of "compound errors" when combining mappings across more than two concept schemes, skos:closeMatch is not declared to be a transitive property.</para>
    ///   <para>rdfs:label : has close match</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#closeMatch">skos:closeMatch</a>
    /// </summary>
    let closeMatch = _prefixId.prefix "closeMatch"
    /// <summary>
    ///   <para>skos:definition : A statement or formal explanation of the meaning of a concept.</para>
    ///   <para>rdfs:label : definition</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#definition">skos:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>skos:definition : A note for an editor, translator or maintainer of the vocabulary.</para>
    ///   <para>rdfs:label : editorial note</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#editorialNote">skos:editorialNote</a>
    /// </summary>
    let editorialNote = _prefixId.prefix "editorialNote"
    /// <summary>
    ///   <para>rdfs:comment : skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.</para>
    ///   <para>skos:definition : skos:exactMatch is used to link two concepts, indicating a high degree of confidence that the concepts can be used interchangeably across a wide range of information retrieval applications. skos:exactMatch is a transitive property, and is a sub-property of skos:closeMatch.</para>
    ///   <para>rdfs:label : has exact match</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#exactMatch">skos:exactMatch</a>
    /// </summary>
    let exactMatch = _prefixId.prefix "exactMatch"
    /// <summary>
    ///   <para>skos:definition : An example of the use of a concept.</para>
    ///   <para>rdfs:label : example</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#example">skos:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    /// <summary>
    ///   <para>skos:definition : Relates, by convention, a concept scheme to a concept which is topmost in the broader/narrower concept hierarchies for that scheme, providing an entry point to these hierarchies.</para>
    ///   <para>rdfs:label : has top concept</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#hasTopConcept">skos:hasTopConcept</a>
    /// </summary>
    let hasTopConcept = _prefixId.prefix "hasTopConcept"
    /// <summary>
    ///   <para>rdfs:comment : skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.rdfs:comment : The range of skos:hiddenLabel is the class of RDF plain literals.</para>
    ///   <para>skos:definition : A lexical label for a resource that should be hidden when generating visual displays of the resource, but should still be accessible to free text search operations.</para>
    ///   <para>rdfs:label : hidden label</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#hiddenLabel">skos:hiddenLabel</a>
    /// </summary>
    let hiddenLabel = _prefixId.prefix "hiddenLabel"
    /// <summary>
    ///   <para>skos:definition : A note about the past state/use/meaning of a concept.</para>
    ///   <para>rdfs:label : history note</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#historyNote">skos:historyNote</a>
    /// </summary>
    let historyNote = _prefixId.prefix "historyNote"
    /// <summary>
    ///   <para>skos:scopeNote : A concept may be a member of more than one concept scheme.</para>
    ///   <para>skos:definition : Relates a resource (for example a concept) to a concept scheme in which it is included.</para>
    ///   <para>rdfs:label : is in scheme</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#inScheme">skos:inScheme</a>
    /// </summary>
    let inScheme = _prefixId.prefix "inScheme"
    /// <summary>
    ///   <para>rdfs:comment : These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.</para>
    ///   <para>skos:definition : Relates two concepts coming, by convention, from different schemes, and that have comparable meanings</para>
    ///   <para>rdfs:label : is in mapping relation with</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#mappingRelation">skos:mappingRelation</a>
    /// </summary>
    let mappingRelation = _prefixId.prefix "mappingRelation"
    /// <summary>
    ///   <para>skos:definition : Relates a collection to one of its members.</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#member">skos:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property.</para>
    ///   <para>skos:definition : Relates an ordered collection to the RDF list containing its members.</para>
    ///   <para>rdfs:label : has member list</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#memberList">skos:memberList</a>
    /// </summary>
    let memberList = _prefixId.prefix "memberList"
    /// <summary>
    ///   <para>skos:definition : skos:narrowMatch is used to state a hierarchical mapping link between two conceptual resources in different concept schemes.</para>
    ///   <para>rdfs:label : has narrower match</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#narrowMatch">skos:narrowMatch</a>
    /// </summary>
    let narrowMatch = _prefixId.prefix "narrowMatch"
    /// <summary>
    ///   <para>rdfs:comment : Narrower concepts are typically rendered as children in a concept hierarchy (tree).</para>
    ///   <para>skos:scopeNote : By convention, skos:broader is only used to assert an immediate (i.e. direct) hierarchical link between two conceptual resources.</para>
    ///   <para>skos:definition : Relates a concept to a concept that is more specific in meaning.</para>
    ///   <para>rdfs:label : has narrower</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#narrower">skos:narrower</a>
    /// </summary>
    let narrower = _prefixId.prefix "narrower"
    /// <summary>
    ///   <para>skos:scopeNote : By convention, skos:narrowerTransitive is not used to make assertions. Rather, the properties can be used to draw inferences about the transitive closure of the hierarchical relation, which is useful e.g. when implementing a simple query expansion algorithm in a search application.</para>
    ///   <para>skos:definition : skos:narrowerTransitive is a transitive superproperty of skos:narrower.^^xsd:string</para>
    ///   <para>rdfs:label : has narrower transitive</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#narrowerTransitive">skos:narrowerTransitive</a>
    /// </summary>
    let narrowerTransitive = _prefixId.prefix "narrowerTransitive"
    /// <summary>
    ///   <para>skos:scopeNote : By convention, skos:notation is used with a typed literal in the object position of the triple.</para>
    ///   <para>skos:definition : A notation, also known as classification code, is a string of characters such as "T58.5" or "303.4833" used to uniquely identify a concept within the scope of a given concept scheme.</para>
    ///   <para>rdfs:label : notation</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#notation">skos:notation</a>
    /// </summary>
    let notation = _prefixId.prefix "notation"
    /// <summary>
    ///   <para>skos:scopeNote : This property may be used directly, or as a super-property for more specific note types.</para>
    ///   <para>skos:definition : A general note, for any purpose.</para>
    ///   <para>rdfs:label : note</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#note">skos:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
    ///       disjoint properties.rdfs:comment : The range of skos:prefLabel is the class of RDF plain literals.rdfs:comment : A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.</para>
    ///   <para>skos:definition : The preferred lexical label for a resource, in a given language.</para>
    ///   <para>rdfs:label : preferred label</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#prefLabel">skos:prefLabel</a>
    /// </summary>
    let prefLabel = _prefixId.prefix "prefLabel"
    /// <summary>
    ///   <para>rdfs:comment : skos:related is disjoint with skos:broaderTransitive</para>
    ///   <para>skos:definition : Relates a concept to a concept with which there is an associative semantic relationship.</para>
    ///   <para>rdfs:label : has related</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#related">skos:related</a>
    /// </summary>
    let related = _prefixId.prefix "related"
    /// <summary>
    ///   <para>skos:definition : skos:relatedMatch is used to state an associative mapping link between two conceptual resources in different concept schemes.</para>
    ///   <para>rdfs:label : has related match</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#relatedMatch">skos:relatedMatch</a>
    /// </summary>
    let relatedMatch = _prefixId.prefix "relatedMatch"
    /// <summary>
    ///   <para>skos:definition : A note that helps to clarify the meaning and/or the use of a concept.</para>
    ///   <para>rdfs:label : scope note</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#scopeNote">skos:scopeNote</a>
    /// </summary>
    let scopeNote = _prefixId.prefix "scopeNote"
    /// <summary>
    ///   <para>skos:scopeNote : This property should not be used directly, but as a super-property for all properties denoting a relationship of meaning between concepts.</para>
    ///   <para>skos:definition : Links a concept to a concept related by meaning.</para>
    ///   <para>rdfs:label : is in semantic relation with</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#semanticRelation">skos:semanticRelation</a>
    /// </summary>
    let semanticRelation = _prefixId.prefix "semanticRelation"
    /// <summary>
    ///   <para>skos:definition : Relates a concept to the concept scheme that it is a top level concept of.</para>
    ///   <para>rdfs:label : is top concept in scheme</para>
    ///   <a href="http://www.w3.org/2004/02/skos/core#topConceptOf">skos:topConceptOf</a>
    /// </summary>
    let topConceptOf = _prefixId.prefix "topConceptOf"
