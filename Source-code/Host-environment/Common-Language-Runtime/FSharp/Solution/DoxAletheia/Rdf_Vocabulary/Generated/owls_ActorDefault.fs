namespace http.www.daml.org.services.owl_s._1._2.ActorDefault.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_ActorDefault =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#"
    /// <summary>
    ///
    ///       Actor represents a Requester or Provider who might request or offer a service.
    ///       The original Actor definition was provided within DAML-S V0.5, V0.6 and V0.7
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#email"></see>
    /// </summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#fax"></see>
    /// </summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#phone"></see>
    /// </summary>
    let phone = Namespaced_IRI.parse _namespace_name "phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#physicalAddress"></see>
    /// </summary>
    let physicalAddress =
        Namespaced_IRI.parse _namespace_name "physicalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#webURL"></see>
    /// </summary>
    let webURL = Namespaced_IRI.parse _namespace_name "webURL" |> NamespacedName
