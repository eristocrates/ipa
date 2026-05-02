open System
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




let RNG =
    let rng = System.Random()
    fun min max -> rng.Next(min, max + 1)






type Interval_Range = private IntervalRange of Interval<int, string>

type Interval_Range with
    static member from_limits (interval_start: int) (interval_end: int) =

        IntervalRange(Interval<int, string>(interval_start, interval_end, ""))

    static member from_labelled_limits (label: string) (interval_start: int) (interval_end: int) =

        IntervalRange(Interval<int, string>(interval_start, interval_end, label))

    static member from_int(value: int) = Interval_Range.from_limits value value

type Code_Subspace = private CodeSubspace of IntervalSet<int, string>

module Code_Subspace =
    let map piped_function (CodeSubspace code_subspace) = code_subspace |> Seq.map piped_function


    let head_interval (CodeSubspace code_subspace) = code_subspace |> Seq.head

    let subtract_interval
        (source: Interval<int, string>)
        (excluded: Interval<int, string>)
        : seq<Interval<int, string>> =

        seq {
            if excluded.End < source.Start
               || source.End < excluded.Start then
                yield source
            else
                if source.Start < excluded.Start then
                    yield Interval<int, string>(source.Start, excluded.Start - 1, source.Value)

                if excluded.End < source.End then
                    yield Interval<int, string>(excluded.End + 1, source.End, source.Value)
        }




// TODO change the string generator to a sequence
// deal with string checking ensureing all codepoints are present
type Code_Subspace with
    static member from_interval_range(IntervalRange interval_range) =
        let interval_set = IntervalSet<int, string>()
        interval_set.Add(interval_range) |> ignore
        CodeSubspace interval_set

    static member from_limits (interval_start: int) (interval_end: int) =
        let interval_range = Interval_Range.from_limits interval_start interval_end

        Code_Subspace.from_interval_range interval_range

    static member from_string(value: string) =
        let interval_set = IntervalSet<int, string>()

        let intervals =
            value.EnumerateRunes()
            |> Seq.map (fun rune -> Interval_Range.from_int rune.Value)

        intervals
        |> Seq.iter (fun (IntervalRange singleton) -> interval_set.Add(singleton) |> ignore)

        CodeSubspace interval_set

    static member from_int(value: int) =
        Code_Subspace.from_interval_range (Interval_Range.from_limits value value)





    member this.HasIntersection(CodeSubspace interval_set) =
        let (CodeSubspace subspace) = this
        subspace.HasIntersection interval_set

    member this.Union(CodeSubspace interval_set) =
        let (CodeSubspace subspace) = this
        CodeSubspace(subspace.Union interval_set)

    static member from_union(code_subspaces: Code_Subspace seq) =
        let interval_set = IntervalSet<int, string>()

        let unioned_interval_set =
            code_subspaces
            |> Seq.fold
                (fun (accumulated_interval_set: IntervalSet<int, string>) (CodeSubspace next_interval_set) ->
                    accumulated_interval_set.Union next_interval_set)
                interval_set

        CodeSubspace unioned_interval_set

    member this.Contains(value: int) =
        let (CodeSubspace subspace) = this
        let (IntervalRange interval) = Interval_Range.from_int value

        subspace.HasIntersection [ interval ]

    member this.Contains(value: string) =
        let (CodeSubspace subspace) = this

        let (CodeSubspace string_space) = Code_Subspace.from_string value

        subspace.IsSupersetOf string_space

    member this.Except(CodeSubspace excluded_interval_set) =
        let (CodeSubspace source_interval_set) = this

        let remaining_intervals =
            excluded_interval_set
            |> Seq.fold
                (fun current_intervals excluded_interval ->
                    current_intervals
                    |> Seq.collect (fun source_interval ->
                        Code_Subspace.subtract_interval source_interval excluded_interval)
                    |> Seq.toList)
                (source_interval_set |> Seq.toList)

        let result_interval_set = IntervalSet<int, string>()

        remaining_intervals
        |> Seq.iter (fun interval -> result_interval_set.Add interval |> ignore)

        CodeSubspace result_interval_set

    member this.test_generator =
        let (CodeSubspace code_subspace) = this

        code_subspace
        |> Seq.map (fun interval -> Gen.int32 (Range.constant interval.Start interval.End))
        |> Gen.choice

    member this.random_generator() =
        let (CodeSubspace code_subspace) = this

        code_subspace
        |> Seq.map (fun interval -> RNG interval.Start interval.End)
        |> Seq.randomChoice

    member this.parser_combinator: Parser<int, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        let (CodeSubspace code_subspace) = this

        code_subspace
        |> Seq.map (fun interval -> anyInRange interval.Start interval.End)
        |> choice





