#time on

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Threading.Tasks
open System.Diagnostics
open Microsoft.FSharp.Collections
#r "nuget: UUIDNext"
open UUIDNext
#r "nuget: XParsec"
open XParsec
#r "nuget: BitFaster.Caching"
open BitFaster.Caching
#r "nuget: LightningDB"
open LightningDB
#r "nuget: Blake3"
open Blake3
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0"
#r "Ergonomic_Extensions.dll"
#r "Unicodepoint.dll"
#r "Interval_Range.dll"
#r "NeatIntervals.dll"
#r "FRange.dll"
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Interval_Range
open BitFaster.Caching.Lfu


#r "nuget: CommunityToolkit.HighPerformance, 8.4.0"

open System
open System.Buffers
open System.Text
open CommunityToolkit.HighPerformance.Buffers

let string_pool = StringPool.Shared
module String_Pool = 

    let from_code_line
        (code_line: Code_Line)
        : string =

        // Every Unicode scalar requires either one or two UTF-16 code units.
        let char_buffer =
            ArrayPool<char>.Shared.Rent(code_line.Length * 2)

        try
            let mutable char_count = 0

            for code_point in code_line do
                let rune = Rune(code_point)

                char_count <-
                    char_count
                    + rune.EncodeToUtf16(
                        char_buffer.AsSpan(char_count)
                    )

            string_pool.GetOrAdd(
                ReadOnlySpan<char>(
                    char_buffer,
                    0,
                    char_count
                )
            )
        finally
            ArrayPool<char>.Shared.Return(char_buffer)





