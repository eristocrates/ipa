open System.Diagnostics

let time_operation (operation_name: string) (operation: unit -> 'Result) : 'Result =

    let stopwatch = Stopwatch.StartNew()

    try
        let result = operation ()

        stopwatch.Stop()

        printfn "%s elapsed=%O" operation_name stopwatch.Elapsed

        result
    with
    | _ ->
        stopwatch.Stop()

        printfn "%s failed elapsed=%O" operation_name stopwatch.Elapsed

        reraise ()
