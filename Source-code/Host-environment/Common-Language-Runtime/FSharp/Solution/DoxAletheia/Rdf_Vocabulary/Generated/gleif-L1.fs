namespace https.www.gleif.org.ontology.L1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_L1 =
    let _namespace_iri = Namespace_Iri gleif_L1 |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-L1:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"GLEIF L1 Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/">https://www.gleif.org/ontology/L1/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_L1, "") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:Branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/Branch">https://www.gleif.org/ontology/L1/Branch</seealso>
    let Branch = Prefixed_Name(gleif_L1, "Branch") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:BusinessRegistryIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business registry identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/BusinessRegistryIdentifier">https://www.gleif.org/ontology/L1/BusinessRegistryIdentifier</seealso>
    let BusinessRegistryIdentifier =
        Prefixed_Name(gleif_L1, "BusinessRegistryIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:Fund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/Fund">https://www.gleif.org/ontology/L1/Fund</seealso>
    let Fund = Prefixed_Name(gleif_L1, "Fund") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:FundFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/FundFamily">https://www.gleif.org/ontology/L1/FundFamily</seealso>
    let FundFamily = Prefixed_Name(gleif_L1, "FundFamily") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:GlobalLegalEntityIdentifierSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:Registry</para>
    ///
    /// labels<para>"Global Legal Entity Identifier System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/GlobalLegalEntityIdentifierSystem">https://www.gleif.org/ontology/L1/GlobalLegalEntityIdentifierSystem</seealso>
    let GlobalLegalEntityIdentifierSystem =
        Prefixed_Name(gleif_L1, "GlobalLegalEntityIdentifierSystem") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:LEI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"LEI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/LEI">https://www.gleif.org/ontology/L1/LEI</seealso>
    let LEI = Prefixed_Name(gleif_L1, "LEI") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:LegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/LegalEntity">https://www.gleif.org/ontology/L1/LegalEntity</seealso>
    let LegalEntity = Prefixed_Name(gleif_L1, "LegalEntity") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:LegalEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/LegalEntityIdentifier">https://www.gleif.org/ontology/L1/LegalEntityIdentifier</seealso>
    let LegalEntityIdentifier =
        Prefixed_Name(gleif_L1, "LegalEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:LegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/LegalEntityIdentifierRegistryEntry">https://www.gleif.org/ontology/L1/LegalEntityIdentifierRegistryEntry</seealso>
    let LegalEntityIdentifierRegistryEntry =
        Prefixed_Name(gleif_L1, "LegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:LocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/LocalOperatingUnit">https://www.gleif.org/ontology/L1/LocalOperatingUnit</seealso>
    let LocalOperatingUnit =
        Prefixed_Name(gleif_L1, "LocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegisteredEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegisteredEntity">https://www.gleif.org/ontology/L1/RegisteredEntity</seealso>
    let RegisteredEntity = Prefixed_Name(gleif_L1, "RegisteredEntity") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatus">https://www.gleif.org/ontology/L1/RegistrationStatus</seealso>
    let RegistrationStatus =
        Prefixed_Name(gleif_L1, "RegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusAnnulled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///
    /// labels<para>"annulled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusAnnulled">https://www.gleif.org/ontology/L1/RegistrationStatusAnnulled</seealso>
    let RegistrationStatusAnnulled =
        Prefixed_Name(gleif_L1, "RegistrationStatusAnnulled") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusDuplicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"duplicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusDuplicate">https://www.gleif.org/ontology/L1/RegistrationStatusDuplicate</seealso>
    let RegistrationStatusDuplicate =
        Prefixed_Name(gleif_L1, "RegistrationStatusDuplicate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"issued"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusIssued">https://www.gleif.org/ontology/L1/RegistrationStatusIssued</seealso>
    let RegistrationStatusIssued =
        Prefixed_Name(gleif_L1, "RegistrationStatusIssued") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusLapsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///
    /// labels<para>"lapsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusLapsed">https://www.gleif.org/ontology/L1/RegistrationStatusLapsed</seealso>
    let RegistrationStatusLapsed =
        Prefixed_Name(gleif_L1, "RegistrationStatusLapsed") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusMerged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///
    /// labels<para>"merged"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusMerged">https://www.gleif.org/ontology/L1/RegistrationStatusMerged</seealso>
    let RegistrationStatusMerged =
        Prefixed_Name(gleif_L1, "RegistrationStatusMerged") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusPendingArchival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///
    /// labels<para>"pending archival"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingArchival">https://www.gleif.org/ontology/L1/RegistrationStatusPendingArchival</seealso>
    let RegistrationStatusPendingArchival =
        Prefixed_Name(gleif_L1, "RegistrationStatusPendingArchival") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusPendingTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pending transfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusPendingTransfer">https://www.gleif.org/ontology/L1/RegistrationStatusPendingTransfer</seealso>
    let RegistrationStatusPendingTransfer =
        Prefixed_Name(gleif_L1, "RegistrationStatusPendingTransfer") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:RegistrationStatusRetired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:RegistrationStatus</para>
    ///
    /// labels<para>"retired"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/RegistrationStatusRetired">https://www.gleif.org/ontology/L1/RegistrationStatusRetired</seealso>
    let RegistrationStatusRetired =
        Prefixed_Name(gleif_L1, "RegistrationStatusRetired") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:SoleProprietor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sole proprietor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/SoleProprietor">https://www.gleif.org/ontology/L1/SoleProprietor</seealso>
    let SoleProprietor = Prefixed_Name(gleif_L1, "SoleProprietor") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:ValidationSourceKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LEI validation source kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/ValidationSourceKind">https://www.gleif.org/ontology/L1/ValidationSourceKind</seealso>
    let ValidationSourceKind =
        Prefixed_Name(gleif_L1, "ValidationSourceKind") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:ValidationSourceKindEntitySuppliedOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-L1:ValidationSourceKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity supplied only"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/ValidationSourceKindEntitySuppliedOnly">https://www.gleif.org/ontology/L1/ValidationSourceKindEntitySuppliedOnly</seealso>
    let ValidationSourceKindEntitySuppliedOnly =
        Prefixed_Name(gleif_L1, "ValidationSourceKindEntitySuppliedOnly") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:ValidationSourceKindFullyCorroborated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:ValidationSourceKind</para>
    ///
    /// labels<para>"fully corroborated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/ValidationSourceKindFullyCorroborated">https://www.gleif.org/ontology/L1/ValidationSourceKindFullyCorroborated</seealso>
    let ValidationSourceKindFullyCorroborated =
        Prefixed_Name(gleif_L1, "ValidationSourceKindFullyCorroborated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:ValidationSourceKindPartiallyCorroborated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-L1:ValidationSourceKind</para>
    ///
    /// labels<para>"partially corroborated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/ValidationSourceKindPartiallyCorroborated">https://www.gleif.org/ontology/L1/ValidationSourceKindPartiallyCorroborated</seealso>
    let ValidationSourceKindPartiallyCorroborated =
        Prefixed_Name(gleif_L1, "ValidationSourceKindPartiallyCorroborated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAlternativeLanguageHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has alternative language headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageHeadquartersAddress">https://www.gleif.org/ontology/L1/hasAlternativeLanguageHeadquartersAddress</seealso>
    let hasAlternativeLanguageHeadquartersAddress =
        Prefixed_Name(gleif_L1, "hasAlternativeLanguageHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAlternativeLanguageLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has alternative language legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalAddress">https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalAddress</seealso>
    let hasAlternativeLanguageLegalAddress =
        Prefixed_Name(gleif_L1, "hasAlternativeLanguageLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAlternativeLanguageLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has other entity names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalName">https://www.gleif.org/ontology/L1/hasAlternativeLanguageLegalName</seealso>
    let hasAlternativeLanguageLegalName =
        Prefixed_Name(gleif_L1, "hasAlternativeLanguageLegalName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAssociatedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has associated entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAssociatedEntity">https://www.gleif.org/ontology/L1/hasAssociatedEntity</seealso>
    let hasAssociatedEntity =
        Prefixed_Name(gleif_L1, "hasAssociatedEntity") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAssociatedEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has associated entity name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAssociatedEntityName">https://www.gleif.org/ontology/L1/hasAssociatedEntityName</seealso>
    let hasAssociatedEntityName =
        Prefixed_Name(gleif_L1, "hasAssociatedEntityName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAutoASCIITransliteratedHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has auto ASCII transliterated headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedHeadquartersAddress">https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedHeadquartersAddress</seealso>
    let hasAutoASCIITransliteratedHeadquartersAddress =
        Prefixed_Name(gleif_L1, "hasAutoASCIITransliteratedHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAutoASCIITransliteratedLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has auto ASCII transliterated legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalAddress">https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalAddress</seealso>
    let hasAutoASCIITransliteratedLegalAddress =
        Prefixed_Name(gleif_L1, "hasAutoASCIITransliteratedLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasAutoASCIITransliteratedLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has auto ASCII transliterated legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalName">https://www.gleif.org/ontology/L1/hasAutoASCIITransliteratedLegalName</seealso>
    let hasAutoASCIITransliteratedLegalName =
        Prefixed_Name(gleif_L1, "hasAutoASCIITransliteratedLegalName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasEntityID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has entity id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasEntityID">https://www.gleif.org/ontology/L1/hasEntityID</seealso>
    let hasEntityID = Prefixed_Name(gleif_L1, "hasEntityID") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasFundFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has fund family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasFundFamily">https://www.gleif.org/ontology/L1/hasFundFamily</seealso>
    let hasFundFamily = Prefixed_Name(gleif_L1, "hasFundFamily") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasFundFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has fund family name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasFundFamilyName">https://www.gleif.org/ontology/L1/hasFundFamilyName</seealso>
    let hasFundFamilyName = Prefixed_Name(gleif_L1, "hasFundFamilyName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasHeadquartersAddress">https://www.gleif.org/ontology/L1/hasHeadquartersAddress</seealso>
    let hasHeadquartersAddress =
        Prefixed_Name(gleif_L1, "hasHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasLEI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasLEI">https://www.gleif.org/ontology/L1/hasLEI</seealso>
    let hasLEI = Prefixed_Name(gleif_L1, "hasLEI") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasLegalAddress">https://www.gleif.org/ontology/L1/hasLegalAddress</seealso>
    let hasLegalAddress = Prefixed_Name(gleif_L1, "hasLegalAddress") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasLegalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasLegalForm">https://www.gleif.org/ontology/L1/hasLegalForm</seealso>
    let hasLegalForm = Prefixed_Name(gleif_L1, "hasLegalForm") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasLegalFormText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has legal form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasLegalFormText">https://www.gleif.org/ontology/L1/hasLegalFormText</seealso>
    let hasLegalFormText = Prefixed_Name(gleif_L1, "hasLegalFormText") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasLegalName">https://www.gleif.org/ontology/L1/hasLegalName</seealso>
    let hasLegalName = Prefixed_Name(gleif_L1, "hasLegalName") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasManagingLOU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has managing LOU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasManagingLOU">https://www.gleif.org/ontology/L1/hasManagingLOU</seealso>
    let hasManagingLOU = Prefixed_Name(gleif_L1, "hasManagingLOU") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasOtherAddresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has other addresses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasOtherAddresses">https://www.gleif.org/ontology/L1/hasOtherAddresses</seealso>
    let hasOtherAddresses = Prefixed_Name(gleif_L1, "hasOtherAddresses") |> PrefixedName
    /// <summary>
    ///   <para>gleif-L1:hasOtherAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has other authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasOtherAuthority">https://www.gleif.org/ontology/L1/hasOtherAuthority</seealso>
    let hasOtherAuthority = Prefixed_Name(gleif_L1, "hasOtherAuthority") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasOtherEntityNames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has other entity names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasOtherEntityNames">https://www.gleif.org/ontology/L1/hasOtherEntityNames</seealso>
    let hasOtherEntityNames =
        Prefixed_Name(gleif_L1, "hasOtherEntityNames") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasOtherValidationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has other validation identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasOtherValidationIdentifier">https://www.gleif.org/ontology/L1/hasOtherValidationIdentifier</seealso>
    let hasOtherValidationIdentifier =
        Prefixed_Name(gleif_L1, "hasOtherValidationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasPreferredASCIITransliteratedHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has preferred ASCII transliterated headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedHeadquartersAddress">https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedHeadquartersAddress</seealso>
    let hasPreferredASCIITransliteratedHeadquartersAddress =
        Prefixed_Name(gleif_L1, "hasPreferredASCIITransliteratedHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasPreferredASCIITransliteratedLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has preferred ASCII transliterated legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalAddress">https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalAddress</seealso>
    let hasPreferredASCIITransliteratedLegalAddress =
        Prefixed_Name(gleif_L1, "hasPreferredASCIITransliteratedLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasPreferredASCIITransliteratedLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has preferred ASCII transliterated legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalName">https://www.gleif.org/ontology/L1/hasPreferredASCIITransliteratedLegalName</seealso>
    let hasPreferredASCIITransliteratedLegalName =
        Prefixed_Name(gleif_L1, "hasPreferredASCIITransliteratedLegalName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasPreviousLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has previous legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasPreviousLegalName">https://www.gleif.org/ontology/L1/hasPreviousLegalName</seealso>
    let hasPreviousLegalName =
        Prefixed_Name(gleif_L1, "hasPreviousLegalName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasRegisteredAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registered authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasRegisteredAuthority">https://www.gleif.org/ontology/L1/hasRegisteredAuthority</seealso>
    let hasRegisteredAuthority =
        Prefixed_Name(gleif_L1, "hasRegisteredAuthority") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasRegistrationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registration identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasRegistrationIdentifier">https://www.gleif.org/ontology/L1/hasRegistrationIdentifier</seealso>
    let hasRegistrationIdentifier =
        Prefixed_Name(gleif_L1, "hasRegistrationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasTradingOrOperatingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has trading or operating name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasTradingOrOperatingName">https://www.gleif.org/ontology/L1/hasTradingOrOperatingName</seealso>
    let hasTradingOrOperatingName =
        Prefixed_Name(gleif_L1, "hasTradingOrOperatingName") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasTransliteratedHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has transliterated headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasTransliteratedHeadquartersAddress">https://www.gleif.org/ontology/L1/hasTransliteratedHeadquartersAddress</seealso>
    let hasTransliteratedHeadquartersAddress =
        Prefixed_Name(gleif_L1, "hasTransliteratedHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasTransliteratedLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has transliterated legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasTransliteratedLegalAddress">https://www.gleif.org/ontology/L1/hasTransliteratedLegalAddress</seealso>
    let hasTransliteratedLegalAddress =
        Prefixed_Name(gleif_L1, "hasTransliteratedLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasTransliteratedOtherAddresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has transliterated other addresses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherAddresses">https://www.gleif.org/ontology/L1/hasTransliteratedOtherAddresses</seealso>
    let hasTransliteratedOtherAddresses =
        Prefixed_Name(gleif_L1, "hasTransliteratedOtherAddresses") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasTransliteratedOtherEntityNames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transliterated other entity names"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasTransliteratedOtherEntityNames">https://www.gleif.org/ontology/L1/hasTransliteratedOtherEntityNames</seealso>
    let hasTransliteratedOtherEntityNames =
        Prefixed_Name(gleif_L1, "hasTransliteratedOtherEntityNames") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasValidationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasValidationIdentifier">https://www.gleif.org/ontology/L1/hasValidationIdentifier</seealso>
    let hasValidationIdentifier =
        Prefixed_Name(gleif_L1, "hasValidationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:hasValidationSources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation sources"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/hasValidationSources">https://www.gleif.org/ontology/L1/hasValidationSources</seealso>
    let hasValidationSources =
        Prefixed_Name(gleif_L1, "hasValidationSources") |> PrefixedName

    /// <summary>
    ///   <para>gleif-L1:identifiesAndRecords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"identifies and records"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/L1/identifiesAndRecords">https://www.gleif.org/ontology/L1/identifiesAndRecords</seealso>
    let identifiesAndRecords =
        Prefixed_Name(gleif_L1, "identifiesAndRecords") |> PrefixedName
