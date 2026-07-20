namespace http.open_services.net.ns.core.trspatch.hash

open DoxAletheia

module trs_patch =
    let _namespace_name = "http://open-services.net/ns/core/trspatch#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// HTTP entity tag of resource immediately after this change.
    /// <see href="http://open-services.net/ns/core/trspatch#afterETag"></see></summary>
    let afterETag = _prefix "afterETag"
    /// <summary>
    /// HTTP entity tag of resource immediately before this change.
    /// <see href="http://open-services.net/ns/core/trspatch#beforeETag"></see></summary>
    let beforeETag = _prefix "beforeETag"
    /// <summary>
    /// URI of antecedent resource for trs:Creation Change Events.
    /// <see href="http://open-services.net/ns/core/trspatch#createdFrom"></see></summary>
    let createdFrom = _prefix "createdFrom"
    /// <summary>
    /// Patch directives describing a modification to the resource's RDF representation.
    /// <see href="http://open-services.net/ns/core/trspatch#rdfPatch"></see></summary>
    let rdfPatch = _prefix "rdfPatch"
