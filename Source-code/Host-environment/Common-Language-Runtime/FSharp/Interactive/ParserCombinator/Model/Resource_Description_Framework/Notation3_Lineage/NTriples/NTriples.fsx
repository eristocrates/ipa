open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: FSharp.Data"
#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open Uniform_Resource_Identifier
open Internationalized_Resource_Identifier

open XParsec
open XParsecErgonomics

open FSharp.Data
open UnicodeStandard

let HEX = HEXDIG

let pn_chars_base =
    {

      partition_name = "PN_CHARS_BASE"
      unicodepoint_set =

        let range_set =
            Unicodepoint_Set.from'ranges [|


                                            Unicodepoint_Range.from'ints 0x00C0 0x00D6
                                            Unicodepoint_Range.from'ints 0x00D8 0x00F6
                                            Unicodepoint_Range.from'ints 0x00F8 0x02FF
                                            Unicodepoint_Range.from'ints 0x0370 0x037D
                                            Unicodepoint_Range.from'ints 0x037F 0x1FFF
                                            Unicodepoint_Range.from'ints 0x200C 0x200D
                                            Unicodepoint_Range.from'ints 0x2070 0x218F
                                            Unicodepoint_Range.from'ints 0x2C00 0x2FEF
                                            Unicodepoint_Range.from'ints 0x3001 0xD7FF
                                            Unicodepoint_Range.from'ints 0xF900 0xFDCF
                                            Unicodepoint_Range.from'ints 0xFDF0 0xFFFD
                                            Unicodepoint_Range.from'ints 0x10000 0xEFFFF


                                             |]

        Unicodepoint_Set.from'union [| range_set
                                       Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.letters.unicodepoint_set |]


    }

let pn_chars_u =
    {

      partition_name = "PN_CHARS_U"
      unicodepoint_set =
        Unicodepoint_Set.from'union [| pn_chars_base.unicodepoint_set
                                       Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.low_line |]

    }

let pn_chars =
    {

      partition_name = "PN_CHARS"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       pn_chars_u.unicodepoint_set
                                       Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.hyphen_minus
                                       Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.partition.unicodepoint_set
                                       Unicodepoint_Set.from'rosters_and_ranges [| Unicodepoint_Roster.from'int_array [| 0x00B7 |] |] [|
                                           Unicodepoint_Range.from'ints 0x0300 0x036F
                                           Unicodepoint_Range.from'ints 0x203F 0x2040
                                       |]

                                        |]

    }

let pn_chars_full_stop =
    {

      partition_name = "PN_CHARS|'.'"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       pn_chars.unicodepoint_set
                                       Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.punctuation_and_symbols.full_stop |]


    }


let echar =
    {

      partition_name = "ECHAR"
      unicodepoint_set = Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "\\tbnrf\"'" |]

    }

let string_literal_quote_exclusion =
    {

      partition_name = "[^#x22#x5C#x0A#x0D]"
      unicodepoint_set =
        Unicodepoint_Set.from'union [|

                                       Unicodepoint_Set.from'rosters [|

                                                                        Unicodepoint_Roster.from'int_array [| 0x22
                                                                                                              0x5C
                                                                                                              0xA
                                                                                                              0xD |]

                                                                         |] |]

    }

[<Struct>]
type Prefixed_Name_Character_Base =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Prefixed_Name_Character_Base, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from pn_chars_base
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
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

[<Struct>]
type Prefixed_Name_Character_U =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Prefixed_Name_Character_U, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from pn_chars_u
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ PN_CHARS_U        ::=  PN_CHARS_BASE | '_'

            """

[<Struct>]
type Prefixed_Name_Character =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Prefixed_Name_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from pn_chars
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ 
            PN_CHARS          ::= (PN_CHARS_U
                    | '-'
                    | [0-9]
                    | #x00B7
                    | [#x0300-#x036F]
                    | [#x203F-#x2040])

            """

[<Struct>]
type Escaped_Space_Character =
    {

      as'string: string
      as'literal: string
      as'int: int

     }

    static member parse: Parser<Escaped_Space_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '\\'
                let! escaped = unicodepoint_from echar
                return escaped
             }
             |>> fun escaped ->
                     let literal = "\\{escaped.as'string}"

                     let unicodepoint =
                         Unicodepoint.array'from'string literal
                         |> Array.head

                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int
                       as'literal = literal

                     }

            )
            """ 
          ECHAR             ::= ('\' [tbnrf\"'])

            """

