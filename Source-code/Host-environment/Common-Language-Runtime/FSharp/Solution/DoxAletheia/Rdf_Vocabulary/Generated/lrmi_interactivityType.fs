namespace http.purl.org.dcx.lrmi_vocabs.interactivityType.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi_interactivityType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/interactivityType/"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/active"></see>
    /// </summary>
    let active = Namespaced_IRI.parse _namespace_name "active" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/expositive"></see>
    /// </summary>
    let expositive = Namespaced_IRI.parse _namespace_name "expositive" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/mixed"></see>
    /// </summary>
    let mixed = Namespaced_IRI.parse _namespace_name "mixed" |> NamespacedName
