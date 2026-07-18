namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessRegistries.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_breg =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/ActiveStatus"></see>
    /// </summary>
    let ActiveStatus =
        Namespaced_IRI.parse _namespace_name "ActiveStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityStatus"></see>
    /// </summary>
    let EntityStatus =
        Namespaced_IRI.parse _namespace_name "EntityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/AnnulledStatus"></see>
    /// </summary>
    let AnnulledStatus =
        Namespaced_IRI.parse _namespace_name "AnnulledStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus =
        Namespaced_IRI.parse _namespace_name "RegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegisterIdentifier"></see>
    /// </summary>
    let BusinessRegisterIdentifier =
        Namespaced_IRI.parse _namespace_name "BusinessRegisterIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistry"></see>
    /// </summary>
    let BusinessRegistry =
        Namespaced_IRI.parse _namespace_name "BusinessRegistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistrationAuthority"></see>
    /// </summary>
    let BusinessRegistrationAuthority =
        Namespaced_IRI.parse _namespace_name "BusinessRegistrationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistryName"></see>
    /// </summary>
    let hasRegistryName =
        Namespaced_IRI.parse _namespace_name "hasRegistryName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistryEntry"></see>
    /// </summary>
    let BusinessRegistryEntry =
        Namespaced_IRI.parse _namespace_name "BusinessRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationStatus"></see>
    /// </summary>
    let hasRegistrationStatus =
        Namespaced_IRI.parse _namespace_name "hasRegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/CancelledStatus"></see>
    /// </summary>
    let CancelledStatus =
        Namespaced_IRI.parse _namespace_name "CancelledStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/DuplicateStatus"></see>
    /// </summary>
    let DuplicateStatus =
        Namespaced_IRI.parse _namespace_name "DuplicateStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReason"></see>
    /// </summary>
    let EntityExpirationReason =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonCorporateAction"></see>
    /// </summary>
    let EntityExpirationReasonCorporateAction =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonCorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonDissolved"></see>
    /// </summary>
    let EntityExpirationReasonDissolved =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonDissolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonOther"></see>
    /// </summary>
    let EntityExpirationReasonOther =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonOther" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistry"></see>
    /// </summary>
    let EntityLegalFormRegistry =
        Namespaced_IRI.parse _namespace_name "EntityLegalFormRegistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistryEntry"></see>
    /// </summary>
    let EntityLegalFormRegistryEntry =
        Namespaced_IRI.parse _namespace_name "EntityLegalFormRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevel"></see>
    /// </summary>
    let EntityValidationLevel =
        Namespaced_IRI.parse _namespace_name "EntityValidationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelEntitySuppliedOnly"></see>
    /// </summary>
    let EntityValidationLevelEntitySuppliedOnly =
        Namespaced_IRI.parse _namespace_name "EntityValidationLevelEntitySuppliedOnly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelFullyCorroborated"></see>
    /// </summary>
    let EntityValidationLevelFullyCorroborated =
        Namespaced_IRI.parse _namespace_name "EntityValidationLevelFullyCorroborated" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelPartiallyCorroborated"></see>
    /// </summary>
    let EntityValidationLevelPartiallyCorroborated =
        Namespaced_IRI.parse _namespace_name "EntityValidationLevelPartiallyCorroborated" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/InactiveStatus"></see>
    /// </summary>
    let InactiveStatus =
        Namespaced_IRI.parse _namespace_name "InactiveStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/IssuedStatus"></see>
    /// </summary>
    let IssuedStatus =
        Namespaced_IRI.parse _namespace_name "IssuedStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LapsedStatus"></see>
    /// </summary>
    let LapsedStatus =
        Namespaced_IRI.parse _namespace_name "LapsedStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistry =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifierRegistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifierRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationAuthority"></see>
    /// </summary>
    let hasValidationAuthority =
        Namespaced_IRI.parse _namespace_name "hasValidationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationLevel"></see>
    /// </summary>
    let hasValidationLevel =
        Namespaced_IRI.parse _namespace_name "hasValidationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LocalOperatingUnit"></see>
    /// </summary>
    let LocalOperatingUnit =
        Namespaced_IRI.parse _namespace_name "LocalOperatingUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/MergedStatus"></see>
    /// </summary>
    let MergedStatus =
        Namespaced_IRI.parse _namespace_name "MergedStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemCode"></see>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemCode =
        Namespaced_IRI.parse _namespace_name "NorthAmericanIndustryClassificationSystemCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemScheme"></see>
    /// </summary>
    let NorthAmericanIndustryClassificationSystemScheme =
        Namespaced_IRI.parse _namespace_name "NorthAmericanIndustryClassificationSystemScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingArchivalStatus"></see>
    /// </summary>
    let PendingArchivalStatus =
        Namespaced_IRI.parse _namespace_name "PendingArchivalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingTransferStatus"></see>
    /// </summary>
    let PendingTransferStatus =
        Namespaced_IRI.parse _namespace_name "PendingTransferStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingValidationStatus"></see>
    /// </summary>
    let PendingValidationStatus =
        Namespaced_IRI.parse _namespace_name "PendingValidationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationAuthorityCode"></see>
    /// </summary>
    let RegistrationAuthorityCode =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthorityCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RetiredStatus"></see>
    /// </summary>
    let RetiredStatus =
        Namespaced_IRI.parse _namespace_name "RetiredStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationCode"></see>
    /// </summary>
    let StandardIndustrialClassificationCode =
        Namespaced_IRI.parse _namespace_name "StandardIndustrialClassificationCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationScheme"></see>
    /// </summary>
    let StandardIndustrialClassificationScheme =
        Namespaced_IRI.parse _namespace_name "StandardIndustrialClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/TransferredStatus"></see>
    /// </summary>
    let TransferredStatus =
        Namespaced_IRI.parse _namespace_name "TransferredStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAlternativeLanguageLegalName"></see>
    /// </summary>
    let hasAlternativeLanguageLegalName =
        Namespaced_IRI.parse _namespace_name "hasAlternativeLanguageLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAutomaticallyTransliteratedLegalName"></see>
    /// </summary>
    let hasAutomaticallyTransliteratedLegalName =
        Namespaced_IRI.parse _namespace_name "hasAutomaticallyTransliteratedLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTransliteratedLegalName"></see>
    /// </summary>
    let hasTransliteratedLegalName =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationDate"></see>
    /// </summary>
    let hasEntityExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasEntityExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasExpiryDate"></see>
    /// </summary>
    let hasExpiryDate =
        Namespaced_IRI.parse _namespace_name "hasExpiryDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationReason"></see>
    /// </summary>
    let hasEntityExpirationReason =
        Namespaced_IRI.parse _namespace_name "hasEntityExpirationReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityStatus"></see>
    /// </summary>
    let hasEntityStatus =
        Namespaced_IRI.parse _namespace_name "hasEntityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasInitialRegistrationDate"></see>
    /// </summary>
    let hasInitialRegistrationDate =
        Namespaced_IRI.parse _namespace_name "hasInitialRegistrationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPreferredTransliteratedLegalName"></see>
    /// </summary>
    let hasPreferredTransliteratedLegalName =
        Namespaced_IRI.parse _namespace_name "hasPreferredTransliteratedLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPriorLegalName"></see>
    /// </summary>
    let hasPriorLegalName =
        Namespaced_IRI.parse _namespace_name "hasPriorLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationRevisionDate"></see>
    /// </summary>
    let hasRegistrationRevisionDate =
        Namespaced_IRI.parse _namespace_name "hasRegistrationRevisionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRenewalDate"></see>
    /// </summary>
    let hasRenewalDate =
        Namespaced_IRI.parse _namespace_name "hasRenewalDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTradingOrOperationalName"></see>
    /// </summary>
    let hasTradingOrOperationalName =
        Namespaced_IRI.parse _namespace_name "hasTradingOrOperationalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationDate"></see>
    /// </summary>
    let hasValidationDate =
        Namespaced_IRI.parse _namespace_name "hasValidationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/isSelfMaintained"></see>
    /// </summary>
    let isSelfMaintained =
        Namespaced_IRI.parse _namespace_name "isSelfMaintained" |> NamespacedName
