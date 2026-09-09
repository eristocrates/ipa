#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true

open System
open System.Threading.Tasks
open System.Numerics

open NeatIntervals

open FRange






type Range<'LimitType when 'LimitType: comparison and 'LimitType :> IComparable<'LimitType>> with
    member this.asInterval =
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



module IntervalRange =
    let inline asRange (interval: Interval<'EndpointType, 'ValueType>) =
        match interval.Type with
        | IntervalType.Closed -> interval.Start +-+ interval.End
        | IntervalType.StartOpen -> interval.Start *-+ interval.End
        | IntervalType.EndOpen -> interval.Start +-* interval.End
        | IntervalType.Open -> interval.Start *-* interval.End
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type

    let inline asIntervalSet (interval: Interval<'EndpointType, 'ValueType>) =
        let intervalSet = new IntervalSet<'EndpointType, 'ValueType>()
        intervalSet.Add(interval) |> ignore
        intervalSet

    let inline values (interval: Interval<'EndpointType, 'ValueType>) =
        match interval.Type with
        | IntervalType.Closed -> [| interval.Start .. interval.End |]
        | IntervalType.StartOpen -> [| interval.Start + LanguagePrimitives.GenericOne .. interval.End |]
        | IntervalType.EndOpen -> [| interval.Start .. interval.End - LanguagePrimitives.GenericOne |]
        | IntervalType.Open ->
            [| interval.Start + LanguagePrimitives.GenericOne .. interval.End - LanguagePrimitives.GenericOne |]
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type


    let inline union
        (leftInterval: Interval<'EndpointType, Range<'EndpointType>>)
        (rightInterval: Interval<'EndpointType, Range<'EndpointType>>)
        =
        Range.union [ leftInterval.Value ] [
            rightInterval.Value
        ]
        |> List.map (fun range -> range.asInterval)

    let inline except
        (intervalsToRemove: Interval<'EndpointType, Range<'EndpointType>> list)
        (intervalToKeep: Interval<'EndpointType, Range<'EndpointType>>)
        =
        let rangesToRemove =
            intervalsToRemove
            |> List.map (fun interval -> interval.Value)

        Range.difference [ intervalToKeep.Value ] rangesToRemove
        |> List.map (fun range -> range.asInterval)

    let inline cardinality (interval: Interval<'EndpointType, Range<'EndpointType>>) =
        let absoluteDifference = (int interval.End) - (int interval.Start) + 1

        match interval.Type with
        | IntervalType.Closed -> absoluteDifference
        | IntervalType.StartOpen -> absoluteDifference - 1
        | IntervalType.EndOpen -> absoluteDifference - 1
        | IntervalType.Open -> absoluteDifference - 2
        | _ -> failwithf "Cannot create Interval from Interval %A with type %A " interval interval.Type

    let inline zeroArray<'ElementType> (interval: Interval<int, Range<int>>) : 'ElementType array =
        Array.zeroCreate (interval |> cardinality)

    let inline contains (target: 'EndpointType) (interval: Interval<'EndpointType, Range<'EndpointType>>) =
        interval.Value |> Range.contains target

module IntervalRanges =
    let inline contain (target: 'EndpointType) (intervals: Interval<'EndpointType, Range<'EndpointType>> array) =
        intervals
        |> Array.exists (fun interval -> interval.Value |> Range.contains target)

    let inline values(intervals: Interval<'EndpointType, Range<'EndpointType>> array) =
        intervals
        |> Array.collect (fun interval -> interval  |> IntervalRange.values)



module IntervalSet =

    let inline fromIntervalList (intervalList: Interval<'EndpointType, 'ValueType> list) =
        let intervalSet = new IntervalSet<'EndpointType, 'ValueType>()

        intervalList
        |> List.map (fun interval -> intervalSet.Add interval)
        |> ignore

        intervalSet.Merge() |> Seq.toArray



module Range =
    let inline upperInclusive (range: Range<'T>) : 'T =
        match range.Upper with
        | Inclusive value -> value
        | Exclusive value -> value - LanguagePrimitives.GenericOne<'T>
        | Unbounded -> failwithf "Range %A as unbounded Upper value" range

    let inline upperExclusive (range: Range<'T>) : 'T =
        match range.Upper with
        | Inclusive value -> value + LanguagePrimitives.GenericOne<'T>
        | Exclusive value -> value
        | Unbounded -> failwithf "Range %A as unbounded Upper value" range

    let inline lowerInclusive (range: Range<'T>) : 'T =
        match range.Lower with
        | Inclusive value -> value
        | Exclusive value -> value + LanguagePrimitives.GenericOne<'T>
        | Unbounded -> failwithf "Range %A as unbounded Lower value" range

    let inline lowerExclusive (range: Range<'T>) : 'T =
        match range.Lower with
        | Inclusive value -> value - LanguagePrimitives.GenericOne<'T>
        | Exclusive value -> value
        | Unbounded -> failwithf "Range %A as unbounded Lower value" range





/// Creates an inclusive-inclusive range.
let inline (+-+) (lower :'Type) (upper: 'Type) =
    new Interval<'Type, Range<'Type>>(lower, upper, Range.create (Inclusive lower) (Inclusive upper), IntervalType.Closed)


/// Creates an exclusive-inclusive range.
let ( *-+ ) (lower :'Type) (upper: 'Type) =
    new Interval<'Type, Range<'Type>>(
        lower,
        upper,
        Range.create (Exclusive lower) (Inclusive upper),
        IntervalType.StartOpen
    )


/// Creates an inclusive-exclusive range.
let (+-*) (lower :'Type) (upper: 'Type) =

    new Interval<'Type, Range<'Type>>(lower, upper, Range.create (Inclusive lower) (Exclusive upper), IntervalType.EndOpen)

/// Creates an exclusive-exclusive range.
let ( *-* ) (lower :'Type) (upper: 'Type) =

    new Interval<'Type, Range<'Type>>(lower, upper, Range.create (Exclusive lower) (Exclusive upper), IntervalType.Open)
