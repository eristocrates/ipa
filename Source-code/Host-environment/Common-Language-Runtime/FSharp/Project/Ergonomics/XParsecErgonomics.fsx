open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers
open System.Collections.Immutable



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\UnicodeStandard\UnicodeStandard.fsx"
open UnicodeStandard

let unicodepoint_from
    (partition: Unicode_Partition)
    : Parser<Unicodepoint, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
    satisfy (fun unicodepoint -> unicodepoint.is'member_of partition.unicodepoint_set)

let parse_unicodepoint (input: char) = pitem (Unicodepoint.from'char input)

let skip_unicodepoint (input: char) = skipItem (Unicodepoint.from'char input)

type Adposition = | OnInput

let run'partial_parse parse (adposition: Adposition) (raw_string: string) =
    let codepoint_array = Unicodepoint.array'from'string raw_string
    let codepoints = Reader.ofArray codepoint_array ()
    parse codepoints


let parse_expecting parse (expecting: string) = parse <??> expecting

(*

let any_unicodepoint (input: string) =
    'from'string input |> anyOf

let parse_unicodepoint (input: string) =
    unicodepoints'from'string input
    |> Array.map (fun unicodepoint -> pitem unicodepoint)

let skip_unicodepoint (input: string) =
    unicodepoints'from'string input
    |> Array.map (fun unicodepoint -> skipItem unicodepoint)






let run_partial_parse parse (adposition: Adposition) (input: string) =
    let unicodepoints = unicodepoints'from'string input
    let text = Reader.ofArray unicodepoints ()
    parse text

let run_full_parse parse (adposition: Adposition) (input: string) =
    let unicodepoints = unicodepoints'from'string input
    let text = Reader.ofArray unicodepoints ()
    (parse .>> eof) text

let result_from_parse parse (adposition: Adposition) (input: string) =
    let unicodepoints = unicodepoints'from'string input
    let text = Reader.ofArray unicodepoints ()
    let (Result.Ok result) = (parse .>> eof) text
    result

let error_from_parse parse (adposition: Adposition) (input: string) =
    let unicodepoints = unicodepoints'from'string input
    let text = Reader.ofArray unicodepoints ()
    let (Result.Error result) = (parse .>> eof) text
    result


let int_from_stringNumeral (stringNumeral: string) =
    match System.Int32.TryParse(stringNumeral) with
    | true, intNumeral -> intNumeral
    | _ -> failwithf "Invalid numeral string: %s" stringNumeral

let intNumeral_from_RuneNumeral (RuneNumeral: Rune) =
    int_from_stringNumeral (string RuneNumeral)

let int_from_singleDigit (singleDigit: Rune) =
    int_from_stringNumeral (string singleDigit)

let int_from_doubleDigit (leftDigit: Rune) (rightDigit: Rune) =
    int_from_stringNumeral $"{leftDigit}{rightDigit}"

let int_from_tripleDigit (leftDigit: Rune) (centerDigit: Rune) (rightDigit: Rune) =
    int_from_stringNumeral $"{leftDigit}{centerDigit}{rightDigit}"
*)
