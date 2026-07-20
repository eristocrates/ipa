namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.MetadataSECEquities.slash

open DoxAletheia

module fibo_sec_eq_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/EquitiesModule"></see>
    /// </summary>
    let EquitiesModule = _prefix "EquitiesModule"
