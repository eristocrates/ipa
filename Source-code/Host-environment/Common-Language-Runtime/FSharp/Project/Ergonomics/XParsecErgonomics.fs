module Ergonomics.XParsecErgonomics

open System
open System.Text
open System.IO
open System.Globalization

open XParsec
open XParsec.Parsers
open System.Collections.Immutable

type Rune_Representation =
    abstract member rune_representation: Rune

type Character =
    { as_rune: Rune }
    interface Rune_Representation with
        member this.rune_representation = this.as_rune

let anyRune (string_chars: string) =
    string_chars.ToCharArray()
    |> Array.map (fun char_ -> Rune char_)
    |> anyOf

let inline string_from_characters<^CharacterType when ^CharacterType: (member as_rune: Rune)>(elements: seq<^CharacterType>) =
        elements
        |> Seq.toArray
        |> Array.map (fun character -> char character.as_rune.Value)
        |> String
let inline string_from_segments<^SegmentType when ^SegmentType: (member as_string: string)>(segments:ImmutableArray<^SegmentType>) =
            if segments.IsEmpty then
                String.Empty
            else
                "/"
                + (segments
                   |> Seq.map (fun segment -> segment.as_string)
                   |> String.concat "/")

let parse_rune (char_: char) = pitem (Rune char_)
let skip_rune (char_: char) = skipItem (Rune char_)

let runes_from_string (text: string) = text.EnumerateRunes() |> Seq.toArray

let parse_expecting parse (expecting: string) = parse <??> expecting



type Adposition = | OnInput

let run_partial_parse parse (adposition: Adposition) (input: string) =
    let runes = input |> runes_from_string
    let text = Reader.ofArray runes ()
    parse text

let run_full_parse parse (adposition: Adposition) (input: string) =
    let runes = input |> runes_from_string
    let text = Reader.ofArray runes ()
    (parse .>> eof) text
let result_from_parse parse (adposition: Adposition) (input: string) =
    let runes = input |> runes_from_string
    let text = Reader.ofArray runes ()
    let (Result.Ok result) = (parse .>> eof) text
    result
let error_from_parse parse (adposition: Adposition) (input: string) =
    let runes = input |> runes_from_string
    let text = Reader.ofArray runes ()
    let (Result.Error result) = (parse .>> eof) text
    result
     

let int_from_stringNumeral(stringNumeral: string) =
        match System.Int32.TryParse(stringNumeral) with
        | true, intNumeral -> intNumeral
        | _ -> failwithf "Invalid numeral string: %s" stringNumeral

let intNumeral_from_RuneNumeral(RuneNumeral: Rune) =
        int_from_stringNumeral (string RuneNumeral)

let int_from_singleDigit(singleDigit: Rune) =
        int_from_stringNumeral (string singleDigit) 

let int_from_doubleDigit (leftDigit: Rune) (rightDigit: Rune) =
        int_from_stringNumeral $"{leftDigit}{rightDigit}" 

let int_from_tripleDigit (leftDigit: Rune) (centerDigit: Rune) (rightDigit: Rune) =
        int_from_stringNumeral $"{leftDigit}{centerDigit}{rightDigit}" 
