namespace http.open_services.net.ns.am.hash

open DoxAletheia

module oslc_am =
    let _namespace_name = "http://open-services.net/ns/am#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A locally managed resource that describes a link type predicate that might otherwise not be directly resolvable.
    /// <see href="http://open-services.net/ns/am#LinkType"></see></summary>
    let LinkType = _prefix "LinkType"
    /// <summary>
    /// A generic architecture resource.  A resource of this type is likely to be a model or design artifact.
    /// <see href="http://open-services.net/ns/am#Resource"></see></summary>
    let Resource = _prefix "Resource"
