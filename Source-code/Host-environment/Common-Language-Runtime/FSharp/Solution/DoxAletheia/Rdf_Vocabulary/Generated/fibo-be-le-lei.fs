namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LEIEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_le_lei =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingFramework"></see>
    /// </summary>
    let AccountingFramework =
        Namespaced_IRI.parse _namespace_name "AccountingFramework" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipQualifier"></see>
    /// </summary>
    let RelationshipQualifier =
        Namespaced_IRI.parse _namespace_name "RelationshipQualifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingPeriod"></see>
    /// </summary>
    let AccountingPeriod =
        Namespaced_IRI.parse _namespace_name "AccountingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipPeriodQualifier"></see>
    /// </summary>
    let RelationshipPeriodQualifier =
        Namespaced_IRI.parse _namespace_name "RelationshipPeriodQualifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ContractuallyCapableEntity"></see>
    /// </summary>
    let ContractuallyCapableEntity =
        Namespaced_IRI.parse _namespace_name "ContractuallyCapableEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/DocumentFilingPeriod"></see>
    /// </summary>
    let DocumentFilingPeriod =
        Namespaced_IRI.parse _namespace_name "DocumentFilingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalForm"></see>
    /// </summary>
    let EntityLegalForm =
        Namespaced_IRI.parse _namespace_name "EntityLegalForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalFormAbbreviation"></see>
    /// </summary>
    let hasLegalFormAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasLegalFormAbbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedLegalFormAbbreviation"></see>
    /// </summary>
    let hasTransliteratedLegalFormAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedLegalFormAbbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedName"></see>
    /// </summary>
    let hasTransliteratedName =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormScheme"></see>
    /// </summary>
    let EntityLegalFormScheme =
        Namespaced_IRI.parse _namespace_name "EntityLegalFormScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormIdentifier"></see>
    /// </summary>
    let EntityLegalFormIdentifier =
        Namespaced_IRI.parse _namespace_name "EntityLegalFormIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/GenerallyAcceptedAccountingPrinciples"></see>
    /// </summary>
    let GenerallyAcceptedAccountingPrinciples =
        Namespaced_IRI.parse _namespace_name "GenerallyAcceptedAccountingPrinciples" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO17442-CodeSet"></see>
    /// </summary>
    let ``ISO17442-CodeSet`` =
        Namespaced_IRI.parse _namespace_name "ISO17442-CodeSet" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifierScheme"></see>
    /// </summary>
    let LegalEntityIdentifierScheme =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifierScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO20275-CodeSet"></see>
    /// </summary>
    let ``ISO20275-CodeSet`` =
        Namespaced_IRI.parse _namespace_name "ISO20275-CodeSet" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/InternationalFinancialReportingStandard"></see>
    /// </summary>
    let InternationalFinancialReportingStandard =
        Namespaced_IRI.parse _namespace_name "InternationalFinancialReportingStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LEIRegisteredEntity"></see>
    /// </summary>
    let LEIRegisteredEntity =
        Namespaced_IRI.parse _namespace_name "LEIRegisteredEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifier"></see>
    /// </summary>
    let LegalEntityIdentifier =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/OtherAccountingFramework"></see>
    /// </summary>
    let OtherAccountingFramework =
        Namespaced_IRI.parse _namespace_name "OtherAccountingFramework" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipRecord"></see>
    /// </summary>
    let RelationshipRecord =
        Namespaced_IRI.parse _namespace_name "RelationshipRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isQuantifiedBy"></see>
    /// </summary>
    let isQuantifiedBy =
        Namespaced_IRI.parse _namespace_name "isQuantifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatus"></see>
    /// </summary>
    let RelationshipStatus =
        Namespaced_IRI.parse _namespace_name "RelationshipStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusActive"></see>
    /// </summary>
    let RelationshipStatusActive =
        Namespaced_IRI.parse _namespace_name "RelationshipStatusActive" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusInactive"></see>
    /// </summary>
    let RelationshipStatusInactive =
        Namespaced_IRI.parse _namespace_name "RelationshipStatusInactive" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalAddress"></see>
    /// </summary>
    let hasLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalForm"></see>
    /// </summary>
    let hasLegalForm =
        Namespaced_IRI.parse _namespace_name "hasLegalForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasOwnershipPercentage"></see>
    /// </summary>
    let hasOwnershipPercentage =
        Namespaced_IRI.parse _namespace_name "hasOwnershipPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidatedBy"></see>
    /// </summary>
    let isConsolidatedBy =
        Namespaced_IRI.parse _namespace_name "isConsolidatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidationOf"></see>
    /// </summary>
    let isConsolidationOf =
        Namespaced_IRI.parse _namespace_name "isConsolidationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isDirectlyConsolidatedBy"></see>
    /// </summary>
    let isDirectlyConsolidatedBy =
        Namespaced_IRI.parse _namespace_name "isDirectlyConsolidatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isInternationalBranchOf"></see>
    /// </summary>
    let isInternationalBranchOf =
        Namespaced_IRI.parse _namespace_name "isInternationalBranchOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isUltimatelyConsolidatedBy"></see>
    /// </summary>
    let isUltimatelyConsolidatedBy =
        Namespaced_IRI.parse _namespace_name "isUltimatelyConsolidatedBy" |> NamespacedName
