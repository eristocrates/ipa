module DoxAletheia.ConversionErgonomics


let bool_to_byte (predicate_is_true:bool) = if predicate_is_true then 1uy else 0uy
let byte_to_bool (byte_value:byte) = byte_value <> 0uy
