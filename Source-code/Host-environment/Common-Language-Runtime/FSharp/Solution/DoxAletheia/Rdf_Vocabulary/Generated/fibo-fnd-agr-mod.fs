namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.MetadataFNDAgreements.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_agr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/AgreementsModule"></see>
    /// </summary>
    let AgreementsModule =
        Namespaced_IRI.parse _namespace_name "AgreementsModule" |> NamespacedName
