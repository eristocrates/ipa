#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ir-mod`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/" "fibo-ind-ir-mod"

    let _namespaceIri = _prefixId.prefix ""
    let InterestRatesModule = _prefixId.prefix "InterestRatesModule"
