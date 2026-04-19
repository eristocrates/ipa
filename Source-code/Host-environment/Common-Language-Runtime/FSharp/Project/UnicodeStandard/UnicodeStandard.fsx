open System
open System.Linq
open System.Text
open System.Text.Unicode
open System.Globalization
open System.Xml.Linq

#r "nuget: FSharp.Data"
open FSharp.Data


module ucd =
    (*
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

*)
    module cp =
        let as_int (cp: string) = int $"0x{cp}"



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
type Unicodepoint =
    {

      as'string: string
      as'int: int

    }


    static member from'int(input: int) =
        {

          as'string =
            try
                Rune(input).ToString()
            with _ ->
                String.Empty
          as'int = input

        }

    static member from'hexadecimal_digit_string(hexdig_string: string) =
        Unicodepoint.from'int (int $"0x{hexdig_string}")

    static member array'from'string(input: string) =
        input.EnumerateRunes()
        |> Seq.map (fun rune ->

            {

              as'string = rune.ToString()
              as'int = rune.Value

            }

        )
        |> Seq.toArray

    static member sequence'to'string(unicodepoints: Unicodepoint seq) =
        unicodepoints
        |> Seq.map (fun unicodepoint -> unicodepoint.as'string)
        |> String.concat ""
    (*
    member this.name =
        let unicodepoint_value = this.as'int


        let unicode_char =
            ucd.flat.xml.Repertoire.Chars
            |> Array.find (fun unicode_char -> ucd.cp.as_int unicode_char.Cp.Value = unicodepoint_value)

        let aliases =
            unicode_char.NameAlias
            |> Array.map (fun name_alias ->
                { alias = name_alias.Alias
                  alias_type = Unicode_Alias_Type.from_string name_alias.Type })

        { current = unicode_char.Na
          version1 = unicode_char.Na1
          aliases = aliases }


    member this.block =
        let unicodepoint_value = this.as'int


        let unicode_block =
            ucd.grouped.xml.Blocks
            |> Array.find (fun unicode_block ->

                ucd.cp.as_int unicode_block.FirstCp.Value <= unicodepoint_value
                && unicodepoint_value <= ucd.cp.as_int unicode_block.LastCp

            )

        let from'codepoint =
            Unicodepoint.from'int (ucd.cp.as_int unicode_block.FirstCp.Value)

        let to'codepoint = Unicodepoint.from'int (ucd.cp.as_int unicode_block.LastCp)



        {

          block_name = unicode_block.Name
          unicodepoint_range =
            {

              from'codepoint = from'codepoint
              to'codepoint = to'codepoint

            }

        }


*)
    member this.is'in_range(unicodepoint_range: Unicodepoint_Range) =
        let codepoint = this.as'int
        let first_codepoint = unicodepoint_range.from'codepoint.as'int
        let last_codepoint = unicodepoint_range.to'codepoint.as'int

        first_codepoint <= codepoint && codepoint <= last_codepoint

    member this.is'on_roster(unicodepoint_roster: Unicodepoint_Roster) =
        unicodepoint_roster.unicodepoint_roster_set.Contains this

    member this.is'member_of(unicodepoint_set: Unicodepoint_Set) =
        let is_on_roster = this.is'on_roster
        let is_in_range = this.is'in_range

        let roster_check =
            unicodepoint_set.unicodepoint_rosters
            |> Array.map (fun roster -> is_on_roster roster)

        let range_check =
            unicodepoint_set.unicodepoint_ranges
            |> Array.map (fun range -> is_in_range range)

        let check_result = Array.concat [| roster_check; range_check |]

        check_result.Contains true




and [<Struct>] Unicodepoint_Range =
    {

      from'codepoint: Unicodepoint
      to'codepoint: Unicodepoint

    }

    static member from'ints (first_int: int) (last_int: int) =
        {

          from'codepoint = Unicodepoint.from'int first_int
          to'codepoint = Unicodepoint.from'int last_int

        }

and [<Struct>] Unicode_Block =
    {

      block_name: string
      unicodepoint_range: Unicodepoint_Range

    }

and [<Struct>] Unicodepoint_Roster =
    {

      string_set: string
      unicodepoint_roster_set: Set<Unicodepoint>

    }

    static member from'string(input: string) =

        {

          string_set = input
          unicodepoint_roster_set = Unicodepoint.array'from'string input |> Set.ofArray

        }

    static member from'string_array(string_array: string array) =
        let unicodepoints =
            string_array
            |> Array.collect (fun string_ ->

                Unicodepoint.array'from'string string_

            )
            |> Set.ofArray

        {

          string_set = string_array |> String.concat ""
          unicodepoint_roster_set = unicodepoints

        }

    static member from'int_array(int_array: int array) =
        let unicodepoints =
            int_array
            |> Array.map (fun int_ ->

                Unicodepoint.from'int int_

            )
            |> Set.ofArray

        let roster_string =
            unicodepoints
            |> Set.map (fun unicodepoint -> unicodepoint.as'string)
            |> String.concat ""

        {

          string_set = roster_string
          unicodepoint_roster_set = unicodepoints

        }

    static member from'unicodepoint_rosters(unicodepoint_rosters: Unicodepoint_Roster array) =
        let string_array =
            unicodepoint_rosters
            |> Array.map (fun unicodepoint_roster_set ->

                unicodepoint_roster_set.string_set

            )

        Unicodepoint_Roster.from'string_array string_array


and [<Struct>] Unicodepoint_Set =
    {

      unicodepoint_rosters: Unicodepoint_Roster array
      unicodepoint_ranges: Unicodepoint_Range array

    }

    static member from'rosters(unicodepoint_rosters: Unicodepoint_Roster array) =
        {

          unicodepoint_rosters = unicodepoint_rosters
          unicodepoint_ranges = [||]

        }

    static member from'ranges(unicodepoint_ranges: Unicodepoint_Range array) =
        {

          unicodepoint_rosters = [||]
          unicodepoint_ranges = unicodepoint_ranges

        }

    static member from'rosters_and_ranges
        (unicodepoint_rosters: Unicodepoint_Roster array)
        (unicodepoint_ranges: Unicodepoint_Range array)
        =
        {

          unicodepoint_rosters = unicodepoint_rosters
          unicodepoint_ranges = unicodepoint_ranges

        }

    static member from'union(unicodepoint_sets: Unicodepoint_Set array) =
        let unicodepoint_rosters =
            unicodepoint_sets |> Array.collect (fun set -> set.unicodepoint_rosters)

        let unicodepoint_ranges =
            unicodepoint_sets |> Array.collect (fun set -> set.unicodepoint_ranges)

        {

          unicodepoint_rosters = unicodepoint_rosters
          unicodepoint_ranges = unicodepoint_ranges

        }

and [<Struct>] Unicode_Partition =
    {

      partition_name: string
      unicodepoint_set: Unicodepoint_Set

    }

/// https://www.unicode.org/reports/tr29/#Grapheme_Cluster_Boundaries
[<Struct>]
type Grapheme_Cluster =
    {

      as'string: string
      as'codepoints: Unicodepoint array

    }

    static member array'from'string(input: string) =

        seq {
            let enumerator = StringInfo.GetTextElementEnumerator(input)

            while enumerator.MoveNext() do
                let grapheme_cluster_string = enumerator.GetTextElement()

                yield
                    {

                      as'string = grapheme_cluster_string
                      as'codepoints = Unicodepoint.array'from'string grapheme_cluster_string

                    }

        }
        |> Seq.toArray






[<Struct>]
type Unicode_Named_Sequence =
    {

      sequence_name: string
      codepoints: Unicodepoint array

    }



(*
module Unicode_Named_Sequences =
    let involving'unicodepoint (unicodepoint: Unicodepoint) =


        let named_sequences =
            ucd.grouped.xml.NamedSequences
            |> Array.choose (fun sequence ->
                let cps = sequence.Cps.Split(" ") |> Array.map (fun cp -> ucd.cp.as_int cp)




                if cps.Contains(unicodepoint.as'int) then
                    let codepoints =
                        cps
                        |> Array.map (fun codepoint_value ->

                            Unicodepoint.from'int codepoint_value

                        )

                    Some(
                        {

                          sequence_name = sequence.Name
                          codepoints = codepoints

                        }
                    )
                else
                    None

            )

        named_sequences


*)


let Unicode_Space = Unicodepoint_Range.from'ints 0x0000 0x10FFFF

[<Struct>]
type Unicode_Plane =
    {

      plane_name: string
      abbreviation: string
      as'int: int
      unicodepoint_range: Unicodepoint_Range

    }



module Basic_Multilingual_Plane =
    let as'unicode_plane =
        {

          plane_name = "Basic Multilingual Plane"
          abbreviation = "BMP"
          as'int = 0
          unicodepoint_range = Unicodepoint_Range.from'ints 0x0000 0xFFFF

        }

    module Basic_Latin_Block =
        let as'unicode_block =
            {

              block_name = "Basic Latin"
              unicodepoint_range = Unicodepoint_Range.from'ints 0x0000 0x007F

            }




        let C0_controls =

            {

              partition_name = "C0 controls"
              unicodepoint_set =
                {

                  unicodepoint_ranges = [| Unicodepoint_Range.from'ints 0x0000 0x001F |]
                  unicodepoint_rosters = [||]

                }


            }

        module ASCII =
            module punctuation_and_symbols =
                let partition =
                    {

                      partition_name = "ASCII punctuation and symbols"
                      unicodepoint_set =
                        {

                          unicodepoint_ranges =
                            [|

                               Unicodepoint_Range.from'ints 0x0020 0x002F
                               Unicodepoint_Range.from'ints 0x003A 0x0040
                               Unicodepoint_Range.from'ints 0x005B 0x0060
                               Unicodepoint_Range.from'ints 0x007B 0x007E

                               |]
                          unicodepoint_rosters = [||]

                        }

                    }

                let commercial_at =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "@" |]

                let colon = Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string ":" |]

                let solidus =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "/" |]

                let question_mark =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "?" |]

                let plus_sign =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "+" |]

                let hyphen_minus =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "-" |]

                let full_stop =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "." |]

                let tilde = Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "~" |]

                let low_line =
                    Unicodepoint_Set.from'rosters [| Unicodepoint_Roster.from'string "_" |]

            module digits =
                let partition =
                    {

                      partition_name = "ASCII digits"
                      unicodepoint_set =
                        {

                          unicodepoint_ranges =
                            [|

                               Unicodepoint_Range.from'ints 0x0030 0x0039

                               |]
                          unicodepoint_rosters = [||]

                        }

                    }


                let zero'to'four =
                    {

                      partition_name = "0-4"
                      unicodepoint_set =

                        {

                          unicodepoint_ranges = [||]
                          unicodepoint_rosters = [| Unicodepoint_Roster.from'string "01234" |]

                        }

                    }

                let zero'to'five =
                    {

                      partition_name = "0-5"
                      unicodepoint_set =
                        {

                          unicodepoint_ranges = [||]
                          unicodepoint_rosters = [| Unicodepoint_Roster.from'string "012345" |]

                        }

                    }

        module Latin_Alphabet =
            let majuscule =
                {

                  partition_name = "Uppercase Latin alphabet"
                  unicodepoint_set =
                    {

                      unicodepoint_ranges =
                        [|

                           Unicodepoint_Range.from'ints 0x0041 0x005A

                           |]
                      unicodepoint_rosters = [||]

                    }

                }

            let minuscule =
                {

                  partition_name = "Lowercase Latin alphabet"
                  unicodepoint_set =
                    {

                      unicodepoint_ranges =
                        [|

                           Unicodepoint_Range.from'ints 0x0061 0x007A

                           |]
                      unicodepoint_rosters = [||]

                    }

                }

            let letters =

                {

                  partition_name = "Latin alphabet"
                  unicodepoint_set =
                    Unicodepoint_Set.from'union
                        [|

                           majuscule.unicodepoint_set
                           minuscule.unicodepoint_set

                           |]

                }

            module hexadecimal =

                let majuscule =
                    {

                      partition_name = "Uppercase hexadecimal digit"
                      unicodepoint_set =
                        {

                          unicodepoint_ranges =
                            [|

                               Unicodepoint_Range.from'ints 0x0041 0x0046

                               |]
                          unicodepoint_rosters = [||]

                        }

                    }

                let minuscule =
                    {

                      partition_name = "Lowercase hexidecimal digit"
                      unicodepoint_set =
                        {

                          unicodepoint_ranges =
                            [|

                               Unicodepoint_Range.from'ints 0x0061 0x0066

                               |]
                          unicodepoint_rosters = [||]

                        }

                    }

                let digits =

                    {

                      partition_name = "Hexidecimal digits"
                      unicodepoint_set =
                        Unicodepoint_Set.from'union
                            [|

                               majuscule.unicodepoint_set
                               minuscule.unicodepoint_set

                               |]

                    }

            let control_codes =
                let roster = Unicodepoint_Roster.from'int_array [| 0x007F |]

                {

                  partition_name = "Control Codes"
                  unicodepoint_set =
                    {

                      unicodepoint_ranges = C0_controls.unicodepoint_set.unicodepoint_ranges
                      unicodepoint_rosters = [| roster |]

                    }

                }