[<Struct>]
type Escaped_Unicode_Character =
    {

      first_digit: Unicodepoint
      second_digit: Unicodepoint
      third_digit: Unicodepoint
      fourth_digit: Unicodepoint
      fifth_digit: Unicodepoint ValueOption
      sixth_digit: Unicodepoint ValueOption
      seventh_digit: Unicodepoint ValueOption
      eighth_digit: Unicodepoint ValueOption
      as'literal: string
      as'unicodepoint: Unicodepoint

     }

    static member parse: Parser<Escaped_Unicode_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [ parser {
                          do! skip_unicodepoint '\\'
                          do! skip_unicodepoint 'U'
                          let! first_digit = unicodepoint_from HEX
                          let! second_digit = unicodepoint_from HEX
                          let! third_digit = unicodepoint_from HEX
                          let! fourth_digit = unicodepoint_from HEX
                          let! fifth_digit = unicodepoint_from HEX
                          let! sixth_digit = unicodepoint_from HEX
                          let! seventh_digit = unicodepoint_from HEX
                          let! eighth_digit = unicodepoint_from HEX

                          return
                              (first_digit,
                               second_digit,
                               third_digit,
                               fourth_digit,
                               ValueSome(fifth_digit),
                               ValueSome(sixth_digit),
                               ValueSome(seventh_digit),
                               ValueSome(eighth_digit))
                      }
                      parser {
                          do! skip_unicodepoint '\\'
                          do! skip_unicodepoint 'u'
                          let! first_digit = unicodepoint_from HEX
                          let! second_digit = unicodepoint_from HEX
                          let! third_digit = unicodepoint_from HEX
                          let! fourth_digit = unicodepoint_from HEX

                          return
                              (first_digit,
                               second_digit,
                               third_digit,
                               fourth_digit,
                               ValueNone,
                               ValueNone,
                               ValueNone,
                               ValueNone)
                      } ]
             |>> fun (first_digit,
                      second_digit,
                      third_digit,
                      fourth_digit,
                      fifth_digit,
                      sixth_digit,
                      seventh_digit,
                      eighth_digit) ->
                     let hexadecimal_digit_string =
                         if fifth_digit.IsSome then
                             $"{first_digit.as'string}{second_digit.as'string}{third_digit.as'string}{fourth_digit.as'string}{fifth_digit.Value.as'string}{sixth_digit.Value.as'string}{seventh_digit.Value.as'string}{eighth_digit.Value.as'string}"
                         else
                             $"{first_digit.as'string}{second_digit.as'string}{third_digit.as'string}{fourth_digit.as'string}
"

                     let encoded_literal =
                         if fifth_digit.IsSome then
                             $"\\U{hexadecimal_digit_string}"
                         else
                             $"\\u{hexadecimal_digit_string}"

                     let unicodepoint =
                         Unicodepoint.from'hexadecimal_digit_string hexadecimal_digit_string

                     {

                       first_digit = first_digit
                       second_digit = second_digit
                       third_digit = third_digit
                       fourth_digit = fourth_digit
                       fifth_digit = fifth_digit
                       sixth_digit = sixth_digit
                       seventh_digit = seventh_digit
                       eighth_digit = eighth_digit
                       as'literal = encoded_literal
                       as'unicodepoint = unicodepoint

                     }

            )
            """ 
UCHAR             ::= ( '\u' HEX HEX HEX HEX )
                    | ( '\U' HEX HEX HEX HEX HEX HEX HEX HEX )

            """

[<Struct>]
type String_Literal_Character =
    {

      as'string: string
      as'int: int
      as'literal: string
      as'unicodepoint: Unicodepoint

     }

    static member parse: Parser<String_Literal_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      unicodepoint_not_from string_literal_quote_exclusion
                      |>> fun character ->
                              { as'string = character.as'string
                                as'int = character.as'int
                                as'literal = character.as'string
                                as'unicodepoint = character }
                      Escaped_Space_Character.parse
                      |>> fun character ->
                              { as'string = character.as'string
                                as'int = character.as'int
                                as'literal = character.as'literal
                                as'unicodepoint =
                                  { as'int = character.as'int
                                    as'string = character.as'string } }
                      Escaped_Unicode_Character.parse
                      |>> fun character ->
                              { as'string = character.as'unicodepoint.as'string
                                as'int = character.as'unicodepoint.as'int
                                as'literal = character.as'literal
                                as'unicodepoint = character.as'unicodepoint }

                       ])
            """ 
           [^#x22#x5C#xA#xD] | ECHAR | UCHAR 

            """

