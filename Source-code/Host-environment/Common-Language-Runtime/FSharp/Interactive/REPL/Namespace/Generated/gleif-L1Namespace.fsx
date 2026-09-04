#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-L1`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L1/" "gleif-L1"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : The legal entity is a branch of another legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : branch^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/Branch">gleif-L1:Branch</a>
    /// </summary>
    let Branch = _prefixId.prefix "Branch"
    /// <summary>
    ///   <para>skos:definition : The legal entity is a branch of another legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : business registry identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/BusinessRegistryIdentifier">gleif-L1:BusinessRegistryIdentifier</a>
    /// </summary>
    let BusinessRegistryIdentifier = _prefixId.prefix "BusinessRegistryIdentifier"
    /// <summary>
    ///   <para>skos:definition : The legal entity is a fund.^^xsd:string</para>
    ///   <para>rdfs:label : fund^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/Fund">gleif-L1:Fund</a>
    /// </summary>
    let Fund = _prefixId.prefix "Fund"
    /// <summary>
    ///   <para>skos:definition : The entity that is the manager of one or more funds.^^xsd:string</para>
    ///   <para>rdfs:label : fund family^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/FundFamily">gleif-L1:FundFamily</a>
    /// </summary>
    let FundFamily = _prefixId.prefix "FundFamily"

    let GlobalLegalEntityIdentifierSystem =
        _prefixId.prefix "GlobalLegalEntityIdentifierSystem"

    /// <summary>
    ///   <para>skos:prefLabel : LEI^^xsd:string</para>
    ///   <para>skos:definition : The ISO 17442 compatible identifier for the legal entity recorded.^^xsd:string</para>
    ///   <para>skos:altLabel : has LEI string^^xsd:string</para>
    ///   <para>rdfs:label : LEI^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/LEI">gleif-L1:LEI</a>
    /// </summary>
    let LEI = _prefixId.prefix "LEI"
    /// <summary>
    ///   <para>skos:definition : LEI-registered entities that are legally or financially responsible for the performance of financial transactions or have the legal right in their jurisdiction to enter independently into legal contracts, regardless of whether they are incorporated or constituted in some other way (e.g. trust, partnership, contractual). It excludes natural persons, but includes governmental organizations and supranationals.^^xsd:string</para>
    ///   <para>rdfs:label : legal entity^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/LegalEntity">gleif-L1:LegalEntity</a>
    /// </summary>
    let LegalEntity = _prefixId.prefix "LegalEntity"
    /// <summary>
    ///   <para>skos:definition : The ISO 17442 compatible identifier for the legal entity referenced.^^xsd:string</para>
    ///   <para>rdfs:label : legal entity identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/LegalEntityIdentifier">gleif-L1:LegalEntityIdentifier</a>
    /// </summary>
    let LegalEntityIdentifier = _prefixId.prefix "LegalEntityIdentifier"

    /// <summary>
    ///   <para>rdfs:label : legal entity identifier registry entry^^xsd:string</para>
    ///   <para>skos:definition : The Registration container element which contains all information on the legal entity's LEI registration with the Managing LOU.^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/LegalEntityIdentifierRegistryEntry">gleif-L1:LegalEntityIdentifierRegistryEntry</a>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "LegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <para>skos:prefLabel : local operating unit^^xsd:string</para>
    ///   <para>skos:definition : An entity that supplies registration, renewal and other services, and acts as the primary interface for legal entities wishing to obtain an LEI. Only organizations duly accredited by the Global Legal Entity Identifier Foundation (GLEIF) are authorized to issue LEIs.^^xsd:string</para>
    ///   <para>skos:altLabel : LOU^^xsd:stringskos:altLabel : LEI issuer^^xsd:string</para>
    ///   <para>rdfs:label : local operating unit^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/LocalOperatingUnit">gleif-L1:LocalOperatingUnit</a>
    /// </summary>
    let LocalOperatingUnit = _prefixId.prefix "LocalOperatingUnit"
    /// <summary>
    ///   <para>skos:definition : LEI-registered entities including, but not limited to, unique parties that are legally or financially responsible for the performance of financial transactions or have the legal right in their jurisdiction to enter independently into legal contracts, regardless of whether they are incorporated or constituted in some other way (e.g. trust, partnership, contractual). It excludes natural persons, but includes governmental organizations and supranationals.^^xsd:string</para>
    ///   <para>rdfs:label : registered entity^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/RegisteredEntity">gleif-L1:RegisteredEntity</a>
    /// </summary>
    let RegisteredEntity = _prefixId.prefix "RegisteredEntity"
    /// <summary>
    ///   <para>skos:definition : The status of the legal entity's LEI registration with the Managing LOU.^^xsd:string</para>
    ///   <para>rdfs:label : legal entity identifier registration status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/RegistrationStatus">gleif-L1:RegistrationStatus</a>
    /// </summary>
    let RegistrationStatus = _prefixId.prefix "RegistrationStatus"
    let RegistrationStatusAnnulled = _prefixId.prefix "RegistrationStatusAnnulled"
    let RegistrationStatusDuplicate = _prefixId.prefix "RegistrationStatusDuplicate"
    let RegistrationStatusIssued = _prefixId.prefix "RegistrationStatusIssued"
    let RegistrationStatusLapsed = _prefixId.prefix "RegistrationStatusLapsed"
    let RegistrationStatusMerged = _prefixId.prefix "RegistrationStatusMerged"

    let RegistrationStatusPendingArchival =
        _prefixId.prefix "RegistrationStatusPendingArchival"

    let RegistrationStatusPendingTransfer =
        _prefixId.prefix "RegistrationStatusPendingTransfer"

    let RegistrationStatusRetired = _prefixId.prefix "RegistrationStatusRetired"
    /// <summary>
    ///   <para>skos:definition : The legal entity represents an individual acting in a business capacity^^xsd:string</para>
    ///   <para>rdfs:label : sole proprietor^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/SoleProprietor">gleif-L1:SoleProprietor</a>
    /// </summary>
    let SoleProprietor = _prefixId.prefix "SoleProprietor"
    /// <summary>
    ///   <para>skos:definition : The level of validation of the reference data provided by the registrant.^^xsd:string</para>
    ///   <para>rdfs:label : LEI validation source kind^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/ValidationSourceKind">gleif-L1:ValidationSourceKind</a>
    /// </summary>
    let ValidationSourceKind = _prefixId.prefix "ValidationSourceKind"

    let ValidationSourceKindEntitySuppliedOnly =
        _prefixId.prefix "ValidationSourceKindEntitySuppliedOnly"

    let ValidationSourceKindFullyCorroborated =
        _prefixId.prefix "ValidationSourceKindFullyCorroborated"

    let ValidationSourceKindPartiallyCorroborated =
        _prefixId.prefix "ValidationSourceKindPartiallyCorroborated"

    /// <summary>
    ///   <para>skos:definition : Address of the headquarters of the entity, in an alternative language used in the legal jurisdiction.^^xsd:string</para>
    ///   <para>rdfs:label : has alternative language headquarters address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageHeadquartersAddress">gleif-L1:hasAlternativeLanguageHeadquartersAddress</a>
    /// </summary>
    let hasAlternativeLanguageHeadquartersAddress =
        _prefixId.prefix "hasAlternativeLanguageHeadquartersAddress"

    /// <summary>
    ///   <para>skos:definition : Registered address of the entity in the legal jurisdiction, in analternative language used in the legal jurisdiction.^^xsd:string</para>
    ///   <para>rdfs:label : has alternative language legal address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalAddress">gleif-L1:hasAlternativeLanguageLegalAddress</a>
    /// </summary>
    let hasAlternativeLanguageLegalAddress =
        _prefixId.prefix "hasAlternativeLanguageLegalAddress"

    /// <summary>
    ///   <para>skos:definition : Registered name of the entity in an alternative language in the legal jurisdiction in which the entity is registered.^^xsd:string</para>
    ///   <para>rdfs:label : has other entity names^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalName">gleif-L1:hasAlternativeLanguageLegalName</a>
    /// </summary>
    let hasAlternativeLanguageLegalName =
        _prefixId.prefix "hasAlternativeLanguageLegalName"

    /// <summary>
    ///   <para>skos:definition : Another entity associated with this entity if needed to fully identify this entity or to place it in an appropriate context.^^xsd:string</para>
    ///   <para>rdfs:label : has associated entity^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAssociatedEntity">gleif-L1:hasAssociatedEntity</a>
    /// </summary>
    let hasAssociatedEntity = _prefixId.prefix "hasAssociatedEntity"
    /// <summary>
    ///   <para>skos:definition : The name of another entity associated with this entity if needed to fully identify this entity or to place it in an appropriate context.^^xsd:string</para>
    ///   <para>rdfs:label : has associated entity name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAssociatedEntityName">gleif-L1:hasAssociatedEntityName</a>
    /// </summary>
    let hasAssociatedEntityName = _prefixId.prefix "hasAssociatedEntityName"

    /// <summary>
    ///   <para>skos:definition : Auto transliterated headquarters address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has auto ASCII transliterated headquarters address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedHeadquartersAddress">gleif-L1:hasAutoASCIITransliteratedHeadquartersAddress</a>
    /// </summary>
    let hasAutoASCIITransliteratedHeadquartersAddress =
        _prefixId.prefix "hasAutoASCIITransliteratedHeadquartersAddress"

    /// <summary>
    ///   <para>skos:definition : Auto transliterated legal address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has auto ASCII transliterated legal address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalAddress">gleif-L1:hasAutoASCIITransliteratedLegalAddress</a>
    /// </summary>
    let hasAutoASCIITransliteratedLegalAddress =
        _prefixId.prefix "hasAutoASCIITransliteratedLegalAddress"

    /// <summary>
    ///   <para>skos:definition : Legal name of the entity transliterated to ASCII characters, auto-transliterated by the managing LOU.^^xsd:string</para>
    ///   <para>rdfs:label : has auto ASCII transliterated legal name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalName">gleif-L1:hasAutoASCIITransliteratedLegalName</a>
    /// </summary>
    let hasAutoASCIITransliteratedLegalName =
        _prefixId.prefix "hasAutoASCIITransliteratedLegalName"

    /// <summary>
    ///   <para>skos:definition : The identifier of the entity at the indicated registration authority. Typically, the identifier of the legal entity as maintained by a business registry in the jurisdiction of legal registration, or if the entity is one that is not recorded in a business registry (e.g. one of the varieties of funds registered instead with financial regulators), the identifier of the entity in the appropriate registration authority.^^xsd:string</para>
    ///   <para>rdfs:label : has entity id^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasEntityID">gleif-L1:hasEntityID</a>
    /// </summary>
    let hasEntityID = _prefixId.prefix "hasEntityID"
    /// <summary>
    ///   <para>skos:definition : The entity that is the manager of the fund.^^xsd:string</para>
    ///   <para>rdfs:label : has fund family^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasFundFamily">gleif-L1:hasFundFamily</a>
    /// </summary>
    let hasFundFamily = _prefixId.prefix "hasFundFamily"
    /// <summary>
    ///   <para>skos:definition : The name of an entity that is the manager of the fund.^^xsd:string</para>
    ///   <para>rdfs:label : has fund family name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasFundFamilyName">gleif-L1:hasFundFamilyName</a>
    /// </summary>
    let hasFundFamilyName = _prefixId.prefix "hasFundFamilyName"
    /// <summary>
    ///   <para>skos:definition : The primary address of the headquarters of the Entity.^^xsd:string</para>
    ///   <para>rdfs:label : has headquarters address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasHeadquartersAddress">gleif-L1:hasHeadquartersAddress</a>
    /// </summary>
    let hasHeadquartersAddress = _prefixId.prefix "hasHeadquartersAddress"
    /// <summary>
    ///   <para>skos:definition : The primary legal address of the entity as recorded in the registration of the entity in its legal jurisdiction.^^xsd:string</para>
    ///   <para>rdfs:label : has legal address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasLegalAddress">gleif-L1:hasLegalAddress</a>
    /// </summary>
    let hasLegalAddress = _prefixId.prefix "hasLegalAddress"
    /// <summary>
    ///   <para>skos:definition : The legal form of the entity, taken from the ISO 20275 Entity Legal Form (ELF) data set maintained by GLEIF.^^xsd:string</para>
    ///   <para>rdfs:label : has legal form^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasLegalForm">gleif-L1:hasLegalForm</a>
    /// </summary>
    let hasLegalForm = _prefixId.prefix "hasLegalForm"
    /// <summary>
    ///   <para>skos:definition : A legacy code or textual description for the legal entity's legal form, used until a current code from the GLEIF-maintained list can be used.^^xsd:string</para>
    ///   <para>rdfs:label : has legal form^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasLegalFormText">gleif-L1:hasLegalFormText</a>
    /// </summary>
    let hasLegalFormText = _prefixId.prefix "hasLegalFormText"
    /// <summary>
    ///   <para>skos:definition : The legal name of the entity.^^xsd:string</para>
    ///   <para>rdfs:label : has legal name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasLegalName">gleif-L1:hasLegalName</a>
    /// </summary>
    let hasLegalName = _prefixId.prefix "hasLegalName"
    /// <summary>
    ///   <para>skos:definition : The LOU that is responsible for administering this LEI registration.^^xsd:string</para>
    ///   <para>rdfs:label : has managing LOU^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasManagingLOU">gleif-L1:hasManagingLOU</a>
    /// </summary>
    let hasManagingLOU = _prefixId.prefix "hasManagingLOU"
    /// <summary>
    ///   <para>skos:definition : An optional list of other addresses for the legal entity, excluding transliterations.^^xsd:string</para>
    ///   <para>rdfs:label : has other addresses^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasOtherAddresses">gleif-L1:hasOtherAddresses</a>
    /// </summary>
    let hasOtherAddresses = _prefixId.prefix "hasOtherAddresses"
    /// <summary>
    ///   <para>skos:definition : A legacy / historical reference code of a registration authority which is not yet entered in the Registration Authorities Code List (RAL) maintained by GLEIF, or the designation of an interim register until such time as an entry from RAL can be delivered. ^^xsd:string</para>
    ///   <para>rdfs:label : has other authority^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasOtherAuthority">gleif-L1:hasOtherAuthority</a>
    /// </summary>
    let hasOtherAuthority = _prefixId.prefix "hasOtherAuthority"
    /// <summary>
    ///   <para>skos:note : Not expected to be used directly: use one of its subProperties.^^xsd:string</para>
    ///   <para>skos:definition : An optional list of other names (excluding transliterations) for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has other entity names^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasOtherEntityNames">gleif-L1:hasOtherEntityNames</a>
    /// </summary>
    let hasOtherEntityNames = _prefixId.prefix "hasOtherEntityNames"
    /// <summary>
    ///   <para>skos:prefLabel : has other validation identifier^^xsd:string</para>
    ///   <para>skos:definition : An optional list of additional registrations used by the LEI Issuer to validate the entity data.^^xsd:string</para>
    ///   <para>skos:altLabel : has additional validation identifier^^xsd:string</para>
    ///   <para>rdfs:label : has other validation identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasOtherValidationIdentifier">gleif-L1:hasOtherValidationIdentifier</a>
    /// </summary>
    let hasOtherValidationIdentifier = _prefixId.prefix "hasOtherValidationIdentifier"

    /// <summary>
    ///   <para>skos:definition : Preferred transliterated headquarters address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has preferred ASCII transliterated headquarters address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedHeadquartersAddress">gleif-L1:hasPreferredASCIITransliteratedHeadquartersAddress</a>
    /// </summary>
    let hasPreferredASCIITransliteratedHeadquartersAddress =
        _prefixId.prefix "hasPreferredASCIITransliteratedHeadquartersAddress"

    /// <summary>
    ///   <para>skos:definition : Preferred transliterated legal address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has preferred ASCII transliterated legal address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalAddress">gleif-L1:hasPreferredASCIITransliteratedLegalAddress</a>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalAddress =
        _prefixId.prefix "hasPreferredASCIITransliteratedLegalAddress"

    /// <summary>
    ///   <para>skos:definition : Legal name of the entity transliterated to ASCII characters, provided by the entity for this purpose.^^xsd:string</para>
    ///   <para>rdfs:label : has preferred ASCII transliterated legal name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalName">gleif-L1:hasPreferredASCIITransliteratedLegalName</a>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalName =
        _prefixId.prefix "hasPreferredASCIITransliteratedLegalName"

    /// <summary>
    ///   <para>skos:definition : A primary legal name previously used by this entity.^^xsd:string</para>
    ///   <para>rdfs:label : has previous legal name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasPreviousLegalName">gleif-L1:hasPreviousLegalName</a>
    /// </summary>
    let hasPreviousLegalName = _prefixId.prefix "hasPreviousLegalName"
    /// <summary>
    ///   <para>skos:definition : The reference of the registration authority, taken from the Registration Authorities Code List (RAL) maintained by GLEIF.^^xsd:string</para>
    ///   <para>rdfs:label : has registered authority^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasRegisteredAuthority">gleif-L1:hasRegisteredAuthority</a>
    /// </summary>
    let hasRegisteredAuthority = _prefixId.prefix "hasRegisteredAuthority"
    /// <summary>
    ///   <para>skos:prefLabel : has registration identifier^^xsd:string</para>
    ///   <para>skos:definition : An identifier for the legal entity in a business registry in the jurisdiction of legal registration, or in the appropriate registration authority.^^xsd:string</para>
    ///   <para>skos:altLabel : has registration authority^^xsd:stringskos:altLabel : has business register entity ID^^xsd:string</para>
    ///   <para>rdfs:label : has registration identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasRegistrationIdentifier">gleif-L1:hasRegistrationIdentifier</a>
    /// </summary>
    let hasRegistrationIdentifier = _prefixId.prefix "hasRegistrationIdentifier"
    /// <summary>
    ///   <para>skos:altLabel : brand name^^xsd:stringskos:altLabel : operating under^^xsd:stringskos:altLabel : doing business as^^xsd:stringskos:altLabel : has trading or operating name^^xsd:stringskos:altLabel : trading as^^xsd:string</para>
    ///   <para>rdfs:label : has trading or operating name^^xsd:string</para>
    ///   <para>skos:definition : A 'trading as', 'brand name' or 'operating under' name currently used by this entity in addition to, but not replacing, the (primary) legal, official registered name^^xsd:string</para>
    ///   <para>skos:prefLabel : has trading or operating name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasTradingOrOperatingName">gleif-L1:hasTradingOrOperatingName</a>
    /// </summary>
    let hasTradingOrOperatingName = _prefixId.prefix "hasTradingOrOperatingName"

    /// <summary>
    ///   <para>skos:definition : A transliterated headquarters address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has transliterated headquarters address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasTransliteratedHeadquartersAddress">gleif-L1:hasTransliteratedHeadquartersAddress</a>
    /// </summary>
    let hasTransliteratedHeadquartersAddress =
        _prefixId.prefix "hasTransliteratedHeadquartersAddress"

    /// <summary>
    ///   <para>skos:definition : A transliterated legal address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has transliterated legal address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasTransliteratedLegalAddress">gleif-L1:hasTransliteratedLegalAddress</a>
    /// </summary>
    let hasTransliteratedLegalAddress = _prefixId.prefix "hasTransliteratedLegalAddress"

    /// <summary>
    ///   <para>skos:definition : An optional list of transliterated addresses for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has transliterated other addresses^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherAddresses">gleif-L1:hasTransliteratedOtherAddresses</a>
    /// </summary>
    let hasTransliteratedOtherAddresses =
        _prefixId.prefix "hasTransliteratedOtherAddresses"

    /// <summary>
    ///   <para>skos:note : Not expected to be used directly: use one of its subProperties.^^xsd:string</para>
    ///   <para>skos:definition : An optional list of ASCII-transliterated (i.e. Latin- or Romanized) representations of names for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has transliterated other entity names^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherEntityNames">gleif-L1:hasTransliteratedOtherEntityNames</a>
    /// </summary>
    let hasTransliteratedOtherEntityNames =
        _prefixId.prefix "hasTransliteratedOtherEntityNames"

    /// <summary>
    ///   <para>skos:prefLabel : has validation identifier^^xsd:string</para>
    ///   <para>skos:definition : The (primary) registration used by the LOU to validate the entity data.^^xsd:string</para>
    ///   <para>skos:altLabel : has validation authority^^xsd:string</para>
    ///   <para>rdfs:label : has validation identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasValidationIdentifier">gleif-L1:hasValidationIdentifier</a>
    /// </summary>
    let hasValidationIdentifier = _prefixId.prefix "hasValidationIdentifier"
    /// <summary>
    ///   <para>skos:definition : The level of validation of the reference data provided by the registrant.^^xsd:string</para>
    ///   <para>rdfs:label : has validation sources^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/hasValidationSources">gleif-L1:hasValidationSources</a>
    /// </summary>
    let hasValidationSources = _prefixId.prefix "hasValidationSources"
    /// <summary>
    ///   <para>skos:definition : The legal entity that is recorded by this registry entry and identified by the LEI.^^xsd:string</para>
    ///   <para>rdfs:label : identifies and records^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L1/identifiesAndRecords">gleif-L1:identifiesAndRecords</a>
    /// </summary>
    let identifiesAndRecords = _prefixId.prefix "identifiesAndRecords"
