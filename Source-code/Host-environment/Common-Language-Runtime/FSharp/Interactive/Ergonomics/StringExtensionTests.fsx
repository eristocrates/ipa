open System
open System.Text
open System.Text
open System.Text.Unicode
open System.Globalization

#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"

open StringExtensions
open Swensen.Unquote.Assertions

#r "nuget: FsCheck"
open FsCheck

let code_point_rejects_negative_int () =
    raises<Swensen.Unquote.AssertionFailedException> <@ Code_Point.op_Explicit -1 |> ignore @>

let code_point_rejects_above_codespace () =
    raises<Swensen.Unquote.AssertionFailedException> <@ Code_Point.op_Explicit 0x110000 |> ignore @>

let unicode_scalar_value_rejects_surrogate () =
    raises<Swensen.Unquote.AssertionFailedException> <@ Unicode_Scalar_Value.op_Explicit 0xD800 |> ignore @>

let code_point_from_rune_accepts_astral_scalar () =
    let code_point = Code_Point.op_Explicit (Rune 0x1F600)

    test <@ Code_Point.as_Uhex_literal code_point = "U+1F600" @>

let string_runes_handles_astral_scalar_as_single_rune () = test <@ "😀".Runes.Length = 1 @>

let string_text_elements_handles_combining_sequence_as_one_text_element () =
    test <@ "e\u0301".TextElements.Length = 1 @>

let grapheme_cluster_round_trips_combining_sequence () =
    let grapheme_cluster = "e\u0301".GraphemeClusters[0]

    test <@ Grapheme_Cluster.as_string grapheme_cluster = "e\u0301" @>




let code_point_acceptance_matches_codespace (raw_int: int) =
    let succeeds =
        try
            Code_Point.op_Explicit raw_int |> ignore
            true
        with
        | :? Swensen.Unquote.AssertionFailedException -> false

    test <@ succeeds = Codespace.Contains raw_int @>

Check.Quick code_point_acceptance_matches_codespace


let unicode_scalar_acceptance_matches_unicode_scalar_value_set (raw_int: int) =
    let succeeds =
        try
            Unicode_Scalar_Value.op_Explicit raw_int |> ignore
            true
        with
        | :? Swensen.Unquote.AssertionFailedException -> false

    test <@ succeeds = Unicode_Scalar_Value_Set.Contains raw_int @>

Check.Quick unicode_scalar_acceptance_matches_unicode_scalar_value_set


let unicode_scalar_values_are_code_points (raw_int: int) =
    test
        <@ not (Unicode_Scalar_Value_Set.Contains raw_int)
           || Codespace.Contains raw_int @>

Check.Quick unicode_scalar_values_are_code_points


let surrogate_code_points_are_not_unicode_scalar_values (raw_int: int) =
    test
        <@ not (Surrogate_Code_Point_Set.Contains raw_int)
           || not (Unicode_Scalar_Value_Set.Contains raw_int) @>

Check.Quick surrogate_code_points_are_not_unicode_scalar_values


let code_point_from_rune_round_trips_to_rune (raw_scalar_value: int) =
    if Unicode_Scalar_Value_Set.Contains raw_scalar_value then
        let rune = Rune raw_scalar_value

        let code_point = Code_Point.op_Explicit rune

        test <@ Code_Point.as_rune code_point = rune @>

Check.Quick code_point_from_rune_round_trips_to_rune


let code_point_hex_literal_matches_raw_int (raw_int: int) =
    if Codespace.Contains raw_int then
        let code_point = Code_Point.op_Explicit raw_int

        test <@ Code_Point.as_hex_literal code_point = sprintf "%04X" raw_int @>

Check.Quick code_point_hex_literal_matches_raw_int


let code_point_uhex_literal_matches_raw_int (raw_int: int) =
    if Codespace.Contains raw_int then
        let code_point = Code_Point.op_Explicit raw_int

        test <@ Code_Point.as_Uhex_literal code_point = sprintf "U+%04X" raw_int @>

Check.Quick code_point_uhex_literal_matches_raw_int


let string_runes_match_enumerate_runes (raw_string: NonNull<string>) =
    let expected = raw_string.Get.EnumerateRunes() |> Seq.toArray

    test <@ raw_string.Get.Runes = expected @>

Check.Quick string_runes_match_enumerate_runes


let string_text_elements_are_never_null (raw_string: NonNull<string>) =
    let text_elements = raw_string.Get.TextElements

    test
        <@ text_elements
           |> Array.forall (fun text_element -> Text_Element.as_string text_element <> null) @>

Check.Quick string_text_elements_are_never_null


let grapheme_clusters_round_trip_to_original_string_by_concatenation (raw_string: NonNull<string>) =
    let reconstructed =
        raw_string.Get.GraphemeClusters
        |> Array.map Grapheme_Cluster.as_string
        |> String.concat ""

    test <@ reconstructed = raw_string.Get @>

Check.Quick grapheme_clusters_round_trip_to_original_string_by_concatenation
