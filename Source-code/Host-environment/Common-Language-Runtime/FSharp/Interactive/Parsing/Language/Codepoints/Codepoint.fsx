open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"
open XParsecErgonomics


type Dollar_Sign =
    { as_rune: Rune }
    interface Rune_Representation with
        member this.as_rune = this.as_rune

    static member parse: Parser<Dollar_Sign, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '$' |>> fun rune -> { as_rune = rune }

type Exclamation_Mark =
    { as_rune: Rune }
    interface Rune_Representation with
        member this.as_rune = this.as_rune

    static member parse: Parser<Exclamation_Mark, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '!' |>> fun rune -> { as_rune = rune }