[<Struct>]
type Quoted_String_Literal =
    {

      as'string: string
      as'literal: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Quoted_String_Literal, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {
                do! skip_unicodepoint '"'
                let! quoted = many String_Literal_Character.parse
                do! skip_unicodepoint '"'
                return quoted
             }
             |>> fun quoted_characters ->
                     {

                       as'string =
                           quoted_characters
                           |> Seq.map (fun character -> character.as'string)
                           |> String.concat ""
                       as'literal =
                         quoted_characters
                         |> Seq.map (fun character -> character.as'literal)
                         |> String.concat ""
                       as'unicodepoints =
                         quoted_characters
                         |> Seq.map (fun character -> character.as'unicodepoint)
                         |> Seq.toArray

                     }



            )
            """ 
STRING_LITERAL_QUOTE ::= '"' ( [^#x22#x5C#xA#xD] | ECHAR | UCHAR )* '"'

            """

[<Struct>]
type Language_Code =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Language_Code, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '@'

                let! language_code =
                    many1 (unicodepoint_from Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.letters)

                return language_code
             }
             |>> fun language_codepoints ->

                     {

                       as'string =
                           "@"
                           + (language_codepoints
                              |> Seq.map (fun code_point -> code_point.as'string)
                              |> String.concat "")
                       as'unicodepoints = language_codepoints |> Seq.toArray

                     }

            )
            """ 
          '@' [a-zA-Z]+

            """

[<Struct>]
type Region_Code =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Region_Code, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '-'

                let! region_code =
                    many1 (
                        choice [

                                 unicodepoint_from Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.letters
                                 unicodepoint_from Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.partition

                                  ]
                    )

                return region_code
             }
             |>> fun region_codepoints ->

                     {

                       as'string =
                           "-"
                           + (region_codepoints
                              |> Seq.map (fun code_point -> code_point.as'string)
                              |> String.concat "")
                       as'unicodepoints = region_codepoints |> Seq.toArray

                     }

            )
            """ 
           '-' [a-zA-Z0-9]+ 

            """

[<Struct>]
type Base_Direction =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Base_Direction, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '-'
                do! skip_unicodepoint '-'

                let! base_direction =
                    many1 (unicodepoint_from Basic_Multilingual_Plane.Basic_Latin_Block.Latin_Alphabet.letters)


                return base_direction
             }
             |>> fun base_direction ->

                     {

                       as'string =
                           "--"
                           + (base_direction
                              |> Seq.map (fun code_point -> code_point.as'string)
                              |> String.concat "")
                       as'unicodepoints = base_direction |> Seq.toArray

                     }

            )
            """ 
           '-' [a-zA-Z0-9]+ 

            """

[<Struct>]
type Language_Tag =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array
      language_code: Language_Code
      region_code: Region_Code ValueOption
      base_direction: Base_Direction ValueOption

     }

    static member parse: Parser<Language_Tag, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! language_code = Language_Code.parse
                let! region_code = opt Region_Code.parse
                let! base_direction = opt Base_Direction.parse

                return (language_code, region_code, base_direction)
             }
             |>> fun (language_code, region_code_option, base_direction_option) ->
                     let region_code_string =
                         if region_code_option.IsSome then
                             $"@{region_code_option.Value}"
                         else
                             String.Empty

                     let base_direction_string =
                         if base_direction_option.IsSome then
                             $"--{base_direction_option.Value}"
                         else
                             String.Empty

                     let region_code_codepoints =
                         if region_code_option.IsSome then
                             region_code_option.Value.as'unicodepoints
                         else
                             [||]

                     let base_direction_codepoints =
                         if base_direction_option.IsSome then
                             base_direction_option.Value.as'unicodepoints
                         else
                             [||]


                     {

                       as'string = $"{language_code.as'string}{region_code_string}{base_direction_string}"
                       as'unicodepoints =
                         Array.concat [| language_code.as'unicodepoints
                                         region_code_codepoints
                                         base_direction_codepoints |]
                       language_code = language_code
                       region_code = region_code_option
                       base_direction = base_direction_option }

            )
            """ 
           LANG_DIR          ::= '@' [a-zA-Z]+ ( '-' [a-zA-Z0-9]+ )* ( '--' [a-zA-Z]+ )?
 

            """


