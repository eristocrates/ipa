namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.CorporateActions.slash

open DoxAletheia

module fibo_cae_ce_act =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassifier"></see>
    /// </summary>
    let ActionClassifier = _prefix "ActionClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassificationScheme"></see>
    /// </summary>
    let ActionClassificationScheme = _prefix "ActionClassificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionStatus"></see>
    /// </summary>
    let ActionStatus = _prefix "ActionStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/BusinessStrategyClassifier"></see>
    /// </summary>
    let BusinessStrategyClassifier = _prefix "BusinessStrategyClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ChangeAction"></see>
    /// </summary>
    let ChangeAction = _prefix "ChangeAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryCorporateAction"></see>
    /// </summary>
    let MandatoryCorporateAction = _prefix "MandatoryCorporateAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ClassAction"></see>
    /// </summary>
    let ClassAction = _prefix "ClassAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/VoluntaryCorporateAction"></see>
    /// </summary>
    let VoluntaryCorporateAction = _prefix "VoluntaryCorporateAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ConsentSolicitation"></see>
    /// </summary>
    let ConsentSolicitation = _prefix "ConsentSolicitation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/CorporateAction"></see>
    /// </summary>
    let CorporateAction = _prefix "CorporateAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/DisclosureAction"></see>
    /// </summary>
    let DisclosureAction = _prefix "DisclosureAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Divestiture"></see>
    /// </summary>
    let Divestiture = _prefix "Divestiture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/IncomeOrientedClassifier"></see>
    /// </summary>
    let IncomeOrientedClassifier = _prefix "IncomeOrientedClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/LegalFormChange"></see>
    /// </summary>
    let LegalFormChange = _prefix "LegalFormChange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Liquidation"></see>
    /// </summary>
    let Liquidation = _prefix "Liquidation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryWithChoiceCorporateAction"></see>
    /// </summary>
    let MandatoryWithChoiceCorporateAction =
        _prefix "MandatoryWithChoiceCorporateAction"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MarketAction"></see>
    /// </summary>
    let MarketAction = _prefix "MarketAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MergerAcquisition"></see>
    /// </summary>
    let MergerAcquisition = _prefix "MergerAcquisition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Notification"></see>
    /// </summary>
    let Notification = _prefix "Notification"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationAddressChange"></see>
    /// </summary>
    let OrganizationAddressChange = _prefix "OrganizationAddressChange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationNameChange"></see>
    /// </summary>
    let OrganizationNameChange = _prefix "OrganizationNameChange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/PriorityIssue"></see>
    /// </summary>
    let PriorityIssue = _prefix "PriorityIssue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/RegulatoryAction"></see>
    /// </summary>
    let RegulatoryAction = _prefix "RegulatoryAction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/SpinOff"></see>
    /// </summary>
    let SpinOff = _prefix "SpinOff"
