open System
open System.Collections
open System.Numerics
open System.Collections.Immutable
open System.Globalization
open System.IO
open System.Text
open System.Text.Unicode


#r "nuget: Hedgehog"

open Hedgehog
open Hedgehog.FSharp

#r "nuget: NeatIntervals"
open NeatIntervals
#r "nuget: Unquote"
open Swensen.Unquote.Assertions


#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\Unicode_Standard.fsx"
open Unicode_Standard




type Code_Point = private CodePoint of int

type Unicode_Scalar = private UnicodeScalar of Code_Point
type Grapheme_Cluster = private GraphemeCluster of Code_Point array
type Text_Element = private TextElement of string


type Code_Point with

    static member from_int(raw_int: int) =
        test <@ Codespace.Contains raw_int @>
        CodePoint raw_int

    static member op_Explicit(CodePoint code_point) = code_point

    static member from_char(raw_char: char) =
        test <@ not (Char.IsSurrogate raw_char) @>
        Code_Point.from_int (int raw_char)

    static member from_rune(rune: Rune) = Code_Point.from_int rune.Value

    static member from_runes(runes: Rune array) = runes |> Array.map Code_Point.from_rune

    static member from_scalar_value(UnicodeScalar code_point) = code_point
    static member from_grapheme_cluster(GraphemeCluster code_points) = code_points

    member this.as_string =
        let (CodePoint code_point) = this
        (Rune code_point).ToString()


module Int32 =
    let from_hexadecimal_digit_string (hexdig_string: string) = Convert.ToInt32(hexdig_string, 16)



type Unicode_Scalar with
    static member from_int(raw_int: int) =
        test <@ Unicode_Scalar_Value.Contains raw_int @>
        UnicodeScalar(CodePoint raw_int)


type Grapheme_Cluster with

    static member from_text_element(TextElement text_element) =
        let runes = text_element.EnumerateRunes() |> Seq.toArray
        let code_points = runes |> Code_Point.from_runes
        GraphemeCluster code_points


    static member from_text_elements(text_elements: Text_Element array) =
        text_elements
        |> Array.map Grapheme_Cluster.from_text_element


module Code_Point =

    let as_rune (CodePoint code_point) = Rune code_point
    let as_string (CodePoint code_point) = (Rune code_point).ToString()


    let as_hex_literal (CodePoint code_point) = sprintf "%04X" (int code_point)
    let as_Uhex_literal (CodePoint code_point) = sprintf "U+%04X" (int code_point)




type Code_Line =
    | Code_Line of Code_Point array


    static member op_Explicit(Code_Line rdf_string) =
        rdf_string
        |> Array.map Code_Point.as_string
        |> String.concat ""


    member this.as_string =
        let (Code_Line code_point_array) = this

        code_point_array
        |> Array.map (fun code_point -> code_point.as_string)
        |> String.concat ""


module Grapheme_Cluster =

    let as_string (GraphemeCluster grapheme_cluster) =
        grapheme_cluster
        |> Array.map Code_Point.as_string
        |> String.concat ""



module Text_Element =

    let as_string (TextElement text_element) = text_element

    let as_grapheme_cluster (text_element: Text_Element) =
        Grapheme_Cluster.from_text_element text_element






type String with

    member this.TextElements =
        let enumerator = StringInfo.GetTextElementEnumerator(this)

        seq {

            while enumerator.MoveNext() do
                let element = enumerator.GetTextElement()
                yield TextElement element


        }
        |> Seq.toArray

    member this.GraphemeClusters =
        this.TextElements
        |> Array.map Grapheme_Cluster.from_text_element

    member this.Runes = this.EnumerateRunes() |> Seq.toArray

    member this.CodePoints =
        this.GraphemeClusters
        |> Array.collect (fun (GraphemeCluster code_points) -> code_points)

    member this.ScalarValues =
        this.CodePoints
        |> Array.map (fun (CodePoint code_point) -> code_point)


type Int32 with
    member this.as_hexstring = sprintf "%04X" this
    member this.as_Ustring = sprintf "U+%04X" this
    member this.is_in_code_subspace(code_subspace: Code_Subspace) = code_subspace.Contains this
    member this.is_code_point = this.is_in_code_subspace Codespace
    member this.is_unicode_scalar = this.is_in_code_subspace Unicode_Scalar_Value
    member this.as_Code_Point = Code_Point.from_int this
    member this.as_string = ((Rune this).ToString())



type 'T ``[]`` with
    member this.as_string =
        match box this with
        | :? (int array) as int_array ->
            int_array
            |> Array.map (fun int_value -> int_value.as_string)
            |> String.concat ""
        | _ -> String.Empty


fsi.AddPrinter<Code_Point>(fun (CodePoint value) -> sprintf "%s U+%04X" ((Rune value).ToString()) value)

fsi.AddPrinter<Code_Line> (fun code_line ->
    let (Code_Line code_points) = code_line

    let code_points_string =
        code_points
        |> Array.map (fun code_point ->
            let (CodePoint value) = code_point
            sprintf "%s U+%04X" ((Rune value).ToString()) value)

    sprintf "%s \n\n %A" code_line.as_string code_points_string)
