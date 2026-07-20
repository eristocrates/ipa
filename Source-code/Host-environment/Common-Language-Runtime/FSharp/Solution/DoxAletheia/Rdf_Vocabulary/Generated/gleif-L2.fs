namespace https.www.gleif.org.ontology.L2.slash

open DoxAletheia

module gleif_L2 =
    let _namespace_name = "https://www.gleif.org/ontology/L2/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusAnnulled"></see>
    /// </summary>
    let RegistrationStatusAnnulled = _prefix "RegistrationStatusAnnulled"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusDuplicate"></see>
    /// </summary>
    let RegistrationStatusDuplicate = _prefix "RegistrationStatusDuplicate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusLapsed"></see>
    /// </summary>
    let RegistrationStatusLapsed = _prefix "RegistrationStatusLapsed"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingArchival"></see>
    /// </summary>
    let RegistrationStatusPendingArchival = _prefix "RegistrationStatusPendingArchival"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingTransfer"></see>
    /// </summary>
    let RegistrationStatusPendingTransfer = _prefix "RegistrationStatusPendingTransfer"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusPublished"></see>
    /// </summary>
    let RegistrationStatusPublished = _prefix "RegistrationStatusPublished"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatusRetired"></see>
    /// </summary>
    let RegistrationStatusRetired = _prefix "RegistrationStatusRetired"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardIFRS"></see>
    /// </summary>
    let AccountingStandardIFRS = _prefix "AccountingStandardIFRS"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardOtherAccountingStandard"></see>
    /// </summary>
    let AccountingStandardOtherAccountingStandard =
        _prefix "AccountingStandardOtherAccountingStandard"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandardUSGAAP"></see>
    /// </summary>
    let AccountingStandardUSGAAP = _prefix "AccountingStandardUSGAAP"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindAccountsFiling"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindAccountsFiling =
        _prefix "RelationshipValidationDocumentsKindAccountsFiling"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindContracts"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindContracts =
        _prefix "RelationshipValidationDocumentsKindContracts"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindOtherOfficialDocuments"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindOtherOfficialDocuments =
        _prefix "RelationshipValidationDocumentsKindOtherOfficialDocuments"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindRegulatoryFiling"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindRegulatoryFiling =
        _prefix "RelationshipValidationDocumentsKindRegulatoryFiling"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindSupportingDocuments"></see>
    /// </summary>
    let RelationshipValidationDocumentsKindSupportingDocuments =
        _prefix "RelationshipValidationDocumentsKindSupportingDocuments"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatusActive"></see>
    /// </summary>
    let RelationshipStatusActive = _prefix "RelationshipStatusActive"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatusInactive"></see>
    /// </summary>
    let RelationshipStatusInactive = _prefix "RelationshipStatusInactive"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasRelationshipStatus"></see>
    /// </summary>
    let hasRelationshipStatus = _prefix "hasRelationshipStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipStatus"></see>
    /// </summary>
    let RelationshipStatus = _prefix "RelationshipStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasChild"></see>
    /// </summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasParent"></see>
    /// </summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasRelationshipPeriod"></see>
    /// </summary>
    let hasRelationshipPeriod = _prefix "hasRelationshipPeriod"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingConsolidation"></see>
    /// </summary>
    let AccountingConsolidation = _prefix "AccountingConsolidation"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasAccountingStandard"></see>
    /// </summary>
    let hasAccountingStandard = _prefix "hasAccountingStandard"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/AccountingStandard"></see>
    /// </summary>
    let AccountingStandard = _prefix "AccountingStandard"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/DirectConsolidation"></see>
    /// </summary>
    let DirectConsolidation = _prefix "DirectConsolidation"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/InternationalBranchRelationship"></see>
    /// </summary>
    let InternationalBranchRelationship = _prefix "InternationalBranchRelationship"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/LegalEntityRelationshipRecord"></see>
    /// </summary>
    let LegalEntityRelationshipRecord = _prefix "LegalEntityRelationshipRecord"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationDocuments"></see>
    /// </summary>
    let hasValidationDocuments = _prefix "hasValidationDocuments"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKind"></see>
    /// </summary>
    let RelationshipValidationDocumentsKind =
        _prefix "RelationshipValidationDocumentsKind"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasDocumentFilingPeriod"></see>
    /// </summary>
    let hasDocumentFilingPeriod = _prefix "hasDocumentFilingPeriod"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasAccountingPeriod"></see>
    /// </summary>
    let hasAccountingPeriod = _prefix "hasAccountingPeriod"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationSources"></see>
    /// </summary>
    let hasValidationSources = _prefix "hasValidationSources"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/hasValidationReference"></see>
    /// </summary>
    let hasValidationReference = _prefix "hasValidationReference"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus = _prefix "RegistrationStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L2/UltimateConsolidation"></see>
    /// </summary>
    let UltimateConsolidation = _prefix "UltimateConsolidation"
