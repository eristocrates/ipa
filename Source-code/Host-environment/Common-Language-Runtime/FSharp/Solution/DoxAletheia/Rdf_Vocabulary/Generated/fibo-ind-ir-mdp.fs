namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MarketDataProviders.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ir_mdp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersInc-US-DE"></see>
    /// </summary>
    let ``BGCPartnersInc-US-DE`` =
        Namespaced_IRI.parse _namespace_name "BGCPartnersInc-US-DE" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncHeadquartersAddress"></see>
    /// </summary>
    let BGCPartnersIncHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "BGCPartnersIncHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncDateEstablished"></see>
    /// </summary>
    let BGCPartnersIncDateEstablished =
        Namespaced_IRI.parse _namespace_name "BGCPartnersIncDateEstablished" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncBusinessEntityIdentifier"></see>
    /// </summary>
    let BGCPartnersIncBusinessEntityIdentifier =
        Namespaced_IRI.parse _namespace_name "BGCPartnersIncBusinessEntityIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncLegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let BGCPartnersIncLegalEntityIdentifierRegistryEntry =
        Namespaced_IRI.parse _namespace_name "BGCPartnersIncLegalEntityIdentifierRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/EuropeanMoneyMarketsInstituteBenchmarkPublisher"></see>
    /// </summary>
    let EuropeanMoneyMarketsInstituteBenchmarkPublisher =
        Namespaced_IRI.parse _namespace_name "EuropeanMoneyMarketsInstituteBenchmarkPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FederalReserveBoardH.15RateResetTimeOfDay"></see>
    /// </summary>
    let ``FederalReserveBoardH.15RateResetTimeOfDay`` =
        Namespaced_IRI.parse _namespace_name "FederalReserveBoardH.15RateResetTimeOfDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FenicsMarketData"></see>
    /// </summary>
    let FenicsMarketData =
        Namespaced_IRI.parse _namespace_name "FenicsMarketData" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ICEBenchmarkPublisher"></see>
    /// </summary>
    let ICEBenchmarkPublisher =
        Namespaced_IRI.parse _namespace_name "ICEBenchmarkPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/LSEGFinancialSolutionsAsMarketDataProvider"></see>
    /// </summary>
    let LSEGFinancialSolutionsAsMarketDataProvider =
        Namespaced_IRI.parse _namespace_name "LSEGFinancialSolutionsAsMarketDataProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceBanks"></see>
    /// </summary>
    let ReferenceBanks =
        Namespaced_IRI.parse _namespace_name "ReferenceBanks" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceDealers"></see>
    /// </summary>
    let ReferenceDealers =
        Namespaced_IRI.parse _namespace_name "ReferenceDealers" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/SwapMarker"></see>
    /// </summary>
    let SwapMarker = Namespaced_IRI.parse _namespace_name "SwapMarker" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/Tradition"></see>
    /// </summary>
    let Tradition = Namespaced_IRI.parse _namespace_name "Tradition" |> NamespacedName
