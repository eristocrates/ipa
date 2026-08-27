namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.InternationalRegistriesAndAuthorities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_ireg =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_ireg |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"International Registries and Authorities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_ireg, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BankForInternationalSettlements</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Banque Des Reglements Internationaux"</para><para>"Bank für Internationalen Zahlungsausgleich"</para><para>"Bank for International Settlements"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlements">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlements</seealso>
    let BankForInternationalSettlements =
        Prefixed_Name(fibo_fbc_fct_ireg, "BankForInternationalSettlements") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BankForInternationalSettlementsAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank for International Settlements address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsAddress</seealso>
    let BankForInternationalSettlementsAddress =
        Prefixed_Name(fibo_fbc_fct_ireg, "BankForInternationalSettlementsAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BankForInternationalSettlementsAsBankingServicesProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:Bank</para>
    ///
    /// labels<para>"Bank for International Settlements as banking services provider"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsAsBankingServicesProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsAsBankingServicesProvider</seealso>
    let BankForInternationalSettlementsAsBankingServicesProvider =
        Prefixed_Name(fibo_fbc_fct_ireg, "BankForInternationalSettlementsAsBankingServicesProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BankForInternationalSettlementsDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank for International Settlements date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsDateEstablished</seealso>
    let BankForInternationalSettlementsDateEstablished =
        Prefixed_Name(fibo_fbc_fct_ireg, "BankForInternationalSettlementsDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Bank for International Settlements legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry</seealso>
    let BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_ireg, "BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BusinessIdentifierCodeDataRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business identifier code data record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeDataRecord">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeDataRecord</seealso>
    let BusinessIdentifierCodeDataRecord =
        Prefixed_Name(fibo_fbc_fct_ireg, "BusinessIdentifierCodeDataRecord") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BusinessIdentifierCodeRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"Business Identifier Code registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeRegistrationAuthority</seealso>
    let BusinessIdentifierCodeRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_ireg, "BusinessIdentifierCodeRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:BusinessIdentifierCodeRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"business identifier code registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeRegistry</seealso>
    let BusinessIdentifierCodeRegistry =
        Prefixed_Name(fibo_fbc_fct_ireg, "BusinessIdentifierCodeRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:GLEIFLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Global Legal Entity Identifier Foundation (GLEIF) legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GLEIFLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GLEIFLegalEntityIdentifierRegistryEntry</seealso>
    let GLEIFLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_ireg, "GLEIFLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:GlobalLEIIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///
    /// labels<para>"Global LEI Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLEIIndex">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLEIIndex</seealso>
    let GlobalLEIIndex =
        Prefixed_Name(fibo_fbc_fct_ireg, "GlobalLEIIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:GlobalLegalEntityIdentifierFoundation</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-fbo:NotForProfitOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Global Legal Entity Identifier Foundation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLegalEntityIdentifierFoundation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLegalEntityIdentifierFoundation</seealso>
    let GlobalLegalEntityIdentifierFoundation =
        Prefixed_Name(fibo_fbc_fct_ireg, "GlobalLegalEntityIdentifierFoundation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:GlobalLegalEntityIdentifierFoundationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Global Legal Entity Identifier Foundation address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLegalEntityIdentifierFoundationAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/GlobalLegalEntityIdentifierFoundationAddress</seealso>
    let GlobalLegalEntityIdentifierFoundationAddress =
        Prefixed_Name(fibo_fbc_fct_ireg, "GlobalLegalEntityIdentifierFoundationAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:IBANRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IBAN registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/IBANRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/IBANRegistrationAuthority</seealso>
    let IBANRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_ireg, "IBANRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:LegalEntityIdentfierRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"Legal Entity Identifier registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/LegalEntityIdentfierRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/LegalEntityIdentfierRegistrationAuthority</seealso>
    let LegalEntityIdentfierRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_ireg, "LegalEntityIdentfierRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:MICRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"MIC registration authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MICRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MICRegistrationAuthority</seealso>
    let MICRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_ireg, "MICRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:MarketIdentifierCodeRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"market identifier code registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MarketIdentifierCodeRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MarketIdentifierCodeRegistry</seealso>
    let MarketIdentifierCodeRegistry =
        Prefixed_Name(fibo_fbc_fct_ireg, "MarketIdentifierCodeRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:MarketIdentifierCodeRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market identifier code registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MarketIdentifierCodeRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MarketIdentifierCodeRegistryEntry</seealso>
    let MarketIdentifierCodeRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_ireg, "MarketIdentifierCodeRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:SWIFTLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Society for Worldwide Interbank Financial Telecommunication (SWIFT) legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SWIFTLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SWIFTLegalEntityIdentifierRegistryEntry</seealso>
    let SWIFTLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_ireg, "SWIFTLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:SocietyForWorldwideInterbankFinancialTelecommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-fbo:NotForProfitOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Society for Worldwide Interbank Financial Telecommunication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SocietyForWorldwideInterbankFinancialTelecommunication">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SocietyForWorldwideInterbankFinancialTelecommunication</seealso>
    let SocietyForWorldwideInterbankFinancialTelecommunication =
        Prefixed_Name(fibo_fbc_fct_ireg, "SocietyForWorldwideInterbankFinancialTelecommunication") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-ireg:SocietyForWorldwideInterbankFinancialTelecommunicationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Society for Worldwide Interbank Financial Telecommunication address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SocietyForWorldwideInterbankFinancialTelecommunicationAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/SocietyForWorldwideInterbankFinancialTelecommunicationAddress</seealso>
    let SocietyForWorldwideInterbankFinancialTelecommunicationAddress =
        Prefixed_Name(fibo_fbc_fct_ireg, "SocietyForWorldwideInterbankFinancialTelecommunicationAddress") |> PrefixedName
