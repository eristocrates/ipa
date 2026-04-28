open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Language\Meta\Bacus_Naur_Form\Augmented\Augmented_Bacus_Naur_Form.fsx"

open SetErgonomics

open XParsec

open XParsecErgonomics
open Unicode_Standard



#r "nuget: FSharp.UMX"

open FSharp.UMX
















let sub_delims = Set_Definition.FromString "!$&'()*+,;="


let gen_delims = Set_Definition.FromString ":/?#[]@"



let reserved =
    Set_Definition.FromOverlay [|

                                  gen_delims
                                  sub_delims

                                   |]


let unreserved =


    Set_Definition.FromOverlay [| Augmented_Bacus_Naur_Form.alpha
                                  Augmented_Bacus_Naur_Form.digit
                                  hyphen_minus
                                  full_stop
                                  low_line
                                  tilde |]




let reg_name =
    Set_Definition.FromOverlay [|

                                  unreserved
                                  sub_delims

                                   |]



let userinfo =
    Set_Definition.FromOverlay [|

                                  reg_name
                                  colon

                                   |]

let segment_nz_nc =

    Set_Definition.FromOverlay [| reg_name
                                  commercial_at |]



let pchar_ =

    Set_Definition.FromOverlay [| segment_nz_nc
                                  colon |]

let fragment =

    Set_Definition.FromOverlay [|

                                  pchar_
                                  solidus
                                  question_mark

                                   |]

let query_ = fragment


let segment_nz = pchar_


let segment = pchar_


let abempty =
    Set_Definition.FromOverlay [|

                                  segment
                                  solidus

                                   |]



let scheme =

    Set_Definition.FromOverlay [|

                                  Augmented_Bacus_Naur_Form.alpha
                                  Augmented_Bacus_Naur_Form.digit
                                  plus_sign
                                  hyphen_minus
                                  full_stop

                                   |]







let iprivate =
    Set_Definition.FromOverlay [| Set_Definition.FromIncludedInterval 0xE000 0xF8FF
                                  Set_Definition.FromIncludedInterval 0xF0000 0xFFFFD
                                  Set_Definition.FromIncludedInterval 0x100000 0x10FFFD |]



let ucschar =
    Set_Definition.FromOverlay [| Set_Definition.FromIncludedInterval 0xA0 0xD7FF
                                  Set_Definition.FromIncludedInterval 0xF900 0xFDCF
                                  Set_Definition.FromIncludedInterval 0xFDF0 0xFFEF
                                  Set_Definition.FromIncludedInterval 0x10000 0x1FFFD
                                  Set_Definition.FromIncludedInterval 0x20000 0x2FFFD
                                  Set_Definition.FromIncludedInterval 0x30000 0x3FFFD
                                  Set_Definition.FromIncludedInterval 0x40000 0x4FFFD
                                  Set_Definition.FromIncludedInterval 0x50000 0x5FFFD
                                  Set_Definition.FromIncludedInterval 0x60000 0x6FFFD
                                  Set_Definition.FromIncludedInterval 0x70000 0x7FFFD
                                  Set_Definition.FromIncludedInterval 0x80000 0x8FFFD
                                  Set_Definition.FromIncludedInterval 0x90000 0x9FFFD
                                  Set_Definition.FromIncludedInterval 0xA0000 0xAFFFD
                                  Set_Definition.FromIncludedInterval 0xB0000 0xBFFFD
                                  Set_Definition.FromIncludedInterval 0xC0000 0xCFFFD
                                  Set_Definition.FromIncludedInterval 0xD0000 0xDFFFD
                                  Set_Definition.FromIncludedInterval 0xE1000 0xEFFFD |]

let ireserved =
    Set_Definition.FromOverlay [| reserved
                                  ucschar |]


let iunreserved =
    Set_Definition.FromOverlay [| unreserved
                                  ucschar |]


let ireg_name =
    Set_Definition.FromOverlay [| reg_name
                                  ucschar |]

let iuserinfo =
    Set_Definition.FromOverlay [| userinfo
                                  ucschar |]

let isegment_nz_nc =
    Set_Definition.FromOverlay [| segment_nz_nc
                                  ucschar |]


let ipchar =
    Set_Definition.FromOverlay [| pchar_
                                  ucschar |]

let ifragment =
    Set_Definition.FromOverlay [| fragment
                                  ucschar |]

let iquery =
    Set_Definition.FromOverlay [| query_
                                  iprivate
                                  ucschar |]

