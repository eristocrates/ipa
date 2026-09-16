#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module voidwh =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl" "voidwh"

    let _namespaceIri = _prefixId.prefix ""
