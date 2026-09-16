#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cem =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/CEMontology/" "cem"
    let _namespaceIri = _prefixId.prefix ""
