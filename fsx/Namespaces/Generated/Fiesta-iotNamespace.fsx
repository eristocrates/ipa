#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fiesta-iot`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/iot/ontology/fiesta-iot#" "fiesta-iot"

    let _namespaceIri = _prefixId.prefix ""
