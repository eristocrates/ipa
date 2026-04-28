open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers
open System.Collections.Immutable

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\SetErgonomics.fsx"
open SetErgonomics


#r "nuget: FSharp.UMX"

open FSharp.UMX

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Unicode_Standard.fsx"

open Unicode_Standard

module UMX =
    let retag_string<[<Measure>] 'InputMeasure, [<Measure>] 'OutputMeasure>
        (input: string<'InputMeasure>)
        : string<'OutputMeasure> =
        %(UMX.untag input)

let material_element_of
    (material_set: Set_Definition<int>)
    : Parser<int, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    satisfy (fun code_point -> material_set.Contains code_point)

let pcode_point (input: char) = pitem (int input)

let skipcode_point (input: char) = skipItem (int input)

let parse_expecting parse (expecting: string) = parse <??> expecting

let int_array_from_string (raw_string: string) =
    seq { for rune in raw_string.EnumerateRunes() -> rune.Value }
    |> Seq.toArray

let code_point_reader (code_points: int array) = Reader.ofArray code_points ()

let partial_parse parse (raw_string: string) =
    raw_string
    |> int_array_from_string
    |> code_point_reader
    |> parse

let complete_parse parse (raw_string: string) =
    raw_string
    |> int_array_from_string
    |> code_point_reader
    |> (parse .>> eof)

let parse_code_point_expecting<[<Measure>] 'OutputType>
    (material_set: Set_Definition<int>)
    (expecting: string)
    : Parser<string<'OutputType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_expecting
        (material_element_of material_set
         |>> fun code_point -> %(Rune(code_point).ToString()))
        expecting

let string_from_code_points (code_points: ImmutableArray<int>) : string =

    code_points
    |> Seq.map char
    |> Seq.toArray
    |> String

let parse_result parse (raw_string: string) =
    let result =
        raw_string
        |> int_array_from_string
        |> code_point_reader
        |> (parse .>> eof)

    let (Result.Ok ok_result) = result
    ok_result

let error'from_parse parse (raw_string: string) =
    let result =
        raw_string
        |> int_array_from_string
        |> code_point_reader
        |> (parse .>> eof)

    let (Result.Error error_result) = result
    error_result

module ImmutableArray =
    let of_strings_to_measured_string<[<Measure>] 'MeasureType>
        (immutable_measured_string_array: ImmutableArray<string<'MeasureType>>)
        : string<'MeasureType> =
        let untagged_string =
            immutable_measured_string_array
            |> Seq.toArray
            |> Array.map (fun tagged_string -> UMX.untag tagged_string)
            |> String.concat ""

        %untagged_string
