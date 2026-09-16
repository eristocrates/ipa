#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module alignment =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/alignmentType/" "alignment"

    let _namespaceIri = _prefixId.prefix ""
    let assesses = _prefixId.prefix "assesses"
    let complexityLevel = _prefixId.prefix "complexityLevel"
    let educationalLevel = _prefixId.prefix "educationalLevel"
    let educationalSubject = _prefixId.prefix "educationalSubject"
    let prerequisite = _prefixId.prefix "prerequisite"
    let readingLevel = _prefixId.prefix "readingLevel"
    let teaches = _prefixId.prefix "teaches"
