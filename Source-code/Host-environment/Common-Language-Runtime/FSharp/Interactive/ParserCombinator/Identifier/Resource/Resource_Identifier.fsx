open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open StringExtensions
open XParsecErgonomics
open Unicode_Standard

open XParsec















let alpha = Latin_Alphabet


let digit = ASCII_digits




let sub_delims = Code_Subspace.from_string "!$&'()*+,;="


let gen_delims = Code_Subspace.from_string ":/?#[]@"



let reserved =
    Code_Subspace.from_union [|

                                gen_delims
                                sub_delims

                                 |]


let unreserved =


    Code_Subspace.from_union [| alpha
                                digit
                                hyphen_minus
                                full_stop
                                low_line
                                tilde |]



let pchar_unencoded =

    Code_Subspace.from_union [| unreserved
                                sub_delims
                                colon
                                commercial_at |]



let query_fragment_unencoded =

    Code_Subspace.from_union [|

                                pchar_unencoded
                                solidus
                                question_mark

                                 |]


let segment_nz_nc_unencoded =
    Code_Subspace.from_union [| unreserved
                                sub_delims
                                commercial_at |]

let segment_nz_unencoded = pchar_unencoded
let segment_unencoded = pchar_unencoded

let abempty_unencoded =
    Code_Subspace.from_union [|

                                segment_unencoded
                                solidus

                                 |]

let rootless_unencoded =
    Code_Subspace.from_union [|

                                segment_nz_unencoded
                                abempty_unencoded

                                 |]

let noscheme_unencoded =
    Code_Subspace.from_union [|

                                segment_nz_nc_unencoded
                                abempty_unencoded

                                 |]

let absolute_unencoded = rootless_unencoded


let reg_name_unencoded =
    Code_Subspace.from_union [|

                                unreserved
                                sub_delims

                                 |]



let userinfo_unencoded =
    Code_Subspace.from_union [|

                                reg_name_unencoded
                                colon

                                 |]











let scheme =

    Code_Subspace.from_union [|

                                alpha
                                digit
                                plus_sign
                                hyphen_minus
                                full_stop

                                 |]







let iprivate =
    Code_Subspace.from_union [| Code_Subspace.from_limits 0xE000 0xF8FF
                                Code_Subspace.from_limits 0xF0000 0xFFFFD
                                Code_Subspace.from_limits 0x100000 0x10FFFD |]



let ucschar =
    Code_Subspace.from_union [| Code_Subspace.from_limits 0xA0 0xD7FF
                                Code_Subspace.from_limits 0xF900 0xFDCF
                                Code_Subspace.from_limits 0xFDF0 0xFFEF
                                Code_Subspace.from_limits 0x10000 0x1FFFD
                                Code_Subspace.from_limits 0x20000 0x2FFFD
                                Code_Subspace.from_limits 0x30000 0x3FFFD
                                Code_Subspace.from_limits 0x40000 0x4FFFD
                                Code_Subspace.from_limits 0x50000 0x5FFFD
                                Code_Subspace.from_limits 0x60000 0x6FFFD
                                Code_Subspace.from_limits 0x70000 0x7FFFD
                                Code_Subspace.from_limits 0x80000 0x8FFFD
                                Code_Subspace.from_limits 0x90000 0x9FFFD
                                Code_Subspace.from_limits 0xA0000 0xAFFFD
                                Code_Subspace.from_limits 0xB0000 0xBFFFD
                                Code_Subspace.from_limits 0xC0000 0xCFFFD
                                Code_Subspace.from_limits 0xD0000 0xDFFFD
                                Code_Subspace.from_limits 0xE1000 0xEFFFD |]

let iunreserved =
    Code_Subspace.from_union [| unreserved
                                ucschar |]

let ifragment_unencoded =
    Code_Subspace.from_union [| query_fragment_unencoded
                                ucschar |]

