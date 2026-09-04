#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-mxj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-mxj"

    let _namespaceIri = _prefixId.prefix ""
    let FederalGovernmentOfMexico = _prefixId.prefix "FederalGovernmentOfMexico"
    let MexicanEntity = _prefixId.prefix "MexicanEntity"
    let MexicanJurisdiction = _prefixId.prefix "MexicanJurisdiction"
