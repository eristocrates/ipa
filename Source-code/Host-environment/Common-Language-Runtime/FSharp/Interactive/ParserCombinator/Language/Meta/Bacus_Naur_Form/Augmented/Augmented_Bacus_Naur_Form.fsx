open System
open System.Text
open System.IO
open System.Globalization


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsec
open XParsec.Parsers
open XParsecErgonomics

open FSharp.Data
open Unicode_Standard
open SetErgonomics

#r "nuget: FSharp.UMX"

open FSharp.UMX
let alpha = Latin_Alphabet


let digit = ASCII_digits

let hexdig =
    Set_Definition.FromOverlay [|

                                  A_to_F
                                  ASCII_digits

                                   |]



[<Measure>]
type ALPHA

let parse_ALPHA =
    parse_code_point_expecting<ALPHA> alpha """ ALPHA          = %x41-5A / %x61-7A """

[<Measure>]
type DIGIT

let parse_DIGIT =
    parse_code_point_expecting<DIGIT> digit """ DIGIT          =  %x30-39 ; 0-9 """

[<Measure>]
type HEXDIG

let parse_HEXDIG =
    parse_code_point_expecting<HEXDIG>
        digit
        """ HEXDIG         =  DIGIT / "A" / "B" / "C" / "D" / "E" / "F" / "a" / "b" / "c" / "d" / "e" / "f" """
