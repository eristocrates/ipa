#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open ResourceDescription
#load @".paket/load/main.group.fsx"
open System

module httpm =
    let _namespace =
        NamedReference "http://www.w3.org/2011/http-methods#" |> NamespaceName

    let _rdfType = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

    let _owlNamedIndividual =
        NamedReference "http://www.w3.org/2002/07/owl#NamedIndividual"

    let CONNECT = _namespace.prefixedName "CONNECT"
    let DELETE = _namespace.prefixedName "DELETE"
    let GET = _namespace.prefixedName "GET"
    let HEAD = _namespace.prefixedName "HEAD"
    let PATCH = _namespace.prefixedName "PATCH"
    let POST = _namespace.prefixedName "POST"
    let PUT = _namespace.prefixedName "PUT"
    let OPTIONS = _namespace.prefixedName "OPTIONS"
    let TRACE = _namespace.prefixedName "TRACE"
