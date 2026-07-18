namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCapacity.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_law_lcap =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isPredicatedOn"></see>
    /// </summary>
    let isPredicatedOn =
        Namespaced_IRI.parse _namespace_name "isPredicatedOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualObligation"></see>
    /// </summary>
    let ContractualObligation =
        Namespaced_IRI.parse _namespace_name "ContractualObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Claim"></see>
    /// </summary>
    let Claim = Namespaced_IRI.parse _namespace_name "Claim" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalConstruct"></see>
    /// </summary>
    let LegalConstruct =
        Namespaced_IRI.parse _namespace_name "LegalConstruct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentObligation"></see>
    /// </summary>
    let ContingentObligation =
        Namespaced_IRI.parse _namespace_name "ContingentObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Duty"></see>
    /// </summary>
    let Duty = Namespaced_IRI.parse _namespace_name "Duty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImpliedBy"></see>
    /// </summary>
    let isImpliedBy =
        Namespaced_IRI.parse _namespace_name "isImpliedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentRight"></see>
    /// </summary>
    let ContingentRight =
        Namespaced_IRI.parse _namespace_name "ContingentRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Right"></see>
    /// </summary>
    let Right = Namespaced_IRI.parse _namespace_name "Right" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implies"></see>
    /// </summary>
    let implies = Namespaced_IRI.parse _namespace_name "implies" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isConferredOn"></see>
    /// </summary>
    let isConferredOn =
        Namespaced_IRI.parse _namespace_name "isConferredOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualCapability"></see>
    /// </summary>
    let ContractualCapability =
        Namespaced_IRI.parse _namespace_name "ContractualCapability" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalCapacity"></see>
    /// </summary>
    let LegalCapacity =
        Namespaced_IRI.parse _namespace_name "LegalCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualInterest"></see>
    /// </summary>
    let ContractualInterest =
        Namespaced_IRI.parse _namespace_name "ContractualInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualRight"></see>
    /// </summary>
    let ContractualRight =
        Namespaced_IRI.parse _namespace_name "ContractualRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasFractionalInterest"></see>
    /// </summary>
    let hasFractionalInterest =
        Namespaced_IRI.parse _namespace_name "hasFractionalInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalObligation"></see>
    /// </summary>
    let LegalObligation =
        Namespaced_IRI.parse _namespace_name "LegalObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualOption"></see>
    /// </summary>
    let ContractualOption =
        Namespaced_IRI.parse _namespace_name "ContractualOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DelegatedLegalAuthority"></see>
    /// </summary>
    let DelegatedLegalAuthority =
        Namespaced_IRI.parse _namespace_name "DelegatedLegalAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DeliveryObligation"></see>
    /// </summary>
    let DeliveryObligation =
        Namespaced_IRI.parse _namespace_name "DeliveryObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Regulation"></see>
    /// </summary>
    let Regulation = Namespaced_IRI.parse _namespace_name "Regulation" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalRight"></see>
    /// </summary>
    let LegalRight = Namespaced_IRI.parse _namespace_name "LegalRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LiabilityCapacity"></see>
    /// </summary>
    let LiabilityCapacity =
        Namespaced_IRI.parse _namespace_name "LiabilityCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/License"></see>
    /// </summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensor"></see>
    /// </summary>
    let Licensor = Namespaced_IRI.parse _namespace_name "Licensor" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensee"></see>
    /// </summary>
    let Licensee = Namespaced_IRI.parse _namespace_name "Licensee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LicenseIdentifier"></see>
    /// </summary>
    let LicenseIdentifier =
        Namespaced_IRI.parse _namespace_name "LicenseIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/licenses"></see>
    /// </summary>
    let licenses = Namespaced_IRI.parse _namespace_name "licenses" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LitigationCapacity"></see>
    /// </summary>
    let LitigationCapacity =
        Namespaced_IRI.parse _namespace_name "LitigationCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/NotificationObligation"></see>
    /// </summary>
    let NotificationObligation =
        Namespaced_IRI.parse _namespace_name "NotificationObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implements"></see>
    /// </summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ReportingPolicy"></see>
    /// </summary>
    let ReportingPolicy =
        Namespaced_IRI.parse _namespace_name "ReportingPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/SignatoryCapacity"></see>
    /// </summary>
    let SignatoryCapacity =
        Namespaced_IRI.parse _namespace_name "SignatoryCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasCapacity"></see>
    /// </summary>
    let hasCapacity =
        Namespaced_IRI.parse _namespace_name "hasCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isCapacityOf"></see>
    /// </summary>
    let isCapacityOf =
        Namespaced_IRI.parse _namespace_name "isCapacityOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImplementedBy"></see>
    /// </summary>
    let isImplementedBy =
        Namespaced_IRI.parse _namespace_name "isImplementedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isLicensedBy"></see>
    /// </summary>
    let isLicensedBy =
        Namespaced_IRI.parse _namespace_name "isLicensedBy" |> NamespacedName
