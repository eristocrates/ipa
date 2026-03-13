// https://datatracker.ietf.org/doc/html/rfc5234#appendix-B.1

#if INTERACTIVE
#r "nuget: FParsec"
#endif

open System
open FParsec


let tryParseHex (text: string) =
    match Int32.TryParse(text, Globalization.NumberStyles.HexNumber, Globalization.CultureInfo.InvariantCulture) with
    | true, value when value >= 0 && value <= 0xFFFF -> Some value
    | _ -> None

// https://datatracker.ietf.org/doc/html/rfc5234#section-2.3
let terminalCharValue (terminal: string) : (char -> bool) =
    match if String.IsNullOrEmpty terminal then
              None
          elif terminal.StartsWith("%x", StringComparison.OrdinalIgnoreCase) then
              let hex = terminal.Substring(2)

              match
                  Int32.TryParse
                      (
                          hex,
                          Globalization.NumberStyles.HexNumber,
                          Globalization.CultureInfo.InvariantCulture
                      )
                  with
              | true, value when value >= 0 && value <= 0xFFFF -> Some value
              | _ -> None
          else
              None
        with
    | Some value -> fun character -> int character = value
    | None -> invalidArg (nameof terminal) $"Invalid single terminal value: {terminal}"

let terminalCharValueRange (terminal: string) : char -> bool =
    if not (terminal.StartsWith("%x", StringComparison.OrdinalIgnoreCase)) then
        invalidArg (nameof terminal) (@"Expected %x... range terminal, got: " + terminal)

    let body = terminal.Substring(2)
    let pieces = body.Split('-')

    if pieces.Length <> 2 then
        invalidArg
            (nameof terminal)
            (@"Expected a single range like %x00-1F, got: "
             + terminal)


    match tryParseHex pieces[0], tryParseHex pieces[1] with
    | Some lowerBound, Some upperBound when lowerBound <= upperBound ->
        fun character ->
            let codePoint = int character
            lowerBound <= codePoint && codePoint <= upperBound
    | Some _, Some _ -> invalidArg (nameof terminal) $"Range lower bound exceeds upper bound: {terminal}"
    | _ -> invalidArg (nameof terminal) $"Invalid hex range terminal: {terminal}"



let ALPHA: Parser<char, unit> =
    choice [ satisfyL (terminalCharValueRange "%x41-5A") "A-Z"
             satisfyL (terminalCharValueRange "%x61-7A") "a-z" ]

let BIT: Parser<char, unit> = anyOf "01" // "0" / "1"

let CHAR: Parser<char, unit> =
    satisfyL (terminalCharValueRange "%x01-7F") "any 7-bit US-ASCII character, excluding NUL"

let CR: Parser<char, unit> = satisfyL (terminalCharValue "%x7F") "carriage return"
let LF: Parser<char, unit> = satisfyL (terminalCharValue "%x0A") "line feed" // %x0A ; linefeed

let CRLF: Parser<char * char, unit> = CR .>>. LF // ; Internet standard newline

let CTL: Parser<char, unit> =
    choice [ satisfyL (terminalCharValueRange "%x00-1F") "control characters"
             satisfyL (terminalCharValue "%x7F") "control character" ]

let DIGIT: Parser<char, unit> = satisfyL (terminalCharValueRange "%x30-39") "0-9"

let DQUOTE: Parser<char, unit> = satisfyL (terminalCharValue "%x22") "Double Quote"

let HEXDIG: Parser<char, unit> = choice [ DIGIT; anyOf "ABCDEF" ]

let HTAB: Parser<char, unit> = satisfyL (terminalCharValue "%x09") "horizontal tab"



let SP: Parser<char, unit> = satisfyL (terminalCharValue "%x20") "space"
let WSP: Parser<char, unit> = choice [ SP; HTAB ]

let LWSP: Parser<char, unit> = WSP (* (WSP / CRLF WSP)
                      ; Use of this linear-white-space rule
                      ;  permits lines containing only white
                      ;  space that are no longer legal in
                      ;  mail headers and have caused
                      ;  interoperability problems in other
                      ;  contexts.
                      ; Do not use when defining mail
                      ;  headers and use with caution in
                      ;  other contexts.
                  *)

let OCTET: Parser<char, unit> =
    satisfyL (terminalCharValueRange "%x00-FF") "8 bits of data"


let VCHAR: Parser<char, unit> =
    satisfyL (terminalCharValueRange "%x21-7E") "visible (printing) characters"


let runTest (input: string) =
    match run (many ALPHA) input with
    | Success (result, userState, position) ->
        Console.WriteLine $"Success\tresult: {result}, userState: {userState}, position: {position}"
    | Failure (inputString, error, userState) ->
        Console.WriteLine $"Failure\tresult: {inputString}, error: {error}, userState: {userState}"

runTest "test"