let isegment_nz =
    Set_Definition.FromOverlay [| segment_nz
                                  ucschar |]

let isegment =
    Set_Definition.FromOverlay [| segment
                                  ucschar |]

let iabempty =
    Set_Definition.FromOverlay [| abempty
                                  ucschar |]































[<Measure>]
type Subcomponent_Delimiter_Character

let parse_Subcomponent_Delimiter_Character =
    parse_code_point_expecting<Subcomponent_Delimiter_Character>
        sub_delims
        """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """


[<Measure>]
type General_Component_Delimiter_Character

let parse_General_Component_Delimiter_Character =
    parse_code_point_expecting<General_Component_Delimiter_Character>
        gen_delims
        """ gen-delims  = ":" / "/" / "?" / "#" / "[" / "]" / "@" """



[<Measure>]
type Reserved_Character


let parse_Reserved_Character =
    parse_code_point_expecting<Reserved_Character> reserved """ reserved      = gen-delims / sub-delims """

let parse_Percent_Encoded_Character: Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_expecting
        (parser {

            do! skipcode_point '%'
            let! left_hex_digit = material_element_of Hexidecimal_digits
            let! right_hex_digit = material_element_of Hexidecimal_digits

            return (left_hex_digit, right_hex_digit)

         }
         |>> fun (left_hex_digit, right_hex_digit) -> $"%%{char left_hex_digit}{char right_hex_digit}"



        )

        """pct-encoded   = "%" HEXDIG HEXDIG"""

let parse_code_point_or_Percent_Encoded_Character_expecting<[<Measure>] 'OutputType>
    (material_set: Set_Definition<int>)
    (expecting: string)
    : Parser<string<'OutputType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    choice [

             parse_code_point_expecting<'OutputType> material_set expecting
             parse_Percent_Encoded_Character
             |>> fun character -> %character

              ]




[<Measure>]
type Decimal_Octet


module Decimal_Octet =

    let parse_0_9: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (material_element_of Augmented_Bacus_Naur_Form.digit
             .>> notFollowedBy (material_element_of Augmented_Bacus_Naur_Form.digit)
             |>> fun single_digit -> %(Rune(single_digit).ToString()))
            """     DIGIT                 ; 0-9 """

    let parse_10_99: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! leftDigit = material_element_of one_to_nine
                let! rightDigit = material_element_of Augmented_Bacus_Naur_Form.digit
                return % $"{char leftDigit}{char rightDigit}"

            })
            """    %x31-39 DIGIT         ; 10-99 """

    let parse_100_199: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! leftDigit = pcode_point '1'
                let! centerDigit = material_element_of Augmented_Bacus_Naur_Form.digit
                let! rightDigit = material_element_of Augmented_Bacus_Naur_Form.digit
                return % $"{char leftDigit}{char centerDigit}{char rightDigit}"

            }

            )
            """    "1" 2DIGIT            ; 100-199 """

    let parse_200_249: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! leftDigit = pcode_point '2'

                let! centerDigit = material_element_of zero_to_four

                let! rightDigit = material_element_of Augmented_Bacus_Naur_Form.digit
                return % $"{char leftDigit}{char centerDigit}{char rightDigit}"

            })
            """    "2" %x30-34 DIGIT     ; 200-249 """

    let parse_250_255: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! leftDigit = pcode_point '2'
                let! centerDigit = pcode_point '5'

                let! rightDigit = material_element_of zero_to_five

                return % $"{char leftDigit}{char centerDigit}{char rightDigit}"

            })
            """  "25" %x30-35          ; 250-255 """

let parse_Decimal_Octet: Parser<string<Decimal_Octet>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_expecting
        (choice [

                  Decimal_Octet.parse_250_255
                  Decimal_Octet.parse_200_249
                  Decimal_Octet.parse_100_199
                  Decimal_Octet.parse_10_99
                  Decimal_Octet.parse_0_9

                   ])
        """
dec-octet     = DIGIT                 ; 0-9
             / %x31-39 DIGIT         ; 10-99
             / "1" 2DIGIT            ; 100-199
             / "2" %x30-34 DIGIT     ; 200-249
             / "25" %x30-35          ; 250-255
"""

[<Measure>]
type ipv4address

