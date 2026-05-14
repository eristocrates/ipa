open System

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Unicode_Standard.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\StringExtensions.fsx"

open StringExtensions
open Unicode_Standard

open SetErgonomics

open Swensen.Unquote.Assertions


#r "nuget: Hedgehog"

open Hedgehog
open Hedgehog.FSharp



let codespace_cardinality =
    PropertyConfig.defaults
    |> PropertyConfig.withTests 0x10FFFF<tests>

let propReverse =
    property {
        let! xs = Gen.list (Range.linear 0 100) Gen.alpha
        return List.rev (List.rev xs) = xs
    }

// Run it
Property.checkBool propReverse

property {
    let! xs = Gen.list (Range.linear 0 100) Gen.alpha
    return List.rev (List.rev xs) = xs
}
|> Property.checkBool

// Buggy function - fails for numbers > 100
let tryAdd a b = if a > 100 then None else Some(a + b)

let propAdd =
    property {
        let! a = Gen.int32 (Range.constantBounded ())
        let! b = Gen.int32 (Range.constantBounded ())
        return test <@ tryAdd a b = Some(a + b) @>
    }

// Property.check propAdd












module Range =
    let FromIncludedRange (included_interval: Included_Interval<int>) =
        Gen.int32 (Range.constant included_interval.first_element included_interval.last_element)

    let FromSetDefinition (set_definition: Set_Definition<int>) =
        let ranges =
            set_definition.included_intervals
            |> Array.map FromIncludedRange

        Gen.choice ranges

let Gen_Codespace = Range.FromSetDefinition Codespace

let Gen_Unicode_Scalar_Value =
    Gen.choice [| Gen.int32 (Range.constant 0xD800 0xDBFF)
                  Gen.int32 (Range.constant 0xDC00 0xDFFF) |]

let Gen_Surrogate_Code_Point = Range.FromSetDefinition Surrogate_Code_Point_Set





let code_point_from_codespace_int_preserves_hex_projection =
    property {
        let! raw_int = Gen_Codespace

        let code_point = Code_Point.op_Explicit raw_int

        test <@ Code_Point.as_hex_literal code_point = sprintf "%04X" raw_int @>
    }

Property.report code_point_from_codespace_int_preserves_hex_projection


let code_point_constructor_accepts_generated_codespace_values =
    property {
        let! raw_int = Gen_Codespace

        let succeeds =
            try
                Code_Point.op_Explicit raw_int |> ignore
                true
            with
            | :? Swensen.Unquote.AssertionFailedException -> false

        test <@ succeeds @>
    }

Property.report code_point_constructor_accepts_generated_codespace_values



let unicode_scalar_value_constructor_accepts_generated_scalar_values =
    property {
        let! raw_int = Gen_Unicode_Scalar_Value

        let succeeds =
            try
                Unicode_Scalar_Value.op_Explicit raw_int |> ignore
                true
            with
            | :? Swensen.Unquote.AssertionFailedException -> false

        test <@ succeeds @>
    }

Property.check unicode_scalar_value_constructor_accepts_generated_scalar_values



let code_point_round_trips_through_rune =
    property {
        let! raw_int = Gen_Unicode_Scalar_Value

        let code_point = Code_Point.op_Explicit raw_int

        let rune = Code_Point.as_rune code_point

        let reconstructed = Code_Point.op_Explicit rune

        test <@ reconstructed = code_point @>
    }

Property.check code_point_round_trips_through_rune



let unicode_scalar_value_constructor_rejects_generated_surrogates =
    property {
        let! raw_int = Gen_Surrogate_Code_Point

        raises<Swensen.Unquote.AssertionFailedException> <@ Unicode_Scalar_Value.op_Explicit raw_int |> ignore @>
    }

Property.check unicode_scalar_value_constructor_rejects_generated_surrogates































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


(*

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
*)
