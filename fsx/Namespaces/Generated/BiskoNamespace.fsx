#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bisko =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#" "bisko"

    let _namespaceIri = _prefixId.prefix ""
    let uniProtTaxonomy = _prefixId.prefix "uniProtTaxonomy"
    let uniProtTaxonomyDT = _prefixId.prefix "uniProtTaxonomyDT"