module Code_Point_Rule =


    // TODO deal with octet map, since this has more than 255 values
    let ucschar =
        {

          code_points =

              Array.concat [| 0xA0 +-+ 0xD7FF |> Interval_Range.as_array
                              0xF900 +-+ 0xFDCF |> Interval_Range.as_array
                              0xFDF0 +-+ 0xFFEF |> Interval_Range.as_array
                              0x10000 +-+ 0x1FFFD |> Interval_Range.as_array
                              0x20000 +-+ 0x2FFFD |> Interval_Range.as_array
                              0x30000 +-+ 0x3FFFD |> Interval_Range.as_array
                              0x40000 +-+ 0x4FFFD |> Interval_Range.as_array
                              0x50000 +-+ 0x5FFFD |> Interval_Range.as_array
                              0x60000 +-+ 0x6FFFD |> Interval_Range.as_array
                              0x70000 +-+ 0x7FFFD |> Interval_Range.as_array
                              0x80000 +-+ 0x8FFFD |> Interval_Range.as_array
                              0x90000 +-+ 0x9FFFD |> Interval_Range.as_array
                              0xA0000 +-+ 0xAFFFD |> Interval_Range.as_array
                              0xB0000 +-+ 0xBFFFD |> Interval_Range.as_array
                              0xC0000 +-+ 0xCFFFD |> Interval_Range.as_array
                              0xD0000 +-+ 0xDFFFD |> Interval_Range.as_array
                              0xE1000 +-+ 0xEFFFD |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                      ucschar        = %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
                                                      / %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
                                                      / %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
                                                      / %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
                                                      / %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
                                                      / %xD0000-DFFFD / %xE1000-EFFFD

                                  """

        }

    let pn_chars_base =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Latin_Majuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Latin_Minuscule
                              |> Interval_Range.as_array
                              0x00C0 +-+ 0x00D6 |> Interval_Range.as_array
                              0x00D8 +-+ 0x00F6 |> Interval_Range.as_array
                              0x00F8 +-+ 0x02FF |> Interval_Range.as_array
                              0x0370 +-+ 0x037D |> Interval_Range.as_array
                              0x037F +-+ 0x1FFF |> Interval_Range.as_array
                              0x200C +-+ 0x200D |> Interval_Range.as_array
                              0x2070 +-+ 0x218F |> Interval_Range.as_array
                              0x2C00 +-+ 0x2FEF |> Interval_Range.as_array
                              0x3001 +-+ 0xD7FF |> Interval_Range.as_array
                              0xF900 +-+ 0xFDCF |> Interval_Range.as_array
                              0xFDF0 +-+ 0xFFFD |> Interval_Range.as_array
                              0x10000 +-+ 0xEFFFF |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                    PN_CHARS_BASE     ::= ([A-Z]
                                                        | [a-z]
                                                        | [#x00C0-#x00D6]
                                                        | [#x00D8-#x00F6]
                                                        | [#x00F8-#x02FF]
                                                        | [#x0370-#x037D]
                                                        | [#x037F-#x1FFF]
                                                        | [#x200C-#x200D]
                                                        | [#x2070-#x218F]
                                                        | [#x2C00-#x2FEF]
                                                        | [#x3001-#xD7FF]
                                                        | [#xF900-#xFDCF]
                                                        | [#xFDF0-#xFFFD]
                                                        | [#x10000-#xEFFFF])
                                    
                                  """

        }

    let pn_chars_u =
        {

          code_points =

              Array.concat [|

                              pn_chars_base.code_points
                              [| int '_' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                        PN_CHARS_U        ::=  PN_CHARS_BASE | '_'                                        
                                  """

        }

    let pn_chars =
        {

          code_points =

              Array.concat [|

                              pn_chars_u.code_points
                              [| int '-' |]
                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              [| 0x00B7 |]
                              0x0300 +-+ 0x036F |> Interval_Range.as_array
                              0x203F +-+ 0x2040 |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                  
                                        PN_CHARS_U        ::=  PN_CHARS_BASE | '_'                                        
                                  """

        }


    let sub_delims =

        {

          code_points =
              Code_Line.from_chars_sorted [| '!'
                                             '$'
                                             '&'
                                             '''
                                             '('
                                             ')'
                                             '*'
                                             '+'
                                             ','
                                             ';'
                                             '=' |]

          metasyntax =

              """
                                  sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "="
                                  """

        }


    let gen_delims =

        {

          code_points =
              Code_Line.from_chars_sorted [|

                                             ':'
                                             '/'
                                             '?'
                                             '#'
                                             '['
                                             ']'
                                             '@'


                                              |]

          metasyntax =

              """
                                  gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
                                  """

        }


    let reserved =
        {

          code_points =

              Array.concat [|

                              gen_delims.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                  reserved      = gen-delims / sub-delims
                                  """

        }




    let unreserved =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Latin_Majuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Latin_Minuscule
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              (Code_Line.from_chars [| '-'
                                                       '.'
                                                       '_'
                                                       '~' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                                  """

        }

    let iunreserved =
        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              ucschar.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                              iunreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar
                              """

        }


    let hexdigit =
        {

          code_points =

              Array.concat [|

                              Unicodepoint.Partition.Ascii_Digits
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.A_to_F
                              |> Interval_Range.as_array
                              Unicodepoint.Partition.a_to_f
                              |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                      HEXDIG = DIGIT / "A" / "B" / "C" / "D" / "E" / "F"
                                      overridden to case insensitive
                                      """

        }



    let userinfo =

        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              sub_delims.code_points
                              [| int ':' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                        unreserved / pct-encoded / sub-delims / ":"  
                                      """

        }

    let iuserinfo =

        {

          code_points =

              Array.concat [|

                              iunreserved.code_points
                              sub_delims.code_points
                              [| int ':' |]

                               |]
              |> Array.sort

          metasyntax =

              """
                                     iunreserved / pct-encoded / sub-delims / ":"   
                                  """

        }


    let reg_name =
        {

          code_points =

              Array.concat [|

                              unreserved.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                   unreserved / pct-encoded / sub-delims 
                                  """

        }

    let ireg_name =
        {

          code_points =

              Array.concat [|

                              iunreserved.code_points
                              sub_delims.code_points

                               |]
              |> Array.sort

          metasyntax =

              """
                                   iunreserved / pct-encoded / sub-delims 
                                  """

        }

    let pchar_unencoded_noncolon =
        {

          code_points =

              Array.concat [|

                              reg_name.code_points
                              (Code_Line.from_chars [| '@' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                                  """

        }

    let ipchar_unencoded_noncolon =
        {

          code_points =

              Array.concat [|

                              ireg_name.code_points
                              (Code_Line.from_chars [| '@' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                                  """

        }

    let pchar_unencoded =
        {

          code_points =

              Array.concat [|

                              pchar_unencoded_noncolon.code_points
                              (Code_Line.from_chars [| ':' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let ipchar_unencoded =
        {

          code_points =

              Array.concat [|

                              ipchar_unencoded_noncolon.code_points
                              (Code_Line.from_chars [| ':' |])

                               |]
              |> Array.sort

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }


    let iprivate =
        {

          code_points =

              Array.concat [| 0xE000 +-+ 0xF8FF |> Interval_Range.as_array
                              0xF0000 +-+ 0xFFFFD |> Interval_Range.as_array
                              0x100000 +-+ 0x10FFFD |> Interval_Range.as_array

                               |]
              |> Array.sort

          metasyntax =

              """
                                   iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD 
                                  """

        }


















module Code_Line_Rule =
    open Code_Point_Rule

    let pct_encoded =
        {

          code_line_parser =
              parser {
                  let! sigil = parse_char '%'
                  let! left_digit = hexdigit.code_point_parser
                  let! right_digit = hexdigit.code_point_parser


                  return [| sigil; left_digit; right_digit |]


              }

          metasyntax =

              """
                                  pct-encoded    = "%" HEXDIG HEXDIG
                                  """

        }

    let pchar_encoded =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ pchar_unencoded.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let ipchar_encoded =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ ipchar_unencoded.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@"
                                  """

        }

    let pchar_encoded_noncolon =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ pchar_unencoded_noncolon.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  pchar         = unreserved / pct-encoded / sub-delims / "@"
                                  """

        }

    let ipchar_encoded_noncolon =
        {

          code_line_parser =
              parser {



                  return!
                      choice [ ipchar_unencoded_noncolon.code_point_parser
                               |>> (fun code_point -> [| code_point |])
                               pct_encoded.code_line_parser ]


              }

          metasyntax =

              """
                                  ipchar         = iunreserved / pct-encoded / sub-delims / "@"
                                  """

        }


    let query_fragment =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   pchar_encoded.code_line_parser
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])




                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  fragment      = *( pchar / "/" / "?" )
                                  """

        }

    let ifragment =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   ipchar_encoded.code_line_parser
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])



                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  ifragment      = *( ipchar / "/" / "?" )
                                  """

        }

    let iquery =
        {

          code_line_parser =
              parser {

                  let! immutable_code_square =

                      many (
                          choice [

                                   ipchar_encoded.code_line_parser
                                   iprivate.code_point_parser
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '/'
                                   |>> (fun code_point -> [| code_point |])
                                   parse_char '?'
                                   |>> (fun code_point -> [| code_point |])



                                    ]
                      )

                  return Code_Line.from_immutable_code_square immutable_code_square


              }

          metasyntax =

              """
                                  ifragment      = *( ipchar / "/" / "?" )
                                  """

        }





module Rfc_Types =
    open Code_Point_Rule
    open Code_Line_Rule







    let interval_0_4 = 0 +-+ 4
    let interval_0_5 = 0 +-+ 5
    let interval_1_9 = 1 +-+ 9











    type Octet =
        private
        | Octet of raw_string:string

        static member parser: Parser<Octet, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! digits =
                    choice [

                             tuple3 (parse_char '2') (parse_char '5') (any_point_from_interval interval_0_5)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple3
                                 (parse_char '2')
                                 (any_point_from_interval interval_0_4)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple3
                                 (parse_char '1')
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, center_digit, right_digit) ->
                                 [| left_digit
                                    center_digit
                                    right_digit |])
                             tuple2
                                 (any_point_from_interval interval_1_9)
                                 (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                             |>> (fun struct (left_digit, right_digit) -> [| left_digit; right_digit |])
                             any_point_from_interval Unicodepoint.Partition.Ascii_Digits
                             |>> (fun digit -> [| digit |])

                              ]
                 
                
                
                return String_Pool.from_code_line digits |> Octet

            }

        static member metasyntax =
            """
                                        dec-octet     = DIGIT                 ; 0-9
                                                     / %x31-39 DIGIT         ; 10-99
                                                     / "1" 2DIGIT            ; 100-199
                                                     / "2" %x30-34 DIGIT     ; 200-249
                                                     / "25" %x30-35          ; 250-255

                                      """

        static member parse(input_string: string) =
            match Octet.parser input_string.as_parser_input with
            | Ok success ->
                success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Octet.metasyntax)

        member this.as_raw_string =
            match this with
            | Octet raw_string -> raw_string
        member this.as_int = int this.as_raw_string




    type IPv4_Address =
        private
        | IPv4 of  string * Octet * Octet * Octet * Octet

        static member parser: Parser<IPv4_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! outer_left = Octet.parser
                do! skip_char '.'
                let! inner_left = Octet.parser
                do! skip_char '.'
                let! inner_right = Octet.parser
                do! skip_char '.'
                let! outer_right = Octet.parser
                let ipv4 = sprintf "%s.%s.%s.%s" outer_left.as_raw_string inner_left.as_raw_string inner_right.as_raw_string outer_right.as_raw_string
                return IPv4( ipv4, outer_left, inner_left, inner_right, outer_right)

            }

        static member metasyntax =
            """
                                        IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
                                      """

        static member parse(input_string: string) =
            match IPv4_Address.parser input_string.as_parser_input with
            | Ok success -> 
                  success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPv4_Address.metasyntax)

        member this.octets =
            match this with
            | IPv4 (_, outer_left, inner_left, inner_right, outer_right) ->
                [| outer_left
                   inner_left
                   inner_right
                   outer_right |]


        member this.outer_left:Octet = this.octets[0]
        member this.inner_left:Octet = this.octets[1]
        member this.inner_right:Octet = this.octets[2]
        member this.outer_right:Octet = this.octets[3]


        member this.as_raw_string =
            match this with 
            | IPv4 (raw_string,_,_,_,_)  -> raw_string






    type Hextet =
        private
        | Hextet of string
        static member parser: Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! immutable_code_line =

                    choice [

                             parray 4 (hexdigit.code_point_parser)
                             parray 3 (hexdigit.code_point_parser)
                             parray 2 (hexdigit.code_point_parser)
                             parray 1 (hexdigit.code_point_parser)

                              ]


                return 
                    Code_Line.from_immutable_code_line immutable_code_line
                    |> String_Pool.from_code_line
                    |> Hextet


            }

        static member colon_suffixed_parser: Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! h16 = Hextet.parser
                do! skip_char ':'

                return h16


            }

        static member metasyntax =

            """
                                      h16           = 1*4HEXDIG
                                      """

        static member parse(input_string: string) =
            match Hextet.parser input_string.as_parser_input with
            | Ok success ->

                success

            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Hextet.metasyntax)

        member this.as_raw_string =
            match this with
            | Hextet raw_string -> raw_string
        static member raw_string(hextet: Hextet) = hextet.as_raw_string






    type Least_Significant_32_Bits =
        | LeastSignificantHextets of Hextet * Hextet
        | LeastSignificantIPv4 of IPv4_Address


        static member parser: Parser<Least_Significant_32_Bits, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! ls32 =

                    choice [

                             Hextet.parser .>> skip_char ':' .>>. Hextet.parser
                             |>> (fun struct (left_hextet, right_hextet) ->
                                 LeastSignificantHextets(left_hextet, right_hextet))
                             IPv4_Address.parser |>> LeastSignificantIPv4

                              ]


                return ls32


            }

        static member metasyntax =
            """
                                        ls32          = ( h16 ":" h16 ) / IPv4address
                                        """

        static member parse(input_string: string) =
            match Least_Significant_32_Bits.parser input_string.as_parser_input with
            | Ok success -> 

              success
            | Error failure ->
                failwithf
                    "%A: %s"
                    failure
                    (code_line_message input_string.as_code_line Least_Significant_32_Bits.metasyntax)

        member this.substrings =
            match this with 
            | LeastSignificantHextets (left_hextet, right_hextet) -> [| left_hextet.as_raw_string; right_hextet.as_raw_string |]
            | LeastSignificantIPv4 (ipv4_address) ->
                [| ipv4_address.outer_left.as_raw_string
                   ipv4_address.inner_left.as_raw_string
                   ipv4_address.inner_right.as_raw_string
                   ipv4_address.outer_right.as_raw_string |]

        member this.as_rendered_string =
            match this with
            | LeastSignificantHextets (left_h16, right_h16) ->
                sprintf "%s:%s" left_h16.as_raw_string right_h16.as_raw_string
            | LeastSignificantIPv4 ipv4_address -> ipv4_address.as_raw_string



    type IPv6_Address =
        private
        | Six_h16__ls32 of string * Hextet array * Least_Significant_32_Bits
        | Five_h16__ls32 of string * Hextet array * Least_Significant_32_Bits
        | Maybe_One_h16__Four_h16__ls32 of string * Hextet voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Two_h16__Three_h16__ls32 of string * Hextet array voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Three_h16__Two_h16__ls32 of string * Hextet array voption * Hextet array * Least_Significant_32_Bits
        | Maybe_Four_h16__One_h16__ls32 of string * Hextet array voption * Hextet * Least_Significant_32_Bits
        | Maybe_Five_h16__ls32 of string * Hextet array voption * Least_Significant_32_Bits
        | Maybe_Six_h16__h16 of string * Hextet array voption * Hextet
        | Maybe_Seven_h16 of string * Hextet array voption



        ///  =                            6( h16 ":" ) ls32
        static member Six_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! hextets =
                    parray 6 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())

                let! ls32 = Least_Significant_32_Bits.parser
                let hextet_string = 
                    hextets
                    |> Array.map (fun hextet -> hextet.as_raw_string)
                    |> String.concat ":"
                let ipv6_string = sprintf "%s:%s" hextet_string ls32.as_rendered_string
                return Six_h16__ls32(ipv6_string, hextets, ls32)

            }

        ///                       "::" 5( h16 ":" ) ls32
        static member Five_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                do! skip_string "::"

                let! hextets =
                    parray 5 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())

                let! ls32 = Least_Significant_32_Bits.parser
                let hextet_string = 
                    "::" + (hextets
                    |> Array.map (fun hextet -> hextet.as_raw_string)
                    |> String.concat ":")
                let ipv6_string = sprintf "%s:%s" hextet_string ls32.as_rendered_string
                return Five_h16__ls32(ipv6_string, hextets, ls32)

            }

        /// [               h16 ] "::" 4( h16 ":" ) ls32
        static member Maybe_One_h16__Four_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_hextet = opt Hextet.parser
                do! skip_string "::"

                let! hextets =
                    parray 4 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                let maybe_hextet_string = 
                    match maybe_hextet with 
                    | ValueSome hextet -> sprintf "%s" hextet.as_raw_string
                    | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"


                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_One_h16__Four_h16__ls32(ipv6_string, maybe_hextet, hextets, ls32)

            }



        /// [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
        static member Maybe_Two_h16__Three_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_two_hextets =
                    opt (
                        choice [

                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"

                let! hextets =
                    parray 4 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_two_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_Two_h16__Three_h16__ls32(ipv6_string, maybe_two_hextets, hextets, ls32)



            }



        /// [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
        static member Maybe_Three_h16__Two_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_three_hextets =
                    opt (
                        choice [

                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"

                let! hextets =
                    parray 2 Hextet.colon_suffixed_parser
                    |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_three_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let hextet_string = 
                        hextets
                        |> Array.map (fun hextet -> hextet.as_raw_string)
                        |> String.concat ":"
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string hextet_string ls32.as_rendered_string
                return Maybe_Three_h16__Two_h16__ls32(ipv6_string, maybe_three_hextets, hextets, ls32)



            }

        /// [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
        static member Maybe_Four_h16__One_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_four_hextets =
                    opt (
                        choice [

                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! h16 = Hextet.colon_suffixed_parser
                let! ls32 = Least_Significant_32_Bits.parser

                let maybe_hextet_string = 
                        match maybe_four_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s:%s" maybe_hextet_string h16.as_raw_string ls32.as_rendered_string
                return Maybe_Four_h16__One_h16__ls32(ipv6_string, maybe_four_hextets, h16, ls32)



            }

        /// [ *4( h16 ":" ) h16 ] "::"              ls32
        static member Maybe_Five_h16__ls32_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_five_hextets =
                    opt (
                        choice [

                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! ls32 = Least_Significant_32_Bits.parser
                let maybe_hextet_string = 
                        match maybe_five_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s" maybe_hextet_string  ls32.as_rendered_string
                return Maybe_Five_h16__ls32(ipv6_string, maybe_five_hextets, ls32)



            }



        /// [ *5( h16 ":" ) h16 ] "::"              h16
        static member Maybe_Six_h16__h16_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_six_hextets =
                    opt (
                        choice [

                                 parray 5 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let! h16 = Hextet.parser
                let maybe_hextet_string = 
                        match maybe_six_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::%s" maybe_hextet_string  h16.as_raw_string
                return Maybe_Six_h16__h16(ipv6_string, maybe_six_hextets, h16)



            }

        /// [ *6( h16 ":" ) h16 ] "::"
        static member Maybe_Seven_h16_parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_seven_hextets =
                    opt (
                        choice [

                                 parray 5 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 4 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 3 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 parray 2 Hextet.colon_suffixed_parser
                                 .>>. Hextet.parser
                                 |>> (fun struct (immutable_hextets, h16) ->
                                     immutable_hextets.AsSpan().ToArray()
                                     |> Array.append [| h16 |])
                                 Hextet.colon_suffixed_parser .>>. Hextet.parser
                                 |>> (fun struct (h16_colon, h16) -> [| h16_colon; h16 |])
                                 Hextet.parser |>> (fun h16 -> [| h16 |])

                                  ]

                    )

                do! skip_string "::"
                let maybe_hextet_string = 
                        match maybe_seven_hextets with 
                        | ValueSome hextets ->
                            hextets
                            |> Array.map (fun hextet -> hextet.as_raw_string)
                            |> String.concat ":"
                        | ValueNone -> String.Empty
                let ipv6_string = sprintf "%s::" maybe_hextet_string
                return Maybe_Seven_h16( ipv6_string, maybe_seven_hextets)



            }

        static member parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! ipv6 =

                    choice [

                             IPv6_Address.Six_h16__ls32_parser
                             IPv6_Address.Five_h16__ls32_parser
                             IPv6_Address.Maybe_One_h16__Four_h16__ls32_parser
                             IPv6_Address.Maybe_Two_h16__Three_h16__ls32_parser
                             IPv6_Address.Maybe_Three_h16__Two_h16__ls32_parser
                             IPv6_Address.Maybe_Four_h16__One_h16__ls32_parser
                             IPv6_Address.Maybe_Five_h16__ls32_parser
                             IPv6_Address.Maybe_Six_h16__h16_parser
                             IPv6_Address.Maybe_Seven_h16_parser



                              ]


                return ipv6


            }

        static member metasyntax =
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

        static member parse(input_string: string) =
            match IPv6_Address.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPv6_Address.metasyntax)




        member this.as_raw_string = 
            match this with
            | Six_h16__ls32 (raw_string ,hextets, ls32) -> raw_string
            | Five_h16__ls32 (raw_string ,hextets, ls32) -> raw_string
            | Maybe_One_h16__Four_h16__ls32 (raw_string ,maybe_hextet, hextets, ls32) -> raw_string
            | Maybe_Two_h16__Three_h16__ls32 (raw_string ,maybe_two_hextets, hextets, ls32) -> raw_string
            | Maybe_Three_h16__Two_h16__ls32 (raw_string ,maybe_three_hextets, hextets, ls32) -> raw_string
            | Maybe_Four_h16__One_h16__ls32 (raw_string ,maybe_four_hextets, h16, ls32) -> raw_string
            | Maybe_Five_h16__ls32 (raw_string ,maybe_five_hextets, ls32) -> raw_string
            | Maybe_Six_h16__h16 (raw_string ,maybe_six_hextets, h16) -> raw_string
            | Maybe_Seven_h16 (raw_string , maybe_seven_hextets) -> raw_string
        member this.substrings = 
            match this with
            | Six_h16__ls32 (raw_string ,hextets, ls32) -> 
                Array.concat [|
                    hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                    ls32.substrings
                |]
            | Five_h16__ls32 (raw_string ,hextets, ls32) -> 
                Array.concat [|
                    hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                    ls32.substrings
                |]
            | Maybe_One_h16__Four_h16__ls32 (raw_string ,maybe_hextet, hextets, ls32) -> 
                match maybe_hextet with 
                | ValueSome hextet -> 
                    Array.concat [|
                        [|hextet.as_raw_string|]
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
                | ValueNone -> 
                    Array.concat [|
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
            | Maybe_Two_h16__Three_h16__ls32 (raw_string ,maybe_two_hextets, hextets, ls32) -> 
                match maybe_two_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
                | ValueNone -> 
                    Array.concat [|
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
            | Maybe_Three_h16__Two_h16__ls32 (raw_string ,maybe_three_hextets, hextets, ls32) -> 
                match maybe_three_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
                | ValueNone -> 
                    Array.concat [|
                        hextets |> Array.map (fun hextet -> hextet.as_raw_string)
                        ls32.substrings
                    |]
            | Maybe_Four_h16__One_h16__ls32 (raw_string ,maybe_four_hextets, h16, ls32) -> 
                match maybe_four_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                        [|h16.as_raw_string|]
                        ls32.substrings
                    |]
                | ValueNone -> 
                    Array.concat [|
                        [|h16.as_raw_string|]
                        ls32.substrings
                    |]
            | Maybe_Five_h16__ls32 (raw_string ,maybe_five_hextets, ls32) -> 
                match maybe_five_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                        ls32.substrings
                    |]
                | ValueNone -> ls32.substrings
            | Maybe_Six_h16__h16 (raw_string ,maybe_six_hextets, h16) -> 
                match maybe_six_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                        [|h16.as_raw_string|]
                    |]
                | ValueNone -> [|h16.as_raw_string|]
            | Maybe_Seven_h16 (raw_string , maybe_seven_hextets) -> 
                match maybe_seven_hextets with 
                | ValueSome h16s -> 
                    Array.concat [|
                        h16s |> Array.map (fun h16 -> h16.as_raw_string)
                    |]
                | ValueNone -> [||]

    type IPvFuture =
        private
        | IPvFuture of string * string * string


        static member parser: Parser<IPvFuture, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_any_from_string "vV"

                let! hexdigits =
                    many1 hexdigit.code_point_parser
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line |> String_Pool.from_code_line)

                do! skip_char '.'

                let! address =
                    many1 (userinfo.code_point_parser)
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line |> String_Pool.from_code_line)
                let ipvfuture_string = sprintf "%s.%s" hexdigits  address


                return IPvFuture(ipvfuture_string, hexdigits, address)


            }

        static member metasyntax =
            """
                                IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
                                """

        static member parse(input_string: string) =
            match IPvFuture.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IPvFuture.metasyntax)

        member this.substrings =
            match this with
            | IPvFuture (_, hexdigits, address) -> [| hexdigits; address |]
        member this.version =
            match this with
            | IPvFuture (_, hexdigits, address) -> hexdigits
        member this.address =
            match this with
            | IPvFuture (_, hexdigits, address) -> address
        member this.as_raw_string =
            match this with
            | IPvFuture (string_index, hexdigits, address) -> string_index




    type IP_Literal =
        private
        | IPv6Literal of IPv6_Address
        | IPvFutureLiteral of IPvFuture


        static member parser: Parser<IP_Literal, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '['

                let! literal =
                    choice [ IPv6_Address.parser |>> IPv6Literal
                             IPvFuture.parser |>> IPvFutureLiteral ]

                do! skip_char ']'
                return literal


            }

        static member metasyntax =
            """
            IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
            """

        static member parse(input_string: string) =
            match IP_Literal.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IP_Literal.metasyntax)


        member this.substrings =
            match this with
            | IPv6Literal ipv6_address -> ipv6_address.substrings
            | IPvFutureLiteral ipvfuture -> ipvfuture.substrings
        member this.as_raw_string = 
                match this with
                | IPv6Literal ipv6_address -> ipv6_address.as_raw_string
                | IPvFutureLiteral ipvfuture -> ipvfuture.as_raw_string
        member this.as_rendered_string = sprintf "[%s]" this.as_raw_string

            



    type Port =
        private
        | Port of string
        static member parser: Parser<Port, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char ':'

                let! digits =
                    many (any_point_from_interval Unicodepoint.Partition.Ascii_Digits)
                    |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)

                return String_Pool.from_code_line digits |> Port

            }

        static member metasyntax =
            """
                                      ":" port
                                      port          = *DIGIT
                                      """

        static member parse(input_string: string) =
            match Port.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Port.metasyntax)

        member this.as_raw_string =
            match this with 
            | Port raw_string ->  raw_string

        member this.as_int = int this.as_raw_string
        member this.as_rendered_string = sprintf ":%s" this.as_raw_string


    // TODO consider pairing with iana scheme
    type Scheme =
        private
        | Scheme of string
        static member parser: Parser<Scheme, Code_Point, unit, ReadableMemory<Code_Point>> =

            parser {

                let! scheme_head =
                    choice [

                             Unicodepoint.Partition.Latin_Majuscule
                             |> any_point_from_interval
                             Unicodepoint.Partition.Latin_Minuscule
                             |> any_point_from_interval

                              ]

                let! scheme_tail =

                    many (
                        choice [


                                 Unicodepoint.Partition.Latin_Majuscule
                                 |> any_point_from_interval
                                 Unicodepoint.Partition.Latin_Minuscule
                                 |> any_point_from_interval
                                 Unicodepoint.Partition.Ascii_Digits
                                 |> any_point_from_interval
                                 parse_char '+'
                                 parse_char '-'
                                 parse_char '.'



                                  ]
                    )
                let scheme:Code_Line = 
                    Array.concat [| [| scheme_head |]
                                    scheme_tail.AsMemory().ToArray() |]

                return scheme |> String_Pool.from_code_line |> Scheme


            }

        static member metasyntax =
            """
                                      scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
                                      """

        static member parse(input_string: string) =
            match Scheme.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Scheme.metasyntax)

        member this.as_raw_string =
            match this with 
            | Scheme as_raw_string -> as_raw_string


        member this.as_rendered_string = this.as_raw_string.ToLowerInvariant() + ":"






    type Fragment =
        private
        | UniformFragment of string
        | InternationalizedFragment of string
        static member parser: Parser<Fragment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '#'

                let! fragment =
                    choice [ ifragment.code_line_parser
                             |>> (fun code_line -> code_line |> String_Pool.from_code_line |> InternationalizedFragment)
                             query_fragment.code_line_parser
                             |>> (fun code_line -> code_line |> String_Pool.from_code_line |> UniformFragment) ]

                return fragment

            }

        static member metasyntax =
            """
                                      ifragment      = *( ipchar / "/" / "?" )
                                      fragment      = *( pchar / "/" / "?" )
                                      """

        static member parse(input_string: string) =
            match Fragment.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Fragment.metasyntax)

        member this.as_raw_string =
            match this with 
            | InternationalizedFragment raw_string -> raw_string
            | UniformFragment raw_string -> raw_string
        member this.as_rendered_string = sprintf "#%s" this.as_raw_string


    type Query =
        private
        | InternationalizedQuery of string
        | UniformQuery of string
        static member parser: Parser<Query, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '?'

                return!
                    choice [ iquery.code_line_parser |>> (fun code_line -> code_line |> String_Pool.from_code_line |> InternationalizedQuery)
                             query_fragment.code_line_parser |>> (fun code_line -> code_line |> String_Pool.from_code_line |> UniformQuery) ]

            }

        static member metasyntax =
            """
                                      iquery         = *( ipchar / iprivate / "/" / "?" )
                                      query         = *( pchar / "/" / "?" )
                                      """

        static member parse(input_string: string) =
            match Query.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line Query.metasyntax)

        member this.as_raw_string =
            match this with 
            | InternationalizedQuery raw_string -> raw_string
            | UniformQuery raw_string -> raw_string
        member this.as_rendered_string = sprintf "?%s" this.as_raw_string


    type Userinfo =
        private
        | InternationalizedUserinfo of string
        | UniformUserinfo of string
        static member parser: Parser<Userinfo, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! userinfo =
                    choice [ many iuserinfo.code_point_parser
                             |>> (fun immutable_code_line ->
                                 Code_Line.from_immutable_code_line immutable_code_line |> String_Pool.from_code_line |> InternationalizedUserinfo)
                             many userinfo.code_point_parser
                             |>> (fun immutable_code_line ->
                                 Code_Line.from_immutable_code_line immutable_code_line |> String_Pool.from_code_line |> UniformUserinfo) ]

                do! skip_char '@'
                return userinfo

            }

        static member metasyntax =
            """
                                      iuserinfo      = *( iunreserved / pct-encoded / sub-delims / ":" )
                                      userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
                                      iuserinfo "@"
                                      userinfo "@"
                                      """

        static member parse(input_string: string) =
            match Userinfo.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Userinfo.metasyntax)

        member this.as_raw_string =
            match this with 
            | InternationalizedUserinfo raw_string -> raw_string
            | UniformUserinfo raw_string -> raw_string
        member this.as_rendered_string = sprintf "%s@" this.as_raw_string



    type Segment =
        private
        | UniformSegment of string
        | UniformSegmentFromUniformNonZeroSegment of string
        | UniformSegmentFromUniformNonzeroNoncolonSegment of string
        | InternationalizedSegment of string
        | InternationalizedSegmentFromInternationalizedNonZeroSegment of string
        | InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment of string
        // TODO next implement isegment into parser as choice
        static member parser: Parser<Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many ipchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line  
                                 |> InternationalizedSegment)
                             many pchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line 
                                 |> UniformSegment) ]


            }

        static member metasyntax =
            """
                    isegment       = *ipchar
                    segment       = *pchar
                    """

        static member parse(input_string: string) =
            match Segment.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Segment.metasyntax)

        member this.as_raw_string =
            match this with
            | UniformSegment raw_string -> raw_string
            | UniformSegmentFromUniformNonZeroSegment raw_string -> raw_string
            | UniformSegmentFromUniformNonzeroNoncolonSegment raw_string -> raw_string
            | InternationalizedSegment raw_string -> raw_string
            | InternationalizedSegmentFromInternationalizedNonZeroSegment raw_string -> raw_string
            | InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment raw_string -> raw_string

        static member raw_string(segment: Segment) = segment.as_raw_string

    type Nonzero_Segment =
        private
        | InternationalizedNonzeroSegment of string
        | UniformNonzeroSegment of string

        static member parser: Parser<Nonzero_Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [

                             many1 ipchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line 
                                 |> InternationalizedNonzeroSegment)
                             many1 pchar_encoded.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line
                                 |> UniformNonzeroSegment)

                              ]

            }

        static member metasyntax =
            """
                    isegment-nz    = 1*ipchar
                    segment-nz    = 1*pchar
                    """

        static member parse(input_string: string) =
            match Nonzero_Segment.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Nonzero_Segment.metasyntax)

        member this.as_raw_string =
            match this with
            | UniformNonzeroSegment raw_string -> raw_string
            | InternationalizedNonzeroSegment raw_string -> raw_string




    type Nonzero_Noncolon_Segment =
        private
        | InternationalizedNonzeroNoncolonSegment of string
        | UniformNonzeroNoncolonSegment of string
        static member parser: Parser<Nonzero_Noncolon_Segment, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many1 ipchar_encoded_noncolon.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line
                                 |> InternationalizedNonzeroNoncolonSegment)
                             many1 pchar_encoded_noncolon.code_line_parser
                             |>> (fun immutable_code_square ->
                                 Code_Line.from_immutable_code_square immutable_code_square  |> String_Pool.from_code_line
                                 |> UniformNonzeroNoncolonSegment) ]

            }

        static member metasyntax =
            """
                    isegment-nz-nc = 1*( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                    segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                    """

        static member parse(input_string: string) =
            match Segment.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf
                    "%A: %s"
                    failure
                    (code_line_message input_string.as_code_line Nonzero_Noncolon_Segment.metasyntax)

        member this.as_raw_string =
            match this with
            | UniformNonzeroNoncolonSegment raw_string -> raw_string
            | InternationalizedNonzeroNoncolonSegment raw_string -> raw_string




    type Path_Abempty =
        private
        | UniformPathAbempty of string * Segment array
        | InternationalizedPathAbempty of string * Segment array
        static member parser: Parser<Path_Abempty, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segments =
                    many (skip_char '/' >>. Segment.parser)
                    |>> (fun immutable_segments -> immutable_segments.AsSpan().ToArray())

                let is_internationalized =
                    segments
                    |> Array.exists (fun segment ->
                        segment.IsInternationalizedSegment
                        || segment.IsInternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment
                        || segment.IsInternationalizedSegmentFromInternationalizedNonZeroSegment

                    )
                let path_string = 
                    "/" + (segments |> Array.map (fun segment -> segment.as_raw_string) |> String.concat "/")

                return
                    if is_internationalized then
                         InternationalizedPathAbempty( path_string, segments)
                    else
                        UniformPathAbempty( path_string, segments)

            }

        static member metasyntax =
            """
                    ipath-abempty  = *( "/" isegment )
                    path-abempty  = *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Abempty.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Abempty.metasyntax)

        member this.segments =
            match this with
            | UniformPathAbempty (_,segments) -> segments
            | InternationalizedPathAbempty (_,segments) -> segments



            
        member this.as_raw_string = 

            match this with
            | UniformPathAbempty (raw_string,segments) -> raw_string
            | InternationalizedPathAbempty (raw_string,segments) -> raw_string


    type Path_Rootless =
        private
        | UniformPathRootless of string * Nonzero_Segment * Path_Abempty
        | InternationalizedPathRootless of string * Nonzero_Segment * Path_Abempty

        static member parser: Parser<Path_Rootless, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segment_nz = Nonzero_Segment.parser
                let! abempty = Path_Abempty.parser
                let path_string =  segment_nz.as_raw_string + abempty.as_raw_string

                return
                    if segment_nz.IsInternationalizedNonzeroSegment
                       || abempty.IsInternationalizedPathAbempty then
                        InternationalizedPathRootless( path_string, segment_nz, abempty)
                    else
                        UniformPathRootless( path_string, segment_nz, abempty)

            }

        static member metasyntax =
            """
                    ipath-rootless = isegment-nz *( "/" isegment )
                    path-rootless = segment-nz *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Rootless.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Rootless.metasyntax)


        member this.segments =
            match this with
            | UniformPathRootless (_, segment_nz, path_abempty) ->
                Array.concat [| [| (Segment.UniformSegmentFromUniformNonZeroSegment segment_nz.as_raw_string) |]
                                path_abempty.segments |]
            | InternationalizedPathRootless (_,segment_nz, path_abempty) ->
                Array.concat [| [| (Segment.InternationalizedSegmentFromInternationalizedNonZeroSegment
                                       segment_nz.as_raw_string) |]
                                path_abempty.segments |]




        member this.as_raw_string =
            match this with
            | UniformPathRootless (raw_string, segment_nz, path_abempty) -> raw_string
            | InternationalizedPathRootless (raw_string,segment_nz, path_abempty) -> raw_string

    type Path_Absolute =
        private
        | UniformAbsoluteRootPath of string * Path_Rootless
        | InternationalizedAbsoluteRootPath of string * Path_Rootless
        | AbsoluteRoot of string


        static member parser: Parser<Path_Absolute, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                do! skip_char '/'
                let! maybe_path = opt Path_Rootless.parser
                let path_string = 
                    "/" + (
                        match maybe_path with 
                        | ValueSome path -> path.as_raw_string
                        | ValueNone -> String.Empty
                    )

                return
                    match maybe_path with
                    | ValueSome path when path.IsInternationalizedPathRootless -> InternationalizedAbsoluteRootPath (path_string, path)
                    | ValueSome path -> UniformAbsoluteRootPath(path_string, path)
                    | ValueNone ->  AbsoluteRoot path_string

            }

        static member metasyntax =
            """
                    ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ]
                    path-absolute = "/" [ segment-nz *( "/" segment ) ]
                    """

        static member parse(input_string: string) =
            match Path_Absolute.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Absolute.metasyntax)



        member this.segments =
            match this with
            | UniformAbsoluteRootPath (_, path_rootless) -> path_rootless.segments
            | InternationalizedAbsoluteRootPath (_, path_rootless) -> path_rootless.segments
            | AbsoluteRoot _ -> [||]


        member this.as_raw_string =
            match this with
            | UniformAbsoluteRootPath (raw_string, path_rootless) -> raw_string
            | InternationalizedAbsoluteRootPath (raw_string, path_rootless) -> raw_string
            | AbsoluteRoot raw_string -> raw_string

    type Path_Noscheme =
        private
        | UniformPathNoscheme of string * Nonzero_Noncolon_Segment * Path_Abempty
        | InternationalizedPathNoscheme of string * Nonzero_Noncolon_Segment * Path_Abempty


        static member parser: Parser<Path_Noscheme, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! segment_nz_nc = Nonzero_Noncolon_Segment.parser
                let! abempty = Path_Abempty.parser
                let path_string =  segment_nz_nc.as_raw_string + abempty.as_raw_string

                return
                    if segment_nz_nc.IsInternationalizedNonzeroNoncolonSegment then
                        InternationalizedPathNoscheme( path_string, segment_nz_nc, abempty)
                    else
                        UniformPathNoscheme( path_string, segment_nz_nc, abempty)

            }

        static member metasyntax =
            """
                    ipath-noscheme = isegment-nz-nc *( "/" isegment )
                    path-noscheme = segment-nz *( "/" segment )
                    """

        static member parse(input_string: string) =
            match Path_Noscheme.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Path_Noscheme.metasyntax)

        member this.segments =
            match this with
            | UniformPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| Segment.UniformSegmentFromUniformNonzeroNoncolonSegment segment_nz_nc.as_raw_string |]
                                path_abempty.segments |]

            | InternationalizedPathNoscheme (_, segment_nz_nc, path_abempty) ->
                Array.concat [| [| Segment.InternationalizedSegmentFromInternationalizedNonzeroNoncolonSegment
                                       segment_nz_nc.as_raw_string |]
                                path_abempty.segments |]


        member this.as_raw_string =
            match this with
            | UniformPathNoscheme (raw_string, segment_nz_nc, path_abempty) -> raw_string
            | InternationalizedPathNoscheme (raw_string,segment_nz_nc, path_abempty) -> raw_string



    type Registered_Name =
        private
        | UniformRegisteredName of string
        | InternationalizedRegisteredName of string
        static member parser: Parser<Registered_Name, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                return!
                    choice [ many ireg_name.code_point_parser
                             |>> (fun immutable_code_line ->
                                 immutable_code_line.AsSpan().ToArray() |> String_Pool.from_code_line
                                 |> UniformRegisteredName)
                             many reg_name.code_point_parser
                             |>> (fun immutable_code_line ->
                                 immutable_code_line.AsSpan().ToArray() |> String_Pool.from_code_line
                                 |> InternationalizedRegisteredName) ]

            }

        static member metasyntax =
            """
                                      ireg-name      = *( iunreserved / pct-encoded / sub-delims )
                                      reg-name      = *( unreserved / pct-encoded / sub-delims )
                                      """

        static member parse(input_string: string) =
            match Registered_Name.parser input_string.as_parser_input with
            | Ok success -> 
              success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Registered_Name.metasyntax)


        member this.as_raw_string =
            match this with
            | UniformRegisteredName raw_string -> raw_string
            | InternationalizedRegisteredName raw_string -> raw_string





    type Host =
        | IPLiteralHost of IP_Literal
        | IPv4Host of IPv4_Address
        | UniformRegisteredNameHost of Registered_Name
        | InternationalizedRegisteredNameHost of Registered_Name


        static member parser: Parser<Host, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {

                let! host =
                    choice [ IP_Literal.parser |>> IPLiteralHost
                             IPv4_Address.parser |>> IPv4Host
                             Registered_Name.parser
                             |>> (fun reg_name ->
                                 if reg_name.IsInternationalizedRegisteredName then
                                     InternationalizedRegisteredNameHost reg_name
                                 else
                                     UniformRegisteredNameHost reg_name

                                 ) ]

                return host


            }

        static member metasyntax =
            """
            ihost          = IP-literal / IPv4address / ireg-name
            host          = IP-literal / IPv4address / reg-name
            """

        static member parse(input_string: string) =
            match Host.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line IP_Literal.metasyntax)

        member this.as_raw_string = 
            match this with
            | IPLiteralHost ip_literal -> ip_literal.as_raw_string
            | IPv4Host ipv4_address -> ipv4_address.as_raw_string
            | UniformRegisteredNameHost registered_name -> registered_name.as_raw_string
            | InternationalizedRegisteredNameHost registered_name -> registered_name.as_raw_string

        member this.as_rendered_string =
            match this with
            | IPLiteralHost ip_literal -> ip_literal.as_rendered_string
            | IPv4Host ipv4_address -> ipv4_address.as_raw_string
            | UniformRegisteredNameHost registered_name -> registered_name.as_raw_string
            | InternationalizedRegisteredNameHost registered_name -> registered_name.as_raw_string


    type Authority =
        | HostAuthority of  Host
        | UserinfoHostAuthority of string *  Userinfo * Host
        | HostPortAuthority of string *  Host * Port
        | UserinfoHostPortAuthority of string *  Userinfo * Host * Port


        static member parser: Parser<Authority, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_userinfo = opt Userinfo.parser
                let! host = Host.parser
                let! maybe_port = opt Port.parser

                return
                    match maybe_userinfo, host, maybe_port with
                    | ValueNone, host, ValueNone -> HostAuthority host
                    | ValueSome userinfo, host, ValueNone -> 
                        let authority_string = userinfo.as_rendered_string + host.as_rendered_string
                        UserinfoHostAuthority( authority_string, userinfo, host)
                    | ValueNone, host, ValueSome port -> 
                        let authority_string = host.as_rendered_string + port.as_rendered_string
                        HostPortAuthority( authority_string, host, port)
                    | ValueSome userinfo, host, ValueSome port -> 
                        let authority_string = userinfo.as_rendered_string + host.as_rendered_string + port.as_rendered_string
                        UserinfoHostPortAuthority( authority_string, userinfo, host, port)

            }

        static member metasyntax =
            """
            iauthority     = [ iuserinfo "@" ] ihost [ ":" port ]
            authority     = [ userinfo "@" ] host [ ":" port ]
            """

        static member parse(input_string: string) =
            match Authority.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)

        member this.as_raw_string = 
        
            match this with
            | HostAuthority host ->  host.as_raw_string
            | UserinfoHostAuthority (raw_string , userinfo, host) -> raw_string 
            | HostPortAuthority (raw_string , host, port) -> raw_string 
            | UserinfoHostPortAuthority (raw_string , userinfo, host, port) -> raw_string 





    type Relative_Part =
        | RelativeAuthorityAbemptyPart of string * Authority * Path_Abempty
        | RelativeAbsolutePart of  Path_Absolute
        | RelativeNoschemePart of  Path_Noscheme
        | RelativeEmptyPart 
        static member parser: Parser<Relative_Part, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_part =
                    opt (
                        choice [

                                 skip_string "//" >>. Authority.parser
                                 .>>. Path_Abempty.parser
                                 |>> (fun struct (authority, abempty) ->
                                     let relative_string = authority.as_raw_string + abempty.as_raw_string
                                     RelativeAuthorityAbemptyPart(relative_string, authority, abempty))
                                 Path_Absolute.parser |>> (fun path -> RelativeAbsolutePart( path))
                                 Path_Noscheme.parser |>> (fun path -> RelativeNoschemePart( path))

                                  ]
                    )

                return
                    match maybe_part with
                    | ValueSome part -> part
                    | ValueNone -> RelativeEmptyPart

            }

        static member metasyntax =
            """
            relative-part = "//" authority path-abempty
                 / path-absolute
                 / path-noscheme
                 / path-empty

           irelative-part = "//" iauthority ipath-abempty
                              / ipath-absolute
                              / ipath-noscheme
                              / ipath-empty
            """

        static member parse(input_string: string) =
            match Relative_Part.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)

        member this.as_raw_string = 
            match this with 
            | RelativeAuthorityAbemptyPart (raw_string, authority, abempty) -> raw_string
            | RelativeAbsolutePart part ->  part.as_raw_string
            | RelativeNoschemePart part ->  part.as_raw_string
            | RelativeEmptyPart -> String.Empty


        member this.as_rendered_string =
            match this with
            | RelativeAuthorityAbemptyPart (raw_string, authority, abempty) -> "//" + raw_string
            | RelativeAbsolutePart part ->  part.as_raw_string
            | RelativeNoschemePart part ->  part.as_raw_string
            | RelativeEmptyPart -> String.Empty




    type Hierarchical_Part =
        | HierarchicalAuthorityAbemptyPart of string * Authority * Path_Abempty
        | HierarchicalAbsolutePart of Path_Absolute
        | HierarchicalRootlessPart of Path_Rootless
        | HierarchicalEmptyPart 
        static member parser: Parser<Hierarchical_Part, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! maybe_part =
                    opt (
                        choice [

                                 skip_string "//" >>. Authority.parser
                                 .>>. Path_Abempty.parser
                                 |>> (fun struct (authority, abempty) ->
                                     let hierarchical_string = authority.as_raw_string + abempty.as_raw_string
                                     HierarchicalAuthorityAbemptyPart( hierarchical_string, authority, abempty))
                                 Path_Absolute.parser |>> (fun path -> HierarchicalAbsolutePart( path))
                                 Path_Rootless.parser |>> (fun path -> HierarchicalRootlessPart( path))

                                  ]
                    )

                return
                    match maybe_part with
                    | ValueSome part -> part
                    | ValueNone -> HierarchicalEmptyPart

            }

        static member metasyntax =
            """
            hier-part     = "//" authority path-abempty
                         / path-absolute
                         / path-rootless
                         / path-empty
           ihier-part     = "//" iauthority ipath-abempty
                              / ipath-absolute
                              / ipath-rootless
                              / ipath-empty
            """

        static member parse(input_string: string) =
            match Hierarchical_Part.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Authority.metasyntax)


        member this.as_raw_string = 
            match this with 
            | HierarchicalAuthorityAbemptyPart (raw_string, authority, abempty) -> raw_string
            | HierarchicalAbsolutePart part ->  part.as_raw_string
            | HierarchicalRootlessPart part ->  part.as_raw_string
            | HierarchicalEmptyPart  -> String.Empty

            

        member this.as_rendered_string =
            match this with
            | HierarchicalAuthorityAbemptyPart (_, authority, abempty) -> "//" + this.as_raw_string
            | HierarchicalAbsolutePart part ->  part.as_raw_string
            | HierarchicalRootlessPart part ->  part.as_raw_string
            | HierarchicalEmptyPart  -> String.Empty



    type Relative_Reference =
        | RelativeReference  of Relative_Part
        | RelativeQueryReference of string *  Relative_Part * Query
        | RelativeFragmentReference of string *  Relative_Part * Fragment
        | RelativeQueryFragmentReference of string *  Relative_Part * Query * Fragment



        static member parser: Parser<Relative_Reference, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! relative_part = Relative_Part.parser
                let! maybe_query = opt Query.parser
                let! maybe_fragment = opt Fragment.parser

                return
                    match relative_part, maybe_query, maybe_fragment with
                    | part, ValueNone, ValueNone -> RelativeReference( part)
                    | part, ValueSome query_, ValueNone -> 
                        let relative_string = part.as_rendered_string + query_.as_rendered_string
                        RelativeQueryReference( relative_string, part, query_)
                    | part, ValueNone, ValueSome fragment -> 
                        let relative_string = part.as_rendered_string + fragment.as_rendered_string
                        RelativeFragmentReference( relative_string, part, fragment)
                    | part, ValueSome query_, ValueSome fragment ->
                        let relative_string = part.as_rendered_string + query_.as_rendered_string + fragment.as_rendered_string
                        RelativeQueryFragmentReference( relative_string, part, query_, fragment)

            }

        static member metasyntax =
            """
                irelative-ref  = irelative-part [ "?" iquery ] [ "#" ifragment ]
                relative-ref  = relative-part [ "?" query ] [ "#" fragment ]

            """

        static member parse(input_string: string) =
            match Relative_Reference.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Relative_Reference.metasyntax)



        member this.as_raw_string = 
            match this with 
            | RelativeReference ( part) ->   part.as_raw_string
            | RelativeQueryReference (raw_string, part, query_) -> raw_string
            | RelativeFragmentReference (raw_string, part, fragment) -> raw_string
            | RelativeQueryFragmentReference (raw_string, part, raw_querystring, fragment) -> raw_string
        member this.as_rendered_string = 
            match this with 
            | RelativeReference ( part) ->   part.as_rendered_string
            | RelativeQueryReference (raw_string, part, query_) -> raw_string
            | RelativeFragmentReference (raw_string, part, fragment) -> raw_string
            | RelativeQueryFragmentReference (raw_string, part, raw_querystring, fragment) -> raw_string


    type Absolute_IRI =
        | AbsoluteIRI of string * Scheme * Hierarchical_Part
        | AbsoluteQueryIRI of string * Scheme * Hierarchical_Part * Query
        member this.scheme =
            match this with
            | AbsoluteIRI (_, scheme, hier_part) -> scheme
            | AbsoluteQueryIRI (_, scheme, hier_part, query_) -> scheme

        static member parser: Parser<Absolute_IRI, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! scheme = Scheme.parser
                do! skip_char ':'
                let! hier_part = Hierarchical_Part.parser
                let! maybe_query = opt Query.parser

                return
                    match maybe_query with
                    | ValueSome query_ -> 
                        let absolute_string = scheme.as_rendered_string + hier_part.as_rendered_string + query_.as_rendered_string
                        AbsoluteQueryIRI( absolute_string, scheme, hier_part, query_)
                    | ValueNone -> 
                        let absolute_string = scheme.as_rendered_string + hier_part.as_rendered_string

                        AbsoluteIRI( absolute_string, scheme, hier_part)

            }

        static member metasyntax =
            """
                absolute-IRI   = scheme ":" ihier-part [ "?" iquery ]
                absolute-URI  = scheme ":" hier-part [ "?" query ]

            """

        static member parse(input_string: string) =
            match Absolute_IRI.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure ->
                failwithf "%A: %s" failure (code_line_message input_string.as_code_line Absolute_IRI.metasyntax)

        member this.as_raw_string = 
            match this with
            | AbsoluteIRI (raw_string, scheme, hier_part) -> raw_string
            | AbsoluteQueryIRI (raw_string, scheme, hier_part, query_) -> raw_string




    type IRI =
        | IRI of string * Scheme * Hierarchical_Part
        | QueryIRI of string * Scheme * Hierarchical_Part * Query
        | FragmentIRI of string * Scheme * Hierarchical_Part * Fragment
        | QueryFragmentIRI of string * Scheme * Hierarchical_Part * Query * Fragment
        member this.scheme =
            match this with
            | IRI (_, scheme, hier_part) -> scheme
            | QueryIRI (_, scheme, hier_part, query_) -> scheme
            | FragmentIRI (_, scheme, hier_part, fragment) -> scheme
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> scheme

        member this.hierarchical_part =
            match this with
            | IRI (_, scheme, hier_part) -> hier_part
            | QueryIRI (_, scheme, hier_part, query_) -> hier_part
            | FragmentIRI (_, scheme, hier_part, fragment) -> hier_part
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> hier_part

        member this.maybe_query =
            match this with
            | IRI (_, scheme, hier_part) -> None
            | QueryIRI (_, scheme, hier_part, query_) -> Some query_
            | FragmentIRI (_, scheme, hier_part, fragment) -> None
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> Some query_

        member this.maybe_fragment =
            match this with
            | IRI (_, scheme, hier_part) -> None
            | QueryIRI (_, scheme, hier_part, query_) -> None
            | FragmentIRI (_, scheme, hier_part, fragment) -> Some fragment
            | QueryFragmentIRI (_, scheme, hier_part, query_, fragment) -> Some fragment


        static member parser: Parser<IRI, Code_Point, unit, ReadableMemory<Code_Point>> =
            parser {
                let! scheme = Scheme.parser
                do! skip_char ':'
                let! hier_part = Hierarchical_Part.parser
                let! maybe_query = opt Query.parser
                let! maybe_fragment = opt Fragment.parser

                return
                    match maybe_query, maybe_fragment with
                    | ValueNone, ValueNone -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string
                        IRI( iri_string, scheme, hier_part)
                    | ValueSome query_, ValueNone -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + query_.as_rendered_string
                        QueryIRI( iri_string, scheme, hier_part, query_)
                    | ValueNone, ValueSome fragment -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + fragment.as_rendered_string
                        FragmentIRI( iri_string, scheme, hier_part, fragment)
                    | ValueSome query_, ValueSome fragment -> 
                        let iri_string = scheme.as_rendered_string + hier_part.as_rendered_string + fragment.as_rendered_string
                        QueryFragmentIRI( iri_string, scheme, hier_part, query_, fragment)

            }

        static member metasyntax =
            """
                IRI            = scheme ":" ihier-part [ "?" iquery ] [ "#" ifragment ]
                URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]

            """

        static member parse(input_string: string) =
            match IRI.parser input_string.as_parser_input with
            | Ok success -> 
                success
            | Error failure -> failwithf "%A: %s" failure (code_line_message input_string.as_code_line IRI.metasyntax)

        member this.as_raw_string =
            match this with
            | IRI (raw_string, scheme, hier_part) -> raw_string
            | QueryIRI (raw_string, scheme, hier_part, query_) -> raw_string
            | FragmentIRI (raw_string, scheme, hier_part, fragment) -> raw_string
            | QueryFragmentIRI (raw_string, scheme, hier_part, raw_querystring, fragment) -> raw_string


open Rfc_Types
open Code_Point_Rule
open Code_Line_Rule



[<RequireQualifiedAccessAttribute>]
type Language_Tag = 
    | en
type Region_Subtag = 
    | US

type Rdf_Triple =
    { curSubject: Rdf_Subject
      curPredicate: Rdf_Predicate
      curObject: Rdf_Object }
    member this.as_object = this |> TripleTerm |> TripleTermObject

and Rdf_Quad =
    { triple: Rdf_Triple
      curGraph: Rdf_Subject option }

and Rdf_Subject =
    | IRIREFSubject of IRIREF
    | BlankNodeSubject of Blank_Node
    member this.maybe_predicate =
        match this with
        | IRIREFSubject iriref -> Some iriref.as_subject
        | BlankNodeSubject blank_node -> None

    member this.as_object =

        match this with
        | IRIREFSubject iriref -> iriref.as_object
        | BlankNodeSubject blank_node -> blank_node.as_object

    member this.as_rendered_string =

        match this with
        | IRIREFSubject iriref -> iriref.as_rendered_string
        | BlankNodeSubject blank_node -> blank_node.as_raw_string


and Rdf_Predicate =
    | IRIREFPredicate of IRIREF
    member this.as_subject =
        match this with
        | IRIREFPredicate iriref -> iriref.as_subject

    member this.as_object =
        match this with
        | IRIREFPredicate iriref -> iriref.as_object

    member this.as_rendered_string =
        match this with
        | IRIREFPredicate iriref -> iriref.as_rendered_string


and Rdf_Object =
    | IRIREFObject of IRIREF
    | BlankNodeObject of Blank_Node
    | LiteralObject of Rdf_Literal
    | TripleTermObject of Triple_Term
    member this.maybe_subject =
        match this with
        | IRIREFObject iriref -> Some iriref.as_subject
        | BlankNodeObject blank_node -> Some blank_node.as_subject
        | LiteralObject rdf_literal -> None
        // TODO figure out howto incorporate reified triple subjects
        | TripleTermObject triple_term -> None

    member this.maybe_predicate =
        match this with
        | IRIREFObject iriref -> Some iriref.as_predicate
        | BlankNodeObject blank_node -> None
        | LiteralObject rdf_literal -> None
        | TripleTermObject triple_term -> None

and PredicateObjectList =
    {

      verb: Rdf_Predicate
      objectLists: ObjectList array

     }

    static member inline from_terms (predicate: Rdf_Predicate) (objects: Rdf_Object array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdf_object ->
                { rdf_object = rdf_object
                  annotations = [||]

                })

        }

and ObjectList =
    { rdf_object: Rdf_Object
      annotations: Annotation array }

and Annotation =
    | AnnotationReifier of Rdf_Subject
    | AnnotationBlock of PredicateObjectList

and Triple_Term =
    | TripleTerm of Rdf_Triple
    member this.as_object = TripleTermObject this

    member this.ttSubject =
        match this with
        | TripleTerm triple -> triple.curSubject

    member this.ttPredicate =
        match this with
        | TripleTerm triple -> triple.curPredicate

    member this.ttObject =
        match this with
        | TripleTerm triple -> triple.curObject




and IRIREF =
    | NamespacedName of Namespaced_IRI
    | SkolemIRIREF of Skolem_IRI
    | IRIREF of IRI
    | RelativeReference of Relative_Reference
    member this.as_subject = IRIREFSubject this
    member this.as_predicate = IRIREFPredicate this
    member this.as_object = IRIREFObject this

    static member parser: Parser<IRIREF, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {
            return!
                choice [

                         IRI.parser |>> IRIREF
                         Relative_Reference.parser |>> RelativeReference

                          ]


        }

    static member metasyntax =
        """
            IRI-reference  = IRI / irelative-ref
            URI-reference = URI / relative-ref

        """

    static member parse(input_string: string) =
        match IRIREF.parser input_string.as_parser_input with
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line IRIREF.metasyntax}"


    member this.as_raw_string =
        match this with
        | IRIREF iri -> iri.as_raw_string
        | SkolemIRIREF iri -> iri.as_raw_string
        | NamespacedName namespaced_iri -> namespaced_iri.as_raw_string
        | RelativeReference relative_ref -> relative_ref.as_raw_string
    member this.as_rendered_string = "<" + this.as_raw_string + ">"



and Blank_Node =
    | BlankNodeIdentifier of identifier: string
    | BlankNodePropertyList of identifier: string * predicateObjectList: PredicateObjectList

    member this.as_subject = BlankNodeSubject this
    member this.as_object = BlankNodeObject this

    member this.as_raw_string =
        match this with
        | BlankNodeIdentifier identifier -> identifier
        | BlankNodePropertyList (identifier, predicateObjectList) -> identifier
    member this.as_rendered_string = "_:" + this.as_raw_string


and Rdf_Literal =
    | SimpleLiteral of lexical_form: string
    | LongLiteral of lexical_form: string
    | DatatypedLiteral of lexical_form: string * datatype: IRIREF
    | LanguageString of lexical_form: string * language: Language_Tag
    | RegionString of lexical_form: string * language: Language_Tag * region: Region_Subtag
    | DirectedLanguageString of lexical_form: string * language: Language_Tag * base_direction: Initial_Text_Direction
    | DirectedRegionString of
        lexical_form: string *
        language: Language_Tag *
        region: Region_Subtag *
        base_direction: Initial_Text_Direction

    member this.lexical_form =
        match this with
        | SimpleLiteral lexical_form -> lexical_form
        | LongLiteral lexical_form -> lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> lexical_form
        | LanguageString (lexical_form, language) -> lexical_form
        | RegionString (lexical_form, language, region) -> lexical_form
        | DirectedLanguageString (lexical_form, language, base_direction) -> lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) -> lexical_form

    member this.datatype =
        match this with
        | SimpleLiteral lexical_form -> IRIREF.parse "http://www.w3.org/2001/XMLSchema#string"
        | LongLiteral lexical_form -> IRIREF.parse "http://www.w3.org/2001/XMLSchema#string"
        | DatatypedLiteral (lexical_form, datatype) -> datatype
        | LanguageString (lexical_form, language) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
        | RegionString (lexical_form, language, region) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            IRIREF.parse "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"

    member this.language_tag =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> Some language
        | RegionString (lexical_form, language, region) -> Some language
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some language
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some language

    member this.region_tag(literal: Rdf_Literal) =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> Some region
        | DirectedLanguageString (lexical_form, language, base_direction) -> None
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some region

    member this.base_direction(literal: Rdf_Literal) =
        match this with
        | SimpleLiteral lexical_form -> None
        | LongLiteral lexical_form -> None
        | DatatypedLiteral (lexical_form, datatype) -> None
        | LanguageString (lexical_form, language) -> None
        | RegionString (lexical_form, language, region) -> None
        | DirectedLanguageString (lexical_form, language, base_direction) -> Some base_direction
        | DirectedRegionString (lexical_form, language, region, base_direction) -> Some base_direction

    member this.as_object = LiteralObject this

and Initial_Text_Direction =
    | Ltr
    | Rtl
    member this.lexical_form =

        match this with
        | Ltr -> "ltr"
        | Rtl -> "rtl"

and Skolem_IRI =
    | SkolemIRI of IRIREF * Guid
    member this.well_known_iriref =
        match this with
        | SkolemIRI (well_known_stem, uuid) -> well_known_stem

    member this.uuid =
        match this with
        | SkolemIRI (well_known_stem, uuid) -> uuid


    member this.as_subject = this |> SkolemIRIREF |> IRIREFSubject
    member this.as_predicate = this |> SkolemIRIREF |> IRIREFPredicate
    member this.as_object = this |> SkolemIRIREF |> IRIREFObject

    member this.as_raw_string =
        match this with
        | SkolemIRI (well_known_stem, uuid) ->
            well_known_stem.as_rendered_string
            + uuid.ToString("N")
    member this.as_rendered_string = "<" + this.as_raw_string + ">"

and Namespaced_IRI =
    private
    | NamespacedIRI of IRIREF * Local_Name
    member this.namespace_iriref =
        match this with
        | NamespacedIRI (namespace_name, local_name) -> namespace_name

    member this.local_name =
        match this with
        | NamespacedIRI (namespace_name, local_name) -> local_name
    member this.as_raw_string = 
        match this with
        | NamespacedIRI (namespace_name, local_name) -> namespace_name.as_raw_string + local_name.as_raw_string
    member this.as_rendered_string = "<" + this.as_raw_string + ">"

    member this.as_prefixed_name (delimiter: string) (prefix_map: Map<string, string>) =
        try
            let namespace_name = this.namespace_iriref.as_rendered_string
            let prefix_label = prefix_map[namespace_name]
            sprintf "%s%s%s" prefix_label delimiter this.local_name.as_raw_string
        with
        | err -> failwithf "%s failed with error %s" this.as_rendered_string err.Message

    member this.as_curie(prefix_map: Map<string, string>) = this.as_prefixed_name ":" prefix_map

    static member metasyntax =
        """
    
            IRIREF            ::=  '<' ([^#x00-#x20<>"{}|^`\] | UCHAR)* '>' /* #x00=NULL #01-#x1F=control codes #x20=space */
            PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?

        """

    static member parse (namespace_name_input: string) (local_name_input: string) =
        let namespace_name =
            match IRIREF.parser namespace_name_input.as_parser_input with
            | Ok success -> success
            | Error failure ->
                failwith $"{failure} : {code_line_message namespace_name_input.as_code_line IRIREF.metasyntax}"

        let local_name =
            match Local_Name.parser local_name_input.as_parser_input with
            | Ok success -> success
            | Error failure ->
                failwith $"{failure} : {code_line_message local_name_input.as_code_line PN_LOCAL.metasyntax}"

        NamespacedIRI(namespace_name, local_name)





    member this.as_subject = this |> NamespacedName |> IRIREFSubject
    member this.as_predicate = this |> NamespacedName |> IRIREFPredicate
    member this.as_object = this |> NamespacedName |> IRIREFObject


and Local_Name =

    private
    | LocalName of PN_LOCAL
    | LocalPath of Path_Rootless
    static member parser: Parser<Local_Name, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {
            return!
                choice [ PN_LOCAL.parser |>> LocalName
                         Path_Rootless.parser |>> LocalPath ]

        }

    static member metasyntax =
        """
                                      PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                      ipath-rootless = isegment-nz *( "/" isegment )
                                      """

    static member parse(input_string: string) =
        match Local_Name.parser input_string.as_parser_input with
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line Local_Name.metasyntax}"

    member this.substrings =
        match this with
        | LocalName pn_local -> [| pn_local.as_raw_string |]
        | LocalPath path_rootless -> path_rootless.segments  |> Array.map Segment.raw_string



    member this.as_raw_string =

        match this with
        | LocalName pn_local -> pn_local.as_raw_string
        | LocalPath path_rootless -> path_rootless.as_raw_string


and PN_LOCAL =
    private
    | PN_LOCAL of string
    static member parser: Parser<PN_LOCAL, Code_Point, unit, ReadableMemory<Code_Point>> =
        parser {

            let! head =
                choice [

                         pn_chars_u.code_point_parser
                         parse_char ':'
                         any_point_from_interval Unicodepoint.Partition.Ascii_Digits

                          ]

            let! maybe_tail =
                opt (

                    many (
                        choice [ pn_chars.code_point_parser
                                 parse_char '.'
                                 parse_char ':' ]
                    )
                )

            return
                match maybe_tail with
                | ValueNone ->  [| head |] |> String_Pool.from_code_line |> PN_LOCAL
                | ValueSome immutable_code_line ->
                    immutable_code_line
                    |> Code_Line.from_immutable_code_line
                    |> Array.insertAt 0 head
                    |> String_Pool.from_code_line
                    |> PN_LOCAL

        }

    static member metasyntax =
        """
                                  PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ?
                                  """

    static member parse(input_string: string) =
        match PN_LOCAL.parser input_string.as_parser_input with
        | Ok (PN_LOCAL false_positive) when false_positive[false_positive.ToCharArray().last_index] = '.' ->
            failwith
                $"false positive for {input_string}, cannot end with full stop ``.`` : {code_line_message input_string.as_code_line PN_LOCAL.metasyntax}"
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line PN_LOCAL.metasyntax}"

    member this.as_raw_string =
        match this with
        | PN_LOCAL raw_string -> raw_string





and Vertex =
    | SubjectVertex of Rdf_Subject
    | ObjectVertex of Rdf_Object
    static member subject_string
        (rdf_subject: Rdf_Subject)
        (prefix_delimiter: string)
        (prefix_map: Map<string, string>)
        =
        match rdf_subject with
        | IRIREFSubject (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFSubject iriref -> iriref.as_rendered_string
        | BlankNodeSubject blank_node -> blank_node.as_raw_string

    static member object_String (rdf_object: Rdf_Object) (prefix_delimiter: string) (prefix_map: Map<string, string>) =

        match rdf_object with
        | IRIREFObject (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFObject iriref -> iriref.as_rendered_string
        | BlankNodeObject blank_node -> blank_node.as_raw_string
        | LiteralObject rdf_literal ->
            match rdf_literal with
            | SimpleLiteral lexical_form -> sprintf "%s" lexical_form
            | LongLiteral lexical_form -> sprintf "%s" lexical_form
            | DatatypedLiteral (lexical_form, (NamespacedName datatype_iri)) ->
                sprintf "%s^^%s" lexical_form (datatype_iri.as_prefixed_name prefix_delimiter prefix_map)
            | DatatypedLiteral (lexical_form, datatype) -> sprintf "%s^^%s" lexical_form datatype.as_rendered_string
            | LanguageString (lexical_form, language) -> sprintf "%s@%s" lexical_form (language.ToString())
            | RegionString (lexical_form, language, region) ->
                sprintf "%s@%s-%s" lexical_form (language.ToString()) (region.ToString())
            | DirectedLanguageString (lexical_form, language, base_direction) ->
                sprintf "%s@%s--%s" lexical_form (language.ToString()) base_direction.lexical_form
            | DirectedRegionString (lexical_form, language, region, base_direction) ->
                sprintf
                    "%s@%s-%s--%s"
                    lexical_form
                    (language.ToString())
                    (region.ToString())
                    base_direction.lexical_form

        | TripleTermObject triple_term ->
            sprintf
                "%s %s %s"
                (Vertex.subject_string triple_term.ttSubject prefix_delimiter prefix_map)
                (Edge.predicate_string triple_term.ttPredicate prefix_delimiter prefix_map)
                (Vertex.object_String triple_term.ttObject prefix_delimiter prefix_map)

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | SubjectVertex rdf_subject -> Vertex.subject_string rdf_subject prefix_delimiter prefix_map
        | ObjectVertex rdf_object -> Vertex.object_String rdf_object prefix_delimiter prefix_map



and Edge =
    | PredicateEdge of Rdf_Predicate
    | TripleEdge of Rdf_Triple
    static member predicate_string
        (rdf_predicate: Rdf_Predicate)
        (prefix_delimiter: string)
        (prefix_map: Map<string, string>)
        =
        match rdf_predicate with
        | IRIREFPredicate (NamespacedName namespaced_iri) -> namespaced_iri.as_prefixed_name prefix_delimiter prefix_map
        | IRIREFPredicate iriref -> iriref.as_rendered_string

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | PredicateEdge rdf_predicate -> Edge.predicate_string rdf_predicate prefix_delimiter prefix_map
        | TripleEdge rdf_triple -> Edge.predicate_string rdf_triple.curPredicate prefix_delimiter prefix_map







module Rdf_Triple =

    let inline from_terms
        (rdf_subject: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        (rdf_predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
        (rdf_object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
        =
        { curSubject = rdf_subject.as_subject
          curPredicate = rdf_predicate.as_predicate
          curObject = rdf_object.as_object }


// TODO next consider
// open FSharp.HashCollections
// Hashset instead

module Triples =
    let from_terms
        (rdf_subjects: Rdf_Subject array)
        (rdf_predicates: Rdf_Predicate array)
        (rdf_objects: Rdf_Object array)
        =
        rdf_objects
        |> Array.Parallel.collect (fun rdf_object ->

            rdf_predicates
            |> Array.Parallel.collect (fun rdf_predicate ->

                rdf_subjects
                |> Array.Parallel.map (fun rdf_subject ->

                    {

                      curSubject = rdf_subject
                      curPredicate = rdf_predicate
                      curObject = rdf_object

                    }

                )))
        |> Set.ofArray

    let from_subjects_predicateObjectLists
        (rdf_subjects: Rdf_Subject array)
        (predicateObjectLists: PredicateObjectList array)
        =
        rdf_subjects
        |> Array.Parallel.collect (fun rdf_subject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = rdf_subject
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.rdf_object }

                )



            )



        )
        |> Set.ofArray

module Quad =

    let inline from_terms
        (subject: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
        (object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
        (graph_name: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
        =
        {

          triple = Rdf_Triple.from_terms subject predicate object
          curGraph = Some graph_name.as_subject

        }

    let curSubject (quad: Rdf_Quad) = quad.triple.curSubject
    let curPredicate (quad: Rdf_Quad) = quad.triple.curPredicate
    let curObject (quad: Rdf_Quad) = quad.triple.curObject


















































let test_string = "https"


let test_scheme =  Scheme.parse test_string

let test_iri = IRI.parse "https://eristocrates.dev/ontology/dbug/"

let xml_string = IRIREF.parse "http://www.w3.org/2001/XMLSchema#string"
xml_string.as_rendered_string


