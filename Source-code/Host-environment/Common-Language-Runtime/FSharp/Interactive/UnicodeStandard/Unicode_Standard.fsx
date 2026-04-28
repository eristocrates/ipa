open System
open System.Linq
open System.Text
open System.Text.Unicode
open System.Globalization
open System.Xml.Linq

#r "nuget: Unquote"
open Swensen.Unquote.Assertions
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\SetErgonomics.fsx"
open SetErgonomics

#r "nuget: FSharp.UMX"

open FSharp.UMX

let int_from_hexadecimal_digit_string (hexdig_string: string) = Convert.ToInt32(hexdig_string, 16)


let Codespace = Set_Definition.FromIncludedInterval 0x0000 0x10FFFF


[<Measure>]
type code_point

type Code_Point =
    static member parse(raw_int: int) : int<code_point> =
        test <@ Codespace.Contains raw_int @>
        %raw_int


[<Measure>]
type high_surrogate_code_point

let High_Surrogate_Code_Point_Set =
    Set_Definition.FromIncludedInterval 0xD800 0xDBFF

[<Measure>]
type low_surrogate_code_point

let Low_Surrogate_Code_Point_Set = Set_Definition.FromIncludedInterval 0xDC00 0xDFFF

let Surrogate_Code_Point_Set =
    Set_Definition.FromOverlay [| High_Surrogate_Code_Point_Set
                                  Low_Surrogate_Code_Point_Set |]

let Unicode_Scalar_Value_Set =
    Codespace
    |> Set_Definition.FromExclusion Surrogate_Code_Point_Set



[<Measure>]
type unicode_scalar_value

type Unicode_Scalar_Value =
    static member parse(raw_int: int) : int<unicode_scalar_value> =
        test <@ Unicode_Scalar_Value_Set.Contains raw_int @>
        %raw_int


[<Struct>]
type Unicode_Plane =
    {

      plane_name: string
      abbreviation: string
      as'int: int
      material_set: Set_Definition<int>

     }




[<Struct>]
type Unicode_Block =
    {

      block_name: string
      material_set: Set_Definition<int>

     }


[<Struct>]
type Unicode_Partition =
    {

      partition_name: string
      material_set: Set_Definition<int>

     }



let Basic_Multilingual_Plane = Set_Definition.FromIncludedInterval 0x0000 0xFFFF

let Basic_Latin_Block = Set_Definition.FromIncludedInterval 0x0000 0x007F

let C0_controls = Set_Definition.FromIncludedInterval 0x0000 0x001F



let ASCII_punctuation_and_symbols =

    Set_Definition.FromOverlay [|

                                  Set_Definition.FromIncludedInterval 0x0020 0x002F
                                  Set_Definition.FromIncludedInterval 0x003A 0x0040
                                  Set_Definition.FromIncludedInterval 0x005B 0x0060
                                  Set_Definition.FromIncludedInterval 0x007B 0x007E

                                   |]

let commercial_at = Set_Definition.FromString "@"

let colon = Set_Definition.FromString ":"

let solidus = Set_Definition.FromString "/"

let question_mark = Set_Definition.FromString "?"

let plus_sign = Set_Definition.FromString "+"

let hyphen_minus = Set_Definition.FromString "-"

let full_stop = Set_Definition.FromString "."

let tilde = Set_Definition.FromString "~"

let low_line = Set_Definition.FromString "_"

let ASCII_digits = Set_Definition.FromIncludedInterval 0x0030 0x0039



let one_to_nine = Set_Definition.FromIncludedInterval 0x0031 0x0039
let zero_to_four = Set_Definition.FromIncludedInterval 0x0030 0x0034


let zero_to_five = Set_Definition.FromIncludedInterval 0x0030 0x0035


let Latin_Alphabet_Majuscule = Set_Definition.FromIncludedInterval 0x0041 0x005A


let Latin_Alphabet_Minuscule = Set_Definition.FromIncludedInterval 0x0061 0x007A


let Latin_Alphabet =
    Set_Definition.FromOverlay [|

                                  Latin_Alphabet_Majuscule
                                  Latin_Alphabet_Minuscule

                                   |]


let A_to_F = Set_Definition.FromIncludedInterval 0x0041 0x0046


let a_to_f = Set_Definition.FromIncludedInterval 0x0061 0x0066


let Hexidecimal_digits =
    Set_Definition.FromOverlay [|

                                  A_to_F
                                  a_to_f
                                  ASCII_digits

                                   |]

let control_codes =
    Set_Definition.FromOverlay [|

                                  Set_Definition.FromSingleton 0x007F
                                  C0_controls

                                   |]
