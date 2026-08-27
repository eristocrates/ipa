namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MarketDataProviders.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ir_mdp =
    let _namespace_iri = Namespace_Iri fibo_ind_ir_mdp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ir-mdp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Market Data Providers Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ir_mdp, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:EuropeanMoneyMarketsInstituteBenchmarkPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    ///
    /// labels<para>"European Money Markets Institute (EMMI) benchmark publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/EuropeanMoneyMarketsInstituteBenchmarkPublisher">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/EuropeanMoneyMarketsInstituteBenchmarkPublisher</seealso>
    let EuropeanMoneyMarketsInstituteBenchmarkPublisher =
        Prefixed_Name(fibo_ind_ir_mdp, "EuropeanMoneyMarketsInstituteBenchmarkPublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:FederalReserveBoardH.15RateResetTimeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:RateResetTimeOfDay</para>
    ///
    /// labels<para>"Federal Reserve Board H.15 rate reset time of day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FederalReserveBoardH.15RateResetTimeOfDay">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FederalReserveBoardH.15RateResetTimeOfDay</seealso>
    let ``FederalReserveBoardH.15RateResetTimeOfDay`` =
        Prefixed_Name(fibo_ind_ir_mdp, "FederalReserveBoardH.15RateResetTimeOfDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:FenicsMarketData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///
    /// labels<para>"Fenics Market Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FenicsMarketData">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FenicsMarketData</seealso>
    let FenicsMarketData =
        Prefixed_Name(fibo_ind_ir_mdp, "FenicsMarketData") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:ICEBenchmarkPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ICE benchmark publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ICEBenchmarkPublisher">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ICEBenchmarkPublisher</seealso>
    let ICEBenchmarkPublisher =
        Prefixed_Name(fibo_ind_ir_mdp, "ICEBenchmarkPublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:LSEGFinancialSolutionsAsMarketDataProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"LSEG Financial Solutions as market data provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/LSEGFinancialSolutionsAsMarketDataProvider">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/LSEGFinancialSolutionsAsMarketDataProvider</seealso>
    let LSEGFinancialSolutionsAsMarketDataProvider =
        Prefixed_Name(fibo_ind_ir_mdp, "LSEGFinancialSolutionsAsMarketDataProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:ReferenceBanks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Collections:Collection</para>
    ///
    /// labels<para>"reference banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceBanks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceBanks</seealso>
    let ReferenceBanks =
        Prefixed_Name(fibo_ind_ir_mdp, "ReferenceBanks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:ReferenceDealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>Collections:Collection</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"reference dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceDealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceDealers</seealso>
    let ReferenceDealers =
        Prefixed_Name(fibo_ind_ir_mdp, "ReferenceDealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mdp:SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Swap Marker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/SwapMarker</seealso>
    let SwapMarker = Prefixed_Name(fibo_ind_ir_mdp, "SwapMarker") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-mdp:Tradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:MarketDataProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"Tradition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/Tradition">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/Tradition</seealso>
    let Tradition = Prefixed_Name(fibo_ind_ir_mdp, "Tradition") |> PrefixedName
