open System
open System.Linq
open System.Text

let trimmedString (inputString: string) = inputString.TrimStart().TrimEnd()


let Capitalize (input: string) =
    if String.IsNullOrEmpty(input) then
        input
    else
        input

        |> Seq.mapi (fun characterIndex character ->
            match characterIndex with
            | 0 -> Char.ToUpper(character)
            | _ -> character)
        |> String.Concat

let lastSectionOfString (input: string) (delimeter: string) =
    let index = input.LastIndexOf(delimeter)

    if index = -1 then
        input // return the whole string if the delimiter is not found
    else
        input.Substring(index + 1)


let period character = character = '.'

[<RequireQualifiedAccess>]
type Affix =
    | prefix of string
    | postfix of string

let reverseString (input: string) =
    input.Reverse() |> Seq.toArray |> String

/// just a crumb of humor to lighten the day
let gnirts = reverseString

let from_string_start = 0


let nonEmptyString (rawString: string) =

    try
        if not (String.IsNullOrWhiteSpace rawString) then
            Some(rawString)
        else
            None
    with
    | _ -> None

let substringFromCircumfix (prefix: string) (superstring: string) (suffix: string) =
    let prefixIndex = superstring.IndexOf(prefix) + 1
    let suffixIndex = superstring.LastIndexOf(suffix) - 1

    match prefixIndex, suffixIndex with
    | from_prefix, to_suffix when prefixIndex <> -1 && suffixIndex <> -1 -> Some(superstring[from_prefix..to_suffix])
    | _ -> None



let firstSubstringBeforeDelimiter (delimiter: string) (superstring: string) =
    let delimiterIndex = superstring.IndexOf delimiter

    if delimiterIndex > -1 then
        let to_delimiter = delimiterIndex - 1
        let substring = superstring.[from_string_start..to_delimiter]
        Some(substring)
    else
        None





let stringUntilDelimiterCharacter (superstring: string) (delimiterCharacter: char) =
    superstring.ToCharArray()
    |> Array.takeWhile (fun character -> character <> delimiterCharacter)
    |> System.String





let (|First_substring_before_delimiter|_|) (delimiter: string) (superstring: string) =
    firstSubstringBeforeDelimiter delimiter superstring
