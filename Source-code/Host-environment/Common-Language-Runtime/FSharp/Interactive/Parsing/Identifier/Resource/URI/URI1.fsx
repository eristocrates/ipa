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

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\FsharpErgonomics.fsx"
open FsharpErgonomics


























type Character =
    abstract member as_char: char

type QueryFragment_Character =
    inherit Character



type Unreserved_Character =
    inherit Character


type Reserved_Character =
    inherit Character

type Subcomponent_Delimiter_Character =
    inherit Reserved_Character

type General_Component_Delimiter_Character =
    inherit Reserved_Character

type Path_Delimiter_Character =
    inherit General_Component_Delimiter_Character


type Percent_Encoded_Character =
    inherit Character
    abstract member left_digit: char
    abstract member right_digit: char
    abstract member as_literal: string

[<RequireQualifiedAccess>]
type Registered_Name_Character =
    | From_Unreserved_Character of Unreserved_Character
    | From_Subcomponent_Delimiter_Character of Subcomponent_Delimiter_Character
    | From_Percent_Encoded_Character of Percent_Encoded_Character
    member this.as_char =
        match this with
        | From_Unreserved_Character unreserved_character -> unreserved_character.as_char
        | From_Subcomponent_Delimiter_Character subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_char
        | From_Percent_Encoded_Character percent_encoded_character -> percent_encoded_character.as_char


[<RequireQualifiedAccess>]
type PathSegment_Character =
    | From_Character of Character
    | From_Percent_Encoded_Character of Percent_Encoded_Character
    | From_Subcomponent_Delimiter_Character of Subcomponent_Delimiter_Character
    | From_Unreserved_Character of Unreserved_Character
    member this.as_char =
        match this with
        | From_Percent_Encoded_Character percent_encoded_character -> percent_encoded_character.as_char
        | From_Subcomponent_Delimiter_Character subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_char
        | From_Unreserved_Character unreserved_character -> unreserved_character.as_char
// TODO consider typing head vs tail?
type Scheme_Character =
    inherit Character


type Decimal_Numeral =
    abstract member as_int: int

type Decimal_Octet =
    inherit Decimal_Numeral

type Port =
    inherit Decimal_Numeral


type Component =
    abstract member as_string: string

// https://www.rfc-editor.org/rfc/rfc3986#section-2.2

type Fragment =
    inherit Component
    abstract member fragment_sequence: QueryFragment_Character seq

// TODO handle key value query strings
type Query =
    inherit Component
    abstract member query_sequence: QueryFragment_Character seq
// abstract member mapping: Map<string,string>
// abstract member keys: string set
// abstract member values: string set

type Segment =
    inherit Component
    abstract member segment_character_sequence: PathSegment_Character seq

type NonZero_Segment =
    inherit Segment

type NonZero_NonColon_Segment =
    inherit NonZero_Segment


type Registered_Name =
    inherit Component
    abstract member registered_name_character_sequence: Registered_Name_Character seq

type IPv4address =
    inherit Component
    abstract member outer_left_octet: Decimal_Octet
    abstract member inner_left_octet: Decimal_Octet
    abstract member inner_right_octet: Decimal_Octet
    abstract member outer_right_octet: Decimal_Octet

[<RequireQualifiedAccess>]
type Host =
    | From_Registered_Name of Registered_Name
    | From_IPv4address of IPv4address
    member this.as_string =
        match this with
        | From_Registered_Name registered_name -> registered_name.as_string
        | From_IPv4address ipv4address -> ipv4address.as_string


type UserInfo =
    inherit Component
    abstract member userinfo_character_sequence: PathSegment_Character seq

type Authority =
    inherit Component
    abstract member userinfo: UserInfo option
    abstract member host: Host
    abstract member port: Port option

type Scheme =
    inherit Component
    abstract member scheme_character_sequence: Scheme_Character seq




type Path_ =
    inherit Component
    abstract member segment_sequence: Segment seq


type Empty_Path =
    inherit Path_
    inherit Component


type Abempty_Path =
    inherit Path_

type Tailed_Path =
    inherit Path_
    abstract member tail_segment_sequence: Segment seq

type NonZero_Path =
    inherit Tailed_Path
    abstract member head_segment: NonZero_Segment

type NoScheme_Path =
    inherit Tailed_Path
    inherit Component
    abstract member head_segment: NonZero_NonColon_Segment

