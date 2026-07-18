namespace https.spec.edmcouncil.org.fibo.ontology.BP.SecuritiesIssuance.MetadataBPSecuritiesIssuance.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_bp_iss_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/SecuritiesIssuanceModule"></see>
    /// </summary>
    let SecuritiesIssuanceModule =
        Namespaced_IRI.parse _namespace_name "SecuritiesIssuanceModule" |> NamespacedName
