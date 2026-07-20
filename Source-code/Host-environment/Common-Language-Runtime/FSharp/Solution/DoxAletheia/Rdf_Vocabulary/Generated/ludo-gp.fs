namespace http.ns.inria.fr.ludo.v1.gamepresentation.hash

open DoxAletheia

module ludo_gp =
    let _namespace_name = "http://ns.inria.fr/ludo/v1/gamepresentation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamepresentation#FrontEndDisplay"></see>
    /// </summary>
    let FrontEndDisplay = _prefix "FrontEndDisplay"
