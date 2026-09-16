#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Xml.Linq

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa

#r "FSLang.dll"
#r "Ast.dll"

open FSharp.Data

open Fabulous.AST
open Fantomas.Core
open FsHttp
open Dubzer.WhatwgUrl

type RFCProvider = JsonProvider<UseOriginalNames=true, OmitNullFields=true, RootName="rfc", Sample= @"D:\https\org\rfc-editor\www\rfc\sample.json">
type RequestForComments(rfcInt: int) =
    let _url = DomUrl $"https://www.rfc-editor.org/rfc/{rfcInt}.json"

    let _json = http { GET _url.Href } |> Request.send |> Response.toText |> RFCProvider.Parse
    static member GetIndex() =

        http { GET "https://www.ietf.org/download/rfc-index.txt" }
        |> Request.send
        |> Response.toText

    member this.rfcNumber = sprintf "%04i" rfcInt
    member this.rfcName = $"RFC{this.rfcNumber}"

    member this.url = _url
    member this.json = _json

let rfcNumbers =
    RequestForComments.GetIndex().Split('\n')
    |> Array.choose (fun line ->
        if line.Length > 3 && line[..3] |> Seq.forall Char.IsDigit then
            int line[..3] |> RequestForComments |> Some
        else
            None)
rfcNumbers[0]
