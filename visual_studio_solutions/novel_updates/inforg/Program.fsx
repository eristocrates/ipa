// https://fsprojects.github.io/FSharp.Data/library/HtmlProvider.html
#r "nuget: FSharp.Data"
#r "nuget: Terminal.Gui"
#r "nuget: Iride"
#r @"..\..\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"
#load "Link.fsx"
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
open Xs.Namespace
open Xml.spec.Namespace
open Loc.premis.Namespace
open Cidocrm.Namespace


module Unit =
  module Prefix =
    // Using float avoids truncation; int64 would silently lose information for submultiples.
    let inline measurea   (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e18
    let inline peta  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e15
    let inline tera  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e12
    let inline giga  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e9
    let inline mega  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e6
    let inline kilo  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e3
    let inline hecto (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e2
    let inline deca  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure * 1e1

    let inline metric  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure
    let inline deci  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e1
    let inline centi (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e2
    let inline milli (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e3
    let inline micro (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e6
    let inline nano  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e9
    let inline pico  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e12
    let inline femto (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e15
    let inline atto  (measure: float<'UnitOfMeasure>) : float<'UnitOfMeasure> = measure / 1e18



let pauseFor (prefix:float<SI.UnitNames.second> -> float<SI.UnitNames.second>) (measure: float<SI.UnitNames.second>) : unit =
  let duration  = prefix measure
  Thread.Sleep(TimeSpan.FromSeconds(float duration))

Console.WriteLine(DateTime.Now)
pauseFor Unit.Prefix.metric 2.0<SI.UnitNames.second>
Console.WriteLine(DateTime.Now)

GraphRuntime.inMemoryDataset.Graphs |> Seq.iter (fun graph -> 
  graph.Clear()
  graph.NamespaceMap.Clear()
)
let a = rdf.``type``

let novelupdates =
    NamedGraph.inhabitant
        (mint.prefixID $"https://www.novelupdates.com/" "novelupdates")
        @"Artifacts\novelupdates"
let novelupdates'group =
    NamedGraph.inhabitant
        (mint.prefixID $"https://www.novelupdates.com/group/" "novelupdates.group")
        @"Artifacts\novelupdates\groups"
let graphs = [novelupdates'group]



// Link.novelupdates.group.Citrus_aurora.when_the_guide_stopped_playing_a_villainess_the_obsession_began.html.Lists.List3.Values |> Array.iter (fun item -> Console.WriteLine item)

let firstPage = 1
let lastPage =
  Link.novelupdates.groupslist.html.CssSelect "div.digg_pagination a"
  |> Seq.map (fun pg -> 
    let href = pg.Attribute("href").Value()
    href.Replace("./?pg=", "") |> int
  ) |> Seq.sort |> Seq.last



let pages =
  seq {
    for pageIndex in firstPage .. lastPage do
      let pageGraph =
        NamedGraph.inhabitant
          (mint.prefixID $"urn:novelupdates:group:{pageIndex}" $"novelupdates.group.page{pageIndex}")
          $"""Artifacts\novelupdates\groups\page{pageIndex}"""
      let pageHtml = Link.novelupdates.groupslist.paginated.html pageIndex

      pageHtml.CssSelect ".g-cols li a" 
      |> Seq.iter (fun anchor ->
        let href = anchor.Attribute("href").Value()
        let localName = href.Replace(novelupdates'group._uri.OriginalString, "").Replace("/","")
        novelupdates'group._prefix localName --- a --> novelupdates._prefix "group" >-: pageGraph)
      pageGraph

  }
  |> Seq.cache
graphs = graphs @ (pages |> Seq.toList)

graphs |> List.iter (fun namedGraph -> 
     GraphRuntime.Serialization.Turtle.save  namedGraph
)