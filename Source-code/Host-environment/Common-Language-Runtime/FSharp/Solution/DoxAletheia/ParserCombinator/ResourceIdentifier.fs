// #time on

module DoxAletheia.ParserCombinator.ResourceIdentifier


open System
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics
open Microsoft.FSharp.Collections
open UUIDNext

open XParsec
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open ByteExtensions
open Data
open Interval_Range








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





