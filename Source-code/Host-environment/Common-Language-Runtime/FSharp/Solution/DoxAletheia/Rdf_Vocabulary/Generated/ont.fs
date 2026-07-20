namespace http.purl.org.net.ns.ontology_annot.hash

open DoxAletheia

module ont =
    let _namespace_name = "http://purl.org/net/ns/ontology-annot#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#created"></see>
    /// </summary>
    let created = _prefix "created"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#creator"></see>
    /// </summary>
    let creator = _prefix "creator"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#modified"></see>
    /// </summary>
    let modified = _prefix "modified"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#deprecatedBy"></see>
    /// </summary>
    let deprecatedBy = _prefix "deprecatedBy"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#seeOther"></see>
    /// </summary>
    let seeOther = _prefix "seeOther"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#title"></see>
    /// </summary>
    let title = _prefix "title"
