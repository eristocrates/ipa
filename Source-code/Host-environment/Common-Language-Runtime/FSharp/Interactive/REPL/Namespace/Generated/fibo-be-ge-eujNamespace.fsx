#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-euj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-euj"

    let _namespaceIri = _prefixId.prefix ""
    let CouncilOfEurope = _prefixId.prefix "CouncilOfEurope"
    let EuropeanCommission = _prefixId.prefix "EuropeanCommission"

    let EuropeanCommissionAsRegulatoryAgency =
        _prefixId.prefix "EuropeanCommissionAsRegulatoryAgency"

    let EuropeanEconomicArea = _prefixId.prefix "EuropeanEconomicArea"
    let EuropeanFreeTradeAssociation = _prefixId.prefix "EuropeanFreeTradeAssociation"
    let EuropeanUnionEntity = _prefixId.prefix "EuropeanUnionEntity"
    let EuropeanUnionJurisdiction = _prefixId.prefix "EuropeanUnionJurisdiction"
    let GovernmentOfTheEuropeanUnion = _prefixId.prefix "GovernmentOfTheEuropeanUnion"