type Rootless_Path =
    inherit Tailed_Path
    abstract member head_segment: NonZero_Segment

type Absolute_Path =
    inherit Path_
    inherit Component
    abstract member nonzero_path: NonZero_Path option

type Network_Path =
    inherit Component
    abstract member network_authority: Authority
    abstract member abempty_path: Abempty_Path option


[<RequireQualifiedAccess>]
type Relative_Part =
    | From_Empty_Path of Empty_Path
    | From_NoScheme_Path of NoScheme_Path
    | From_Absolute_Path of Absolute_Path
    | From_Network_Path of Network_Path
    member this.as_string =
        match this with
        | From_Empty_Path empty_path -> empty_path.as_string
        | From_NoScheme_Path noscheme_path -> noscheme_path.as_string
        | From_Absolute_Path absolute_path -> absolute_path.as_string
        | From_Network_Path network_path -> network_path.as_string

[<RequireQualifiedAccess>]
type Hierarchical_Part =
    | From_Empty_Path of Empty_Path
    | From_Rootless_Path of Rootless_Path
    | From_Absolute_Path of Absolute_Path
    | From_Network_Path of Network_Path
    member this.as_string =
        match this with
        | From_Empty_Path empty_path -> empty_path.as_string
        | From_Rootless_Path rootless_path -> rootless_path.as_string
        | From_Absolute_Path absolute_path -> absolute_path.as_string
        | From_Network_Path network_path -> network_path.as_string




type URI_Reference =
    inherit Component

type Relative_Reference =
    inherit URI_Reference
    abstract member relative_part: Relative_Part
    abstract member query: Query option
    abstract member fragment: Fragment option

type Absolute_URI =
    inherit Component
    abstract member scheme: Scheme
    abstract hierarchical_part: Hierarchical_Part
    abstract member query: Query option

type URI =
    inherit Absolute_URI
    inherit URI_Reference
    abstract member fragment: Fragment option







addInterfacePrinter<Character> ()
addInterfacePrinter<QueryFragment_Character> ()
addInterfacePrinter<PathSegment_Character> ()
addInterfacePrinter<Registered_Name_Character> ()
addInterfacePrinter<Unreserved_Character> ()
addInterfacePrinter<Reserved_Character> ()
addInterfacePrinter<Subcomponent_Delimiter_Character> ()
addInterfacePrinter<General_Component_Delimiter_Character> ()
addInterfacePrinter<Path_Delimiter_Character> ()
addInterfacePrinter<Percent_Encoded_Character> ()
addInterfacePrinter<Scheme_Character> ()

addInterfacePrinter<Decimal_Numeral> ()
addInterfacePrinter<Decimal_Octet> ()
addInterfacePrinter<Port> ()

addInterfacePrinter<Component> ()
addInterfacePrinter<Fragment> ()
addInterfacePrinter<Query> ()
addInterfacePrinter<Segment> ()
addInterfacePrinter<NonZero_Segment> ()
addInterfacePrinter<NonZero_NonColon_Segment> ()

addInterfacePrinter<Host> ()
addInterfacePrinter<Registered_Name> ()
addInterfacePrinter<IPv4address> ()

addInterfacePrinter<UserInfo> ()
addInterfacePrinter<Authority> ()
addInterfacePrinter<Scheme> ()

addInterfacePrinter<Hierarchical_Part> ()
addInterfacePrinter<Relative_Part> ()
addInterfacePrinter<Path_> ()
addInterfacePrinter<Empty_Path> ()
addInterfacePrinter<Abempty_Path> ()
addInterfacePrinter<Tailed_Path> ()
addInterfacePrinter<NonZero_Path> ()
addInterfacePrinter<NoScheme_Path> ()
addInterfacePrinter<Rootless_Path> ()
addInterfacePrinter<Absolute_Path> ()
addInterfacePrinter<Network_Path> ()

addInterfacePrinter<URI_Reference> ()
addInterfacePrinter<Relative_Reference> ()
addInterfacePrinter<Absolute_URI> ()
addInterfacePrinter<URI> ()









module Character =
    let from_char (char_: char) =
        { new Character with
            member this.as_char = char_ }


