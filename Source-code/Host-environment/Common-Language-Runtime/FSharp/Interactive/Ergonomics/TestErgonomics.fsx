#r "nuget: FsCheck"
#r "nuget: Unquote"
#r "nuget: FsUnit"
#r "nuget: FSharp.UMX"

module EmailAddress =

    type _T = EmailAddress of string

    // create with continuation
    let createWithCont success failure (s: string) =
        if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then
            success (EmailAddress s)
        else
            failure "Email address must contain an @ sign"

    // create directly
    let create s =
        let success e = Some e
        let failure _ = None
        createWithCont success failure s

    // unwrap with continuation
    let apply f (EmailAddress e) = f e

    // unwrap directly
    let value e = apply id e







open FsCheck
open Swensen.Unquote.Assertions
open FsUnit
open FsUnitTyped




3 |> should equal 1




let int_should_equal_int (integer: int) = test <@ integer = integer @>
Check.Quick int_should_equal_int




let reverse_reverse_int_is_original_int (list_int: list<int>) =
    test <@ List.rev (List.rev list_int) = list_int @>




Check.Quick reverse_reverse_int_is_original_int




let reverse_is_original (list_int: list<int>) = test <@ List.rev list_int = list_int @>




let reverse_reverse_float_is_original_float (list_float: list<float>) =
    test <@ List.rev (List.rev list_float) = list_float @>



Check.Quick reverse_reverse_float_is_original_float
13
