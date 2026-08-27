namespace https.spec.edmcouncil.org.fibo.ontology.IND.Indicators.Indicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ind_ind =
    let _namespace_iri = Namespace_Iri fibo_ind_ind_ind |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ind-ind:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Indicators Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ind_ind, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:DailyAverageMarketRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"daily average market rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/DailyAverageMarketRate">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/DailyAverageMarketRate</seealso>
    let DailyAverageMarketRate =
        Prefixed_Name(fibo_ind_ind_ind, "DailyAverageMarketRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:EndOfDayMarketRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"end-of-day market rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/EndOfDayMarketRate">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/EndOfDayMarketRate</seealso>
    let EndOfDayMarketRate =
        Prefixed_Name(fibo_ind_ind_ind, "EndOfDayMarketRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:HistoricalPriceVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"historical price volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalPriceVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalPriceVolatility</seealso>
    let HistoricalPriceVolatility =
        Prefixed_Name(fibo_ind_ind_ind, "HistoricalPriceVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:HistoricalVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"historical volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalVolatility</seealso>
    let HistoricalVolatility =
        Prefixed_Name(fibo_ind_ind_ind, "HistoricalVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:ImpliedPriceVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"implied price volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedPriceVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedPriceVolatility</seealso>
    let ImpliedPriceVolatility =
        Prefixed_Name(fibo_ind_ind_ind, "ImpliedPriceVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:ImpliedVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"implied volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedVolatility</seealso>
    let ImpliedVolatility =
        Prefixed_Name(fibo_ind_ind_ind, "ImpliedVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:MarketRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketRate">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketRate</seealso>
    let MarketRate = Prefixed_Name(fibo_ind_ind_ind, "MarketRate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ind-ind:MarketSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market spread"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketSpread">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketSpread</seealso>
    let MarketSpread = Prefixed_Name(fibo_ind_ind_ind, "MarketSpread") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:PriceStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceStructure">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceStructure</seealso>
    let PriceStructure =
        Prefixed_Name(fibo_ind_ind_ind, "PriceStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:PriceVolatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceVolatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceVolatility</seealso>
    let PriceVolatility =
        Prefixed_Name(fibo_ind_ind_ind, "PriceVolatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:QuotedPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quoted price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/QuotedPrice">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/QuotedPrice</seealso>
    let QuotedPrice = Prefixed_Name(fibo_ind_ind_ind, "QuotedPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ind-ind:TermStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"term structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/TermStructure">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/TermStructure</seealso>
    let TermStructure = Prefixed_Name(fibo_ind_ind_ind, "TermStructure") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ind-ind:Volatility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volatility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/Volatility">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/Volatility</seealso>
    let Volatility = Prefixed_Name(fibo_ind_ind_ind, "Volatility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:hasQuotationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quotation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDate">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDate</seealso>
    let hasQuotationDate =
        Prefixed_Name(fibo_ind_ind_ind, "hasQuotationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:hasQuotationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has quotation date and time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDateTime">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDateTime</seealso>
    let hasQuotationDateTime =
        Prefixed_Name(fibo_ind_ind_ind, "hasQuotationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-ind:isVolatilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is volatility of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/isVolatilityOf">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/isVolatilityOf</seealso>
    let isVolatilityOf =
        Prefixed_Name(fibo_ind_ind_ind, "isVolatilityOf") |> PrefixedName
