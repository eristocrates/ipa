#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module g50k =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/50kGazetteer/" "g50k"

    let _namespaceIri = _prefixId.prefix ""
