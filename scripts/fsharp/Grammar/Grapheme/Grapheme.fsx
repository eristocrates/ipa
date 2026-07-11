#if INTERACTIVE

#load "../Data.fsx"
#load "NumericalDigit.fsx"

open Data
#endif

open FParsec
open System
open System.Globalization
open System.Text
open System.IO

type Intension = { codePoint: char; character: Rune }

module Letter =
    module Case =
        module Minuscule =
            type Type = Data.Type<Intension, int>

            let inhabitant (input: string) : Type =
                match run asciiLower input with
                | Success(lowercase, _, _) ->
                    { lexical = string lowercase
                      intensional =
                        { codePoint = lowercase
                          character = Rune(lowercase) }
                      extensional = int lowercase }
                | Failure(msg, _, _) -> failwith msg

        module Majuscule =
            type Type = Data.Type<Intension, int>

            let inhabitant (input: string) : Type =
                match run asciiUpper input with
                | Success(uppercase, _, _) ->
                    { lexical = string uppercase
                      intensional =
                        { codePoint = uppercase
                          character = Rune(uppercase) }
                      extensional = int uppercase }
                | Failure(msg, _, _) -> failwith msg


    type Type =
        { lowercase: Case.Minuscule.Type
          uppercase: Case.Majuscule.Type }

    let Alpha =
        { lowercase = Case.Minuscule.inhabitant "a"
          uppercase = Case.Majuscule.inhabitant "A" }

    let Alfa = Alpha

    let Bravo =
        { lowercase = Case.Minuscule.inhabitant "b"
          uppercase = Case.Majuscule.inhabitant "B" }

    let Charlie =
        { lowercase = Case.Minuscule.inhabitant "c"
          uppercase = Case.Majuscule.inhabitant "C" }

    let Delta =
        { lowercase = Case.Minuscule.inhabitant "d"
          uppercase = Case.Majuscule.inhabitant "D" }

    let Echo =
        { lowercase = Case.Minuscule.inhabitant "e"
          uppercase = Case.Majuscule.inhabitant "E" }

    let Foxtrot =
        { lowercase = Case.Minuscule.inhabitant "f"
          uppercase = Case.Majuscule.inhabitant "F" }

    let Golf =
        { lowercase = Case.Minuscule.inhabitant "g"
          uppercase = Case.Majuscule.inhabitant "G" }

    let Hotel =
        { lowercase = Case.Minuscule.inhabitant "h"
          uppercase = Case.Majuscule.inhabitant "H" }

    let India =
        { lowercase = Case.Minuscule.inhabitant "i"
          uppercase = Case.Majuscule.inhabitant "I" }

    let Juliett =
        { lowercase = Case.Minuscule.inhabitant "j"
          uppercase = Case.Majuscule.inhabitant "J" }

    let Juliet = Juliett

    let Kilo =
        { lowercase = Case.Minuscule.inhabitant "k"
          uppercase = Case.Majuscule.inhabitant "K" }

    let Lima =
        { lowercase = Case.Minuscule.inhabitant "l"
          uppercase = Case.Majuscule.inhabitant "L" }

    let Mike =
        { lowercase = Case.Minuscule.inhabitant "m"
          uppercase = Case.Majuscule.inhabitant "M" }

    let November =
        { lowercase = Case.Minuscule.inhabitant "n"
          uppercase = Case.Majuscule.inhabitant "N" }

    let Oscar =
        { lowercase = Case.Minuscule.inhabitant "o"
          uppercase = Case.Majuscule.inhabitant "O" }

    let Papa =
        { lowercase = Case.Minuscule.inhabitant "p"
          uppercase = Case.Majuscule.inhabitant "P" }

    let Quebec =
        { lowercase = Case.Minuscule.inhabitant "q"
          uppercase = Case.Majuscule.inhabitant "Q" }

    let Romeo =
        { lowercase = Case.Minuscule.inhabitant "r"
          uppercase = Case.Majuscule.inhabitant "R" }

    let Sierra =
        { lowercase = Case.Minuscule.inhabitant "s"
          uppercase = Case.Majuscule.inhabitant "S" }

    let Tango =
        { lowercase = Case.Minuscule.inhabitant "t"
          uppercase = Case.Majuscule.inhabitant "T" }

    let Uniform =
        { lowercase = Case.Minuscule.inhabitant "u"
          uppercase = Case.Majuscule.inhabitant "U" }

    let Victor =
        { lowercase = Case.Minuscule.inhabitant "v"
          uppercase = Case.Majuscule.inhabitant "V" }

    let Whiskey =
        { lowercase = Case.Minuscule.inhabitant "w"
          uppercase = Case.Majuscule.inhabitant "W" }

    let Xray =
        { lowercase = Case.Minuscule.inhabitant "x"
          uppercase = Case.Majuscule.inhabitant "X" }

    let Yankee =
        { lowercase = Case.Minuscule.inhabitant "y"
          uppercase = Case.Majuscule.inhabitant "Y" }

    let Zulu =
        { lowercase = Case.Minuscule.inhabitant "z"
          uppercase = Case.Majuscule.inhabitant "Z" }

