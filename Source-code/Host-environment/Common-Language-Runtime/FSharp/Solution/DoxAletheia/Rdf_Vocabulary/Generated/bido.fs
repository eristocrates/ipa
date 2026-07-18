namespace http.purl.org.spar.bido.slash

open DoxAletheia.Rdf_Vocabulary

module bido =
    let _namespace_name = "http://purl.org/spar/bido/"
    /// <summary>
    ///   <see href="http://purl.org/spar/bido/bido.png"></see>
    /// </summary>
    let ``bido.png`` = Namespaced_IRI.parse _namespace_name "bido.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/bido/2015-07-13"></see>
    /// </summary>
    let ``_2015-07-13`` =
        Namespaced_IRI.parse _namespace_name "2015-07-13" |> NamespacedName
