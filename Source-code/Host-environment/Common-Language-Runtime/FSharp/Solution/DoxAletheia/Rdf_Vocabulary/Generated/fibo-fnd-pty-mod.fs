namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.MetadataFNDParties.slash

open DoxAletheia

module fibo_fnd_pty_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/PartiesModule"></see>
    /// </summary>
    let PartiesModule = _prefix "PartiesModule"
