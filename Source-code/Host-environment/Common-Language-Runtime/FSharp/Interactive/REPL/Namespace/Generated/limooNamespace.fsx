#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module limoo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/LiMo/0.1#" "limoo"
    let attributionCondition = _prefixId.prefix "attributionCondition"
    let compatibleWith = _prefixId.prefix "compatibleWith"
    let createCondition = _prefixId.prefix "createCondition"
    let noCopyrightCondition = _prefixId.prefix "noCopyrightCondition"
    let nonCommercialCondition = _prefixId.prefix "nonCommercialCondition"
    let nonDerivativeWorksCondition = _prefixId.prefix "nonDerivativeWorksCondition"
    let remixCondition = _prefixId.prefix "remixCondition"
    let shareAlikeCondition = _prefixId.prefix "shareAlikeCondition"
    let shareCondition = _prefixId.prefix "shareCondition"
