open System

let (|Integer_String|_|) (input: string) =
    match Int32.TryParse input with

    | true, integer -> Some input
    | false, _ -> None
