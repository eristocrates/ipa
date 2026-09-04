#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-swpind`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/" "fibo-der-drc-swpind"

    let _namespaceIri = _prefixId.prefix ""
    let BloombergSDR = _prefixId.prefix "BloombergSDR"
    let ChicagoMercantileExchange = _prefixId.prefix "ChicagoMercantileExchange"
    let DTCCDataRepository = _prefixId.prefix "DTCCDataRepository"
    let ICETradeVault = _prefixId.prefix "ICETradeVault"
