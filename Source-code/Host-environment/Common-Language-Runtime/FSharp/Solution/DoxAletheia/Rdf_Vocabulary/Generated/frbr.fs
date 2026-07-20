namespace http.purl.org.spar.frbr.slash

open DoxAletheia

module frbr =
    let _namespace_name = "http://purl.org/spar/frbr/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/frbr/2011-06-29"></see>
    /// </summary>
    let ``_2011-06-29`` = _prefix "2011-06-29"
    /// <summary>
    ///   <see href="http://purl.org/spar/frbr/2018-03-29"></see>
    /// </summary>
    let ``_2018-03-29`` = _prefix "2018-03-29"
