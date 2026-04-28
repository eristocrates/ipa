#r "nuget: Unquote"

open Swensen.Unquote.Assertions

type Included_Interval<'ElementType when 'ElementType: comparison> =
    {

      first_element: 'ElementType
      last_element: 'ElementType

     }
    member this.Contains(element: 'ElementType) =
        this.first_element <= element
        && element <= this.last_element

type Excluded_Interval<'ElementType when 'ElementType: comparison> =
    {

      first_element: 'ElementType
      last_element: 'ElementType

     }
    member this.Contains(element: 'ElementType) =
        this.first_element <= element
        && element <= this.last_element

type Set_Definition<'ElementType when 'ElementType: comparison> =
    {

      included_roster: Set<'ElementType>
      included_intervals: Included_Interval<'ElementType> array
      excluded_roster: Set<'ElementType>
      excluded_intervals: Excluded_Interval<'ElementType> array

     }
    static member Empty<'ElementType when 'ElementType: comparison>() =
        {

          included_roster = Set.empty<'ElementType>
          included_intervals = [||]
          excluded_roster = Set.empty<'ElementType>
          excluded_intervals = [||]

        }

    member this.Contains(element: 'ElementType) =

        let exists_in_included_intervals =
            this.included_intervals
            |> Array.exists (fun included_interval -> included_interval.Contains element)


        let exists_in_excluded_intervals =
            this.excluded_intervals
            |> Array.exists (fun excluded_interval -> excluded_interval.Contains element)


        (this.included_roster.Contains element
         || exists_in_included_intervals)
        && not (
            this.excluded_roster.Contains element
            || exists_in_excluded_intervals
        )

    static member FromIncludedRoster<'ElementType when 'ElementType: comparison>(elements: seq<'ElementType>) =
        { Set_Definition.Empty<'ElementType>() with included_roster = Set.ofSeq elements }

    static member FromExcludedRoster<'ElementType when 'ElementType: comparison>(elements: seq<'ElementType>) =
        { Set_Definition.Empty<'ElementType>() with excluded_roster = Set.ofSeq elements }

    static member FromIncludedInterval<'ElementType when 'ElementType: comparison>
        (first_element: 'ElementType)
        (last_element: 'ElementType)
        =
        test <@ first_element <= last_element @>

        { Set_Definition.Empty<'ElementType>() with
            included_intervals =
                [| { first_element = first_element
                     last_element = last_element } |] }

    static member FromExcludedInterval<'ElementType when 'ElementType: comparison>
        (first_element: 'ElementType)
        (last_element: 'ElementType)
        =
        test <@ first_element <= last_element @>

        { Set_Definition.Empty<'ElementType>() with
            excluded_intervals =
                [| { first_element = first_element
                     last_element = last_element } |] }

    static member FromSingleton<'ElementType when 'ElementType: comparison>
        (element: 'ElementType)

        : Set_Definition<'ElementType> =
        { Set_Definition.Empty<'ElementType>() with included_roster = Set.ofArray [| element |] }

    static member FromString
        (element_string: string)

        : Set_Definition<int> =
        let code_points = seq { for rune in element_string.EnumerateRunes() -> rune.Value }


        Set_Definition.FromIncludedRoster(code_points)
    static member FromOverlay
        (set_definitions: Set_Definition<'ElementType> array)
        : Set_Definition<'ElementType> =

        {
            included_roster =
                set_definitions
                |> Seq.collect _.included_roster
                |> Set.ofSeq

            included_intervals =
                set_definitions
                |> Array.collect _.included_intervals

            excluded_roster =
                set_definitions
                |> Seq.collect _.excluded_roster
                |> Set.ofSeq

            excluded_intervals =
                set_definitions
                |> Array.collect _.excluded_intervals
        }

    static member ExcludeRoster
        (elements_to_exclude: seq<'ElementType>)
        (set_definition:Set_Definition<'ElementType>)

        : Set_Definition<'ElementType> =
        Set_Definition.FromOverlay [|
            set_definition
            Set_Definition.FromExcludedRoster elements_to_exclude
        |]

    static member ExcludeInterval
        (first_element: 'ElementType)
        (last_element: 'ElementType)
        (set_definition:Set_Definition<'ElementType>)

        : Set_Definition<'ElementType> =
        Set_Definition.FromOverlay [|
            set_definition
            Set_Definition.FromExcludedInterval first_element last_element
        |]

    static member FromExclusion
        (elements_to_exclude_set_definition: Set_Definition<'ElementType>)
        (elements_to_keep_set_definition: Set_Definition<'ElementType>)

        : Set_Definition<'ElementType> =

        Set_Definition.FromOverlay [|
            elements_to_keep_set_definition

            {
                included_roster = Set.empty
                included_intervals = [||]

                excluded_roster =
                    elements_to_exclude_set_definition.included_roster

                excluded_intervals =
                    elements_to_exclude_set_definition.included_intervals
                    |> Array.map (fun included_interval ->
                            {first_element = included_interval.first_element;
                            last_element = included_interval.last_element}
                    )
            }
        |]