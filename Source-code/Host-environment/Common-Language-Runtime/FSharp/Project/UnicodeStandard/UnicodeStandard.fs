open System
open System.Linq
open System.Text
open System.Text.Unicode
open System.Globalization
open System.Xml.Linq

open FSharp.Data


module ucd =
    module flat =
        [<Literal>]
        let flatFilePath =
            @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

        let xml = XmlProvider<flatFilePath>.Load flatFilePath

    module grouped =
        [<Literal>]
        let groupedFilePath =
            @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.grouped.xml"

        let xml = XmlProvider<groupedFilePath>.Load groupedFilePath


[<Struct>]
type Unicodepoint = { value: int }

let unicodepoint_value'from'ucd_string (ucd_string: string) = int $"0x{ucd_string}"

[<Struct>]
type Grapheme_Cluster =
    {

      as_string: string

     }



let grapheme_clusters'from'string (input: string) =
    seq {
        let enumerator = StringInfo.GetTextElementEnumerator(input)

        while enumerator.MoveNext() do
            yield { as_string = enumerator.GetTextElement() }



    }
    |> Seq.toArray

let unicodepoints'from'grapheme_cluster (grapheme_cluster: Grapheme_Cluster) =
    grapheme_cluster.as_string.EnumerateRunes()
    |> Seq.map (fun rune -> { value = rune.Value })
    |> Seq.toArray


let unicodepoints_from_string (input: string) =
    let grapheme_clusters = grapheme_clusters'from'string input

    grapheme_clusters
    |> Array.collect (fun grapheme_cluster -> unicodepoints'from'grapheme_cluster grapheme_cluster)




[<Struct>]
[<RequireQualifiedAccess>]
type Unicode_Alias_Type =
    | abbreviation of string
    | control of string
    | figment of string
    | correction of string
    | alternate of string
    | unknown of string
    static member from_string(alias_type: string) =
        match alias_type with
        | "abbreviation" -> abbreviation alias_type
        | "control" -> control alias_type
        | "figment" -> figment alias_type
        | "correction" -> correction alias_type
        | "alternate" -> alternate alias_type
        | _ -> unknown alias_type


[<Struct>]
type Unicode_Alias =
    {

      alias: string
      alias_type: Unicode_Alias_Type

     }

[<Struct>]
type Unicode_Name =
    {

      current: string option
      version1: string option
      aliases: Unicode_Alias array

     }

[<Struct>]
type Unicode_Block =
    {

      name: string
      from_codepoint_value: int
      to_codepoint_value: int

     }

[<Struct>]
type Unicode_Named_Sequence =
    {

      name: string
      codepoint_values: int array

     }

let name'from'unicodepoint (unicodepoint: Unicodepoint) =
    let unicode_char =
        ucd.flat.xml.Repertoire.Chars
        |> Array.find (fun unicode_char -> unicodepoint_value'from'ucd_string unicode_char.Cp.Value = unicodepoint.value)

    let aliases =
        unicode_char.NameAlias
        |> Array.map (fun name_alias ->

            {

              alias = name_alias.Alias
              alias_type = Unicode_Alias_Type.from_string name_alias.Type

            }

        )

    {

      current = unicode_char.Na
      version1 = unicode_char.Na1
      aliases = aliases

    }

let block'from'unicodepoint (unicodepoint: Unicodepoint) =
    let unicode_block =
        ucd.grouped.xml.Blocks
        |> Array.find (fun unicode_block ->

            unicodepoint_value'from'ucd_string unicode_block.FirstCp.Value
            <= unicodepoint.value
            && unicodepoint.value
               <= unicodepoint_value'from'ucd_string unicode_block.LastCp

        )


    {

      name = unicode_block.Name
      from_codepoint_value = unicodepoint_value'from'ucd_string unicode_block.FirstCp.Value
      to_codepoint_value = unicodepoint_value'from'ucd_string unicode_block.LastCp

    }



let named_sequences'from'unicodepoint (unicodepoint: Unicodepoint) =

    let named_sequences =
        ucd.grouped.xml.NamedSequences
        |> Array.choose (fun sequence ->
            let cps =
                sequence.Cps.Split(" ")
                |> Array.map (fun ucd_string -> unicodepoint_value'from'ucd_string ucd_string)




            if cps.Contains(unicodepoint.value) then

                Some(
                    {

                      name = sequence.Name
                      codepoint_values = cps

                    }
                )
            else
                None

        )

    named_sequences


(*
let test_string = grapheme_clusters'from'string "test"
let test_codepoint = test_string[0].as_codepoints[0]
name'from'unicodepoint test_codepoint
block'from'unicodepoint test_codepoint
named_sequences'from'unicodepoint test_codepoint

*)
