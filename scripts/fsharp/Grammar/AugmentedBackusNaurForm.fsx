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

// -------------------------
// Unicode scalar (Rune) parsing from input text
// -------------------------
// This is the "execution artifact" parser you were missing:
// it consumes ONE Unicode scalar value from the input stream and returns a Rune.
//
// Why needed:
// - FParsec's primitives are primarily char-based (UTF-16 code units).
// - A Rune may be either:
//   * a single UTF-16 char (BMP, non-surrogate), OR
//   * a surrogate pair (two chars) encoding one Unicode scalar.
module UnicodeScalar =
    let parser: Parser<Rune, unit> =
        // Try surrogate pair first; if it fails, backtrack and try single char.
        attempt (
            anyChar .>>. anyChar
            >>= fun (hi, lo) ->
                match Rune.TryCreate(hi, lo) with
                | true, rune -> preturn rune
                | false, _ -> fail "Invalid UTF-16 surrogate pair (not a Unicode scalar value)."
        )
        <|> (anyChar
             >>= fun c ->
                 // Reject isolated surrogates: they are not valid Unicode scalar values.
                 if Char.IsSurrogate(c) then
                     fail "Isolated UTF-16 surrogate is not a Unicode scalar value."
                 else
                     preturn (Rune c))

// -------------------------
// ABNF base infrastructure (your existing code)
// -------------------------

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

            let literalParts =
                numeralList |> List.map (fun character -> character.intensional.literal)

            let lexical =
                match numeralRelation with
                | Relation.Singleton -> basePrefix.lexical + (literalParts |> String.concat "")
                | Relation.Concatenation -> basePrefix.lexical + (literalParts |> String.concat ".")
                | Relation.Boundary -> basePrefix.lexical + (literalParts |> String.concat "-")

            // NOTE: extensional here is a "display/summary policy", not the denotation of the set.
            // The denotation (the set of allowed runes) is handled by runeParser/stringParser below.
            let extensional =
                match numeralRelation with
                | Relation.Singleton
                | Relation.Concatenation ->
                    numeralList
                    |> List.map (fun character -> character.extensional.ToString())
                    |> String.concat ""
                | Relation.Boundary ->
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

            // -------------------------
            // NEW: compile a Value (spec artifact) into input parsers (execution artifacts)
            // -------------------------

            let asInclusiveBounds (first: Numeral.Type) (last: Numeral.Type) : int * int =
                let a = first.intensional.integer
                let b = last.intensional.integer
                if a <= b then (a, b) else (b, a)

        // Parser that consumes ONE Rune from the input stream and checks it against this Value spec.
        // - Singleton: accept exactly that rune
        // - Boundary: accept any rune whose scalar value lies within inclusive bounds
        // - Concatenation: not a single-rune spec; use stringParser for that
        let runeParser (valueSpec: Type) : Parser<WritingSystem.Grapheme.Representation, unit> =
            match valueSpec.intensional.relation with
            | Relation.Singleton ->
                match valueSpec.intensional.characters with
                | [ only ] ->
                    UnicodeScalar.parser
                    >>= fun rune ->
                        if rune = only.extensional then
                            preturn { runicCharacter = rune }
                        else
                            fail $"Expected rune {only.extensional}."
                | _ -> fail "Singleton relation must have exactly one numeral."

            | Relation.Boundary ->
                match valueSpec.intensional.characters with
                | [ first; last ] ->
                    let (lo, hi) = Range.asInclusiveBounds first last

                    UnicodeScalar.parser
                    >>= fun rune ->
                        let scalar = rune.Value

                        if lo <= scalar && scalar <= hi then
                            preturn { runicCharacter = rune }
                        else
                            fail $"Rune scalar {scalar} is outside inclusive range {lo}-{hi}."
                | _ -> fail "Boundary relation must have exactly two numerals (endpoints)."

            | Relation.Concatenation -> fail "Concatenation denotes a sequence; use stringParser, not runeParser."

        // Parser that consumes a STRING from the input stream according to this Value spec.
        // - Singleton: one rune
        // - Concatenation: N runes in order (length = number of numerals in spec)
        // - Boundary: ONE rune in range (string length = 1 Rune)
        let stringParser (valueSpec: Type) : Parser<string, unit> =
            match valueSpec.intensional.relation with
            | Relation.Singleton -> runeParser valueSpec |>> fun r -> r.ToString()

            | Relation.Boundary -> runeParser valueSpec |>> fun r -> r.ToString()

            | Relation.Concatenation ->
                let expected = valueSpec.intensional.characters |> List.map (fun n -> n.extensional)
                // parse exactly that sequence
                let rec parseAll (remaining: Rune list) : Parser<Rune list, unit> =
                    match remaining with
                    | [] -> preturn []
                    | head :: tail ->
                        UnicodeScalar.parser
                        >>= fun got ->
                            if got = head then
                                parseAll tail |>> fun rest -> got :: rest
                            else
                                fail $"Expected rune {head}."

                parseAll expected
                |>> fun runes -> runes |> List.map (fun r -> r.ToString()) |> String.concat ""


        // -------------------------
        // Your Value parser (spec parser)
        // SMALL but important change: do not fail at end-of-input
        // -------------------------
        let parser: Parser<Type, unit> =
            Prefix.parser
            >>= fun basePrefix ->
                Numeral.parser basePrefix
                >>= fun first ->

                    // CHANGE:
                    // lookAhead anyChar FAILS at end-of-input.
                    // We want "no next char" to mean "Singleton".
                    opt (lookAhead anyChar)
                    >>= function
                        | Some '.' -> ConcatenatedString.parser first
                        | Some '-' -> Range.parser first
                        | _ -> Character.parser first

        let inhabitant (on_input: string) : Type =
            match run parser on_input with
            | Success(literal, _, _) -> literal
            | Failure(msg, _, _) -> failwith msg

    let parserFromLiteral (rangeLiteral: string) =
        Value.runeParser (Value.inhabitant rangeLiteral)


    // NEW: compile ONE range literal like "%xA0-D7FF" into (lo, hi)
    let private compileOneRangeLiteral (rangeLiteral: string) : int * int =
        let valueSpec = Value.inhabitant rangeLiteral

        match valueSpec.intensional.relation, valueSpec.intensional.characters with
        | Value.Relation.Boundary, [ first; last ] -> Value.Range.asInclusiveBounds first last
        | Value.Relation.Singleton, [ only ] ->
            let v = only.intensional.integer
            (v, v)
        | _ -> failwith $"Expected a singleton or boundary ABNF terminal value, got: {valueSpec.lexical}"

    // NEW: compile a LIST of range literals into a single predicate (scalar -> bool)
    let private compileRangePredicate (rangeLiterals: string list) : (int -> bool) =
        let bounds: (int * int) list = rangeLiterals |> List.map compileOneRangeLiteral

        fun scalar -> bounds |> List.exists (fun (lo, hi) -> lo <= scalar && scalar <= hi)

    // NEW: build an execution parser: parse ONE rune, accept if in ANY of the listed ranges
    let runeparserFromLiteralList (rangeLiterals: string list) : Parser<WritingSystem.Grapheme.Representation, unit> =

        let isAllowed = compileRangePredicate rangeLiterals

        UnicodeScalar.parser
        >>= fun rune ->
            let scalar = rune.Value

            if isAllowed scalar then
                preturn { runicCharacter = rune }
            else
                fail $"Rune scalar {scalar} is not in the allowed ucschar ranges."

    let inhabitantFromRange (on_input: string) (specifiedRange: string) : WritingSystem.Grapheme.Representation =
        match run (parserFromLiteral specifiedRange) on_input with
        | Success(runicRepresentation, _, _) -> runicRepresentation
        | Failure(msg, _, _) -> failwith msg


let Rule = Rulename.parser .>> defined_as .>>. Terminal.Value.parser
