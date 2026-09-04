#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-L2`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L2/" "gleif-L2"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : Accounting consolidation holds when '[in the] financial statements of a group [...] the assets, liabilities, equity, income, expenses and cash flows of the parent and its subsidiaries are presented as those of a single economic entity'.^^xsd:string</para>
    ///   <para>rdfs:label : accounting consolidation^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/AccountingConsolidation">gleif-L2:AccountingConsolidation</a>
    /// </summary>
    let AccountingConsolidation = _prefixId.prefix "AccountingConsolidation"
    /// <summary>
    ///   <para>skos:definition : the type of accounting standard used to source consolidation information, which is based on reported accounting roll-ups^^xsd:string</para>
    ///   <para>rdfs:label : accounting standard^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/AccountingStandard">gleif-L2:AccountingStandard</a>
    /// </summary>
    let AccountingStandard = _prefixId.prefix "AccountingStandard"
    let AccountingStandardIFRS = _prefixId.prefix "AccountingStandardIFRS"

    let AccountingStandardOtherAccountingStandard =
        _prefixId.prefix "AccountingStandardOtherAccountingStandard"

    let AccountingStandardUSGAAP = _prefixId.prefix "AccountingStandardUSGAAP"
    /// <summary>
    ///   <para>skos:prefLabel : direct consolidation^^xsd:string</para>
    ///   <para>skos:definition : The 'child' entity has its accounts fully consolidated by the 'parent' entity, in the sense given by the accounting standard(s) specified; the parent entity is the closest fully consolidating parent to the child entity in any applicable hierarchical ownership structure.^^xsd:string</para>
    ///   <para>skos:altLabel : is directly consolidated by^^xsd:string</para>
    ///   <para>rdfs:label : direct consolidation^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/DirectConsolidation">gleif-L2:DirectConsolidation</a>
    /// </summary>
    let DirectConsolidation = _prefixId.prefix "DirectConsolidation"

    /// <summary>
    ///   <para>skos:prefLabel : international branch relationship^^xsd:string</para>
    ///   <para>skos:note : A non-incorporated establishment of a head office legal entity, when this establishment is located in a separate jurisdiction from the jurisdiction in which the head office legal entity is located, i.e., in a host jurisdiction outside of its home jurisdiction. Under this definition, an establishment may consist of a single office or other business premises, or of several offices (i.e., a branch network) in different locations of the same host jurisdiction: even in the latter case, only one LEI would be issued per host jurisdiction, essentially amounting to, “one country-one LEI.” Unlike foreign subsidiaries of a parent entity, which are separately incorporated or organised under the laws of the host jurisdictions, an international branch, as defined here, is legally dependent on the head office legal entity and cannot exist without its head office legal entity ^^xsd:string</para>
    ///   <para>skos:definition : Child is a lead international branch or international branch network outside of the head office’s jurisdiction. The Parent is the Head Office and MUST have an LEI.^^xsd:string</para>
    ///   <para>skos:altLabel : is international branch of^^xsd:string</para>
    ///   <para>rdfs:label : international branch relationship^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/InternationalBranchRelationship">gleif-L2:InternationalBranchRelationship</a>
    /// </summary>
    let InternationalBranchRelationship =
        _prefixId.prefix "InternationalBranchRelationship"

    /// <summary>
    ///   <para>rdfs:label : legal entity relationship record^^xsd:string</para>
    ///   <para>skos:definition : The Registration container element contains information specifying the LOU's administration of the relationship record.^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/LegalEntityRelationshipRecord">gleif-L2:LegalEntityRelationshipRecord</a>
    /// </summary>
    let LegalEntityRelationshipRecord = _prefixId.prefix "LegalEntityRelationshipRecord"
    /// <summary>
    ///   <para>skos:definition : The status of the legal entity's relationship record registration with the Managing LOU.^^xsd:string</para>
    ///   <para>rdfs:label : relationship registration status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/RegistrationStatus">gleif-L2:RegistrationStatus</a>
    /// </summary>
    let RegistrationStatus = _prefixId.prefix "RegistrationStatus"
    let RegistrationStatusAnnulled = _prefixId.prefix "RegistrationStatusAnnulled"
    let RegistrationStatusDuplicate = _prefixId.prefix "RegistrationStatusDuplicate"
    let RegistrationStatusLapsed = _prefixId.prefix "RegistrationStatusLapsed"

    let RegistrationStatusPendingArchival =
        _prefixId.prefix "RegistrationStatusPendingArchival"

    let RegistrationStatusPendingTransfer =
        _prefixId.prefix "RegistrationStatusPendingTransfer"

    let RegistrationStatusPublished = _prefixId.prefix "RegistrationStatusPublished"
    let RegistrationStatusRetired = _prefixId.prefix "RegistrationStatusRetired"
    /// <summary>
    ///   <para>skos:definition : The status of the legal entities' relationship itself: active or inactive.^^xsd:string</para>
    ///   <para>rdfs:label : relationship status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/RelationshipStatus">gleif-L2:RelationshipStatus</a>
    /// </summary>
    let RelationshipStatus = _prefixId.prefix "RelationshipStatus"
    let RelationshipStatusActive = _prefixId.prefix "RelationshipStatusActive"
    let RelationshipStatusInactive = _prefixId.prefix "RelationshipStatusInactive"

    /// <summary>
    ///   <para>skos:definition : Type of source document(s) used for validating the relationship.^^xsd:string</para>
    ///   <para>rdfs:label : relationship validation documents kind^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/RelationshipValidationDocumentsKind">gleif-L2:RelationshipValidationDocumentsKind</a>
    /// </summary>
    let RelationshipValidationDocumentsKind =
        _prefixId.prefix "RelationshipValidationDocumentsKind"

    let RelationshipValidationDocumentsKindAccountsFiling =
        _prefixId.prefix "RelationshipValidationDocumentsKindAccountsFiling"

    let RelationshipValidationDocumentsKindContracts =
        _prefixId.prefix "RelationshipValidationDocumentsKindContracts"

    let RelationshipValidationDocumentsKindOtherOfficialDocuments =
        _prefixId.prefix "RelationshipValidationDocumentsKindOtherOfficialDocuments"

    let RelationshipValidationDocumentsKindRegulatoryFiling =
        _prefixId.prefix "RelationshipValidationDocumentsKindRegulatoryFiling"

    let RelationshipValidationDocumentsKindSupportingDocuments =
        _prefixId.prefix "RelationshipValidationDocumentsKindSupportingDocuments"

    /// <summary>
    ///   <para>skos:prefLabel : ultimate consolidation^^xsd:string</para>
    ///   <para>skos:definition : The 'child' entity has its accounts fully consolidated by the 'parent' entity, in the sense given by the accounting standard(s) specified; the child entity is the most distant fully consolidating parent from the child entity in any applicable hierarchical ownership structure.^^xsd:string</para>
    ///   <para>skos:altLabel : is ultimately consolidated by^^xsd:string</para>
    ///   <para>rdfs:label : ultimate consolidation^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/UltimateConsolidation">gleif-L2:UltimateConsolidation</a>
    /// </summary>
    let UltimateConsolidation = _prefixId.prefix "UltimateConsolidation"
    /// <summary>
    ///   <para>skos:definition : The dates in this Period indicate the accounting period covered by the most recent validation documents for this relationship.^^xsd:string</para>
    ///   <para>rdfs:label : has accounting period^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasAccountingPeriod">gleif-L2:hasAccountingPeriod</a>
    /// </summary>
    let hasAccountingPeriod = _prefixId.prefix "hasAccountingPeriod"
    /// <summary>
    ///   <para>skos:definition : The accounting standard applied to determine the definition of e.g. ultimate or direct accounting consolidating parent for the relationship. The relevant accounting standard is that applicable to the 'parent' entity.^^xsd:string</para>
    ///   <para>rdfs:label : has accounting standard^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasAccountingStandard">gleif-L2:hasAccountingStandard</a>
    /// </summary>
    let hasAccountingStandard = _prefixId.prefix "hasAccountingStandard"
    /// <summary>
    ///   <para>skos:definition : The entity that plays the child role.^^xsd:string</para>
    ///   <para>rdfs:label : has child^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasChild">gleif-L2:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>skos:definition : The dates in this instance of Period indicate the validity period of a regulatory filing, accounting document, or other document demonstrating the relationship's validity^^xsd:string</para>
    ///   <para>rdfs:label : has document filing period^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasDocumentFilingPeriod">gleif-L2:hasDocumentFilingPeriod</a>
    /// </summary>
    let hasDocumentFilingPeriod = _prefixId.prefix "hasDocumentFilingPeriod"
    /// <summary>
    ///   <para>skos:definition : The entity that plays the parent role.^^xsd:string</para>
    ///   <para>rdfs:label : has parent^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasParent">gleif-L2:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>skos:definition : The dates in this instance of Period indicate the duration of validity of the relationship itself, as distinct from any administrative or reporting aspects.^^xsd:string</para>
    ///   <para>rdfs:label : has relationship period^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasRelationshipPeriod">gleif-L2:hasRelationshipPeriod</a>
    /// </summary>
    let hasRelationshipPeriod = _prefixId.prefix "hasRelationshipPeriod"
    /// <summary>
    ///   <para>skos:definition : Indicates the status of the relationship (i.e., active, inactive).^^xsd:string</para>
    ///   <para>rdfs:label : has relationship status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasRelationshipStatus">gleif-L2:hasRelationshipStatus</a>
    /// </summary>
    let hasRelationshipStatus = _prefixId.prefix "hasRelationshipStatus"
    /// <summary>
    ///   <para>skos:definition : Type of source document(s) used for validating the relationship.^^xsd:string</para>
    ///   <para>rdfs:label : has validation documents^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasValidationDocuments">gleif-L2:hasValidationDocuments</a>
    /// </summary>
    let hasValidationDocuments = _prefixId.prefix "hasValidationDocuments"
    /// <summary>
    ///   <para>skos:definition : A reference to a specific document or other source used as the basis of relationship validation for this relationship record.^^xsd:string</para>
    ///   <para>rdfs:label : has validation reference^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasValidationReference">gleif-L2:hasValidationReference</a>
    /// </summary>
    let hasValidationReference = _prefixId.prefix "hasValidationReference"
    /// <summary>
    ///   <para>skos:definition : Level of relationship validation.^^xsd:string</para>
    ///   <para>rdfs:label : has validation sources^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2/hasValidationSources">gleif-L2:hasValidationSources</a>
    /// </summary>
    let hasValidationSources = _prefixId.prefix "hasValidationSources"
