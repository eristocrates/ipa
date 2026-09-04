#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module coun =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.daml.org/2001/09/countries/iso-3166-ont#" "coun"

    let Country = _prefixId.prefix "Country"
    let code = _prefixId.prefix "code"
    let name = _prefixId.prefix "name"
