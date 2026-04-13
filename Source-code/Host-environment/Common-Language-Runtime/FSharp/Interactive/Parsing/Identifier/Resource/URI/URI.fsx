open System
open System.Web
open System.Text
open System.IO
open System.Globalization



#r @"nuget: FSharpPlus"

// open FSharpPlus
open FSharpPlus.Data

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Metalanguage\ABNF\ABNF.fsx"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics



type Subcomponent_Delimiter_Character =
    { as_rune: Rune }

    static member parse: Parser<Subcomponent_Delimiter_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (anyRune "!$&'()*+,;="
             |>> fun rune -> { as_rune = rune })
            """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """

type General_Component_Delimiter_Character =
    { as_rune: Rune }


    static member parse: Parser<General_Component_Delimiter_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (anyRune ":/?#[]@"
             |>> fun rune -> { as_rune = rune })
            """ gen-delims  = ":" / "/" / "?" / "#" / "[" / "]" / "@" """

[<RequireQualifiedAccess>]
type Unreserved_Character =
    | FromALPHA of ABNF.ALPHA
    | FromDIGIT of ABNF.DIGIT
    | FromRune of Rune
    member this.as_rune =

        match this with
        | FromALPHA alpha -> alpha.as_rune
        | FromDIGIT digit -> digit.as_rune
        | FromRune rune -> rune

    static member parse: Parser<Unreserved_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      ABNF.ALPHA.parse |>> FromALPHA
                      ABNF.DIGIT.parse |>> FromDIGIT
                      anyRune "-._~" |>> FromRune

                       ])

            """ unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" """

[<RequireQualifiedAccess>]
type Reserved_Character =
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character
    | FromGeneralComponentDelimiterCharacter of General_Component_Delimiter_Character

    member this.as_rune =
        match this with
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | FromGeneralComponentDelimiterCharacter general_component_delimiter_character ->
            general_component_delimiter_character.as_rune

    static member parse: Parser<Reserved_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Subcomponent_Delimiter_Character.parse
                      |>> FromSubcomponentDelimiterCharacter
                      General_Component_Delimiter_Character.parse
                      |>> FromGeneralComponentDelimiterCharacter


                       ])

            """ reserved      = gen-delims / sub-delims """




type Percent_Encoded_Character =
    {

      left_digit: ABNF.HEXDIGIT
      right_digit: ABNF.HEXDIGIT
      as_literal: string
      as_rune: Rune

     }

    static member parse: Parser<Percent_Encoded_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                do! skip_rune '%'
                let! leftHexDigit = ABNF.HEXDIGIT.parse
                let! rightHexDigit = ABNF.HEXDIGIT.parse

                return (leftHexDigit, rightHexDigit)

             }
             |>> (fun (leftHexDigit, rightHexDigit) ->
                 let encodedLiteral = $"%%{leftHexDigit.as_rune}{rightHexDigit.as_rune}"
                 let rune = Rune(char (HttpUtility.UrlDecode encodedLiteral))

                 {

                   left_digit = leftHexDigit
                   right_digit = rightHexDigit
                   as_rune = rune
                   as_literal = encodedLiteral

                 })

            )

            """pct-encoded   = "%" HEXDIG HEXDIG"""


[<RequireQualifiedAccess>]
type Path_Character =
    | FromUnreservedCharacter of Unreserved_Character
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character
    | FromCharacter of Character

    member this.as_rune =
        match this with
        | FromUnreservedCharacter unreserved_character -> unreserved_character.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | FromCharacter character -> character.as_rune

    static member parse: Parser<Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        choice [

                 Unreserved_Character.parse
                 |>> FromUnreservedCharacter
                 Percent_Encoded_Character.parse
                 |>> FromPercentEncodedCharacter
                 Subcomponent_Delimiter_Character.parse
                 |>> FromSubcomponentDelimiterCharacter
                 anyRune ":@"
                 |>> fun rune -> FromCharacter { as_rune = rune } ]


[<RequireQualifiedAccess>]
type NonColon_Path_Character =
    | FromUnreservedCharacter of Unreserved_Character
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character
    | FromCharacter of Character

    member this.as_rune =
        match this with
        | FromUnreservedCharacter unreserved_character -> unreserved_character.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | FromCharacter character -> character.as_rune

    static member parse: Parser<NonColon_Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        choice [

                 Unreserved_Character.parse
                 |>> FromUnreservedCharacter
                 Percent_Encoded_Character.parse
                 |>> FromPercentEncodedCharacter
                 Subcomponent_Delimiter_Character.parse
                 |>> FromSubcomponentDelimiterCharacter
                 anyRune "@"
                 |>> fun rune -> FromCharacter { as_rune = rune } ]



type Segment = Path_Character seq
type NonEmpty_Segment = NonEmptySeq<Path_Character>
type NonColon_NonEmpty_Segment = NonEmptySeq<NonColon_Path_Character>
let test = run_parse Percent_Encoded_Character.parse OnInput "%21"
