namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.LegalEntities.MarketsAndExchangesExamples.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_le_mktex =
    let _namespace_iri = Namespace_Iri fibo_exmp_le_mktex |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-le-mktex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"US Markets and Exchanges Individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_le_mktex, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:CBOEGlobalMarketsBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CBOE Global Markets, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsBusinessEntityIdentifier</seealso>
    let CBOEGlobalMarketsBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "CBOEGlobalMarketsBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:CBOEGlobalMarketsDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CBOE Global Markets date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsDateEstablished</seealso>
    let CBOEGlobalMarketsDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "CBOEGlobalMarketsDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:CBOEGlobalMarketsHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"CBOE Global Markets headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsHeadquartersAddress</seealso>
    let CBOEGlobalMarketsHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_mktex, "CBOEGlobalMarketsHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:CBOEGlobalMarketsInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CBOE Global Markets, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/CBOEGlobalMarketsInc-US-DE</seealso>
    let CBOEGlobalMarketsInc_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "CBOEGlobalMarketsInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:ChicagoBoardOptionsExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:OperatingLevelMarket</para>
    ///
    /// labels<para>"Chicago Board Options Exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchange">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchange</seealso>
    let ChicagoBoardOptionsExchange =
        Prefixed_Name(fibo_exmp_le_mktex, "ChicagoBoardOptionsExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:ChicagoBoardOptionsExchangeAsServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    ///   <para>fibo-be-oac-cpty:DeJureControllingInterestParty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-oac-cpty:EntityControllingParty</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"Chicago Board Options Exchange as service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchangeAsServiceProvider">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchangeAsServiceProvider</seealso>
    let ChicagoBoardOptionsExchangeAsServiceProvider =
        Prefixed_Name(fibo_exmp_le_mktex, "ChicagoBoardOptionsExchangeAsServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:ChicagoBoardOptionsExchangeDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Chicago Board Options Exchange date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchangeDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/ChicagoBoardOptionsExchangeDateEstablished</seealso>
    let ChicagoBoardOptionsExchangeDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "ChicagoBoardOptionsExchangeDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:IntercontinentalExchangeHoldings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"Intercontinental Exchange Holdings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/IntercontinentalExchangeHoldings">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/IntercontinentalExchangeHoldings</seealso>
    let IntercontinentalExchangeHoldings =
        Prefixed_Name(fibo_exmp_le_mktex, "IntercontinentalExchangeHoldings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEAmericanOptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketSegmentLevelMarket</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE American Options"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptions">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptions</seealso>
    let NYSEAmericanOptions =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEAmericanOptions") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEAmericanOptionsAsServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE American Options as service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsAsServiceProvider">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsAsServiceProvider</seealso>
    let NYSEAmericanOptionsAsServiceProvider =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEAmericanOptionsAsServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEAmericanOptionsBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"NYSE American Options, LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsBusinessEntityIdentifier</seealso>
    let NYSEAmericanOptionsBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEAmericanOptionsBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEAmericanOptionsDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE American Options LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsDateEstablished</seealso>
    let NYSEAmericanOptionsDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEAmericanOptionsDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEAmericanOptionsLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE American Options LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEAmericanOptionsLLC-US-DE</seealso>
    let NYSEAmericanOptionsLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEAmericanOptionsLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArca</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketSegmentLevelMarket</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Arca"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArca">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArca</seealso>
    let NYSEArca = Prefixed_Name(fibo_exmp_le_mktex, "NYSEArca") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaAsServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"NYSE Arca as service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaAsServiceProvider">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaAsServiceProvider</seealso>
    let NYSEArcaAsServiceProvider =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaAsServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"NYSE Arca, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaBusinessEntityIdentifier</seealso>
    let NYSEArcaBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Arca date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaDateEstablished</seealso>
    let NYSEArcaDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaHoldings</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"NYSE Arca Holdings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldings">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldings</seealso>
    let NYSEArcaHoldings =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaHoldings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaHoldingsBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"NYSE Arca Holdings, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsBusinessEntityIdentifier</seealso>
    let NYSEArcaHoldingsBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaHoldingsBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaHoldingsInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///
    /// labels<para>"NYSE Arca Holdings, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsInc-US-DE</seealso>
    let NYSEArcaHoldingsInc_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaHoldingsInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaHoldingsIncDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Arca Holdings, Inc. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsIncDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaHoldingsIncDateEstablished</seealso>
    let NYSEArcaHoldingsIncDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaHoldingsIncDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Arca, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaInc-US-DE</seealso>
    let NYSEArcaInc_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaIncDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"NYSE Arca, Inc. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaIncDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaIncDateEstablished</seealso>
    let NYSEArcaIncDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaIncDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEArcaIncHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"NYSE Arca, Inc. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaIncHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEArcaIncHeadquartersAddress</seealso>
    let NYSEArcaIncHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEArcaIncHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:DarkPool</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketSegmentLevelMarket</para>
    ///
    /// labels<para>"NYSE Dark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEDark">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEDark</seealso>
    let NYSEDark = Prefixed_Name(fibo_exmp_le_mktex, "NYSEDark") |> PrefixedName
    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    ///
    /// labels<para>"NYSE Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroup">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroup</seealso>
    let NYSEGroup = Prefixed_Name(fibo_exmp_le_mktex, "NYSEGroup") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEGroupBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Group, Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupBusinessEntityIdentifier</seealso>
    let NYSEGroupBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEGroupBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEGroupDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Group, Inc. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupDateEstablished</seealso>
    let NYSEGroupDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEGroupDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEGroupInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///
    /// labels<para>"NYSE Group, Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEGroupInc-US-DE</seealso>
    let NYSEGroupInc_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEGroupInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEHoldings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:HoldingCompany</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"NYSE Holdings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldings">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldings</seealso>
    let NYSEHoldings = Prefixed_Name(fibo_exmp_le_mktex, "NYSEHoldings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEHoldingsBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"NYSE Holdings LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsBusinessEntityIdentifier</seealso>
    let NYSEHoldingsBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEHoldingsBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEHoldingsDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:Date</para>
    ///
    /// labels<para>"NYSE Holdings LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsDateEstablished</seealso>
    let NYSEHoldingsDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEHoldingsDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NYSEHoldingsLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NYSE Holdings LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NYSEHoldingsLLC-US-DE</seealso>
    let NYSEHoldingsLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "NYSEHoldingsLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:OperatingLevelMarket</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchange">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchange</seealso>
    let NewYorkStockExchange =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeAsServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange as service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeAsServiceProvider">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeAsServiceProvider</seealso>
    let NewYorkStockExchangeAsServiceProvider =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeAsServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeDateEstablished</seealso>
    let NewYorkStockExchangeDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeHeadquartersAddress</seealso>
    let NewYorkStockExchangeHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeLLC-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange LLC US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLC-US-NY">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLC-US-NY</seealso>
    let NewYorkStockExchangeLLC_US_NY =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeLLC-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeLLCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"New York Stock Exchange LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLCBusinessEntityIdentifier</seealso>
    let NewYorkStockExchangeLLCBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeLLCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:NewYorkStockExchangeLLCDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York Stock Exchange LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLCDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/NewYorkStockExchangeLLCDateEstablished</seealso>
    let NewYorkStockExchangeLLCDateEstablished =
        Prefixed_Name(fibo_exmp_le_mktex, "NewYorkStockExchangeLLCDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroup-Delaware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:ThirdPartyAgent</para>
    ///   <para>fibo-fbc-pas-fpas:AgentForServiceOfProcess</para>
    ///
    /// labels<para>"United Agent Group - Delaware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroup-Delaware">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroup-Delaware</seealso>
    let UnitedAgentGroup_Delaware =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroup-Delaware") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroup-NewYork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:AgentForServiceOfProcess</para>
    ///   <para>fibo-fbc-pas-fpas:ThirdPartyAgent</para>
    ///
    /// labels<para>"United Agent Group - New York"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroup-NewYork">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroup-NewYork</seealso>
    let UnitedAgentGroup_NewYork =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroup-NewYork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"United Agent Group Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE</seealso>
    let UnitedAgentGroupInc_US_DE =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-DE-BusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United Agent Group Inc. US-DE business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE-BusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE-BusinessEntityIdentifier</seealso>
    let UnitedAgentGroupInc_US_DE_BusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-DE-BusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-DE-HeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United Agent Group Inc. US-DE headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE-HeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-DE-HeadquartersAddress</seealso>
    let UnitedAgentGroupInc_US_DE_HeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-DE-HeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United Agent Group Inc. US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY</seealso>
    let UnitedAgentGroupInc_US_NY =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-NY-BusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United Agent Group Inc. US-NY business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY-BusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY-BusinessEntityIdentifier</seealso>
    let UnitedAgentGroupInc_US_NY_BusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-NY-BusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mktex:UnitedAgentGroupInc-US-NY-HeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"United Agent Group Inc. US-NY headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY-HeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/UnitedAgentGroupInc-US-NY-HeadquartersAddress</seealso>
    let UnitedAgentGroupInc_US_NY_HeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_mktex, "UnitedAgentGroupInc-US-NY-HeadquartersAddress") |> PrefixedName
