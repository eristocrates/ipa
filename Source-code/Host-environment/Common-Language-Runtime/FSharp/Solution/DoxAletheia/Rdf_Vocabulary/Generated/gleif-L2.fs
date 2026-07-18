namespace https.www.gleif.org.ontology.L2.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_L2 =
    let _namespace_name = "https://www.gleif.org/ontology/L2/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusAnnulled"></see>
    /// </summary>
    let RegistrationStatusAnnulled =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusAnnulled" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusDuplicate"></see>
    /// </summary>
    let RegistrationStatusDuplicate =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusDuplicate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusLapsed"></see>
    /// </summary>
    let RegistrationStatusLapsed =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusLapsed" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingArchival"></see>
    /// </summary>
    let RegistrationStatusPendingArchival =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusPendingArchival" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingTransfer"></see>
    /// </summary>
    let RegistrationStatusPendingTransfer =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusPendingTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPublished"></see>
    /// </summary>
    let RegistrationStatusPublished =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusPublished" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusRetired"></see>
    /// </summary>
    let RegistrationStatusRetired =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusRetired" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardIFRS"></see>
    /// </summary>
    let AccountingStandardIFRS =
        Namespaced_IRI.parse _namespace_name "AccountingStandardIFRS" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardOtherAccountingStandard"></see>
    /// </summary>
    let AccountingStandardOtherAccountingStandard =
        Namespaced_IRI.parse _namespace_name "AccountingStandardOtherAccountingStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardUSGAAP"></see>
    /// </summary>
    let AccountingStandardUSGAAP =
        Namespaced_IRI.parse _namespace_name "AccountingStandardUSGAAP" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindAccountsFiling"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindAccountsFiling =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKindAccountsFiling" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindContracts"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindContracts =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKindContracts" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindOtherOfficialDocuments"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindOtherOfficialDocuments =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKindOtherOfficialDocuments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindRegulatoryFiling"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindRegulatoryFiling =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKindRegulatoryFiling" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindSupportingDocuments"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindSupportingDocuments =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKindSupportingDocuments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatusActive"></see>
    /// </summary>
    let RelationshipStatusActive =
        Namespaced_IRI.parse _namespace_name "RelationshipStatusActive" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatusInactive"></see>
    /// </summary>
    let RelationshipStatusInactive =
        Namespaced_IRI.parse _namespace_name "RelationshipStatusInactive" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasRelationshipStatus"></see>
    /// </summary>
    let hasRelationshipStatus =
        Namespaced_IRI.parse _namespace_name "hasRelationshipStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatus"></see>
    /// </summary>
    let RelationshipStatus =
        Namespaced_IRI.parse _namespace_name "RelationshipStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasChild"></see>
    /// </summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasParent"></see>
    /// </summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasRelationshipPeriod"></see>
    /// </summary>
    let hasRelationshipPeriod =
        Namespaced_IRI.parse _namespace_name "hasRelationshipPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingConsolidation"></see>
    /// </summary>
    let AccountingConsolidation =
        Namespaced_IRI.parse _namespace_name "AccountingConsolidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasAccountingStandard"></see>
    /// </summary>
    let hasAccountingStandard =
        Namespaced_IRI.parse _namespace_name "hasAccountingStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandard"></see>
    /// </summary>
    let AccountingStandard =
        Namespaced_IRI.parse _namespace_name "AccountingStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/DirectConsolidation"></see>
    /// </summary>
    let DirectConsolidation =
        Namespaced_IRI.parse _namespace_name "DirectConsolidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/InternationalBranchRelationship"></see>
    /// </summary>
    let InternationalBranchRelationship =
        Namespaced_IRI.parse _namespace_name "InternationalBranchRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/LegalEntityRelationshipRecord"></see>
    /// </summary>
    let LegalEntityRelationshipRecord =
        Namespaced_IRI.parse _namespace_name "LegalEntityRelationshipRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationDocuments"></see>
    /// </summary>
    let hasValidationDocuments =
        Namespaced_IRI.parse _namespace_name "hasValidationDocuments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKind"></see>
    /// </summary>
    let RelationshipValidationDocumentsKind =
        Namespaced_IRI.parse _namespace_name "RelationshipValidationDocumentsKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasDocumentFilingPeriod"></see>
    /// </summary>
    let hasDocumentFilingPeriod =
        Namespaced_IRI.parse _namespace_name "hasDocumentFilingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasAccountingPeriod"></see>
    /// </summary>
    let hasAccountingPeriod =
        Namespaced_IRI.parse _namespace_name "hasAccountingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationSources"></see>
    /// </summary>
    let hasValidationSources =
        Namespaced_IRI.parse _namespace_name "hasValidationSources" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationReference"></see>
    /// </summary>
    let hasValidationReference =
        Namespaced_IRI.parse _namespace_name "hasValidationReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus =
        Namespaced_IRI.parse _namespace_name "RegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/UltimateConsolidation"></see>
    /// </summary>
    let UltimateConsolidation =
        Namespaced_IRI.parse _namespace_name "UltimateConsolidation" |> NamespacedName
