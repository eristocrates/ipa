open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Language\Meta\Bacus_Naur_Form\Augmented\Augmented_Bacus_Naur_Form.fsx"

open XParsec

open XParsecErgonomics
open UnicodeStandard




















let sub_delims =
    {

      partition_name = "sub-delims"
      unicodepoint_set =
        {

          unicodepoint_ranges = [||]
          unicodepoint_rosters = [| Unicodepoint_Roster.from'string "!$&'()*+,;=" |]

        }


    }

let gen_delims =
    {

      partition_name = "gen-delims"
      unicodepoint_set =
        {

          unicodepoint_ranges = [||]
          unicodepoint_rosters = [| Unicodepoint_Roster.from'string ":/?#[]@" |]

        }


    }


let reserved =
    {

      partition_name = "reserved"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       gen_delims.unicodepoint_set
                                       sub_delims.unicodepoint_set

                                        |]

    }


let unreserved =

    {

      partition_name = "unreserved"
      unicodepoint_set =
        Unicodepoint_Set.from'union [| Augmented_Bacus_Naur_Form.alpha.unicodepoint_set
                                       Augmented_Bacus_Naur_Form.digit.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.hyphen_minus
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.full_stop
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.low_line
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.tilde |]

    }



let HEXDIG =
    {

      partition_name = "HEXDIG"
      unicodepoint_set = Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.hexadecimal.digits.unicodepoint_set

    }

let reg_name =

    {

      partition_name = "reg-name"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       unreserved.unicodepoint_set
                                       sub_delims.unicodepoint_set

                                        |]

    }

let userinfo =

    {

      partition_name = "userinfo"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       reg_name.unicodepoint_set
                                       Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.colon

                                        |]

    }

let segment_nz_nc =

    {

      partition_name = "segment-nz-nc"
      unicodepoint_set =

        Unicodepoint_Set.from'union [| reg_name.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.commercial_at |]

    }


let pchar_ =
    {

      partition_name = "pchar"
      unicodepoint_set =

        Unicodepoint_Set.from'union [| segment_nz_nc.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.colon |]

    }

let fragment =
    {

      partition_name = "fragment"
      unicodepoint_set =

        Unicodepoint_Set.from'union [|

                                       pchar_.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.solidus
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.question_mark

                                        |]

    }

let query_ =
    {

      partition_name = "query"
      unicodepoint_set = fragment.unicodepoint_set

    }

let segment_nz =
    {

      partition_name = "segment-nz"
      unicodepoint_set = pchar_.unicodepoint_set

    }

let segment =
    {

      partition_name = "segment"
      unicodepoint_set = pchar_.unicodepoint_set

    }

let abempty =
    {

      partition_name = "path-abempty"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       segment.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.solidus

                                        |]

    }


let scheme =

    {

      partition_name = "scheme"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       Augmented_Bacus_Naur_Form.alpha.unicodepoint_set
                                       Augmented_Bacus_Naur_Form.digit.unicodepoint_set
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.plus_sign
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.hyphen_minus
                                       UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.full_stop

                                        |]

    }














[<Struct>]
type Subcomponent_Delimiter_Character =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Subcomponent_Delimiter_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from sub_delims
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """

[<Struct>]
type General_Component_Delimiter_Character =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<General_Component_Delimiter_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from gen_delims
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ gen-delims  = ":" / "/" / "?" / "#" / "[" / "]" / "@" """

[<Struct>]
type Unreserved_Character =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Unreserved_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from unreserved
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" """

