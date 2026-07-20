namespace http.www.daml.org.services.owl_s._1._2.ActorDefault.owl.hash

open DoxAletheia

module owls_ActorDefault =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    ///       Actor represents a Requester or Provider who might request or offer a service.
    ///       The original Actor definition was provided within DAML-S V0.5, V0.6 and V0.7
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#email"></see>
    /// </summary>
    let email = _prefix "email"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#fax"></see>
    /// </summary>
    let fax = _prefix "fax"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#phone"></see>
    /// </summary>
    let phone = _prefix "phone"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#physicalAddress"></see>
    /// </summary>
    let physicalAddress = _prefix "physicalAddress"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#webURL"></see>
    /// </summary>
    let webURL = _prefix "webURL"
