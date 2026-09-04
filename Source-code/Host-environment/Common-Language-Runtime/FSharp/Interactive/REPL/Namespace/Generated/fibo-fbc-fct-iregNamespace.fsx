#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-ireg`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/" "fibo-fbc-fct-ireg"

    let _namespaceIri = _prefixId.prefix ""

    let BankForInternationalSettlements =
        _prefixId.prefix "BankForInternationalSettlements"

    let BankForInternationalSettlementsAddress =
        _prefixId.prefix "BankForInternationalSettlementsAddress"

    let BankForInternationalSettlementsAsBankingServicesProvider =
        _prefixId.prefix "BankForInternationalSettlementsAsBankingServicesProvider"

    let BankForInternationalSettlementsDateEstablished =
        _prefixId.prefix "BankForInternationalSettlementsDateEstablished"

    let BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BankForInternationalSettlementsLegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <para>rdfs:label : business identifier code data record^^xsd:string</para>
    ///   <para>skos:definition : entry in a registry that conforms to ISO 9362 for the management of BIC codes and related registration information^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : BIC data record^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.swift.com/standards/data-standards/bic^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/BusinessIdentifierCodeDataRecord">fibo-fbc-fct-ireg:BusinessIdentifierCodeDataRecord</a>
    /// </summary>
    let BusinessIdentifierCodeDataRecord =
        _prefixId.prefix "BusinessIdentifierCodeDataRecord"

    let BusinessIdentifierCodeRegistrationAuthority =
        _prefixId.prefix "BusinessIdentifierCodeRegistrationAuthority"

    let BusinessIdentifierCodeRegistry =
        _prefixId.prefix "BusinessIdentifierCodeRegistry"

    let GLEIFLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "GLEIFLegalEntityIdentifierRegistryEntry"

    let GlobalLEIIndex = _prefixId.prefix "GlobalLEIIndex"

    let GlobalLegalEntityIdentifierFoundation =
        _prefixId.prefix "GlobalLegalEntityIdentifierFoundation"

    let GlobalLegalEntityIdentifierFoundationAddress =
        _prefixId.prefix "GlobalLegalEntityIdentifierFoundationAddress"

    let IBANRegistrationAuthority = _prefixId.prefix "IBANRegistrationAuthority"

    let LegalEntityIdentfierRegistrationAuthority =
        _prefixId.prefix "LegalEntityIdentfierRegistrationAuthority"

    let MICRegistrationAuthority = _prefixId.prefix "MICRegistrationAuthority"
    let MarketIdentifierCodeRegistry = _prefixId.prefix "MarketIdentifierCodeRegistry"

    /// <summary>
    ///   <para>rdfs:label : market identifier code registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a market identifier code registry that conforms to ISO 10383^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MIC registry entry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/10383/iso-10383-market-identifier-codes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/MarketIdentifierCodeRegistryEntry">fibo-fbc-fct-ireg:MarketIdentifierCodeRegistryEntry</a>
    /// </summary>
    let MarketIdentifierCodeRegistryEntry =
        _prefixId.prefix "MarketIdentifierCodeRegistryEntry"

    let SWIFTLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "SWIFTLegalEntityIdentifierRegistryEntry"

    let SocietyForWorldwideInterbankFinancialTelecommunication =
        _prefixId.prefix "SocietyForWorldwideInterbankFinancialTelecommunication"

    let SocietyForWorldwideInterbankFinancialTelecommunicationAddress =
        _prefixId.prefix "SocietyForWorldwideInterbankFinancialTelecommunicationAddress"
