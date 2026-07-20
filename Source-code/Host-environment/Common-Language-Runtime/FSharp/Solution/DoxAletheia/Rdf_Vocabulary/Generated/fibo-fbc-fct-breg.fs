namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessRegistries.slash

open DoxAletheia

module fibo_fbc_fct_breg =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/ActiveStatus"></see>
    /// </summary>
    let ActiveStatus = _prefix "ActiveStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityStatus"></see>
    /// </summary>
    let EntityStatus = _prefix "EntityStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/AnnulledStatus"></see>
    /// </summary>
    let AnnulledStatus = _prefix "AnnulledStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus = _prefix "RegistrationStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegisterIdentifier"></see>
    /// </summary>
    let BusinessRegisterIdentifier = _prefix "BusinessRegisterIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistry"></see>
    /// </summary>
    let BusinessRegistry = _prefix "BusinessRegistry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistrationAuthority"></see>
    /// </summary>
    let BusinessRegistrationAuthority = _prefix "BusinessRegistrationAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistryName"></see>
    /// </summary>
    let hasRegistryName = _prefix "hasRegistryName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistryEntry"></see>
    /// </summary>
    let BusinessRegistryEntry = _prefix "BusinessRegistryEntry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationStatus"></see>
    /// </summary>
    let hasRegistrationStatus = _prefix "hasRegistrationStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/CancelledStatus"></see>
    /// </summary>
    let CancelledStatus = _prefix "CancelledStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/DuplicateStatus"></see>
    /// </summary>
    let DuplicateStatus = _prefix "DuplicateStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReason"></see>
    /// </summary>
    let EntityExpirationReason = _prefix "EntityExpirationReason"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonCorporateAction"></see>
    /// </summary>
    let EntityExpirationReasonCorporateAction =
        _prefix "EntityExpirationReasonCorporateAction"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonDissolved"></see>
    /// </summary>
    let EntityExpirationReasonDissolved = _prefix "EntityExpirationReasonDissolved"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonOther"></see>
    /// </summary>
    let EntityExpirationReasonOther = _prefix "EntityExpirationReasonOther"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistry"></see>
    /// </summary>
    let EntityLegalFormRegistry = _prefix "EntityLegalFormRegistry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistryEntry"></see>
    /// </summary>
    let EntityLegalFormRegistryEntry = _prefix "EntityLegalFormRegistryEntry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevel"></see>
    /// </summary>
    let EntityValidationLevel = _prefix "EntityValidationLevel"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelEntitySuppliedOnly"></see>
    /// </summary>
    let EntityValidationLevelEntitySuppliedOnly =
        _prefix "EntityValidationLevelEntitySuppliedOnly"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelFullyCorroborated"></see>
    /// </summary>
    let EntityValidationLevelFullyCorroborated =
        _prefix "EntityValidationLevelFullyCorroborated"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelPartiallyCorroborated"></see>
    /// </summary>
    let EntityValidationLevelPartiallyCorroborated =
        _prefix "EntityValidationLevelPartiallyCorroborated"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/InactiveStatus"></see>
    /// </summary>
    let InactiveStatus = _prefix "InactiveStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/IssuedStatus"></see>
    /// </summary>
    let IssuedStatus = _prefix "IssuedStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LapsedStatus"></see>
    /// </summary>
    let LapsedStatus = _prefix "LapsedStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistry = _prefix "LegalEntityIdentifierRegistry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        _prefix "LegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationAuthority"></see>
    /// </summary>
    let hasValidationAuthority = _prefix "hasValidationAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationLevel"></see>
    /// </summary>
    let hasValidationLevel = _prefix "hasValidationLevel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LocalOperatingUnit"></see>
    /// </summary>
    let LocalOperatingUnit = _prefix "LocalOperatingUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/MergedStatus"></see>
    /// </summary>
    let MergedStatus = _prefix "MergedStatus"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemCode"></see>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemCode =
        _prefix "NorthAmericanIndustryClassificationSystemCode"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemScheme"></see>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemScheme =
        _prefix "NorthAmericanIndustryClassificationSystemScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingArchivalStatus"></see>
    /// </summary>
    let PendingArchivalStatus = _prefix "PendingArchivalStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingTransferStatus"></see>
    /// </summary>
    let PendingTransferStatus = _prefix "PendingTransferStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingValidationStatus"></see>
    /// </summary>
    let PendingValidationStatus = _prefix "PendingValidationStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationAuthorityCode"></see>
    /// </summary>
    let RegistrationAuthorityCode = _prefix "RegistrationAuthorityCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RetiredStatus"></see>
    /// </summary>
    let RetiredStatus = _prefix "RetiredStatus"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationCode"></see>
    /// </summary>
    let StandardIndustrialClassificationCode =
        _prefix "StandardIndustrialClassificationCode"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationScheme"></see>
    /// </summary>
    let StandardIndustrialClassificationScheme =
        _prefix "StandardIndustrialClassificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/TransferredStatus"></see>
    /// </summary>
    let TransferredStatus = _prefix "TransferredStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAlternativeLanguageLegalName"></see>
    /// </summary>
    let hasAlternativeLanguageLegalName = _prefix "hasAlternativeLanguageLegalName"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAutomaticallyTransliteratedLegalName"></see>
    /// </summary>
    let hasAutomaticallyTransliteratedLegalName =
        _prefix "hasAutomaticallyTransliteratedLegalName"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTransliteratedLegalName"></see>
    /// </summary>
    let hasTransliteratedLegalName = _prefix "hasTransliteratedLegalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationDate"></see>
    /// </summary>
    let hasEntityExpirationDate = _prefix "hasEntityExpirationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasExpiryDate"></see>
    /// </summary>
    let hasExpiryDate = _prefix "hasExpiryDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationReason"></see>
    /// </summary>
    let hasEntityExpirationReason = _prefix "hasEntityExpirationReason"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityStatus"></see>
    /// </summary>
    let hasEntityStatus = _prefix "hasEntityStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasInitialRegistrationDate"></see>
    /// </summary>
    let hasInitialRegistrationDate = _prefix "hasInitialRegistrationDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPreferredTransliteratedLegalName"></see>
    /// </summary>
    let hasPreferredTransliteratedLegalName =
        _prefix "hasPreferredTransliteratedLegalName"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPriorLegalName"></see>
    /// </summary>
    let hasPriorLegalName = _prefix "hasPriorLegalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationRevisionDate"></see>
    /// </summary>
    let hasRegistrationRevisionDate = _prefix "hasRegistrationRevisionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRenewalDate"></see>
    /// </summary>
    let hasRenewalDate = _prefix "hasRenewalDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTradingOrOperationalName"></see>
    /// </summary>
    let hasTradingOrOperationalName = _prefix "hasTradingOrOperationalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationDate"></see>
    /// </summary>
    let hasValidationDate = _prefix "hasValidationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/isSelfMaintained"></see>
    /// </summary>
    let isSelfMaintained = _prefix "isSelfMaintained"
