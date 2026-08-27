namespace https.www.gleif.org.ontology.L2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_L2 =
    let _namespace_iri = Namespace_Iri gleif_L2 |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-L2:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"GLEIF L2 Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/">https://www.gleif.org/ontology/L2/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_L2, "") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:AccountingConsolidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accounting consolidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/AccountingConsolidation">https://www.gleif.org/ontology/L2/AccountingConsolidation</seealso>
    let AccountingConsolidation =
        Prefixed_Name(gleif_L2, "AccountingConsolidation") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:AccountingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accounting standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/AccountingStandard">https://www.gleif.org/ontology/L2/AccountingStandard</seealso>
    let AccountingStandard =
        Prefixed_Name(gleif_L2, "AccountingStandard") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:AccountingStandardIFRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:AccountingStandard</para>
    ///
    /// labels<para>"IFRS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/AccountingStandardIFRS">https://www.gleif.org/ontology/L2/AccountingStandardIFRS</seealso>
    let AccountingStandardIFRS =
        Prefixed_Name(gleif_L2, "AccountingStandardIFRS") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:AccountingStandardOtherAccountingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:AccountingStandard</para>
    ///
    /// labels<para>"other accounting standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/AccountingStandardOtherAccountingStandard">https://www.gleif.org/ontology/L2/AccountingStandardOtherAccountingStandard</seealso>
    let AccountingStandardOtherAccountingStandard =
        Prefixed_Name(gleif_L2, "AccountingStandardOtherAccountingStandard") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:AccountingStandardUSGAAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:AccountingStandard</para>
    ///
    /// labels<para>"US GAAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/AccountingStandardUSGAAP">https://www.gleif.org/ontology/L2/AccountingStandardUSGAAP</seealso>
    let AccountingStandardUSGAAP =
        Prefixed_Name(gleif_L2, "AccountingStandardUSGAAP") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:DirectConsolidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"direct consolidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/DirectConsolidation">https://www.gleif.org/ontology/L2/DirectConsolidation</seealso>
    let DirectConsolidation =
        Prefixed_Name(gleif_L2, "DirectConsolidation") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:InternationalBranchRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international branch relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/InternationalBranchRelationship">https://www.gleif.org/ontology/L2/InternationalBranchRelationship</seealso>
    let InternationalBranchRelationship =
        Prefixed_Name(gleif_L2, "InternationalBranchRelationship") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:LegalEntityRelationshipRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity relationship record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/LegalEntityRelationshipRecord">https://www.gleif.org/ontology/L2/LegalEntityRelationshipRecord</seealso>
    let LegalEntityRelationshipRecord =
        Prefixed_Name(gleif_L2, "LegalEntityRelationshipRecord") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatus">https://www.gleif.org/ontology/L2/RegistrationStatus</seealso>
    let RegistrationStatus =
        Prefixed_Name(gleif_L2, "RegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusAnnulled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///
    /// labels<para>"annulled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusAnnulled">https://www.gleif.org/ontology/L2/RegistrationStatusAnnulled</seealso>
    let RegistrationStatusAnnulled =
        Prefixed_Name(gleif_L2, "RegistrationStatusAnnulled") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusDuplicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///
    /// labels<para>"duplicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusDuplicate">https://www.gleif.org/ontology/L2/RegistrationStatusDuplicate</seealso>
    let RegistrationStatusDuplicate =
        Prefixed_Name(gleif_L2, "RegistrationStatusDuplicate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusLapsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"lapsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusLapsed">https://www.gleif.org/ontology/L2/RegistrationStatusLapsed</seealso>
    let RegistrationStatusLapsed =
        Prefixed_Name(gleif_L2, "RegistrationStatusLapsed") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusPendingArchival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///
    /// labels<para>"pending archival"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingArchival">https://www.gleif.org/ontology/L2/RegistrationStatusPendingArchival</seealso>
    let RegistrationStatusPendingArchival =
        Prefixed_Name(gleif_L2, "RegistrationStatusPendingArchival") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusPendingTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pending transfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusPendingTransfer">https://www.gleif.org/ontology/L2/RegistrationStatusPendingTransfer</seealso>
    let RegistrationStatusPendingTransfer =
        Prefixed_Name(gleif_L2, "RegistrationStatusPendingTransfer") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusPublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///
    /// labels<para>"published"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusPublished">https://www.gleif.org/ontology/L2/RegistrationStatusPublished</seealso>
    let RegistrationStatusPublished =
        Prefixed_Name(gleif_L2, "RegistrationStatusPublished") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RegistrationStatusRetired</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"retired"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RegistrationStatusRetired">https://www.gleif.org/ontology/L2/RegistrationStatusRetired</seealso>
    let RegistrationStatusRetired =
        Prefixed_Name(gleif_L2, "RegistrationStatusRetired") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipStatus">https://www.gleif.org/ontology/L2/RelationshipStatus</seealso>
    let RelationshipStatus =
        Prefixed_Name(gleif_L2, "RelationshipStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RelationshipStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"active"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipStatusActive">https://www.gleif.org/ontology/L2/RelationshipStatusActive</seealso>
    let RelationshipStatusActive =
        Prefixed_Name(gleif_L2, "RelationshipStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipStatusInactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RelationshipStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"inactive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipStatusInactive">https://www.gleif.org/ontology/L2/RelationshipStatusInactive</seealso>
    let RelationshipStatusInactive =
        Prefixed_Name(gleif_L2, "RelationshipStatusInactive") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship validation documents kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKind">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKind</seealso>
    let RelationshipValidationDocumentsKind =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKind") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKindAccountsFiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    ///
    /// labels<para>"accounts filing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindAccountsFiling">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindAccountsFiling</seealso>
    let RelationshipValidationDocumentsKindAccountsFiling =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKindAccountsFiling") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKindContracts</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"contracts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindContracts">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindContracts</seealso>
    let RelationshipValidationDocumentsKindContracts =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKindContracts") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKindOtherOfficialDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"other official documents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindOtherOfficialDocuments">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindOtherOfficialDocuments</seealso>
    let RelationshipValidationDocumentsKindOtherOfficialDocuments =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKindOtherOfficialDocuments") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKindRegulatoryFiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"regulatory filing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindRegulatoryFiling">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindRegulatoryFiling</seealso>
    let RelationshipValidationDocumentsKindRegulatoryFiling =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKindRegulatoryFiling") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKindSupportingDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L2:RelationshipValidationDocumentsKind</para>
    ///
    /// labels<para>"supporting documents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindSupportingDocuments">https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKindSupportingDocuments</seealso>
    let RelationshipValidationDocumentsKindSupportingDocuments =
        Prefixed_Name(gleif_L2, "RelationshipValidationDocumentsKindSupportingDocuments") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:UltimateConsolidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ultimate consolidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/UltimateConsolidation">https://www.gleif.org/ontology/L2/UltimateConsolidation</seealso>
    let UltimateConsolidation =
        Prefixed_Name(gleif_L2, "UltimateConsolidation") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasAccountingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accounting period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasAccountingPeriod">https://www.gleif.org/ontology/L2/hasAccountingPeriod</seealso>
    let hasAccountingPeriod =
        Prefixed_Name(gleif_L2, "hasAccountingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasAccountingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accounting standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasAccountingStandard">https://www.gleif.org/ontology/L2/hasAccountingStandard</seealso>
    let hasAccountingStandard =
        Prefixed_Name(gleif_L2, "hasAccountingStandard") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has child"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasChild">https://www.gleif.org/ontology/L2/hasChild</seealso>
    let hasChild = Prefixed_Name(gleif_L2, "hasChild") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasDocumentFilingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has document filing period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasDocumentFilingPeriod">https://www.gleif.org/ontology/L2/hasDocumentFilingPeriod</seealso>
    let hasDocumentFilingPeriod =
        Prefixed_Name(gleif_L2, "hasDocumentFilingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasParent">https://www.gleif.org/ontology/L2/hasParent</seealso>
    let hasParent = Prefixed_Name(gleif_L2, "hasParent") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasRelationshipPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relationship period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasRelationshipPeriod">https://www.gleif.org/ontology/L2/hasRelationshipPeriod</seealso>
    let hasRelationshipPeriod =
        Prefixed_Name(gleif_L2, "hasRelationshipPeriod") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasRelationshipStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relationship status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasRelationshipStatus">https://www.gleif.org/ontology/L2/hasRelationshipStatus</seealso>
    let hasRelationshipStatus =
        Prefixed_Name(gleif_L2, "hasRelationshipStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasValidationDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation documents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasValidationDocuments">https://www.gleif.org/ontology/L2/hasValidationDocuments</seealso>
    let hasValidationDocuments =
        Prefixed_Name(gleif_L2, "hasValidationDocuments") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasValidationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has validation reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasValidationReference">https://www.gleif.org/ontology/L2/hasValidationReference</seealso>
    let hasValidationReference =
        Prefixed_Name(gleif_L2, "hasValidationReference") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L2:hasValidationSources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation sources"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L2/hasValidationSources">https://www.gleif.org/ontology/L2/hasValidationSources</seealso>
    let hasValidationSources =
        Prefixed_Name(gleif_L2, "hasValidationSources") |> PrefixedName
