namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesMasterAgreements.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_ma =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/AccountChangeNotificationObligation"></see>
    /// </summary>
    let AccountChangeNotificationObligation =
        Namespaced_IRI.parse _namespace_name "AccountChangeNotificationObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeCreditSupportAgreement"></see>
    /// </summary>
    let DerivativeCreditSupportAgreement =
        Namespaced_IRI.parse _namespace_name "DerivativeCreditSupportAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeMasterAgreement"></see>
    /// </summary>
    let DerivativeMasterAgreement =
        Namespaced_IRI.parse _namespace_name "DerivativeMasterAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/MasterAgreementEarlyTerminationRight"></see>
    /// </summary>
    let MasterAgreementEarlyTerminationRight =
        Namespaced_IRI.parse _namespace_name "MasterAgreementEarlyTerminationRight" |> NamespacedName
