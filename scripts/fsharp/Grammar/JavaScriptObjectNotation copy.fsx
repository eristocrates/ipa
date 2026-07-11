#if INTERACTIVE

#load "AugmentedBackusNaurForm.fsx" // Load a standard .fs file or another .fsx file
#load "../helpers/CodePoint.fsx" // Load a standard .fs file or another .fsx file
#endif
module JavaScriptObjectNotation =

    open System
    open System.IO
    open System.Text
    open System.Globalization
    open FSharp.Data
    open FParsec
    open FParsec.CharParsers

    open AugmentedBackusNaurForm
    open CodePoint


    type JsonValue =
        | JsonTrueValue of JsonTrue
        | JsonFalseValue of JsonFalse
        | JsonNullValue of JsonNull
        | JsonStringValue of JsonString
        | JsonObjectValue of JsonObject
        | JsonArrayValue of JsonArray
        | JsonNumberValue of JsonNumber

    and JsonTrue = { literal: JsonString; value: bool }
    and JsonFalse = { literal: JsonString; value: bool }

    and JsonNull =
        { literal: JsonString
          value: Nullable<bool> }

    and JsonString = string

    and JsonObjectMember = { key: JsonString; value: JsonValue }
    and JsonObject = JsonObjectMember list

    and JsonArray = JsonArrayElement list
    and JsonArrayElement = JsonValue

    and JsonNumber = { stringLiteral: JsonString }

    type StructuralToken =
        | BeginToken of char
        | EndToken of char
        | SeparatorToken of char


    let json_extension (path: string) =
        JsonString.Equals(Path.GetExtension(path), ".json", StringComparison.OrdinalIgnoreCase)

    let space = abnfTerminal "%x20"
    let horizontalTab = abnfTerminal "%x09"
    let lineFeed = abnfTerminal "%x0A"
    let carriageReturn = abnfTerminal "%x0D"
    let leftSquareBracket = abnfTerminal "%x5B"
    let leftCurlyBracket = abnfTerminal "%x7B"
    let rightSquareBracket = abnfTerminal "%x5D"
    let rightCurlyBracket = abnfTerminal "%x7D"
    let colon = abnfTerminal "%x3A"
    let comma = abnfTerminal "%x2C"

    let nullLexeme = abnfConcatenatedTerminal "%x6e.75.6c.6c"

    let falseLexeme = abnfConcatenatedTerminal "%x66.61.6c.73.65"

    let trueLexeme = abnfConcatenatedTerminal "%x74.72.75.65"

    let reverseSolidus = abnfTerminal "%x5C"
    let escape: Parser<char, unit> = reverseSolidus
    let quotationMark = abnfTerminal "%x22"
    let digit: Parser<char, unit> = AugmentedBackusNaurForm.rangeBmp "%x30-39"

    let hexDigit: Parser<char, unit> =
        digit
        <|> AugmentedBackusNaurForm.rangeBmp "%x41-46"
        <|> AugmentedBackusNaurForm.rangeBmp "%x61-66"

    // Parse exactly 4 hex digits into an int (0..0xFFFF).
    let hex4ToInt: Parser<int, unit> =
        parray 4 hexDigit
        |>> (fun hexChars ->
            let hexString = JsonString(hexChars)
            Int32.Parse(hexString, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture))

    let digit1to9: Parser<char, unit> = AugmentedBackusNaurForm.rangeBmp "%x31-39"

    let minus: Parser<char, unit> = abnfTerminal "%x2D"
    let plus: Parser<char, unit> = abnfTerminal "%x2B"
    let zero: Parser<char, unit> = abnfTerminal "%x30"
    let decimalPoint = abnfTerminal "%x2E"

    let eGlyph: Parser<char, unit> = abnfTerminal "%x65" <|> abnfTerminal "%x45"

    let whitespaceGlyph: Parser<char, unit> =
        space <|> horizontalTab <|> lineFeed <|> carriageReturn

    let whitespace: Parser<unit, unit> = skipMany whitespaceGlyph

    let beginArray: Parser<char, unit> = whitespace >>. leftSquareBracket .>> whitespace

    let beginObject: Parser<char, unit> = whitespace >>. leftCurlyBracket .>> whitespace

    let endArray: Parser<char, unit> = whitespace >>. rightSquareBracket .>> whitespace

    let endObject: Parser<char, unit> = whitespace >>. rightCurlyBracket .>> whitespace

    let nameSeparator: Parser<char, unit> = whitespace >>. colon .>> whitespace

    let valueSeparator: Parser<char, unit> =
        attempt (whitespace >>. comma .>> whitespace)

    let beginCharacter: Parser<char, unit> = beginArray <|> beginObject
    let endCharacter: Parser<char, unit> = endArray <|> endObject
    let separatorCharacter: Parser<char, unit> = nameSeparator <|> valueSeparator


    let jsonTrue: Parser<JsonTrue, unit> =
        trueLexeme |>> (fun trueLiteral -> { literal = trueLiteral; value = true })

    let json_true: Parser<JsonValue, unit> = jsonTrue |>> JsonTrueValue

    let jsonFalse: Parser<JsonFalse, unit> =
        falseLexeme
        |>> (fun falseLiteral ->
            { literal = falseLiteral
              value = false })

    let json_false: Parser<JsonValue, unit> = jsonFalse |>> JsonFalseValue

    let jsonNull: Parser<JsonNull, unit> =
        nullLexeme
        |>> fun nullLiteral ->
            { literal = nullLiteral
              value = Nullable() }

    let json_null: Parser<JsonValue, unit> = jsonNull |>> JsonNullValue

    let json_value, jsonValue = createParserForwardedToRef<JsonValue, unit> ()


    let escapedChar: Parser<char, unit> =
        // Parse the backslash once, then decide based on the next character.
        escape
        >>. choice
                [ // \"  -> U+0022 quotation mark
                  abnfTerminal "%x22" >>% '"'

                  // \\  -> U+005C reverse solidus
                  abnfTerminal "%x5C" >>% '\\'

                  // \/  -> U+002F solidus
                  abnfTerminal "%x2F" >>% '/'

                  // \b  -> backspace
                  abnfTerminal "%x62" >>% '\u0008'

                  // \f  -> form feed
                  abnfTerminal "%x66" >>% '\u000C'

                  // \n  -> line feed
                  abnfTerminal "%x6E" >>% '\u000A'

                  // \r  -> carriage return
                  abnfTerminal "%x72" >>% '\u000D'

                  // \t  -> tab
                  abnfTerminal "%x74" >>% '\u0009'

                  // \uXXXX -> a BMP code point (for now), with your current validation policy
                  abnfTerminal "%x75" >>. parray 4 hexDigit
                  >>= (fun hexChars ->
                      let hexString = JsonString(hexChars)

                      let n =
                          Int32.Parse(hexString, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture)

                      if n < 0 || n > 0xFFFF then
                          fail $"\\u{hexString} is outside BMP (requires surrogate handling)"
                      elif 0xD800 <= n && n <= 0xDFFF then
                          fail $"\\u{hexString} is a surrogate code unit, not a Unicode scalar value"
                      else
                          preturn (char n)) ]

    let escapedCodePoint: Parser<int, unit> =
        escape
        >>. choice
                [ // \" -> U+0022
                  abnfTerminal "%x22" >>% 0x22

                  // \\ -> U+005C
                  abnfTerminal "%x5C" >>% 0x5C

                  // \/ -> U+002F
                  abnfTerminal "%x2F" >>% 0x2F

                  // \b -> U+0008
                  abnfTerminal "%x62" >>% 0x08

                  // \f -> U+000C
                  abnfTerminal "%x66" >>% 0x0C

                  // \n -> U+000A
                  abnfTerminal "%x6E" >>% 0x0A

                  // \r -> U+000D
                  abnfTerminal "%x72" >>% 0x0D

                  // \t -> U+0009
                  abnfTerminal "%x74" >>% 0x09

                  abnfTerminal "%x75" >>. hex4ToInt
                  >>= (fun u1 ->
                      if not (CodePoint.isSurrogateCodeUnit u1) then
                          // Plain BMP scalar
                          preturn u1
                      elif CodePoint.isHighSurrogateCodeUnit u1 then
                          // Must be followed by \uYYYY low surrogate
                          // We parse the second escape literally: backslash + 'u' + 4 hex digits.
                          // This is not optional: P1 requires a well-formed pair.
                          escape >>. abnfTerminal "%x75" >>. hex4ToInt
                          >>= (fun u2 ->
                              if not (CodePoint.isLowSurrogateCodeUnit u2) then
                                  fail $"High surrogate \\u{u1:X4} not followed by low surrogate; got \\u{u2:X4}."
                              else
                                  let compositeCodePoint = CodePoint.yokeSurrogates u1 u2
                                  preturn compositeCodePoint)
                      else
                          // Low surrogate without prior high surrogate
                          fail $"Isolated low surrogate escape \\u{u1:X4} is not allowed.") ]

    let isJsonUnescapedCodePoint (cp: int) =
        (0x20 <= cp && cp <= 0x21)
        || (0x23 <= cp && cp <= 0x5B)
        || (0x5D <= cp && cp <= 0x10FFFF)
    // Parse one unescaped scalar from the underlying UTF-16 stream.
    //
    // P1 rules:
    // - High surrogate must be followed by low surrogate and becomes ONE scalar.
    // - Isolated low surrogate is an error.
    // - Non-surrogate char becomes scalar if it is in RFC 8259 unescaped ranges.
    let unescapedCodePoint: Parser<int, unit> =
        anyChar
        >>= fun c1 ->
            if Char.IsHighSurrogate c1 then
                anyChar
                >>= fun c2 ->
                    if not (Char.IsLowSurrogate c2) then
                        fail $"High surrogate U+{int c1:X4} not followed by low surrogate; got U+{int c2:X4}."
                    else
                        let cp = Char.ConvertToUtf32(c1, c2)

                        if not (isJsonUnescapedCodePoint cp) then
                            fail $"Code point U+{cp:X} is not allowed unescaped in JSON string."
                        else
                            preturn cp

            elif Char.IsLowSurrogate c1 then
                fail $"Isolated low surrogate U+{int c1:X4} is not allowed in JSON string."

            else
                let cp = int c1

                if not (isJsonUnescapedCodePoint cp) then
                    fail $"Code point U+{cp:X} is not allowed unescaped in JSON string."
                else
                    preturn cp

    let codePoint: Parser<int, unit> = attempt unescapedCodePoint <|> escapedCodePoint

    let jsonString: Parser<JsonString, unit> =
        quotationMark >>. many codePoint .>> quotationMark |>> CodePoint.toString


    let json_string: Parser<JsonValue, unit> = jsonString |>> JsonStringValue


    let objectMember: Parser<JsonObjectMember, unit> =
        jsonString .>> nameSeparator .>>. json_value
        |>> (fun (memberLexical, memberValue) ->
            { key = memberLexical
              value = memberValue })

    let objectMembers: Parser<JsonObjectMember list, unit> =
        sepBy objectMember valueSeparator

    let object: Parser<JsonObject, unit> = beginObject >>. objectMembers .>> endObject
    let json_object: Parser<JsonValue, unit> = object |>> JsonObjectValue

    let arrayElement: Parser<JsonArrayElement, unit> = json_value

    let arrayElements: Parser<JsonArrayElement list, unit> =
        sepBy arrayElement valueSeparator

    let jarray: Parser<JsonArray, unit> = beginArray >>. arrayElements .>> endArray
    let json_array: Parser<JsonValue, unit> = jarray |>> JsonArrayValue

    let optional (stringParser: Parser<string, unit>) = stringParser <|> preturn ""
    let negative: Parser<string, unit> = minus |>> string

    let numberSign: Parser<string, unit> = (minus <|> plus) |>> string

    let exponent: Parser<string, unit> =
        eGlyph .>>. optional numberSign .>>. many1Chars digit
        |>> (fun ((eChar, signSuffix), digits) -> string eChar + signSuffix + digits)


    let fraction: Parser<string, unit> =
        decimalPoint .>>. many1Chars digit
        |>> (fun (dotChar, digits) -> string dotChar + digits)


    let integer: Parser<string, unit> =
        let numberZero: Parser<string, unit> = zero |>> string

        let nonZeroInteger: Parser<string, unit> =
            digit1to9 .>>. manyChars digit
            |>> (fun (firstDigit, restDigits) ->
                // firstDigit: char (1-9)
                // restDigits: string of 0..n digits
                string firstDigit + restDigits)

        numberZero <|> nonZeroInteger


    let number: Parser<JsonNumber, unit> =
        pipe4
            (optional negative)
            integer
            (optional fraction)
            (optional exponent)
            (fun signPrefix intPart fracPart expPart -> signPrefix + intPart + fracPart + expPart)
        |>> (fun lex -> { stringLiteral = lex })

    let json_number: Parser<JsonValue, unit> = number |>> JsonNumberValue

    do
        jsonValue
        := choice
            [ json_true
              json_false
              json_null
              json_string
              json_object
              json_array
              json_number ]

    let json_text = whitespace >>. json_value .>> whitespace .>> eof
