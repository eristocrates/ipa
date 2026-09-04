#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-le-lei`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/" "fibo-be-le-lei"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : accounting framework^^xsd:string</para>
    ///   <para>skos:definition : framework, including policies, methods, rules, and processes, used to measure, recognize, present, and disclose the information appearing in an entity's financial statements, and, from a legal ownership perspective, that is applied for accounting consolidation determination^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/AccountingFramework">fibo-be-le-lei:AccountingFramework</a>
    /// </summary>
    let AccountingFramework = _prefixId.prefix "AccountingFramework"
    let AccountingPeriod = _prefixId.prefix "AccountingPeriod"
    /// <summary>
    ///   <para>rdfs:label : contractually capable entity^^xsd:string</para>
    ///   <para>skos:definition : a unique entity that is legally or financially responsible for the performance of financial transactions, or has the legal right in its jurisdiction to enter independently into legal contracts, regardless of whether it is incorporated or constituted in some other way (e.g. trust, partnership, contractual). This excludes natural persons, but includes governmental organizations and supranationals.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 17442^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/ContractuallyCapableEntity">fibo-be-le-lei:ContractuallyCapableEntity</a>
    /// </summary>
    let ContractuallyCapableEntity = _prefixId.prefix "ContractuallyCapableEntity"
    let DocumentFilingPeriod = _prefixId.prefix "DocumentFilingPeriod"
    /// <summary>
    ///   <para>rdfs:label : entity legal form^^xsd:string</para>
    ///   <para>skos:definition : a classifier for a legal entity that indicates the nature of that entity as defined from a legal or regulatory perspective, in the jurisdiction in which it was established^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/obp/ui/#iso:std:iso:20275:ed-1:v1:en^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalForm">fibo-be-le-lei:EntityLegalForm</a>
    /// </summary>
    let EntityLegalForm = _prefixId.prefix "EntityLegalForm"
    /// <summary>
    ///   <para>rdfs:label : entity legal form identifier^^xsd:string</para>
    ///   <para>skos:definition : code that denotes an entity legal form as defined in ISO 20275^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/code-lists/iso-20275-entity-legal-forms-code-list^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/obp/ui/#iso:std:iso:20275:ed-1:v1:en^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormIdentifier">fibo-be-le-lei:EntityLegalFormIdentifier</a>
    /// </summary>
    let EntityLegalFormIdentifier = _prefixId.prefix "EntityLegalFormIdentifier"
    /// <summary>
    ///   <para>rdfs:label : entity legal form scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme that specifies the elements of the codes for entity legal forms, such as those that are sanctioned in a given jurisdiction as defined in ISO 20725^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/code-lists/iso-20275-entity-legal-forms-code-list^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/obp/ui/#iso:std:iso:20275:ed-1:v1:en^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/EntityLegalFormScheme">fibo-be-le-lei:EntityLegalFormScheme</a>
    /// </summary>
    let EntityLegalFormScheme = _prefixId.prefix "EntityLegalFormScheme"

    let GenerallyAcceptedAccountingPrinciples =
        _prefixId.prefix "GenerallyAcceptedAccountingPrinciples"

    let ISO17442_CodeSet = _prefixId.prefix "ISO17442-CodeSet"
    let ISO20275_CodeSet = _prefixId.prefix "ISO20275-CodeSet"

    let InternationalFinancialReportingStandard =
        _prefixId.prefix "InternationalFinancialReportingStandard"

    /// <summary>
    ///   <para>rdfs:label : LEI registered entity^^xsd:string</para>
    ///   <para>skos:definition : a legal person that has registered for and is identified by a legal entity identifier^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the GLEIF data includes multiple LEIs for some entities due to corporate actions or other situations. The duplicates are typically archived after some period of time, but in order to reflect the reality in the data, the restriction is modeled as someValuesFrom rather than exactly 1 LEI for a given entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LEIRegisteredEntity">fibo-be-le-lei:LEIRegisteredEntity</a>
    /// </summary>
    let LEIRegisteredEntity = _prefixId.prefix "LEIRegisteredEntity"
    /// <summary>
    ///   <para>rdfs:label : legal entity identifier^^xsd:string</para>
    ///   <para>skos:definition : an organization identifier that uniquely identifies a legal person as defined in ISO 17442^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/standard/59771.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifier">fibo-be-le-lei:LegalEntityIdentifier</a>
    /// </summary>
    let LegalEntityIdentifier = _prefixId.prefix "LegalEntityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : legal entity identifier scheme^^xsd:string</para>
    ///   <para>skos:definition : a scheme that specifies the elements of an unambiguous legal entity identifier (LEI) scheme to identify the legal entities relevant to any financial transaction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/standard/59771.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/LegalEntityIdentifierScheme">fibo-be-le-lei:LegalEntityIdentifierScheme</a>
    /// </summary>
    let LegalEntityIdentifierScheme = _prefixId.prefix "LegalEntityIdentifierScheme"
    let OtherAccountingFramework = _prefixId.prefix "OtherAccountingFramework"
    /// <summary>
    ///   <para>rdfs:label : relationship period qualifier^^xsd:string</para>
    ///   <para>skos:definition : a classifier that qualifies something about the reporting period specified, such as that the date period reflects an accounting or document filing period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipPeriodQualifier">fibo-be-le-lei:RelationshipPeriodQualifier</a>
    /// </summary>
    let RelationshipPeriodQualifier = _prefixId.prefix "RelationshipPeriodQualifier"
    /// <summary>
    ///   <para>rdfs:label : relationship qualifier^^xsd:string</para>
    ///   <para>skos:definition : a classifier that qualifies something about the relationship between consolidated entities during the reporting period, such as the accounting framework used^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipQualifier">fibo-be-le-lei:RelationshipQualifier</a>
    /// </summary>
    let RelationshipQualifier = _prefixId.prefix "RelationshipQualifier"
    /// <summary>
    ///   <para>rdfs:label : relationship record^^xsd:string</para>
    ///   <para>skos:definition : a record describing relationships between legal entities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipRecord">fibo-be-le-lei:RelationshipRecord</a>
    /// </summary>
    let RelationshipRecord = _prefixId.prefix "RelationshipRecord"
    /// <summary>
    ///   <para>rdfs:label : relationship status^^xsd:string</para>
    ///   <para>skos:definition : a classifier that specifies the status of the relationship between consolidated entities during the reporting period (active or inactive)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/RelationshipStatus">fibo-be-le-lei:RelationshipStatus</a>
    /// </summary>
    let RelationshipStatus = _prefixId.prefix "RelationshipStatus"
    let RelationshipStatusActive = _prefixId.prefix "RelationshipStatusActive"
    let RelationshipStatusInactive = _prefixId.prefix "RelationshipStatusInactive"
    /// <summary>
    ///   <para>rdfs:label : has legal address^^xsd:string</para>
    ///   <para>skos:definition : indicates the legal address for the entity, in the jurisdiction in which the entity is established, used for registration purposes with respect to obtaining an LEI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalAddress">fibo-be-le-lei:hasLegalAddress</a>
    /// </summary>
    let hasLegalAddress = _prefixId.prefix "hasLegalAddress"
    /// <summary>
    ///   <para>rdfs:label : has legal form^^xsd:string</para>
    ///   <para>skos:definition : indicates the nature of the entity as defined from a legal or regulatory perspective in a given jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso.org/obp/ui/#iso:std:iso:20275:ed-1:v1:en^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalForm">fibo-be-le-lei:hasLegalForm</a>
    /// </summary>
    let hasLegalForm = _prefixId.prefix "hasLegalForm"
    /// <summary>
    ///   <para>rdfs:label : has legal form abbreviation^^xsd:string</para>
    ///   <para>skos:definition : the precise abbreviation for the entity legal form as defined in the jurisdiction in which it is registered, for example LLC, LLP, Ltd, PLC, Corp.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasLegalFormAbbreviation">fibo-be-le-lei:hasLegalFormAbbreviation</a>
    /// </summary>
    let hasLegalFormAbbreviation = _prefixId.prefix "hasLegalFormAbbreviation"
    /// <summary>
    ///   <para>rdfs:label : has ownership percentage^^xsd:string</para>
    ///   <para>skos:definition : the percentage ownership interest in the owned entity owned by owning entity, if known^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasOwnershipPercentage">fibo-be-le-lei:hasOwnershipPercentage</a>
    /// </summary>
    let hasOwnershipPercentage = _prefixId.prefix "hasOwnershipPercentage"

    /// <summary>
    ///   <para>rdfs:label : has transliterated legal form abbreviation^^xsd:string</para>
    ///   <para>skos:definition : a transliterated (i.e., in Latin or Romanized ASCII) representation of the abbreviation for the entity legal form^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedLegalFormAbbreviation">fibo-be-le-lei:hasTransliteratedLegalFormAbbreviation</a>
    /// </summary>
    let hasTransliteratedLegalFormAbbreviation =
        _prefixId.prefix "hasTransliteratedLegalFormAbbreviation"

    /// <summary>
    ///   <para>rdfs:label : has transliterated name^^xsd:string</para>
    ///   <para>skos:definition : a transliterated (i.e., in Latin or Romanized ASCII) representation of a name for the entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/hasTransliteratedName">fibo-be-le-lei:hasTransliteratedName</a>
    /// </summary>
    let hasTransliteratedName = _prefixId.prefix "hasTransliteratedName"
    /// <summary>
    ///   <para>rdfs:label : is consolidated by^^xsd:string</para>
    ///   <para>skos:definition : indicates the entity considered the 'end node' or consolidating entity (parent) from an ISO 17442 perspective^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidatedBy">fibo-be-le-lei:isConsolidatedBy</a>
    /// </summary>
    let isConsolidatedBy = _prefixId.prefix "isConsolidatedBy"
    /// <summary>
    ///   <para>rdfs:label : is consolidation of^^xsd:string</para>
    ///   <para>skos:definition : indicates the entity considered the 'start node' or consolidated entity from an ISO 17442 perspective^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isConsolidationOf">fibo-be-le-lei:isConsolidationOf</a>
    /// </summary>
    let isConsolidationOf = _prefixId.prefix "isConsolidationOf"
    /// <summary>
    ///   <para>rdfs:label : is directly consolidated by^^xsd:string</para>
    ///   <para>skos:definition : indicates that the entity considered the 'end node' or consolidating entity (parent) fully consolidates the accounting of the 'start node' (child) per the accounting rules specified, and is the closest consolidating entity to that child in any applicable ownership hierarchy^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isDirectlyConsolidatedBy">fibo-be-le-lei:isDirectlyConsolidatedBy</a>
    /// </summary>
    let isDirectlyConsolidatedBy = _prefixId.prefix "isDirectlyConsolidatedBy"
    /// <summary>
    ///   <para>rdfs:label : is an international branch of^^xsd:string</para>
    ///   <para>skos:definition : indicates that the entity considered the 'start node' or consolidated entity (child) is an international subsidiary of the 'end node' (parent) in the jurisdiction of the child^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isInternationalBranchOf">fibo-be-le-lei:isInternationalBranchOf</a>
    /// </summary>
    let isInternationalBranchOf = _prefixId.prefix "isInternationalBranchOf"
    /// <summary>
    ///   <para>rdfs:label : is quantified by^^xsd:string</para>
    ///   <para>skos:definition : indicates that something is limited to or conditional due to some rate or other statistical value^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isQuantifiedBy">fibo-be-le-lei:isQuantifiedBy</a>
    /// </summary>
    let isQuantifiedBy = _prefixId.prefix "isQuantifiedBy"
    /// <summary>
    ///   <para>rdfs:label : is ultimately consolidated by^^xsd:string</para>
    ///   <para>skos:definition : indicates that the entity considered the 'end node' or consolidating entity (parent) fully consolidates the accounting of the 'start node' (child) per the accounting rules specified, and is the most distant consolidating entity to that child in any applicable ownership hierarchy^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : GLEIF Level 2 Relationship Record (RR) Common Data Format (CDF), see https://www.gleif.org/en/about-lei/common-data-file-format/relationship-record-cdf-format#^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/isUltimatelyConsolidatedBy">fibo-be-le-lei:isUltimatelyConsolidatedBy</a>
    /// </summary>
    let isUltimatelyConsolidatedBy = _prefixId.prefix "isUltimatelyConsolidatedBy"
