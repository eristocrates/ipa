namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessCenters.slash

open DoxAletheia

module fibo_fbc_fct_bc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCode"></see>
    /// </summary>
    let BusinessCenterCode = _prefix "BusinessCenterCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCodeScheme"></see>
    /// </summary>
    let BusinessCenterCodeScheme = _prefix "BusinessCenterCodeScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessDayAdjustmentCode"></see>
    /// </summary>
    let BusinessDayAdjustmentCode = _prefix "BusinessDayAdjustmentCode"
