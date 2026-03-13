#if INTERACTIVE
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Json"
#r "nuget: Newtonsoft.Json"
#r "nuget: Iride"
#r "nuget: FsHttp"
#r @"C:\Repositories\ipa\visual_studio_solutions\shared_kernel\bin\Debug\net10.0\shared_kernel.dll"
#r @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"
#endif

open System
open System.Reflection
open System.Globalization
open System.Threading

open System.IO
open System.Text
open System.Text.Json
open System.Collections.Generic
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open System.Text.Json.Nodes
open System.Text.Json.Nodes
open FSharp.Data
open FSharp.Json


open FsHttp
open VDS.RDF.Parsing
open VDS.RDF.Query
open System.Net.Http
open SharedKernel
open Program

open Ergonomics
open Shorthand
open LangTag
open Rdf.Namespace
open Rdfs.Namespace
open Owl.Namespace
open Xsd.Namespace
open Xs.Namespace
open Xml.spec.Namespace
open Dcat.Namespace
open Dcmi.dcterms.Namespace
open Ontolex.Namespace
open Ontolex.lexinfo.Namespace



GraphRuntime.inMemoryDataset.Graphs
|> Seq.iter (fun graph ->
    graph.Clear()
    graph.NamespaceMap.Clear())



let a = rdf.``type``

let commonplace = mint.prefixID "https://eristocrates.dev/ontology/commonplace" "commonplace"
let wikipedia = mint.prefixID "https://en.wikipedia.org/wiki/" "wikipedia.en" 
let colon = mint.prefixID "urn:adhoc:" ""
let lexeme = mint.prefixID "urn:lexeme:" "lexeme"
let form = mint.prefixID "urn:form:" "form"
let singular = mint.prefixID $"{form._namespaceUri}singular:" $"{form._namespacePrefix.Value}.singular"
let concept = mint.prefixID "urn:concept:" "concept"
let entity = mint.prefixID "urn:entity:" "entity"
let sense = mint.prefixID "urn:sense:" "sense"
let usage = mint.prefixID "urn:usage:" "usage"
let has = mint.prefixID "urn:has:" "has"
let part = mint.prefixID "urn:part:" "part"
let restriction = mint.prefixID "urn:restriction:" "restriction"
module bfo = 
    let vocabulary = mint.prefixID "http://purl.obolibrary.org/obo/BFO_" "bfo"
    let has_part = vocabulary._prefix "0000051"
    let part_of = vocabulary._prefix "0000050"
    let MaterialEntity = vocabulary._prefix "0000040"

let graph =
  NamedGraph.inhabitant
      (mint.prefixID "urn:adhoc:graph" "graph")
      @"C:\Repositories\ipa\visual_studio_solutions\control\Management\graph"

// part._prefix "of" --- owl.sameAs --> bfo.part_of >-: graph


let has_part(hypernym:Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)(hyponym:Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)(graphs : NamedGraph.Type list) = 
    has._prefix "part" --- owl.sameAs --> bfo.has_part >=: graphs

    let owlRestriction = restriction._prefix $"{hypernym._localName}_has_part_{hyponym._localName}"
    hypernym --- rdfs.subClassOf --> owlRestriction >=: graphs
    owlRestriction --~ 
    [
        a -~- owl.Restriction ;
        owl.onProperty -~- has._prefix "part" ;
        owl.someValuesFrom -~- hyponym
    ] >=: graphs

let Kitchen = entity._prefix "Kitchen"
let Sink = entity._prefix "Sink"
let Counter = entity._prefix "Counter"
let Floor = entity._prefix "Floor"

entity._prefix "material" --- owl.sameAs --> bfo.MaterialEntity >-: graph

[
    Kitchen
    Sink
    Counter
    Floor
] -=- rdfs.subClassOf --> entity._prefix "material" >-:  graph

has_part Kitchen Sink [graph]

GraphRuntime.NamedGraphs
|> Seq.iter (fun namedGraph -> GraphRuntime.Serialization.Turtle.save namedGraph)