module NumericalLetter =
    type Type = Data.Type<Letter.Type, int>

    let inhabitant (letterDigit: Letter.Type) (digitInteger: int) : Type =
        match run hex letterDigit.lowercase.lexical with
        | Success(lower, _, _) ->
            match run hex letterDigit.uppercase.lexical with
            | Success(upper, _, _) ->
                { lexical = string upper
                  intensional = letterDigit
                  extensional = digitInteger }
            | Failure(msg, _, _) -> failwith msg
        | Failure(msg, _, _) -> failwith msg

    let Alpha = inhabitant Letter.Alpha 10
    let Bravo = inhabitant Letter.Bravo 11
    let Charlie = inhabitant Letter.Charlie 12
    let Delta = inhabitant Letter.Delta 13
    let Echo = inhabitant Letter.Echo 14
    let Foxtrot = inhabitant Letter.Foxtrot 15






module Alphanumerical =
    type Type =
        | NumericalInhabitant of NumericalDigit.Type
        | LetterInhabitant of Letter.Type

module NumeralSystem =
    type Type =
        { radix: int
          alphabet: Alphanumerical.Type Set }

    let inhabitant<'DigitType> (digits: Alphanumerical.Type Set) : Type =
        { radix = digits.Count
          alphabet = digits }

    module Binary =
        type Digit = Data.Type<Intension, int>


        let zero: Digit = NumericalDigit.zero
        let one: Digit = NumericalDigit.one

        let System =
            inhabitant (
                Set.ofList
                    [ Alphanumerical.NumericalInhabitant NumericalDigit.zero
                      Alphanumerical.NumericalInhabitant NumericalDigit.one

                      ]
            )

    module Decimal =
        type Digit = Data.Type<Intension, int>
        let zero: Digit = NumericalDigit.zero
        let one: Digit = NumericalDigit.one
        let two: Digit = NumericalDigit.two
        let three: Digit = NumericalDigit.three
        let four: Digit = NumericalDigit.four
        let five: Digit = NumericalDigit.five
        let six: Digit = NumericalDigit.six
        let seven: Digit = NumericalDigit.seven
        let eight: Digit = NumericalDigit.eight
        let nine: Digit = NumericalDigit.nine

        let System =
            inhabitant (
                Set.ofList
                    [ Alphanumerical.NumericalInhabitant NumericalDigit.zero
                      Alphanumerical.NumericalInhabitant NumericalDigit.one
                      Alphanumerical.NumericalInhabitant NumericalDigit.two
                      Alphanumerical.NumericalInhabitant NumericalDigit.three
                      Alphanumerical.NumericalInhabitant NumericalDigit.four
                      Alphanumerical.NumericalInhabitant NumericalDigit.five
                      Alphanumerical.NumericalInhabitant NumericalDigit.six
                      Alphanumerical.NumericalInhabitant NumericalDigit.seven
                      Alphanumerical.NumericalInhabitant NumericalDigit.eight
                      Alphanumerical.NumericalInhabitant NumericalDigit.nine

                      ]
            )

    module Hexadecimal =
        type NumberDigit = Data.Type<Intension, int>
        type LetterDigit = Data.Type<Letter.Type, int>

        let zero: NumberDigit = NumericalDigit.zero
        let one: NumberDigit = NumericalDigit.one
        let two: NumberDigit = NumericalDigit.two
        let three: NumberDigit = NumericalDigit.three
        let four: NumberDigit = NumericalDigit.four
        let five: NumberDigit = NumericalDigit.five
        let six: NumberDigit = NumericalDigit.six
        let seven: NumberDigit = NumericalDigit.seven
        let eight: NumberDigit = NumericalDigit.eight
        let nine: NumberDigit = NumericalDigit.nine
        let ten: LetterDigit = NumericalLetter.Alpha
        let eleven: LetterDigit = NumericalLetter.Bravo
        let twelve: LetterDigit = NumericalLetter.Charlie
        let thirteen: LetterDigit = NumericalLetter.Delta
        let fourteen: LetterDigit = NumericalLetter.Echo
        let fifteen: LetterDigit = NumericalLetter.Foxtrot

        let System =
            inhabitant (
                Set.ofList
                    [ Alphanumerical.NumericalInhabitant NumericalDigit.zero
                      Alphanumerical.NumericalInhabitant NumericalDigit.one
                      Alphanumerical.NumericalInhabitant NumericalDigit.two
                      Alphanumerical.NumericalInhabitant NumericalDigit.three
                      Alphanumerical.NumericalInhabitant NumericalDigit.four
                      Alphanumerical.NumericalInhabitant NumericalDigit.five
                      Alphanumerical.NumericalInhabitant NumericalDigit.six
                      Alphanumerical.NumericalInhabitant NumericalDigit.seven
                      Alphanumerical.NumericalInhabitant NumericalDigit.eight
                      Alphanumerical.NumericalInhabitant NumericalDigit.nine
                      Alphanumerical.LetterInhabitant Letter.Alpha
                      Alphanumerical.LetterInhabitant Letter.Bravo
                      Alphanumerical.LetterInhabitant Letter.Charlie
                      Alphanumerical.LetterInhabitant Letter.Delta
                      Alphanumerical.LetterInhabitant Letter.Echo
                      Alphanumerical.LetterInhabitant Letter.Foxtrot

                      ]

            )
