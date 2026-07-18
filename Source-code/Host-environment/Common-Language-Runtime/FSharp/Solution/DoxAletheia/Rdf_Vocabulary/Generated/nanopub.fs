namespace http.www.nanopub.org.nschema.hash

open DoxAletheia.Rdf_Vocabulary

module nanopub =
    let _namespace_name = "http://www.nanopub.org/nschema#"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Assertion"></see>
    /// </summary>
    let Assertion = Namespaced_IRI.parse _namespace_name "Assertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Nanopublication"></see>
    /// </summary>
    let Nanopublication =
        Namespaced_IRI.parse _namespace_name "Nanopublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Provenance"></see>
    /// </summary>
    let Provenance = Namespaced_IRI.parse _namespace_name "Provenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#PublicationInfo"></see>
    /// </summary>
    let PublicationInfo =
        Namespaced_IRI.parse _namespace_name "PublicationInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasAssertion"></see>
    /// </summary>
    let hasAssertion =
        Namespaced_IRI.parse _namespace_name "hasAssertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasProvenance"></see>
    /// </summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasPublicationInfo"></see>
    /// </summary>
    let hasPublicationInfo =
        Namespaced_IRI.parse _namespace_name "hasPublicationInfo" |> NamespacedName
