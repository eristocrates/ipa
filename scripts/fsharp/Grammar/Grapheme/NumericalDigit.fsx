#if INTERACTIVE

#load "../Data.fsx"
#load "Grapheme.fsx"

open Data
#endif

open FParsec
open System
open System.Globalization
open System.Text
open System.IO

type Type = Data.Type<Grapheme.Intension, int>

let inhabitant (digitString: string) (digitInteger: int) : Type =
    match run digit digitString with
    | Success(numericalDigit, _, _) ->
        { lexical = string numericalDigit
          intensional =
            { codePoint = numericalDigit
              character = Rune(numericalDigit) }
          extensional = digitInteger }
    | Failure(msg, _, _) -> failwith msg


let zero = inhabitant "0" 0
let one = inhabitant "1" 1
let two = inhabitant "2" 2
let three = inhabitant "3" 3
let four = inhabitant "4" 4
let five = inhabitant "5" 5
let six = inhabitant "6" 6
let seven = inhabitant "7" 7
let eight = inhabitant "8" 8
let nine = inhabitant "9" 9
