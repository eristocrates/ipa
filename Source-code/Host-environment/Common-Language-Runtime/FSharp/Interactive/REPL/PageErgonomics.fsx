#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "TaskErgonomics.dll"

open TaskErgonomics

open PuppeteerSharp
open PuppeteerSharp.Cdp
open Dubzer.WhatwgUrl



type IPage with
    member this.asCdp = this :?> CdpPage


type CdpPageTarget with
    member this.DomUrl = DomUrl this.Url

type CdpPage with
    member this.DomUrl = DomUrl this.Url

    member this.ScrollToBottom() =
        task { return! this.EvaluateFunctionAsync("() => window.scrollTo(0, document.documentElement.scrollHeight)") }
        |> await

    member this.ScrollDown(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, pixels)", pixels) }
        |> await

    member this.ScrollUp(pixels: int) =
        task { return! this.EvaluateFunctionAsync("(pixels) => window.scrollBy(0, -pixels)", pixels) }
        |> await

    member this.SetTabName(name: string) =
        task { return! this.EvaluateFunctionAsync<string>("name => document.title = name", name) }
