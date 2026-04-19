open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: FSharp.Data"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\Ergonomics\XParsecErgonomics.fsx"


open XParsec
open XParsec.Parsers
open XParsecErgonomics

open FSharp.Data
open UnicodeStandard

let alpha =
    {

      partition_name = "ALPHA"
      unicodepoint_set = Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.letters.unicodepoint_set

    }

let digit =
    {

      partition_name = "DIGIT"
      unicodepoint_set = Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.partition.unicodepoint_set

    }

let hexdig =
    {

      partition_name = "HEXDIG"
      unicodepoint_set = Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.hexadecimal.digits.unicodepoint_set

    }


[<Struct>]
type ALPHA =
    {

      as'string: string
      as'int: int

    }

    static member parse
        : Parser<ALPHA, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from alpha
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """ ALPHA          = %x41-5A / %x61-7A """



[<Struct>]
type DIGIT =
    {

      as'string: string
      as'int: int

    }

    static member parse
        : Parser<DIGIT, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from digit
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """ DIGIT          =  %x30-39 ; 0-9 """

[<Struct>]
type HEXDIG =
    {

      as'string: string
      as'int: int

    }

    static member parse
        : Parser<HEXDIG, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from hexdig
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """ HEXDIG         =  DIGIT / "A" / "B" / "C" / "D" / "E" / "F" / "a" / "b" / "c" / "d" / "e" / "f" """
