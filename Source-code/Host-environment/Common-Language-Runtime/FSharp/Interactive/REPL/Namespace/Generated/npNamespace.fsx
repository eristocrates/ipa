#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module np =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.nanopub.org/nschema#" "np"
    let Assertion = _prefixId.prefix "Assertion"
    let Nanopublication = _prefixId.prefix "Nanopublication"
    let Provenance = _prefixId.prefix "Provenance"
    let PublicationInfo = _prefixId.prefix "PublicationInfo"
    let hasAssertion = _prefixId.prefix "hasAssertion"
    let hasProvenance = _prefixId.prefix "hasProvenance"
    let hasPublicationInfo = _prefixId.prefix "hasPublicationInfo"