module Subcomponent_Delimiter_Character =
    /// sub-delims    = "!" / "$" / "&" / "'" / "(" / ")"
    ///             / "*" / "+" / "," / ";" / "="
    let parser: Parser<Subcomponent_Delimiter_Character, unit> =
        parser_expecting
            (anyOf "!$&'()*+,;="
             |>> (fun char_ ->
                 { new Subcomponent_Delimiter_Character with
                     member this.as_char = char_ }))
            """
    sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "="
            """



module General_Component_Delimiter_Character =


    /// gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
    let parser: Parser<General_Component_Delimiter_Character, unit> =
        parser_expecting
            (anyOf ":/?#[]@"
             |>> (fun char_ ->
                 { new General_Component_Delimiter_Character with
                     member this.as_char = char_ }))
            """
gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
"""

    let from_input (input: string) =
        let output_result = apply_parser parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())


// reserved      = gen-delims / sub-delims
// let reserved = gen_delims <|> sub_delims

module Unreserved_Character =
    /// unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
    let parser =
        parser_expecting
            (choice [

                      Augmented_Backus_Naur_Form.Core_Rules.ALPHA
                      Augmented_Backus_Naur_Form.Core_Rules.DIGIT
                      anyOf "-._~"

                       ]
             |>> (fun char_ ->
                 { new Unreserved_Character with
                     member this.as_char = char_ })

            )
            """
    unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                """

    let from_input (input: string) =
        let output_result = apply_parser parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())



module Percent_Encoded_Character =

    /// pct-encoded   = "%" HEXDIG HEXDIG
    let parser =
        parser_expecting
            (%%pchar '%'
             -- +.Augmented_Backus_Naur_Form.Core_Rules.HEXDIG
             -- +.Augmented_Backus_Naur_Form.Core_Rules.HEXDIG
             -%> (fun leftHexDigit rightHexDigit ->
                 let encodedLiteral = $"%%{leftHexDigit}{rightHexDigit}"

                 { new Percent_Encoded_Character with
                     member this.as_char = char (HttpUtility.UrlDecode encodedLiteral)
                     member this.left_digit = leftHexDigit
                     member this.right_digit = rightHexDigit
                     member this.as_literal = encodedLiteral }

                 ))
            """
    pct-encoded   = "%" HEXDIG HEXDIG
            """

    let from_input (input: string) =
        let output_result = apply_parser parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())

module PathSegment_Character =

    let from_char (char_: char) =
        PathSegment_Character.From_Character(Character.from_char char_)


    /// pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
    let parser: Parser<PathSegment_Character, unit> =
        parser_expecting
            (choice [ anyOf ":@" |>> from_char
                      Unreserved_Character.parser
                      |>> PathSegment_Character.From_Unreserved_Character
                      Percent_Encoded_Character.parser
                      |>> PathSegment_Character.From_Percent_Encoded_Character
                      Subcomponent_Delimiter_Character.parser
                      |>> PathSegment_Character.From_Subcomponent_Delimiter_Character


                       ])
            """
    pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                """

    let from_input (input: string) =
        let output_result = apply_parser parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())

/// ( pchar / "/" / "?" )
module QueryFragment_Character =
    let from_char (char_: char) =
        { new QueryFragment_Character with
            member this.as_char = char_ }

    let parser: Parser<QueryFragment_Character, unit> =
        choice [

                 PathSegment_Character.parser
                 |>> fun pathSegment_character -> from_char pathSegment_character.as_char
                 anyOf "/?" |>> from_char

                  ]

    let from_input (input: string) =
        let output_result = apply_parser parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())

module Fragment =
    let string_from_option (fragment_option: Fragment option) =
        match fragment_option with
        | Some fragment -> $"#{fragment.as_string}"
        | _ -> String.Empty

    /// fragment      = *( pchar / "/" / "?" )
    let parser =
        parser_expecting
            (zero_or_more QueryFragment_Character.parser
             |>> (fun queryFragmentList ->
                 let queryFragmentString =
                     queryFragmentList
                     |> List.map (fun queryFragment_character -> queryFragment_character


                     )

                 { new Fragment with
                     member this.as_string =
                         queryFragmentList
                         |> List.map (fun queryFragmentCharacter -> queryFragmentCharacter.as_char)
                         |> List.toArray
                         |> String

                     member this.fragment_sequence = queryFragmentList |> List.toSeq }

                 ))
            """
    fragment      = *( pchar / "/" / "?" )
        """

    module hash_prefixed =
        let parser = parser_expecting (pchar '#' >>. parser) """ [ "#" fragment ] """



