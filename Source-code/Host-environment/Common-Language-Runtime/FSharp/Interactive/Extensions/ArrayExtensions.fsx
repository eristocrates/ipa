type 'T ``[]`` with

    member this.last_index = this.Length - 1

    member this.index target_index =
        let absolute_index = abs target_index

        match target_index with
        | positive_index when target_index > 0 ->
            match absolute_index > this.last_index with
            | true -> this[this.last_index]
            | false -> this[positive_index]
        | negative_index when target_index < 0 ->
            match absolute_index > this.last_index with
            | true -> this[0]
            | false -> this[this.last_index + negative_index]

        | _ -> this[0]

module Array =

    let last_index (target_array: 'T []) = target_array.last_index
    let index target_index (target_array: 'T []) = target_array.index target_index
