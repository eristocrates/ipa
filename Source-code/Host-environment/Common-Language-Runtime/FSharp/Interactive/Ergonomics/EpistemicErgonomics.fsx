open System
open Microsoft.FSharp.Core.Operators
open System.Text
open System.Diagnostics
open System.Collections.Generic
//-------------------------------------------------------------------------
// Posteriori
//-------------------------------------------------------------------------

open System
open System.Diagnostics

[<RequireQualifiedAccess>]
[<StructuralEquality; StructuralComparison>]
[<DebuggerDisplay("{DebugDisplay,nq}")>]
type Posteriori<'Value> =
    | Known of option<'Value>
    | Unknown of unit

(*
    [<DebuggerBrowsable(DebuggerBrowsableState.Never)>]
    member this.IsKnown =
        match this with
        | Posteriori.Known _ -> true
        | Posteriori.Unknown () -> false

    [<DebuggerBrowsable(DebuggerBrowsableState.Never)>]
    member this.IsUnknown =
        match this with
        | Posteriori.Unknown () -> true
        | Posteriori.Known _ -> false

*)
    [<DebuggerBrowsable(DebuggerBrowsableState.Never)>]
    member this.IsKnownSome =
        match this with
        | Posteriori.Known (Some _) -> true
        | _ -> false

    [<DebuggerBrowsable(DebuggerBrowsableState.Never)>]
    member this.IsKnownNone =
        match this with
        | Posteriori.Known None -> true
        | _ -> false

    /// Returns the inner option only when the posteriori state is known.
    /// Raises when the state is Unknown.
    member this.Option =
        match this with
        | Posteriori.Known option_value -> option_value
        | Posteriori.Unknown () ->
            raise (InvalidOperationException("Posteriori.Option: value-status is unknown."))

    /// Returns the contained value only for Known(Some value).
    /// Raises for Known None and Unknown.
    member this.Value =
        match this with
        | Posteriori.Known (Some value) -> value
        | Posteriori.Known None ->
            raise (InvalidOperationException("Posteriori.Value: value is known to be absent."))
        | Posteriori.Unknown () ->
            raise (InvalidOperationException("Posteriori.Value: value-status is unknown."))

    static member KnownSome(value: 'Value) : Posteriori<'Value> =
        Posteriori.Known (Some value)

    static member KnownNone : Posteriori<'Value> =
        Posteriori.Known None

    static member KnownUnknown : Posteriori<'Value> =
        Posteriori.Unknown ()

    member private this.DebugDisplay =
        match this with
        | Posteriori.Known (Some value) -> $"Known(Some {value})"
        | Posteriori.Known None -> "Known(None)"
        | Posteriori.Unknown () -> "Unknown"

    override this.ToString() =
        match this with
        | Posteriori.Known (Some value) -> $"Known(Some {value})"
        | Posteriori.Known None -> "Known(None)"
        | Posteriori.Unknown () -> "Unknown"

and 'Value posteriori = Posteriori<'Value>


[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Posteriori =

    let KnownSome (value: 'Value) : Posteriori<'Value> =
        Posteriori.Known (Some value)

    let KnownNone<'Value> : Posteriori<'Value> =
        Posteriori.Known None

    let KnownUnknown<'Value> : Posteriori<'Value> =
        Posteriori.Unknown ()

    let ofOption (option_value: option<'Value>) : Posteriori<'Value> =
        Posteriori.Known option_value

    let ofValue (value: 'Value) : Posteriori<'Value> =
        KnownSome value

    /// Lossy: Unknown becomes None.
    let toOptionLossy (posteriori: Posteriori<'Value>) : option<'Value> =
        match posteriori with
        | Posteriori.Known option_value -> option_value
        | Posteriori.Unknown () -> None

    /// Non-lossy: returns Some option only when known.
    let toKnownOption (posteriori: Posteriori<'Value>) : option<option<'Value>> =
        match posteriori with
        | Posteriori.Known option_value -> Some option_value
        | Posteriori.Unknown () -> None

    let get (posteriori: Posteriori<'Value>) : 'Value =
        posteriori.Value

    let getOption (posteriori: Posteriori<'Value>) : option<'Value> =
        posteriori.Option

    let isKnown (posteriori: Posteriori<'Value>) : bool = posteriori.IsKnown

    let isUnknown (posteriori: Posteriori<'Value>) : bool =
        posteriori.IsUnknown

    let isKnownSome (posteriori: Posteriori<'Value>) : bool =
        posteriori.IsKnownSome

    let isKnownNone (posteriori: Posteriori<'Value>) : bool =
        posteriori.IsKnownNone

    let defaultValue (value: 'Value) (posteriori: Posteriori<'Value>) : 'Value =
        match posteriori with
        | Posteriori.Known (Some actual_value) -> actual_value
        | Posteriori.Known None -> value
        | Posteriori.Unknown () -> value

    let defaultWith (defThunk: unit -> 'Value) (posteriori: Posteriori<'Value>) : 'Value =
        match posteriori with
        | Posteriori.Known (Some actual_value) -> actual_value
        | Posteriori.Known None -> defThunk ()
        | Posteriori.Unknown () -> defThunk ()

    let orElse (if_not_known_some: Posteriori<'Value>) (posteriori: Posteriori<'Value>) : Posteriori<'Value> =
        match posteriori with
        | Posteriori.Known (Some _) -> posteriori
        | Posteriori.Known None -> if_not_known_some
        | Posteriori.Unknown () -> if_not_known_some

    let orElseWith (if_not_known_some_thunk: unit -> Posteriori<'Value>) (posteriori: Posteriori<'Value>) : Posteriori<'Value> =
        match posteriori with
        | Posteriori.Known (Some _) -> posteriori
        | Posteriori.Known None -> if_not_known_some_thunk ()
        | Posteriori.Unknown () -> if_not_known_some_thunk ()

    /// Epistemically preserving count.
    let count (posteriori: Posteriori<'Value>) : Posteriori<int> =
        match posteriori with
        | Posteriori.Known (Some _) -> KnownSome 1
        | Posteriori.Known None -> KnownSome 0
        | Posteriori.Unknown () -> KnownUnknown

    /// Lossy Option-like count.
    let countLossy (posteriori: Posteriori<'Value>) : int =
        match posteriori with
        | Posteriori.Known (Some _) -> 1
        | Posteriori.Known None -> 0
        | Posteriori.Unknown () -> 0

    let fold
        (folder: 'State -> 'Value -> 'State)
        (state: 'State)
        (posteriori: Posteriori<'Value>)
        : Posteriori<'State> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome (folder state value)
        | Posteriori.Known None -> KnownSome state
        | Posteriori.Unknown () -> KnownUnknown

    let foldLossy
        (folder: 'State -> 'Value -> 'State)
        (state: 'State)
        (posteriori: Posteriori<'Value>)
        : 'State =

        match posteriori with
        | Posteriori.Known (Some value) -> folder state value
        | Posteriori.Known None -> state
        | Posteriori.Unknown () -> state

    let foldBack
        (folder: 'Value -> 'State -> 'State)
        (posteriori: Posteriori<'Value>)
        (state: 'State)
        : Posteriori<'State> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome (folder value state)
        | Posteriori.Known None -> KnownSome state
        | Posteriori.Unknown () -> KnownUnknown

    let foldBackLossy
        (folder: 'Value -> 'State -> 'State)
        (posteriori: Posteriori<'Value>)
        (state: 'State)
        : 'State =

        match posteriori with
        | Posteriori.Known (Some value) -> folder value state
        | Posteriori.Known None -> state
        | Posteriori.Unknown () -> state

    /// Epistemically preserving exists.
    let exists
        (predicate: 'Value -> bool)
        (posteriori: Posteriori<'Value>)
        : Posteriori<bool> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome (predicate value)
        | Posteriori.Known None -> KnownSome false
        | Posteriori.Unknown () -> KnownUnknown

    let existsLossy
        (predicate: 'Value -> bool)
        (posteriori: Posteriori<'Value>)
        : bool =

        match posteriori with
        | Posteriori.Known (Some value) -> predicate value
        | Posteriori.Known None -> false
        | Posteriori.Unknown () -> false

    /// Epistemically preserving forall.
    let forall
        (predicate: 'Value -> bool)
        (posteriori: Posteriori<'Value>)
        : Posteriori<bool> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome (predicate value)
        | Posteriori.Known None -> KnownSome true
        | Posteriori.Unknown () -> KnownUnknown

    let forallLossy
        (predicate: 'Value -> bool)
        (posteriori: Posteriori<'Value>)
        : bool =

        match posteriori with
        | Posteriori.Known (Some value) -> predicate value
        | Posteriori.Known None -> true
        | Posteriori.Unknown () -> true

    let contains
        (value: 'Value)
        (posteriori: Posteriori<'Value>)
        : Posteriori<bool>
        when 'Value: equality =

        match posteriori with
        | Posteriori.Known (Some actual_value) -> KnownSome (actual_value = value)
        | Posteriori.Known None -> KnownSome false
        | Posteriori.Unknown () -> KnownUnknown

    let containsLossy
        (value: 'Value)
        (posteriori: Posteriori<'Value>)
        : bool
        when 'Value: equality =

        match posteriori with
        | Posteriori.Known (Some actual_value) -> actual_value = value
        | Posteriori.Known None -> false
        | Posteriori.Unknown () -> false

    let iter
        (action: 'Value -> unit)
        (posteriori: Posteriori<'Value>)
        : unit =

        match posteriori with
        | Posteriori.Known (Some value) -> action value
        | Posteriori.Known None -> ()
        | Posteriori.Unknown () -> ()

    let map
        (mapping: 'Input -> 'Output)
        (posteriori: Posteriori<'Input>)
        : Posteriori<'Output> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome (mapping value)
        | Posteriori.Known None -> KnownNone
        | Posteriori.Unknown () -> KnownUnknown

    let mapOption
        (mapping: option<'Input> -> option<'Output>)
        (posteriori: Posteriori<'Input>)
        : Posteriori<'Output> =

        match posteriori with
        | Posteriori.Known option_value -> Posteriori.Known (mapping option_value)
        | Posteriori.Unknown () -> KnownUnknown

    let map2
        (mapping: 'Input1 -> 'Input2 -> 'Output)
        (posteriori1: Posteriori<'Input1>)
        (posteriori2: Posteriori<'Input2>)
        : Posteriori<'Output> =

        match posteriori1, posteriori2 with
        | Posteriori.Known (Some value1), Posteriori.Known (Some value2) ->
            KnownSome (mapping value1 value2)

        | Posteriori.Unknown (), _
        | _, Posteriori.Unknown () ->
            KnownUnknown

        | Posteriori.Known None, _
        | _, Posteriori.Known None ->
            KnownNone

    let map3
        (mapping: 'Input1 -> 'Input2 -> 'Input3 -> 'Output)
        (posteriori1: Posteriori<'Input1>)
        (posteriori2: Posteriori<'Input2>)
        (posteriori3: Posteriori<'Input3>)
        : Posteriori<'Output> =

        match posteriori1, posteriori2, posteriori3 with
        | Posteriori.Known (Some value1), Posteriori.Known (Some value2), Posteriori.Known (Some value3) ->
            KnownSome (mapping value1 value2 value3)

        | Posteriori.Unknown (), _, _
        | _, Posteriori.Unknown (), _
        | _, _, Posteriori.Unknown () ->
            KnownUnknown

        | Posteriori.Known None, _, _
        | _, Posteriori.Known None, _
        | _, _, Posteriori.Known None ->
            KnownNone

    let bind
        (binder: 'Input -> Posteriori<'Output>)
        (posteriori: Posteriori<'Input>)
        : Posteriori<'Output> =

        match posteriori with
        | Posteriori.Known (Some value) -> binder value
        | Posteriori.Known None -> KnownNone
        | Posteriori.Unknown () -> KnownUnknown

    let bindOption
        (binder: option<'Input> -> Posteriori<'Output>)
        (posteriori: Posteriori<'Input>)
        : Posteriori<'Output> =

        match posteriori with
        | Posteriori.Known option_value -> binder option_value
        | Posteriori.Unknown () -> KnownUnknown

    let flatten
        (posteriori: Posteriori<Posteriori<'Value>>)
        : Posteriori<'Value> =

        match posteriori with
        | Posteriori.Known (Some inner) -> inner
        | Posteriori.Known None -> KnownNone
        | Posteriori.Unknown () -> KnownUnknown

    /// Keeps a known value when the predicate succeeds.
    /// If the known value fails, the result is known absent.
    /// Unknown remains unknown.
    let filter
        (predicate: 'Value -> bool)
        (posteriori: Posteriori<'Value>)
        : Posteriori<'Value> =

        match posteriori with
        | Posteriori.Known (Some value) ->
            if predicate value then
                KnownSome value
            else
                KnownNone

        | Posteriori.Known None ->
            KnownNone

        | Posteriori.Unknown () ->
            KnownUnknown

    let toArray
        (posteriori: Posteriori<'Value>)
        : Posteriori<'Value array> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome [| value |]
        | Posteriori.Known None -> KnownSome [||]
        | Posteriori.Unknown () -> KnownUnknown

    let toArrayLossy
        (posteriori: Posteriori<'Value>)
        : 'Value array =

        match posteriori with
        | Posteriori.Known (Some value) -> [| value |]
        | Posteriori.Known None -> [||]
        | Posteriori.Unknown () -> [||]

    let toList
        (posteriori: Posteriori<'Value>)
        : Posteriori<'Value list> =

        match posteriori with
        | Posteriori.Known (Some value) -> KnownSome [ value ]
        | Posteriori.Known None -> KnownSome []
        | Posteriori.Unknown () -> KnownUnknown

    let toListLossy
        (posteriori: Posteriori<'Value>)
        : 'Value list =

        match posteriori with
        | Posteriori.Known (Some value) -> [ value ]
        | Posteriori.Known None -> []
        | Posteriori.Unknown () -> []

    let toNullable
        (posteriori: Posteriori<'Value>)
        : Nullable<'Value>
        when 'Value: struct =

        match posteriori with
        | Posteriori.Known (Some value) -> Nullable value
        | Posteriori.Known None -> Nullable()
        | Posteriori.Unknown () -> Nullable()

    let ofNullable
        (nullable_value: Nullable<'Value>)
        : Posteriori<'Value>
        when 'Value: struct =

        if nullable_value.HasValue then
            KnownSome nullable_value.Value
        else
            KnownNone

    let ofObj
        (value: 'Value | null)
        : Posteriori<'Value>
        when 'Value: not struct and 'Value: not null =

        match value with
        | null -> KnownNone
        | _ -> KnownSome value

    let toObj
        (posteriori: Posteriori<'Value>)
        : 'Value | null
        when 'Value: not struct =

        match posteriori with
        | Posteriori.Known (Some value) -> value
        | Posteriori.Known None -> null
        | Posteriori.Unknown () -> null

    /// Explicitly collapse Unknown into a caller-provided known optional value.
    let defaultOption
        (option_value: option<'Value>)
        (posteriori: Posteriori<'Value>)
        : option<'Value> =

        match posteriori with
        | Posteriori.Known actual_option -> actual_option
        | Posteriori.Unknown () -> option_value

    /// Explicitly collapse Unknown into a caller-provided Posteriori value.
    let defaultPosteriori
        (replacement: Posteriori<'Value>)
        (posteriori: Posteriori<'Value>)
        : Posteriori<'Value> =

        match posteriori with
        | Posteriori.Known _ -> posteriori
        | Posteriori.Unknown () -> replacement
































let trivial_test (test_string: string) : Posteriori<bool> =
    match test_string with
    | "true" -> Posteriori.KnownSome true
    | "false" -> Posteriori.KnownSome false
    | "" -> Posteriori.KnownNone
    | _ -> Posteriori.KnownUnknown


trivial_test "true"
trivial_test "false"
trivial_test ""
trivial_test "anything else"
