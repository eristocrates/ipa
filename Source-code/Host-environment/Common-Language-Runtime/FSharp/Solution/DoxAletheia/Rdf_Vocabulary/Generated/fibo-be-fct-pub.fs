namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.Publishers.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_fct_pub =
    let _namespace_iri = Namespace_Iri fibo_be_fct_pub |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-fct-pub:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Publishers Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_fct_pub, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:APIFirstMarketDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"API-first market data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/APIFirstMarketDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/APIFirstMarketDataProvider</seealso>
    let APIFirstMarketDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "APIFirstMarketDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:AlternativeDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alternative data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/AlternativeDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/AlternativeDataProvider</seealso>
    let AlternativeDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "AlternativeDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:CryptoDigitalAssetDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"crypto and digital-asset data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/CryptoDigitalAssetDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/CryptoDigitalAssetDataProvider</seealso>
    let CryptoDigitalAssetDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "CryptoDigitalAssetDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:DerivativesVolatilityDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivatives and volatility data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/DerivativesVolatilityDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/DerivativesVolatilityDataProvider</seealso>
    let DerivativesVolatilityDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "DerivativesVolatilityDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:ExchangeSourcedDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange-sourced data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ExchangeSourcedDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ExchangeSourcedDataProvider</seealso>
    let ExchangeSourcedDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "ExchangeSourcedDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:FixedIncomeSpecialistProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed income specialist provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/FixedIncomeSpecialistProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/FixedIncomeSpecialistProvider</seealso>
    let FixedIncomeSpecialistProvider =
        Prefixed_Name(fibo_be_fct_pub, "FixedIncomeSpecialistProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:InstitutionalMarketDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institutional market data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/InstitutionalMarketDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/InstitutionalMarketDataProvider</seealso>
    let InstitutionalMarketDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "InstitutionalMarketDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/MarketDataProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/MarketDataProvider</seealso>
    let MarketDataProvider =
        Prefixed_Name(fibo_be_fct_pub, "MarketDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publication">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publication</seealso>
    let Publication = Prefixed_Name(fibo_be_fct_pub, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publisher">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publisher</seealso>
    let Publisher = Prefixed_Name(fibo_be_fct_pub, "Publisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:ReferenceDataSpecialistProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reference data specialist provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ReferenceDataSpecialistProvider">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ReferenceDataSpecialistProvider</seealso>
    let ReferenceDataSpecialistProvider =
        Prefixed_Name(fibo_be_fct_pub, "ReferenceDataSpecialistProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-pub:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/hasPublisher">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(fibo_be_fct_pub, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-fct-pub:isPublishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is published by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/isPublishedBy">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/isPublishedBy</seealso>
    let isPublishedBy = Prefixed_Name(fibo_be_fct_pub, "isPublishedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-fct-pub:publishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"publishes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/publishes">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/publishes</seealso>
    let publishes = Prefixed_Name(fibo_be_fct_pub, "publishes") |> PrefixedName
