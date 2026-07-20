namespace http.purl.org.dcx.lrmi_vocabs.interactivityType.slash

open DoxAletheia

module lrmi_interactivityType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/interactivityType/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/active"></see>
    /// </summary>
    let active = _prefix "active"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/expositive"></see>
    /// </summary>
    let expositive = _prefix "expositive"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/interactivityType/mixed"></see>
    /// </summary>
    let mixed = _prefix "mixed"
