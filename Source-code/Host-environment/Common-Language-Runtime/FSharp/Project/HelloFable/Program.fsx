open System
open System.IO




#r "nuget: XParsec"
open XParsec
#r "nuget: NeatIntervals"
open NeatIntervals
#r "nuget: FRange"
open FRange
#r "nuget: UUIDNext"
open UUIDNext
#r "nuget: CommunityToolkit.HighPerformance"
open CommunityToolkit.HighPerformance.Buffers
#r "nuget: FSharp.Data"
open FSharp.Data
#r "nuget: FSharp.HashCollections"
open FSharp.HashCollections
#r "nuget: dotNetRdf"
open VDS.RDF
#r "nuget: Yog.FSharp"
open Yog.Model
open Yog.Builder
open Yog.IO
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid



#r "nuget: QuikGraph"
open QuikGraph
#r "nuget: QuikGraph.Serialization"
open QuikGraph.Serialization
#r "nuget: QuikGraph.Graphviz"
open QuikGraph.Graphviz
#r "nuget: QuikGraph.Data"
open QuikGraph.Data
#r "nuget: QuikGraph.MSAGL"
open QuikGraph.MSAGL
#r "nuget: QuikGraph.Petri"
open QuikGraph.Petri




#r "nuget:  Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast


#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Unicodepoint\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Interval_Range\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\ParserCombinator\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\obj\Release\net10.0"

#r "Unicodepoint.dll"
#r "Interval_Range.dll"
#r "Ergonomic_Extensions.dll"
#r "ParserCombinator.dll"
#r "Rdf_Vocabulary.dll"

open DoxAletheia
open Rdf_Vocabulary
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range
open Rdf_Shorthand
open Rdf_Document
open Namespace_Prefixes
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\HtmlErgonomics.fsx"

open HtmlErgonomics
open type Html_Tag

open FSharp.ViewEngine
open Fss
open Fss.Types

open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash
open http.xmlns.com.foaf._0._1.slash












let html_element =
    html {
        _lang "en"

        head {
            title "graph"
            meta { _charset "UTF-8" }

            meta {
                _name "viewport"
                _content "width=device-width, initial-scale=1"
            }

            style { css "body" [ Margin.value Zero ] }
            script { _src "https://cdn.jsdelivr.net/npm/force-graph" }

        }

        body {
            div { _id "graph" }

            script {
                _type "module"
                _src "./Program.fs.js"
            }
        }

    }

let html_document =
    html_element
    |> Render.toHtmlDocString
    |> HtmlDocument.Parse



let html_document_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\HelloFable\Program.fs.html"

File.WriteAllText(html_document_path, html_document.ToString())

let a = rdf.type_








module dbug =
    let _namespace_name = "https://eristocrates.dev/ontology/dbug/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name
        |> NamespacedName

    let this_ = _prefix "this"
    let example = _prefix "example"
    let Bob = _prefix "Bob"
    let The_Mona_Lisa = _prefix "The_Mona_Lisa"
    let Alice = _prefix "Alice"

    let Charlie = _prefix "Charlie"
    let Sasha = _prefix "Sasha"
    let eris = _prefix "eris"
    let syris = _prefix "syris"
    let Leonardo_da_Vinci = _prefix "Leonardo_da_Vinci"
    let La_Joconde_a_Washington = _prefix "La_Joconde_à_Washington"
    let archipelago = _prefix "archipelago"



module commonplace =
    let _namespace_name = "https://eristocrates.dev/ontology/commonplace/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name
        |> NamespacedName
    let Quest_of_D = _prefix "Quest_of_D"
    let Gitadora = _prefix "Gitadora"



module The_16th_Sanctuary = 
    module Rhythm_Games = 
        module rhythm_game_chat = 


            [<Literal>]
            let sample_file_path =
                @"H:\Surface\Personal\16thSanctuary\The 16th Sanctuary - Rhythm Games - rhythm-game-chat [879472415682490408].json"

            let json = JsonProvider<sample_file_path>.Load sample_file_path




