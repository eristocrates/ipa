open System
open System.IO


#r "nuget: FSharp.Data"
open FSharp.Data





#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"

open FParsec
open FParsec.Pipes


#r "nuget:  Fabulous.AST"

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast

// https://www.rfc-editor.org/info/rfc3986

module rfc3986 =
    [<Literal>]
    let filePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\URI\rfc3986.html"

    let stem = "rfc3986"


    let html = HtmlProvider<filePath>.Load filePath

rfc3986.html.Html
