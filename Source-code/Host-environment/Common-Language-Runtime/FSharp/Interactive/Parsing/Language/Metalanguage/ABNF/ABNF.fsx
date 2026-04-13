open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"
open XParsecErgonomics


type ALPHA =
    { as_rune: Rune }

    static member parse: Parser<ALPHA, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Rune.IsLetter
             |>> fun rune -> { as_rune = rune })
            """ALPHA          =  %x41-5A / %x61-7A   ; A-Z / a-z"""



type DIGIT =
    { as_rune: Rune }

    static member parse: Parser<DIGIT, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Rune.IsDigit
             |>> fun rune -> { as_rune = rune })

            """DIGIT          =  %x30-39 ; 0-9"""


type HEXDIGIT =
    { as_rune: Rune }

    static member parse: Parser<HEXDIGIT, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (anyRune "0123456789abcdefgABCDEFG"
             |>> fun rune -> { as_rune = rune })

            """ HEXDIG         =  DIGIT / "A" / "B" / "C" / "D" / "E" / "F" """
