namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.Markets.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_mkt =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_mkt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Markets Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_mkt, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ActiveMICStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketIdentifierCodeStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"active MIC status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ActiveMICStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ActiveMICStatus</seealso>
    let ActiveMICStatus =
        Prefixed_Name(fibo_fbc_fct_mkt, "ActiveMICStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:AlternativeTradingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alternative trading system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AlternativeTradingSystem">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AlternativeTradingSystem</seealso>
    let AlternativeTradingSystem =
        Prefixed_Name(fibo_fbc_fct_mkt, "AlternativeTradingSystem") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ApprovedPublicationArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"approved publication arrangement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedPublicationArrangement">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedPublicationArrangement</seealso>
    let ApprovedPublicationArrangement =
        Prefixed_Name(fibo_fbc_fct_mkt, "ApprovedPublicationArrangement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ApprovedReportingMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"approved reporting mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedReportingMechanism">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedReportingMechanism</seealso>
    let ApprovedReportingMechanism =
        Prefixed_Name(fibo_fbc_fct_mkt, "ApprovedReportingMechanism") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:AuctionMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auction market"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AuctionMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AuctionMarket</seealso>
    let AuctionMarket = Prefixed_Name(fibo_fbc_fct_mkt, "AuctionMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ConsolidatedTapeProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consolidated tape provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ConsolidatedTapeProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ConsolidatedTapeProvider</seealso>
    let ConsolidatedTapeProvider =
        Prefixed_Name(fibo_fbc_fct_mkt, "ConsolidatedTapeProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:CryptoAssetServicesProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"crypto asset services provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/CryptoAssetServicesProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/CryptoAssetServicesProvider</seealso>
    let CryptoAssetServicesProvider =
        Prefixed_Name(fibo_fbc_fct_mkt, "CryptoAssetServicesProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:DarkPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dark pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DarkPool">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DarkPool</seealso>
    let DarkPool = Prefixed_Name(fibo_fbc_fct_mkt, "DarkPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:DataReportingServicesProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"data reporting services provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DataReportingServicesProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DataReportingServicesProvider</seealso>
    let DataReportingServicesProvider =
        Prefixed_Name(fibo_fbc_fct_mkt, "DataReportingServicesProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:DesignatedContractMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"designated contract market"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DesignatedContractMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DesignatedContractMarket</seealso>
    let DesignatedContractMarket =
        Prefixed_Name(fibo_fbc_fct_mkt, "DesignatedContractMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ElectronicCommunicationNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electronic communication network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ElectronicCommunicationNetwork">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ElectronicCommunicationNetwork</seealso>
    let ElectronicCommunicationNetwork =
        Prefixed_Name(fibo_fbc_fct_mkt, "ElectronicCommunicationNetwork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:Exchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/Exchange">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/Exchange</seealso>
    let Exchange = Prefixed_Name(fibo_fbc_fct_mkt, "Exchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ExchangeParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExchangeParticipant">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExchangeParticipant</seealso>
    let ExchangeParticipant =
        Prefixed_Name(fibo_fbc_fct_mkt, "ExchangeParticipant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ExpiredMICStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketIdentifierCodeStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"expired MIC status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExpiredMICStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExpiredMICStatus</seealso>
    let ExpiredMICStatus =
        Prefixed_Name(fibo_fbc_fct_mkt, "ExpiredMICStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:ISO10383-ClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Classifiers:ClassificationScheme</para>
    ///
    /// labels<para>"ISO 10383 classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ISO10383-ClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ISO10383-ClassificationScheme</seealso>
    let ISO10383_ClassificationScheme =
        Prefixed_Name(fibo_fbc_fct_mkt, "ISO10383-ClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:InterdealerQuotationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interdealer quotation system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/InterdealerQuotationSystem">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/InterdealerQuotationSystem</seealso>
    let InterdealerQuotationSystem =
        Prefixed_Name(fibo_fbc_fct_mkt, "InterdealerQuotationSystem") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market category classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier</seealso>
    let MarketCategoryClassifier =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-APPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///
    /// labels<para>"market category classifier - APPA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-APPA">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-APPA</seealso>
    let MarketCategoryClassifier_APPA =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-APPA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-ARMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - ARMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ARMS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ARMS</seealso>
    let MarketCategoryClassifier_ARMS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-ARMS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-ATSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///
    /// labels<para>"market category classifier - ATSS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ATSS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ATSS</seealso>
    let MarketCategoryClassifier_ATSS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-ATSS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-CASP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - CASP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CASP">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CASP</seealso>
    let MarketCategoryClassifier_CASP =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-CASP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-CTPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - CTPS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CTPS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CTPS</seealso>
    let MarketCategoryClassifier_CTPS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-CTPS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-DCMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - DCMS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-DCMS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-DCMS</seealso>
    let MarketCategoryClassifier_DCMS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-DCMS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-IDQS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///
    /// labels<para>"market category classifier - IDQS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-IDQS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-IDQS</seealso>
    let MarketCategoryClassifier_IDQS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-IDQS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-MLTF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - MLTF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-MLTF">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-MLTF</seealso>
    let MarketCategoryClassifier_MLTF =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-MLTF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-NSPD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - NSPD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-NSPD">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-NSPD</seealso>
    let MarketCategoryClassifier_NSPD =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-NSPD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-OTFS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///
    /// labels<para>"market category classifier - OTFS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTFS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTFS</seealso>
    let MarketCategoryClassifier_OTFS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-OTFS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-OTHR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - OTHR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTHR">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTHR</seealso>
    let MarketCategoryClassifier_OTHR =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-OTHR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-RMKT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - RMKT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMKT">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMKT</seealso>
    let MarketCategoryClassifier_RMKT =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-RMKT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-RMOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///
    /// labels<para>"market category classifier - RMOS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMOS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMOS</seealso>
    let MarketCategoryClassifier_RMOS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-RMOS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-SEFS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - SEFS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SEFS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SEFS</seealso>
    let MarketCategoryClassifier_SEFS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-SEFS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-SINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - SINT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SINT">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SINT</seealso>
    let MarketCategoryClassifier_SINT =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-SINT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier-TRFS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketCategoryClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market category classifier - TRFS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-TRFS">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-TRFS</seealso>
    let MarketCategoryClassifier_TRFS =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketCategoryClassifier-TRFS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifier</seealso>
    let MarketIdentifier =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketIdentifierCodeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market indicator code status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifierCodeStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifierCodeStatus</seealso>
    let MarketIdentifierCodeStatus =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketIdentifierCodeStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketLevelClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market level classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier</seealso>
    let MarketLevelClassifier =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketLevelClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketLevelClassifier-OPRT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketLevelClassifier</para>
    ///
    /// labels<para>"market-level classifier - OPRT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-OPRT">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-OPRT</seealso>
    let MarketLevelClassifier_OPRT =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketLevelClassifier-OPRT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketLevelClassifier-SGMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-mkt:MarketLevelClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"market-level classifier - SGMT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-SGMT">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-SGMT</seealso>
    let MarketLevelClassifier_SGMT =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketLevelClassifier-SGMT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketSegmentLevelMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market segment-level market"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarket</seealso>
    let MarketSegmentLevelMarket =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketSegmentLevelMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MarketSegmentLevelMarketIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market segment-level market identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarketIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarketIdentifier</seealso>
    let MarketSegmentLevelMarketIdentifier =
        Prefixed_Name(fibo_fbc_fct_mkt, "MarketSegmentLevelMarketIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:MultilateralTradingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multilateral trading facility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MultilateralTradingFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MultilateralTradingFacility</seealso>
    let MultilateralTradingFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "MultilateralTradingFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:OffMarketFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"off-market facility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OffMarketFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OffMarketFacility</seealso>
    let OffMarketFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "OffMarketFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:OperatingLevelMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"operating-level market"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarket</seealso>
    let OperatingLevelMarket =
        Prefixed_Name(fibo_fbc_fct_mkt, "OperatingLevelMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:OperatingLevelMarketIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"operating-level market identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarketIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarketIdentifier</seealso>
    let OperatingLevelMarketIdentifier =
        Prefixed_Name(fibo_fbc_fct_mkt, "OperatingLevelMarketIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:OrganizedTradingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organized trading facility"</para><para>"organised trading facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OrganizedTradingFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OrganizedTradingFacility</seealso>
    let OrganizedTradingFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "OrganizedTradingFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:QuoteDrivenMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quote-driven market"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/QuoteDrivenMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/QuoteDrivenMarket</seealso>
    let QuoteDrivenMarket =
        Prefixed_Name(fibo_fbc_fct_mkt, "QuoteDrivenMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:RecognizedMarketOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"recognized market operator"</para><para>"recognised market operator"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RecognizedMarketOperator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RecognizedMarketOperator</seealso>
    let RecognizedMarketOperator =
        Prefixed_Name(fibo_fbc_fct_mkt, "RecognizedMarketOperator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:RegisteredMultilateralTradingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered multilateral trading facility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegisteredMultilateralTradingFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegisteredMultilateralTradingFacility</seealso>
    let RegisteredMultilateralTradingFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "RegisteredMultilateralTradingFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:RegulatedExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulated exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegulatedExchange">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegulatedExchange</seealso>
    let RegulatedExchange =
        Prefixed_Name(fibo_fbc_fct_mkt, "RegulatedExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:SwapExecutionFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap execution facility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SwapExecutionFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SwapExecutionFacility</seealso>
    let SwapExecutionFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "SwapExecutionFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:SystematicInternaliser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"systematic internalizer"</para><para>"systematic internaliser"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SystematicInternaliser">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SystematicInternaliser</seealso>
    let SystematicInternaliser =
        Prefixed_Name(fibo_fbc_fct_mkt, "SystematicInternaliser") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:TradeReportingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trade reporting facility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/TradeReportingFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/TradeReportingFacility</seealso>
    let TradeReportingFacility =
        Prefixed_Name(fibo_fbc_fct_mkt, "TradeReportingFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:UpdatedMICStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-mkt:MarketIdentifierCodeStatus</para>
    ///
    /// labels<para>"updated MIC status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/UpdatedMICStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/UpdatedMICStatus</seealso>
    let UpdatedMICStatus =
        Prefixed_Name(fibo_fbc_fct_mkt, "UpdatedMICStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:hasFacilityAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has facility acronym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasFacilityAcronym">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasFacilityAcronym</seealso>
    let hasFacilityAcronym =
        Prefixed_Name(fibo_fbc_fct_mkt, "hasFacilityAcronym") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:hasMarketIdentifierCodeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has market identifier code status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasMarketIdentifierCodeStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasMarketIdentifierCodeStatus</seealso>
    let hasMarketIdentifierCodeStatus =
        Prefixed_Name(fibo_fbc_fct_mkt, "hasMarketIdentifierCodeStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:operatesInCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"operates in country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInCountry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInCountry</seealso>
    let operatesInCountry =
        Prefixed_Name(fibo_fbc_fct_mkt, "operatesInCountry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mkt:operatesInMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"operates in municipality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInMunicipality">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInMunicipality</seealso>
    let operatesInMunicipality =
        Prefixed_Name(fibo_fbc_fct_mkt, "operatesInMunicipality") |> PrefixedName
