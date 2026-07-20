namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.MetadataSECSecurities.slash

open DoxAletheia

module fibo_sec_sec_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/SecuritiesModule"></see>
    /// </summary>
    let SecuritiesModule = _prefix "SecuritiesModule"