let iquery_unencoded =
    Code_Subspace.from_union [| query_fragment_unencoded
                                iprivate
                                ucschar |]

let ipchar_unencoded =
    Code_Subspace.from_union [| pchar_unencoded
                                ucschar |]

let isegment_nz_nc_unencoded =
    Code_Subspace.from_union [| segment_nz_nc_unencoded
                                ucschar |]


let isegment_nz_unencoded =
    Code_Subspace.from_union [| segment_nz_unencoded
                                ucschar |]

let isegment_unencoded =
    Code_Subspace.from_union [| segment_unencoded
                                ucschar |]

let iabempty_unencoded =
    Code_Subspace.from_union [| abempty_unencoded
                                ucschar |]


let irootless_unencoded =
    Code_Subspace.from_union [|

                                rootless_unencoded
                                ucschar

                                 |]

let inoscheme_unencoded =
    Code_Subspace.from_union [|

                                noscheme_unencoded
                                ucschar

                                 |]

let iabsolute_unencoded = irootless_unencoded


let ireg_name_unencoded =
    Code_Subspace.from_union [| reg_name_unencoded
                                ucschar |]

let iuserinfo_unencoded =
    Code_Subspace.from_union [| userinfo_unencoded
                                ucschar |]




















module Kleene =
    let star parser_combinator =
        many parser_combinator |>> ImmutableArray.toArray

    let plus parser_combinator =
        many1 parser_combinator |>> ImmutableArray.toArray



module Subcomponent_Delimiter_Character =
    let parser_combinator =
        sub_delims.parser_combinator
        |> expecting """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """

module General_Component_Delimiter_Character =
    let parser_combinator =
        gen_delims.parser_combinator
        |> expecting """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """

module Reserved_Character =
    let parser_combinator =
        reserved.parser_combinator
        |> expecting """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """


module Percent_Encoded_Character =
    let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
        parser {


            let! sigil = percent.parser_combinator
            let! left_hex_digit = Hexadecimal_digits.parser_combinator
            let! right_hex_digit = Hexadecimal_digits.parser_combinator

            return
                Array.concat [ sigil
                               left_hex_digit
                               right_hex_digit ]

        }
        |> expecting """pct-encoded   = "%" HEXDIG HEXDIG"""


module Decimal_Octet =

    let private parse_0_9: Parser<int array, int, unit, ReadableArray<int>> =
        (digit.parser_combinator
         .>> notFollowedBy digit.parser_combinator)
        |> expecting """     DIGIT                 ; 0-9 """

    let private parse_10_99: Parser<int array, int, unit, ReadableArray<int>> =
        parser {

            let! leftDigit = one_to_nine.parser_combinator
            let! rightDigit = digit.parser_combinator
            return Array.concat [| leftDigit; rightDigit |]

        }
        |> expecting """    %x31-39 DIGIT         ; 10-99 """

    let private parse_100_199: Parser<int array, int, unit, ReadableArray<int>> =

        parser {

            let! leftDigit = one.parser_combinator
            let! centerDigit = digit.parser_combinator
            let! rightDigit = digit.parser_combinator

            return
                Array.concat [| leftDigit
                                centerDigit
                                rightDigit |]

        }
        |> expecting """    "1" 2DIGIT            ; 100-199 """

    let private parse_200_249: Parser<int array, int, unit, ReadableArray<int>> =
        parser {

            let! leftDigit = two.parser_combinator

            let! centerDigit = zero_to_four.parser_combinator

            let! rightDigit = digit.parser_combinator

            return
                Array.concat [| leftDigit
                                centerDigit
                                rightDigit |]

        }
        |> expecting """    "2" %x30-34 DIGIT     ; 200-249 """

    let private parse_250_255: Parser<int array, int, unit, ReadableArray<int>> =
        parser {

            let! leftDigit = two.parser_combinator
            let! centerDigit = five.parser_combinator
            let! rightDigit = zero_to_five.parser_combinator

            return
                Array.concat [| leftDigit
                                centerDigit
                                rightDigit |]

        }
        |> expecting """  "25" %x30-35          ; 250-255 """

    let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
        choice [

                 parse_250_255
                 parse_200_249
                 parse_100_199
                 parse_10_99
                 parse_0_9

                  ]
        |> expecting
            """
    dec-octet     = DIGIT                 ; 0-9
                 / %x31-39 DIGIT         ; 10-99
                 / "1" 2DIGIT            ; 100-199
                 / "2" %x30-34 DIGIT     ; 200-249
                 / "25" %x30-35          ; 250-255
    """

