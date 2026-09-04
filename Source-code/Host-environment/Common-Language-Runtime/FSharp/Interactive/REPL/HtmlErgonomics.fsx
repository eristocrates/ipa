#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "TaskErgonomics.dll"

open TaskErgonomics
#r "JavascriptErgonomics.dll"

open JavascriptErgonomics


open System
open System.Linq.Expressions
open FSharp.Data
open PuppeteerSharp
open PuppeteerSharp.Cdp





type IElementHandle with
    member this.asCdp = this :?> CdpElementHandle



type CdpElementHandle with
    member this.EvaluateFunction(javascriptFunction: Expression<Func<'InputType, 'OutputType>>) =
        task { return! this.EvaluateFunctionAsync<'OutputType>(javascriptFunction |> Javascript.asText) }
        |> await

    member this.outerHTML =
        Javascript.func<AngleSharp.Dom.IElement, string> (fun element -> element.OuterHtml)
        |> this.EvaluateFunction
        |> HtmlNode.Parse
