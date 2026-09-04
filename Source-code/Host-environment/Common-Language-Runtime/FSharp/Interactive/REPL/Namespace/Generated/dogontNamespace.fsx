#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dogont =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://elite.polito.it/ontologies/dogont" "dogont"

    let ``_.owl`` = _prefixId.prefix ".owl"
