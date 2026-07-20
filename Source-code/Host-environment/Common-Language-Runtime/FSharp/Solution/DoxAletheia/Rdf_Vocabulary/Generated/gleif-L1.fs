namespace https.www.gleif.org.ontology.L1.slash

open DoxAletheia

module gleif_L1 =
    let _namespace_name = "https://www.gleif.org/ontology/L1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindEntitySuppliedOnly"></see>
    /// </summary>
    let ValidationSourceKindEntitySuppliedOnly =
        _prefix "ValidationSourceKindEntitySuppliedOnly"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindFullyCorroborated"></see>
    /// </summary>
    let ValidationSourceKindFullyCorroborated =
        _prefix "ValidationSourceKindFullyCorroborated"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindPartiallyCorroborated"></see>
    /// </summary>
    let ValidationSourceKindPartiallyCorroborated =
        _prefix "ValidationSourceKindPartiallyCorroborated"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusAnnulled"></see>
    /// </summary>
    let RegistrationStatusAnnulled = _prefix "RegistrationStatusAnnulled"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusDuplicate"></see>
    /// </summary>
    let RegistrationStatusDuplicate = _prefix "RegistrationStatusDuplicate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusIssued"></see>
    /// </summary>
    let RegistrationStatusIssued = _prefix "RegistrationStatusIssued"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusLapsed"></see>
    /// </summary>
    let RegistrationStatusLapsed = _prefix "RegistrationStatusLapsed"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingArchival"></see>
    /// </summary>
    let RegistrationStatusPendingArchival = _prefix "RegistrationStatusPendingArchival"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingTransfer"></see>
    /// </summary>
    let RegistrationStatusPendingTransfer = _prefix "RegistrationStatusPendingTransfer"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusMerged"></see>
    /// </summary>
    let RegistrationStatusMerged = _prefix "RegistrationStatusMerged"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusRetired"></see>
    /// </summary>
    let RegistrationStatusRetired = _prefix "RegistrationStatusRetired"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/Branch"></see>
    /// </summary>
    let Branch = _prefix "Branch"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegisteredEntity"></see>
    /// </summary>
    let RegisteredEntity = _prefix "RegisteredEntity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/BusinessRegistryIdentifier"></see>
    /// </summary>
    let BusinessRegistryIdentifier = _prefix "BusinessRegistryIdentifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherAuthority"></see>
    /// </summary>
    let hasOtherAuthority = _prefix "hasOtherAuthority"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasRegisteredAuthority"></see>
    /// </summary>
    let hasRegisteredAuthority = _prefix "hasRegisteredAuthority"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasEntityID"></see>
    /// </summary>
    let hasEntityID = _prefix "hasEntityID"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/Fund"></see>
    /// </summary>
    let Fund = _prefix "Fund"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasFundFamily"></see>
    /// </summary>
    let hasFundFamily = _prefix "hasFundFamily"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/FundFamily"></see>
    /// </summary>
    let FundFamily = _prefix "FundFamily"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasFundFamilyName"></see>
    /// </summary>
    let hasFundFamilyName = _prefix "hasFundFamilyName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntity"></see>
    /// </summary>
    let LegalEntity = _prefix "LegalEntity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/GlobalLegalEntityIdentifierSystem"></see>
    /// </summary>
    let GlobalLegalEntityIdentifierSystem = _prefix "GlobalLegalEntityIdentifierSystem"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LEI"></see>
    /// </summary>
    let LEI = _prefix "LEI"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntityIdentifier"></see>
    /// </summary>
    let LegalEntityIdentifier = _prefix "LegalEntityIdentifier"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        _prefix "LegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasValidationIdentifier"></see>
    /// </summary>
    let hasValidationIdentifier = _prefix "hasValidationIdentifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasManagingLOU"></see>
    /// </summary>
    let hasManagingLOU = _prefix "hasManagingLOU"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LocalOperatingUnit"></see>
    /// </summary>
    let LocalOperatingUnit = _prefix "LocalOperatingUnit"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasValidationSources"></see>
    /// </summary>
    let hasValidationSources = _prefix "hasValidationSources"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/identifiesAndRecords"></see>
    /// </summary>
    let identifiesAndRecords = _prefix "identifiesAndRecords"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherValidationIdentifier"></see>
    /// </summary>
    let hasOtherValidationIdentifier = _prefix "hasOtherValidationIdentifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherAddresses"></see>
    /// </summary>
    let hasOtherAddresses = _prefix "hasOtherAddresses"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalAddress"></see>
    /// </summary>
    let hasLegalAddress = _prefix "hasLegalAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalName"></see>
    /// </summary>
    let hasLegalName = _prefix "hasLegalName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasRegistrationIdentifier"></see>
    /// </summary>
    let hasRegistrationIdentifier = _prefix "hasRegistrationIdentifier"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasHeadquartersAddress"></see>
    /// </summary>
    let hasHeadquartersAddress = _prefix "hasHeadquartersAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedLegalAddress"></see>
    /// </summary>
    let hasTransliteratedLegalAddress = _prefix "hasTransliteratedLegalAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasTransliteratedHeadquartersAddress =
        _prefix "hasTransliteratedHeadquartersAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherEntityNames"></see>
    /// </summary>
    let hasOtherEntityNames = _prefix "hasOtherEntityNames"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalForm"></see>
    /// </summary>
    let hasLegalForm = _prefix "hasLegalForm"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalFormText"></see>
    /// </summary>
    let hasLegalFormText = _prefix "hasLegalFormText"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus = _prefix "RegistrationStatus"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/SoleProprietor"></see>
    /// </summary>
    let SoleProprietor = _prefix "SoleProprietor"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKind"></see>
    /// </summary>
    let ValidationSourceKind = _prefix "ValidationSourceKind"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageHeadquartersAddress"></see>
    /// </summary>
    let hasAlternativeLanguageHeadquartersAddress =
        _prefix "hasAlternativeLanguageHeadquartersAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalAddress"></see>
    /// </summary>
    let hasAlternativeLanguageLegalAddress =
        _prefix "hasAlternativeLanguageLegalAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalName"></see>
    /// </summary>
    let hasAlternativeLanguageLegalName = _prefix "hasAlternativeLanguageLegalName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAssociatedEntity"></see>
    /// </summary>
    let hasAssociatedEntity = _prefix "hasAssociatedEntity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAssociatedEntityName"></see>
    /// </summary>
    let hasAssociatedEntityName = _prefix "hasAssociatedEntityName"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasAutoASCIITransliteratedHeadquartersAddress =
        _prefix "hasAutoASCIITransliteratedHeadquartersAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalAddress"></see>
    /// </summary>
    let hasAutoASCIITransliteratedLegalAddress =
        _prefix "hasAutoASCIITransliteratedLegalAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalName"></see>
    /// </summary>
    let hasAutoASCIITransliteratedLegalName =
        _prefix "hasAutoASCIITransliteratedLegalName"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherEntityNames"></see>
    /// </summary>
    let hasTransliteratedOtherEntityNames = _prefix "hasTransliteratedOtherEntityNames"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedHeadquartersAddress =
        _prefix "hasPreferredASCIITransliteratedHeadquartersAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalAddress"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalAddress =
        _prefix "hasPreferredASCIITransliteratedLegalAddress"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalName"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalName =
        _prefix "hasPreferredASCIITransliteratedLegalName"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreviousLegalName"></see>
    /// </summary>
    let hasPreviousLegalName = _prefix "hasPreviousLegalName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTradingOrOperatingName"></see>
    /// </summary>
    let hasTradingOrOperatingName = _prefix "hasTradingOrOperatingName"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherAddresses"></see>
    /// </summary>
    let hasTransliteratedOtherAddresses = _prefix "hasTransliteratedOtherAddresses"