[<Struct>]
type IPv4address =
    {

      outer_left_octet: string<Decimal_Octet>
      inner_left_octet: string<Decimal_Octet>
      inner_right_octet: string<Decimal_Octet>
      outer_right_octet: string<Decimal_Octet>
      as_string: string<ipv4address>

     }


    static member parse: Parser<IPv4address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! outer_left = parse_Decimal_Octet
                do! skipcode_point '.'
                let! inner_left = parse_Decimal_Octet
                do! skipcode_point '.'
                let! inner_right = parse_Decimal_Octet
                do! skipcode_point '.'
                let! outer_right = parse_Decimal_Octet
                return (outer_left, inner_left, inner_right, outer_right)


             }
             |>> fun (outer_left, inner_left, inner_right, outer_right) ->
                     {

                       outer_left_octet = outer_left
                       inner_left_octet = inner_left
                       inner_right_octet = inner_right
                       outer_right_octet = outer_right
                       as_string = % $"{outer_left}.{inner_left}.{inner_right}.{outer_right}"

                     }


            )
            """    IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet """

[<Measure>]
type h16




let parse_h16: Parser<string<h16>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parse_expecting
        (choice [ parray 4 (material_element_of Hexidecimal_digits)
                  parray 3 (material_element_of Hexidecimal_digits)
                  parray 2 (material_element_of Hexidecimal_digits)
                  parray 1 (material_element_of Hexidecimal_digits) ]
         |>> fun hexadecimal_digits ->
                 hexadecimal_digits
                 |> string_from_code_points
                 |> UMX.tag<h16>)
        """
h16           = 1*4HEXDIG
              ; 16 bits of address represented in hexadecimal


"""

type H16_Pair =

    { left_h16: string<h16>
      right_h16: string<h16> }
    member this.as_string = % $"{this.left_h16}:{this.right_h16}"

[<Measure>]
type ls32


type LS32 =
    | FromH16Pair of H16_Pair
    | FromIPv4address of IPv4address
    member this.as_string =
        match this with
        | FromH16Pair h16_pair -> h16_pair.as_string
        | FromIPv4address ipv4 -> ipv4.as_string

    static member parse: Parser<LS32, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [

                      parser {
                          let! left_h16 = parse_h16
                          do! skipcode_point ':'
                          let! right_h16 = parse_h16

                          return
                              FromH16Pair
                                  { left_h16 = left_h16
                                    right_h16 = right_h16 }

                      }

                      IPv4address.parse |>> FromIPv4address

                       ])
            """
ls32          = ( h16 ":" h16 ) / IPv4address
              ; least-significant 32 bits of address
"""

[<Measure>]
type IPvFuture_Version_Flag


[<Measure>]
type IPvFuture_Address



type IPvFuture =

    { version_flag: string<IPvFuture_Version_Flag>
      address: string<IPvFuture_Address> }

    member this.as_string = % $"v{this.version_flag}.{this.address}"

    static member parse: Parser<IPvFuture, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {
                do!
                    choice [ skipcode_point 'v'
                             skipcode_point 'V' ]

                let! hexadecimal_digits = many1 (material_element_of Hexidecimal_digits)

                do! skipcode_point '.'

                let ipvfuture_address_character_set =
                    Set_Definition.FromOverlay [| unreserved
                                                  sub_delims
                                                  colon |]

                let! address_part_characters = many1 (material_element_of ipvfuture_address_character_set)

                return
                    {

                      version_flag = %(hexadecimal_digits |> string_from_code_points)
                      address = %(address_part_characters |> string_from_code_points)

                    }
            })
            """
IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
"""

[<Measure>]
type ipv6address


type IPv6address =
    | FromSixH16ColonThenLS32 of string<ipv6address>
    | FromDoubleColonThenFiveH16ColonThenLS32 of string<ipv6address>
    | FromOptionalOneH16ThenDoubleColonThenFourH16ColonThenLS32 of string<ipv6address>
    | FromOptionalTwoH16ThenDoubleColonThenThreeH16ColonThenLS32 of string<ipv6address>
    | FromOptionalThreeH16ThenDoubleColonThenTwoH16ColonThenLS32 of string<ipv6address>
    | FromOptionalFourH16ThenDoubleColonThenOneH16ColonThenLS32 of string<ipv6address>
    | FromOptionalFiveH16ThenDoubleColonThenLS32 of string<ipv6address>
    | FromOptionalSixH16ThenDoubleColonThenH16 of string<ipv6address>
    | FromOptionalSevenH16ThenDoubleColon of string<ipv6address>

    member this.as_string =
        match this with
        | FromSixH16ColonThenLS32 value -> value
        | FromDoubleColonThenFiveH16ColonThenLS32 value -> value
        | FromOptionalOneH16ThenDoubleColonThenFourH16ColonThenLS32 value -> value
        | FromOptionalTwoH16ThenDoubleColonThenThreeH16ColonThenLS32 value -> value
        | FromOptionalThreeH16ThenDoubleColonThenTwoH16ColonThenLS32 value -> value
        | FromOptionalFourH16ThenDoubleColonThenOneH16ColonThenLS32 value -> value
        | FromOptionalFiveH16ThenDoubleColonThenLS32 value -> value
        | FromOptionalSixH16ThenDoubleColonThenH16 value -> value
        | FromOptionalSevenH16ThenDoubleColon value -> value


