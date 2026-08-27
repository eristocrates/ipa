namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessRegistries.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_breg =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_breg |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-breg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Business Registries Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_breg, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-breg:ActiveStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"active status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/ActiveStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/ActiveStatus</seealso>
    let ActiveStatus = Prefixed_Name(fibo_fbc_fct_breg, "ActiveStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:AnnulledStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///
    /// labels<para>"annulled status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/AnnulledStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/AnnulledStatus</seealso>
    let AnnulledStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "AnnulledStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:BusinessRegisterIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business register identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegisterIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegisterIdentifier</seealso>
    let BusinessRegisterIdentifier =
        Prefixed_Name(fibo_fbc_fct_breg, "BusinessRegisterIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistrationAuthority</seealso>
    let BusinessRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_breg, "BusinessRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistry</seealso>
    let BusinessRegistry =
        Prefixed_Name(fibo_fbc_fct_breg, "BusinessRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/BusinessRegistryEntry</seealso>
    let BusinessRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_breg, "BusinessRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:CancelledStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"cancelled status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/CancelledStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/CancelledStatus</seealso>
    let CancelledStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "CancelledStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:DuplicateStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"duplicate status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/DuplicateStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/DuplicateStatus</seealso>
    let DuplicateStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "DuplicateStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity expiration reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReason">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReason</seealso>
    let EntityExpirationReason =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityExpirationReason") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReasonCorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity expiration reason - corporate action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonCorporateAction">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonCorporateAction</seealso>
    let EntityExpirationReasonCorporateAction =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityExpirationReasonCorporateAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReasonDissolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity expiration reason - disolved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonDissolved">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonDissolved</seealso>
    let EntityExpirationReasonDissolved =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityExpirationReasonDissolved") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReasonOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityExpirationReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity expiration reason - other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonOther">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityExpirationReasonOther</seealso>
    let EntityExpirationReasonOther =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityExpirationReasonOther") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityLegalFormRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistry</seealso>
    let EntityLegalFormRegistry =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityLegalFormRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityLegalFormRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityLegalFormRegistryEntry</seealso>
    let EntityLegalFormRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityLegalFormRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityStatus</seealso>
    let EntityStatus = Prefixed_Name(fibo_fbc_fct_breg, "EntityStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity validation level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevel">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevel</seealso>
    let EntityValidationLevel =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityValidationLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevelEntitySuppliedOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity validation level - entity-supplied only"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelEntitySuppliedOnly">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelEntitySuppliedOnly</seealso>
    let EntityValidationLevelEntitySuppliedOnly =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityValidationLevelEntitySuppliedOnly") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevelFullyCorroborated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevel</para>
    ///
    /// labels<para>"entity validation level - fully corroborated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelFullyCorroborated">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelFullyCorroborated</seealso>
    let EntityValidationLevelFullyCorroborated =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityValidationLevelFullyCorroborated") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevelPartiallyCorroborated</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityValidationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"entity validation level - partially corroborated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelPartiallyCorroborated">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/EntityValidationLevelPartiallyCorroborated</seealso>
    let EntityValidationLevelPartiallyCorroborated =
        Prefixed_Name(fibo_fbc_fct_breg, "EntityValidationLevelPartiallyCorroborated") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:InactiveStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:EntityStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"inactive status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/InactiveStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/InactiveStatus</seealso>
    let InactiveStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "InactiveStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:IssuedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///
    /// labels<para>"issued status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/IssuedStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/IssuedStatus</seealso>
    let IssuedStatus = Prefixed_Name(fibo_fbc_fct_breg, "IssuedStatus") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-breg:LapsedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"lapsed status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LapsedStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LapsedStatus</seealso>
    let LapsedStatus = Prefixed_Name(fibo_fbc_fct_breg, "LapsedStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistry</seealso>
    let LegalEntityIdentifierRegistry =
        Prefixed_Name(fibo_fbc_fct_breg, "LegalEntityIdentifierRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LegalEntityIdentifierRegistryEntry</seealso>
    let LegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_breg, "LegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/LocalOperatingUnit</seealso>
    let LocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_breg, "LocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:MergedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"merged status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/MergedStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/MergedStatus</seealso>
    let MergedStatus = Prefixed_Name(fibo_fbc_fct_breg, "MergedStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:NorthAmericanIndustryClassificationSystemCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"North American Industry Classification System code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemCode</seealso>
    let NorthAmericanIndustryClassificationSystemCode =
        Prefixed_Name(fibo_fbc_fct_breg, "NorthAmericanIndustryClassificationSystemCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:NorthAmericanIndustryClassificationSystemScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"North American Industry Classification System scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/NorthAmericanIndustryClassificationSystemScheme</seealso>
    let NorthAmericanIndustryClassificationSystemScheme =
        Prefixed_Name(fibo_fbc_fct_breg, "NorthAmericanIndustryClassificationSystemScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:PendingArchivalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///
    /// labels<para>"pending archival status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingArchivalStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingArchivalStatus</seealso>
    let PendingArchivalStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "PendingArchivalStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:PendingTransferStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pending transfer status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingTransferStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingTransferStatus</seealso>
    let PendingTransferStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "PendingTransferStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:PendingValidationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pending validation status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingValidationStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/PendingValidationStatus</seealso>
    let PendingValidationStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "PendingValidationStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration authority code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationAuthorityCode</seealso>
    let RegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_breg, "RegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RegistrationStatus</seealso>
    let RegistrationStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "RegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:RetiredStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///
    /// labels<para>"retired status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RetiredStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/RetiredStatus</seealso>
    let RetiredStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "RetiredStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:StandardIndustrialClassificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard industrial classification code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationCode</seealso>
    let StandardIndustrialClassificationCode =
        Prefixed_Name(fibo_fbc_fct_breg, "StandardIndustrialClassificationCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:StandardIndustrialClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard industrial classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/StandardIndustrialClassificationScheme</seealso>
    let StandardIndustrialClassificationScheme =
        Prefixed_Name(fibo_fbc_fct_breg, "StandardIndustrialClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:TransferredStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"transferred status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/TransferredStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/TransferredStatus</seealso>
    let TransferredStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "TransferredStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasAlternativeLanguageLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has alternative language legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAlternativeLanguageLegalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAlternativeLanguageLegalName</seealso>
    let hasAlternativeLanguageLegalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasAlternativeLanguageLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasAutomaticallyTransliteratedLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has automatically transliterated legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAutomaticallyTransliteratedLegalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasAutomaticallyTransliteratedLegalName</seealso>
    let hasAutomaticallyTransliteratedLegalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasAutomaticallyTransliteratedLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasEntityExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has entity expiration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationDate</seealso>
    let hasEntityExpirationDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasEntityExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasEntityExpirationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has entity expiration reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationReason">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityExpirationReason</seealso>
    let hasEntityExpirationReason =
        Prefixed_Name(fibo_fbc_fct_breg, "hasEntityExpirationReason") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasEntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has entity status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasEntityStatus</seealso>
    let hasEntityStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "hasEntityStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has expiry date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasExpiryDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasExpiryDate</seealso>
    let hasExpiryDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasExpiryDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasInitialRegistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has initial registration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasInitialRegistrationDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasInitialRegistrationDate</seealso>
    let hasInitialRegistrationDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasInitialRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasManagingLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has managing local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasManagingLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasManagingLocalOperatingUnit</seealso>
    let hasManagingLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_breg, "hasManagingLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasPreferredTransliteratedLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has preferred transliterated legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPreferredTransliteratedLegalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPreferredTransliteratedLegalName</seealso>
    let hasPreferredTransliteratedLegalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasPreferredTransliteratedLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasPriorLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has prior legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPriorLegalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasPriorLegalName</seealso>
    let hasPriorLegalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasPriorLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasRegistrationRevisionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has registration status revision date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationRevisionDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationRevisionDate</seealso>
    let hasRegistrationRevisionDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasRegistrationRevisionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasRegistrationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registration status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistrationStatus</seealso>
    let hasRegistrationStatus =
        Prefixed_Name(fibo_fbc_fct_breg, "hasRegistrationStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasRegistryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has registry name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistryName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRegistryName</seealso>
    let hasRegistryName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasRegistryName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasRenewalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has renewal date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRenewalDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasRenewalDate</seealso>
    let hasRenewalDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasRenewalDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasTradingOrOperationalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has trading or operational name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTradingOrOperationalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTradingOrOperationalName</seealso>
    let hasTradingOrOperationalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasTradingOrOperationalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasTransliteratedLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transliterated legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTransliteratedLegalName">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasTransliteratedLegalName</seealso>
    let hasTransliteratedLegalName =
        Prefixed_Name(fibo_fbc_fct_breg, "hasTransliteratedLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasValidationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationAuthority</seealso>
    let hasValidationAuthority =
        Prefixed_Name(fibo_fbc_fct_breg, "hasValidationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasValidationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has validation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationDate">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationDate</seealso>
    let hasValidationDate =
        Prefixed_Name(fibo_fbc_fct_breg, "hasValidationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:hasValidationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has validation level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationLevel">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/hasValidationLevel</seealso>
    let hasValidationLevel =
        Prefixed_Name(fibo_fbc_fct_breg, "hasValidationLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-breg:isSelfMaintained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is self-maintained"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/isSelfMaintained">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/isSelfMaintained</seealso>
    let isSelfMaintained =
        Prefixed_Name(fibo_fbc_fct_breg, "isSelfMaintained") |> PrefixedName
