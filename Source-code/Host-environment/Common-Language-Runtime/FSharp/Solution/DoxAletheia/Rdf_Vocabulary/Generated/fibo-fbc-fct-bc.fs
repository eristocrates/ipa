namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessCenters.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_bc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCode"></see>
    /// </summary>
    let BusinessCenterCode =
        Namespaced_IRI.parse _namespace_name "BusinessCenterCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCodeScheme"></see>
    /// </summary>
    let BusinessCenterCodeScheme =
        Namespaced_IRI.parse _namespace_name "BusinessCenterCodeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessDayAdjustmentCode"></see>
    /// </summary>
    let BusinessDayAdjustmentCode =
        Namespaced_IRI.parse _namespace_name "BusinessDayAdjustmentCode" |> NamespacedName