module Query =

    let string_from_option (query_option: Query option) =
        match query_option with
        | Some query -> $"#{query.as_string}"
        | _ -> String.Empty

    /// query         = *( pchar / "/" / "?" )
    let parser =
        parser_expecting
            (zero_or_more QueryFragment_Character.parser
             |>> (fun queryFragmentList ->
                 { new Query with
                     member this.as_string =
                         queryFragmentList
                         |> List.map (fun queryFragmentCharacter -> queryFragmentCharacter.as_char)
                         |> List.toArray
                         |> String

                     member this.query_sequence = queryFragmentList |> List.toSeq }


                 ))
            """
    query         = *( pchar / "/" / "?" )
        """

    module questionmark_prefixed =
        let parser = parser_expecting (pchar '?' >>. parser) """ [ "?" query ] """


// TODO account for other delimiters, ? #, :, maybe substringsx
module Path_Delimiter_Character =
    /// a "set" of delimiter characters as a string
    let setstring = "/"

    let parser =
        anyOf setstring
        |>> (fun delimiter ->
            { new Path_Delimiter_Character with
                member this.as_char = delimiter })


    let variable_parser (variablestring: string) =
        anyOf variablestring
        |>> (fun delimiter ->
            { new Path_Delimiter_Character with
                member this.as_char = delimiter })

    let solidus = "/"

/// segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" )
///             ; non-zero-length segment without any colon ":"
module Segment =

    let string_from_sequence (segment_sequence: Segment seq) =
        segment_sequence
        |> Seq.map (fun segment -> segment.as_string)
        |> String.concat Path_Delimiter_Character.solidus

    module NonZero_NonColon_Segment =

        let parser =

            parser_expecting
                (contiguous (
                    choice [

                             Unreserved_Character.parser
                             |>> fun unreserved_character ->
                                     PathSegment_Character.from_char unreserved_character.as_char
                             Percent_Encoded_Character.parser
                             |>> fun percent_encoded_character ->
                                     PathSegment_Character.from_char percent_encoded_character.as_char
                             Subcomponent_Delimiter_Character.parser
                             |>> fun subcomponent_delimiter_character ->
                                     PathSegment_Character.from_char subcomponent_delimiter_character.as_char
                             pchar '@' |>> PathSegment_Character.from_char

                              ]
                 )
                 |>> List.toSeq
                 |>> (fun pathSegment_character_sequence ->

                     { new NonZero_NonColon_Segment with

                         member this.as_string =
                             pathSegment_character_sequence
                             |> Seq.map (fun segment_character ->

                                 segment_character.as_char

                             )
                             |> Seq.toArray
                             |> String

                         member this.segment_character_sequence = pathSegment_character_sequence }


                     ))
                """
        segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" )
                    ; non-zero-length segment without any colon ":"
        """

    module NonZero_Segment =
        /// segment-nz    = 1*pchar
        let parser: Parser<NonZero_Segment, unit> =
            parser_expecting
                (one_or_more PathSegment_Character.parser

                 |>> (fun pathSegmentCharacterList ->
                     pathSegmentCharacterList
                     |> List.toSeq
                     |> (fun pathSegment_character_sequence ->

                         { new NonZero_Segment with


                             member this.as_string =
                                 pathSegment_character_sequence
                                 |> Seq.map (fun segment_character ->

                                     segment_character.as_char

                                 )
                                 |> Seq.toArray
                                 |> String

                             member this.segment_character_sequence = pathSegment_character_sequence }

                         )

                     ))
                """
        segment-nz    = 1*pchar
        """


    /// segment       = *pchar
    let parser =
        parser_expecting
            (zero_or_more PathSegment_Character.parser
             |>> (fun pathSegmentCharacterList ->
                 pathSegmentCharacterList
                 |> List.toSeq
                 |> (fun pathSegment_character_sequence ->

                     { new Segment with


                         member this.as_string =
                             pathSegment_character_sequence
                             |> Seq.map (fun segment_character ->

                                 segment_character.as_char

                             )
                             |> Seq.toArray
                             |> String

                         member this.segment_character_sequence = pathSegment_character_sequence }

                     )

                 )

            )
            """
    segment       = *pchar
    """


