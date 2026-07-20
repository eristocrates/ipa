namespace http.www.w3.org._2004._02.skos.core.hash

open DoxAletheia

module skos =
    let _namespace_name = "http://www.w3.org/2004/02/skos/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#ConceptScheme"></see>
    /// </summary>
    let ConceptScheme = _prefix "ConceptScheme"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#definition"></see>
    /// </summary>
    let definition = _prefix "definition"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#scopeNote"></see>
    /// </summary>
    let scopeNote = _prefix "scopeNote"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#example"></see>
    /// </summary>
    let example = _prefix "example"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#OrderedCollection"></see>
    /// </summary>
    let OrderedCollection = _prefix "OrderedCollection"
    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    /// The range of skos:altLabel is the class of RDF plain literals.
    /// <see href="http://www.w3.org/2004/02/skos/core#altLabel"></see></summary>
    let altLabel = _prefix "altLabel"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#broadMatch"></see>
    /// </summary>
    let broadMatch = _prefix "broadMatch"
    /// <summary>
    /// Broader concepts are typically rendered as parents in a concept hierarchy (tree).
    /// <see href="http://www.w3.org/2004/02/skos/core#broader"></see></summary>
    let broader = _prefix "broader"
    /// <summary>
    /// These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.
    /// <see href="http://www.w3.org/2004/02/skos/core#mappingRelation"></see></summary>
    let mappingRelation = _prefix "mappingRelation"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#narrowMatch"></see>
    /// </summary>
    let narrowMatch = _prefix "narrowMatch"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#broaderTransitive"></see>
    /// </summary>
    let broaderTransitive = _prefix "broaderTransitive"
    /// <summary>
    /// Narrower concepts are typically rendered as children in a concept hierarchy (tree).
    /// <see href="http://www.w3.org/2004/02/skos/core#narrower"></see></summary>
    let narrower = _prefix "narrower"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#semanticRelation"></see>
    /// </summary>
    let semanticRelation = _prefix "semanticRelation"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#narrowerTransitive"></see>
    /// </summary>
    let narrowerTransitive = _prefix "narrowerTransitive"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#changeNote"></see>
    /// </summary>
    let changeNote = _prefix "changeNote"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#closeMatch"></see>
    /// </summary>
    let closeMatch = _prefix "closeMatch"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#editorialNote"></see>
    /// </summary>
    let editorialNote = _prefix "editorialNote"
    /// <summary>
    /// skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.
    /// <see href="http://www.w3.org/2004/02/skos/core#exactMatch"></see></summary>
    let exactMatch = _prefix "exactMatch"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#hasTopConcept"></see>
    /// </summary>
    let hasTopConcept = _prefix "hasTopConcept"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#topConceptOf"></see>
    /// </summary>
    let topConceptOf = _prefix "topConceptOf"
    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    /// The range of skos:hiddenLabel is the class of RDF plain literals.
    /// <see href="http://www.w3.org/2004/02/skos/core#hiddenLabel"></see></summary>
    let hiddenLabel = _prefix "hiddenLabel"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#historyNote"></see>
    /// </summary>
    let historyNote = _prefix "historyNote"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#inScheme"></see>
    /// </summary>
    let inScheme = _prefix "inScheme"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    /// For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property.
    /// <see href="http://www.w3.org/2004/02/skos/core#memberList"></see></summary>
    let memberList = _prefix "memberList"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#notation"></see>
    /// </summary>
    let notation = _prefix "notation"
    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
    ///       disjoint properties.
    /// The range of skos:prefLabel is the class of RDF plain literals.
    /// A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.
    /// <see href="http://www.w3.org/2004/02/skos/core#prefLabel"></see></summary>
    let prefLabel = _prefix "prefLabel"
    /// <summary>
    /// skos:related is disjoint with skos:broaderTransitive
    /// <see href="http://www.w3.org/2004/02/skos/core#related"></see></summary>
    let related = _prefix "related"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#relatedMatch"></see>
    /// </summary>
    let relatedMatch = _prefix "relatedMatch"
