namespace https.www.gleif.org.ontology.Base.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_base =
    let _namespace_iri = Namespace_Iri gleif_base |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-base:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///
    /// labels<para>"GLEIF Base Ontology"</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/">https://www.gleif.org/ontology/Base/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_base, "") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/Entity">https://www.gleif.org/ontology/Base/Entity</seealso>
    let Entity = Prefixed_Name(gleif_base, "Entity") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityExpirationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity expiration reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityExpirationReason">https://www.gleif.org/ontology/Base/EntityExpirationReason</seealso>
    let EntityExpirationReason =
        Prefixed_Name(gleif_base, "EntityExpirationReason") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityExpirationReasonCorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:EntityExpirationReason</para>
    ///
    /// labels<para>"corporate action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityExpirationReasonCorporateAction">https://www.gleif.org/ontology/Base/EntityExpirationReasonCorporateAction</seealso>
    let EntityExpirationReasonCorporateAction =
        Prefixed_Name(gleif_base, "EntityExpirationReasonCorporateAction") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityExpirationReasonDissolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:EntityExpirationReason</para>
    ///
    /// labels<para>"dissolved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityExpirationReasonDissolved">https://www.gleif.org/ontology/Base/EntityExpirationReasonDissolved</seealso>
    let EntityExpirationReasonDissolved =
        Prefixed_Name(gleif_base, "EntityExpirationReasonDissolved") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityExpirationReasonOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:EntityExpirationReason</para>
    ///
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityExpirationReasonOther">https://www.gleif.org/ontology/Base/EntityExpirationReasonOther</seealso>
    let EntityExpirationReasonOther =
        Prefixed_Name(gleif_base, "EntityExpirationReasonOther") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityStatus">https://www.gleif.org/ontology/Base/EntityStatus</seealso>
    let EntityStatus = Prefixed_Name(gleif_base, "EntityStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-base:EntityStatus</para>
    ///
    /// labels<para>"active"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityStatusActive">https://www.gleif.org/ontology/Base/EntityStatusActive</seealso>
    let EntityStatusActive =
        Prefixed_Name(gleif_base, "EntityStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:EntityStatusInactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:EntityStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"inactive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/EntityStatusInactive">https://www.gleif.org/ontology/Base/EntityStatusInactive</seealso>
    let EntityStatusInactive =
        Prefixed_Name(gleif_base, "EntityStatusInactive") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:GLEIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:RegistrationAuthority</para>
    /// </remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/GLEIF">https://www.gleif.org/ontology/Base/GLEIF</seealso>
    let GLEIF = Prefixed_Name(gleif_base, "GLEIF") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/Identifier">https://www.gleif.org/ontology/Base/Identifier</seealso>
    let Identifier = Prefixed_Name(gleif_base, "Identifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:LegalEntityRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/LegalEntityRelationship">https://www.gleif.org/ontology/Base/LegalEntityRelationship</seealso>
    let LegalEntityRelationship =
        Prefixed_Name(gleif_base, "LegalEntityRelationship") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:LegalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/LegalPerson">https://www.gleif.org/ontology/Base/LegalPerson</seealso>
    let LegalPerson = Prefixed_Name(gleif_base, "LegalPerson") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"period"</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/Period">https://www.gleif.org/ontology/Base/Period</seealso>
    let Period = Prefixed_Name(gleif_base, "Period") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:PhysicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical address"</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/PhysicalAddress">https://www.gleif.org/ontology/Base/PhysicalAddress</seealso>
    let PhysicalAddress = Prefixed_Name(gleif_base, "PhysicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:PhysicalAddressASCII</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical address ASCII"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/PhysicalAddressASCII">https://www.gleif.org/ontology/Base/PhysicalAddressASCII</seealso>
    let PhysicalAddressASCII =
        Prefixed_Name(gleif_base, "PhysicalAddressASCII") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:RegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/RegistrationAuthority">https://www.gleif.org/ontology/Base/RegistrationAuthority</seealso>
    let RegistrationAuthority =
        Prefixed_Name(gleif_base, "RegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:RegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/RegistrationStatus">https://www.gleif.org/ontology/Base/RegistrationStatus</seealso>
    let RegistrationStatus =
        Prefixed_Name(gleif_base, "RegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:Registry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/Registry">https://www.gleif.org/ontology/Base/Registry</seealso>
    let Registry = Prefixed_Name(gleif_base, "Registry") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:RegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/RegistryEntry">https://www.gleif.org/ontology/Base/RegistryEntry</seealso>
    let RegistryEntry = Prefixed_Name(gleif_base, "RegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:RegistryIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registry identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/RegistryIdentifier">https://www.gleif.org/ontology/Base/RegistryIdentifier</seealso>
    let RegistryIdentifier =
        Prefixed_Name(gleif_base, "RegistryIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAbbreviation">https://www.gleif.org/ontology/Base/hasAbbreviation</seealso>
    let hasAbbreviation = Prefixed_Name(gleif_base, "hasAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAbbreviationLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has abbreviation local"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAbbreviationLocal">https://www.gleif.org/ontology/Base/hasAbbreviationLocal</seealso>
    let hasAbbreviationLocal =
        Prefixed_Name(gleif_base, "hasAbbreviationLocal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAbbreviationTransliterated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has abbreviation transliterated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAbbreviationTransliterated">https://www.gleif.org/ontology/Base/hasAbbreviationTransliterated</seealso>
    let hasAbbreviationTransliterated =
        Prefixed_Name(gleif_base, "hasAbbreviationTransliterated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAdditionalAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has additional address line"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAdditionalAddressLine">https://www.gleif.org/ontology/Base/hasAdditionalAddressLine</seealso>
    let hasAdditionalAddressLine =
        Prefixed_Name(gleif_base, "hasAdditionalAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddress">https://www.gleif.org/ontology/Base/hasAddress</seealso>
    let hasAddress = Prefixed_Name(gleif_base, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAddressHeadquarters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has address headquarters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressHeadquarters">https://www.gleif.org/ontology/Base/hasAddressHeadquarters</seealso>
    let hasAddressHeadquarters =
        Prefixed_Name(gleif_base, "hasAddressHeadquarters") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAddressLegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has address legal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressLegal">https://www.gleif.org/ontology/Base/hasAddressLegal</seealso>
    let hasAddressLegal = Prefixed_Name(gleif_base, "hasAddressLegal") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasAddressLine1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressLine1">https://www.gleif.org/ontology/Base/hasAddressLine1</seealso>
    let hasAddressLine1 = Prefixed_Name(gleif_base, "hasAddressLine1") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasAddressLine2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressLine2">https://www.gleif.org/ontology/Base/hasAddressLine2</seealso>
    let hasAddressLine2 = Prefixed_Name(gleif_base, "hasAddressLine2") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasAddressLine3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressLine3">https://www.gleif.org/ontology/Base/hasAddressLine3</seealso>
    let hasAddressLine3 = Prefixed_Name(gleif_base, "hasAddressLine3") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasAddressLine4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address line 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressLine4">https://www.gleif.org/ontology/Base/hasAddressLine4</seealso>
    let hasAddressLine4 = Prefixed_Name(gleif_base, "hasAddressLine4") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasAddressNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressNumber">https://www.gleif.org/ontology/Base/hasAddressNumber</seealso>
    let hasAddressNumber = Prefixed_Name(gleif_base, "hasAddressNumber") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAddressNumberWithinBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has address number within building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressNumberWithinBuilding">https://www.gleif.org/ontology/Base/hasAddressNumberWithinBuilding</seealso>
    let hasAddressNumberWithinBuilding =
        Prefixed_Name(gleif_base, "hasAddressNumberWithinBuilding") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasAddressTransliterated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has address transliterated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasAddressTransliterated">https://www.gleif.org/ontology/Base/hasAddressTransliterated</seealso>
    let hasAddressTransliterated =
        Prefixed_Name(gleif_base, "hasAddressTransliterated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has city"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasCity">https://www.gleif.org/ontology/Base/hasCity</seealso>
    let hasCity = Prefixed_Name(gleif_base, "hasCity") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasCountry">https://www.gleif.org/ontology/Base/hasCountry</seealso>
    let hasCountry = Prefixed_Name(gleif_base, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasCoverageArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has coverage area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasCoverageArea">https://www.gleif.org/ontology/Base/hasCoverageArea</seealso>
    let hasCoverageArea = Prefixed_Name(gleif_base, "hasCoverageArea") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has end"</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasEnd">https://www.gleif.org/ontology/Base/hasEnd</seealso>
    let hasEnd = Prefixed_Name(gleif_base, "hasEnd") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasEntityExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has entity expiration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasEntityExpirationDate">https://www.gleif.org/ontology/Base/hasEntityExpirationDate</seealso>
    let hasEntityExpirationDate =
        Prefixed_Name(gleif_base, "hasEntityExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasEntityExpirationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has entity expiration reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasEntityExpirationReason">https://www.gleif.org/ontology/Base/hasEntityExpirationReason</seealso>
    let hasEntityExpirationReason =
        Prefixed_Name(gleif_base, "hasEntityExpirationReason") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasEntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has entity status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasEntityStatus">https://www.gleif.org/ontology/Base/hasEntityStatus</seealso>
    let hasEntityStatus = Prefixed_Name(gleif_base, "hasEntityStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasFirstAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has first address line"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasFirstAddressLine">https://www.gleif.org/ontology/Base/hasFirstAddressLine</seealso>
    let hasFirstAddressLine =
        Prefixed_Name(gleif_base, "hasFirstAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasGeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has geographic region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasGeographicRegion">https://www.gleif.org/ontology/Base/hasGeographicRegion</seealso>
    let hasGeographicRegion =
        Prefixed_Name(gleif_base, "hasGeographicRegion") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasInitialRegistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has initial registration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasInitialRegistrationDate">https://www.gleif.org/ontology/Base/hasInitialRegistrationDate</seealso>
    let hasInitialRegistrationDate =
        Prefixed_Name(gleif_base, "hasInitialRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasLastUpdateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has last modification date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasLastUpdateDate">https://www.gleif.org/ontology/Base/hasLastUpdateDate</seealso>
    let hasLastUpdateDate =
        Prefixed_Name(gleif_base, "hasLastUpdateDate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasLegalJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasLegalJurisdiction">https://www.gleif.org/ontology/Base/hasLegalJurisdiction</seealso>
    let hasLegalJurisdiction =
        Prefixed_Name(gleif_base, "hasLegalJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasLegalName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasLegalName">https://www.gleif.org/ontology/Base/hasLegalName</seealso>
    let hasLegalName = Prefixed_Name(gleif_base, "hasLegalName") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasMailRouting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"mail routing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasMailRouting">https://www.gleif.org/ontology/Base/hasMailRouting</seealso>
    let hasMailRouting = Prefixed_Name(gleif_base, "hasMailRouting") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasName">https://www.gleif.org/ontology/Base/hasName</seealso>
    let hasName = Prefixed_Name(gleif_base, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasNameASCII</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name ASCII"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameASCII">https://www.gleif.org/ontology/Base/hasNameASCII</seealso>
    let hasNameASCII = Prefixed_Name(gleif_base, "hasNameASCII") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameASCIIAutomatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name ASCII automatic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameASCIIAutomatic">https://www.gleif.org/ontology/Base/hasNameASCIIAutomatic</seealso>
    let hasNameASCIIAutomatic =
        Prefixed_Name(gleif_base, "hasNameASCIIAutomatic") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameASCIIPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name ASCII preferred"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameASCIIPreferred">https://www.gleif.org/ontology/Base/hasNameASCIIPreferred</seealso>
    let hasNameASCIIPreferred =
        Prefixed_Name(gleif_base, "hasNameASCIIPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameAdditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name additional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameAdditional">https://www.gleif.org/ontology/Base/hasNameAdditional</seealso>
    let hasNameAdditional =
        Prefixed_Name(gleif_base, "hasNameAdditional") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameAdditionalLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name additional local"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameAdditionalLocal">https://www.gleif.org/ontology/Base/hasNameAdditionalLocal</seealso>
    let hasNameAdditionalLocal =
        Prefixed_Name(gleif_base, "hasNameAdditionalLocal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameLegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name legal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameLegal">https://www.gleif.org/ontology/Base/hasNameLegal</seealso>
    let hasNameLegal = Prefixed_Name(gleif_base, "hasNameLegal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameLegalLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name legal local"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameLegalLocal">https://www.gleif.org/ontology/Base/hasNameLegalLocal</seealso>
    let hasNameLegalLocal =
        Prefixed_Name(gleif_base, "hasNameLegalLocal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name local"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameLocal">https://www.gleif.org/ontology/Base/hasNameLocal</seealso>
    let hasNameLocal = Prefixed_Name(gleif_base, "hasNameLocal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNamePreviousLegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name previous legal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNamePreviousLegal">https://www.gleif.org/ontology/Base/hasNamePreviousLegal</seealso>
    let hasNamePreviousLegal =
        Prefixed_Name(gleif_base, "hasNamePreviousLegal") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameTradingOrOperating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name trading or operating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameTradingOrOperating">https://www.gleif.org/ontology/Base/hasNameTradingOrOperating</seealso>
    let hasNameTradingOrOperating =
        Prefixed_Name(gleif_base, "hasNameTradingOrOperating") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameTranslatedEnglish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name translated English"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameTranslatedEnglish">https://www.gleif.org/ontology/Base/hasNameTranslatedEnglish</seealso>
    let hasNameTranslatedEnglish =
        Prefixed_Name(gleif_base, "hasNameTranslatedEnglish") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNameTransliterated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has name transliterated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNameTransliterated">https://www.gleif.org/ontology/Base/hasNameTransliterated</seealso>
    let hasNameTransliterated =
        Prefixed_Name(gleif_base, "hasNameTransliterated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasNextRenewalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has next renewal date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasNextRenewalDate">https://www.gleif.org/ontology/Base/hasNextRenewalDate</seealso>
    let hasNextRenewalDate =
        Prefixed_Name(gleif_base, "hasNextRenewalDate") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has postal code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasPostalCode">https://www.gleif.org/ontology/Base/hasPostalCode</seealso>
    let hasPostalCode = Prefixed_Name(gleif_base, "hasPostalCode") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasRegion">https://www.gleif.org/ontology/Base/hasRegion</seealso>
    let hasRegion = Prefixed_Name(gleif_base, "hasRegion") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasRegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasRegistrationStatus">https://www.gleif.org/ontology/Base/hasRegistrationStatus</seealso>
    let hasRegistrationStatus =
        Prefixed_Name(gleif_base, "hasRegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>gleif-base:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasSource">https://www.gleif.org/ontology/Base/hasSource</seealso>
    let hasSource = Prefixed_Name(gleif_base, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has start"</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasStart">https://www.gleif.org/ontology/Base/hasStart</seealso>
    let hasStart = Prefixed_Name(gleif_base, "hasStart") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasSuccessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has successor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasSuccessor">https://www.gleif.org/ontology/Base/hasSuccessor</seealso>
    let hasSuccessor = Prefixed_Name(gleif_base, "hasSuccessor") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasSuccessorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has successor name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasSuccessorName">https://www.gleif.org/ontology/Base/hasSuccessorName</seealso>
    let hasSuccessorName = Prefixed_Name(gleif_base, "hasSuccessorName") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasTag">https://www.gleif.org/ontology/Base/hasTag</seealso>
    let hasTag = Prefixed_Name(gleif_base, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasTarget">https://www.gleif.org/ontology/Base/hasTarget</seealso>
    let hasTarget = Prefixed_Name(gleif_base, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:hasWebsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has website"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/hasWebsite">https://www.gleif.org/ontology/Base/hasWebsite</seealso>
    let hasWebsite = Prefixed_Name(gleif_base, "hasWebsite") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"identifies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/identifies">https://www.gleif.org/ontology/Base/identifies</seealso>
    let identifies = Prefixed_Name(gleif_base, "identifies") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:isManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is managed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/isManagedBy">https://www.gleif.org/ontology/Base/isManagedBy</seealso>
    let isManagedBy = Prefixed_Name(gleif_base, "isManagedBy") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:isQualifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is qualified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/isQualifiedBy">https://www.gleif.org/ontology/Base/isQualifiedBy</seealso>
    let isQualifiedBy = Prefixed_Name(gleif_base, "isQualifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:isQuantifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is quantified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/isQuantifiedBy">https://www.gleif.org/ontology/Base/isQuantifiedBy</seealso>
    let isQuantifiedBy = Prefixed_Name(gleif_base, "isQuantifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:isRegisteredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is registered in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/isRegisteredIn">https://www.gleif.org/ontology/Base/isRegisteredIn</seealso>
    let isRegisteredIn = Prefixed_Name(gleif_base, "isRegisteredIn") |> PrefixedName
    /// <summary>
    ///   <para>gleif-base:records</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"records"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Base/records">https://www.gleif.org/ontology/Base/records</seealso>
    let records = Prefixed_Name(gleif_base, "records") |> PrefixedName