[<Struct>]
type Prefixed_Name_Character_U_0_9 =
    {

      as'string: string
      as'int: int

     }

    static member parse: Parser<Prefixed_Name_Character_U_0_9, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [ unicodepoint_from pn_chars_u
                      unicodepoint_from Basic_Multilingual_Plane.Basic_Latin_Block.ASCII.digits.partition ]
             |>> fun unicodepoint ->
                     {

                       as'string = unicodepoint.as'string
                       as'int = unicodepoint.as'int

                     })
            """ 
             PN_CHARS_U | [0-9] 

            """

[<Struct>]
type Prefixed_Name_Tail =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Prefixed_Name_Tail, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (many1 (unicodepoint_from pn_chars_full_stop)
             |>> fun code_points ->
                     let last_index = code_points.Length - 1
                     let last_code_point = code_points.[last_index]

                     match last_code_point.as'string with
                     // TODO come up with a more parse native solution
                     | "." ->
                         failwith "Prefixed_Name_Tail originally written for BLANK_NODE_LABEL must not end with '.'"
                     | _ ->
                         {

                           as'string =
                               code_points
                               |> Seq.map (fun code_point -> code_point.as'string)
                               |> String.concat ""
                           as'unicodepoints = code_points |> Seq.toArray

                         })
            """ 
             (PN_CHARS|'.')* PN_CHARS 

            """

[<Struct>]
type Blank_Node_Label =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

     }

    static member parse: Parser<Blank_Node_Label, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '_'
                do! skip_unicodepoint ':'
                let! head = unicodepoint_from pn_chars_full_stop
                let! tail = opt Prefixed_Name_Tail.parse



                return (head, tail)
             }
             |>> fun (head, tail_option) ->
                     let tail_string =
                         match tail_option with
                         | ValueSome tail -> tail.as'string
                         | _ -> String.Empty

                     let tail_code_points =
                         match tail_option with
                         | ValueSome tail -> tail.as'unicodepoints
                         | _ -> [||]


                     {

                       as'string = $"{head}{tail_string}"
                       as'unicodepoints = Array.append [| head |] tail_code_points

                     }

            )
            """ 
           BLANK_NODE_LABEL  ::= '_:' ( PN_CHARS_U | [0-9] ) ((PN_CHARS|'.')* PN_CHARS)?

            """

type IRIREF =
    {


      as'string: string
      iri: IRI voption
      relative_reference: Internationalized_Relative_Reference voption
      is'relative: bool

     }



    static member parse: Parser<IRIREF, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '<'
                let! iriref = IRI_Reference.parse
                do! skip_unicodepoint '>'



                return (iriref)
             }
             |>> fun (iriref) ->


                     {

                       as'string = $"<{iriref.as'string}>"
                       iri = iriref.iri
                       relative_reference = iriref.relative_reference
                       is'relative = iriref.is'relative

                     }

            )
            """ 
           IRIREF            ::=  '<' ([^#x00-#x20<>"{}|^`\] | UCHAR)* '>'
 

            """



type Datatype_IRIREF =
    {


      as'string: string
      iri: IRI voption
      relative_reference: Internationalized_Relative_Reference voption
      is'relative: bool

     }



    static member parse: Parser<Datatype_IRIREF, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                do! skip_unicodepoint '^'
                do! skip_unicodepoint '^'
                let! iriref = IRI_Reference.parse



                return (iriref)
             }
             |>> fun (iriref) ->


                     {

                       as'string = $"^^{iriref.as'string}"
                       iri = iriref.iri
                       relative_reference = iriref.relative_reference
                       is'relative = iriref.is'relative

                     }

            )
            """ 
           '^^' IRIREF
 

            """

[<RequireQualifiedAccess>]
type Literal_Tag =
    | FromDatatypeIRIREF of Datatype_IRIREF
    | FromLanguageTag of Language_Tag

    static member parse: Parser<Literal_Tag, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      Datatype_IRIREF.parse |>> FromDatatypeIRIREF
                      Language_Tag.parse |>> FromLanguageTag


                       ]

            )
            """ 
           '^^' IRIREF | LANG_DIR 

            """


