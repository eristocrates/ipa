namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCapacity.slash

open DoxAletheia

module fibo_fnd_law_lcap =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isPredicatedOn"></see>
    /// </summary>
    let isPredicatedOn = _prefix "isPredicatedOn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualObligation"></see>
    /// </summary>
    let ContractualObligation = _prefix "ContractualObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Claim"></see>
    /// </summary>
    let Claim = _prefix "Claim"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalConstruct"></see>
    /// </summary>
    let LegalConstruct = _prefix "LegalConstruct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentObligation"></see>
    /// </summary>
    let ContingentObligation = _prefix "ContingentObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Duty"></see>
    /// </summary>
    let Duty = _prefix "Duty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImpliedBy"></see>
    /// </summary>
    let isImpliedBy = _prefix "isImpliedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentRight"></see>
    /// </summary>
    let ContingentRight = _prefix "ContingentRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Right"></see>
    /// </summary>
    let Right = _prefix "Right"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implies"></see>
    /// </summary>
    let implies = _prefix "implies"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isConferredOn"></see>
    /// </summary>
    let isConferredOn = _prefix "isConferredOn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualCapability"></see>
    /// </summary>
    let ContractualCapability = _prefix "ContractualCapability"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalCapacity"></see>
    /// </summary>
    let LegalCapacity = _prefix "LegalCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualInterest"></see>
    /// </summary>
    let ContractualInterest = _prefix "ContractualInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualRight"></see>
    /// </summary>
    let ContractualRight = _prefix "ContractualRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasFractionalInterest"></see>
    /// </summary>
    let hasFractionalInterest = _prefix "hasFractionalInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalObligation"></see>
    /// </summary>
    let LegalObligation = _prefix "LegalObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualOption"></see>
    /// </summary>
    let ContractualOption = _prefix "ContractualOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DelegatedLegalAuthority"></see>
    /// </summary>
    let DelegatedLegalAuthority = _prefix "DelegatedLegalAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DeliveryObligation"></see>
    /// </summary>
    let DeliveryObligation = _prefix "DeliveryObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Regulation"></see>
    /// </summary>
    let Regulation = _prefix "Regulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalRight"></see>
    /// </summary>
    let LegalRight = _prefix "LegalRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LiabilityCapacity"></see>
    /// </summary>
    let LiabilityCapacity = _prefix "LiabilityCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/License"></see>
    /// </summary>
    let License = _prefix "License"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensor"></see>
    /// </summary>
    let Licensor = _prefix "Licensor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensee"></see>
    /// </summary>
    let Licensee = _prefix "Licensee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LicenseIdentifier"></see>
    /// </summary>
    let LicenseIdentifier = _prefix "LicenseIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/licenses"></see>
    /// </summary>
    let licenses = _prefix "licenses"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LitigationCapacity"></see>
    /// </summary>
    let LitigationCapacity = _prefix "LitigationCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/NotificationObligation"></see>
    /// </summary>
    let NotificationObligation = _prefix "NotificationObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implements"></see>
    /// </summary>
    let implements = _prefix "implements"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ReportingPolicy"></see>
    /// </summary>
    let ReportingPolicy = _prefix "ReportingPolicy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/SignatoryCapacity"></see>
    /// </summary>
    let SignatoryCapacity = _prefix "SignatoryCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasCapacity"></see>
    /// </summary>
    let hasCapacity = _prefix "hasCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isCapacityOf"></see>
    /// </summary>
    let isCapacityOf = _prefix "isCapacityOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImplementedBy"></see>
    /// </summary>
    let isImplementedBy = _prefix "isImplementedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isLicensedBy"></see>
    /// </summary>
    let isLicensedBy = _prefix "isLicensedBy"