/// path-empty    = 0<pchar> ; zero characters
let empty_path =
    { new Empty_Path with

        member this.as_string = String.Empty
        member this.segment_sequence = seq {  } }


module Decimal_Octet =
    let from_int (int_: int) =
        { new Decimal_Octet with
            member this.as_int = int_ }

    /// dec-octet     = DIGIT                 ; 0-9
    let dec_octet'0_9 =
        parser_expecting
            (Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             .>> notFollowedBy Augmented_Backus_Naur_Form.Core_Rules.DIGIT

             |>> int_from_singleDigit)
            """
    DIGIT                 ; 0-9
    """

    ///              / %x31-39 DIGIT         ; 10-99
    let dec_octet'10_99 =
        parser_expecting
            (%% +.anyOf "123456789"
             -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             -- notFollowedBy Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             -%> int_from_doubleDigit)
            """
    %x31-39 DIGIT         ; 10-99
    """

    ///              / "1" 2DIGIT            ; 100-199
    let dec_octet'100_199 =
        parser_expecting
            (%% +.pchar '1'
             -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             -%> int_from_tripleDigit)
            """
    "1" 2DIGIT            ; 100-199
    """

    ///              / "2" %x30-34 DIGIT     ; 200-249
    let dec_octet'200_249 =
        parser_expecting
            (%% +.pchar '2'
             -- +.anyOf "01234"
             -- +.Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             -%> int_from_tripleDigit)
            """
    "2" %x30-34 DIGIT     ; 200-249
    """

    ///              / "25" %x30-35          ; 250-255
    let dec_octet'250_255: Parser<int, unit> =
        parser_expecting
            (%% +.pchar '2' -- +.pchar '5' -- +.anyOf "012345"
             -%> int_from_tripleDigit)
            """
    "25" %x30-35          ; 250-255
    """


    /// dec-octet     = DIGIT                 ; 0-9
    ///              / %x31-39 DIGIT         ; 10-99
    ///              / "1" 2DIGIT            ; 100-199
    ///              / "2" %x30-34 DIGIT     ; 200-249
    ///              / "25" %x30-35          ; 250-255
    let parser =
        parser_expecting
            (choice [

                      attempt dec_octet'250_255
                      attempt dec_octet'200_249
                      attempt dec_octet'100_199
                      attempt dec_octet'10_99
                      dec_octet'0_9


                       ]
             |>> from_int

            )
            """
    dec-octet     = DIGIT                 ; 0-9
                 / %x31-39 DIGIT         ; 10-99
                 / "1" 2DIGIT            ; 100-199
                 / "2" %x30-34 DIGIT     ; 200-249
                 / "25" %x30-35          ; 250-255
    """



module IPv4address =
    /// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
    let parser =
        parser_expecting
            (%% +.Decimal_Octet.parser
             -- pchar '.'
             -- +.Decimal_Octet.parser
             -- pchar '.'
             -- +.Decimal_Octet.parser
             -- pchar '.'
             -- +.Decimal_Octet.parser
             -%> fun outer_left inner_left inner_right outer_right ->

                     { new IPv4address with
                         member this.as_string =
                             $"{outer_left.as_int}.{inner_left.as_int}.{inner_right.as_int}.{outer_right.as_int}"

                         member this.outer_left_octet = outer_left
                         member this.inner_left_octet = inner_left
                         member this.inner_right_octet = inner_right
                         member this.outer_right_octet = outer_right }


            )
            """
    /// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
    """



// TODO maybe one day
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


module Port =
    /// port          = *DIGIT
    let parser =
        parser_expecting
            (zero_or_more Augmented_Backus_Naur_Form.Core_Rules.DIGIT
             |>> fun charList ->
                     let stringNumeral = string_from_charList charList

                     { new Port with
                         member this.as_int = int_from_stringNumeral stringNumeral }

            )
            """
    port          = *DIGIT
    """

    /// [ ":" port ]
    let colon_parser =
        parser_expecting
            (opt (pchar ':' >>. parser))
            """
    [ ":" port ]
    """