let Codespace = Code_Subspace.from_limits 0x0000 0x10FFFF



let High_Surrogate = Code_Subspace.from_limits 0xD800 0xDBFF
let Low_Surrogate = Code_Subspace.from_limits 0xDC00 0xDFFF

let Surrogate = High_Surrogate.Union Low_Surrogate


let Unicode_Scalar_Value = Codespace.Except Surrogate




let Basic_Multilingual_Plane = Code_Subspace.from_limits 0x0000 0xFFFF

let Basic_Latin_Block = Code_Subspace.from_limits 0x0000 0x007F

let C0_controls = Code_Subspace.from_limits 0x0000 0x001F



let ASCII_punctuation_and_symbols =

    Code_Subspace.from_union [|

                                Code_Subspace.from_limits 0x0020 0x002F
                                Code_Subspace.from_limits 0x003A 0x0040
                                Code_Subspace.from_limits 0x005B 0x0060
                                Code_Subspace.from_limits 0x007B 0x007E

                                 |]

let commercial_at = Code_Subspace.from_string "@"

let colon = Code_Subspace.from_string ":"

let solidus = Code_Subspace.from_string "/"

let question_mark = Code_Subspace.from_string "?"

let plus_sign = Code_Subspace.from_string "+"

let hyphen_minus = Code_Subspace.from_string "-"

let full_stop = Code_Subspace.from_string "."

let tilde = Code_Subspace.from_string "~"

let low_line = Code_Subspace.from_string "_"

let ASCII_digits = Code_Subspace.from_limits 0x0030 0x0039



let one_to_nine = Code_Subspace.from_limits 0x0031 0x0039
let zero_to_four = Code_Subspace.from_limits 0x0030 0x0034


let zero_to_five = Code_Subspace.from_limits 0x0030 0x0035


let Latin_Alphabet_Majuscule = Code_Subspace.from_limits 0x0041 0x005A


let Latin_Alphabet_Minuscule = Code_Subspace.from_limits 0x0061 0x007A


let Latin_Alphabet =
    Code_Subspace.from_union [|

                                Latin_Alphabet_Majuscule
                                Latin_Alphabet_Minuscule

                                 |]


let A_to_F = Code_Subspace.from_limits 0x0041 0x0046


let a_to_f = Code_Subspace.from_limits 0x0061 0x0066



let Hexadecimal_digits =
    Code_Subspace.from_union [|

                                A_to_F
                                a_to_f
                                ASCII_digits

                                 |]

let control_codes =
    Code_Subspace.from_union [|

                                Code_Subspace.from_int 0x007F
                                C0_controls

                                 |]









type Int32 with
    member this.as_hexstring = sprintf "%04X" this
    member this.as_Ustring = sprintf "U+%04X" this
    member this.is_in_code_subspace(code_subspace: Code_Subspace) = code_subspace.Contains this
    member this.is_code_point = this.is_in_code_subspace Codespace
    member this.is_unicode_scalar = this.is_in_code_subspace Unicode_Scalar_Value

module Int32 =
    let from_hexadecimal_digit_string (hexdig_string: string) = Convert.ToInt32(hexdig_string, 16)


type Code_Point = private CodePoint of int
type Code_Line = private CodeLine of Code_Point array


type Unicode_Scalar = private UnicodeScalar of Code_Point
type Grapheme_Cluster = private GraphemeCluster of Code_Point array
type Text_Element = private TextElement of string

type Code_Point with

    static member from_int(raw_int: int) =
        test <@ raw_int.is_code_point @>
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




type Unicode_Scalar with
    static member from_int(raw_int: int) =
        test <@ raw_int.is_unicode_scalar @>
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


type Code_Line with

    static member op_Explicit(CodeLine code_line) =
        code_line
        |> Array.map Code_Point.as_string
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
        |> Array.map (fun (GraphemeCluster code_points) -> code_points)




fsi.AddPrinter<Code_Point>(fun (CodePoint code_point) -> sprintf "%s U+%04X" ((Rune code_point).ToString()) code_point)
