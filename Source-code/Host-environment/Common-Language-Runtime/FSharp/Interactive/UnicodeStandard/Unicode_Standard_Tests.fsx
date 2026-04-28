open System
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Unicode_Standard.fsx"

open Unicode_Standard

open SetErgonomics

open Swensen.Unquote.Assertions

#r "nuget: FsCheck"
open FsCheck









let unicode_codespace_accepts_bounds_and_rejects_outside () =
    test <@ Codespace.Contains 0x0000 @>
    test <@ Codespace.Contains 0x10FFFF @>
    test <@ not (Codespace.Contains -1) @>
    test <@ not (Codespace.Contains 0x110000) @>

unicode_codespace_accepts_bounds_and_rejects_outside ()


let unicode_scalar_value_excludes_surrogates () =
    test <@ Unicode_Scalar_Value_Set.Contains 0x0000 @>
    test <@ Unicode_Scalar_Value_Set.Contains 0xD7FF @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xD800) @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xDBFF) @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xDC00) @>
    test <@ not (Unicode_Scalar_Value_Set.Contains 0xDFFF) @>
    test <@ Unicode_Scalar_Value_Set.Contains 0xE000 @>
    test <@ Unicode_Scalar_Value_Set.Contains 0x10FFFF @>

let unicode_scalar_value_parse_accepts_exactly_unicode_scalar_values (raw_int: int) =
    if Unicode_Scalar_Value_Set.Contains raw_int then
        let parsed = Unicode_Scalar_Value.parse raw_int
        test <@ int parsed = raw_int @>
    else
        raises<Swensen.Unquote.AssertionFailedException> <@ Unicode_Scalar_Value.parse raw_int |> ignore @>

Check.Quick unicode_scalar_value_parse_accepts_exactly_unicode_scalar_values


let int_from_hexadecimal_digit_string_matches_convert_for_non_negative_int (NonNegativeInt raw_int) =
    let hexadecimal_digit_string = raw_int.ToString("X")

    test
        <@ int_from_hexadecimal_digit_string hexadecimal_digit_string = Convert.ToInt32(hexadecimal_digit_string, 16) @>

Check.Quick int_from_hexadecimal_digit_string_matches_convert_for_non_negative_int
#r "nuget: FsCheck"

open FsCheck
open Swensen.Unquote.Assertions

// Partition law: Codespace = Scalar ∪ Surrogate
let codespace_equals_scalar_or_surrogate (raw_int: int) =
    test
        <@ Codespace.Contains raw_int = (Unicode_Scalar_Value_Set.Contains raw_int
                                         || Surrogate_Code_Point_Set.Contains raw_int) @>

Check.Quick codespace_equals_scalar_or_surrogate

// Disjointness: Scalar ∩ Surrogate = ∅
let scalar_and_surrogate_are_disjoint (raw_int: int) =
    test
        <@ not (
            Unicode_Scalar_Value_Set.Contains raw_int
            && Surrogate_Code_Point_Set.Contains raw_int
        ) @>

Check.Quick scalar_and_surrogate_are_disjoint

// Scalar subset of Codespace
let scalar_is_subset_of_codespace (raw_int: int) =
    test
        <@ not (Unicode_Scalar_Value_Set.Contains raw_int)
           || Codespace.Contains raw_int @>

Check.Quick scalar_is_subset_of_codespace

// Surrogate subset of Codespace
let surrogate_is_subset_of_codespace (raw_int: int) =
    test
        <@ not (Surrogate_Code_Point_Set.Contains raw_int)
           || Codespace.Contains raw_int @>

Check.Quick surrogate_is_subset_of_codespace

// Basic Latin ⊆ BMP
let basic_latin_subset_of_bmp (raw_int: int) =
    test
        <@ not (Basic_Latin_Block.Contains raw_int)
           || Basic_Multilingual_Plane.Contains raw_int @>

Check.Quick basic_latin_subset_of_bmp

// ASCII letters ⊆ Basic Latin
let ascii_letters_subset_of_basic_latin (raw_int: int) =
    test
        <@ not (Latin_Alphabet.Contains raw_int)
           || Basic_Latin_Block.Contains raw_int @>

Check.Quick ascii_letters_subset_of_basic_latin

// ASCII digits ⊆ Basic Latin
let ascii_digits_subset_of_basic_latin (raw_int: int) =
    test
        <@ not (ASCII_digits.Contains raw_int)
           || Basic_Latin_Block.Contains raw_int @>

Check.Quick ascii_digits_subset_of_basic_latin

// Hex digits ⊆ Basic Latin
let hex_digits_subset_of_basic_latin (raw_int: int) =
    test
        <@ not (Hexidecimal_digits.Contains raw_int)
           || Basic_Latin_Block.Contains raw_int @>

Check.Quick hex_digits_subset_of_basic_latin

// Hex digits definition correctness
let hex_digits_definition (raw_int: int) =
    test
        <@ Hexidecimal_digits.Contains raw_int = (ASCII_digits.Contains raw_int
                                                  || (0x0041 <= raw_int && raw_int <= 0x0046)
                                                  || (0x0061 <= raw_int && raw_int <= 0x0066)) @>

Check.Quick hex_digits_definition

// Code_Point.parse domain equals Codespace
let code_point_parse_domain (raw_int: int) =
    let parse_succeeds =
        try
            Code_Point.parse raw_int |> ignore
            true
        with
        | :? Swensen.Unquote.AssertionFailedException -> false

    test <@ parse_succeeds = Codespace.Contains raw_int @>

Check.Quick code_point_parse_domain

// Unicode_Scalar_Value.parse domain equals scalar set
let unicode_scalar_parse_domain (raw_int: int) =
    let parse_succeeds =
        try
            Unicode_Scalar_Value.parse raw_int |> ignore
            true
        with
        | :? Swensen.Unquote.AssertionFailedException -> false

    test <@ parse_succeeds = Unicode_Scalar_Value_Set.Contains raw_int @>

Check.Quick unicode_scalar_parse_domain

// Hex conversion round-trip
let hex_conversion_round_trip (NonNegativeInt raw_int) =
    let hex_string = raw_int.ToString("X")

    test <@ int_from_hexadecimal_digit_string hex_string = raw_int @>

Check.Quick hex_conversion_round_trip