let parse_double_colon: Parser<unit, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {
        do! skipcode_point ':'
        do! skipcode_point ':'
    }


let parse_h16_colon_as_string: Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {
        let! h16 = parse_h16
        do! skipcode_point ':'

        return $"{h16}:"
    }


let parse_h16_as_string: Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_h16 |>> fun h16 -> $"{h16}"


let parse_h16_colon_sequence_exactly
    (count: int)

    : Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! h16_colons = parray count parse_h16_colon_as_string

        return h16_colons |> Seq.toArray |> String.concat ""
    }


let parse_h16_sequence_exactly
    (count: int)

    : Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        if count = 0 then
            return ""
        else
            let! first_h16 = parse_h16_as_string

            let! remaining_h16s =
                parray
                    (count - 1)
                    (parser {
                        do! skipcode_point ':'
                        let! h16 = parse_h16_as_string

                        return $":{h16}"
                    })

            return
                seq {
                    yield first_h16
                    yield! remaining_h16s
                }
                |> String.concat ""
    }


let parse_optional_h16_sequence_up_to
    (maximum_count: int)

    : Parser<string, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    choice [ for count in [ maximum_count .. -1 .. 1 ] do
                 parse_h16_sequence_exactly count

             parser { return "" } ]


let parse_ipv6address_alternative_1: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! h16_colons = parse_h16_colon_sequence_exactly 6
        let! ls32 = LS32.parse

        return FromSixH16ColonThenLS32(% $"{h16_colons}{ls32.as_string}")
    }


let parse_ipv6address_alternative_2: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        do! parse_double_colon

        let! h16_colons = parse_h16_colon_sequence_exactly 5
        let! ls32 = LS32.parse

        return FromDoubleColonThenFiveH16ColonThenLS32(% $"::{h16_colons}{ls32.as_string}")
    }


let parse_ipv6address_alternative_3: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 1

        do! parse_double_colon

        let! h16_colons = parse_h16_colon_sequence_exactly 4
        let! ls32 = LS32.parse

        return FromOptionalOneH16ThenDoubleColonThenFourH16ColonThenLS32(% $"{prefix}::{h16_colons}{ls32.as_string}")
    }


let parse_ipv6address_alternative_4: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 2

        do! parse_double_colon

        let! h16_colons = parse_h16_colon_sequence_exactly 3
        let! ls32 = LS32.parse

        return FromOptionalTwoH16ThenDoubleColonThenThreeH16ColonThenLS32(% $"{prefix}::{h16_colons}{ls32.as_string}")
    }


let parse_ipv6address_alternative_5: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 3

        do! parse_double_colon

        let! h16_colons = parse_h16_colon_sequence_exactly 2
        let! ls32 = LS32.parse

        return FromOptionalThreeH16ThenDoubleColonThenTwoH16ColonThenLS32(% $"{prefix}::{h16_colons}{ls32.as_string}")
    }


let parse_ipv6address_alternative_6: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 4

        do! parse_double_colon

        let! h16_colon = parse_h16_colon_as_string
        let! ls32 = LS32.parse

        return FromOptionalFourH16ThenDoubleColonThenOneH16ColonThenLS32(% $"{prefix}::{h16_colon}{ls32.as_string}")
    }


let parse_ipv6address_alternative_7: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 5

        do! parse_double_colon

        let! ls32 = LS32.parse

        return FromOptionalFiveH16ThenDoubleColonThenLS32(% $"{prefix}::{ls32.as_string}")
    }


let parse_ipv6address_alternative_8: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 6

        do! parse_double_colon

        let! h16 = parse_h16

        return FromOptionalSixH16ThenDoubleColonThenH16(% $"{prefix}::{h16}")
    }