[<Struct>]
type Reserved_Character =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Reserved_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from reserved
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ reserved      = gen-delims / sub-delims """

[<Struct>]
type Percent_Encoded_Character =
    {

      left_digit: Unicodepoint
      right_digit: Unicodepoint
      as'literal: string
      as'unicodepoint: Unicodepoint

     }

    static member parse: Parser<Percent_Encoded_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '%'
                let! left_hex_digit = unicodepoint_from HEXDIG
                let! right_hex_digit = unicodepoint_from HEXDIG

                return (left_hex_digit, right_hex_digit)

             }
             |>> fun (left_hex_digit, right_hex_digit) ->
                     let encoded_literal = $"%%{left_hex_digit.as'string}{right_hex_digit.as'string}"

                     let unicodepoint =
                         Unicodepoint.from'hexadecimal_digit_string
                             $"{left_hex_digit.as'string}{right_hex_digit.as'string}"

                     {

                       left_digit = left_hex_digit
                       right_digit = right_hex_digit
                       as'literal = encoded_literal
                       as'unicodepoint = unicodepoint

                     }

            )

            """pct-encoded   = "%" HEXDIG HEXDIG"""

    static member or'unicodepoint_from(partition: Unicode_Partition) =
        choice [

                 unicodepoint_from partition
                 Percent_Encoded_Character.parse
                 |>> fun percent_encoded_character ->
                         {

                           as'string = percent_encoded_character.as'unicodepoint.as'string
                           as'int = percent_encoded_character.as'unicodepoint.as'int

                         }

                  ]

[<Struct>]
type PCharacter =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<PCharacter, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (Percent_Encoded_Character.or'unicodepoint_from pchar_
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     }


            )
            """ pchar         = unreserved / pct-encoded / sub-delims / ":" / "@" """

[<Struct>]
type Fragment =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Fragment, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            skip_unicodepoint '#'
            >>. many (Percent_Encoded_Character.or'unicodepoint_from fragment)
            |>> fun unicodepoints ->

                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray

                    }

            )
            """ fragment      = *( pchar / "/" / "?" ) """



[<Struct>]
type Query =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Query, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            skip_unicodepoint '?'
            >>. many (Percent_Encoded_Character.or'unicodepoint_from query_)
            |>> fun unicodepoints ->

                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray

                    }

            )
            """ query      = *( pchar / "/" / "?" ) """



[<Struct>]
type Segment =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array
      guaranteed'nonzero_length: bool
      excludes'colon: bool

     }

    static member parse'nonzero_noncolon: Parser<Segment, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            many1 (Percent_Encoded_Character.or'unicodepoint_from segment_nz_nc)
            |>> fun unicodepoints ->

                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray
                      guaranteed'nonzero_length = true
                      excludes'colon = true

                    }

            )
            """ segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":" """

    static member parse'nonzero: Parser<Segment, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            many1 (Percent_Encoded_Character.or'unicodepoint_from pchar_)
            |>> fun unicodepoints ->

                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray
                      guaranteed'nonzero_length = true
                      excludes'colon = false

                    }

            )
            """ segment-nz    = 1*pchar """

    static member parse: Parser<Segment, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            many (Percent_Encoded_Character.or'unicodepoint_from pchar_)
            |>> fun unicodepoints ->

                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray
                      guaranteed'nonzero_length = false
                      excludes'colon = false

                    }

            )
            """ segment       = *pchar """

[<Struct>]
type Registered_Name =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Registered_Name, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (many (Percent_Encoded_Character.or'unicodepoint_from reg_name)
             |>> fun unicodepoints ->

                     {

                       as'string = unicodepoints |> Unicodepoint.sequence'to'string
                       as'unicodepoints = unicodepoints |> Seq.toArray

                     }

            )
            """ reg-name      = *( unreserved / pct-encoded / sub-delims ) """


type Decimal_Octet =
    {

      as'string: string
      as'int: int

     }


    static member parse'0_9: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from Augmented_Bacus_Naur_Form.digit
             .>> notFollowedBy (unicodepoint_from Augmented_Bacus_Naur_Form.digit)
             |>> fun single_digit ->
                     {

                       as'int = single_digit.as'int
                       as'string = single_digit.as'string

                     })
            """     DIGIT                 ; 0-9 """

    static member parse'10_99: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_unicodepoint '1'
                let! rightDigit = unicodepoint_from Augmented_Bacus_Naur_Form.digit
                return (leftDigit, rightDigit)

             }
             |>> fun (leftDigit, rightDigit) ->
                     {

                       as'int = leftDigit.as'int * 10 + rightDigit.as'int
                       as'string = $"{leftDigit.as'string}{rightDigit.as'string}"

                     })
            """    %x31-39 DIGIT         ; 10-99 """

    static member parse'100_199: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_unicodepoint '1'
                let! centerDigit = unicodepoint_from Augmented_Bacus_Naur_Form.digit
                let! rightDigit = unicodepoint_from Augmented_Bacus_Naur_Form.digit
                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     {

                       as'int =
                           leftDigit.as'int * 100
                           + centerDigit.as'int * 10
                           + rightDigit.as'int
                       as'string = $"{leftDigit.as'string}{centerDigit.as'string}{rightDigit.as'string}"

                     })
            """    "1" 2DIGIT            ; 100-199 """

    static member parse'200_249: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_unicodepoint '2'

                let! centerDigit =
                    unicodepoint_from
                        UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.zero'to'four

                let! rightDigit = unicodepoint_from Augmented_Bacus_Naur_Form.digit
                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     {

                       as'int =
                           leftDigit.as'int * 100
                           + centerDigit.as'int * 10
                           + rightDigit.as'int
                       as'string = $"{leftDigit.as'string}{centerDigit.as'string}{rightDigit.as'string}"

                     })
            """    "2" %x30-34 DIGIT     ; 200-249 """

    static member parse'250_255: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_unicodepoint '2'
                let! centerDigit = parse_unicodepoint '5'

                let! rightDigit =
                    unicodepoint_from
                        UnicodeStandard.Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.zero'to'five

                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     {

                       as'int =
                           leftDigit.as'int * 100
                           + centerDigit.as'int * 10
                           + rightDigit.as'int
                       as'string = $"{leftDigit.as'string}{centerDigit.as'string}{rightDigit.as'string}"

                     })
            """  "25" %x30-35          ; 250-255 """

    static member parse: Parser<Decimal_Octet, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      Decimal_Octet.parse'250_255
                      Decimal_Octet.parse'200_249
                      Decimal_Octet.parse'100_199
                      Decimal_Octet.parse'10_99
                      Decimal_Octet.parse'0_9

                       ])
            """
    dec-octet     = DIGIT                 ; 0-9
                 / %x31-39 DIGIT         ; 10-99
                 / "1" 2DIGIT            ; 100-199
                 / "2" %x30-34 DIGIT     ; 200-249
                 / "25" %x30-35          ; 250-255
    """

[<Struct>]
type IPv4address =
    {

      outer_left_octet: Decimal_Octet
      inner_left_octet: Decimal_Octet
      inner_right_octet: Decimal_Octet
      outer_right_octet: Decimal_Octet
      as'unicodepoints: Unicodepoint array
      as'string: string

     }


    static member parse: Parser<IPv4address, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! outer_left = Decimal_Octet.parse
                do! skip_unicodepoint '.'
                let! inner_left = Decimal_Octet.parse
                do! skip_unicodepoint '.'
                let! inner_right = Decimal_Octet.parse
                do! skip_unicodepoint '.'
                let! outer_right = Decimal_Octet.parse
                return (outer_left, inner_left, inner_right, outer_right)


             }
             |>> fun (outer_left, inner_left, inner_right, outer_right) ->
                     {

                       outer_left_octet = outer_left
                       inner_left_octet = inner_left
                       inner_right_octet = inner_right
                       outer_right_octet = outer_right
                       as'unicodepoints =
                         [|

                            { as'string = outer_left.as'string
                              as'int = outer_left.as'int }
                            { as'string = inner_left.as'string
                              as'int = inner_left.as'int }
                            { as'string = inner_right.as'string
                              as'int = inner_right.as'int }
                            { as'string = outer_right.as'string
                              as'int = outer_right.as'int }

                            |]
                       as'string =
                         $"{outer_left.as'string}.{inner_left.as'string}.{inner_right.as'string}.{outer_right.as'string}"

                     }


            )
            """    IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet """

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

[<Struct>]
type Port =
    {

      as'int: int
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Port, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (skip_unicodepoint ':'
             >>. many1 (unicodepoint_from Augmented_Bacus_Naur_Form.digit)
             |>> fun unicodepoints ->

                     {

                       as'int =
                           unicodepoints
                           |> Seq.map (fun unicodepoint -> string unicodepoint.as'string)
                           |> String.concat ""
                           |> int
                       as'unicodepoints = unicodepoints |> Seq.toArray

                     }

            )
            """ port          = *DIGIT """

[<Struct>]
[<RequireQualifiedAccess>]
type Host_Kind =
    | IPv4address
    | Registered_Name
    | Internationalized_Registered_Name

[<Struct>]
type Host =
    {

      as_string: string
      as'unicodepoints: Unicodepoint array
      path_kind: Host_Kind

     }

    static member parse: Parser<Host, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      IPv4address.parse
                      |>> fun ipv4address ->
                              {

                                as_string = ipv4address.as'string
                                as'unicodepoints = ipv4address.as'unicodepoints
                                path_kind = Host_Kind.IPv4address

                              }
                      Registered_Name.parse
                      |>> fun registered_name ->
                              {

                                as_string = registered_name.as'string
                                as'unicodepoints = registered_name.as'unicodepoints
                                path_kind = Host_Kind.Registered_Name

                              }


                       ])
            """ host          =  IPv4address / reg-name """


[<Struct>]
type Userinfo =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Userinfo, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            many (Percent_Encoded_Character.or'unicodepoint_from userinfo)
            .>> skip_unicodepoint '@'
            |>> fun unicodepoints ->
                    {

                      as'string = unicodepoints |> Unicodepoint.sequence'to'string
                      as'unicodepoints = unicodepoints |> Seq.toArray

                    }

            )
            """ userinfo      = *( unreserved / pct-encoded / sub-delims / ":" ) """

[<Struct>]
type Authority =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array
      userinfo: Userinfo ValueOption
      host: Host
      port: Port ValueOption

     }



    static member parse: Parser<Authority, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {
                let! userinfo = opt Userinfo.parse
                let! host = Host.parse
                let! port = opt Port.parse
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                     let authority_string =
                         let userinfoString =
                             match userinfo_option with
                             | ValueSome userinfo -> $"{userinfo.as'string}@"
                             | _ -> String.Empty

                         let portString =
                             match port_option with
                             | ValueSome port -> $":{string port.as'int}"
                             | _ -> String.Empty

                         $"{userinfoString}{host.as_string}{portString}"

                     let unicodepoints =

                         let userinfoUnicodepoints =
                             match userinfo_option with
                             | ValueSome userinfo -> userinfo.as'unicodepoints
                             | _ -> [||]

                         let portUnicodepoints =
                             match port_option with
                             | ValueSome port -> [| Unicodepoint.from'int port.as'int |]
                             | _ -> [||]

                         Seq.concat [ userinfoUnicodepoints
                                      host.as'unicodepoints
                                      portUnicodepoints ]
                         |> Seq.toArray

                     {

                       as'string = authority_string
                       as'unicodepoints = unicodepoints
                       userinfo = userinfo_option
                       host = host
                       port = port_option

                     })
            """  authority     = [ userinfo "@" ] host [ ":" port ] """

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

[<Struct>]
type URI_Path =
    {

      as'string: string
      as'segments: Segment array
      path_segments: string array
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as'string = String.Empty
          as'segments = [||]
          path_segments = [||]
          path_kind = Path_Kind.empty

        }

    static member parse'rootless: Parser<URI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (Segment.parse'nonzero
             .>>. many (skip_unicodepoint '/' >>. Segment.parse)
             |>> fun struct (head, tail) ->
                     let segments = Seq.insertAt 0 head tail |> Seq.toArray

                     let path_segments =
                         segments
                         |> Array.map (fun segment -> segment.as'string)

                     {

                       path_segments = path_segments
                       as'string =
                         segments
                         |> Seq.map (fun segment -> segment.as'string)
                         |> String.concat "/"
                       as'segments = segments
                       path_kind = Path_Kind.rootless

                     })
            """ path-rootless = segment-nz *( "/" segment ) """

    static member parse'noscheme: Parser<URI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (Segment.parse'nonzero_noncolon
             .>>. many (skip_unicodepoint '/' >>. Segment.parse)
             |>> fun struct (head, tail) ->
                     let segments = Seq.insertAt 0 head tail |> Seq.toArray

                     let path_segments =
                         segments
                         |> Array.map (fun segment -> segment.as'string)

                     {

                       path_segments = path_segments

                       as'string =
                           segments
                           |> Seq.map (fun segment -> segment.as'string)
                           |> String.concat "/"
                       as'segments = segments
                       path_kind = Path_Kind.noscheme

                     })
            """ path-noscheme = segment-nz-nc *( "/" segment ) """

    static member parse'absolute: Parser<URI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (skip_unicodepoint '/'
             >>. opt (URI_Path.parse'rootless)
             |>> fun path_absolute_option ->
                     match path_absolute_option with
                     | ValueSome rootless_path ->
                         let path_segments =
                             rootless_path.as'segments
                             |> Array.map (fun segment -> segment.as'string)

                         {

                           path_segments = path_segments

                           as'string = "/" + (rootless_path.as'string)
                           as'segments = rootless_path.as'segments
                           path_kind = Path_Kind.absolute

                         }
                     | _ ->
                         { as'string = "/"
                           path_segments = [||]
                           as'segments = [||]
                           path_kind = Path_Kind.absolute

                         }



            )
            """ path-absolute = "/" [ segment-nz *( "/" segment ) ] """


    static member parse'abempty: Parser<URI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (many (skip_unicodepoint '/' >>. Segment.parse)
             |>> fun segments ->
                     if segments.Length > 0 then
                         let path_segments =
                             segments
                             |> Seq.toArray
                             |> Array.map (fun segment -> segment.as'string)

                         {

                           path_segments = path_segments

                           as'segments = segments |> Seq.toArray
                           path_kind = Path_Kind.abempty
                           as'string =
                             "/"
                             + (segments
                                |> Seq.map (fun segment -> segment.as'string)
                                |> String.concat "/")

                         }

                     else
                         URI_Path.Empty


            )
            """ path-abempty  = *( "/" segment ) """




[<Struct>]
type Scheme =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }


    static member parse: Parser<Scheme, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from Augmented_Bacus_Naur_Form.alpha
             .>>. many (unicodepoint_from scheme)
             |>> fun struct (head, tail) ->
                     let unicodepoints = Seq.insertAt 0 head tail |> Seq.toArray

                     {

                       as'string = unicodepoints |> Unicodepoint.sequence'to'string
                       as'unicodepoints = unicodepoints

                     }

            )
            """ scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." ) """

