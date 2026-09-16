#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dbowl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/dbowl/relational-to-ontology-mapping-primitive.owl#" "dbowl"