let parse_ipv6address_alternative_9: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parser {
        let! prefix = parse_optional_h16_sequence_up_to 7

        do! parse_double_colon

        return FromOptionalSevenH16ThenDoubleColon(% $"{prefix}::")
    }


let parse_IPv6address: Parser<IPv6address, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =

    parse_expecting
        (choice [ parse_ipv6address_alternative_1
                  parse_ipv6address_alternative_2
                  parse_ipv6address_alternative_3
                  parse_ipv6address_alternative_4
                  parse_ipv6address_alternative_5
                  parse_ipv6address_alternative_6
                  parse_ipv6address_alternative_7
                  parse_ipv6address_alternative_8
                  parse_ipv6address_alternative_9 ])
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

[<Measure>]
type ip_literal

type IP_Literal =
    | FromIPv6address of IPv6address
    | FromIPvFuture of IPvFuture

    member this.as_string: string<ip_literal> =
        match this with
        | FromIPv6address ipv6address -> % $"[{ipv6address.as_string}]"
        | FromIPvFuture ipvfuture -> % $"[{ipvfuture.as_string}]"

    static member parse: Parser<IP_Literal, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {
                do! skipcode_point '['

                let! ip_literal =
                    choice [ parse_IPv6address |>> FromIPv6address
                             IPvFuture.parse |>> FromIPvFuture ]

                do! skipcode_point ']'

                return ip_literal
            })
            """
IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
"""

[<Measure>]
type Port


let parse_Port: Parser<string<Port>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_expecting
        (skipcode_point ':'
         >>. many1 (material_element_of Augmented_Bacus_Naur_Form.digit)
         |>> fun digits ->
                 digits
                 |> Seq.map char
                 |> Seq.toArray
                 |> String
                 |> UMX.tag<Port>


        )
        """ port          = *DIGIT 
        empty port delimiter rejected as per rfc3986 section 3.2 Authority
        producers and normalizers should omit the ":" delimiter that separates host from port if the port component is empty"""





[<Measure>]
type resource_scheme



let parse_resource_scheme: Parser<string<resource_scheme>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_expecting
        (material_element_of Augmented_Bacus_Naur_Form.alpha
         .>>. many (material_element_of scheme)
         |>> fun struct (head, tail) ->
                 let chars =
                     Seq.insertAt 0 head tail
                     |> Seq.map char
                     |> Seq.toArray

                 % String(chars)


        )
        """ scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." ) """














































let parse_percent_encoded_many_skip_sigil_prefix<[<Measure>] 'MeasureType>
    (sigil: char)
    (material_set: Set_Definition<int>)
    (expecting: string)
    : Parser<string<'MeasureType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {

        do! skipcode_point sigil

        let! immutable_array =
            many (parse_code_point_or_Percent_Encoded_Character_expecting<'MeasureType> material_set expecting)

        return
            immutable_array
            |> ImmutableArray.of_strings_to_measured_string<'MeasureType>
    }

let parse_percent_encoded_many_skip_sigil_postfix<[<Measure>] 'MeasureType>
    (material_set: Set_Definition<int>)
    (sigil: char)
    (expecting: string)
    : Parser<string<'MeasureType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {


        let! immutable_array =
            many (parse_code_point_or_Percent_Encoded_Character_expecting<'MeasureType> material_set expecting)

        do! skipcode_point sigil

        return
            immutable_array
            |> ImmutableArray.of_strings_to_measured_string<'MeasureType>
    }




let parse_percent_encoded_many1<[<Measure>] 'MeasureType>
    (material_set: Set_Definition<int>)
    (expecting: string)
    : Parser<string<'MeasureType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {


        let! immutable_array =
            many1 (parse_code_point_or_Percent_Encoded_Character_expecting<'MeasureType> material_set expecting)

        return
            immutable_array
            |> ImmutableArray.of_strings_to_measured_string<'MeasureType>

    }

let parse_percent_encoded_many<[<Measure>] 'MeasureType>
    (material_set: Set_Definition<int>)
    (expecting: string)
    : Parser<string<'MeasureType>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parser {


        let! immutable_array =
            many (parse_code_point_or_Percent_Encoded_Character_expecting<'MeasureType> material_set expecting)

        return
            immutable_array
            |> ImmutableArray.of_strings_to_measured_string<'MeasureType>

    }






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