[<Struct>]
type URI_Part =
    {

      as'string: string
      authority: Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member parse: Parser<URI_Part, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (opt (
                choice [ parser {
                             do! skip_unicodepoint '/'
                             do! skip_unicodepoint '/'
                             let! authority = Authority.parse
                             let! path_abempty = URI_Path.parse'abempty
                             return (authority, path_abempty)
                         }
                         |>> fun (authority, path_abempty) ->
                                 {

                                   as'string = $"//{authority.as'string}{path_abempty.as'string}"
                                   authority = ValueSome authority
                                   uri_path = path_abempty
                                   path_kind = Path_Kind.authority_abempty

                                 }

                         URI_Path.parse'absolute
                         |>> fun absolute_path ->
                                 {

                                   as'string = absolute_path.as'string
                                   authority = ValueNone
                                   uri_path = absolute_path
                                   path_kind = absolute_path.path_kind

                                 }

                          ]
             )
             |>> fun relative_part_option ->
                     defaultValueArg
                         relative_part_option
                         {

                           as'string = String.Empty
                           authority = ValueNone
                           uri_path = URI_Path.Empty
                           path_kind = Path_Kind.empty

                         }

            )
            """
             "//" authority path-abempty
             / path-absolute
             
"""




[<Struct>]
type Relative_Part =
    {

      as'string: string
      authority: Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as'string = String.Empty
          authority = ValueNone
          uri_path = URI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Relative_Part, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (opt (
                choice [ URI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as'string = uri_part.as'string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }

                         URI_Path.parse'noscheme
                         |>> fun noscheme_path ->
                                 {

                                   as'string = noscheme_path.as'string
                                   authority = ValueNone
                                   uri_path = noscheme_path
                                   path_kind = noscheme_path.path_kind

                                 }

                          ]
             )
             |>> fun relative_part_option -> defaultValueArg relative_part_option Relative_Part.Empty

            )
            """
relative-part = "//" authority path-abempty
             / path-absolute
             / path-noscheme
             / path-empty
"""

[<Struct>]
type Relative_Reference =
    {

      as'string: string
      relative_part: Relative_Part
      query: Query voption
      fragment: Fragment voption }

    static member parse: Parser<Relative_Reference, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! relative_part = Relative_Part.parse
                let! query = opt Query.parse
                let! fragment = opt Fragment.parse
                return (relative_part, query, fragment)
             }
             |>> fun (relative_part, query_option, fragment_option) ->

                     let queryString =
                         match query_option with
                         | ValueSome query -> $"?{query.as'string}"
                         | _ -> String.Empty

                     let fragmentString =
                         match fragment_option with
                         | ValueSome fragment -> $"#{fragment.as'string}"
                         | _ -> String.Empty

                     {

                       as'string = $"{relative_part.as'string}{queryString}{fragmentString}"
                       relative_part = relative_part
                       query = query_option
                       fragment = fragment_option

                     }

            )
            """ relative-ref  = relative-part [ "?" query ] [ "#" fragment ] """

