#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module premis =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.loc.gov/premis/rdf/v1#" "premis"
