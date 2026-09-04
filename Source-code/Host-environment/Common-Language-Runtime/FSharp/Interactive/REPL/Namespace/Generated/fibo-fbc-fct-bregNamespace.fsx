#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-breg`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/" "fibo-fbc-fct-breg"

    let _namespaceIri = _prefixId.prefix ""
    let ActiveStatus = _prefixId.prefix "ActiveStatus"
    let AnnulledStatus = _prefixId.prefix "AnnulledStatus"
    /// <summary>
    ///   <para>rdfs:label : business register identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies a business register, such as a register identified by the Global Legal Entity Identifier Foundation (GLEIF) registration authorities list^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/gleif-registration-authorities-list^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegisterIdentifier">fibo-fbc-fct-breg:BusinessRegisterIdentifier</a>
    /// </summary>
    let BusinessRegisterIdentifier = _prefixId.prefix "BusinessRegisterIdentifier"
    /// <summary>
    ///   <para>rdfs:label : business registration authority^^xsd:string</para>
    ///   <para>skos:definition : registration authority that is responsible for maintaining a registry of business entities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/gleif-registration-authorities-list^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A business registry may include any government-managed registry for registering a business, such as a state department of corporations in the US, as well as other registries such as a local operating unit (LOU) for registration of legal entity identifiers (LEIs). Any sanctioned registration authority as defined by the Registration Authorities List, published by GLEIF, is a business registration authority in this sense.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistrationAuthority">fibo-fbc-fct-breg:BusinessRegistrationAuthority</a>
    /// </summary>
    let BusinessRegistrationAuthority = _prefixId.prefix "BusinessRegistrationAuthority"
    /// <summary>
    ///   <para>rdfs:label : business registry^^xsd:string</para>
    ///   <para>skos:definition : registry for registering and maintaining information about business entities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/gleif-registration-authorities-list^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistry">fibo-fbc-fct-breg:BusinessRegistry</a>
    /// </summary>
    let BusinessRegistry = _prefixId.prefix "BusinessRegistry"
    /// <summary>
    ///   <para>rdfs:label : business registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a business registry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistryEntry">fibo-fbc-fct-breg:BusinessRegistryEntry</a>
    /// </summary>
    let BusinessRegistryEntry = _prefixId.prefix "BusinessRegistryEntry"
    let CancelledStatus = _prefixId.prefix "CancelledStatus"
    let DuplicateStatus = _prefixId.prefix "DuplicateStatus"
    /// <summary>
    ///   <para>rdfs:label : entity expiration reason^^xsd:string</para>
    ///   <para>skos:definition : code for the reason that a legal entity ceased to exist and/or operate^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReason">fibo-fbc-fct-breg:EntityExpirationReason</a>
    /// </summary>
    let EntityExpirationReason = _prefixId.prefix "EntityExpirationReason"

    let EntityExpirationReasonCorporateAction =
        _prefixId.prefix "EntityExpirationReasonCorporateAction"

    let EntityExpirationReasonDissolved =
        _prefixId.prefix "EntityExpirationReasonDissolved"

    let EntityExpirationReasonOther = _prefixId.prefix "EntityExpirationReasonOther"
    /// <summary>
    ///   <para>rdfs:label : entity legal form registry^^xsd:string</para>
    ///   <para>skos:definition : registry for registering and maintaining information about the legal forms that are valid for business entities for a particular jurisdiction following the ISO 20275 standard^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ELF registry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/code-lists/iso-20275-entity-legal-forms-code-list^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistry">fibo-fbc-fct-breg:EntityLegalFormRegistry</a>
    /// </summary>
    let EntityLegalFormRegistry = _prefixId.prefix "EntityLegalFormRegistry"
    /// <summary>
    ///   <para>rdfs:label : entity legal form registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in an entity legal form registry that conforms to ISO 20275^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ELF registry entry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/code-lists/iso-20275-entity-legal-forms-code-list^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistryEntry">fibo-fbc-fct-breg:EntityLegalFormRegistryEntry</a>
    /// </summary>
    let EntityLegalFormRegistryEntry = _prefixId.prefix "EntityLegalFormRegistryEntry"
    /// <summary>
    ///   <para>rdfs:label : entity status^^xsd:string</para>
    ///   <para>skos:definition : lifecycle stage indicating the operational and/or legal status of an entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In some jurisdictions, there may be other possible values for entity status, such as suspended in the State of California, thus the individuals provided herein are not intended to be exhaustive.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityStatus">fibo-fbc-fct-breg:EntityStatus</a>
    /// </summary>
    let EntityStatus = _prefixId.prefix "EntityStatus"
    /// <summary>
    ///   <para>rdfs:label : entity validation level^^xsd:string</para>
    ///   <para>skos:definition : code for the level of validation performed by the GLEIF or LOU with respect to the reference data provided by the registrant^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevel">fibo-fbc-fct-breg:EntityValidationLevel</a>
    /// </summary>
    let EntityValidationLevel = _prefixId.prefix "EntityValidationLevel"

    let EntityValidationLevelEntitySuppliedOnly =
        _prefixId.prefix "EntityValidationLevelEntitySuppliedOnly"

    let EntityValidationLevelFullyCorroborated =
        _prefixId.prefix "EntityValidationLevelFullyCorroborated"

    let EntityValidationLevelPartiallyCorroborated =
        _prefixId.prefix "EntityValidationLevelPartiallyCorroborated"

    let InactiveStatus = _prefixId.prefix "InactiveStatus"
    let IssuedStatus = _prefixId.prefix "IssuedStatus"
    let LapsedStatus = _prefixId.prefix "LapsedStatus"
    /// <summary>
    ///   <para>rdfs:label : legal entity identifier registry^^xsd:string</para>
    ///   <para>skos:definition : registry for registering and maintaining information about business entities for a particular jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LEI registry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistry">fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</a>
    /// </summary>
    let LegalEntityIdentifierRegistry = _prefixId.prefix "LegalEntityIdentifierRegistry"

    /// <summary>
    ///   <para>rdfs:label : legal entity identifier registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a legal entity identifier registry that conforms to ISO 17442 and the Global Legal Entity Identifier Foundation (GLEIF) Common Data Format (CDF)^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LEI registry entry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistryEntry">fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</a>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "LegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <para>rdfs:label : local operating unit^^xsd:string</para>
    ///   <para>skos:definition : registrar that is authorized by the Global LEI Foundation to issue legal entity identifiers^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LOU^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : LOUs supply registration, renewal and other services, and act as the primary interface for legal entities wishing to obtain an LEI.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LocalOperatingUnit">fibo-fbc-fct-breg:LocalOperatingUnit</a>
    /// </summary>
    let LocalOperatingUnit = _prefixId.prefix "LocalOperatingUnit"
    let MergedStatus = _prefixId.prefix "MergedStatus"

    /// <summary>
    ///   <para>rdfs:label : North American Industry Classification System code^^xsd:string</para>
    ///   <para>skos:definition : the North American Industry Classification System (NAICS) code representing an industry^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : NAICS code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemCode">fibo-fbc-fct-breg:NorthAmericanIndustryClassificationSystemCode</a>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemCode =
        _prefixId.prefix "NorthAmericanIndustryClassificationSystemCode"

    /// <summary>
    ///   <para>rdfs:label : North American Industry Classification System scheme^^xsd:string</para>
    ///   <para>skos:definition : the scheme defining the North American Industry Classification System (NAICS) Codes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The North American Industry Classification System (NAICS) is the standard used by Federal statistical agencies in classifying business establishments for the purpose of collecting, analyzing, and publishing statistical data related to the U.S. business economy.
    ///
    /// NAICS was developed under the auspices of the Office of Management and Budget (OMB), and adopted in 1997 to replace the Standard Industrial Classification (SIC) system. It was developed jointly by the U.S. Economic Classification Policy Committee (ECPC), Statistics Canada and Mexico's Instituto Nacional Estadistica y Geografia, to allow for a high level of comparability in business statistics among the North American countries.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemScheme">fibo-fbc-fct-breg:NorthAmericanIndustryClassificationSystemScheme</a>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemScheme =
        _prefixId.prefix "NorthAmericanIndustryClassificationSystemScheme"

    let PendingArchivalStatus = _prefixId.prefix "PendingArchivalStatus"
    let PendingTransferStatus = _prefixId.prefix "PendingTransferStatus"
    let PendingValidationStatus = _prefixId.prefix "PendingValidationStatus"
    /// <summary>
    ///   <para>rdfs:label : registration authority code^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies a business registry, and is associated with a registration authority and jurisdiction, issued by the Global Legal Entity Identifier Foundation (GLEIF)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/gleif-registration-authorities-list^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationAuthorityCode">fibo-fbc-fct-breg:RegistrationAuthorityCode</a>
    /// </summary>
    let RegistrationAuthorityCode = _prefixId.prefix "RegistrationAuthorityCode"
    /// <summary>
    ///   <para>rdfs:label : registration status^^xsd:string</para>
    ///   <para>skos:definition : lifecycle stage indicating the status of a given registration of something, such as a business or legal entity, as specified by the registration authority^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : There may be other possible values for registration status, depending on the registry, thus the individuals provided herein are not intended to be exhaustive.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationStatus">fibo-fbc-fct-breg:RegistrationStatus</a>
    /// </summary>
    let RegistrationStatus = _prefixId.prefix "RegistrationStatus"
    let RetiredStatus = _prefixId.prefix "RetiredStatus"

    /// <summary>
    ///   <para>rdfs:label : standard industrial classification code^^xsd:string</para>
    ///   <para>skos:definition : the SIC code representing an industry^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SIC code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationCode">fibo-fbc-fct-breg:StandardIndustrialClassificationCode</a>
    /// </summary>
    let StandardIndustrialClassificationCode =
        _prefixId.prefix "StandardIndustrialClassificationCode"

    /// <summary>
    ///   <para>rdfs:label : standard industrial classification scheme^^xsd:string</para>
    ///   <para>skos:definition : the scheme defining the Standard Industrial Classification (SIC) Code List^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Standard Industrial Classifications are four-digit codes that categorize companies by the type of business activities they engage in. These codes were created by the U.S. government in 1937 to facilitate analysis of economic activity across government agencies and within industries. They were mostly replaced in 1997 by a new system of six-digit codes called the North American Industry Classification System (NAICS). The new codes were adopted in part to standardize industry data collection and analysis in between Canada, the United States and Mexico which had entered into the North American Free Trade Agreement. Note that certain organizations, such as the Securities and Exchange Commission (SEC) still use SIC codes for some purposes.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationScheme">fibo-fbc-fct-breg:StandardIndustrialClassificationScheme</a>
    /// </summary>
    let StandardIndustrialClassificationScheme =
        _prefixId.prefix "StandardIndustrialClassificationScheme"

    let TransferredStatus = _prefixId.prefix "TransferredStatus"

    /// <summary>
    ///   <para>rdfs:label : has alternative language legal name^^xsd:string</para>
    ///   <para>skos:definition : denotes a registered legal name for the entity in an alternative language used in the legal jurisdiction in which the entity is registered^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAlternativeLanguageLegalName">fibo-fbc-fct-breg:hasAlternativeLanguageLegalName</a>
    /// </summary>
    let hasAlternativeLanguageLegalName =
        _prefixId.prefix "hasAlternativeLanguageLegalName"

    /// <summary>
    ///   <para>rdfs:label : has automatically transliterated legal name^^xsd:string</para>
    ///   <para>skos:definition : denotes an auto-generated ASCII-transliterated representation of the legal name for the entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAutomaticallyTransliteratedLegalName">fibo-fbc-fct-breg:hasAutomaticallyTransliteratedLegalName</a>
    /// </summary>
    let hasAutomaticallyTransliteratedLegalName =
        _prefixId.prefix "hasAutomaticallyTransliteratedLegalName"

    /// <summary>
    ///   <para>rdfs:label : has entity expiration date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which an entity ceases(d) to exist^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationDate">fibo-fbc-fct-breg:hasEntityExpirationDate</a>
    /// </summary>
    let hasEntityExpirationDate = _prefixId.prefix "hasEntityExpirationDate"
    /// <summary>
    ///   <para>rdfs:label : has entity expiration reason^^xsd:string</para>
    ///   <para>skos:definition : indicates the reason that an entity ceased to exist (i.e., disolved, merged with another entity, etc.)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationReason">fibo-fbc-fct-breg:hasEntityExpirationReason</a>
    /// </summary>
    let hasEntityExpirationReason = _prefixId.prefix "hasEntityExpirationReason"
    /// <summary>
    ///   <para>rdfs:label : has entity status^^xsd:string</para>
    ///   <para>skos:definition : indicates the status of the entity (i.e., active, inactive)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityStatus">fibo-fbc-fct-breg:hasEntityStatus</a>
    /// </summary>
    let hasEntityStatus = _prefixId.prefix "hasEntityStatus"
    /// <summary>
    ///   <para>rdfs:label : has expiry date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which something ceases(d) to exist^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasExpiryDate">fibo-fbc-fct-breg:hasExpiryDate</a>
    /// </summary>
    let hasExpiryDate = _prefixId.prefix "hasExpiryDate"
    /// <summary>
    ///   <para>rdfs:label : has initial registration date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which an identifier or other registered item was created and/or first registered^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasInitialRegistrationDate">fibo-fbc-fct-breg:hasInitialRegistrationDate</a>
    /// </summary>
    let hasInitialRegistrationDate = _prefixId.prefix "hasInitialRegistrationDate"
    /// <summary>
    ///   <para>rdfs:label : has managing local operating unit^^xsd:string</para>
    ///   <para>skos:definition : relates a legal entity identification record to the identifier for the local operating unit that registered the relevant legal entity identifier^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasManagingLocalOperatingUnit">fibo-fbc-fct-breg:hasManagingLocalOperatingUnit</a>
    /// </summary>
    let hasManagingLocalOperatingUnit = _prefixId.prefix "hasManagingLocalOperatingUnit"

    /// <summary>
    ///   <para>rdfs:label : has preferred transliterated legal name^^xsd:string</para>
    ///   <para>skos:definition : denotes a preferred ASCII-transliterated representation of the legal name for the entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPreferredTransliteratedLegalName">fibo-fbc-fct-breg:hasPreferredTransliteratedLegalName</a>
    /// </summary>
    let hasPreferredTransliteratedLegalName =
        _prefixId.prefix "hasPreferredTransliteratedLegalName"

    /// <summary>
    ///   <para>rdfs:label : has prior legal name^^xsd:string</para>
    ///   <para>skos:definition : denotes a primary legal name that was used previously for the entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPriorLegalName">fibo-fbc-fct-breg:hasPriorLegalName</a>
    /// </summary>
    let hasPriorLegalName = _prefixId.prefix "hasPriorLegalName"
    /// <summary>
    ///   <para>rdfs:label : has registration status revision date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date that the status of a specific registration in the registry was revised^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationRevisionDate">fibo-fbc-fct-breg:hasRegistrationRevisionDate</a>
    /// </summary>
    let hasRegistrationRevisionDate = _prefixId.prefix "hasRegistrationRevisionDate"
    /// <summary>
    ///   <para>rdfs:label : has registration status^^xsd:string</para>
    ///   <para>skos:definition : indicates the status of a specific registration, such as for an identifier or license^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationStatus">fibo-fbc-fct-breg:hasRegistrationStatus</a>
    /// </summary>
    let hasRegistrationStatus = _prefixId.prefix "hasRegistrationStatus"
    /// <summary>
    ///   <para>rdfs:label : has registry name^^xsd:string</para>
    ///   <para>skos:definition : denotes a name for the registry, for example, for a business registry in which a business registration identifier for the legal entity is registered^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistryName">fibo-fbc-fct-breg:hasRegistryName</a>
    /// </summary>
    let hasRegistryName = _prefixId.prefix "hasRegistryName"
    /// <summary>
    ///   <para>rdfs:label : has renewal date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date by which a specific registration in the registry must be renewed or updated^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURIcmns-av:adaptedFrom : https://www.swift.com/standards/data-standards/bic?tl=en#BICPolicyandDatarecord^^xsd:anyURI</para>
    ///   <para>cmns-av:usageNote : This property is equivalent to the date of expiry in some registries, such as the BIC registry.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRenewalDate">fibo-fbc-fct-breg:hasRenewalDate</a>
    /// </summary>
    let hasRenewalDate = _prefixId.prefix "hasRenewalDate"
    /// <summary>
    ///   <para>rdfs:label : has trading or operational name^^xsd:string</para>
    ///   <para>skos:definition : denotes a 'trading as', 'brand name', 'doing business as', or 'operating under' name currently used by the entity in addition to, but not replacing, the (primary) legal, official registered name^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTradingOrOperationalName">fibo-fbc-fct-breg:hasTradingOrOperationalName</a>
    /// </summary>
    let hasTradingOrOperationalName = _prefixId.prefix "hasTradingOrOperationalName"
    /// <summary>
    ///   <para>rdfs:label : has transliterated legal name^^xsd:string</para>
    ///   <para>skos:definition : denotes an optional ASCII-transliterated (i.e. Latin- or Romanized) representation of the legal name for the entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTransliteratedLegalName">fibo-fbc-fct-breg:hasTransliteratedLegalName</a>
    /// </summary>
    let hasTransliteratedLegalName = _prefixId.prefix "hasTransliteratedLegalName"
    /// <summary>
    ///   <para>rdfs:label : has validation authority^^xsd:string</para>
    ///   <para>skos:definition : identifies the business registration authority for the legal entity, used by the Local Operating Unit (LOU) as the basis for validation, as defined in the GLEIF Registration Authorities List^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationAuthority">fibo-fbc-fct-breg:hasValidationAuthority</a>
    /// </summary>
    let hasValidationAuthority = _prefixId.prefix "hasValidationAuthority"
    /// <summary>
    ///   <para>rdfs:label : has validation date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date that a specific registration in the registry was most recently reviewed and validated^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.swift.com/standards/data-standards/bic?tl=en#BICPolicyandDatarecord^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationDate">fibo-fbc-fct-breg:hasValidationDate</a>
    /// </summary>
    let hasValidationDate = _prefixId.prefix "hasValidationDate"
    /// <summary>
    ///   <para>rdfs:label : has validation level^^xsd:string</para>
    ///   <para>skos:definition : indicates the level of validation performed by the registrar with respect to the legal entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationLevel">fibo-fbc-fct-breg:hasValidationLevel</a>
    /// </summary>
    let hasValidationLevel = _prefixId.prefix "hasValidationLevel"
    /// <summary>
    ///   <para>rdfs:label : is self-maintained^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the information about the entity is maintained internally or by a third-party^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.swift.com/standards/data-standards/bic?tl=en#BICPolicyandDatarecord^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/isSelfMaintained">fibo-fbc-fct-breg:isSelfMaintained</a>
    /// </summary>
    let isSelfMaintained = _prefixId.prefix "isSelfMaintained"
