#if INTERACTIVE

#load "Data.fsx"
#load "WritingSystem.fsx"
#load "AugmentedBackusNaurForm.fsx"

open Data
open AugmentedBackusNaurForm
#endif

open FParsec
open System
open System.Globalization
open System.Text
open System.IO

module Character =

    module Universal =
        type Type = Data<WritingSystem.Grapheme.Representation, int>

        let parser: Parser<Type, unit> =
            Terminal.runeparserFromLiteralList
                [ "%xA0-D7FF"
                  "%xF900-FDCF"
                  "%xFDF0-FFEF"
                  "%x10000-1FFFD"
                  "%x20000-2FFFD"
                  "%x30000-3FFFD"
                  "%x40000-4FFFD"
                  "%x50000-5FFFD"
                  "%x60000-6FFFD"
                  "%x70000-7FFFD"
                  "%x80000-8FFFD"
                  "%x90000-9FFFD"
                  "%xA0000-AFFFD"
                  "%xB0000-BFFFD"
                  "%xC0000-CFFFD"
                  "%xD0000-DFFFD"
                  "%xE1000-EFFFD" ]
            |>> fun ucschar ->
                { lexical = ucschar.runicCharacter.ToString()
                  intensional = ucschar
                  extensional = ucschar.runicCharacter.Value }

        let inhabitant (on_input: string) : Type =
            match run parser on_input with
            | Success(generalDelimiter, _, _) -> generalDelimiter
            | Failure(msg, _, _) -> failwith msg

    module Reserved =
        module Delimiter =
            module Generic =
                type Type = Data<WritingSystem.Grapheme.Representation, char>

                let parser: Parser<Type, unit> =
                    anyOf ":/?#[]@"
                    |>> (fun gen_delims ->
                        { lexical = string gen_delims
                          intensional = { runicCharacter = Rune gen_delims }
                          extensional = gen_delims })

                let inhabitant (on_input: string) : Type =
                    match run parser on_input with
                    | Success(generalDelimiter, _, _) -> generalDelimiter
                    | Failure(msg, _, _) -> failwith msg

            module Subcomponent =
                type Type = Data<WritingSystem.Grapheme.Representation, int>

                let parser: Parser<Type, unit> =
                    anyOf "!$&'()*+,;="
                    |>> (fun sub_delims ->
                        { lexical = string sub_delims
                          intensional = { runicCharacter = Rune sub_delims }
                          extensional = int sub_delims })

                let inhabitant (on_input: string) : Type =
                    match run parser on_input with
                    | Success(subcomponentDelimiter, _, _) -> subcomponentDelimiter
                    | Failure(msg, _, _) -> failwith msg

        type Type =
            | GeneralDelimiter of Delimiter.Generic.Type
            | SubcomponentDelimiter of Delimiter.Subcomponent.Type

        let parser: Parser<Type, unit> =
            choice
                [ Delimiter.Generic.parser
                  |>> (fun generalReserved -> GeneralDelimiter generalReserved)
                  Delimiter.Subcomponent.parser
                  |>> (fun subcomponentReserved -> SubcomponentDelimiter subcomponentReserved) ]

        let inhabitant (on_input: string) : Type =
            match run parser on_input with
            | Success(reserved, _, _) -> reserved
            | Failure(msg, _, _) -> failwith msg

    module Unreserved =
        type Type = Data<WritingSystem.Grapheme.Representation, int>

        let parser: Parser<Type, unit> =
            choice [ AugmentedBackusNaurForm.ALPHA; AugmentedBackusNaurForm.DIGIT; anyOf "-._~" ]
            |>> (fun sub_delims ->
                { lexical = string sub_delims
                  intensional = { runicCharacter = Rune sub_delims }
                  extensional = int sub_delims })

        let inhabitant (on_input: string) : Type =
            match run parser on_input with
            | Success(subcomponentDelimiter, _, _) -> subcomponentDelimiter
            | Failure(msg, _, _) -> failwith msg

        module Internationalized =
            let parser = choice [ parser; Universal.parser ]

            let inhabitant (on_input: string) : Type =
                match run parser on_input with
                | Success(iunreserved, _, _) -> iunreserved
                | Failure(msg, _, _) -> failwith msg


    module PercentEncoded =
        type Intension =
            { mostSignificant: byte
              leastSignificant: byte }

        type Type = Data<Intension, byte>

        let parser: Parser<Type, unit> =
            pchar '%' >>. hex .>>. hex
            |>> fun (leftDigit, rightDigit) ->
                let mostSignificantNibble = Uri.FromHex leftDigit // int 0..15
                let leastSignificantNibble = Uri.FromHex rightDigit // int 0..15

                let octet = (mostSignificantNibble <<< 4) ||| leastSignificantNibble // int 0..255

                { lexical = $"{WritingSystem.Grapheme.percent}{leftDigit}{rightDigit}"
                  intensional =
                    { mostSignificant = byte mostSignificantNibble
                      leastSignificant = byte leastSignificantNibble }
                  extensional = byte octet }

        let inhabitant (on_input: string) =
            match run parser on_input with
            | Success(dataOctet, _, _) -> dataOctet
            | Failure(msg, _, _) -> failwith msg

