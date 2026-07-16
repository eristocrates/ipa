// #time on
module DoxAletheia.XParsecExtensions

open System
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics
(*


// #r "nuget: CommunityToolkit.HighPerformance"
open CommunityToolkit.HighPerformance

// #r "nuget: Unquote"
open Swensen.Unquote.Assertions

// #r "nuget: XParsec"



// #r "nuget: FSharp.UMX"


// #r "nuget: Hedgehog"

open Hedgehog
open Hedgehog.FSharp

// #r "nuget: NUnit.Framework"
// #r "nuget: FsUnit"

open NUnit.Framework
open FsUnit

// #r "nuget: FsCheck"
open FsCheck

// #r "nuget: MathNet.Numerics"
open MathNet.Numerics

// #r "nuget: FRange"
open FRange


// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics

// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\IntervalErgonomics.fsx"
// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\Unicodepoint.fsx"

open IntervalErgonomics
// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\ArrayErgonomics.fsx"
open ArrayErgonomics
*)

open XParsec
open XParsec.Parsers
open XParsec.Combinators
open FSharp.UMX
open NeatIntervals
open FRange


open StringExtensions
open IntervalErgonomics

// printfn "Vector.IsHardwareAccelerated = %b" Vector.IsHardwareAccelerated


type Code_Point_Parser = Parser<Code_Point, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Line_Parser = Parser<Code_Line, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Square_Parser = Parser<Code_Square, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Cube_Parser = Parser<Code_Cube, Code_Point, unit, ReadableMemory<Code_Point>>


let parse_input happy_path sad_path parse_result =

    match parse_result with
    | Ok success -> happy_path success
    | Error failure -> sad_path failure


module Code_Line =
    let zero_array: Code_Line array = [| [| 0 |] |]

    let from_immutable_code_line (immutable_array: ImmutableArray<Code_Point>) : Code_Line =
        immutable_array.AsMemory().ToArray()

    let from_immutable_code_square (immutable_array: ImmutableArray<Code_Line>) : Code_Line =
        immutable_array.AsMemory().ToArray()
        |> Array.collect (fun array_ -> array_)

    let Unames (code_line: Code_Line) =
        code_line
        |> Array.map (fun code_point -> sprintf "U+%04X" code_point)

module Code_Square =
    let zero_array: Code_Square array = [| [| [| 0 |] |] |]

    let from_immutable_code_square (immutable_array: ImmutableArray<Code_Line>) : Code_Square =
        immutable_array.AsMemory().ToArray()
        |> Array.map (fun array_ -> array_)

    let from_immutable_code_cube (immutable_array: ImmutableArray<Code_Square>) : Code_Square =
        immutable_array.AsMemory().ToArray()
        |> Array.collect (fun array_ -> array_)

    let Unames (code_square: Code_Square) =
        code_square |> Array.map Code_Line.Unames







let code_point_message (code_point: Code_Point) (rule: string) =
    sprintf "code point %d (U+%X) ``%s`` failed rule %s" code_point code_point (String.from_code_point code_point) rule

let code_line_message (code_line: Code_Line) (rule: string) =
    sprintf "code line %A (%A) ``%s`` failed rule %s" code_line Code_Line.Unames (String.from_code_line code_line) rule

let code_square_message (code_square: Code_Square) (rule: string) =
    sprintf
        "code line %A (%A) ``%A`` failed rule %s"
        code_square
        Code_Square.Unames
        (Strings.from_code_square code_square)
        rule

let code_cube_message (code_cube: Code_Cube) (rule: string) =
    sprintf
        "code line %A (%A) ``%A`` failed rule %s"
        code_cube
        Code_Square.Unames
        (Strings.from_code_cube code_cube)
        rule


type Code_Dimension =
    | CodePoint of Code_Point
    | CodeLine of Code_Line
    | CodeSquare of Code_Square
    | CodeCube of Code_Cube
    member this.error_message =
        match this with
        | CodePoint code_point -> code_point_message code_point
        | CodeLine code_line -> code_line_message code_line
        | CodeSquare code_square -> code_square_message code_square
        | CodeCube code_cube -> code_cube_message code_cube



type Parser_Input =
    | CharInput of char
    | StringInput of string
    | CodePointInput of Code_Point
    | CodeLineInput of Code_Line


