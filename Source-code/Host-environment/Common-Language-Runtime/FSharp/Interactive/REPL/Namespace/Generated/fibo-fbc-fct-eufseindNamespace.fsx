#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-eufseind`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/" "fibo-fbc-fct-eufseind"

    let _namespaceIri = _prefixId.prefix ""
    let EuropeanBankingFederation = _prefixId.prefix "EuropeanBankingFederation"
    let EuropeanMoneyMarketsInstitute = _prefixId.prefix "EuropeanMoneyMarketsInstitute"
    let SwedishBankersAssociation = _prefixId.prefix "SwedishBankersAssociation"
