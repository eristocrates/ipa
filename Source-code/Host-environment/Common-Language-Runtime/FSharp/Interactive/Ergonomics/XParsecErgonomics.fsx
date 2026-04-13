open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

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

let parse_rune (char_: char) = pitem (Rune char_)
let skip_rune (char_: char) = skipItem (Rune char_)

let runes_from_string (text: string) = text.EnumerateRunes() |> Seq.toArray

let parse_expecting parse (expecting: string) = parse <??> expecting



type Adposition = | OnInput

let run_parse parse (adposition: Adposition) (input: string) =
    let runes = input |> runes_from_string
    let text = Reader.ofArray runes ()
    parse text
