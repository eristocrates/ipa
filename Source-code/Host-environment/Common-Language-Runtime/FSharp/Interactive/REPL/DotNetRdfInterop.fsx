#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open VDS.RDF

let GlobalGreatGraph = new ThreadSafeGraph()
let ggg = GlobalGreatGraph
let namespaceMapper = ggg.NamespaceMap :?> NamespaceMapper
