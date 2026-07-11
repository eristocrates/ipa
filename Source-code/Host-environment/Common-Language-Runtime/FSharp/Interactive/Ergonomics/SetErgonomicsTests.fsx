#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\SetErgonomics.fsx"

open SetErgonomics

open Swensen.Unquote.Assertions

#r "nuget: FsCheck"
open FsCheck














let from_included_roster_contains_exactly_roster_members (elements: int list) (element: int) =
    let set_definition = Set_Definition.FromIncludedRoster elements

    test <@ set_definition.Contains element = List.contains element elements @>

Check.Quick from_included_roster_contains_exactly_roster_members


let from_excluded_roster_contains_no_elements (elements: int list) (element: int) =
    let set_definition = Set_Definition.FromExcludedRoster elements

    test <@ set_definition.Contains element = false @>

Check.Quick from_excluded_roster_contains_no_elements


let from_included_interval_contains_exactly_elements_between_bounds (a: int) (b: int) (element: int) =
    let first_element = min a b
    let last_element = max a b

    let set_definition = Set_Definition.FromIncludedInterval first_element last_element

    test
        <@ set_definition.Contains element = (first_element <= element
                                              && element <= last_element) @>

Check.Quick from_included_interval_contains_exactly_elements_between_bounds


let from_singleton_contains_exactly_single_element (singleton: int) (element: int) =
    let set_definition = Set_Definition.FromSingleton singleton

    test <@ set_definition.Contains element = (element = singleton) @>

Check.Quick from_singleton_contains_exactly_single_element


let from_string_handles_astral_unicode_scalar_value () =
    let set_definition = Set_Definition.FromString "😀"

    test <@ set_definition.Contains 0x1F600 @>
    test <@ not (set_definition.Contains 0xD83D) @>
    test <@ not (set_definition.Contains 0xDE00) @>

from_string_handles_astral_unicode_scalar_value ()


let from_string_contains_each_enumerated_rune_value (text: string) =
    let set_definition = Set_Definition.FromString text

    let code_points =
        seq { for rune in text.EnumerateRunes() -> rune.Value }
        |> Seq.toList

    test <@ code_points |> List.forall set_definition.Contains @>

Check.Quick from_string_contains_each_enumerated_rune_value

let from_string_contains_each_enumerated_non_null_rune_value (NonNull text) =
    let set_definition = Set_Definition.FromString text

    let code_points =
        seq { for rune in text.EnumerateRunes() -> rune.Value }
        |> Seq.toList

    test <@ code_points |> List.forall set_definition.Contains @>

Check.Quick from_string_contains_each_enumerated_non_null_rune_value


let from_overlay_of_included_rosters_contains_element_from_either_roster
    (left_elements: int list)
    (right_elements: int list)
    (element: int)
    =

    let left = Set_Definition.FromIncludedRoster left_elements

    let right = Set_Definition.FromIncludedRoster right_elements

    let overlay =
        Set_Definition.FromOverlay [| left
                                      right |]

    test
        <@ overlay.Contains element = (List.contains element left_elements
                                       || List.contains element right_elements) @>

Check.Quick from_overlay_of_included_rosters_contains_element_from_either_roster

let from_overlay_excluded_roster_suppresses_included_roster
    (included_elements: int list)
    (excluded_elements: int list)
    (element: int)
    =

    let included = Set_Definition.FromIncludedRoster included_elements

    let excluded = Set_Definition.FromExcludedRoster excluded_elements

    let overlay =
        Set_Definition.FromOverlay [| included
                                      excluded |]

    test
        <@ overlay.Contains element = (List.contains element included_elements
                                       && not (List.contains element excluded_elements)) @>

Check.Quick from_overlay_excluded_roster_suppresses_included_roster

let from_overlay_excluded_roster_suppresses_included_interval
    (a: int)
    (b: int)
    (excluded_elements: int list)
    (element: int)
    =

    let first_element = min a b
    let last_element = max a b

    let included_interval =
        Set_Definition.FromIncludedInterval first_element last_element

    let excluded_roster = Set_Definition.FromExcludedRoster excluded_elements

    let overlay =
        Set_Definition.FromOverlay [| included_interval
                                      excluded_roster |]

    test
        <@ overlay.Contains element = (first_element <= element
                                       && element <= last_element
                                       && not (List.contains element excluded_elements)) @>

Check.Quick from_overlay_excluded_roster_suppresses_included_interval

let from_overlay_excluded_interval_suppresses_included_roster
    (included_elements: int list)
    (a: int)
    (b: int)
    (element: int)
    =

    let first_element = min a b
    let last_element = max a b

    let included_roster = Set_Definition.FromIncludedRoster included_elements

    let excluded_interval =
        Set_Definition.FromExcludedInterval first_element last_element

    let overlay =
        Set_Definition.FromOverlay [| included_roster
                                      excluded_interval |]

    test
        <@ overlay.Contains element = (List.contains element included_elements
                                       && not (
                                           first_element <= element
                                           && element <= last_element
                                       )) @>