// TODO figure out why this isn't type checking
[<Struct>]
type RDF_Literal =
    {

      as'string: string
      quoted_string_literal: Quoted_String_Literal
      datatype_iriref: Datatype_IRIREF
      language_tag: Language_Tag ValueOption

     }

    static member parse: Parser<RDF_Literal, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! quoted_string_literal = Quoted_String_Literal.parse
                let! literal_tag = opt Literal_Tag.parse
                return (quoted_string_literal, literal_tag)


             }
             |>> fun (quoted_string_literal, literal_tag_option) ->

                     match literal_tag_option with
                     | ValueSome literal_tag ->
                         match literal_tag with
                         | Literal_Tag.FromDatatypeIRIREF datatype_iriref ->
                             {

                               as'string = $"{quoted_string_literal.as'string}{datatype_iriref.as'string}"
                               quoted_string_literal = quoted_string_literal
                               datatype_iriref = datatype_iriref
                               language_tag = ValueNone

                             }

                         | Literal_Tag.FromLanguageTag language_tag ->
                             let lang_datatype_iri_string =
                                 if language_tag.base_direction.IsSome then
                                     "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"
                                 else
                                     "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"

                             {

                               as'string = $"{quoted_string_literal.as'string}{language_tag.as'string}"
                               quoted_string_literal = quoted_string_literal
                               datatype_iriref =
                                 result'from_parse Datatype_IRIREF.parse OnInput $"^^{lang_datatype_iri_string}"
                               language_tag = ValueNone

                             }


                     | _ ->
                         {

                           as'string = quoted_string_literal.as'string
                           quoted_string_literal = quoted_string_literal
                           datatype_iriref =
                             result'from_parse
                                 Datatype_IRIREF.parse
                                 OnInput
                                 $"^^http://www.w3.org/2001/XMLSchema#string"
                           language_tag = ValueNone

                         })
            """ 
           literal           ::= STRING_LITERAL_QUOTE ('^^' IRIREF | LANG_DIR )?


            """

[<RequireQualifiedAccess>]
type RDF_Subject =
    | FromIRIREF of IRIREF
    | FromBlankNodeLabel of Blank_Node_Label

    static member parse: Parser<RDF_Subject, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      IRIREF.parse |>> FromIRIREF
                      Blank_Node_Label.parse |>> FromBlankNodeLabel


                       ]

            )
            """ 
           subject           ::= IRIREF | BLANK_NODE_LABEL

            """

[<RequireQualifiedAccess>]
type RDF_Predicate =
    | FromIRIREF of IRIREF


    static member parse: Parser<RDF_Predicate, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      IRIREF.parse |>> FromIRIREF


                       ]

            )
            """ 
           predicate         ::= IRIREF

            """

[<RequireQualifiedAccess>]
type RDF_Object =
    | FromIRIREF of IRIREF
    | FromBlankNodeLabel of Blank_Node_Label
    | FromRDFLiteral of RDF_Literal
    | FromTripleTerm of Triple_Term
    static member parse: Parser<RDF_Object, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice [

                      IRIREF.parse |>> FromIRIREF
                      Blank_Node_Label.parse |>> FromBlankNodeLabel
                      RDF_Literal.parse |>> FromRDFLiteral
                      Triple_Term.parse |>> FromTripleTerm


                       ]

            )
            """ 
           object            ::= IRIREF | BLANK_NODE_LABEL | literal | tripleTerm

            """

and Triple_Term =
    {

      rdf_subject: RDF_Subject
      rdf_predicate: RDF_Predicate
      rdf_object: RDF_Object


     }
    static member parse: Parser<Triple_Term, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {
                do! skip_unicodepoint '<'
                do! skip_unicodepoint '<'
                do! skip_unicodepoint '('
                let! rdf_subject = RDF_Subject.parse
                let! rdf_predicate = RDF_Predicate.parse
                let! rdf_object = RDF_Object.parse
                do! skip_unicodepoint ')'
                do! skip_unicodepoint '>'
                do! skip_unicodepoint '>'
                return (rdf_subject, rdf_predicate, rdf_object)
             }
             |>> fun (rdf_subject, rdf_predicate, rdf_object) ->
                     { rdf_subject = rdf_subject
                       rdf_predicate = rdf_predicate
                       rdf_object = rdf_object

                     }


            )
            """ 
               tripleTerm        ::= '<<(' subject predicate object ')>>'

                """
