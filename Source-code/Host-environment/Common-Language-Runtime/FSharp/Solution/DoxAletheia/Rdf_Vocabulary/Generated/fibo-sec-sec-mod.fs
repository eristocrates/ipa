namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.MetadataSECSecurities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/SecuritiesModule"></see>
    /// </summary>
    let SecuritiesModule =
        Namespaced_IRI.parse _namespace_name "SecuritiesModule" |> NamespacedName
