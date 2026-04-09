open System
open System.Web


open System.Linq

open System.IO
open System.Globalization
open System.Text.RegularExpressions

#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"
#r "nuget: Fabulous.AST"


open FParsec
open FParsec.Pipes

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Metalanguage\Augmented_Backus_Naur_Form\Augmented_Backus_Naur_Form.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\WorldWideWeb\URISchemes.fsx"



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\ParsingErgonomics.fsx"

open ParsingErgonomics



// https://www.rfc-editor.org/rfc/rfc3986#section-2.2

/// sub-delims    = "!" / "$" / "&" / "'" / "(" / ")"
///             / "*" / "+" / "," / ";" / "="
let sub_delims: Parser<char, unit> =
    parser'withArgument'expecting
        anyOf
        "!$&'()*+,;="
        """
    sub-delims    = "!" / "$" / "&" / "'" / "(" / ")"
                / "*" / "+" / "," / ";" / "="
    """

runParser sub_delims OnString "abc"

/// gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
let gen_delims = anyOf "!$&'()*+,;="
/// reserved      = gen-delims / sub-delims
let reserved = gen_delims <|> sub_delims

/// unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
let unreserved =
    choice [

             Augmented_Backus_Naur_Form.Core_Rules.ALPHA
             Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             anyOf "-._~"

              ]




/// pct-encoded   = "%" HEXDIG HEXDIG
let pct_encoded =
    %% +.(pchar '%')
    -- +.Augmented_Backus_Naur_Form.Core_Rules.HEXDIG
    -- +.Augmented_Backus_Naur_Form.Core_Rules.HEXDIG
    -%> (fun percent leftHexDigit rightHexDigit ->
        let encodedLitral = $"{percent}{leftHexDigit}{rightHexDigit}"
        char (HttpUtility.UrlDecode encodedLitral)

        )

/// pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"

let path_char =
    choice [

             unreserved
             pct_encoded
             sub_delims
             anyOf ":@"

              ]

let subQueryFragment =
    choice [

             path_char
             anyOf "/?"

              ]

/// fragment      = *( pchar / "/" / "?" )
let hash_fragment =
    pchar '#' >>. zero_or_more subQueryFragment
    |>> string_from_charList

/// query         = *( pchar / "/" / "?" )

let question_query =
    pchar '?' >>. zero_or_more subQueryFragment
    |>> string_from_charList

/// segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" )
///             ; non-zero-length segment without any colon ":"

let segment_nz_nc =
    contiguous (
        choice [

                 unreserved
                 pct_encoded
                 sub_delims
                 pchar '@'

                  ]
    )
    |>> string_from_charList

/// segment-nz    = 1*pchar
let segment_nz = one_or_more path_char |>> string_from_charList

/// segment       = *pchar
let segment = zero_or_more path_char |>> string_from_charList

let path_delimiter = pstring "/"
/// path-abempty  = *( "/" segment )
let path_ab = path_delimiter >>. segment
let path_empty: string list = [ "" ]

/// path-abempty  = *( "/" segment )
let path_abempty = zero_or_more path_ab
(*
    |>> (fun char_list'list ->
        if char_list'list.Length > 0 then
            string'list_from_char_list'list char_list'list
        else
            [ "" ]

        )

*)
/// path-absolute = "/" [ segment-nz *( "/" segment ) ]
let segment_nz_segment = %% +.segment_nz -- +.path_abempty -%> prepend

/// path-absolute = "/" [ segment-nz *( "/" segment ) ]
let path_absolute =
    %%path_delimiter
    -- notFollowedBy path_delimiter
    -- +.(opt segment_nz_segment)
    -%> fun output -> defaultArg output []

/// path-noscheme = segment-nz-nc *( "/" segment )
let path_noscheme = %% +.segment_nz_nc -- +.path_abempty -%> prepend
/// path-rootless = segment-nz *( "/" segment )
let path_rootless = %% +.segment_nz -- +.path_abempty -%> prepend
// path-empty    = 0<pchar>
// let path_empty = zero_of path_char


let abempties =
    [

      ""
      "/"
      "/alpha"
      "/alpha/beta"
      "/alpha/beta/charlie"
      "/alpha//beta"
      "//alpha"
      "/alpha/"

      ]


let randomAbempty = abempties |> List.randomChoice
randomAbempty

let randomAbemptyResult = runParser path_abempty OnString randomAbempty
randomAbemptyResult

