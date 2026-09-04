#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module voidwh =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl" "voidwh"

    let _namespaceIri = _prefixId.prefix ""