module sanctuary =
    open DoxAletheia.Rdf_Vocabulary
    let _namespace_name = "https://eristocrates.dev/ontology/sanctuary/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name
        |> NamespacedName

    let eristocrates = _prefix "eristocrates"
    let siamesederp = _prefix "siamesederp"
    let yaladre = _prefix "yaladre"
    let regen = _prefix "regen=Q"


let draft_document = 
    !| [ 
        sanctuary.eristocrates
        sanctuary.siamesederp
        sanctuary.yaladre
        sanctuary.regen
     ] --- a --> foaf.Person
     -!> sanctuary.yaladre --- foaf.topic_interest -->| [ commonplace.Quest_of_D  ; commonplace.Gitadora  ]
let test_name = "test_graph"
let test_directory = Path.Combine(__SOURCE_DIRECTORY__, test_name)
draft_document |> write_draft test_directory test_name



[<CLIMutable>]
type Force_Node =
    {
        id: string
    }

[<CLIMutable>]
type Force_Link =
    {
        source: string
        target: string
        predicate: string
    }

[<CLIMutable>]
type Force_Graph_Data =
    {
        nodes: Force_Node array
        links: Force_Link array
    }


let force_graph_data (rdf_graph:Rdf_Graph) =

    let links =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            {
                source = triple.curSubject.as_raw_string
                target = triple.curObject.as_raw_string
                predicate = triple.curPredicate.as_raw_string 
            }
        )

    let nodes =
        links
        |> Array.collect (fun link ->
            [|
                link.source
                link.target
            |]
        )
        |> Array.distinct
        |> Array.map (fun id ->
            {
                id = id
            }
        )

    {
        nodes = nodes
        links = links
    }


let test_graph = 
     draft_document |> Draft_Document.to_rdf_graph
let force_graph = force_graph_data test_graph






let force_node_expression (node: Force_Node) =
    AnonRecordExpr(
        [
            RecordFieldExpr("id", Ast.String(node.id))
        ]
    )

let force_link_expression (link: Force_Link) =
    AnonRecordExpr(
        [
            RecordFieldExpr("source", Ast.String(link.source))
            RecordFieldExpr("target", Ast.String(link.target))
            RecordFieldExpr("predicate", Ast.String(link.predicate))
        ]
    )
let force_graph_data_expression (graph_data: Force_Graph_Data) =

    let node_expressions =
        graph_data.nodes
        |> Array.map force_node_expression

    let link_expressions =
        graph_data.links
        |> Array.map force_link_expression

    AnonRecordExpr(
        [
            RecordFieldExpr(
                "nodes",
                ArrayExpr(node_expressions)
            )

            RecordFieldExpr(
                "links",
                ArrayExpr(link_expressions)
            )
        ]
    )


let generated_graph_data_oak (graph_data: Force_Graph_Data) =
    Oak() {
        AnonymousModule() {
                Open("Browser.Dom")
                Open("Browser.Types")
                Open("Fable.Core")
                Open("Fable.Core.JsInterop")

                Value(
                    "graphData",
                    force_graph_data_expression graph_data
                )

                Function(
                    "render_graph",
                    [
                        ParenPat(
                            ParameterPat("element", "HTMLElement")
                        )

                        ParenPat(
                            ParameterPat("data", "obj")
                        )
                    ],
                    IdentExpr("jsNative"),
                    "obj"
                )
                |> _.attribute(
                    Attribute(
                        "Emit",
                        Ast.String(
                            "new ForceGraph()($0).linkDirectionalParticles(2).graphData($1)"
                        )
                    )
                )
                |> _.attribute(
                    Attribute(
                        "Emit",
                        Ast.String(
                            "new ForceGraph()($0).linkDirectionalParticles(2).graphData($1)"
                        )
                    )
                )

                Value(
                    "Graph",
                    AppExpr(
                        "render_graph",
                        [
                            ParenExpr(
                                AppExpr(
                                    "document.getElementById",
                                    Ast.String("graph")
                                )
                            )

                            IdentExpr("graphData")
                        ]
                    )
                )
            }
            
        }
        |> Gen.mkOak
        |> Gen.run
    

let generated_source  =
    force_graph
    |> generated_graph_data_oak
    
let watched_file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\HelloFable\Program.fs"
File.WriteAllText(watched_file_path, generated_source)
printfn "%s" generated_source