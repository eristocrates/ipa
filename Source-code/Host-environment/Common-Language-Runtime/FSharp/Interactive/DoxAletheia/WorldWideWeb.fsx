open System
open System.Linq

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\WorldWideWeb\URISchemes.fsx"
// #r "nuget: CaseConverter"
// open CaseConverter


module MediaType =
    module text =
        [<Literal>]
        let turtle = "text/turtle;q=0.8"

        let plain = "text/plain;q=0.1"

    module application =

        let ntriples = "application/n-triples;q=0.7"
        let rdfxml = "application/rdf+xml;q=0.6"
        let trig = "application/trig;q=1"
        let nquads = "application/n-quads;q=0.9"
        let ldjson = "application/ld+json;q=0.5"
