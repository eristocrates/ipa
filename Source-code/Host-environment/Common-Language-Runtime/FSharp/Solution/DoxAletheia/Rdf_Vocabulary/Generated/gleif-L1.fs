namespace https.www.gleif.org.ontology.L1.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_L1 =
    let _namespace_name = "https://www.gleif.org/ontology/L1/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindEntitySuppliedOnly"></see>
    /// </summary>
    let ValidationSourceKindEntitySuppliedOnly =
        Namespaced_IRI.parse _namespace_name "ValidationSourceKindEntitySuppliedOnly" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindFullyCorroborated"></see>
    /// </summary>
    let ValidationSourceKindFullyCorroborated =
        Namespaced_IRI.parse _namespace_name "ValidationSourceKindFullyCorroborated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKindPartiallyCorroborated"></see>
    /// </summary>
    let ValidationSourceKindPartiallyCorroborated =
        Namespaced_IRI.parse _namespace_name "ValidationSourceKindPartiallyCorroborated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusAnnulled"></see>
    /// </summary>
    let RegistrationStatusAnnulled =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusAnnulled" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusDuplicate"></see>
    /// </summary>
    let RegistrationStatusDuplicate =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusDuplicate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusIssued"></see>
    /// </summary>
    let RegistrationStatusIssued =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusIssued" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusLapsed"></see>
    /// </summary>
    let RegistrationStatusLapsed =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusLapsed" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingArchival"></see>
    /// </summary>
    let RegistrationStatusPendingArchival =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusPendingArchival" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingTransfer"></see>
    /// </summary>
    let RegistrationStatusPendingTransfer =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusPendingTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusMerged"></see>
    /// </summary>
    let RegistrationStatusMerged =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusMerged" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatusRetired"></see>
    /// </summary>
    let RegistrationStatusRetired =
        Namespaced_IRI.parse _namespace_name "RegistrationStatusRetired" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/Branch"></see>
    /// </summary>
    let Branch = Namespaced_IRI.parse _namespace_name "Branch" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegisteredEntity"></see>
    /// </summary>
    let RegisteredEntity =
        Namespaced_IRI.parse _namespace_name "RegisteredEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/BusinessRegistryIdentifier"></see>
    /// </summary>
    let BusinessRegistryIdentifier =
        Namespaced_IRI.parse _namespace_name "BusinessRegistryIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherAuthority"></see>
    /// </summary>
    let hasOtherAuthority =
        Namespaced_IRI.parse _namespace_name "hasOtherAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasRegisteredAuthority"></see>
    /// </summary>
    let hasRegisteredAuthority =
        Namespaced_IRI.parse _namespace_name "hasRegisteredAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasEntityID"></see>
    /// </summary>
    let hasEntityID =
        Namespaced_IRI.parse _namespace_name "hasEntityID" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/Fund"></see>
    /// </summary>
    let Fund = Namespaced_IRI.parse _namespace_name "Fund" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasFundFamily"></see>
    /// </summary>
    let hasFundFamily =
        Namespaced_IRI.parse _namespace_name "hasFundFamily" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/FundFamily"></see>
    /// </summary>
    let FundFamily = Namespaced_IRI.parse _namespace_name "FundFamily" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasFundFamilyName"></see>
    /// </summary>
    let hasFundFamilyName =
        Namespaced_IRI.parse _namespace_name "hasFundFamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntity"></see>
    /// </summary>
    let LegalEntity =
        Namespaced_IRI.parse _namespace_name "LegalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/GlobalLegalEntityIdentifierSystem"></see>
    /// </summary>
    let GlobalLegalEntityIdentifierSystem =
        Namespaced_IRI.parse _namespace_name "GlobalLegalEntityIdentifierSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LEI"></see>
    /// </summary>
    let LEI = Namespaced_IRI.parse _namespace_name "LEI" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntityIdentifier"></see>
    /// </summary>
    let LegalEntityIdentifier =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let LegalEntityIdentifierRegistryEntry =
        Namespaced_IRI.parse _namespace_name "LegalEntityIdentifierRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasValidationIdentifier"></see>
    /// </summary>
    let hasValidationIdentifier =
        Namespaced_IRI.parse _namespace_name "hasValidationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasManagingLOU"></see>
    /// </summary>
    let hasManagingLOU =
        Namespaced_IRI.parse _namespace_name "hasManagingLOU" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/LocalOperatingUnit"></see>
    /// </summary>
    let LocalOperatingUnit =
        Namespaced_IRI.parse _namespace_name "LocalOperatingUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasValidationSources"></see>
    /// </summary>
    let hasValidationSources =
        Namespaced_IRI.parse _namespace_name "hasValidationSources" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/identifiesAndRecords"></see>
    /// </summary>
    let identifiesAndRecords =
        Namespaced_IRI.parse _namespace_name "identifiesAndRecords" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherValidationIdentifier"></see>
    /// </summary>
    let hasOtherValidationIdentifier =
        Namespaced_IRI.parse _namespace_name "hasOtherValidationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherAddresses"></see>
    /// </summary>
    let hasOtherAddresses =
        Namespaced_IRI.parse _namespace_name "hasOtherAddresses" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalAddress"></see>
    /// </summary>
    let hasLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalName"></see>
    /// </summary>
    let hasLegalName =
        Namespaced_IRI.parse _namespace_name "hasLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasRegistrationIdentifier"></see>
    /// </summary>
    let hasRegistrationIdentifier =
        Namespaced_IRI.parse _namespace_name "hasRegistrationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasHeadquartersAddress"></see>
    /// </summary>
    let hasHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedLegalAddress"></see>
    /// </summary>
    let hasTransliteratedLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasTransliteratedHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasOtherEntityNames"></see>
    /// </summary>
    let hasOtherEntityNames =
        Namespaced_IRI.parse _namespace_name "hasOtherEntityNames" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalForm"></see>
    /// </summary>
    let hasLegalForm =
        Namespaced_IRI.parse _namespace_name "hasLegalForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasLegalFormText"></see>
    /// </summary>
    let hasLegalFormText =
        Namespaced_IRI.parse _namespace_name "hasLegalFormText" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus =
        Namespaced_IRI.parse _namespace_name "RegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/SoleProprietor"></see>
    /// </summary>
    let SoleProprietor =
        Namespaced_IRI.parse _namespace_name "SoleProprietor" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/ValidationSourceKind"></see>
    /// </summary>
    let ValidationSourceKind =
        Namespaced_IRI.parse _namespace_name "ValidationSourceKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageHeadquartersAddress"></see>
    /// </summary>
    let hasAlternativeLanguageHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasAlternativeLanguageHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalAddress"></see>
    /// </summary>
    let hasAlternativeLanguageLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasAlternativeLanguageLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalName"></see>
    /// </summary>
    let hasAlternativeLanguageLegalName =
        Namespaced_IRI.parse _namespace_name "hasAlternativeLanguageLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAssociatedEntity"></see>
    /// </summary>
    let hasAssociatedEntity =
        Namespaced_IRI.parse _namespace_name "hasAssociatedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAssociatedEntityName"></see>
    /// </summary>
    let hasAssociatedEntityName =
        Namespaced_IRI.parse _namespace_name "hasAssociatedEntityName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasAutoASCIITransliteratedHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasAutoASCIITransliteratedHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalAddress"></see>
    /// </summary>
    let hasAutoASCIITransliteratedLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasAutoASCIITransliteratedLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalName"></see>
    /// </summary>
    let hasAutoASCIITransliteratedLegalName =
        Namespaced_IRI.parse _namespace_name "hasAutoASCIITransliteratedLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherEntityNames"></see>
    /// </summary>
    let hasTransliteratedOtherEntityNames =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedOtherEntityNames" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedHeadquartersAddress"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasPreferredASCIITransliteratedHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalAddress"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalAddress =
        Namespaced_IRI.parse _namespace_name "hasPreferredASCIITransliteratedLegalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalName"></see>
    /// </summary>
    let hasPreferredASCIITransliteratedLegalName =
        Namespaced_IRI.parse _namespace_name "hasPreferredASCIITransliteratedLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasPreviousLegalName"></see>
    /// </summary>
    let hasPreviousLegalName =
        Namespaced_IRI.parse _namespace_name "hasPreviousLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTradingOrOperatingName"></see>
    /// </summary>
    let hasTradingOrOperatingName =
        Namespaced_IRI.parse _namespace_name "hasTradingOrOperatingName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherAddresses"></see>
    /// </summary>
    let hasTransliteratedOtherAddresses =
        Namespaced_IRI.parse _namespace_name "hasTransliteratedOtherAddresses" |> NamespacedName
