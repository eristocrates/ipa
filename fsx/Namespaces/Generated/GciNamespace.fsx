#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gci =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/GCI/Foundation/GCI-Foundation.owl#" "gci"
