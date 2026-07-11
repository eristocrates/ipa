module DoxAletheia.ByteExtensions

open System
open ConversionErgonomics
open FSharp.Units.DataStorage


type Byte with
    static member from_bool(predicate_is_true: bool) = bool_to_byte predicate_is_true
    member this.to_bool = byte_to_bool this

[<Measure>]
type MiB =
    static member create(value: float) =
        LanguagePrimitives.FloatWithMeasure<MiB> value

    /// Converts Mebibytes to Mebibits.
    static member toMebibits(value: float<MiB>) : float<mebibit> = mebibit.create (float value * 8.0)

    /// Converts Mebibits to Mebibytes.
    static member fromMebibits(value: float<mebibit>) : float<MiB> = MiB.create (float value / 8.0)

    /// Converts Mebibytes to Bits by passing through FSharp.Units mebibit.
    static member toBits(value: float<MiB>) : float<b> =
        value |> MiB.toMebibits |> mebibit.toBits

    /// Converts Bits to Mebibytes by passing through FSharp.Units mebibit.
    static member fromBits(value: float<b>) : float<MiB> =
        value |> b.toMebibits |> MiB.fromMebibits
