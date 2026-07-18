namespace http.ns.inria.fr.ludo.v1.gamepresentation.hash

open DoxAletheia.Rdf_Vocabulary

module ludo_gp =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/gamepresentation#"

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamepresentation#FrontEndDisplay"></see>
    /// </summary>
    let FrontEndDisplay =
        Namespaced_IRI.parse _namespace_name "FrontEndDisplay" |> NamespacedName
