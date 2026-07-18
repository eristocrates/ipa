namespace http.open_services.net.ns.am.hash

open DoxAletheia.Rdf_Vocabulary

module oslc_am =
    let _namespace_name = "http://open-services.net/ns/am#"
    /// <summary>
    /// A locally managed resource that describes a link type predicate that might otherwise not be directly resolvable.
    /// <see href="http://open-services.net/ns/am#LinkType"></see></summary>
    let LinkType = Namespaced_IRI.parse _namespace_name "LinkType" |> NamespacedName
    /// <summary>
    /// A generic architecture resource.  A resource of this type is likely to be a model or design artifact.
    /// <see href="http://open-services.net/ns/am#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
