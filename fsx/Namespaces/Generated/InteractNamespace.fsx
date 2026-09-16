#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module interact =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/interactivityType/" "interact"

    let _namespaceIri = _prefixId.prefix ""
    let active = _prefixId.prefix "active"
    let expositive = _prefixId.prefix "expositive"
    let mixed = _prefixId.prefix "mixed"