module Registered_Name =
    /// reg-name      = *( unreserved / pct-encoded / sub-delims )
    let parser =
        parser_expecting
            (zero_or_more (
                choice [

                         Unreserved_Character.parser
                         |>> Registered_Name_Character.From_Unreserved_Character
                         Percent_Encoded_Character.parser
                         |>> Registered_Name_Character.From_Percent_Encoded_Character
                         Subcomponent_Delimiter_Character.parser
                         |>> Registered_Name_Character.From_Subcomponent_Delimiter_Character

                          ]
             )
             |>> List.toSeq
             |>> (fun character_sequence ->

                 { new Registered_Name with
                     member this.as_string =
                         character_sequence
                         |> Seq.map (fun character -> character.as_char)
                         |> Seq.toArray
                         |> String

                     member this.registered_name_character_sequence = character_sequence }


                 )

            )
            """
    reg-name      = *( unreserved / pct-encoded / sub-delims )
    """
// TODO IP-literal
// host          = IP-literal / IPv4address / reg-name
module Host =
    /// host          =  IPv4address / reg-name
    let parser =
        parser_expecting
            (choice [ IPv4address.parser |>> Host.From_IPv4address
                      Registered_Name.parser
                      |>> Host.From_Registered_Name

                       ])
            """
    /// host          =  IPv4address / reg-name
    """

module UserInfo =
    /// userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
    let parser =
        parser_expecting
            (zero_or_more (
                choice [

                         Unreserved_Character.parser
                         |>> PathSegment_Character.From_Unreserved_Character
                         Percent_Encoded_Character.parser
                         |>> PathSegment_Character.From_Percent_Encoded_Character
                         Subcomponent_Delimiter_Character.parser
                         |>> PathSegment_Character.From_Subcomponent_Delimiter_Character
                         pchar ':' |>> PathSegment_Character.from_char

                          ]
             )
             |>> List.toSeq
             |>> (fun character_sequence ->

                 { new UserInfo with
                     member this.as_string =
                         character_sequence
                         |> Seq.map (fun character -> character.as_char)
                         |> Seq.toArray
                         |> String

                     member this.userinfo_character_sequence = character_sequence }


                 ))
            """
    /// userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
    """

    /// [ userinfo "@" ]
    let at_parser =
        parser_expecting
            (

            provisional (parser .>> succeededBy communication_at)

            )
            """
    [ userinfo "@" ]
    """

module Authority =
    /// authority     = [ userinfo "@" ] host [ ":" port ]
    let parser =
        parser_expecting
            (%% +.UserInfo.at_parser
             -- +.Host.parser
             -- +.Port.colon_parser
             -%> (fun userinfoOption host portOption ->

                 { new Authority with

                     member this.as_string =

                         let userinfoString =
                             match userinfoOption with
                             | Some userinfo -> $"{userinfo}@"
                             | _ -> String.Empty

                         let portString =
                             match portOption with
                             | Some port -> $":{string port}"
                             | _ -> String.Empty

                         $"{userinfoString}{host.as_string}{portString}"

                     member this.userinfo = userinfoOption
                     member this.host = host
                     member this.port = portOption }




                 ))
            """
    authority     = [ userinfo "@" ] host [ ":" port ]
    """

module Abempty_Path =

    /// path-abempty  = *( "/" segment ) ; begins with "/" or is empty
    let parser =
        parser_expecting
            (zero_or_more (Path_Delimiter_Character.parser >>. Segment.parser)
             |>> fun segmentList ->
                     let segment_sequence = segmentList |> List.toSeq

                     { new Abempty_Path with
                         member this.as_string = segment_sequence |> Segment.string_from_sequence
                         member this.segment_sequence = segment_sequence }

            )
            """
    path-abempty  = *( "/" segment ) ; begins with "/" or is empty
    """

module NonZero_Path =
    let parser =
        parser_expecting
            (%% +.Segment.NonZero_Segment.parser
             -- +.Abempty_Path.parser
             -%> (fun head_segment tail_path ->
                 let head_sequence = seq { head_segment :> Segment }
                 let tail_sequence = tail_path.segment_sequence
                 let segment_sequence = Seq.append head_sequence tail_sequence
                 let segment_sequence_string = segment_sequence |> Segment.string_from_sequence

                 { new NonZero_Path with
                     member this.as_string = segment_sequence_string
                     member this.segment_sequence = segment_sequence
                     member this.head_segment = head_segment
                     member this.tail_segment_sequence = tail_sequence }

                 ))
            """
segment-nz *( "/" segment )
    """

