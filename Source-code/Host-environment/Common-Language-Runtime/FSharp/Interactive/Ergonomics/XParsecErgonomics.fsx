open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

#r "nuget: Hedgehog"

open XParsec
open XParsec.Parsers
open System.Collections.Immutable

#r "nuget: Unquote"
open Swensen.Unquote.Assertions



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"
open StringExtensions





let from_input_string (input_string: string) =
    Reader.ofArray input_string.ScalarValues ()

let expecting (message: string) parse = parse <??> message

let parse
    state_transition
    transition_condition
    to_reader
    (input_string: string)
    diagnostic
    (message: string)
    to_output
    =
    let parse_input = to_reader input_string

    let with_combinator = state_transition transition_condition
    let with_diagnostic_combinator = diagnostic message with_combinator

    if message = "" then
        parse_input |> with_combinator |> to_output
    else
        parse_input
        |> with_diagnostic_combinator
        |> to_output



let string_parser (input_string: string) = pseq input_string.ScalarValues


let string_literal_parser (input_string: string) = string_parser input_string .>> eof



let complete_parser combinator = combinator .>> eof
let partial_parser combinator = combinator

let return_int_array (result: Result<int array, 'a>) =
    test <@ Result.isOk result @>
    let (Ok result_value) = result
    result_value

let return_string (result: Result<int array, 'a>) = (return_int_array result).as_string

let return_code_point_array result =
    return_int_array result
    |> Array.map (fun value -> Code_Point.from_int value)

let returning_the_error result =
    test <@ Result.isError result @>

    let (Error error_value) = result
    error_value


parse string_parser "hello" from_input_string "hello world" expecting "hello world" return_int_array



module ImmutableArray =
    let toArray (immutable_array: ImmutableArray<_>) =
        immutable_array
        |> Seq.collect (fun element -> element)
        |> Seq.toArray
