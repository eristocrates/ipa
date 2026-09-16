#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module decision =
    let _prefixId = PrefixId.fromNamespaceLabel "https://decision-ontology.googlecode.com/svn/trunk/decision.owl#" "decision"