abempties
|> List.map (fun abempty -> runParser path_abempty OnString abempty)

let absolutes =
    [

      "/alpha"
      "/alpha/bravo"
      "/alpha/bravo/charlie"
      "/alpha/"
      "/"
      "/alpha//bravo"
      "//alpha"

      ]

let randomAbsolute = absolutes |> List.randomChoice
randomAbsolute

let randomAbsoluteResult = runParser path_absolute OnString randomAbsolute
randomAbsoluteResult

absolutes
|> List.map (fun absolute -> runParser path_absolute OnString absolute)

let noschemes =
    [

      "a"
      "a/b"
      "abc/def"
      "a-b_c.d"
      "abc123/xyz"
      "a:b"
      "a:/b"
      ":"

      ]

let randomNoScheme = noschemes |> List.randomChoice
randomNoScheme

let randomNoSchemeResult = runParser segment_nz_nc OnString randomNoScheme
randomNoSchemeResult

noschemes
|> List.map (fun noscheme -> runParser segment_nz_nc OnString noscheme)

let rootless =
    [ "alpha"
      "alpha/bravo"
      "alpha:bravo"
      "alpha:bravo/charlie"
      "alphabravocharlie:deltaechofoxtrot/golfhotelindigo"

      ]


let randomRootless = rootless |> List.randomChoice
randomRootless

let randomRootlessResult = runParser path_rootless OnString randomRootless
randomRootlessResult

rootless
|> List.map (fun noscheme -> runParser path_rootless OnString noscheme)



/// path          = path-abempty    ; begins with "/" or is empty
///              / path-absolute   ; begins with "/" but not "//"
///              / path-noscheme   ; begins with a non-colon segment
///              / path-rootless   ; begins with a segment
///              / path-empty      ; zero characters
let path =
    choice [

             path_abempty
             path_absolute
             path_noscheme
             path_rootless

              ]

/// reg-name      = *( unreserved / pct-encoded / sub-delims )

let reg_name =
    zero_or_more (
        choice [

                 unreserved
                 pct_encoded
                 sub_delims

                  ]
    )
    |>> string_from_charList


let dec_octet'1: Parser<char, unit> =
    (satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValue "%x31") "1")


let dec_octet'2: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValue "%x32") "2"

let dec_octet'5: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValue "%x35") "5"

let dec_octet'3_9: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValueRange "%x33-39") "3-9"

let dec_octet'0_4: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValueRange "%x30-34") "0-4"

let dec_octet'0_5: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValueRange "%x30-35") "0-5"

let dec_octet'1_9: Parser<char, unit> =
    satisfyL (Augmented_Backus_Naur_Form.Core_Rules.terminalCharValueRange "%x31-39") "1-9"

/// dec-octet     = DIGIT                 ; 0-9
let dec_octet'0_9 =
    Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    .>> notFollowedBy Augmented_Backus_Naur_Form.Core_Rules.DIGIT

    |>> int_from_singleDigit

///              / %x31-39 DIGIT         ; 10-99
let dec_octet'10_99 =
    %% +.dec_octet'1_9
    -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    -- notFollowedBy Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    -%> int_from_doubleDigit

///              / "1" 2DIGIT            ; 100-199
let dec_octet'100_199 =
    %% +.dec_octet'1
    -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    -%> int_from_tripleDigit

///              / "2" %x30-34 DIGIT     ; 200-249
let dec_octet'200_249 =
    %% +.dec_octet'2
    -- +.dec_octet'0_4
    -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    -%> int_from_tripleDigit

///              / "25" %x30-35          ; 250-255
let dec_octet'250_255: Parser<int, unit> =
    %% +.dec_octet'2
    -- +.dec_octet'5
    -- +.dec_octet'0_5
    -%> int_from_tripleDigit


/// dec-octet     = DIGIT                 ; 0-9
///              / %x31-39 DIGIT         ; 10-99
///              / "1" 2DIGIT            ; 100-199
///              / "2" %x30-34 DIGIT     ; 200-249
///              / "25" %x30-35          ; 250-255
let dec_octet =
    choice [

             attempt dec_octet'250_255
             attempt dec_octet'200_249
             attempt dec_octet'100_199
             attempt dec_octet'10_99
             dec_octet'0_9


              ]



let decocts =
    seq {
        for numeral in 0..256 do
            string numeral
    }

