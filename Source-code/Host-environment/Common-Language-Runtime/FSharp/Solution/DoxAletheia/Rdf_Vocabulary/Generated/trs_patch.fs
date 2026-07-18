namespace http.open_services.net.ns.core.trspatch.hash

open DoxAletheia.Rdf_Vocabulary

module trs_patch =
    let _namespace_name = "http://open-services.net/ns/core/trspatch#"
    /// <summary>
    /// HTTP entity tag of resource immediately after this change.
    /// <see href="http://open-services.net/ns/core/trspatch#afterETag"></see></summary>
    let afterETag = Namespaced_IRI.parse _namespace_name "afterETag" |> NamespacedName
    /// <summary>
    /// HTTP entity tag of resource immediately before this change.
    /// <see href="http://open-services.net/ns/core/trspatch#beforeETag"></see></summary>
    let beforeETag = Namespaced_IRI.parse _namespace_name "beforeETag" |> NamespacedName

    /// <summary>
    /// URI of antecedent resource for trs:Creation Change Events.
    /// <see href="http://open-services.net/ns/core/trspatch#createdFrom"></see></summary>
    let createdFrom =
        Namespaced_IRI.parse _namespace_name "createdFrom" |> NamespacedName

    /// <summary>
    /// Patch directives describing a modification to the resource's RDF representation.
    /// <see href="http://open-services.net/ns/core/trspatch#rdfPatch"></see></summary>
    let rdfPatch = Namespaced_IRI.parse _namespace_name "rdfPatch" |> NamespacedName
