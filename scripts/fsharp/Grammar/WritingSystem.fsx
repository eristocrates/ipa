#if INTERACTIVE

#load "Data.fsx"

open Data
#endif

open FParsec
open System
open System.Globalization
open System.Text
open System.IO


module Grapheme =
    type Representation = { runicCharacter: Rune }

    let percent =
        { lexical = "%"
          intensional = { runicCharacter = Rune '%' }
          extensional = '%' }


    module NumericalDigit =
        type Type = Data<Rune, int>

        let parser = digit

        let inhabitant (on_input: string) (digitInteger: int) : Type =
            match run parser on_input with
            | Success(numericalDigit, _, _) ->
                { lexical = string numericalDigit
                  intensional = Rune(numericalDigit)
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

    module Letter =
        module Case =
            module Minuscule =
                type Type = Data<Rune, int>
                let parser = asciiLower

                let inhabitant (on_input: string) : Type =
                    match run parser on_input with
                    | Success(lowercase, _, _) ->
                        { lexical = string lowercase
                          intensional = Rune(lowercase)
                          extensional = int lowercase }
                    | Failure(msg, _, _) -> failwith msg

            module Majuscule =
                type Type = Data<Rune, int>
                let parser = asciiUpper

                let inhabitant (on_input: string) : Type =
                    match run parser on_input with
                    | Success(uppercase, _, _) ->
                        { lexical = string uppercase
                          intensional = Rune(uppercase)
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
        type Type = Data<Letter.Type, int>
        let parser = hex

        let inhabitant (letterDigit: Letter.Type) (digitInteger: int) : Type =
            match run parser letterDigit.lowercase.lexical with
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






    type Type =
        | DigitInhabitant of NumericalDigit.Type
        | LetterInhabitant of Letter.Type

module NumeralSystem =
    type Type =
        { radix: int
          alphabet: Grapheme.Type Set }

    let inhabitant<'DigitType> (digits: Grapheme.Type Set) : Type =
        { radix = digits.Count
          alphabet = digits }

    module Binary =
        type Digit = Data<Rune, int>


        let zero: Digit = Grapheme.NumericalDigit.zero
        let one: Digit = Grapheme.NumericalDigit.one

        let System =
            inhabitant (
                Set.ofList
                    [ Grapheme.DigitInhabitant Grapheme.NumericalDigit.zero
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.one

                      ]
            )

    module Decimal =
        type Digit = Data<Rune, int>
        let zero: Digit = Grapheme.NumericalDigit.zero
        let one: Digit = Grapheme.NumericalDigit.one
        let two: Digit = Grapheme.NumericalDigit.two
        let three: Digit = Grapheme.NumericalDigit.three
        let four: Digit = Grapheme.NumericalDigit.four
        let five: Digit = Grapheme.NumericalDigit.five
        let six: Digit = Grapheme.NumericalDigit.six
        let seven: Digit = Grapheme.NumericalDigit.seven
        let eight: Digit = Grapheme.NumericalDigit.eight
        let nine: Digit = Grapheme.NumericalDigit.nine

        let System =
            inhabitant (
                Set.ofList
                    [ Grapheme.DigitInhabitant Grapheme.NumericalDigit.zero
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.one
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.two
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.three
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.four
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.five
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.six
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.seven
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.eight
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.nine

                      ]
            )

    module Hexadecimal =
        type NumberDigit = Data<Rune, int>
        type LetterDigit = Data<Grapheme.Letter.Type, int>

        let zero: NumberDigit = Grapheme.NumericalDigit.zero
        let one: NumberDigit = Grapheme.NumericalDigit.one
        let two: NumberDigit = Grapheme.NumericalDigit.two
        let three: NumberDigit = Grapheme.NumericalDigit.three
        let four: NumberDigit = Grapheme.NumericalDigit.four
        let five: NumberDigit = Grapheme.NumericalDigit.five
        let six: NumberDigit = Grapheme.NumericalDigit.six
        let seven: NumberDigit = Grapheme.NumericalDigit.seven
        let eight: NumberDigit = Grapheme.NumericalDigit.eight
        let nine: NumberDigit = Grapheme.NumericalDigit.nine
        let ten: LetterDigit = Grapheme.NumericalLetter.Alpha
        let eleven: LetterDigit = Grapheme.NumericalLetter.Bravo
        let twelve: LetterDigit = Grapheme.NumericalLetter.Charlie
        let thirteen: LetterDigit = Grapheme.NumericalLetter.Delta
        let fourteen: LetterDigit = Grapheme.NumericalLetter.Echo
        let fifteen: LetterDigit = Grapheme.NumericalLetter.Foxtrot

        let System =
            inhabitant (
                Set.ofList
                    [ Grapheme.DigitInhabitant Grapheme.NumericalDigit.zero
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.one
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.two
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.three
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.four
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.five
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.six
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.seven
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.eight
                      Grapheme.DigitInhabitant Grapheme.NumericalDigit.nine
                      Grapheme.LetterInhabitant Grapheme.Letter.Alpha
                      Grapheme.LetterInhabitant Grapheme.Letter.Bravo
                      Grapheme.LetterInhabitant Grapheme.Letter.Charlie
                      Grapheme.LetterInhabitant Grapheme.Letter.Delta
                      Grapheme.LetterInhabitant Grapheme.Letter.Echo
                      Grapheme.LetterInhabitant Grapheme.Letter.Foxtrot

                      ]

            )




module Numeral =
    module Radix =
        type Intension = { indicator: char; cardinality: int }
        type Type = Data<Intension, int>

        let inhabitant (baseIdentifier: char) (digitCardinality: int) : Type =
            { lexical = string baseIdentifier
              intensional =
                { indicator = baseIdentifier
                  cardinality = digitCardinality }
              extensional = digitCardinality }

    module Prefix =
        type Intension =
            { numericalSigil: char
              baseIndicator: char }

        type Type = Data<Intension, string>

        let inhabitant (prefixSigil: char) (baseSigil: char) : Type =
            { lexical = $"{prefixSigil}{baseSigil}"
              intensional =
                { numericalSigil = prefixSigil
                  baseIndicator = baseSigil }
              extensional = $"0{baseSigil}" }
