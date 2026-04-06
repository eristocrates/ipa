open System

let Capitalize (input: string) =
    if String.IsNullOrEmpty(input) then
        input
    else
        input

        |> Seq.mapi (fun characterIndex character ->
            match characterIndex with
            | 0 -> Char.ToUpper(character)
            | _ -> character)
        |> String.Concat

let lastSectionOfString (input: string) (delimeter: string) =
    let index = input.LastIndexOf(delimeter)

    if index = -1 then
        input // return the whole string if the delimiter is not found
    else
        input.Substring(index + 1)



(*
let jsonValueString (jsonValue: JsonValue) =
    if jsonValue.AsString().Length > 0 then
        Some(jsonValue.AsString())
    else
        None
*)
