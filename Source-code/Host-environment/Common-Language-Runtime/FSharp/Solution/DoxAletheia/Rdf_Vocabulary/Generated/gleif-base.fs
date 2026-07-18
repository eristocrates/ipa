namespace https.www.gleif.org.ontology.Base.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_base =
    let _namespace_name = "https://www.gleif.org/ontology/Base/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatusActive"></see>
    /// </summary>
    let EntityStatusActive =
        Namespaced_IRI.parse _namespace_name "EntityStatusActive" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatusInactive"></see>
    /// </summary>
    let EntityStatusInactive =
        Namespaced_IRI.parse _namespace_name "EntityStatusInactive" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonCorporateAction"></see>
    /// </summary>
    let EntityExpirationReasonCorporateAction =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonCorporateAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonDissolved"></see>
    /// </summary>
    let EntityExpirationReasonDissolved =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonDissolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReasonOther"></see>
    /// </summary>
    let EntityExpirationReasonOther =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReasonOther" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/GLEIF"></see>
    /// </summary>
    let GLEIF = Namespaced_IRI.parse _namespace_name "GLEIF" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityExpirationDate"></see>
    /// </summary>
    let hasEntityExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasEntityExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSuccessor"></see>
    /// </summary>
    let hasSuccessor =
        Namespaced_IRI.parse _namespace_name "hasSuccessor" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityStatus"></see>
    /// </summary>
    let hasEntityStatus =
        Namespaced_IRI.parse _namespace_name "hasEntityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityStatus"></see>
    /// </summary>
    let EntityStatus =
        Namespaced_IRI.parse _namespace_name "EntityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEntityExpirationReason"></see>
    /// </summary>
    let hasEntityExpirationReason =
        Namespaced_IRI.parse _namespace_name "hasEntityExpirationReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/EntityExpirationReason"></see>
    /// </summary>
    let EntityExpirationReason =
        Namespaced_IRI.parse _namespace_name "EntityExpirationReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLegalLocal"></see>
    /// </summary>
    let hasNameLegalLocal =
        Namespaced_IRI.parse _namespace_name "hasNameLegalLocal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLegalJurisdiction"></see>
    /// </summary>
    let hasLegalJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasLegalJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasTag"></see>
    /// </summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistrationAuthority"></see>
    /// </summary>
    let RegistrationAuthority =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLegalName"></see>
    /// </summary>
    let hasLegalName =
        Namespaced_IRI.parse _namespace_name "hasLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Identifier"></see>
    /// </summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/identifies"></see>
    /// </summary>
    let identifies = Namespaced_IRI.parse _namespace_name "identifies" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/LegalEntityRelationship"></see>
    /// </summary>
    let LegalEntityRelationship =
        Namespaced_IRI.parse _namespace_name "LegalEntityRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSource"></see>
    /// </summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasTarget"></see>
    /// </summary>
    let hasTarget = Namespaced_IRI.parse _namespace_name "hasTarget" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/LegalPerson"></see>
    /// </summary>
    let LegalPerson =
        Namespaced_IRI.parse _namespace_name "LegalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Period"></see>
    /// </summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasEnd"></see>
    /// </summary>
    let hasEnd = Namespaced_IRI.parse _namespace_name "hasEnd" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasStart"></see>
    /// </summary>
    let hasStart = Namespaced_IRI.parse _namespace_name "hasStart" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/PhysicalAddress"></see>
    /// </summary>
    let PhysicalAddress =
        Namespaced_IRI.parse _namespace_name "PhysicalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressNumber"></see>
    /// </summary>
    let hasAddressNumber =
        Namespaced_IRI.parse _namespace_name "hasAddressNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCity"></see>
    /// </summary>
    let hasCity = Namespaced_IRI.parse _namespace_name "hasCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressNumberWithinBuilding"></see>
    /// </summary>
    let hasAddressNumberWithinBuilding =
        Namespaced_IRI.parse _namespace_name "hasAddressNumberWithinBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine1"></see>
    /// </summary>
    let hasAddressLine1 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine1" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine3"></see>
    /// </summary>
    let hasAddressLine3 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine3" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasMailRouting"></see>
    /// </summary>
    let hasMailRouting =
        Namespaced_IRI.parse _namespace_name "hasMailRouting" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasPostalCode"></see>
    /// </summary>
    let hasPostalCode =
        Namespaced_IRI.parse _namespace_name "hasPostalCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasRegion"></see>
    /// </summary>
    let hasRegion = Namespaced_IRI.parse _namespace_name "hasRegion" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine2"></see>
    /// </summary>
    let hasAddressLine2 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine2" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLine4"></see>
    /// </summary>
    let hasAddressLine4 =
        Namespaced_IRI.parse _namespace_name "hasAddressLine4" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/PhysicalAddressASCII"></see>
    /// </summary>
    let PhysicalAddressASCII =
        Namespaced_IRI.parse _namespace_name "PhysicalAddressASCII" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistrationStatus"></see>
    /// </summary>
    let RegistrationStatus =
        Namespaced_IRI.parse _namespace_name "RegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/Registry"></see>
    /// </summary>
    let Registry = Namespaced_IRI.parse _namespace_name "Registry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isManagedBy"></see>
    /// </summary>
    let isManagedBy =
        Namespaced_IRI.parse _namespace_name "isManagedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistryEntry"></see>
    /// </summary>
    let RegistryEntry =
        Namespaced_IRI.parse _namespace_name "RegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/RegistryIdentifier"></see>
    /// </summary>
    let RegistryIdentifier =
        Namespaced_IRI.parse _namespace_name "RegistryIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isRegisteredIn"></see>
    /// </summary>
    let isRegisteredIn =
        Namespaced_IRI.parse _namespace_name "isRegisteredIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviation"></see>
    /// </summary>
    let hasAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasAbbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviationLocal"></see>
    /// </summary>
    let hasAbbreviationLocal =
        Namespaced_IRI.parse _namespace_name "hasAbbreviationLocal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAbbreviationTransliterated"></see>
    /// </summary>
    let hasAbbreviationTransliterated =
        Namespaced_IRI.parse _namespace_name "hasAbbreviationTransliterated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAdditionalAddressLine"></see>
    /// </summary>
    let hasAdditionalAddressLine =
        Namespaced_IRI.parse _namespace_name "hasAdditionalAddressLine" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressHeadquarters"></see>
    /// </summary>
    let hasAddressHeadquarters =
        Namespaced_IRI.parse _namespace_name "hasAddressHeadquarters" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressLegal"></see>
    /// </summary>
    let hasAddressLegal =
        Namespaced_IRI.parse _namespace_name "hasAddressLegal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasAddressTransliterated"></see>
    /// </summary>
    let hasAddressTransliterated =
        Namespaced_IRI.parse _namespace_name "hasAddressTransliterated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasGeographicRegion"></see>
    /// </summary>
    let hasGeographicRegion =
        Namespaced_IRI.parse _namespace_name "hasGeographicRegion" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasCoverageArea"></see>
    /// </summary>
    let hasCoverageArea =
        Namespaced_IRI.parse _namespace_name "hasCoverageArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasFirstAddressLine"></see>
    /// </summary>
    let hasFirstAddressLine =
        Namespaced_IRI.parse _namespace_name "hasFirstAddressLine" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasInitialRegistrationDate"></see>
    /// </summary>
    let hasInitialRegistrationDate =
        Namespaced_IRI.parse _namespace_name "hasInitialRegistrationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasLastUpdateDate"></see>
    /// </summary>
    let hasLastUpdateDate =
        Namespaced_IRI.parse _namespace_name "hasLastUpdateDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCII"></see>
    /// </summary>
    let hasNameASCII =
        Namespaced_IRI.parse _namespace_name "hasNameASCII" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTransliterated"></see>
    /// </summary>
    let hasNameTransliterated =
        Namespaced_IRI.parse _namespace_name "hasNameTransliterated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCIIAutomatic"></see>
    /// </summary>
    let hasNameASCIIAutomatic =
        Namespaced_IRI.parse _namespace_name "hasNameASCIIAutomatic" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLegal"></see>
    /// </summary>
    let hasNameLegal =
        Namespaced_IRI.parse _namespace_name "hasNameLegal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameASCIIPreferred"></see>
    /// </summary>
    let hasNameASCIIPreferred =
        Namespaced_IRI.parse _namespace_name "hasNameASCIIPreferred" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameAdditional"></see>
    /// </summary>
    let hasNameAdditional =
        Namespaced_IRI.parse _namespace_name "hasNameAdditional" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameAdditionalLocal"></see>
    /// </summary>
    let hasNameAdditionalLocal =
        Namespaced_IRI.parse _namespace_name "hasNameAdditionalLocal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameLocal"></see>
    /// </summary>
    let hasNameLocal =
        Namespaced_IRI.parse _namespace_name "hasNameLocal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNamePreviousLegal"></see>
    /// </summary>
    let hasNamePreviousLegal =
        Namespaced_IRI.parse _namespace_name "hasNamePreviousLegal" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTradingOrOperating"></see>
    /// </summary>
    let hasNameTradingOrOperating =
        Namespaced_IRI.parse _namespace_name "hasNameTradingOrOperating" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNameTranslatedEnglish"></see>
    /// </summary>
    let hasNameTranslatedEnglish =
        Namespaced_IRI.parse _namespace_name "hasNameTranslatedEnglish" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasNextRenewalDate"></see>
    /// </summary>
    let hasNextRenewalDate =
        Namespaced_IRI.parse _namespace_name "hasNextRenewalDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasRegistrationStatus"></see>
    /// </summary>
    let hasRegistrationStatus =
        Namespaced_IRI.parse _namespace_name "hasRegistrationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasSuccessorName"></see>
    /// </summary>
    let hasSuccessorName =
        Namespaced_IRI.parse _namespace_name "hasSuccessorName" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/hasWebsite"></see>
    /// </summary>
    let hasWebsite = Namespaced_IRI.parse _namespace_name "hasWebsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isQualifiedBy"></see>
    /// </summary>
    let isQualifiedBy =
        Namespaced_IRI.parse _namespace_name "isQualifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/isQuantifiedBy"></see>
    /// </summary>
    let isQuantifiedBy =
        Namespaced_IRI.parse _namespace_name "isQuantifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Base/records"></see>
    /// </summary>
    let records = Namespaced_IRI.parse _namespace_name "records" |> NamespacedName
