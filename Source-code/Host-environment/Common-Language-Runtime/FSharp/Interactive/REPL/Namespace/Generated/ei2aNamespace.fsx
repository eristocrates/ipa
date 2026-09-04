#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ei2a =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://opendata.aragon.es/def/ei2a#" "ei2a"
