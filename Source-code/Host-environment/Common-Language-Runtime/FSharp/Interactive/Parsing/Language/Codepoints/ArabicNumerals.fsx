open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics


type Digit_Zero =
    { as_rune: Rune }
    static member parse: Parser<Digit_Zero, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '0' |>> fun rune -> { as_rune = rune }

type Digit_One =
    { as_rune: Rune }
    static member parse: Parser<Digit_One, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '1' |>> fun rune -> { as_rune = rune }

type Digit_Two =
    { as_rune: Rune }
    static member parse: Parser<Digit_Two, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '2' |>> fun rune -> { as_rune = rune }

type Digit_Three =
    { as_rune: Rune }
    static member parse: Parser<Digit_Three, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '3' |>> fun rune -> { as_rune = rune }

type Digit_Four =
    { as_rune: Rune }
    static member parse: Parser<Digit_Four, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '4' |>> fun rune -> { as_rune = rune }

type Digit_Five =
    { as_rune: Rune }
    static member parse: Parser<Digit_Five, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '5' |>> fun rune -> { as_rune = rune }

type Digit_Six =
    { as_rune: Rune }
    static member parse: Parser<Digit_Six, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '6' |>> fun rune -> { as_rune = rune }

type Digit_Seven =
    { as_rune: Rune }
    static member parse: Parser<Digit_Seven, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '7' |>> fun rune -> { as_rune = rune }

type Digit_Eight =
    { as_rune: Rune }
    static member parse: Parser<Digit_Eight, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '8' |>> fun rune -> { as_rune = rune }

type Digit_Nine =
    { as_rune: Rune }
    static member parse: Parser<Digit_Nine, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_rune '9' |>> fun rune -> { as_rune = rune }
