#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module part =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/participation/schema#" "part"

    let _namespaceIri = _prefixId.prefix ""
