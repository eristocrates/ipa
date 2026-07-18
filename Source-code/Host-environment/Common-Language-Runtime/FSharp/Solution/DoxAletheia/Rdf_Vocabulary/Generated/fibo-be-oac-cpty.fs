namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.ControlParties.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_cpty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ContractualControl"></see>
    /// </summary>
    let ContractualControl =
        Namespaced_IRI.parse _namespace_name "ContractualControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControlledParty"></see>
    /// </summary>
    let ControlledParty =
        Namespaced_IRI.parse _namespace_name "ControlledParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControllingAlliance"></see>
    /// </summary>
    let ControllingAlliance =
        Namespaced_IRI.parse _namespace_name "ControllingAlliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/CourtAppointedControl"></see>
    /// </summary>
    let CourtAppointedControl =
        Namespaced_IRI.parse _namespace_name "CourtAppointedControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeFactoControllingInterestParty"></see>
    /// </summary>
    let DeFactoControllingInterestParty =
        Namespaced_IRI.parse _namespace_name "DeFactoControllingInterestParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeJureControllingInterestParty"></see>
    /// </summary>
    let DeJureControllingInterestParty =
        Namespaced_IRI.parse _namespace_name "DeJureControllingInterestParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/EntityControllingParty"></see>
    /// </summary>
    let EntityControllingParty =
        Namespaced_IRI.parse _namespace_name "EntityControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControl"></see>
    /// </summary>
    let InfluenceBasedDeFactoControl =
        Namespaced_IRI.parse _namespace_name "InfluenceBasedDeFactoControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControllingParty"></see>
    /// </summary>
    let InfluenceBasedDeFactoControllingParty =
        Namespaced_IRI.parse _namespace_name "InfluenceBasedDeFactoControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControl"></see>
    /// </summary>
    let InvestmentBasedDeFactoControl =
        Namespaced_IRI.parse _namespace_name "InvestmentBasedDeFactoControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControllingInterestParty"></see>
    /// </summary>
    let InvestmentBasedDeFactoControllingInterestParty =
        Namespaced_IRI.parse _namespace_name "InvestmentBasedDeFactoControllingInterestParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/JointControllingParty"></see>
    /// </summary>
    let JointControllingParty =
        Namespaced_IRI.parse _namespace_name "JointControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/SoleControllingParty"></see>
    /// </summary>
    let SoleControllingParty =
        Namespaced_IRI.parse _namespace_name "SoleControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/MajorityControllingParty"></see>
    /// </summary>
    let MajorityControllingParty =
        Namespaced_IRI.parse _namespace_name "MajorityControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/Receiver"></see>
    /// </summary>
    let Receiver = Namespaced_IRI.parse _namespace_name "Receiver" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/TotalOwner"></see>
    /// </summary>
    let TotalOwner = Namespaced_IRI.parse _namespace_name "TotalOwner" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/advises"></see>
    /// </summary>
    let advises = Namespaced_IRI.parse _namespace_name "advises" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isAdvisedBy"></see>
    /// </summary>
    let isAdvisedBy =
        Namespaced_IRI.parse _namespace_name "isAdvisedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasControllingOrganizationMember"></see>
    /// </summary>
    let hasControllingOrganizationMember =
        Namespaced_IRI.parse _namespace_name "hasControllingOrganizationMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isControllingMemberOf"></see>
    /// </summary>
    let isControllingMemberOf =
        Namespaced_IRI.parse _namespace_name "isControllingMemberOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasMajorityControllingParty"></see>
    /// </summary>
    let hasMajorityControllingParty =
        Namespaced_IRI.parse _namespace_name "hasMajorityControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isBasedOnInvestmentEquity"></see>
    /// </summary>
    let isBasedOnInvestmentEquity =
        Namespaced_IRI.parse _namespace_name "isBasedOnInvestmentEquity" |> NamespacedName
