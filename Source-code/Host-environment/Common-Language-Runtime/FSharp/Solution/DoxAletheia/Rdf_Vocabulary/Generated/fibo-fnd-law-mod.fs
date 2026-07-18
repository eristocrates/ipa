namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.MetadataFNDLaw.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_law_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/LawModule"></see>
    /// </summary>
    let LawModule = Namespaced_IRI.parse _namespace_name "LawModule" |> NamespacedName
