namespace http.ns.inria.fr.ludo.bare

open DoxAletheia

module ludo =
    let _namespace_name = "http://ns.inria.fr/ludo"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/images/ludo_in_a_nutshell.png"></see>
    /// </summary>
    let ``_/images/ludo_in_a_nutshell.png`` = _prefix "/images/ludo_in_a_nutshell.png"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/xapi.rdf"></see>
    /// </summary>
    let ``_/v1/xapi.rdf`` = _prefix "/v1/xapi.rdf"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamepresentation.rdf"></see>
    /// </summary>
    let ``_/v1/gamepresentation.rdf`` = _prefix "/v1/gamepresentation.rdf"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/gamemodel.rdf"></see>
    /// </summary>
    let ``_/v1/gamemodel.rdf`` = _prefix "/v1/gamemodel.rdf"
    /// <summary>
    ///   <see href="http://ns.inria.fr/ludo/v1/virtualcontext.rdf"></see>
    /// </summary>
    let ``_/v1/virtualcontext.rdf`` = _prefix "/v1/virtualcontext.rdf"
