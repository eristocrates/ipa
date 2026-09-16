#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sou21 =
    let _prefixId = PrefixId.fromNamespaceLabel "http://qudt.org/2.1/vocab/sou/" "sou21"
