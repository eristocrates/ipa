#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-actus-mod`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/" "fibo-actus-mod"

    let _namespaceIri = _prefixId.prefix ""
    let ACTUSDomain = _prefixId.prefix "ACTUSDomain"
