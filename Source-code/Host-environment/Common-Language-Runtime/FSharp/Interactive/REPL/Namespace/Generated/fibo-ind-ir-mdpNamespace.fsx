#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ir-mdp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/" "fibo-ind-ir-mdp"

    let _namespaceIri = _prefixId.prefix ""

    let EuropeanMoneyMarketsInstituteBenchmarkPublisher =
        _prefixId.prefix "EuropeanMoneyMarketsInstituteBenchmarkPublisher"

    let ``FederalReserveBoardH.15RateResetTimeOfDay`` =
        _prefixId.prefix "FederalReserveBoardH.15RateResetTimeOfDay"

    let FenicsMarketData = _prefixId.prefix "FenicsMarketData"
    let ICEBenchmarkPublisher = _prefixId.prefix "ICEBenchmarkPublisher"

    let LSEGFinancialSolutionsAsMarketDataProvider =
        _prefixId.prefix "LSEGFinancialSolutionsAsMarketDataProvider"

    let ReferenceBanks = _prefixId.prefix "ReferenceBanks"
    let ReferenceDealers = _prefixId.prefix "ReferenceDealers"
    let SwapMarker = _prefixId.prefix "SwapMarker"
    let Tradition = _prefixId.prefix "Tradition"
