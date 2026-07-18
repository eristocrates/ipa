namespace https.spec.edmcouncil.org.fibo.ontology.IND.Indicators.Indicators.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ind_ind =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/DailyAverageMarketRate"></see>
    /// </summary>
    let DailyAverageMarketRate =
        Namespaced_IRI.parse _namespace_name "DailyAverageMarketRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketRate"></see>
    /// </summary>
    let MarketRate = Namespaced_IRI.parse _namespace_name "MarketRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDateTime"></see>
    /// </summary>
    let hasQuotationDateTime =
        Namespaced_IRI.parse _namespace_name "hasQuotationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/EndOfDayMarketRate"></see>
    /// </summary>
    let EndOfDayMarketRate =
        Namespaced_IRI.parse _namespace_name "EndOfDayMarketRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalPriceVolatility"></see>
    /// </summary>
    let HistoricalPriceVolatility =
        Namespaced_IRI.parse _namespace_name "HistoricalPriceVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalVolatility"></see>
    /// </summary>
    let HistoricalVolatility =
        Namespaced_IRI.parse _namespace_name "HistoricalVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceVolatility"></see>
    /// </summary>
    let PriceVolatility =
        Namespaced_IRI.parse _namespace_name "PriceVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/Volatility"></see>
    /// </summary>
    let Volatility = Namespaced_IRI.parse _namespace_name "Volatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedPriceVolatility"></see>
    /// </summary>
    let ImpliedPriceVolatility =
        Namespaced_IRI.parse _namespace_name "ImpliedPriceVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedVolatility"></see>
    /// </summary>
    let ImpliedVolatility =
        Namespaced_IRI.parse _namespace_name "ImpliedVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketSpread"></see>
    /// </summary>
    let MarketSpread =
        Namespaced_IRI.parse _namespace_name "MarketSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceStructure"></see>
    /// </summary>
    let PriceStructure =
        Namespaced_IRI.parse _namespace_name "PriceStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/QuotedPrice"></see>
    /// </summary>
    let QuotedPrice =
        Namespaced_IRI.parse _namespace_name "QuotedPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/TermStructure"></see>
    /// </summary>
    let TermStructure =
        Namespaced_IRI.parse _namespace_name "TermStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDate"></see>
    /// </summary>
    let hasQuotationDate =
        Namespaced_IRI.parse _namespace_name "hasQuotationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/isVolatilityOf"></see>
    /// </summary>
    let isVolatilityOf =
        Namespaced_IRI.parse _namespace_name "isVolatilityOf" |> NamespacedName
