#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-exmp-le-mktex`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/" "fibo-exmp-le-mktex"

    let _namespaceIri = _prefixId.prefix ""

    let CBOEGlobalMarketsBusinessEntityIdentifier =
        _prefixId.prefix "CBOEGlobalMarketsBusinessEntityIdentifier"

    let CBOEGlobalMarketsDateEstablished =
        _prefixId.prefix "CBOEGlobalMarketsDateEstablished"

    let CBOEGlobalMarketsHeadquartersAddress =
        _prefixId.prefix "CBOEGlobalMarketsHeadquartersAddress"

    let CBOEGlobalMarketsInc_US_DE = _prefixId.prefix "CBOEGlobalMarketsInc-US-DE"
    let ChicagoBoardOptionsExchange = _prefixId.prefix "ChicagoBoardOptionsExchange"

    let ChicagoBoardOptionsExchangeAsServiceProvider =
        _prefixId.prefix "ChicagoBoardOptionsExchangeAsServiceProvider"

    let ChicagoBoardOptionsExchangeDateEstablished =
        _prefixId.prefix "ChicagoBoardOptionsExchangeDateEstablished"

    let IntercontinentalExchangeHoldings =
        _prefixId.prefix "IntercontinentalExchangeHoldings"

    let NYSEAmericanOptions = _prefixId.prefix "NYSEAmericanOptions"

    let NYSEAmericanOptionsAsServiceProvider =
        _prefixId.prefix "NYSEAmericanOptionsAsServiceProvider"

    let NYSEAmericanOptionsBusinessEntityIdentifier =
        _prefixId.prefix "NYSEAmericanOptionsBusinessEntityIdentifier"

    let NYSEAmericanOptionsDateEstablished =
        _prefixId.prefix "NYSEAmericanOptionsDateEstablished"

    let NYSEAmericanOptionsLLC_US_DE = _prefixId.prefix "NYSEAmericanOptionsLLC-US-DE"
    let NYSEArca = _prefixId.prefix "NYSEArca"
    let NYSEArcaAsServiceProvider = _prefixId.prefix "NYSEArcaAsServiceProvider"

    let NYSEArcaBusinessEntityIdentifier =
        _prefixId.prefix "NYSEArcaBusinessEntityIdentifier"

    let NYSEArcaDateEstablished = _prefixId.prefix "NYSEArcaDateEstablished"
    let NYSEArcaHoldings = _prefixId.prefix "NYSEArcaHoldings"

    let NYSEArcaHoldingsBusinessEntityIdentifier =
        _prefixId.prefix "NYSEArcaHoldingsBusinessEntityIdentifier"

    let NYSEArcaHoldingsInc_US_DE = _prefixId.prefix "NYSEArcaHoldingsInc-US-DE"

    let NYSEArcaHoldingsIncDateEstablished =
        _prefixId.prefix "NYSEArcaHoldingsIncDateEstablished"

    let NYSEArcaInc_US_DE = _prefixId.prefix "NYSEArcaInc-US-DE"
    let NYSEArcaIncDateEstablished = _prefixId.prefix "NYSEArcaIncDateEstablished"

    let NYSEArcaIncHeadquartersAddress =
        _prefixId.prefix "NYSEArcaIncHeadquartersAddress"

    let NYSEDark = _prefixId.prefix "NYSEDark"
    let NYSEGroup = _prefixId.prefix "NYSEGroup"

    let NYSEGroupBusinessEntityIdentifier =
        _prefixId.prefix "NYSEGroupBusinessEntityIdentifier"

    let NYSEGroupDateEstablished = _prefixId.prefix "NYSEGroupDateEstablished"
    let NYSEGroupInc_US_DE = _prefixId.prefix "NYSEGroupInc-US-DE"
    let NYSEHoldings = _prefixId.prefix "NYSEHoldings"

    let NYSEHoldingsBusinessEntityIdentifier =
        _prefixId.prefix "NYSEHoldingsBusinessEntityIdentifier"

    let NYSEHoldingsDateEstablished = _prefixId.prefix "NYSEHoldingsDateEstablished"
    let NYSEHoldingsLLC_US_DE = _prefixId.prefix "NYSEHoldingsLLC-US-DE"
    let NewYorkStockExchange = _prefixId.prefix "NewYorkStockExchange"

    let NewYorkStockExchangeAsServiceProvider =
        _prefixId.prefix "NewYorkStockExchangeAsServiceProvider"

    let NewYorkStockExchangeDateEstablished =
        _prefixId.prefix "NewYorkStockExchangeDateEstablished"

    let NewYorkStockExchangeHeadquartersAddress =
        _prefixId.prefix "NewYorkStockExchangeHeadquartersAddress"

    let NewYorkStockExchangeLLC_US_NY = _prefixId.prefix "NewYorkStockExchangeLLC-US-NY"

    let NewYorkStockExchangeLLCBusinessEntityIdentifier =
        _prefixId.prefix "NewYorkStockExchangeLLCBusinessEntityIdentifier"

    let NewYorkStockExchangeLLCDateEstablished =
        _prefixId.prefix "NewYorkStockExchangeLLCDateEstablished"

    let UnitedAgentGroup_Delaware = _prefixId.prefix "UnitedAgentGroup-Delaware"
    let UnitedAgentGroup_NewYork = _prefixId.prefix "UnitedAgentGroup-NewYork"
    let UnitedAgentGroupInc_US_DE = _prefixId.prefix "UnitedAgentGroupInc-US-DE"

    let UnitedAgentGroupInc_US_DE_BusinessEntityIdentifier =
        _prefixId.prefix "UnitedAgentGroupInc-US-DE-BusinessEntityIdentifier"

    let UnitedAgentGroupInc_US_DE_HeadquartersAddress =
        _prefixId.prefix "UnitedAgentGroupInc-US-DE-HeadquartersAddress"

    let UnitedAgentGroupInc_US_NY = _prefixId.prefix "UnitedAgentGroupInc-US-NY"

    let UnitedAgentGroupInc_US_NY_BusinessEntityIdentifier =
        _prefixId.prefix "UnitedAgentGroupInc-US-NY-BusinessEntityIdentifier"

    let UnitedAgentGroupInc_US_NY_HeadquartersAddress =
        _prefixId.prefix "UnitedAgentGroupInc-US-NY-HeadquartersAddress"
