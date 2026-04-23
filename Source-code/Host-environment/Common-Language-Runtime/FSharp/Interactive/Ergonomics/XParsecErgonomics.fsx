open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers
open System.Collections.Immutable



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\UnicodeStandard.fsx"
open UnicodeStandard

let unicodepoint_from
    (partition: Unicode_Partition)
    : Parser<Unicodepoint, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
    satisfy (fun unicodepoint -> unicodepoint.is'member_of partition.unicodepoint_set)

let unicodepoint_not_from
    (partition: Unicode_Partition)
    : Parser<Unicodepoint, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
    satisfy (fun unicodepoint -> not (unicodepoint.is'member_of partition.unicodepoint_set))

let parse_unicodepoint (input: char) =
    let input_value = (Rune input).Value
    pitem (Unicodepoint.from'int input_value)

let skip_unicodepoint (input: char) =
    let input_value = (Rune input).Value
    skipItem (Unicodepoint.from'int input_value)


type Adposition = | OnInput



let parse_expecting parse (expecting: string) = parse <??> expecting



let run'partial_parse parse (adposition: Adposition) (raw_string: string) =
    let codepoint_array = Unicodepoint.array'from'string raw_string
    let codepoints = Reader.ofArray codepoint_array ()
    parse codepoints

let run'full_parse parse (adposition: Adposition) (raw_string: string) =
    let codepoint_array = Unicodepoint.array'from'string raw_string
    let codepoints = Reader.ofArray codepoint_array ()
    (parse .>> eof) codepoints

let result'from_parse parse (adposition: Adposition) (raw_string: string) =
    let codepoint_array = Unicodepoint.array'from'string raw_string
    let codepoints = Reader.ofArray codepoint_array ()
    let (Result.Ok result) = (parse .>> eof) codepoints
    result

let error'from_parse parse (adposition: Adposition) (raw_string: string) =
    let codepoint_array = Unicodepoint.array'from'string raw_string
    let codepoints = Reader.ofArray codepoint_array ()
    let (Result.Error result) = (parse .>> eof) codepoints
    result
