#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dogont =
    let _prefixId = PrefixId.fromNamespaceLabel "http://elite.polito.it/ontologies/dogont" "dogont"

    let _'_period_'owl = _prefixId.prefix ".owl"
