open System
open System.Collections.Immutable

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

// open XParsecErgonomics



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Unicode_Standard.fsx"

open SetErgonomics
open Unicode_Standard


open StringExtensions



open Swensen.Unquote.Assertions

let from_input_string (input_string: string) =
    Reader.ofArray input_string.CodePoints ()

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


let code_point_parser (target_code_point: Code_Point) = pitem target_code_point

let string_parser (input_string: string) = pseq input_string.CodePoints

let set_parser (set_definition: Set_Definition<int>) =
    satisfy (fun (code_point: Code_Point) -> set_definition.Contains(int code_point))

let string_literal_parser (input_string: string) = string_parser input_string .>> eof



let complete_parser combinator = combinator .>> eof

let returning_the_value result =
    test <@ Result.isOk result @>
    let (Ok result_value) = result
    result_value |> Code_Point.array_as_string

let returning_the_error result =
    test <@ Result.isError result @>

    let (Error error_value) = result
    error_value


// TODO find a way to keep expected message with <?>
parse string_parser "hello" from_input_string "hello world" expecting "hello world" returning_the_value
