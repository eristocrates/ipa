#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hw =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl" "hw"

    let _namespaceIri = _prefixId.prefix ""
