namespace https.www.gleif.org.ontology.Base.slash

open DoxAletheia

module gleif_base =
    let _namespace_name = "https://www.gleif.org/ontology/Base/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatusActive"></see>
    /// </summary>
    let EntityStatusActive = _prefix "EntityStatusActive"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatusInactive"></see>
    /// </summary>
    let EntityStatusInactive = _prefix "EntityStatusInactive"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonCorporateAction"></see>
    /// </summary>
    let EntityExpirationReasonCorporateAction =
        _prefix "EntityExpirationReasonCorporateAction"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonDissolved"></see>
    /// </summary>
    let EntityExpirationReasonDissolved = _prefix "EntityExpirationReasonDissolved"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonOther"></see>
    /// </summary>
    let EntityExpirationReasonOther = _prefix "EntityExpirationReasonOther"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/GLEIF"></see>
    /// </summary>
    let GLEIF = _prefix "GLEIF"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityExpirationDate"></see>
    /// </summary>
    let hasEntityExpirationDate = _prefix "hasEntityExpirationDate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSuccessor"></see>
    /// </summary>
    let hasSuccessor = _prefix "hasSuccessor"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityStatus"></see>
    /// </summary>
    let hasEntityStatus = _prefix "hasEntityStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatus"></see>
    /// </summary>
    let EntityStatus = _prefix "EntityStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityExpirationReason"></see>
    /// </summary>
    let hasEntityExpirationReason = _prefix "hasEntityExpirationReason"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReason"></see>
    /// </summary>
    let EntityExpirationReason = _prefix "EntityExpirationReason"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLegalLocal"></see>
    /// </summary>
    let hasNameLegalLocal = _prefix "hasNameLegalLocal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLegalJurisdiction"></see>
    /// </summary>
    let hasLegalJurisdiction = _prefix "hasLegalJurisdiction"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasTag"></see>
    /// </summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistrationAuthority"></see>
    /// </summary>
    let RegistrationAuthority = _prefix "RegistrationAuthority"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLegalName"></see>
    /// </summary>
    let hasLegalName = _prefix "hasLegalName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Identifier"></see>
    /// </summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/identifies"></see>
    /// </summary>
    let identifies = _prefix "identifies"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/LegalEntityRelationship"></see>
    /// </summary>
    let LegalEntityRelationship = _prefix "LegalEntityRelationship"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSource"></see>
    /// </summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasTarget"></see>
    /// </summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/LegalPerson"></see>
    /// </summary>
    let LegalPerson = _prefix "LegalPerson"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEnd"></see>
    /// </summary>
    let hasEnd = _prefix "hasEnd"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasStart"></see>
    /// </summary>
    let hasStart = _prefix "hasStart"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/PhysicalAddress"></see>
    /// </summary>
    let PhysicalAddress = _prefix "PhysicalAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressNumber"></see>
    /// </summary>
    let hasAddressNumber = _prefix "hasAddressNumber"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCity"></see>
    /// </summary>
    let hasCity = _prefix "hasCity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressNumberWithinBuilding"></see>
    /// </summary>
    let hasAddressNumberWithinBuilding = _prefix "hasAddressNumberWithinBuilding"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine1"></see>
    /// </summary>
    let hasAddressLine1 = _prefix "hasAddressLine1"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine3"></see>
    /// </summary>
    let hasAddressLine3 = _prefix "hasAddressLine3"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasMailRouting"></see>
    /// </summary>
    let hasMailRouting = _prefix "hasMailRouting"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasPostalCode"></see>
    /// </summary>
    let hasPostalCode = _prefix "hasPostalCode"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasRegion"></see>
    /// </summary>
    let hasRegion = _prefix "hasRegion"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine2"></see>
    /// </summary>
    let hasAddressLine2 = _prefix "hasAddressLine2"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine4"></see>
    /// </summary>
    let hasAddressLine4 = _prefix "hasAddressLine4"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/PhysicalAddressASCII"></see>
    /// </summary>
    let PhysicalAddressASCII = _prefix "PhysicalAddressASCII"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus = _prefix "RegistrationStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Registry"></see>
    /// </summary>
    let Registry = _prefix "Registry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isManagedBy"></see>
    /// </summary>
    let isManagedBy = _prefix "isManagedBy"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistryEntry"></see>
    /// </summary>
    let RegistryEntry = _prefix "RegistryEntry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistryIdentifier"></see>
    /// </summary>
    let RegistryIdentifier = _prefix "RegistryIdentifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isRegisteredIn"></see>
    /// </summary>
    let isRegisteredIn = _prefix "isRegisteredIn"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviation"></see>
    /// </summary>
    let hasAbbreviation = _prefix "hasAbbreviation"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviationLocal"></see>
    /// </summary>
    let hasAbbreviationLocal = _prefix "hasAbbreviationLocal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviationTransliterated"></see>
    /// </summary>
    let hasAbbreviationTransliterated = _prefix "hasAbbreviationTransliterated"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAdditionalAddressLine"></see>
    /// </summary>
    let hasAdditionalAddressLine = _prefix "hasAdditionalAddressLine"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressHeadquarters"></see>
    /// </summary>
    let hasAddressHeadquarters = _prefix "hasAddressHeadquarters"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLegal"></see>
    /// </summary>
    let hasAddressLegal = _prefix "hasAddressLegal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressTransliterated"></see>
    /// </summary>
    let hasAddressTransliterated = _prefix "hasAddressTransliterated"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasGeographicRegion"></see>
    /// </summary>
    let hasGeographicRegion = _prefix "hasGeographicRegion"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCoverageArea"></see>
    /// </summary>
    let hasCoverageArea = _prefix "hasCoverageArea"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasFirstAddressLine"></see>
    /// </summary>
    let hasFirstAddressLine = _prefix "hasFirstAddressLine"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasInitialRegistrationDate"></see>
    /// </summary>
    let hasInitialRegistrationDate = _prefix "hasInitialRegistrationDate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLastUpdateDate"></see>
    /// </summary>
    let hasLastUpdateDate = _prefix "hasLastUpdateDate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCII"></see>
    /// </summary>
    let hasNameASCII = _prefix "hasNameASCII"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTransliterated"></see>
    /// </summary>
    let hasNameTransliterated = _prefix "hasNameTransliterated"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCIIAutomatic"></see>
    /// </summary>
    let hasNameASCIIAutomatic = _prefix "hasNameASCIIAutomatic"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLegal"></see>
    /// </summary>
    let hasNameLegal = _prefix "hasNameLegal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCIIPreferred"></see>
    /// </summary>
    let hasNameASCIIPreferred = _prefix "hasNameASCIIPreferred"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameAdditional"></see>
    /// </summary>
    let hasNameAdditional = _prefix "hasNameAdditional"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameAdditionalLocal"></see>
    /// </summary>
    let hasNameAdditionalLocal = _prefix "hasNameAdditionalLocal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLocal"></see>
    /// </summary>
    let hasNameLocal = _prefix "hasNameLocal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNamePreviousLegal"></see>
    /// </summary>
    let hasNamePreviousLegal = _prefix "hasNamePreviousLegal"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTradingOrOperating"></see>
    /// </summary>
    let hasNameTradingOrOperating = _prefix "hasNameTradingOrOperating"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTranslatedEnglish"></see>
    /// </summary>
    let hasNameTranslatedEnglish = _prefix "hasNameTranslatedEnglish"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNextRenewalDate"></see>
    /// </summary>
    let hasNextRenewalDate = _prefix "hasNextRenewalDate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasRegistrationStatus"></see>
    /// </summary>
    let hasRegistrationStatus = _prefix "hasRegistrationStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSuccessorName"></see>
    /// </summary>
    let hasSuccessorName = _prefix "hasSuccessorName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasWebsite"></see>
    /// </summary>
    let hasWebsite = _prefix "hasWebsite"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isQualifiedBy"></see>
    /// </summary>
    let isQualifiedBy = _prefix "isQualifiedBy"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isQuantifiedBy"></see>
    /// </summary>
    let isQuantifiedBy = _prefix "isQuantifiedBy"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/records"></see>
    /// </summary>
    let records = _prefix "records"
