namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.MetadataSECEquities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_eq_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/EquitiesModule"></see>
    /// </summary>
    let EquitiesModule =
        Namespaced_IRI.parse _namespace_name "EquitiesModule" |> NamespacedName
