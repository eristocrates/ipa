namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.CorporateActions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_cae_ce_act =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassifier"></see>
    /// </summary>
    let ActionClassifier =
        Namespaced_IRI.parse _namespace_name "ActionClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassificationScheme"></see>
    /// </summary>
    let ActionClassificationScheme =
        Namespaced_IRI.parse _namespace_name "ActionClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionStatus"></see>
    /// </summary>
    let ActionStatus =
        Namespaced_IRI.parse _namespace_name "ActionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/BusinessStrategyClassifier"></see>
    /// </summary>
    let BusinessStrategyClassifier =
        Namespaced_IRI.parse _namespace_name "BusinessStrategyClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ChangeAction"></see>
    /// </summary>
    let ChangeAction =
        Namespaced_IRI.parse _namespace_name "ChangeAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryCorporateAction"></see>
    /// </summary>
    let MandatoryCorporateAction =
        Namespaced_IRI.parse _namespace_name "MandatoryCorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ClassAction"></see>
    /// </summary>
    let ClassAction =
        Namespaced_IRI.parse _namespace_name "ClassAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/VoluntaryCorporateAction"></see>
    /// </summary>
    let VoluntaryCorporateAction =
        Namespaced_IRI.parse _namespace_name "VoluntaryCorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ConsentSolicitation"></see>
    /// </summary>
    let ConsentSolicitation =
        Namespaced_IRI.parse _namespace_name "ConsentSolicitation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/CorporateAction"></see>
    /// </summary>
    let CorporateAction =
        Namespaced_IRI.parse _namespace_name "CorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/DisclosureAction"></see>
    /// </summary>
    let DisclosureAction =
        Namespaced_IRI.parse _namespace_name "DisclosureAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Divestiture"></see>
    /// </summary>
    let Divestiture =
        Namespaced_IRI.parse _namespace_name "Divestiture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/IncomeOrientedClassifier"></see>
    /// </summary>
    let IncomeOrientedClassifier =
        Namespaced_IRI.parse _namespace_name "IncomeOrientedClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/LegalFormChange"></see>
    /// </summary>
    let LegalFormChange =
        Namespaced_IRI.parse _namespace_name "LegalFormChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Liquidation"></see>
    /// </summary>
    let Liquidation =
        Namespaced_IRI.parse _namespace_name "Liquidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryWithChoiceCorporateAction"></see>
    /// </summary>
    let MandatoryWithChoiceCorporateAction =
        Namespaced_IRI.parse _namespace_name "MandatoryWithChoiceCorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MarketAction"></see>
    /// </summary>
    let MarketAction =
        Namespaced_IRI.parse _namespace_name "MarketAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MergerAcquisition"></see>
    /// </summary>
    let MergerAcquisition =
        Namespaced_IRI.parse _namespace_name "MergerAcquisition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Notification"></see>
    /// </summary>
    let Notification =
        Namespaced_IRI.parse _namespace_name "Notification" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationAddressChange"></see>
    /// </summary>
    let OrganizationAddressChange =
        Namespaced_IRI.parse _namespace_name "OrganizationAddressChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationNameChange"></see>
    /// </summary>
    let OrganizationNameChange =
        Namespaced_IRI.parse _namespace_name "OrganizationNameChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/PriorityIssue"></see>
    /// </summary>
    let PriorityIssue =
        Namespaced_IRI.parse _namespace_name "PriorityIssue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/RegulatoryAction"></see>
    /// </summary>
    let RegulatoryAction =
        Namespaced_IRI.parse _namespace_name "RegulatoryAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/SpinOff"></see>
    /// </summary>
    let SpinOff = Namespaced_IRI.parse _namespace_name "SpinOff" |> NamespacedName
