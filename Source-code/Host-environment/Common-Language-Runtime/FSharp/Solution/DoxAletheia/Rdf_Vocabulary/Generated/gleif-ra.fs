namespace https.www.gleif.org.ontology.RegistrationAuthority.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_ra =
    let _namespace_name = "https://www.gleif.org/ontology/RegistrationAuthority/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/BusinessRegistry"></see>
    /// </summary>
    let BusinessRegistry =
        Namespaced_IRI.parse _namespace_name "BusinessRegistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/RAregistry"></see>
    /// </summary>
    let RAregistry = Namespaced_IRI.parse _namespace_name "RAregistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/RegistrationAuthority/RegistrationAuthorityCode"></see>
    /// </summary>
    let RegistrationAuthorityCode =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthorityCode" |> NamespacedName
