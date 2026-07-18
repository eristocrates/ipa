namespace http.purl.org.umu.uneskos.hash

open DoxAletheia.Rdf_Vocabulary

module uneskos =
    let _namespace_name = "http://purl.org/umu/uneskos#"
    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#hasMainConcept"></see>
    /// </summary>
    let hasMainConcept =
        Namespaced_IRI.parse _namespace_name "hasMainConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#hasMicroThesaurus"></see>
    /// </summary>
    let hasMicroThesaurus =
        Namespaced_IRI.parse _namespace_name "hasMicroThesaurus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#mainConceptOf"></see>
    /// </summary>
    let mainConceptOf =
        Namespaced_IRI.parse _namespace_name "mainConceptOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#memberOf"></see>
    /// </summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
