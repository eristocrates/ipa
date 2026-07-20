namespace http.purl.org.spar.bido.slash

open DoxAletheia

module bido =
    let _namespace_name = "http://purl.org/spar/bido/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/bido/bido.png"></see>
    /// </summary>
    let ``bido.png`` = _prefix "bido.png"
    /// <summary>
    ///   <see href="http://purl.org/spar/bido/2015-07-13"></see>
    /// </summary>
    let ``_2015-07-13`` = _prefix "2015-07-13"
