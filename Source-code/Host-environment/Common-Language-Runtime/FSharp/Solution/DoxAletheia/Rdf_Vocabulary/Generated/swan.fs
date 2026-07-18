namespace http.purl.org.swan._2._0.slash

open DoxAletheia.Rdf_Vocabulary

module swan =
    let _namespace_name = "http://purl.org/swan/2.0/"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/agents/"></see>
    /// </summary>
    let ``agents/`` = Namespaced_IRI.parse _namespace_name "agents/" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/"></see>
    /// </summary>
    let ``discourse-elements/`` =
        Namespaced_IRI.parse _namespace_name "discourse-elements/" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/"></see>
    /// </summary>
    let ``discourse-relationships/`` =
        Namespaced_IRI.parse _namespace_name "discourse-relationships/" |> NamespacedName
