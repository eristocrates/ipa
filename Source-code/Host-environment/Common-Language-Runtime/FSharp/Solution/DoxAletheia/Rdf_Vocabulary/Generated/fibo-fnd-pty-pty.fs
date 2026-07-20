namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.Parties.slash

open DoxAletheia

module fibo_fnd_pty_pty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentificationScheme"></see>
    /// </summary>
    let PartyRoleIdentificationScheme = _prefix "PartyRoleIdentificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentifier"></see>
    /// </summary>
    let PartyRoleIdentifier = _prefix "PartyRoleIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentificationScheme"></see>
    /// </summary>
    let TaxIdentificationScheme = _prefix "TaxIdentificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentifier"></see>
    /// </summary>
    let TaxIdentifier = _prefix "TaxIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasMailingAddress"></see>
    /// </summary>
    let hasMailingAddress = _prefix "hasMailingAddress"
