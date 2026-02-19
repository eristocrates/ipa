// https://fsprojects.github.io/FSharp.Data/library/HtmlProvider.html
#r "nuget: FSharp.Data"
#r "nuget: Terminal.Gui"
#r "nuget: Iride"
#r @"..\..\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"
// #load "Tui.fsx"

#load @"..\..\shared_kernel\Sanitation.fsx"
#load @"..\..\shared_kernel\InvalidFileNameCharacter.fsx"

open System.Text
open FSharp.Data
open System
open System.IO
open System.Collections.Generic
open System.Xml.Linq
open System.Xml.XPath
open System.Threading
open System.Net
open FSharp.Data.UnitSystems

open Sanitation
open Program
open Ergonomics
open Shorthand
open Rdf.Namespace
open Rdfs.Namespace
open Owl.Namespace
open Xsd.Namespace

module SongDatabase =
    [<Literal>]
    let uri =
        @"C:\Repositories\ipa\visual_studio_solutions\rhythm_games\infalsus\SongDatabase.json"

    type provider = JsonProvider<uri>
    let json = provider.Load(uri)

module SongList =
    [<Literal>]
    let uri =
        @"C:\Repositories\ipa\visual_studio_solutions\rhythm_games\infalsus\SongList.json"

    type provider = JsonProvider<uri>
    let json = provider.Load(uri)

let canonicalize (localName: string) = localName.Replace(" ", "_")

SongDatabase.json.AllSongInfo
|> Array.filter (fun songInfo -> songInfo.BaseName.IsSome)
|> Array.iter (fun songInfo -> Console.WriteLine songInfo.BaseName.Value)





GraphRuntime.inMemoryDataset.Graphs
|> Seq.iter (fun graph ->
    graph.Clear()
    graph.NamespaceMap.Clear())

let a = rdf.``type``

let infalsus'miraheze =
    NamedGraph.inhabitant
        (mint.prefixID $"https://infalsus.miraheze.org/wiki/" "infalsus.miraheze")
        @"Artifacts\infalsus\miraheze"
let infalsus = mint.prefixID $"urn:infalsus:" "infalsus"
let dbpedia'ontology = mint.prefixID $"http://dbpedia.org/ontology/" "dbpedia"

SongList.json.Songs.JsonValue.Properties()
|> Array.iter (fun (songKey, songValue) -> 
    let songName = canonicalize songKey
    infalsus'miraheze._prefix songName --- a --> dbpedia'ontology._prefix "Song" >-: infalsus'miraheze
    let artist =  songValue.GetProperty("artist")
    infalsus'miraheze._prefix songName --- infalsus._prefix "artist" --> dbpedia'ontology._prefix "Song" >-: infalsus'miraheze
)
let graphs = [ infalsus'miraheze ]



graphs |> List.iter (fun namedGraph -> 
     GraphRuntime.Serialization.Turtle.save  namedGraph
)