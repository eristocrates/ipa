namespace https.www.gleif.org.ontology.RegistrationAuthority.slash

open DoxAletheia

module gleif_ra =
    let _namespace_name = "https://www.gleif.org/ontology/RegistrationAuthority/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/BusinessRegistry"></see>
    /// </summary>
    let BusinessRegistry = _prefix "BusinessRegistry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/RAregistry"></see>
    /// </summary>
    let RAregistry = _prefix "RAregistry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/RegistrationAuthorityCode"></see>
    /// </summary>
    let RegistrationAuthorityCode = _prefix "RegistrationAuthorityCode"
