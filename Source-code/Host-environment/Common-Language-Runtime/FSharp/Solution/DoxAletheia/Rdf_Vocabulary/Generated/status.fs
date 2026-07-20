namespace http.www.w3.org._2003._06.sw_vocab_status.ns.hash

open DoxAletheia

module status =
    let _namespace_name = "http://www.w3.org/2003/06/sw-vocab-status/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// more information about the status etc of a term, typically human oriented
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo"></see></summary>
    let moreinfo = _prefix "moreinfo"
    /// <summary>
    /// the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status"></see></summary>
    let term_status = _prefix "term_status"
    /// <summary>
    /// human-oriented documentation, examples etc for use of this term
    /// <see href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs"></see></summary>
    let userdocs = _prefix "userdocs"