module Absolute_Path =


    /// path-absolute = "/" [ segment-nz *( "/" segment ) ] ; begins with "/" but not "//"
    let parser =
        parser_expecting
            (%%Path_Delimiter_Character.parser
             -- notFollowedBy Path_Delimiter_Character.parser
             -- +.(opt NonZero_Path.parser)
             -%> (fun nonzero_path_option ->

                 { new Absolute_Path with

                     member this.as_string =
                         match nonzero_path_option with
                         | Some nonzero_path -> nonzero_path.as_string
                         | _ -> "/"

                     member this.segment_sequence =
                         match nonzero_path_option with
                         | Some nonzero_path -> nonzero_path.segment_sequence
                         | _ -> empty_path.segment_sequence

                     member this.nonzero_path = nonzero_path_option }

                 ))
            """
    path-absolute = "/" [ segment-nz *( "/" segment ) ] ; begins with "/" but not "//"
    """

module NoScheme_Path =
    /// path-noscheme = segment-nz-nc *( "/" segment ) ; begins with a non-colon segment
    let parser =
        parser_expecting
            (%% +.Segment.NonZero_NonColon_Segment.parser
             -- +.Abempty_Path.parser
             -%> (fun head_segment tail_path ->
                 let head_sequence = seq { head_segment :> Segment }
                 let tail_sequence = tail_path.segment_sequence
                 let segment_sequence = Seq.append head_sequence tail_sequence
                 let segment_sequence_string = segment_sequence |> Segment.string_from_sequence

                 { new NoScheme_Path with
                     member this.as_string = segment_sequence_string
                     member this.segment_sequence = segment_sequence
                     member this.head_segment = head_segment
                     member this.tail_segment_sequence = tail_sequence }

                 ))
            """
    path-noscheme = segment-nz-nc *( "/" segment ) ; begins with a non-colon segment
    """

module Rootless_Path =
    /// path-rootless = segment-nz *( "/" segment ) ; begins with a segment
    let parser =
        parser_expecting
            (%% +.Segment.NonZero_Segment.parser
             -- +.Abempty_Path.parser
             -%> (fun head_segment tail_path ->
                 let head_sequence = seq { head_segment :> Segment }
                 let tail_sequence = tail_path.segment_sequence
                 let segment_sequence = Seq.append head_sequence tail_sequence
                 let segment_sequence_string = segment_sequence |> Segment.string_from_sequence

                 { new Rootless_Path with
                     member this.as_string = segment_sequence_string
                     member this.segment_sequence = segment_sequence
                     member this.head_segment = head_segment
                     member this.tail_segment_sequence = tail_sequence }

                 ))
            """
    path-rootless = segment-nz *( "/" segment ) ; begins with a segment
     """

module Network_Path =
    /// "//" authority path-abempty
    let parser =
        parser_expecting
            (%% +.Authority.parser
             -- +.(provisional Abempty_Path.parser)
             -%> (fun authority abempty_path_option ->
                 let segment_sequence_string =
                     match abempty_path_option with
                     | Some abempty_path -> abempty_path.as_string
                     | _ -> String.Empty


                 { new Network_Path with
                     member this.as_string = $"{authority.as_string}/{segment_sequence_string}"
                     member this.network_authority = authority
                     member this.abempty_path = abempty_path_option }

                 ))
            """
    "//" authority path-abempty
    """

module Scheme =
    let from_char (char_: char) =
        { new Scheme_Character with
            member this.as_char = char_ }

    /// ALPHA
    let head_parser =
        Augmented_Backus_Naur_Form.Core_Rules.ALPHA
        |>> from_char

    ///  *( ALPHA / DIGIT / "+" / "-" / "." )
    let tail_parser =
        choice [

                 Augmented_Backus_Naur_Form.Core_Rules.ALPHA
                 Augmented_Backus_Naur_Form.Core_Rules.DIGIT
                 anyOf "+-."

                  ]
        |>> from_char

    /// scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
    let parser =
        parser_expecting
            (%% +.head_parser -- +.(zero_or_more tail_parser)
             -%> fun head tail ->
                     { new Scheme with

                         member this.as_string =
                             let headString = string head.as_char

                             let tailString =
                                 tail
                                 |> List.map (fun character -> character.as_char)
                                 |> List.toArray
                                 |> String

                             $"{headString}{tailString}"

                         member this.scheme_character_sequence = head :: tail |> List.toSeq }





            )
            """
    scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
    """



