#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module audRole =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/" "audRole"

    let _namespaceIri = _prefixId.prefix ""
    let administrator = _prefixId.prefix "administrator"
    let generalPublic = _prefixId.prefix "generalPublic"
    let mentor = _prefixId.prefix "mentor"
    let parent = _prefixId.prefix "parent"
    let peerTutor = _prefixId.prefix "peerTutor"
    let professional = _prefixId.prefix "professional"
    let student = _prefixId.prefix "student"
    let teacher = _prefixId.prefix "teacher"
