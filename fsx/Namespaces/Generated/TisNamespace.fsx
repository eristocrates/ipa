#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tis =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl" "tis"

    let _namespaceIri = _prefixId.prefix ""
