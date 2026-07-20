namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MarketDataProviders.slash

open DoxAletheia

module fibo_ind_ir_mdp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersInc-US-DE"></see>
    /// </summary>
    let ``BGCPartnersInc-US-DE`` = _prefix "BGCPartnersInc-US-DE"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncHeadquartersAddress"></see>
    /// </summary>
    let BGCPartnersIncHeadquartersAddress = _prefix "BGCPartnersIncHeadquartersAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncDateEstablished"></see>
    /// </summary>
    let BGCPartnersIncDateEstablished = _prefix "BGCPartnersIncDateEstablished"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncBusinessEntityIdentifier"></see>
    /// </summary>
    let BGCPartnersIncBusinessEntityIdentifier =
        _prefix "BGCPartnersIncBusinessEntityIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/BGCPartnersIncLegalEntityIdentifierRegistryEntry"></see>
    /// </summary>
    let BGCPartnersIncLegalEntityIdentifierRegistryEntry =
        _prefix "BGCPartnersIncLegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/EuropeanMoneyMarketsInstituteBenchmarkPublisher"></see>
    /// </summary>
    let EuropeanMoneyMarketsInstituteBenchmarkPublisher =
        _prefix "EuropeanMoneyMarketsInstituteBenchmarkPublisher"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FederalReserveBoardH.15RateResetTimeOfDay"></see>
    /// </summary>
    let ``FederalReserveBoardH.15RateResetTimeOfDay`` =
        _prefix "FederalReserveBoardH.15RateResetTimeOfDay"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/FenicsMarketData"></see>
    /// </summary>
    let FenicsMarketData = _prefix "FenicsMarketData"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ICEBenchmarkPublisher"></see>
    /// </summary>
    let ICEBenchmarkPublisher = _prefix "ICEBenchmarkPublisher"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/LSEGFinancialSolutionsAsMarketDataProvider"></see>
    /// </summary>
    let LSEGFinancialSolutionsAsMarketDataProvider =
        _prefix "LSEGFinancialSolutionsAsMarketDataProvider"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceBanks"></see>
    /// </summary>
    let ReferenceBanks = _prefix "ReferenceBanks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/ReferenceDealers"></see>
    /// </summary>
    let ReferenceDealers = _prefix "ReferenceDealers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/SwapMarker"></see>
    /// </summary>
    let SwapMarker = _prefix "SwapMarker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/Tradition"></see>
    /// </summary>
    let Tradition = _prefix "Tradition"