[<Struct>]
type Hierarchical_Part =
    {

      as'string: string
      authority: Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as'string = String.Empty
          authority = ValueNone
          uri_path = URI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Hierarchical_Part, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (opt (
                choice [

                         URI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as'string = uri_part.as'string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }
                         URI_Path.parse'rootless
                         |>> fun rootless_path ->
                                 {

                                   as'string = rootless_path.as'string
                                   authority = ValueNone
                                   uri_path = rootless_path
                                   path_kind = rootless_path.path_kind

                                 }

                          ]
             )
             |>> fun hierarchical_part_option -> defaultValueArg hierarchical_part_option Hierarchical_Part.Empty)
            """
hier-part     = "//" authority path-abempty
             / path-absolute
             / path-rootless
             / path-empty
"""

[<Struct>]
type Absolute_URI =
    {

      as'string: string
      scheme: Scheme
      hierarchical_part: Hierarchical_Part
      query: Query voption

     }

    static member parse: Parser<Absolute_URI, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! scheme = Scheme.parse
                do! skip_unicodepoint ':'
                let! hierarchical_part = Hierarchical_Part.parse
                let! query = opt Query.parse
                return (scheme, hierarchical_part, query)
             }
             |>> fun (scheme, hierarchical_part, query_option) ->

                     let queryString =
                         match query_option with
                         | ValueSome query -> $"?{query.as'string}"
                         | _ -> String.Empty


                     {

                       as'string = $"{scheme.as'string}:{hierarchical_part.as'string}{queryString}"
                       scheme = scheme
                       hierarchical_part = hierarchical_part
                       query = query_option

                     }

            )
            """ absolute-URI  = scheme ":" hier-part [ "?" query ] """

