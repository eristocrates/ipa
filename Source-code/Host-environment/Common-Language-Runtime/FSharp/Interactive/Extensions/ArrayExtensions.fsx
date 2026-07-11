open System
open System.Threading.Tasks
open System.Numerics

module Array =

    let vectorizable_length<'T> (target_array: 'T []) =
        let width = Vector<'T>.Count

        match target_array.Length % width with
        | 0 -> target_array.Length
        | remainder -> target_array.Length + width - remainder

    let inline right_pad<'T when 'T: (static member Zero: ^T)> (padded_length: int) (target_array: 'T []) =

        if padded_length = target_array.Length then
            target_array
        else
            let padded_array = Array.create padded_length LanguagePrimitives.GenericZero
            System.Array.Copy(target_array, padded_array, target_array.Length)
            padded_array

    let inline vectorize<'InputType, 'OutputType when 'InputType: (static member Zero: 'InputType)>
        (vectorize: 'InputType -> 'OutputType)
        (input_array: 'InputType array)
        =
        let mutable start_index = 0
        let width = Vector<'InputType>.Count
        let last_position = width - 1
        let padding_length = vectorizable_length input_array
        let padded_input = input_array |> right_pad padding_length
        let output_array = Array.zeroCreate<'OutputType> padded_input.Length

        while start_index < padded_input.Length do
            let vector = Vector<'InputType>(padded_input, start_index)

            for position_index = 0 to last_position do
                let code_point = start_index + position_index
                let value = vectorize vector[position_index]
                output_array[code_point] <- value

            // printfn "array index %i = %A" code_point value

            start_index <- start_index + width

        output_array


    let last_index (target_array: 'T []) = target_array.Length - 1


    let index_is_safe (target_index: int) (target_array: 'T ``[]``) =
        let absolute_index = abs target_index

        if absolute_index > last_index target_array then
            false
        else
            true


    let reversible_index (target_index: int) (target_array: 'T ``[]``) =
        let absolute_index = abs target_index

        match target_index with
        | positive_index when target_index > 0 ->
            if target_array |> index_is_safe positive_index then
                positive_index
            else
                last_index target_array
        | negative_index when target_index < 0 ->
            if target_array |> index_is_safe negative_index then
                (last_index target_array) + negative_index
            else
                0
        | _ -> 0

    let string_slice left_target right_target (string_array: string array) =
        let from_index = string_array |> reversible_index left_target
        let to_index = string_array |> reversible_index right_target
        string_array[from_index..to_index]

    let is_vectorizable_from_index (start_index: int) (target_array: 'ElementType array) =
        start_index + Vector<'ElementType>.Count
        <= target_array.Length

    module Parallel =

        let inline vectorize<'InputType, 'OutputType when 'InputType: (static member Zero: 'InputType)>
            (vectorize: 'InputType -> 'OutputType)
            (input_array: 'InputType array)
            =

            let width = Vector<'InputType>.Count

            let padding_length = vectorizable_length input_array

            let padded_input = input_array |> right_pad padding_length

            let output_array = Array.zeroCreate<'OutputType> padded_input.Length

            let vector_count = padded_input.Length / width

            Parallel.For(
                0,
                vector_count,
                fun vector_number ->
                    let start_index = vector_number * width

                    let vector = Vector<'InputType>(padded_input, start_index)

                    for position_index = 0 to width - 1 do
                        let array_index = start_index + position_index

                        let value = vectorize vector[position_index]

                        output_array[array_index] <- value
            )
            |> ignore

            output_array

type 'T ``[]`` with

    member this.last_index = Array.last_index this
    member this.vectorizable_length = Array.vectorizable_length this


    member this.index target_index =
        this |> Array.reversible_index target_index
