namespace http.www.w3.org._2004._02.skos.core.hash

open DoxAletheia.Rdf_Vocabulary

module skos =
    let _namespace_name = "http://www.w3.org/2004/02/skos/core#"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#Collection"></see>
    /// </summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#ConceptScheme"></see>
    /// </summary>
    let ConceptScheme =
        Namespaced_IRI.parse _namespace_name "ConceptScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#definition"></see>
    /// </summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#scopeNote"></see>
    /// </summary>
    let scopeNote = Namespaced_IRI.parse _namespace_name "scopeNote" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#example"></see>
    /// </summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#OrderedCollection"></see>
    /// </summary>
    let OrderedCollection =
        Namespaced_IRI.parse _namespace_name "OrderedCollection" |> NamespacedName

    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    /// The range of skos:altLabel is the class of RDF plain literals.
    /// <see href="http://www.w3.org/2004/02/skos/core#altLabel"></see></summary>
    let altLabel = Namespaced_IRI.parse _namespace_name "altLabel" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#broadMatch"></see>
    /// </summary>
    let broadMatch = Namespaced_IRI.parse _namespace_name "broadMatch" |> NamespacedName
    /// <summary>
    /// Broader concepts are typically rendered as parents in a concept hierarchy (tree).
    /// <see href="http://www.w3.org/2004/02/skos/core#broader"></see></summary>
    let broader = Namespaced_IRI.parse _namespace_name "broader" |> NamespacedName

    /// <summary>
    /// These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.
    /// <see href="http://www.w3.org/2004/02/skos/core#mappingRelation"></see></summary>
    let mappingRelation =
        Namespaced_IRI.parse _namespace_name "mappingRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#narrowMatch"></see>
    /// </summary>
    let narrowMatch =
        Namespaced_IRI.parse _namespace_name "narrowMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#broaderTransitive"></see>
    /// </summary>
    let broaderTransitive =
        Namespaced_IRI.parse _namespace_name "broaderTransitive" |> NamespacedName

    /// <summary>
    /// Narrower concepts are typically rendered as children in a concept hierarchy (tree).
    /// <see href="http://www.w3.org/2004/02/skos/core#narrower"></see></summary>
    let narrower = Namespaced_IRI.parse _namespace_name "narrower" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#semanticRelation"></see>
    /// </summary>
    let semanticRelation =
        Namespaced_IRI.parse _namespace_name "semanticRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#narrowerTransitive"></see>
    /// </summary>
    let narrowerTransitive =
        Namespaced_IRI.parse _namespace_name "narrowerTransitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#changeNote"></see>
    /// </summary>
    let changeNote = Namespaced_IRI.parse _namespace_name "changeNote" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#closeMatch"></see>
    /// </summary>
    let closeMatch = Namespaced_IRI.parse _namespace_name "closeMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#editorialNote"></see>
    /// </summary>
    let editorialNote =
        Namespaced_IRI.parse _namespace_name "editorialNote" |> NamespacedName

    /// <summary>
    /// skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.
    /// <see href="http://www.w3.org/2004/02/skos/core#exactMatch"></see></summary>
    let exactMatch = Namespaced_IRI.parse _namespace_name "exactMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#hasTopConcept"></see>
    /// </summary>
    let hasTopConcept =
        Namespaced_IRI.parse _namespace_name "hasTopConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#topConceptOf"></see>
    /// </summary>
    let topConceptOf =
        Namespaced_IRI.parse _namespace_name "topConceptOf" |> NamespacedName

    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    /// The range of skos:hiddenLabel is the class of RDF plain literals.
    /// <see href="http://www.w3.org/2004/02/skos/core#hiddenLabel"></see></summary>
    let hiddenLabel =
        Namespaced_IRI.parse _namespace_name "hiddenLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#historyNote"></see>
    /// </summary>
    let historyNote =
        Namespaced_IRI.parse _namespace_name "historyNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#inScheme"></see>
    /// </summary>
    let inScheme = Namespaced_IRI.parse _namespace_name "inScheme" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property.
    /// <see href="http://www.w3.org/2004/02/skos/core#memberList"></see></summary>
    let memberList = Namespaced_IRI.parse _namespace_name "memberList" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#notation"></see>
    /// </summary>
    let notation = Namespaced_IRI.parse _namespace_name "notation" |> NamespacedName
    /// <summary>
    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
    ///       disjoint properties.
    /// The range of skos:prefLabel is the class of RDF plain literals.
    /// A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.
    /// <see href="http://www.w3.org/2004/02/skos/core#prefLabel"></see></summary>
    let prefLabel = Namespaced_IRI.parse _namespace_name "prefLabel" |> NamespacedName
    /// <summary>
    /// skos:related is disjoint with skos:broaderTransitive
    /// <see href="http://www.w3.org/2004/02/skos/core#related"></see></summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/02/skos/core#relatedMatch"></see>
    /// </summary>
    let relatedMatch =
        Namespaced_IRI.parse _namespace_name "relatedMatch" |> NamespacedName
