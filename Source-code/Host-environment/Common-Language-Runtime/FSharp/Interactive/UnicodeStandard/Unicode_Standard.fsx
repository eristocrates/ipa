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

    member this.parser_combinator: Parser<int array, int, unit, ReadableArray<int>> =
        let (CodeSubspace code_subspace) = this

        code_subspace
        |> Seq.map (fun interval -> anyInRange interval.Start interval.End)
        |> choice
        |>> fun result -> [| result |]





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

let ucd_whitespace =
    Code_Subspace.from_union [|

                                Code_Subspace.from_int 0x0009
                                Code_Subspace.from_int 0x000A
                                Code_Subspace.from_int 0x000B
                                Code_Subspace.from_int 0x000C
                                Code_Subspace.from_int 0x000D
                                Code_Subspace.from_int 0x0020
                                Code_Subspace.from_int 0x0085
                                Code_Subspace.from_int 0x00A0
                                Code_Subspace.from_int 0x1680
                                Code_Subspace.from_int 0x2000
                                Code_Subspace.from_int 0x2001
                                Code_Subspace.from_int 0x2002
                                Code_Subspace.from_int 0x2003
                                Code_Subspace.from_int 0x2004
                                Code_Subspace.from_int 0x2005
                                Code_Subspace.from_int 0x2006
                                Code_Subspace.from_int 0x2007
                                Code_Subspace.from_int 0x2008
                                Code_Subspace.from_int 0x2009
                                Code_Subspace.from_int 0x200A
                                Code_Subspace.from_int 0x2028
                                Code_Subspace.from_int 0x2029
                                Code_Subspace.from_int 0x202F
                                Code_Subspace.from_int 0x205F
                                Code_Subspace.from_int 0x3000

                                 |]

let commercial_at = Code_Subspace.from_string "@"
let left_square_bracket = Code_Subspace.from_string "["
let right_square_bracket = Code_Subspace.from_string "]"
let number_sign = Code_Subspace.from_string "#"
let question_mark = Code_Subspace.from_string "?"

let colon = Code_Subspace.from_string ":"


let solidus = Code_Subspace.from_string "/"


let plus_sign = Code_Subspace.from_string "+"

let hyphen_minus = Code_Subspace.from_string "-"

let full_stop = Code_Subspace.from_string "."

let tilde = Code_Subspace.from_string "~"

let low_line = Code_Subspace.from_string "_"
let percent = Code_Subspace.from_string "%"

let ASCII_digits = Code_Subspace.from_limits 0x0030 0x0039



let one = Code_Subspace.from_string "1"
let two = Code_Subspace.from_string "2"
let five = Code_Subspace.from_string "5"
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

let vV = Code_Subspace.from_string "vV"

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