module IP =
    module v4 =
        module address =
            let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
                parser {

                    let! outer_left = Decimal_Octet.parser_combinator
                    let! left_dot = full_stop.parser_combinator
                    let! inner_left = Decimal_Octet.parser_combinator
                    let! center_dot = full_stop.parser_combinator
                    let! inner_right = Decimal_Octet.parser_combinator
                    let! right_dot = full_stop.parser_combinator
                    let! outer_right = Decimal_Octet.parser_combinator

                    return
                        Array.concat [| outer_left
                                        left_dot
                                        inner_left
                                        center_dot
                                        inner_right
                                        right_dot
                                        outer_right |]
                }
                |> expecting """    IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet """

    module v6 =


        module h16 =
            let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
                choice [ parray 4 (Hexadecimal_digits.parser_combinator)
                         parray 3 (Hexadecimal_digits.parser_combinator)
                         parray 2 (Hexadecimal_digits.parser_combinator)
                         parray 1 (Hexadecimal_digits.parser_combinator) ]
                |>> ImmutableArray.toArray
                |> expecting """ h16           = 1*4HEXDIG ; 16 bits of address represented in hexadecimal """

            module pair =
                let parser_combinator =
                    parser {
                        let! left_h16 = parser_combinator
                        let! delimiter = colon.parser_combinator
                        let! right_h16 = parser_combinator

                        return
                            Array.concat [| left_h16
                                            delimiter
                                            right_h16 |]

                    }
                    |> expecting """( h16 ":" h16 )"""


        module ls32 =

            let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
                choice [

                         h16.pair.parser_combinator
                         v4.address.parser_combinator

                          ]
                |> expecting
                    """ ls32          = ( h16 ":" h16 ) / IPv4address ; least-significant 32 bits of address """





        let double_colon: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! left_colon = colon.parser_combinator
                let! right_colon = colon.parser_combinator

                return
                    Array.concat [| left_colon
                                    right_colon |]
            }
            |> expecting """::"""


        let h16_colon: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! h16 = h16.parser_combinator
                let! delimiter = colon.parser_combinator

                return Array.concat [| h16; delimiter |]
            }
            |> expecting """ h16 ":" """


        let colon_h16: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! delimiter = colon.parser_combinator
                let! h16 = h16.parser_combinator

                return Array.concat [| delimiter; h16 |]
            }
            |> expecting """ ":" h16 """


        let h16_colon_sequence_exactly (count: int) : Parser<int array, int, unit, ReadableArray<int>> =

            if count = 0 then
                parser { return [||] }
            else
                parray count h16_colon |>> ImmutableArray.toArray


        let h16_sequence_exactly (count: int) : Parser<int array, int, unit, ReadableArray<int>> =

            if count = 0 then
                parser { return [||] }

            elif count = 1 then
                h16.parser_combinator

            else
                parser {
                    let! first_h16 = h16.parser_combinator

                    let! remaining_h16s =
                        parray (count - 1) colon_h16
                        |>> ImmutableArray.toArray

                    return
                        Array.concat [| first_h16
                                        remaining_h16s |]
                }


        let optional_h16_sequence_up_to (maximum_count: int) : Parser<int array, int, unit, ReadableArray<int>> =

            let alternatives =
                [ maximum_count .. -1 .. 1 ]
                |> List.map h16_sequence_exactly

            choice (alternatives @ [ parser { return [||] } ])


        let alternative_1: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! h16_colons = h16_colon_sequence_exactly 6
                let! ls32 = ls32.parser_combinator

                return Array.concat [| h16_colons; ls32 |]
            }
            |> expecting """                            6( h16 ":" ) ls32 """


        let alternative_2: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! double_colon = double_colon
                let! h16_colons = h16_colon_sequence_exactly 5
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| double_colon
                                    h16_colons
                                    ls32 |]
            }
            |> expecting """                       "::" 5( h16 ":" ) ls32 """


        let alternative_3: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 1
                let! double_colon = double_colon
                let! h16_colons = h16_colon_sequence_exactly 4
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    h16_colons
                                    ls32 |]
            }
            |> expecting """ [               h16 ] "::" 4( h16 ":" ) ls32 """


        let alternative_4: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 2
                let! double_colon = double_colon
                let! h16_colons = h16_colon_sequence_exactly 3
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    h16_colons
                                    ls32 |]
            }
            |> expecting """ [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32 """


        let alternative_5: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 3
                let! double_colon = double_colon
                let! h16_colons = h16_colon_sequence_exactly 2
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    h16_colons
                                    ls32 |]
            }
            |> expecting """ [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32 """


        let alternative_6: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 4
                let! double_colon = double_colon
                let! h16_colon = h16_colon
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    h16_colon
                                    ls32 |]
            }
            |> expecting """ [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32 """


        let alternative_7: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 5
                let! double_colon = double_colon
                let! ls32 = ls32.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    ls32 |]
            }
            |> expecting """ [ *4( h16 ":" ) h16 ] "::"              ls32 """


        let alternative_8: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 6
                let! double_colon = double_colon
                let! h16 = h16.parser_combinator

                return
                    Array.concat [| prefix
                                    double_colon
                                    h16 |]
            }
            |> expecting """ [ *5( h16 ":" ) h16 ] "::"              h16 """


        let alternative_9: Parser<int array, int, unit, ReadableArray<int>> =
            parser {
                let! prefix = optional_h16_sequence_up_to 7
                let! double_colon = double_colon

                return Array.concat [| prefix; double_colon |]
            }
            |> expecting """ [ *6( h16 ":" ) h16 ] "::" """


        module address =
            let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
                choice [ alternative_1
                         alternative_2
                         alternative_3
                         alternative_4
                         alternative_5
                         alternative_6
                         alternative_7
                         alternative_8
                         alternative_9 ]
                |> expecting
                    """
        IPv6address   =                            6( h16 ":" ) ls32
                     /                       "::" 5( h16 ":" ) ls32
                     / [               h16 ] "::" 4( h16 ":" ) ls32
                     / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
                     / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
                     / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
                     / [ *4( h16 ":" ) h16 ] "::"              ls32
                     / [ *5( h16 ":" ) h16 ] "::"              h16
                     / [ *6( h16 ":" ) h16 ] "::"
        """







    module vFuture =

        module version_flag =
            let parser_combinator =
                parser {
                    let! sigil = vV.parser_combinator

                    let! hexadecimal_digits =
                        many1 Hexadecimal_digits.parser_combinator
                        |>> ImmutableArray.toArray

                    return
                        Array.concat [| sigil
                                        hexadecimal_digits |]
                }
                |> expecting """ "v" 1*HEXDIG """

        let address =
            Code_Subspace.from_union [| unreserved
                                        sub_delims
                                        colon |]

        let parser_combinator =
            parser {
                let! version_flag = version_flag.parser_combinator
                let! delimiter = full_stop.parser_combinator

                let! address =
                    many1 address.parser_combinator
                    |>> ImmutableArray.toArray

                return
                    Array.concat [| version_flag
                                    delimiter
                                    address |]
            }
            |> expecting """ IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" ) """











    module Literal =
        let parser_combinator =
            parser {
                let! initial = left_square_bracket.parser_combinator

                let! literal =
                    choice [ v6.address.parser_combinator
                             vFuture.parser_combinator ]

                let! terminal = right_square_bracket.parser_combinator

                return
                    Array.concat [| initial
                                    literal
                                    terminal |]
            }
            |> expecting
                """
    IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
    """

