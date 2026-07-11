open System
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"
open StringExtensions

let (|Integer_String|_|) (input: string) =
    match Int32.TryParse input with

    | true, integer -> Some input
    | false, _ -> None

let (|First_substring_before_delimiter|_|) (delimiter: string) (superstring: string) =
    superstring.first_substring_before_delimiter delimiter
