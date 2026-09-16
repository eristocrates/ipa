#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ucum =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/muo/ucum/" "ucum"