Check.Quick from_overlay_excluded_interval_suppresses_included_roster

let from_overlay_with_empty_preserves_included_roster (included_elements: int list) (element: int) =

    let included = Set_Definition.FromIncludedRoster included_elements

    let overlay =
        Set_Definition.FromOverlay [| Set_Definition.Empty()
                                      included |]

    test <@ overlay.Contains element = included.Contains element @>

Check.Quick from_overlay_with_empty_preserves_included_roster


let exclude_roster_static_suppresses_elements
    (included_elements: int list)
    (excluded_elements: int list)
    (element: int)
    =

    let set_definition =
        Set_Definition.FromIncludedRoster included_elements
        |> Set_Definition.ExcludeRoster excluded_elements

    test
        <@ set_definition.Contains element = (List.contains element included_elements
                                              && not (List.contains element excluded_elements)) @>

Check.Quick exclude_roster_static_suppresses_elements

let exclude_interval_static_suppresses_interval (included_elements: int list) (a: int) (b: int) (element: int) =

    let first_element = min a b
    let last_element = max a b

    let set_definition =
        Set_Definition.FromIncludedRoster included_elements
        |> Set_Definition.ExcludeInterval first_element last_element

    test
        <@ set_definition.Contains element = (List.contains element included_elements
                                              && not (
                                                  first_element <= element
                                                  && element <= last_element
                                              )) @>

Check.Quick exclude_interval_static_suppresses_interval

let exclude_roster_static_suppresses_included_interval (a: int) (b: int) (excluded_elements: int list) (element: int) =

    let first_element = min a b
    let last_element = max a b

    let set_definition =
        Set_Definition.FromIncludedInterval first_element last_element
        |> Set_Definition.ExcludeRoster excluded_elements

    test
        <@ set_definition.Contains element = (first_element <= element
                                              && element <= last_element
                                              && not (List.contains element excluded_elements)) @>

Check.Quick exclude_roster_static_suppresses_included_interval

let exclude_interval_static_suppresses_included_interval (a: int) (b: int) (c: int) (d: int) (element: int) =

    let first_included = min a b
    let last_included = max a b

    let first_excluded = min c d
    let last_excluded = max c d

    let set_definition =
        Set_Definition.FromIncludedInterval first_included last_included
        |> Set_Definition.ExcludeInterval first_excluded last_excluded

    test
        <@ set_definition.Contains element = (first_included <= element
                                              && element <= last_included
                                              && not (
                                                  first_excluded <= element
                                                  && element <= last_excluded
                                              )) @>

Check.Quick exclude_interval_static_suppresses_included_interval



let from_exclusion_subtracts_included_interval_from_included_interval
    (a: int)
    (b: int)
    (c: int)
    (d: int)
    (element: int)
    =

    let first_included = min a b
    let last_included = max a b

    let first_excluded = min c d
    let last_excluded = max c d

    let keep = Set_Definition.FromIncludedInterval first_included last_included

    let exclude = Set_Definition.FromIncludedInterval first_excluded last_excluded

    let result = keep |> Set_Definition.FromExclusion exclude

    test
        <@ result.Contains element = (first_included <= element
                                      && element <= last_included
                                      && not (
                                          first_excluded <= element
                                          && element <= last_excluded
                                      )) @>

Check.Quick from_exclusion_subtracts_included_interval_from_included_interval


let from_exclusion_defines_unicode_scalar_value_set () =
    let Codespace = Set_Definition.FromIncludedInterval 0x0000 0x10FFFF

    let Surrogate_Code_Point_Set = Set_Definition.FromIncludedInterval 0xD800 0xDFFF

    let Unicode_Scalar_Value_Set =
        Codespace
        |> Set_Definition.FromExclusion Surrogate_Code_Point_Set

    test <@ Unicode_Scalar_Value_Set.Contains 0x0000 @>
    test <@ Unicode_Scalar_Value_Set.Contains 0xD7FF @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xD800) @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xDFFF) @>
    test <@ Unicode_Scalar_Value_Set.Contains 0xE000 @>
    test <@ Unicode_Scalar_Value_Set.Contains 0x10FFFF @>

from_exclusion_defines_unicode_scalar_value_set ()

let from_exclusion_subtracts_included_roster_from_included_interval
    (a: int)
    (b: int)
    (excluded_elements: int array)
    (element: int)
    =

    let first_included = min a b
    let last_included = max a b

    let keep = Set_Definition.FromIncludedInterval first_included last_included

    let exclude = Set_Definition.FromIncludedRoster excluded_elements

    let result = keep |> Set_Definition.FromExclusion exclude

    test
        <@ result.Contains element = (first_included <= element
                                      && element <= last_included
                                      && not (Array.contains element excluded_elements)) @>

Check.Quick from_exclusion_subtracts_included_roster_from_included_interval
