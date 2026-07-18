namespace http.purl.org.net.ns.ontology_annot.hash

open DoxAletheia.Rdf_Vocabulary

module ont =
    let _namespace_name = "http://purl.org/net/ns/ontology-annot#"
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#created"></see>
    /// </summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#creator"></see>
    /// </summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#modified"></see>
    /// </summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#deprecatedBy"></see>
    /// </summary>
    let deprecatedBy =
        Namespaced_IRI.parse _namespace_name "deprecatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#seeOther"></see>
    /// </summary>
    let seeOther = Namespaced_IRI.parse _namespace_name "seeOther" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/ns/ontology-annot#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
