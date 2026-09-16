#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spdx =
    let _prefixId = PrefixId.fromNamespaceLabel "https://spdx.org/rdf/3.1/terms/" "spdx"
    let _namespaceIri = _prefixId.prefix ""
