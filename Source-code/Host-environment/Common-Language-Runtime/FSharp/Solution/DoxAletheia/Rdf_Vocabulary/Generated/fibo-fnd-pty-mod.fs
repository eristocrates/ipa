namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.MetadataFNDParties.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_pty_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/PartiesModule"></see>
    /// </summary>
    let PartiesModule =
        Namespaced_IRI.parse _namespace_name "PartiesModule" |> NamespacedName
