#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module edupro =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/semed/eduprogression#" "edupro"

    let _namespaceIri = _prefixId.prefix ""
