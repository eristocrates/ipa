module DoxAletheia.BooleanExtensions

open System
open ConversionErgonomics

type Boolean with 
    static member from_byte (byte_value:byte) = byte_to_bool byte_value
    member this.to_byte  = bool_to_byte this



