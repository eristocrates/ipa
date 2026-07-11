open System.Diagnostics

type AutoLogBuilder() =
    let autolog logged_expression =
        printfn "expression is %A" logged_expression

    member this.Bind(right_hand_expression, rest_of_block_parameterized_by_left_hand_identifier) =
        autolog right_hand_expression
        rest_of_block_parameterized_by_left_hand_identifier right_hand_expression

    member this.Return(expression_at_end_of_block) = expression_at_end_of_block

let autolog = new AutoLogBuilder()



type StopwatchBuilder() =
    member this.timer = new Stopwatch()

    member this.Delay(computation_expression_block_as_function) =
        printfn "Starting computation timer"
        this.timer.Start()
        computation_expression_block_as_function ()

    member this.Bind(value, rest) =
        printfn "Value: %A" value
        rest value

    member this.Return(expression_to_return) =
        let return_value = expression_to_return
        this.timer.Stop()
        printfn "%A" this.timer.ElapsedMilliseconds
        return_value

let stopwatch = StopwatchBuilder()

let result =
    stopwatch {
        let! x = 42
        return x
    }

let loggedWorkflow =
    autolog {
        let! x = 42
        let! y = 43
        let! z = x + y
        return z
    }
