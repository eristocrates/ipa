#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-acc-mod`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/" "fibo-fnd-acc-mod"

    let _namespaceIri = _prefixId.prefix ""
    let AccountingModule = _prefixId.prefix "AccountingModule"
