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
open FSharp.Data

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
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\HtmlErgonomics.fsx"

open HtmlErgonomics
open type Html_Tag

open FSharp.ViewEngine
open Fss
open Fss.Types

open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash












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
