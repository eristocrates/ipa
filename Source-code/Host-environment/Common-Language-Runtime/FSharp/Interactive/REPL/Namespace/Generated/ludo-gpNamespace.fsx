#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ludo-gp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/gamepresentation#" "ludo-gp"

    let FrontEndDisplay = _prefixId.prefix "FrontEndDisplay"
