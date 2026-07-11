open System
open System.Text
open System.IO
open System.Globalization

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"
#r "nuget: Unquote"

open Unicode_Standard

open SetErgonomics

open Swensen.Unquote.Assertions

#r "nuget: FsCheck"

open FsCheck
open XParsecErgonomics
open XParsec.Parsers



let int_array_from_string_matches_rune_enumeration (raw_string: NonNull<string>) =
    let expected =
        seq { for rune in raw_string.Get.EnumerateRunes() -> rune.Value }
        |> Seq.toArray

    test <@ int_array_from_string raw_string.Get = expected @>

Check.Quick int_array_from_string_matches_rune_enumeration

let int_array_from_string_does_not_emit_surrogate_halves_for_astral_character () =
    test <@ int_array_from_string "😀" = [| 0x1F600 |] @>

int_array_from_string_does_not_emit_surrogate_halves_for_astral_character ()


let partial_parse_does_not_require_end_of_input (first_element: int) (second_element: int) =
    let parser = pitem first_element

    let result =
        [| first_element; second_element |]
        |> code_point_reader
        |> parser

    test
        <@ match result with
           | Result.Ok parsed -> parsed = first_element
           | Result.Error _ -> false @>
