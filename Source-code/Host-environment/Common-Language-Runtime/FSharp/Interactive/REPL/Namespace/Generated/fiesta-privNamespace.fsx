#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fiesta-priv`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/iot/ontology/fiesta-iot#" "fiesta-priv"

    let _namespaceIri = _prefixId.prefix ""
