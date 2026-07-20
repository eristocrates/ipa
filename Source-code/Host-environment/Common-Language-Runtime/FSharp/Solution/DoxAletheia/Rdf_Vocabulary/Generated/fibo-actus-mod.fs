namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.MetadataACTUS.slash

open DoxAletheia

module fibo_actus_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/ACTUSDomain"></see>
    /// </summary>
    let ACTUSDomain = _prefix "ACTUSDomain"
