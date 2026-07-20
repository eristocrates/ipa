namespace http.purl.org.swan._2._0.slash

open DoxAletheia

module swan =
    let _namespace_name = "http://purl.org/swan/2.0/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/agents/"></see>
    /// </summary>
    let ``agents/`` = _prefix "agents/"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/"></see>
    /// </summary>
    let ``discourse-elements/`` = _prefix "discourse-elements/"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/"></see>
    /// </summary>
    let ``discourse-relationships/`` = _prefix "discourse-relationships/"
