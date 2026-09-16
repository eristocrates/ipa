#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module part =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vocab/participation/schema#" "part"

    let _namespaceIri = _prefixId.prefix ""
