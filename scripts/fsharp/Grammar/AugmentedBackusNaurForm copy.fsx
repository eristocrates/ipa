#if INTERACTIVE

#load "Data.fsx"
#load "WritingSystem.fsx"

open Data
#endif

open FParsec
open System
open System.Globalization
open System.Text
open System.IO




let defined_as: Parser<char, unit> = spaces >>. pchar '=' .>> spaces

let numericalSigil = '%'
let decimalSigil = 'd'
let hexadecimalSigil = 'x'
let binarySigil = 'b'

let BIT: Parser<char, unit> = anyOf "01"
let HEXDIG: Parser<char, unit> = hex

let ALPHA = asciiLetter
let DIGIT = digit

module Rulename =
    type Type = Data<string, string>
    // TODO track case like camel, snake, capital initial, all caps
    // TODO flag f# collisions like - or reserved keywords
    // TODO add comment

    let parser: Parser<Type, unit> =
        spaces >>. (manyChars (choice [ ALPHA; DIGIT; pchar '-' ]))
        |>> (fun name ->
            { lexical = name
              intensional = name
              extensional = name })

    let inhabitant (on_input: string) : Type =
        match run parser on_input with
        | Success(rulename, _, _) -> rulename
        | Failure(msg, _, _) -> failwith msg

module Terminal =
    module Prefix =
        let parser: Parser<WritingSystem.Numeral.Prefix.Type, unit> =
            pipe2
                (pchar numericalSigil)
                (choice [ pchar binarySigil; pchar decimalSigil; pchar hexadecimalSigil ])
                (fun prefixSigil baseSigil -> WritingSystem.Numeral.Prefix.inhabitant prefixSigil baseSigil)

        let inhabitant (on_input: string) : WritingSystem.Numeral.Prefix.Type =
            match run parser on_input with
            | Success(prefix, _, _) -> prefix
            | Failure(msg, _, _) -> failwith msg


    module Numeral =
        type Intension =
            { prefix: WritingSystem.Numeral.Prefix.Type
              literal: string
              integer: int }

        type Type = Data<Intension, Rune>

        let parser (terminalPrefix: WritingSystem.Numeral.Prefix.Type) : Parser<Type, unit> =
            let bindechexDigits: Parser<string, unit> =
                match terminalPrefix.intensional.baseIndicator with
                | 'b' -> many1Chars BIT
                | 'd' -> many1Chars DIGIT
                | 'x' -> many1Chars HEXDIG
                | _ -> fail $"Unknown base sigil '{terminalPrefix.intensional.baseIndicator}'"

            let radix: int =
                match terminalPrefix.intensional.baseIndicator with
                | 'b' -> WritingSystem.NumeralSystem.Binary.System.radix
                | 'd' -> WritingSystem.NumeralSystem.Decimal.System.radix
                | 'x' -> WritingSystem.NumeralSystem.Hexadecimal.System.radix
                | c -> failwith $"Unknown base sigil for radix '{c}'"

            bindechexDigits
            >>= fun valueString ->
                let codePoint = Convert.ToInt32(valueString, radix)

                match Rune.TryCreate(codePoint) with
                | true, valueRune ->
                    preturn
                        { lexical = $"{terminalPrefix.lexical}{valueString}"
                          intensional =
                            { prefix = terminalPrefix
                              literal = valueString
                              integer = codePoint }
                          extensional = valueRune }
                | false, _ -> fail $"Value {codePoint} is not a valid Unicode scalar value."

        let inhabitant (on_input: string) (with_prefix: WritingSystem.Numeral.Prefix.Type) : Type =
            match run (parser with_prefix) on_input with
            | Success(numeral, _, _) -> numeral
            | Failure(msg, _, _) -> failwith msg


    module Value =
        module Relation =
            type Type =
                | Singleton
                | Concatenation
                | Boundary

        type Intension =
            { prefix: WritingSystem.Numeral.Prefix.Type
              relation: Relation.Type
              characters: Numeral.Type list }

        type Type = Data<Intension, string>

        // Pure constructor: no parsing here, just assembly.
        let private build
            (basePrefix: WritingSystem.Numeral.Prefix.Type)
            (numeralRelation: Relation.Type)
            (numeralList: Numeral.Type list)
            : Type =

            // prefix applies once; literals are what are concatenated/ranged in "scope" of a prefix.
            // So lexical should look like "%x41.42" rather than "%x41%x42".
            let literalParts =
                numeralList |> List.map (fun character -> character.intensional.literal)

            let lexical =
                match numeralRelation with
                | Relation.Singleton ->
                    // single literal part: "%x" + "41"
                    basePrefix.lexical + (literalParts |> String.concat "")
                | Relation.Concatenation ->
                    // "%x" + "41.42.43"
                    basePrefix.lexical + (literalParts |> String.concat ".")
                | Relation.Boundary ->
                    // "%x" + "41-5A"
                    basePrefix.lexical + (literalParts |> String.concat "-")

            // extensional: concatenate the Rune values into a string
            // (for Range, this is a placeholder policy; you can revise later)
            let extensional =
                match numeralRelation with
                | Relation.Singleton
                | Relation.Concatenation ->
                    numeralList
                    |> List.map (fun character -> character.extensional.ToString())
                    |> String.concat ""
                | Relation.Boundary ->
                    // placeholder: show endpoints joined by "-"
                    numeralList
                    |> List.map (fun character -> character.extensional.ToString())
                    |> String.concat "-"

            { lexical = lexical
              intensional =
                { prefix = basePrefix
                  relation = numeralRelation
                  characters = numeralList }
              extensional = extensional }

        module Character =
            let parser (numeral: Numeral.Type) : Parser<Type, unit> =
                preturn (build numeral.intensional.prefix Relation.Singleton [ numeral ])


        module ConcatenatedString =
            // CASE 1: concatenation tail: ('.' literal)+
            let parser (first: Numeral.Type) : Parser<Type, unit> =
                (pchar '.' >>. Numeral.parser first.intensional.prefix) |> many1
                |>> fun rest ->
                    let numerals = first :: rest
                    build first.intensional.prefix Relation.Concatenation numerals

        module Range =
            // CASE 2: range tail: '-' literal
            let parser (first: Numeral.Type) : Parser<Type, unit> =
                (pchar '-' >>. Numeral.parser first.intensional.prefix)
                |>> fun last ->
                    let endpoints = [ first; last ]
                    build first.intensional.prefix Relation.Boundary endpoints

        let parser: Parser<Type, unit> =
            Prefix.parser
            >>= fun basePrefix ->

                // parse the first literal under this prefix
                Numeral.parser basePrefix
                >>= fun first ->
                    lookAhead anyChar
                    >>= function
                        | '.' ->
                            // commit to concatenation; failure here should fail the whole Value
                            ConcatenatedString.parser first
                        | '-' ->
                            // commit to range; failure here should fail the whole Value
                            Range.parser first
                        | _ ->
                            // no '.' or '-': singleton
                            Character.parser first

        let inhabitant (on_input: string) : Type =
            match run parser on_input with
            | Success(literal, _, _) -> literal
            | Failure(msg, _, _) -> failwith msg


let Rule = Rulename.parser .>> defined_as .>>. Terminal.Value.parser