module Reader =
    let from_parser_input (parser_input: Parser_Input) : Reader<Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        match parser_input with
        | CharInput char_ -> Reader.ofMemory (ReadOnlyMemory([| int char_ |])) ()
        | StringInput string_input -> Reader.ofMemory (ReadOnlyMemory(string_input.as_code_line)) ()
        | CodePointInput code_point -> Reader.ofMemory (ReadOnlyMemory([| code_point |])) ()
        | CodeLineInput code_line -> Reader.ofMemory (ReadOnlyMemory(code_line)) ()



type String with
    member this.as_parser_input = StringInput this |> Reader.from_parser_input














module Code_Parsers =


    let parse_char (target_char: char) : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        pitem (int target_char)

    let parse_code_point
        (target_code_point: Code_Point)
        : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        pitem target_code_point

    let skip_char (target_char: char) : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        skipItem (int target_char)

    let skip_code_point
        (target_code_point: Code_Point)
        : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        skipItem target_code_point



    let parse_string (target_string: string) : Parser<Code_Line, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        pseq target_string.as_code_line

    let skip_string (target_string: string) : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        parse_string target_string >>. preturn ()

    let parse_code_line
        (target_code_line: Code_Line)
        : Parser<Code_Line, Code_Point, 'StateType, ReadableMemory<Code_Point>> =

        pseq target_code_line

    let parse_string_return (target_string: string) return_value =
        pseqReturn target_string.as_code_line return_value

    let parse_code_line_return (target_code_line: Code_Line) return_value =
        pseqReturn target_code_line return_value

    let any_from_chars (char_set: char array) : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        anyOf (Code_Line.from_chars (char_set))

    let any_from_string (string_set: string) : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        anyOf string_set.as_code_line

    let any_from_code_points
        (code_points: Code_Point array)
        : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =

        anyOf code_points

    let none_from_chars
        (char_set: char array)
        : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        noneOf (Code_Line.from_chars (char_set))



    // TODO next continue rewriting Parsers



    let none_from_string (string_set: string) : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        noneOf string_set.as_code_line

    let none_from_code_line
        (code_set: Code_Line)
        : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        noneOf code_set

    let skip_any_from_chars (char_set: char array) : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        skipAnyOf (Code_Line.from_chars (char_set))

    let skip_any_from_string (string_set: string) : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =

        skipAnyOf string_set.as_code_line

    let skip_any_from_code_line
        (code_set: Code_Line)
        : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        skipAnyOf code_set

    let any_point_from_interval
        (interval_range: Interval<Code_Point, Range<Code_Point>>)
        : Parser<Code_Point, Code_Point, 'StateType, ReadableMemory<Code_Point>> =
        anyInRange interval_range.Start interval_range.End

    let skip_any_point_from_interval
        (interval_range: Interval<Code_Point, Range<Code_Point>>)
        : Parser<unit, Code_Point, 'StateType, ReadableMemory<Code_Point>> =

        skipAnyInRange interval_range.Start interval_range.End

    let whitespace_chars =
        [|

           ' '
           '\t'
           '\r'
           '\n'

           |]

    let whitespace_code_points: Code_Line = Code_Line.from_chars whitespace_chars

    let spaces: Parser<unit, Code_Point, unit, ReadableMemory<Code_Point>> =
        many (skipAnyOf whitespace_code_points)
        >>. preturn ()

    let spaces1: Parser<unit, Code_Point, unit, ReadableMemory<Code_Point>> =
        many1 (skipAnyOf whitespace_code_points)
        >>. preturn ()

    let newline: Parser<Code_Line, Code_Point, unit, ReadableMemory<Code_Point>> =
        choice [ skipItem (int '\r') >>. pitem (int '\n')
                 pitem (int '\n')
                 pitem (int '\r')

                  ]
        >>. preturn [| int '\n' |]

    let circumfixed_parser (left_char: char) input_parser (right_char: char) =
        between (parse_char left_char) (parse_char right_char) input_parser

// parse results
module Result =
    let with_none output = None
    let with_empty_array output = [||]
    let with_true output = true
    let with_false output = false


    module Ok =
        let with_output output = output
        let with_some_output output = Some output
        let with_array_output output = [| output |]
        let with_some_array_output output = Some [| output |]

    module Error =
        let with_exception_message (code_dimension: Code_Dimension) (rule: string) =
            failwith <| code_dimension.error_message rule

        let with_none_message (code_dimension: Code_Dimension) (rule: string) =
            Console.WriteLine $"{code_dimension.error_message rule}"
            None

        let with_empty_array_message (code_dimension: Code_Dimension) (rule: string) =
            Console.WriteLine $"{code_dimension.error_message rule}"
            [||]
