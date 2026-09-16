#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cro =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rhizomik.net/ontologies/copyrightonto.owl#" "cro"
