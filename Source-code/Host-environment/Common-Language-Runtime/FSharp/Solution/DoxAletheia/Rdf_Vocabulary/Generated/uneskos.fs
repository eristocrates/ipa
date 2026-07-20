namespace http.purl.org.umu.uneskos.hash

open DoxAletheia

module uneskos =
    let _namespace_name = "http://purl.org/umu/uneskos#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#hasMainConcept"></see>
    /// </summary>
    let hasMainConcept = _prefix "hasMainConcept"
    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#hasMicroThesaurus"></see>
    /// </summary>
    let hasMicroThesaurus = _prefix "hasMicroThesaurus"
    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#mainConceptOf"></see>
    /// </summary>
    let mainConceptOf = _prefix "mainConceptOf"
    /// <summary>
    ///   <see href="http://purl.org/umu/uneskos#memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
