namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesMasterAgreements.slash

open DoxAletheia

module fibo_der_drc_ma =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/AccountChangeNotificationObligation"></see>
    /// </summary>
    let AccountChangeNotificationObligation =
        _prefix "AccountChangeNotificationObligation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeCreditSupportAgreement"></see>
    /// </summary>
    let DerivativeCreditSupportAgreement = _prefix "DerivativeCreditSupportAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeMasterAgreement"></see>
    /// </summary>
    let DerivativeMasterAgreement = _prefix "DerivativeMasterAgreement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/MasterAgreementEarlyTerminationRight"></see>
    /// </summary>
    let MasterAgreementEarlyTerminationRight =
        _prefix "MasterAgreementEarlyTerminationRight"
