open System





type Int32 with
    member this.from_hexadecimal_digit_string(hexdig_string: string) = Convert.ToInt32(hexdig_string, 16)
    member this.as_hexstring = sprintf "%04X" this
    member this.as_Ustring = sprintf "U+%04X" this
