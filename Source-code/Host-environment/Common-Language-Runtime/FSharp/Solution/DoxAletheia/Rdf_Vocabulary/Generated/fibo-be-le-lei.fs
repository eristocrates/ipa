namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LEIEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_le_lei =
    let _namespace_iri = Namespace_Iri fibo_be_le_lei |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-le-lei:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Legal Entity Identifier (LEI) Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_le_lei, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:AccountingFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accounting framework"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingFramework">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingFramework</seealso>
    let AccountingFramework =
        Prefixed_Name(fibo_be_le_lei, "AccountingFramework") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:AccountingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:RelationshipPeriodQualifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"accounting period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingPeriod">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingPeriod</seealso>
    let AccountingPeriod =
        Prefixed_Name(fibo_be_le_lei, "AccountingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:ContractuallyCapableEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractually capable entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ContractuallyCapableEntity">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ContractuallyCapableEntity</seealso>
    let ContractuallyCapableEntity =
        Prefixed_Name(fibo_be_le_lei, "ContractuallyCapableEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:DocumentFilingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-lei:RelationshipPeriodQualifier</para>
    ///
    /// labels<para>"document filing period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/DocumentFilingPeriod">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/DocumentFilingPeriod</seealso>
    let DocumentFilingPeriod =
        Prefixed_Name(fibo_be_le_lei, "DocumentFilingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:EntityLegalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalForm">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalForm</seealso>
    let EntityLegalForm =
        Prefixed_Name(fibo_be_le_lei, "EntityLegalForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:EntityLegalFormIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormIdentifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormIdentifier</seealso>
    let EntityLegalFormIdentifier =
        Prefixed_Name(fibo_be_le_lei, "EntityLegalFormIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:EntityLegalFormScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormScheme">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormScheme</seealso>
    let EntityLegalFormScheme =
        Prefixed_Name(fibo_be_le_lei, "EntityLegalFormScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:GenerallyAcceptedAccountingPrinciples</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:AccountingFramework</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Generally Accepted Accounting Principles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/GenerallyAcceptedAccountingPrinciples">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/GenerallyAcceptedAccountingPrinciples</seealso>
    let GenerallyAcceptedAccountingPrinciples =
        Prefixed_Name(fibo_be_le_lei, "GenerallyAcceptedAccountingPrinciples") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:ISO17442-CodeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-lei:LegalEntityIdentifierScheme</para>
    ///
    /// labels<para>"ISO 17442 code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO17442-CodeSet">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO17442-CodeSet</seealso>
    let ISO17442_CodeSet =
        Prefixed_Name(fibo_be_le_lei, "ISO17442-CodeSet") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:ISO20275-CodeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:EntityLegalFormScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ISO 20275 code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO20275-CodeSet">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ISO20275-CodeSet</seealso>
    let ISO20275_CodeSet =
        Prefixed_Name(fibo_be_le_lei, "ISO20275-CodeSet") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:InternationalFinancialReportingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:AccountingFramework</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"International Financial Reporting Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/InternationalFinancialReportingStandard">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/InternationalFinancialReportingStandard</seealso>
    let InternationalFinancialReportingStandard =
        Prefixed_Name(fibo_be_le_lei, "InternationalFinancialReportingStandard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:LEIRegisteredEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LEI registered entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LEIRegisteredEntity">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LEIRegisteredEntity</seealso>
    let LEIRegisteredEntity =
        Prefixed_Name(fibo_be_le_lei, "LEIRegisteredEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:LegalEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifier</seealso>
    let LegalEntityIdentifier =
        Prefixed_Name(fibo_be_le_lei, "LegalEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:LegalEntityIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifierScheme</seealso>
    let LegalEntityIdentifierScheme =
        Prefixed_Name(fibo_be_le_lei, "LegalEntityIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:OtherAccountingFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:AccountingFramework</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"other accounting framework"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/OtherAccountingFramework">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/OtherAccountingFramework</seealso>
    let OtherAccountingFramework =
        Prefixed_Name(fibo_be_le_lei, "OtherAccountingFramework") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipPeriodQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship period qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipPeriodQualifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipPeriodQualifier</seealso>
    let RelationshipPeriodQualifier =
        Prefixed_Name(fibo_be_le_lei, "RelationshipPeriodQualifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipQualifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipQualifier</seealso>
    let RelationshipQualifier =
        Prefixed_Name(fibo_be_le_lei, "RelationshipQualifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipRecord">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipRecord</seealso>
    let RelationshipRecord =
        Prefixed_Name(fibo_be_le_lei, "RelationshipRecord") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatus">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatus</seealso>
    let RelationshipStatus =
        Prefixed_Name(fibo_be_le_lei, "RelationshipStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:RelationshipStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"relationship status - active"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusActive">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusActive</seealso>
    let RelationshipStatusActive =
        Prefixed_Name(fibo_be_le_lei, "RelationshipStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:RelationshipStatusInactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lei:RelationshipStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"relationship status - inactive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusInactive">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatusInactive</seealso>
    let RelationshipStatusInactive =
        Prefixed_Name(fibo_be_le_lei, "RelationshipStatusInactive") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalAddress">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalAddress</seealso>
    let hasLegalAddress =
        Prefixed_Name(fibo_be_le_lei, "hasLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasLegalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalForm">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalForm</seealso>
    let hasLegalForm = Prefixed_Name(fibo_be_le_lei, "hasLegalForm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasLegalFormAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has legal form abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalFormAbbreviation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalFormAbbreviation</seealso>
    let hasLegalFormAbbreviation =
        Prefixed_Name(fibo_be_le_lei, "hasLegalFormAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasOwnershipPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has ownership percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasOwnershipPercentage">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasOwnershipPercentage</seealso>
    let hasOwnershipPercentage =
        Prefixed_Name(fibo_be_le_lei, "hasOwnershipPercentage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasTransliteratedLegalFormAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transliterated legal form abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedLegalFormAbbreviation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedLegalFormAbbreviation</seealso>
    let hasTransliteratedLegalFormAbbreviation =
        Prefixed_Name(fibo_be_le_lei, "hasTransliteratedLegalFormAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:hasTransliteratedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transliterated name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedName">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedName</seealso>
    let hasTransliteratedName =
        Prefixed_Name(fibo_be_le_lei, "hasTransliteratedName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isConsolidatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is consolidated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidatedBy">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidatedBy</seealso>
    let isConsolidatedBy =
        Prefixed_Name(fibo_be_le_lei, "isConsolidatedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isConsolidationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is consolidation of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidationOf">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidationOf</seealso>
    let isConsolidationOf =
        Prefixed_Name(fibo_be_le_lei, "isConsolidationOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isDirectlyConsolidatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is directly consolidated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isDirectlyConsolidatedBy">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isDirectlyConsolidatedBy</seealso>
    let isDirectlyConsolidatedBy =
        Prefixed_Name(fibo_be_le_lei, "isDirectlyConsolidatedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isInternationalBranchOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an international branch of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isInternationalBranchOf">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isInternationalBranchOf</seealso>
    let isInternationalBranchOf =
        Prefixed_Name(fibo_be_le_lei, "isInternationalBranchOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isQuantifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is quantified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isQuantifiedBy">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isQuantifiedBy</seealso>
    let isQuantifiedBy = Prefixed_Name(fibo_be_le_lei, "isQuantifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lei:isUltimatelyConsolidatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is ultimately consolidated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isUltimatelyConsolidatedBy">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isUltimatelyConsolidatedBy</seealso>
    let isUltimatelyConsolidatedBy =
        Prefixed_Name(fibo_be_le_lei, "isUltimatelyConsolidatedBy") |> PrefixedName