module PathCharacter =
    type Type =
        | PathPercentCharacter of Character.PercentEncoded.Type
        | PathIntegerCharacter of Data<WritingSystem.Grapheme.Representation, int>

    let parser =
        choice
            [ Character.Unreserved.parser |>> PathIntegerCharacter
              Character.Reserved.Delimiter.Subcomponent.parser |>> PathIntegerCharacter
              Character.PercentEncoded.parser |>> PathPercentCharacter
              anyOf ":@"
              |>> (fun pathCharacter ->
                  { lexical = string pathCharacter
                    intensional = ({ runicCharacter = Rune pathCharacter }: WritingSystem.Grapheme.Representation)
                    extensional = int pathCharacter }
                  |> PathIntegerCharacter)

              ]


    let inhabitant (on_input: string) =
        match run parser on_input with
        | Success(dataOctet, _, _) -> dataOctet
        | Failure(msg, _, _) -> failwith msg
// module Internationalzed =



module Fragment =
    type Intension =
        { characterList: list<PathCharacter.Type> }

    type Type = Data<Intension, int list>
    // Turn a parsed PathCharacter into:
    // - a lexical string segment
    // - a list of ints for extensional
    let private project (pathCharacter: PathCharacter.Type) : string * int list =
        match pathCharacter with
        | PathCharacter.PathIntegerCharacter character ->
            // lexical is the original single-character lexeme
            // extensional is your chosen int representation (you currently use int pathCharacter)
            (character.lexical, [ character.extensional ])

        | PathCharacter.PathPercentCharacter percentCharacter ->
            // Here you must choose an extensional policy.
            // The most common useful one is: treat pct-encoded as ONE byte value 0..255.
            //
            // This assumes your PercentEncoded.Type has:
            // - intensional.mostSignificant : byte  (0..15)
            // - intensional.leastSignificant : byte (0..15)
            let highDigit = int percentCharacter.intensional.mostSignificant
            let lowDigit = int percentCharacter.intensional.leastSignificant
            let octet = (highDigit <<< 4) ||| lowDigit

            // lexical should remain the original source lexeme (e.g., "%2F")
            (percentCharacter.lexical, [ octet ])


    let parser: Parser<Type, unit> =
        many (
            choice
                [ PathCharacter.parser

                  anyOf "/?"
                  |>> (fun fragmentCharacter ->
                      { lexical = string fragmentCharacter
                        intensional =
                          ({ runicCharacter = Rune fragmentCharacter }: WritingSystem.Grapheme.Representation)
                        extensional = int fragmentCharacter }
                      |> PathCharacter.PathIntegerCharacter) ]
        )
        |>> (fun pathCharacterList ->
            // Assemble the whole Fragment record from the list.
            let lexical =
                pathCharacterList
                |> List.map (fun pc -> pc |> project |> fst)
                |> String.concat ""

            let extensional = pathCharacterList |> List.collect (fun pc -> pc |> project |> snd)

            { lexical = lexical
              intensional = { characterList = pathCharacterList }
              extensional = extensional })


    let inhabitant (on_string: string) =
        match run parser on_string with
        | Success(fragment, _, _) -> fragment
        | Failure(msg, _, _) -> failwith msg

module Scheme =
    let parser =
        AugmentedBackusNaurForm.ALPHA
        .>>. manyChars (choice [ AugmentedBackusNaurForm.ALPHA; AugmentedBackusNaurForm.DIGIT; anyOf "+-." ])
        |>> fun (first, rest) -> string first + rest

    let inhabitant (on_input: string) =
        match run parser on_input with
        | Success(scheme, _, _) -> scheme
        | Failure(msg, _, _) -> failwith msg

let test = Fragment.inhabitant "test"
