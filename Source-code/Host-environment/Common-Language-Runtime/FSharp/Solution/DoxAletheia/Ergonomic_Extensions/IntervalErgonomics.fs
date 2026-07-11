module DoxAletheia.IntervalErgonomics

open System
open System.Threading.Tasks
open System.Numerics

// #r "nuget: NeatIntervals"
open NeatIntervals

// #r "nuget: FRange"
open FRange






type Range<'LimitType when 'LimitType: comparison and 'LimitType :> IComparable<'LimitType>> with
    member this.as_interval =
        match this.Lower, this.Upper with
        | Inclusive lower, Inclusive higher ->
            new Interval<'LimitType, Range<'LimitType>>(lower, higher, this, IntervalType.Closed)
        | Inclusive lower, Exclusive higher ->
            new Interval<'LimitType, Range<'LimitType>>(lower, higher, this, IntervalType.EndOpen)
        | Exclusive lower, Inclusive higher ->
            new Interval<'LimitType, Range<'LimitType>>(lower, higher, this, IntervalType.StartOpen)
        | Exclusive lower, Exclusive higher ->
            new Interval<'LimitType, Range<'LimitType>>(lower, higher, this, IntervalType.Open)
        | _ -> failwithf "Cannot create Interval from unbounded Range %A " this



module Ranges =
    let contain (target: 'T) (ranges: list<Range<'T>>) =
        ranges
        |> List.exists (fun range -> range |> Range.contains target)



module Interval_Range =
    let inline as_range (interval: Interval<'EndpointType, 'ValueType>) =
        match interval.Type with
        | IntervalType.Closed -> interval.Start +-+ interval.End
        | IntervalType.StartOpen -> interval.Start *-+ interval.End
        | IntervalType.EndOpen -> interval.Start +-* interval.End
        | IntervalType.Open -> interval.Start *-* interval.End
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type

    let inline as_interval_set (interval: Interval<'EndpointType, 'ValueType>) =
        let interval_set = new IntervalSet<'EndpointType, 'ValueType>()
        interval_set.Add(interval) |> ignore
        interval_set

    let inline values (interval: Interval<'EndpointType, 'ValueType>) =
        match interval.Type with
        | IntervalType.Closed -> [| interval.Start .. interval.End |]
        | IntervalType.StartOpen -> [| interval.Start - LanguagePrimitives.GenericOne .. interval.End |]
        | IntervalType.EndOpen -> [| interval.Start .. interval.End - LanguagePrimitives.GenericOne |]
        | IntervalType.Open ->
            [| interval.Start - LanguagePrimitives.GenericOne .. interval.End - LanguagePrimitives.GenericOne |]
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type


    let inline union
        (left_interval: Interval<'EndpointType, Range<'EndpointType>>)
        (right_interval: Interval<'EndpointType, Range<'EndpointType>>)
        =
        Range.union [ left_interval.Value ] [
            right_interval.Value
        ]
        |> List.map (fun range -> range.as_interval)

    let inline except
        (intervals_to_remove: Interval<'EndpointType, Range<'EndpointType>> list)
        (interval_to_keep: Interval<'EndpointType, Range<'EndpointType>>)
        =
        let ranges_to_remove =
            intervals_to_remove
            |> List.map (fun interval -> interval.Value)

        Range.difference [ interval_to_keep.Value ] ranges_to_remove
        |> List.map (fun range -> range.as_interval)

    let inline cardinality (interval: Interval<'EndpointType, Range<'EndpointType>>) =
        let absolute_difference = (int interval.End) - (int interval.Start)

        match interval.Type with
        | IntervalType.Closed -> absolute_difference
        | IntervalType.StartOpen -> absolute_difference - 1
        | IntervalType.EndOpen -> absolute_difference - 1
        | IntervalType.Open -> absolute_difference - 2
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type

    let inline zero_array<'ElementType> (interval: Interval<int, Range<int>>) : 'ElementType array =
        Array.zeroCreate (interval |> cardinality)

    let inline contains (target: 'EndpointType) (interval: Interval<'EndpointType, Range<'EndpointType>>) =
        interval.Value |> Range.contains target

module Interval_Ranges =
    let inline contain (target: 'EndpointType) (intervals: Interval<'EndpointType, Range<'EndpointType>> array) =
        intervals
        |> Array.exists (fun interval -> interval.Value |> Range.contains target)

    let inline values(intervals: Interval<'EndpointType, Range<'EndpointType>> array) =
        intervals
        |> Array.collect (fun interval -> interval  |> Interval_Range.values)



module IntervalSet =

    let inline from_interval_list (interval_list: Interval<'EndpointType, 'ValueType> list) =
        let interval_set = new IntervalSet<'EndpointType, 'ValueType>()

        interval_list
        |> List.map (fun interval -> interval_set.Add interval)
        |> ignore

        interval_set.Merge() |> Seq.toArray



module Range =
    let inline upper_inclusive (range: Range<'T>) : 'T =
        match range.Upper with
        | Inclusive value -> value
        | Exclusive value -> value - LanguagePrimitives.GenericOne<'T>
        | Unbounded -> failwithf "Range %A as unbounded Upper value" range

    let inline upper_exclusive (range: Range<'T>) : 'T =
        match range.Upper with
        | Inclusive value -> value + LanguagePrimitives.GenericOne<'T>
        | Exclusive value -> value
        | Unbounded -> failwithf "Range %A as unbounded Upper value" range

    let inline lower_inclusive (range: Range<'T>) : 'T =
        match range.Lower with
        | Inclusive value -> value
        | Exclusive value -> value + LanguagePrimitives.GenericOne<'T>
        | Unbounded -> failwithf "Range %A as unbounded Lower value" range

    let inline lower_exclusive (range: Range<'T>) : 'T =
        match range.Lower with
        | Inclusive value -> value - LanguagePrimitives.GenericOne<'T>
        | Exclusive value -> value
        | Unbounded -> failwithf "Range %A as unbounded Lower value" range





/// Creates an inclusive-inclusive range.
let (+-+) lower upper =
    new Interval<int, Range<int>>(lower, upper, Range.create (Inclusive lower) (Inclusive upper), IntervalType.Closed)


/// Creates an exclusive-inclusive range.
let ( *-+ ) lower upper =
    new Interval<int, Range<int>>(
        lower,
        upper,
        Range.create (Exclusive lower) (Inclusive upper),
        IntervalType.StartOpen
    )


/// Creates an inclusive-inclusive range.
let (+-*) lower upper =

    new Interval<int, Range<int>>(lower, upper, Range.create (Inclusive lower) (Exclusive upper), IntervalType.EndOpen)

/// Creates an exclusive-exclusive range.
let ( *-* ) lower upper =

    new Interval<int, Range<int>>(lower, upper, Range.create (Exclusive lower) (Exclusive upper), IntervalType.Closed)
