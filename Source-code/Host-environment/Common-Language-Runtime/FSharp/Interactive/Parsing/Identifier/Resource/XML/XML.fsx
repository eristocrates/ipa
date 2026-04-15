open System
open System.Web
open System.Text
open System.IO
open System.Globalization




#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Metalanguage\ABNF\ABNF.fsx"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Codepoints\Punctuation.fsx"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\URI\URI.fsx"

open URI

open Punctuation
open System.Collections.Immutable

type NonColon_Name_Start_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        codepoint = 0x005F // "_"
        || (0x0041 <= codepoint && codepoint <= 0x005A) // A-Z
        || (0x0061 <= codepoint && codepoint <= 0x007A) // a-z
        || (0x00C0 <= codepoint && codepoint <= 0x00D6)
        || (0x00D8 <= codepoint && codepoint <= 0x00F6)
        || (0x00F8 <= codepoint && codepoint <= 0x02FF)
        || (0x0370 <= codepoint && codepoint <= 0x037D)
        || (0x037F <= codepoint && codepoint <= 0x1FFF)
        || (0x200C <= codepoint && codepoint <= 0x200D)
        || (0x2070 <= codepoint && codepoint <= 0x218F)
        || (0x2C00 <= codepoint && codepoint <= 0x2FEF)
        || (0x3001 <= codepoint && codepoint <= 0xD7FF)
        || (0xF900 <= codepoint && codepoint <= 0xFDCF)
        || (0xFDF0 <= codepoint && codepoint <= 0xFFFD)
        || (0x10000 <= codepoint && codepoint <= 0xEFFFF)

    static member parse: Parser<NonColon_Name_Start_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy NonColon_Name_Start_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ NonColon_Name_Start_Character = "_" | [A-Z] | [a-z] | [#xC0-#xD6] | [#xD8-#xF6] | [#xF8-#x2FF] | [#x370-#x37D] | [#x37F-#x1FFF] | [#x200C-#x200D] | [#x2070-#x218F] | [#x2C00-#x2FEF] | [#x3001-#xD7FF] | [#xF900-#xFDCF] | [#xFDF0-#xFFFD] | [#x10000-#xEFFFF] """

type NonColon_Name_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        // Reuse start character
        NonColon_Name_Start_Character.is_in_range rune

        // Additional NameChar cases
        || codepoint = 0x002D // "-"
        || codepoint = 0x002E // "."
        || (0x0030 <= codepoint && codepoint <= 0x0039) // 0-9
        || codepoint = 0x00B7
        || (0x0300 <= codepoint && codepoint <= 0x036F)
        || (0x203F <= codepoint && codepoint <= 0x2040)

    static member parse: Parser<NonColon_Name_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy NonColon_Name_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ NonColon_Name_Character = NonColon_Name_Start_Character | "-" | "." | [0-9] | #xB7 | [#x0300-#x036F] | [#x203F-#x2040] """

type NonColon_Name =
    {

      head: NonColon_Name_Start_Character
      tail: ImmutableArray<NonColon_Name_Character>

     }

    member this.as_characters =
        Seq.append (seq { { as_rune = this.head.as_rune } }) (this.tail)

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<NonColon_Name, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (NonColon_Name_Start_Character.parse
             .>>. many NonColon_Name_Character.parse
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """ NonColon_Name = NonColon_Name_Start_Character (NonColon_Name_Character)* """

type XML_Prefix =
    { as_name: NonColon_Name }

    member this.as_characters = this.as_name.as_characters
    member this.as_string = this.as_name.as_string

type XML_Namespace_Binding =
    {

      namespace_prefix: XML_Prefix
      namespace_reference: URI_Reference

     }

    static member xmlns (prefix_input: string) (namespace_input: string) =

        {

          namespace_prefix = { as_name = result_from_parse NonColon_Name.parse OnInput prefix_input }
          namespace_reference = result_from_parse URI_Reference.parse OnInput namespace_input

        }

type XML_Local_Part =
    { as_name: NonColon_Name }

    member this.as_characters = this.as_name.as_characters
    member this.as_string = this.as_name.as_string

    static member from_string(local_input: string) =
        { as_name = result_from_parse NonColon_Name.parse OnInput local_input }

type XML_Prefixed_Name =
    {

      namespace_binding: XML_Namespace_Binding
      local_part: XML_Local_Part

     }

    member this.as_characters =
        Seq.concat [

                     this.namespace_binding.namespace_prefix.as_characters
                     seq { { as_rune = Rune ':' } }
                     this.local_part.as_characters

                      ]

    member this.as_string =
        $"{this.namespace_binding.namespace_prefix.as_string}:{this.local_part.as_string}"

    static member from_strings (prefix_input: string) (reference_input: string) (local_input: string) =
        {

          namespace_binding = XML_Namespace_Binding.xmlns prefix_input reference_input
          local_part = XML_Local_Part.from_string local_input

        }

    static member from_binding (binding_input: XML_Namespace_Binding) (local_input: string) =
        {

          namespace_binding = binding_input
          local_part = XML_Local_Part.from_string local_input

        }


type XML_Unprefixed_Name =
    { as_name: NonColon_Name }

    member this.as_characters = this.as_name.as_characters
    member this.as_string = this.as_name.as_string

    static member from_string(input: string) =
        { as_name = result_from_parse NonColon_Name.parse OnInput input }

type XML_Qualified_Name =
    | FromPrefixedName of XML_Prefixed_Name
    | FromUnprefixedName of XML_Unprefixed_Name


    member this.as_characters =
        match this with
        | FromPrefixedName prefixed_name -> prefixed_name.as_characters
        | FromUnprefixedName unprefixed_name -> unprefixed_name.as_characters

    member this.as_string =
        match this with
        | FromPrefixedName prefixed_name -> prefixed_name.as_string
        | FromUnprefixedName unprefixed_name -> unprefixed_name.as_string



(*
let prefix_input = "edi"
let namespace_input = "http://ecommerce.example.org/schema"

let xml_namespace = XML_Namespace_Binding.xmlns prefix_input namespace_input

let prefixed_name = Prefixed_Name.from_binding xml_namespace "example"
prefixed_name.as_string
*)
