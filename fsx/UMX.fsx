#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.PrintWidth <- 100
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#load @".paket/load/main.group.fsx"

open System
open System.Collections
open System.Xml
open System.Xml.Linq
open TextCopy
open Fabulous.AST
open Fantomas.Core

type Clipboard with
    member this.clip(text: string) = this.SetText text
    member this.clip(lines: string array) =
        lines |> String.concat "\n" |> this.clip

type String with
    static member Clipboard = new Clipboard()
    member this.clip = String.Clipboard.clip (this)
let measureParameter = "<[<Measure>] 'DatatypeMeasure>"
let codegen =
    Ast.Oak() {
        Ast.AnonymousModule() {
            Ast.Abbrev($"DateTimeOffset", "System.DateTimeOffset")
            |> _.attribute(Ast.Attribute("MeasureAnnotatedAbbreviation"))
        }
    }
    |> Gen.mkOak
    |> Gen.run

codegen.clip
