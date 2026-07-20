namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.ControlParties.slash

open DoxAletheia

module fibo_be_oac_cpty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ContractualControl"></see>
    /// </summary>
    let ContractualControl = _prefix "ContractualControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControlledParty"></see>
    /// </summary>
    let ControlledParty = _prefix "ControlledParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControllingAlliance"></see>
    /// </summary>
    let ControllingAlliance = _prefix "ControllingAlliance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/CourtAppointedControl"></see>
    /// </summary>
    let CourtAppointedControl = _prefix "CourtAppointedControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeFactoControllingInterestParty"></see>
    /// </summary>
    let DeFactoControllingInterestParty = _prefix "DeFactoControllingInterestParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeJureControllingInterestParty"></see>
    /// </summary>
    let DeJureControllingInterestParty = _prefix "DeJureControllingInterestParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/EntityControllingParty"></see>
    /// </summary>
    let EntityControllingParty = _prefix "EntityControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControl"></see>
    /// </summary>
    let InfluenceBasedDeFactoControl = _prefix "InfluenceBasedDeFactoControl"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControllingParty"></see>
    /// </summary>
    let InfluenceBasedDeFactoControllingParty =
        _prefix "InfluenceBasedDeFactoControllingParty"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControl"></see>
    /// </summary>
    let InvestmentBasedDeFactoControl = _prefix "InvestmentBasedDeFactoControl"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControllingInterestParty"></see>
    /// </summary>
    let InvestmentBasedDeFactoControllingInterestParty =
        _prefix "InvestmentBasedDeFactoControllingInterestParty"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/JointControllingParty"></see>
    /// </summary>
    let JointControllingParty = _prefix "JointControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/SoleControllingParty"></see>
    /// </summary>
    let SoleControllingParty = _prefix "SoleControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/MajorityControllingParty"></see>
    /// </summary>
    let MajorityControllingParty = _prefix "MajorityControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/Receiver"></see>
    /// </summary>
    let Receiver = _prefix "Receiver"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/TotalOwner"></see>
    /// </summary>
    let TotalOwner = _prefix "TotalOwner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/advises"></see>
    /// </summary>
    let advises = _prefix "advises"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isAdvisedBy"></see>
    /// </summary>
    let isAdvisedBy = _prefix "isAdvisedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasControllingOrganizationMember"></see>
    /// </summary>
    let hasControllingOrganizationMember = _prefix "hasControllingOrganizationMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isControllingMemberOf"></see>
    /// </summary>
    let isControllingMemberOf = _prefix "isControllingMemberOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasMajorityControllingParty"></see>
    /// </summary>
    let hasMajorityControllingParty = _prefix "hasMajorityControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isBasedOnInvestmentEquity"></see>
    /// </summary>
    let isBasedOnInvestmentEquity = _prefix "isBasedOnInvestmentEquity"
