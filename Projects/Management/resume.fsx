#if INTERACTIVE
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Json"
#r "nuget: Newtonsoft.Json"
#r "nuget: Iride"
#r "nuget: FsHttp"
#r @"C:\Repositories\eristocrates\ipa\visual_studio_solutions\shared_kernel\bin\Debug\net10.0\shared_kernel.dll"
#r @"C:\Repositories\eristocrates\ipa\visual_studio_solutions\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"
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
open Org.Namespace
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

module resume = 
    let _namedGraph = 
      NamedGraph.inhabitant
          (mint.prefixID "urn:adhoc:resume" "resume")
          @"C:\Repositories\eristocrates\Family\Family\Commonplace\resume"
    let _prefix = _namedGraph._prefix
    let this = _prefix "this"
    let test = _prefix "test"

resume.this --- a --> resume.test >-: resume._namedGraph

GraphRuntime.NamedGraphs
|> Seq.iter (fun namedGraph -> GraphRuntime.Serialization.Turtle.save namedGraph)
