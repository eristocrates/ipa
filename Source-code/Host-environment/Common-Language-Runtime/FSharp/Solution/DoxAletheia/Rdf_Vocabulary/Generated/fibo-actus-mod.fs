namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.MetadataACTUS.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_actus_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/ACTUSDomain"></see>
    /// </summary>
    let ACTUSDomain =
        Namespaced_IRI.parse _namespace_name "ACTUSDomain" |> NamespacedName
