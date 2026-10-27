// https://fsharpforfunandprofit.com/posts/computation-expressions-intro/
#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.PrintWidth <- 100
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Clipboard.fsx"
#load "Logger.fsx"
#I @"D:\https\com\github\eristocrates\ipa\dll"
open Clipboard
open Logger
#load @".paket/load/main.group.fsx"

module FSharpLiteral = FSharp.Literals.Literal
open System
open System.Collections
open System.Xml
open System.Xml.Linq
open TextCopy
open Fabulous.AST
open Fantomas.Core

let datatypeMeasureParameter = Ast.TyparDecl("'DatatypeMeasure") |> _.attribute(Ast.Attribute("Measure"))
type Type with
    member this.fsharpName = FSharpLiteral.stringifyTypeDynamic this
    member this.AbbrevName =
        match this.fsharpName with
        | fsharpName when fsharpName.Contains("[]") -> fsharpName.Replace("[]", "Array")
        | fsharpName -> fsharpName
    member this.AstAbbrev =

        Ast.Abbrev(this.AbbrevName, this.fsharpName)
        |> _.typeParams(Ast.PostfixList(datatypeMeasureParameter))
        |> _.attribute(Ast.Attribute("MeasureAnnotatedAbbreviation"))
    member this.nameLiteral = this.AbbrevName + "Literal"
    member this.nameValue = this.AbbrevName + "Value"
    member this.tagMember =
        Ast.Member($"tag<[<Measure>] 'DatatypeMeasure> ({this.nameLiteral}: {this.Name})", $"Unsafe.cast {this.nameLiteral}", $"{this.AbbrevName}<'DatatypeMeasure>")
        |> _.toStatic()
        |> _.toInlined()
    member this.untagMember =
        Ast.Member($"untag<[<Measure>] 'DatatypeMeasure> ({this.nameValue}: {this.AbbrevName}<'DatatypeMeasure>)", $"Unsafe.cast {this.nameValue}", $"{this.Name}")
        |> _.toStatic()
        |> _.toInlined()
    member this.castMember =
        Ast.Member(
            $"cast<[<Measure>] 'FromDatatypeMeasure, [<Measure>] 'ToDatatypeMeasure> (literal: string<'FromDatatypeMeasure>)",
            $"Unsafe.cast literal",
            $"{this.AbbrevName}<'ToDatatypeMeasure>"
        )
        |> _.toStatic()
        |> _.toInlined()

let systemTypes = [|
    typeof<byte array>
    typeof<string>
    typeof<byte>
    typeof<DateOnly>
    typeof<DateTime>
    typeof<DateTimeOffset>
    typeof<decimal>
    typeof<double>
    typeof<int16>
    typeof<int32>
    typeof<int64>
    typeof<sbyte>
    typeof<single>
    typeof<TimeOnly>
    typeof<TimeSpan>
    typeof<uint16>
    typeof<uint32>
    typeof<uint64>
    typeof<Uri>
|]

let codegen =
    Ast.Oak() {
        Ast.AnonymousModule() {

            for systemType in systemTypes do
                systemType.AstAbbrev
            Ast.TypeDefn("UMX") {
                for typeAbbreviation in systemTypes do
                    typeAbbreviation.tagMember
                    typeAbbreviation.untagMember
                    typeAbbreviation.castMember
            }
        }
    }
    |> Gen.mkOak
    |> Gen.run

codegen.clip
