#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module edUse =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/educationalUse/" "edUse"

    let _namespaceIri = _prefixId.prefix ""
    let assessment = _prefixId.prefix "assessment"
    let instruction = _prefixId.prefix "instruction"
    let professionalSupport = _prefixId.prefix "professionalSupport"