[<Struct>]
type URI =
    {

      as'string: string
      scheme: Scheme
      hierarchical_part: Hierarchical_Part
      query: Query voption
      fragment: Fragment voption

     }

    static member parse: Parser<URI, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! absolute_uri = Absolute_URI.parse
                let! fragment = opt Fragment.parse
                return (absolute_uri, fragment)
             }
             |>> fun (absolute_uri, fragment_option) ->


                     let fragmentString =
                         match fragment_option with
                         | ValueSome fragment -> $"#{fragment.as'string}"
                         | _ -> String.Empty

                     {

                       as'string = $"{absolute_uri.as'string}{fragmentString}"
                       scheme = absolute_uri.scheme
                       hierarchical_part = absolute_uri.hierarchical_part
                       query = absolute_uri.query
                       fragment = fragment_option

                     }

            )
            """ URI         = scheme ":" hier-part [ "?" query ] [ "#" fragment ] """

[<Struct>]
type URI_Reference =
    {

      as'string: string
      uri: URI voption
      relative_reference: Relative_Reference voption
      is'relative: bool

     }

    static member parse: Parser<URI_Reference, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      URI.parse
                      |>> fun uri ->
                              {

                                as'string = uri.as'string
                                uri = ValueSome uri
                                relative_reference = ValueNone
                                is'relative = false

                              }
                      Relative_Reference.parse
                      |>> fun relative_reference ->
                              {

                                as'string = relative_reference.as'string
                                uri = ValueNone
                                relative_reference = ValueSome relative_reference
                                is'relative = true

                              }

                       ])
            """ URI-reference = URI / relative-ref """

// let test = result'from_parse URI.parse OnInput "https://aaronandclaire.com/the-easiest-chicken-katsu-recipe/"
