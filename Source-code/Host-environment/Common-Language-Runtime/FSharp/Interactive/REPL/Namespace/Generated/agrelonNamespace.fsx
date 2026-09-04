#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module agrelon =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/agrelon#" "agrelon"
