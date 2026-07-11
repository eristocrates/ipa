module DoxAletheia.RuneExtensions

open System


open System.Text



type Rune with 
    member this.as_string = this.ToString()
    member this.hex_literal = sprintf "%X" this.Value
    member this.Uhex_literal = $"U+{this.hex_literal}"
