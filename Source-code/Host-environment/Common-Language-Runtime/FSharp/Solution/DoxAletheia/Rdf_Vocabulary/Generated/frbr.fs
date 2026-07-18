namespace http.purl.org.spar.frbr.slash

open DoxAletheia.Rdf_Vocabulary

module frbr =
    let _namespace_name = "http://purl.org/spar/frbr/"

    /// <summary>
    ///   <see href="http://purl.org/spar/frbr/2011-06-29"></see>
    /// </summary>
    let ``_2011-06-29`` =
        Namespaced_IRI.parse _namespace_name "2011-06-29" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/frbr/2018-03-29"></see>
    /// </summary>
    let ``_2018-03-29`` =
        Namespaced_IRI.parse _namespace_name "2018-03-29" |> NamespacedName
