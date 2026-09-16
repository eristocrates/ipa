#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module loted =
    let _prefixId = PrefixId.fromNamespaceLabel "http://loted.eu/ontology#" "loted"