module Relative_Part =
    /// relative-part = "//" authority path-abempty
    ///              / path-absolute
    ///              / path-noscheme
    ///              / path-empty
    let parser =
        parser_expecting
            (opt (
                choice [


                         Network_Path.parser
                         |>> Relative_Part.From_Network_Path
                         Absolute_Path.parser
                         |>> Relative_Part.From_Absolute_Path
                         NoScheme_Path.parser
                         |>> Relative_Part.From_NoScheme_Path

                          ]
             )
             |>> fun relative_path_option -> defaultArg relative_path_option (Relative_Part.From_Empty_Path empty_path))
            """
    relative-part = "//" authority path-abempty
                 / path-absolute
                 / path-noscheme
                 / path-empty
    """

module Relative_Reference =
    /// relative-ref  = relative-part [ "?" query ] [ "#" fragment ]
    let parser =
        parser_expecting
            (%% +.Relative_Part.parser
             -- +.(opt Query.questionmark_prefixed.parser)
             -- +.(opt Fragment.hash_prefixed.parser)
             -%> (fun relative_part query_option fragment_option ->

                 { new Relative_Reference with

                     member this.as_string =
                         $"{relative_part.as_string}{Query.string_from_option query_option}{Fragment.string_from_option fragment_option}"

                     member this.relative_part = relative_part
                     member this.query = query_option
                     member this.fragment = fragment_option }

                 ))
            """
    relative-ref  = relative-part [ "?" query ] [ "#" fragment ]
    """

module Hierarchical_Part =
    /// hier-part     = "//" authority path-abempty
    ///              / path-absolute
    ///              / path-rootless
    ///              / path-empty
    let parser =
        parser_expecting
            (opt (
                choice [


                         Network_Path.parser
                         |>> Hierarchical_Part.From_Network_Path
                         Absolute_Path.parser
                         |>> Hierarchical_Part.From_Absolute_Path
                         Rootless_Path.parser
                         |>> Hierarchical_Part.From_Rootless_Path

                          ]
             )
             |>> fun relative_path_option ->
                     defaultArg relative_path_option (Hierarchical_Part.From_Empty_Path empty_path))
            """
    hier-part     = "//" authority path-abempty
                 / path-absolute
                 / path-rootless
                 / path-empty
    """

module Absolute_URI =
    /// absolute-URI  = scheme ":" hier-part [ "?" query ]
    let parser =
        parser_expecting
            (%% +.Scheme.parser
             -- pchar ':'
             -- +.Hierarchical_Part.parser
             -- +.(opt Query.questionmark_prefixed.parser)
             -%> (

             fun scheme hierarchical_part query_option ->

                 { new Absolute_URI with

                     member this.as_string =
                         $"{scheme.as_string}:{hierarchical_part.as_string}{Query.string_from_option query_option}"

                     member this.scheme = scheme
                     member this.hierarchical_part = hierarchical_part
                     member this.query = query_option }


                 ))
            """
    /// absolute-URI  = scheme ":" hier-part [ "?" query ]
    """

module URI =
    /// URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
    let parser =

        parser_expecting
            (%% +.Absolute_URI.parser
             -- +.(opt Fragment.hash_prefixed.parser)
             -%> (fun absolute_uri fragment_option ->

                 { new URI with

                     member this.as_string =
                         $"{absolute_uri.as_string}{Fragment.string_from_option fragment_option}"

                     member this.scheme = absolute_uri.scheme
                     member this.hierarchical_part = absolute_uri.hierarchical_part
                     member this.query = absolute_uri.query
                     member this.fragment = fragment_option }


                 ))
            """
    URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
    """



// let testUriString = "http://localhost/"
// let test = parse_input URI.parser testUriString

let uriStrings =
    [|

       "ftp://ftp.is.co.za/rfc/rfc1808.txt"
       "http://www.ietf.org/rfc/rfc2396.txt"
       // "ldap://[2001:db8::7]/c=GB?objectClass?one"
       "mailto:John.Doe@example.com"
       "news:comp.infosystems.www.servers.unix"
       "tel:+1-816-555-1212"
       "telnet://192.0.2.16:80/"
       "urn:oasis:names:specification:docbook:dtd:xml:4.1.2"

       |]

// uriStrings
// |> Array.map (fun uriString -> parse_input URI.parser uriString)

let testUri = parse_input URI.parser uriStrings[0]

testUri.hierarchical_part
