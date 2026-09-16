#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddw =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododw#" "tddw"
