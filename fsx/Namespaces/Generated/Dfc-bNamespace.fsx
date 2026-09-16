#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``dfc-b`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_BusinessOntology.owl#" "dfc-b"
