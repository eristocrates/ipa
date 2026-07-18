namespace http.ns.inria.fr.ludo.bare

open DoxAletheia.Rdf_Vocabulary

module ludo =
    let _namespace_name = "http://ns.inria.fr/ludo"

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/images/ludo_in_a_nutshell.png"></see>
    /// </summary>
    let ``_/images/ludo_in_a_nutshell.png`` =
        Namespaced_IRI.parse _namespace_name "/images/ludo_in_a_nutshell.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi.rdf"></see>
    /// </summary>
    let ``_/v1/xapi.rdf`` =
        Namespaced_IRI.parse _namespace_name "/v1/xapi.rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamepresentation.rdf"></see>
    /// </summary>
    let ``_/v1/gamepresentation.rdf`` =
        Namespaced_IRI.parse _namespace_name "/v1/gamepresentation.rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel.rdf"></see>
    /// </summary>
    let ``_/v1/gamemodel.rdf`` =
        Namespaced_IRI.parse _namespace_name "/v1/gamemodel.rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/virtualcontext.rdf"></see>
    /// </summary>
    let ``_/v1/virtualcontext.rdf`` =
        Namespaced_IRI.parse _namespace_name "/v1/virtualcontext.rdf" |> NamespacedName
