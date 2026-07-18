namespace http.semanticturkey.uniroma2.it.ns.mdr.hash

open DoxAletheia.Rdf_Vocabulary

module mdr =
    let _namespace_name = "http://semanticturkey.uniroma2.it/ns/mdr#"

    /// <summary>
    /// a method to dereference the identifiers defined by some dataset
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#DereferenciationSystem"></see></summary>
    let DereferenciationSystem =
        Namespaced_IRI.parse _namespace_name "DereferenciationSystem" |> NamespacedName

    /// <summary>
    /// a limitation of some SPARQL endpoint. This class is an extension point for recording and subsequently reacting in an application-specific manner to any perceived limitation of an endpoint. The focus is on limitations that cannot objectively be defined a-priori, as they rather depend on a number of boundary conditions, such as the task, the underlying access technology and even the specific queries run to perform the task. Such limitations can then be defined in application-specific ontologies reusing this vocabulary
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#SparqlEndpointLimitation"></see></summary>
    let SparqlEndpointLimitation =
        Namespaced_IRI.parse _namespace_name "SparqlEndpointLimitation" |> NamespacedName

    /// <summary>
    /// relates a void:Dataset to a resource describing a method to dereference the identifiers defined by that dataset. Currently only two instances: :standardDereferenciation and :noDereferenciation are available, however this will be extended soon to account for versioning and other URI-transformation needs
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#dereferenciationSystem"></see></summary>
    let dereferenciationSystem =
        Namespaced_IRI.parse _namespace_name "dereferenciationSystem" |> NamespacedName

    /// <summary>
    /// missing support for any dereferenciation method
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#noDereferenciation"></see></summary>
    let noDereferenciation =
        Namespaced_IRI.parse _namespace_name "noDereferenciation" |> NamespacedName

    /// <summary>
    /// relates a SPARQL endpoint to a resource describing some limitation of that endpoint
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#sparqlEndpointLimitation"></see></summary>
    let sparqlEndpointLimitation =
        Namespaced_IRI.parse _namespace_name "sparqlEndpointLimitation" |> NamespacedName

    /// <summary>
    /// the method to dereference identifiers by means of HTTP resolution
    /// <see href="http://semanticturkey.uniroma2.it/ns/mdr#standardDereferenciation"></see></summary>
    let standardDereferenciation =
        Namespaced_IRI.parse _namespace_name "standardDereferenciation" |> NamespacedName