let decoctResults =
    decocts
    |> Seq.map (fun decoct -> runParser dec_octet OnString decoct)

decoctResults
|> Seq.iter (fun decoctResult -> Console.WriteLine decoctResult)

/// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
let IPv4address =
    %% +.dec_octet
    -- pchar '.'
    -- +.dec_octet
    -- pchar '.'
    -- +.dec_octet
    -- pchar '.'
    -- +.dec_octet
    -%> fun first second third fourth -> $"{first}.{second}.{third}.{fourth}"


runParser IPv4address OnString "170.85.130.100"

// maybe one day
// IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
//
// IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
//
// IPv6address   =                            6( h16 ":" ) ls32
//              /                       "::" 5( h16 ":" ) ls32
//              / [               h16 ] "::" 4( h16 ":" ) ls32
//              / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
//              / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
//              / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
//              / [ *4( h16 ":" ) h16 ] "::"              ls32
//              / [ *5( h16 ":" ) h16 ] "::"              h16
//              / [ *6( h16 ":" ) h16 ] "::"
//
// h16           = 1*4HEXDIG
// ls32          = ( h16 ":" h16 ) / IPv4address



/// port          = *DIGIT
let port =
    one_or_more Augmented_Backus_Naur_Form.Core_Rules.DIGIT
    |>> fun charList ->
            let stringNumeral = string_from_charList charList
            int_from_stringNumeral stringNumeral

let colon_port = pchar ':' >>. port

/// host          = IP-literal / IPv4address / reg-name
let host = IPv4address <|> reg_name

/// userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )

let userinfo =
    one_or_more (
        choice [

                 unreserved
                 pct_encoded
                 sub_delims
                 pchar ':'

                  ]
    )

let userinfo_at = userinfo .>> pchar '@' |>> string_from_charList

/// authority     = [ userinfo "@" ] host [ ":" port ]

let authority =
    %% +.(opt userinfo_at)
    -- +.host
    -- +.(opt colon_port)
    -%> (fun userinfoOption hostname portOption ->

        let userinfoComponent =
            match userinfoOption with
            | Some userinfo -> $"{userinfo}@"
            | _ -> String.Empty

        let portComponent =
            match portOption with
            | Some port -> $":{string port}"
            | _ -> String.Empty

        $"{userinfoComponent}{hostname}{portComponent}"

        )

/// scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
let schemeHead =
    Augmented_Backus_Naur_Form.Core_Rules.ALPHA
    |>> string

/// scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
let schemeTail =
    choice [

             Augmented_Backus_Naur_Form.Core_Rules.ALPHA
             Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             anyOf "+-."

              ]

/// scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
let scheme =
    %% +.schemeHead -- +.(zero_or_more schemeTail)
    -%> fun head tail -> $"{head}{string_from_charList tail}"

/// relative-part = "//" authority path-abempty
///              / path-absolute
///              / path-noscheme
///              / path-empty
let authority_abempty =
    %%pstring "//" -- +.authority -- +.path_abempty
    -%> fun authorityString abemptyList -> authorityString :: abemptyList

/// relative-part = "//" authority path-abempty
///              / path-absolute
///              / path-noscheme
///              / path-empty
let relative_part =
    opt (
        choice [

                 authority_abempty
                 path_absolute
                 path_noscheme

                  ]
    )
    |>> fun relative_partOption -> defaultArg relative_partOption path_empty

/// relative-ref  = relative-part [ "?" query ] [ "#" fragment ]
let relative_ref =
    %% +.relative_part
    -- +.(opt question_query)
    -- +.(opt hash_fragment)
    -%> auto

/// hier-part     = "//" authority path-abempty
///              / path-absolute
///              / path-rootless
///              / path-empty
let hier_part =
    opt (
        choice [

                 authority_abempty
                 path_absolute
                 path_rootless

                  ]
    )
    |>> fun hier_partOption -> defaultArg hier_partOption path_empty

/// absolute-URI  = scheme ":" hier-part [ "?" query ]
let absolute_URI =
    %% +.scheme
    -- pchar ':'
    -- +.hier_part
    -- +.(opt question_query)
    -%> auto

/// URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
let URI =

    %% +.scheme
    -- pchar ':'
    -- +.hier_part
    -- +.(opt question_query)
    -- +.(opt hash_fragment)
    -%> auto

let testURI = "http://localhost/"
let testResult = runParser (contiguous question_query) OnString ""
