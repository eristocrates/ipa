namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.Parties.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_pty_pty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentificationScheme"></see>
    /// </summary>
    let PartyRoleIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "PartyRoleIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentifier"></see>
    /// </summary>
    let PartyRoleIdentifier =
        Namespaced_IRI.parse _namespace_name "PartyRoleIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentificationScheme"></see>
    /// </summary>
    let TaxIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "TaxIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentifier"></see>
    /// </summary>
    let TaxIdentifier =
        Namespaced_IRI.parse _namespace_name "TaxIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasMailingAddress"></see>
    /// </summary>
    let hasMailingAddress =
        Namespaced_IRI.parse _namespace_name "hasMailingAddress" |> NamespacedName
