namespace http.www.nanopub.org.nschema.hash

open DoxAletheia

module nanopub =
    let _namespace_name = "http://www.nanopub.org/nschema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Assertion"></see>
    /// </summary>
    let Assertion = _prefix "Assertion"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Nanopublication"></see>
    /// </summary>
    let Nanopublication = _prefix "Nanopublication"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#Provenance"></see>
    /// </summary>
    let Provenance = _prefix "Provenance"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#PublicationInfo"></see>
    /// </summary>
    let PublicationInfo = _prefix "PublicationInfo"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasAssertion"></see>
    /// </summary>
    let hasAssertion = _prefix "hasAssertion"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasProvenance"></see>
    /// </summary>
    let hasProvenance = _prefix "hasProvenance"
    /// <summary>
    ///   <see href="http://www.nanopub.org/nschema#hasPublicationInfo"></see>
    /// </summary>
    let hasPublicationInfo = _prefix "hasPublicationInfo"
