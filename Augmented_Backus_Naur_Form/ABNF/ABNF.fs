// https://datatracker.ietf.org/doc/html/rfc5234#section-4
module Augmented_Backus_Naur_Form.ABNF
#if INTERACTIVE
#r "nuget: FParsec"
#endif
open System
open FParsec

let metaTest = @"ALPHA          =  %x41-5A / %x61-7A   ; A-Z / a-z"

let ALPHA = asciiLetter // %x41-5A / %x61-7A   ; A-Z / a-z
