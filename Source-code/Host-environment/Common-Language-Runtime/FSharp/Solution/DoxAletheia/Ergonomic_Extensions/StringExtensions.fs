module DoxAletheia.StringExtensions

open System
open System.Globalization

open System.Text
open System.Net


type Code_Point = int
type Code_Line = Code_Point array
type Code_Square = Code_Line array
type Code_Cube = Code_Square array




type Char with
    member this.as_code_point: Code_Point = int this
    member this.as_code_line: Code_Line = [| this.as_code_point |]



type String with

    member this.rev = this |> Seq.rev |> Seq.toArray |> String
    /// just a crumb of humor to lighten the day
    member this.gnirts = this.rev

    member this.text_elements =
        let enumerator = StringInfo.GetTextElementEnumerator(this)

        [|


           while enumerator.MoveNext() do
               let element = enumerator.GetTextElement()
               yield element

           |]

    member this.grapheme_clusters =
        this.text_elements
        |> Array.map (fun text_element -> text_element.EnumerateRunes() |> Seq.toArray)



    member this.pretrimmed = this.TrimStart()
    member this.posttrimmed = this.TrimEnd()
    member this.circumtrimmed = this.TrimStart().TrimEnd()

    member this.Capitalized =

        if String.IsNullOrEmpty(this) then
            this
        else
            this
            |> Seq.mapi (fun characterIndex character ->
                match characterIndex with
                | 0 -> Char.ToUpperInvariant(character)
                | _ -> character)
            |> String.Concat



    member this.to_empty_option =

        try
            if not (String.IsNullOrWhiteSpace this) then
                Some(this)
            else
                None
        with
        | _ -> None

    member this.substring_between (prefix: string) (suffix: string) =
        let prefixIndex = this.IndexOf(prefix) + 1
        let suffixIndex = this.LastIndexOf(suffix) - 1

        match prefixIndex, suffixIndex with
        | from_prefix, to_suffix when prefixIndex <> -1 && suffixIndex <> -1 -> Some(this[from_prefix..to_suffix])
        | _ -> None

    member this.LastDelimitedSegment(delimiter: string) =

        let index = this.LastIndexOf(delimiter)

        if index = -1 then
            this // return the whole string if the delimiter is not found
        else
            this.Substring(index + 1)

    member this.first_substring_before_delimiter(delimiter: string) =
        let delimiterIndex = this.IndexOf delimiter

        if delimiterIndex > -1 then
            let to_delimiter = delimiterIndex - 1
            let substring = this.[0..to_delimiter]
            Some(substring)
        else
            None

    member this.until_char(delimiterCharacter: char) =
        this.ToCharArray()
        |> Array.takeWhile (fun character -> character <> delimiterCharacter)
        |> String


    member this.runes = this.EnumerateRunes() |> Seq.toArray

    member this.as_code_line: Code_Line =
        this.EnumerateRunes()
        |> Seq.toArray
        |> Array.map (fun rune -> rune.Value)

    member this.as_rune =
        this.EnumerateRunes()
        |> Seq.toArray
        |> Array.exactlyOne

    member this.as_code_point: Code_Point =
        let rune = this.as_rune
        rune.Value

    static member from_code_point(code_point: Code_Point) = Rune(code_point).ToString()

    static member from_code_line(code_line: Code_Line) =
        code_line
        |> Array.map (fun code_point -> Rune(code_point).ToString())
        |> String.concat ""

    member this.url_decoded = WebUtility.UrlDecode(this)
    member this.url_encoded = WebUtility.UrlEncode(this)
    member this.html_encoded = WebUtility.HtmlEncode(this)
    member this.html_decoded = WebUtility.HtmlDecode(this)

    member this.as_int_option =
        match Int32.TryParse this with
        | true, integer -> Some integer
        | false, _ -> None


module String =
    let as_code_point (string_value: string) = string_value.as_code_point
    let as_code_line (string_value: string) = string_value.as_code_line

module Strings =
    let from_code_square (code_square: Code_Square) =
        code_square |> Array.map String.from_code_line

    let from_code_cube (code_cube: Code_Cube) = code_cube |> Array.map from_code_square



module Code_Point =
    let from_char (char_: char) : Code_Point = Rune(char_).Value

module Code_Line =
    let from_chars (chars: char array) : Code_Line =
        chars
        |> Array.map (fun character -> int character)

    let from_chars_sorted (chars: char array) : Code_Line =
        chars
        |> Array.map (fun character -> int character)
        |> Array.sort