(*
        let with_code_point (code_point: int) = code_point
        let with_code_line (code_line: int array) = code_line
        let with_code_square (code_square: int array array) = code_square


        let with_some_code_point (code_point: int) = Some code_point

        let with_some_code_line (code_line: int array) =
            if code_line.Length < 1 then
                None
            else
                Some [| code_line |]

        let with_some_code_square (code_square: int array array) =
            if code_square.Length < 1 then
                None
            else
                Some [| code_square |]

        let with_code_point_string (code_point: int) = Rune(code_point).ToString()
        let with_code_line_string (code_line: int array) = String.from_code_line code_line

        let with_code_square_strings (code_square: int array array) =
            code_square
            |> Array.map (fun code_line -> String.from_code_line code_line)




        let with_some_code_point_string (code_point: int) = Some(String.from_code_point code_point)
        let with_some_code_line_string (code_line: int array) = Some(String.from_code_line code_line)

        let with_some_code_square_string (code_square: int array array) =
            Some(Strings.from_code_square code_square)



        let with_measured_code_point_string<[<Measure>] 'Umx> (code_point: int) : string<'Umx> =
            %(String.from_code_point code_point)

        let with_measured_code_line_string<[<Measure>] 'Umx> (code_line: int array) : string<'Umx> =
            %(String.from_code_line code_line)

        let with_measured_code_square_string<[<Measure>] 'Umx> (code_square: int array array) : string<'Umx> array =
            code_square
            |> Array.map (fun code_line ->

                %(String.from_code_line code_line)

            )





        let with_some_measured_code_point_string<[<Measure>] 'Umx> (code_point: int) : string<'Umx> option =
            Some(%(String.from_code_point code_point))

        let with_some_measured_code_line_string<[<Measure>] 'Umx> (code_line: int array) : string<'Umx> option =
            Some(%(String.from_code_line code_line))

        let with_some_measured_code_square_string<[<Measure>] 'Umx>
            (code_square: int array array)
            : string<'Umx> option array =
            code_square
            |> Array.map (fun code_line ->

                Some(%(String.from_code_line code_line))

            )




module Error =


    let code_point_failed_rule_message (code_point: int) (rule: string) =
        sprintf
            "code point %d (U+%X) ``%s`` failed rule %s"
            code_point
            code_point
            (String.from_code_point code_point)
            rule

    let code_line_failed_rule_message (code_line: int array) (rule: string) =
        sprintf "code line %A  ``%s`` failed rule %s" code_line (String.from_code_line code_line) rule

    let code_square_failed_rule_message (code_square: int array array) (rule: string) =
        sprintf "code square %A  ``%A`` failed rule %s" code_square (Strings.from_code_square code_square) rule




    let with_code_point_exception (code_point: int) (rule: string) =
        code_point_failed_rule_message code_point rule
        |> failwith

    let with_code_line_exception (code_line: int array) (rule: string) =
        code_line_failed_rule_message code_line rule
        |> failwith

    let with_code_square_exception (code_square: int array array) (rule: string) =
        code_square_failed_rule_message code_square rule
        |> failwith


    let with_code_point_none (code_point: int) (rule: string) =
        printfn "%s" (code_point_failed_rule_message code_point rule)
        None

    let with_code_line_none (code_line: int array) (rule: string) =
        printfn "%s" (code_line_failed_rule_message code_line rule)
        None

    let with_code_square_none (code_square: int array array) (rule: string) =
        printfn "%s" (code_square_failed_rule_message code_square rule)
        None

    let with_code_point_empty (code_point: int) (rule: string) =
        printfn "%s" (code_point_failed_rule_message code_point rule)
        [||]

    let with_code_line_empty (code_line: int array) (rule: string) =
        printfn "%s" (code_line_failed_rule_message code_line rule)
        [||]

    let with_code_square_empty (code_square: int array array) (rule: string) =
        printfn "%s" (code_square_failed_rule_message code_square rule)
        [||]


*)
