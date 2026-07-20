namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LEIEntities.slash

open DoxAletheia

module fibo_be_le_lei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingFramework"></see>
    /// </summary>
    let AccountingFramework = _prefix "AccountingFramework"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipQualifier"></see>
    /// </summary>
    let RelationshipQualifier = _prefix "RelationshipQualifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingPeriod"></see>
    /// </summary>
    let AccountingPeriod = _prefix "AccountingPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipPeriodQualifier"></see>
    /// </summary>
    let RelationshipPeriodQualifier = _prefix "RelationshipPeriodQualifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ContractuallyCapableEntity"></see>
    /// </summary>
    let ContractuallyCapableEntity = _prefix "ContractuallyCapableEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/DocumentFilingPeriod"></see>
    /// </summary>
    let DocumentFilingPeriod = _prefix "DocumentFilingPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalForm"></see>
    /// </summary>
    let EntityLegalForm = _prefix "EntityLegalForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalFormAbbreviation"></see>
    /// </summary>
    let hasLegalFormAbbreviation = _prefix "hasLegalFormAbbreviation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedLegalFormAbbreviation"></see>
    /// </summary>
    let hasTransliteratedLegalFormAbbreviation =
        _prefix "hasTransliteratedLegalFormAbbreviation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedName"></see>
    /// </summary>
    let hasTransliteratedName = _prefix "hasTransliteratedName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormScheme"></see>
    /// </summary>
    let EntityLegalFormScheme = _prefix "EntityLegalFormScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormIdentifier"></see>
    /// </summary>
    let EntityLegalFormIdentifier = _prefix "EntityLegalFormIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/GenerallyAcceptedAccountingPrinciples"></see>
    /// </summary>
    let GenerallyAcceptedAccountingPrinciples =
        _prefix "GenerallyAcceptedAccountingPrinciples"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO17442-CodeSet"></see>
    /// </summary>
    let ``ISO17442-CodeSet`` = _prefix "ISO17442-CodeSet"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifierScheme"></see>
    /// </summary>
    let LegalEntityIdentifierScheme = _prefix "LegalEntityIdentifierScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO20275-CodeSet"></see>
    /// </summary>
    let ``ISO20275-CodeSet`` = _prefix "ISO20275-CodeSet"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/InternationalFinancialReportingStandard"></see>
    /// </summary>
    let InternationalFinancialReportingStandard =
        _prefix "InternationalFinancialReportingStandard"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LEIRegisteredEntity"></see>
    /// </summary>
    let LEIRegisteredEntity = _prefix "LEIRegisteredEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifier"></see>
    /// </summary>
    let LegalEntityIdentifier = _prefix "LegalEntityIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/OtherAccountingFramework"></see>
    /// </summary>
    let OtherAccountingFramework = _prefix "OtherAccountingFramework"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipRecord"></see>
    /// </summary>
    let RelationshipRecord = _prefix "RelationshipRecord"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isQuantifiedBy"></see>
    /// </summary>
    let isQuantifiedBy = _prefix "isQuantifiedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatus"></see>
    /// </summary>
    let RelationshipStatus = _prefix "RelationshipStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusActive"></see>
    /// </summary>
    let RelationshipStatusActive = _prefix "RelationshipStatusActive"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusInactive"></see>
    /// </summary>
    let RelationshipStatusInactive = _prefix "RelationshipStatusInactive"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalAddress"></see>
    /// </summary>
    let hasLegalAddress = _prefix "hasLegalAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalForm"></see>
    /// </summary>
    let hasLegalForm = _prefix "hasLegalForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasOwnershipPercentage"></see>
    /// </summary>
    let hasOwnershipPercentage = _prefix "hasOwnershipPercentage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidatedBy"></see>
    /// </summary>
    let isConsolidatedBy = _prefix "isConsolidatedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidationOf"></see>
    /// </summary>
    let isConsolidationOf = _prefix "isConsolidationOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isDirectlyConsolidatedBy"></see>
    /// </summary>
    let isDirectlyConsolidatedBy = _prefix "isDirectlyConsolidatedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isInternationalBranchOf"></see>
    /// </summary>
    let isInternationalBranchOf = _prefix "isInternationalBranchOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isUltimatelyConsolidatedBy"></see>
    /// </summary>
    let isUltimatelyConsolidatedBy = _prefix "isUltimatelyConsolidatedBy"
