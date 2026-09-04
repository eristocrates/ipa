#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``dfc-p`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_ProductGlossary.owl#" "dfc-p"