module Port =
    let parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
        parser {
            let! delimiter = colon.parser_combinator

            let! digits =
                many1 digit.parser_combinator
                |>> ImmutableArray.toArray

            return Array.concat [| delimiter; digits |]
        }
        |> expecting
            """ port          = *DIGIT 
        empty port delimiter rejected as per rfc3986 section 3.2 Authority
        producers and normalizers should omit the ":" delimiter that separates host from port if the port component is empty
        """




module Scheme =


    let parser_combinator =
        parser {
            let! head = alpha.parser_combinator

            let! tail =
                many scheme.parser_combinator
                |>> ImmutableArray.toArray

            return Array.concat [| head; tail |]
        }
        |> expecting """ scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." ) """









[<Struct>]
[<RequireQualifiedAccess>]
type Path_Kind =
    | authority_abempty
    /// begins with "/" or is empty
    | abempty
    /// begins with "/" but not "//"
    | absolute
    /// begins with a non-colon segment
    | noscheme
    /// begins with a segment
    | rootless
    /// zero characters
    | empty


let percent_encodable (subspace: Code_Subspace) =
    choice [

             subspace.parser_combinator
             Percent_Encoded_Character.parser_combinator

              ]



let pchar = percent_encodable pchar_unencoded
let query_fragment = percent_encodable query_fragment_unencoded
let segment_nz_nc = percent_encodable segment_nz_nc_unencoded
let segment_nz = percent_encodable segment_nz_unencoded
let segment = percent_encodable segment_unencoded
let abempty = percent_encodable abempty_unencoded
let rootless = percent_encodable rootless_unencoded
let noscheme = percent_encodable noscheme_unencoded
let absolute = percent_encodable absolute_unencoded
let reg_name = percent_encodable reg_name_unencoded
let userinfo = percent_encodable userinfo_unencoded
let ifragment = percent_encodable ifragment_unencoded
let iquery = percent_encodable iquery_unencoded
let ipchar = percent_encodable ipchar_unencoded
let isegment_nz_nc = percent_encodable isegment_nz_nc_unencoded
let isegment_nz = percent_encodable isegment_nz_unencoded
let isegment = percent_encodable isegment_unencoded
let iabempty = percent_encodable iabempty_unencoded
let irootless = percent_encodable irootless_unencoded
let inoscheme = percent_encodable inoscheme_unencoded
let iabsolute = percent_encodable iabsolute_unencoded
let ireg_name = percent_encodable ireg_name_unencoded
let iuserinfo = percent_encodable iuserinfo_unencoded




















let prefix_delimited_Kleene_star (prefix: Code_Subspace) parser_combinator =
    parser {
        let! delimiter = prefix.parser_combinator
        let! characters = Kleene.star <| parser_combinator
        return Array.concat [| delimiter; characters |]
    }

let prefixed_Kleene_star prefix_combinator parser_combinator =
    parser {
        let! prefix = prefix_combinator
        let! characters = Kleene.star <| parser_combinator
        return Array.concat [| prefix; characters |]
    }

let postfix_delimited_characters (postfix: Code_Subspace) parser_combinator =
    parser {
        let! characters = Kleene.star <| parser_combinator
        let! delimiter = postfix.parser_combinator
        return Array.concat [| characters; delimiter |]
    }

let prefixed_percent_encodable_characters
    (prefix: Code_Subspace)
    (subspace_unencoded: Code_Subspace)
    (message: string)
    =
    let encodable_subspace = percent_encodable subspace_unencoded

    prefix_delimited_Kleene_star prefix encodable_subspace
    |> expecting message
