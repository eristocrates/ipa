#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cdm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/twc/ontology/cdm.owl#" "cdm"

    let _namespaceIri = _prefixId.prefix ""
