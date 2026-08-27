namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.CommercialRegistrationAuthorities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_cra =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_cra |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-cra:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Commercial Registration Authorities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_cra, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BGCPartnersInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BGC Partners, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersInc-US-DE</seealso>
    let BGCPartnersInc_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "BGCPartnersInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BGCPartnersIncBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"BGC Partners, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncBusinessEntityIdentifier</seealso>
    let BGCPartnersIncBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "BGCPartnersIncBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BGCPartnersIncDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:Date</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BGC Partners, Inc. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncDateEstablished</seealso>
    let BGCPartnersIncDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "BGCPartnersIncDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BGCPartnersIncHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BGC Partners, Inc. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BGCPartnersIncHeadquartersAddress</seealso>
    let BGCPartnersIncHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "BGCPartnersIncHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BSDRBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BSDR LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRBusinessEntityIdentifier</seealso>
    let BSDRBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "BSDRBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BSDRDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:Date</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BSDR date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRDateEstablished</seealso>
    let BSDRDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "BSDRDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BSDRHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BSDR LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRHeadquartersAddress</seealso>
    let BSDRHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "BSDRHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BSDRLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///
    /// labels<para>"BSDR LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BSDRLLC-US-DE</seealso>
    let BSDRLLC_US_DE = Prefixed_Name(fibo_fbc_fct_cra, "BSDRLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Bloomberg L.P. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergBusinessEntityIdentifier</seealso>
    let BloombergBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergDateEstablished</seealso>
    let BloombergDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Bloomberg Finance L.P. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceBusinessEntityIdentifier</seealso>
    let BloombergFinanceBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Bloomberg Finance L.P. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceDateEstablished</seealso>
    let BloombergFinanceDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceLP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg Finance L.P."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLP">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLP</seealso>
    let BloombergFinanceLP =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceLP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceLP-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ptr-ptr:LimitedPartnership</para>
    ///
    /// labels<para>"Bloomberg Finance L.P. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLP-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLP-US-DE</seealso>
    let BloombergFinanceLP_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceLP-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceLPAsLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg Finance L.P. as local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLPAsLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceLPAsLocalOperatingUnit</seealso>
    let BloombergFinanceLPAsLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceLPAsLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergFinanceOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg Finance ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceOwnership">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergFinanceOwnership</seealso>
    let BloombergFinanceOwnership =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergFinanceOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergHeadquartersAddress</seealso>
    let BloombergHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergLP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg L.P."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergLP">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergLP</seealso>
    let BloombergLP = Prefixed_Name(fibo_fbc_fct_cra, "BloombergLP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BloombergLP-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ptr-ptr:LimitedPartnership</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bloomberg L.P. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergLP-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BloombergLP-US-DE</seealso>
    let BloombergLP_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "BloombergLP-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BusinessEntityData</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Business Entity Data (BED) B.V."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityData">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityData</seealso>
    let BusinessEntityData =
        Prefixed_Name(fibo_fbc_fct_cra, "BusinessEntityData") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BusinessEntityData-NL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:PrivatelyHeldCompany</para>
    ///
    /// labels<para>"Business Entity Data (BED) B.V. NL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityData-NL">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityData-NL</seealso>
    let BusinessEntityData_NL =
        Prefixed_Name(fibo_fbc_fct_cra, "BusinessEntityData-NL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BusinessEntityDataHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Business Entity Data (BED) B.V. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityDataHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityDataHeadquartersAddress</seealso>
    let BusinessEntityDataHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "BusinessEntityDataHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:BusinessEntityDataLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Business Entity Data (BED) B.V. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityDataLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/BusinessEntityDataLegalAddress</seealso>
    let BusinessEntityDataLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "BusinessEntityDataLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ChicagoMercantileExchangeBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Chicago Mercantile Exchange (CME) business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeBusinessEntityIdentifier</seealso>
    let ChicagoMercantileExchangeBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "ChicagoMercantileExchangeBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ChicagoMercantileExchangeDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:Date</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chicago Mercantile Exchange (CME) date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeDateEstablished</seealso>
    let ChicagoMercantileExchangeDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "ChicagoMercantileExchangeDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ChicagoMercantileExchangeHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chicago Mercantile Exchange (CME) headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeHeadquartersAddress</seealso>
    let ChicagoMercantileExchangeHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "ChicagoMercantileExchangeHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ChicagoMercantileExchangeInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chicago Mercantile Exchange, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ChicagoMercantileExchangeInc-US-DE</seealso>
    let ChicagoMercantileExchangeInc_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "ChicagoMercantileExchangeInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:Clearstream</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:CentralSecuritiesDepository</para>
    ///   <para>fibo-fbc-fct-fse:CentralCounterpartyClearingHouse</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:ClearingBank</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///
    /// labels<para>"Clearstream Banking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/Clearstream">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/Clearstream</seealso>
    let Clearstream = Prefixed_Name(fibo_fbc_fct_cra, "Clearstream") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ClearstreamBankingHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Clearstream Banking S.A. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingHeadquartersAddress</seealso>
    let ClearstreamBankingHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "ClearstreamBankingHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ClearstreamBankingLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Clearstream Banking S.A. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingLegalAddress</seealso>
    let ClearstreamBankingLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "ClearstreamBankingLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ClearstreamBankingSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///
    /// labels<para>"Clearstream Banking S.A."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingSA">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ClearstreamBankingSA</seealso>
    let ClearstreamBankingSA =
        Prefixed_Name(fibo_fbc_fct_cra, "ClearstreamBankingSA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTC-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-tr-tr:Trust</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Depository Trust Company US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTC-US-NY">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTC-US-NY</seealso>
    let DTC_US_NY = Prefixed_Name(fibo_fbc_fct_cra, "DTC-US-NY") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DTCC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCC-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCC-US-DE</seealso>
    let DTCC_US_DE = Prefixed_Name(fibo_fbc_fct_cra, "DTCC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCDataRepositoryBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"business entity identifier for DTCC Data Repository (U.S) LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryBusinessEntityIdentifier</seealso>
    let DTCCDataRepositoryBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCDataRepositoryBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCDataRepositoryDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:Date</para>
    ///
    /// labels<para>"DTCC Data Repository (U.S) LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryDateEstablished</seealso>
    let DTCCDataRepositoryDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCDataRepositoryDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCDataRepositoryHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DTCC Data Repository (U.S) LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryHeadquartersAddress</seealso>
    let DTCCDataRepositoryHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCDataRepositoryHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCDataRepositoryLLC-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///
    /// labels<para>"DTCC Data Repository (U.S) LLC US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryLLC-US-NY">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryLLC-US-NY</seealso>
    let DTCCDataRepositoryLLC_US_NY =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCDataRepositoryLLC-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCDataRepositoryOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DTCC Data Repository ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryOwnership">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCDataRepositoryOwnership</seealso>
    let DTCCDataRepositoryOwnership =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCDataRepositoryOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Depository Trust &amp; Clearing Corporation headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCHeadquartersAddress</seealso>
    let DTCCHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCCLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"The Depository Trust &amp; Clearing Corporation legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCCLegalAddress</seealso>
    let DTCCLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCCLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DTCHeadquartersAndLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"DTC headquarters and legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCHeadquartersAndLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DTCHeadquartersAndLegalAddress</seealso>
    let DTCHeadquartersAndLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "DTCHeadquartersAndLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DepositoryTrustAndClearingCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"The Depository Trust &amp; Clearing Corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustAndClearingCorporation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustAndClearingCorporation</seealso>
    let DepositoryTrustAndClearingCorporation =
        Prefixed_Name(fibo_fbc_fct_cra, "DepositoryTrustAndClearingCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DepositoryTrustCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:CentralCounterpartyClearingHouse</para>
    ///   <para>fibo-fbc-fct-fse:CentralSecuritiesDepository</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"Depository Trust Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustCompany</seealso>
    let DepositoryTrustCompany =
        Prefixed_Name(fibo_fbc_fct_cra, "DepositoryTrustCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:DepositoryTrustCompanyOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///
    /// labels<para>"Depository Trust Company ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustCompanyOwnership">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/DepositoryTrustCompanyOwnership</seealso>
    let DepositoryTrustCompanyOwnership =
        Prefixed_Name(fibo_fbc_fct_cra, "DepositoryTrustCompanyOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:Euroclear</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///   <para>fibo-fbc-fct-fse:ClearingBank</para>
    ///   <para>fibo-fbc-fct-fse:CentralSecuritiesDepository</para>
    ///   <para>fibo-fbc-fct-fse:CentralCounterpartyClearingHouse</para>
    ///
    /// labels<para>"Euroclear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/Euroclear">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/Euroclear</seealso>
    let Euroclear = Prefixed_Name(fibo_fbc_fct_cra, "Euroclear") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:EuroclearHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Euroclear SA/NV headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearHeadquartersAddress</seealso>
    let EuroclearHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "EuroclearHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:EuroclearLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Euroclear SA/NV legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearLegalAddress</seealso>
    let EuroclearLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "EuroclearLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:EuroclearSANV</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Euroclear SA/NV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearSANV">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/EuroclearSANV</seealso>
    let EuroclearSANV = Prefixed_Name(fibo_fbc_fct_cra, "EuroclearSANV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:GlobalLEIIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Global LEI Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/GlobalLEIIndex">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/GlobalLEIIndex</seealso>
    let GlobalLEIIndex =
        Prefixed_Name(fibo_fbc_fct_cra, "GlobalLEIIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:GlobalMarketsEntityIdentifierRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///
    /// labels<para>"Global Markets Entity Identifier registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/GlobalMarketsEntityIdentifierRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/GlobalMarketsEntityIdentifierRegistry</seealso>
    let GlobalMarketsEntityIdentifierRegistry =
        Prefixed_Name(fibo_fbc_fct_cra, "GlobalMarketsEntityIdentifierRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmann</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///
    /// labels<para>"Herausgebergemeinschaft Wertpapier-Mitteilungen Keppler, Lehmann"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmann">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmann</seealso>
    let HerausgebergemeinschaftWertpapier_MitteilungenKepplerLehmann =
        Prefixed_Name(fibo_fbc_fct_cra, "HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmann") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmannGmbHAndCoKG-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:PrivatelyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Herausgebergemeinschaft Wertpapier-Mitteilungen Keppler, Lehmann GmbH &amp; Co. KG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmannGmbHAndCoKG-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmannGmbHAndCoKG-DE</seealso>
    let HerausgebergemeinschaftWertpapier_MitteilungenKepplerLehmannGmbHAndCoKG_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmannGmbHAndCoKG-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ICEBenchmarkAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    ///
    /// labels<para>"ICE Benchmark Administration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICEBenchmarkAdministration">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICEBenchmarkAdministration</seealso>
    let ICEBenchmarkAdministration =
        Prefixed_Name(fibo_fbc_fct_cra, "ICEBenchmarkAdministration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ICETradeVaultLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ICE Trade Vault, LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLC-US-DE</seealso>
    let ICETradeVaultLLC_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "ICETradeVaultLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ICETradeVaultLLCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"business entity identifier for ICE Trade Vault, LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCBusinessEntityIdentifier</seealso>
    let ICETradeVaultLLCBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "ICETradeVaultLLCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ICETradeVaultLLCDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:Date</para>
    ///
    /// labels<para>"ICE Trade Vault, LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCDateEstablished</seealso>
    let ICETradeVaultLLCDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "ICETradeVaultLLCDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ICETradeVaultLLCHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ICE Trade Vault, LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ICETradeVaultLLCHeadquartersAddress</seealso>
    let ICETradeVaultLLCHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "ICETradeVaultLLCHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Intercontinental Exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchange">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchange</seealso>
    let IntercontinentalExchange =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchangeBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Intercontinental Exchange, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeBusinessEntityIdentifier</seealso>
    let IntercontinentalExchangeBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchangeBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchangeDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Intercontinental Exchange date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeDateEstablished</seealso>
    let IntercontinentalExchangeDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchangeDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchangeDateRegistered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Intercontinental Exchange date registered"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeDateRegistered">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeDateRegistered</seealso>
    let IntercontinentalExchangeDateRegistered =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchangeDateRegistered") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchangeHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Intercontinental Exchange headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeHeadquartersAddress</seealso>
    let IntercontinentalExchangeHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchangeHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:IntercontinentalExchangeInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Intercontinental Exchange, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/IntercontinentalExchangeInc-US-DE</seealso>
    let IntercontinentalExchangeInc_US_DE =
        Prefixed_Name(fibo_fbc_fct_cra, "IntercontinentalExchangeInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:NationalNumberingAgency</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"London Stock Exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchange">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchange</seealso>
    let LondonStockExchange =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchangeAsLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///
    /// labels<para>"London Stock Exchange as local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeAsLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeAsLocalOperatingUnit</seealso>
    let LondonStockExchangeAsLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchangeAsLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchangeHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"London Stock Exchange plc. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeHeadquartersAddress</seealso>
    let LondonStockExchangeHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchangeHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchangeLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"London Stock Exchange plc. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeLegalAddress</seealso>
    let LondonStockExchangeLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchangeLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchangePlc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"London Stock Exchange plc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangePlc">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangePlc</seealso>
    let LondonStockExchangePlc =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchangePlc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LondonStockExchangeUnaVistaRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"London Stock Exchange UnaVista Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeUnaVistaRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LondonStockExchangeUnaVistaRegistry</seealso>
    let LondonStockExchangeUnaVistaRegistry =
        Prefixed_Name(fibo_fbc_fct_cra, "LondonStockExchangeUnaVistaRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LuxCSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:CentralSecuritiesDepository</para>
    ///
    /// labels<para>"Lux CSD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSD">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSD</seealso>
    let LuxCSD = Prefixed_Name(fibo_fbc_fct_cra, "LuxCSD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LuxCSDAsLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///
    /// labels<para>"Lux CSD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDAsLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDAsLocalOperatingUnit</seealso>
    let LuxCSDAsLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_cra, "LuxCSDAsLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LuxCSDLEIRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///
    /// labels<para>"Lux CSD LEI Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDLEIRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDLEIRegistry</seealso>
    let LuxCSDLEIRegistry =
        Prefixed_Name(fibo_fbc_fct_cra, "LuxCSDLEIRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:LuxCSDSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"LuxCSD S.A."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDSA">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/LuxCSDSA</seealso>
    let LuxCSDSA = Prefixed_Name(fibo_fbc_fct_cra, "LuxCSDSA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXFinancialInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:NationalNumberingAgency</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///
    /// labels<para>"SIX Financial Information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformation</seealso>
    let SIXFinancialInformation =
        Prefixed_Name(fibo_fbc_fct_cra, "SIXFinancialInformation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXFinancialInformationAG</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SIX Financial Information AG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformationAG">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformationAG</seealso>
    let SIXFinancialInformationAG =
        Prefixed_Name(fibo_fbc_fct_cra, "SIXFinancialInformationAG") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXFinancialInformationAsLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///
    /// labels<para>"SIX Financial Information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformationAsLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXFinancialInformationAsLocalOperatingUnit</seealso>
    let SIXFinancialInformationAsLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_cra, "SIXFinancialInformationAsLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"SIX Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroup">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroup</seealso>
    let SIXGroup = Prefixed_Name(fibo_fbc_fct_cra, "SIXGroup") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXGroupAG</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SIX Group AG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroupAG">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroupAG</seealso>
    let SIXGroupAG = Prefixed_Name(fibo_fbc_fct_cra, "SIXGroupAG") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SIXGroupAGHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"SIX Group AG headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroupAGHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SIXGroupAGHeadquartersAddress</seealso>
    let SIXGroupAGHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "SIXGroupAGHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SPGlobal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"S&amp;P Global"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobal">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobal</seealso>
    let SPGlobal = Prefixed_Name(fibo_fbc_fct_cra, "SPGlobal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SPGlobalBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"S&amp;P Global Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalBusinessEntityIdentifier</seealso>
    let SPGlobalBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_cra, "SPGlobalBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SPGlobalDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"S&amp;P Global date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalDateEstablished</seealso>
    let SPGlobalDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "SPGlobalDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SPGlobalHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"S&amp;P Global headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalHeadquartersAddress</seealso>
    let SPGlobalHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "SPGlobalHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:SPGlobalInc-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"S&amp;P Global Inc. US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalInc-US-NY">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/SPGlobalInc-US-NY</seealso>
    let SPGlobalInc_US_NY =
        Prefixed_Name(fibo_fbc_fct_cra, "SPGlobalInc-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"Thomson Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReuters">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReuters</seealso>
    let ThomsonReuters =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReutersCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thomson Reuters Corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersCorporation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersCorporation</seealso>
    let ThomsonReutersCorporation =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReutersCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReutersDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Thomson Reuters date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersDateEstablished</seealso>
    let ThomsonReutersDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReutersDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReutersHeadquartersAddress-CA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thomson Reuters Corporation Canadian headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersHeadquartersAddress-CA">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersHeadquartersAddress-CA</seealso>
    let ThomsonReutersHeadquartersAddress_CA =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReutersHeadquartersAddress-CA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReutersHeadquartersAddress-US</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Thomson Reuters headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersHeadquartersAddress-US">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersHeadquartersAddress-US</seealso>
    let ThomsonReutersHeadquartersAddress_US =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReutersHeadquartersAddress-US") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:ThomsonReutersLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thomson Reuters legal domicile address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/ThomsonReutersLegalAddress</seealso>
    let ThomsonReutersLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "ThomsonReutersLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:UBIsecureOy-FI</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateLimitedCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ubisecure Oy FI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOy-FI">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOy-FI</seealso>
    let UBIsecureOy_FI =
        Prefixed_Name(fibo_fbc_fct_cra, "UBIsecureOy-FI") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:UBIsecureOyDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ubisecure Oy date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOyDateEstablished">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOyDateEstablished</seealso>
    let UBIsecureOyDateEstablished =
        Prefixed_Name(fibo_fbc_fct_cra, "UBIsecureOyDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:UBIsecureOyHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Ubisecure Oy headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOyHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UBIsecureOyHeadquartersAddress</seealso>
    let UBIsecureOyHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "UBIsecureOyHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:UbisecureAsLocalOperatingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LocalOperatingUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ubisecure Oy as local operating unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UbisecureAsLocalOperatingUnit">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/UbisecureAsLocalOperatingUnit</seealso>
    let UbisecureAsLocalOperatingUnit =
        Prefixed_Name(fibo_fbc_fct_cra, "UbisecureAsLocalOperatingUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:WMDatenserviceEntityIdentifierRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistry</para>
    ///
    /// labels<para>"WM Datenservice Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/WMDatenserviceEntityIdentifierRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/WMDatenserviceEntityIdentifierRegistry</seealso>
    let WMDatenserviceEntityIdentifierRegistry =
        Prefixed_Name(fibo_fbc_fct_cra, "WMDatenserviceEntityIdentifierRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cra:WMGruppeHeadquartersAndLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Herausgebergemeinschaft Wertpapier-Mitteilungen Keppler, Lehmann (WM Gruppe) headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/WMGruppeHeadquartersAndLegalAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/WMGruppeHeadquartersAndLegalAddress</seealso>
    let WMGruppeHeadquartersAndLegalAddress =
        Prefixed_Name(fibo_fbc_fct_cra, "WMGruppeHeadquartersAndLegalAddress") |> PrefixedName
