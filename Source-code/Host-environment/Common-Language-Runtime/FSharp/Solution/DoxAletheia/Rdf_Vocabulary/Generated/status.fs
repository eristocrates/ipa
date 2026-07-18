namespace http.www.w3.org._2003._06.sw_vocab_status.ns.hash

open DoxAletheia.Rdf_Vocabulary

module status =
    let _namespace_name = "http://www.w3.org/2003/06/sw-vocab-status/ns#"
    /// <summary>
    /// more information about the status etc of a term, typically human oriented
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo"></see></summary>
    let moreinfo = Namespaced_IRI.parse _namespace_name "moreinfo" |> NamespacedName

    /// <summary>
    /// the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status"></see></summary>
    let term_status =
        Namespaced_IRI.parse _namespace_name "term_status" |> NamespacedName

    /// <summary>
    /// human-oriented documentation, examples etc for use of this term
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs"></see></summary>
    let userdocs = Namespaced_IRI.parse _namespace_name "userdocs" |> NamespacedName
