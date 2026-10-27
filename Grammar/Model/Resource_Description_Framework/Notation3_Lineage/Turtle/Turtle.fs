module ParserCombinator.Turtle

open System
open System.Web
open System.Text
open System.IO
open System.Globalization


open XParsec
open XParsec.Parsers


open Ergonomics.XParsecErgonomics


open URI


open IRI


open Unicodepoint.Punctuation
open System.Collections.Immutable


type Prefixed_Name_Base_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        (0x0041 <= codepoint && codepoint <= 0x005A)
        || (0x0061 <= codepoint && codepoint <= 0x007A)
        || (0x00C0 <= codepoint && codepoint <= 0x00D6)
        || (0x00D8 <= codepoint && codepoint <= 0x00F6)
        || (0x00F8 <= codepoint && codepoint <= 0x02FF)
        || (0x0370 <= codepoint && codepoint <= 0x037D)
        || (0x037F <= codepoint && codepoint <= 0x1FFF)
        || (0x200C <= codepoint && codepoint <= 0x200D)
        || (0x2070 <= codepoint && codepoint <= 0x218F)
        || (0x2C00 <= codepoint && codepoint <= 0x2FEF)
        || (0x3001 <= codepoint && codepoint <= 0xD7FF)
        || (0xF900 <= codepoint && codepoint <= 0xFDCF)
        || (0xFDF0 <= codepoint && codepoint <= 0xFFFD)
        || (0x10000 <= codepoint && codepoint <= 0xEFFFF)

    static member parse: Parser<Prefixed_Name_Base_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Prefixed_Name_Base_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ PN_CHARS_BASE ::= [A-Z]
                               | [a-z]
                               | [#x00C0-#x00D6]
                               | [#x00D8-#x00F6]
                               | [#x00F8-#x02FF]
                               | [#x0370-#x037D]
                               | [#x037F-#x1FFF]
                               | [#x200C-#x200D]
                               | [#x2070-#x218F]
                               | [#x2C00-#x2FEF]
                               | [#x3001-#xD7FF]
                               | [#xF900-#xFDCF]
                               | [#xFDF0-#xFFFD]
                               | [#x10000-#xEFFFF] """

type Prefixed_Name_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        Prefixed_Name_Base_Character.is_in_range rune
        || codepoint = 0x005F // "_"
        || codepoint = 0x002D // "-"
        || (0x0030 <= codepoint && codepoint <= 0x0039) // 0-9
        || codepoint = 0x00B7
        || (0x0300 <= codepoint && codepoint <= 0x036F)
        || (0x203F <= codepoint && codepoint <= 0x2040)

    static member parse: Parser<Prefixed_Name_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Prefixed_Name_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ PN_CHARS ::= PN_CHARS_BASE
                          | "_"
                          | "-"
                          | [0-9]
                          | #x00B7
                          | [#x0300-#x036F]
                          | [#x203F-#x2040] """

[<RequireQualifiedAccess>]
type Prefixed_Name_Tail_Body_Character =
    | FromPrefixedNameCharacter of Prefixed_Name_Character
    | FromFullStop of Full_Stop
    member this.as_rune =
        match this with
        | FromPrefixedNameCharacter prefixed_name_character -> prefixed_name_character.as_rune
        | FromFullStop full_stop -> full_stop.as_rune

    static member parse: Parser<Prefixed_Name_Tail_Body_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Prefixed_Name_Character.parse
                      |>> FromPrefixedNameCharacter
                      Full_Stop.parse |>> FromFullStop

                       ])
            """ PN_CHARS / '.' """


type Prefixed_Name_Tail =
    { body: ImmutableArray<Prefixed_Name_Tail_Body_Character>
      tip: Prefixed_Name_Character }

    member this.as_characters =
        Seq.concat [ this.body
                     |> Seq.map (fun character -> { as_rune = character.as_rune })
                     seq { this.tip } ]

    static member parse: Parser<Prefixed_Name_Tail, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (manyTill Prefixed_Name_Tail_Body_Character.parse Prefixed_Name_Character.parse
             |>> fun struct (body, tip) -> { body = body; tip = tip })
            """ ( PN_CHARS | '.' )* PN_CHARS """


[<RequireQualifiedAccess>]
type Local_Character_Needing_Escape =
    | FromLowLine of Low_Line
    | FromTilde of Tilde
    | FromFullStop of Full_Stop
    | FromHyphenMinus of Hyphen_Minus
    | FromExclamationMark of Exclamation_Mark
    | FromDollarSign of Dollar_Sign
    | FromAmpersand of Ampersand
    | FromApostrophe of Apostrophe
    | FromLeftParenthesis of Left_Parenthesis
    | FromRightParenthesis of Right_Parenthesis
    | FromAsterisk of Asterisk
    | FromPlusSign of Plus_Sign
    | FromComma of Comma
    | FromSemicolon of Semicolon
    | FromEqualsSign of Equals_Sign
    | FromSolidus of Solidus
    | FromQuestionMark of Question_Mark
    | FromNumberSign of Number_Sign
    | FromCommercialAt of Commercial_At
    | FromPercentSign of Percent_Sign

    member this.as_rune =
        match this with
        | FromLowLine low_line -> low_line.as_rune
        | FromTilde tilde -> tilde.as_rune
        | FromFullStop full_stop -> full_stop.as_rune
        | FromHyphenMinus hyphen_minus -> hyphen_minus.as_rune
        | FromExclamationMark exclamation_mark -> exclamation_mark.as_rune
        | FromDollarSign dollar_sign -> dollar_sign.as_rune
        | FromAmpersand ampersand -> ampersand.as_rune
        | FromApostrophe apostrophe -> apostrophe.as_rune
        | FromLeftParenthesis left_parenthesis -> left_parenthesis.as_rune
        | FromRightParenthesis right_parenthesis -> right_parenthesis.as_rune
        | FromAsterisk asterisk -> asterisk.as_rune
        | FromPlusSign plus_sign -> plus_sign.as_rune
        | FromComma comma -> comma.as_rune
        | FromSemicolon semicolon -> semicolon.as_rune
        | FromEqualsSign equals_sign -> equals_sign.as_rune
        | FromSolidus solidus -> solidus.as_rune
        | FromQuestionMark question_mark -> question_mark.as_rune
        | FromNumberSign number_sign -> number_sign.as_rune
        | FromCommercialAt commercial_at -> commercial_at.as_rune
        | FromPercentSign percent_sign -> percent_sign.as_rune

    static member parse: Parser<Local_Character_Needing_Escape, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Low_Line.parse |>> FromLowLine
                      Tilde.parse |>> FromTilde
                      Full_Stop.parse |>> FromFullStop
                      Hyphen_Minus.parse |>> FromHyphenMinus
                      Exclamation_Mark.parse |>> FromExclamationMark
                      Dollar_Sign.parse |>> FromDollarSign
                      Ampersand.parse |>> FromAmpersand
                      Apostrophe.parse |>> FromApostrophe
                      Left_Parenthesis.parse |>> FromLeftParenthesis
                      Right_Parenthesis.parse |>> FromRightParenthesis
                      Asterisk.parse |>> FromAsterisk
                      Plus_Sign.parse |>> FromPlusSign
                      Comma.parse |>> FromComma
                      Semicolon.parse |>> FromSemicolon
                      Equals_Sign.parse |>> FromEqualsSign
                      Solidus.parse |>> FromSolidus
                      Question_Mark.parse |>> FromQuestionMark
                      Number_Sign.parse |>> FromNumberSign
                      Commercial_At.parse |>> FromCommercialAt
                      Percent_Sign.parse |>> FromPercentSign

                       ])
            """ '_' | '~' | '.' | '-' | '!' | '$' | '&' | "'" | '(' | ')' | '*' | '+' | ',' | ';' | '=' | '/' | '?' | '#' | '@' | '%' """

type Local_Escaped_Character =
    { as_character: Local_Character_Needing_Escape }
    member this.as_rune = this.as_character.as_rune

    static member parse: Parser<Local_Escaped_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Reverse_Solidus.parse
             >>. Local_Character_Needing_Escape.parse
             |>> fun character -> { as_character = character })
            """ PN_LOCAL_ESC      ::= '\' ( '_' | '~' | '.' | '-' | '!' | '$' | '&' | "'" | '(' | ')' | '*' | '+' | ',' | ';' | '=' | '/' | '?' | '#' | '@' | '%' ) """


[<RequireQualifiedAccess>]
type Local_Head_Character =
    | FromPrefixedNameBaseCharacter of Prefixed_Name_Base_Character
    | FromLowLine of Low_Line
    | FromColon of Colon
    | FromDIGIT of ABNF.DIGIT
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromLocalEscapedCharacter of Local_Escaped_Character

    member this.as_rune =
        match this with
        | FromPrefixedNameBaseCharacter prefixed_name_character -> prefixed_name_character.as_rune
        | FromLowLine low_line -> low_line.as_rune
        | FromColon colon -> colon.as_rune
        | FromDIGIT digit -> digit.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromLocalEscapedCharacter local_escaped_character -> local_escaped_character.as_rune

    static member parse: Parser<Local_Head_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Prefixed_Name_Base_Character.parse
                      |>> FromPrefixedNameBaseCharacter
                      Low_Line.parse |>> FromLowLine
                      Colon.parse |>> FromColon
                      ABNF.DIGIT.parse |>> FromDIGIT
                      Percent_Encoded_Character.parse
                      |>> FromPercentEncodedCharacter
                      Local_Escaped_Character.parse
                      |>> FromLocalEscapedCharacter

                       ])
            """
    PN_CHARS_U | ':' | [0-9] | PLX 

    """

[<RequireQualifiedAccess>]
type Local_Tail_Body_Character =
    | FromPrefixedNameCharacter of Prefixed_Name_Character
    | FromFullStop of Full_Stop
    | FromColon of Colon
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromLocalEscapedCharacter of Local_Escaped_Character

    member this.as_rune =
        match this with
        | FromPrefixedNameCharacter prefixed_name_character -> prefixed_name_character.as_rune
        | FromFullStop full_stop -> full_stop.as_rune
        | FromColon colon -> colon.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromLocalEscapedCharacter local_escaped_character -> local_escaped_character.as_rune

    static member parse: Parser<Local_Tail_Body_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Prefixed_Name_Character.parse
                      |>> FromPrefixedNameCharacter
                      Full_Stop.parse |>> FromFullStop
                      Colon.parse |>> FromColon
                      Percent_Encoded_Character.parse
                      |>> FromPercentEncodedCharacter
                      Local_Escaped_Character.parse
                      |>> FromLocalEscapedCharacter

                       ])
            """
     PN_CHARS | '.' | ':' | PLX  

    """

[<RequireQualifiedAccess>]
type Local_Tail_Tip_Character =
    | FromPrefixedNameCharacter of Prefixed_Name_Character
    | FromColon of Colon
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromLocalEscapedCharacter of Local_Escaped_Character

    member this.as_rune =
        match this with
        | FromPrefixedNameCharacter prefixed_name_character -> prefixed_name_character.as_rune
        | FromColon colon -> colon.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromLocalEscapedCharacter local_escaped_character -> local_escaped_character.as_rune

    static member parse: Parser<Local_Tail_Tip_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Prefixed_Name_Character.parse
                      |>> FromPrefixedNameCharacter
                      Colon.parse |>> FromColon
                      Percent_Encoded_Character.parse
                      |>> FromPercentEncodedCharacter
                      Local_Escaped_Character.parse
                      |>> FromLocalEscapedCharacter

                       ])
            """
      PN_CHARS | ':' | PLX   

    """

type Local_Tail =
    { body: ImmutableArray<Local_Tail_Body_Character>
      tip: Local_Tail_Tip_Character }

    member this.as_characters =
        Seq.concat [

                     (this.body
                      |> Seq.map (fun character -> { as_rune = character.as_rune }))
                     seq { { as_rune = this.tip.as_rune } }

                      ]

    static member parse: Parser<Local_Tail, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        let split_tail (characters: ImmutableArray<Local_Tail_Body_Character>) =
            if characters.IsEmpty then
                failwith "Local_Tail requires at least one tail character"
            else
                let last_index = characters.Length - 1
                let last_character = characters.[last_index]

                match last_character with
                | Local_Tail_Body_Character.FromFullStop _ -> failwith "PN_LOCAL tail must not end with '.'"

                | Local_Tail_Body_Character.FromPrefixedNameCharacter prefixed_name_character ->
                    let body =
                        if last_index = 0 then
                            ImmutableArray.Empty
                        else
                            characters.RemoveAt(last_index)

                    { body = body
                      tip = Local_Tail_Tip_Character.FromPrefixedNameCharacter prefixed_name_character }

                | Local_Tail_Body_Character.FromColon colon ->
                    let body =
                        if last_index = 0 then
                            ImmutableArray.Empty
                        else
                            characters.RemoveAt(last_index)

                    { body = body
                      tip = Local_Tail_Tip_Character.FromColon colon }

                | Local_Tail_Body_Character.FromPercentEncodedCharacter percent_encoded_character ->
                    let body =
                        if last_index = 0 then
                            ImmutableArray.Empty
                        else
                            characters.RemoveAt(last_index)

                    { body = body
                      tip = Local_Tail_Tip_Character.FromPercentEncodedCharacter percent_encoded_character }

                | Local_Tail_Body_Character.FromLocalEscapedCharacter local_escaped_character ->
                    let body =
                        if last_index = 0 then
                            ImmutableArray.Empty
                        else
                            characters.RemoveAt(last_index)

                    { body = body
                      tip = Local_Tail_Tip_Character.FromLocalEscapedCharacter local_escaped_character }

        parse_expecting
            (many1 Local_Tail_Body_Character.parse
             |>> split_tail)
            """ ( PN_CHARS | '.' | ':' | PLX )* ( PN_CHARS | ':' | PLX ) """





type Turtle_Local_Name =
    {

      head: Local_Head_Character
      tail: Local_Tail voption

     }

    member this.as_characters =
        let tail_characters =
            match this.tail with
            | ValueSome tail -> tail.as_characters
            | ValueNone -> seq {  }

        Seq.concat [

                     seq { { as_rune = this.head.as_rune } }
                     tail_characters

                      ]

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<Turtle_Local_Name, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Local_Head_Character.parse
             .>>. opt Local_Tail.parse
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """ PN_LOCAL          ::= ( PN_CHARS_U | ':' | [0-9] | PLX ) ( ( PN_CHARS | '.' | ':' | PLX )*  ( PN_CHARS | ':' | PLX ) ) ? """

    static member from_string(local_input: string) =
        result_from_parse Turtle_Local_Name.parse OnInput local_input

type Turtle_Prefix_Name =
    { head: Prefixed_Name_Base_Character
      tail: Prefixed_Name_Tail voption }

    member this.as_characters =
        let tail_characters =
            match this.tail with
            | ValueSome tail -> tail.as_characters
            | ValueNone -> seq {  }

        Seq.concat [ seq { { as_rune = this.head.as_rune } }
                     tail_characters ]

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<Turtle_Prefix_Name, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        let split_tail (characters: ImmutableArray<Prefixed_Name_Tail_Body_Character>) =
            if characters.IsEmpty then
                Ok ValueNone
            else
                let last_index = characters.Length - 1
                let last_character = characters.[last_index]

                match last_character with
                | Prefixed_Name_Tail_Body_Character.FromFullStop _ -> Error "PN_PREFIX must not end with '.'"

                | Prefixed_Name_Tail_Body_Character.FromPrefixedNameCharacter tip ->
                    let body =
                        if last_index = 0 then
                            ImmutableArray.Empty
                        else
                            characters.RemoveAt(last_index)

                    let tail: Prefixed_Name_Tail = { body = body; tip = tip }
                    Ok(ValueSome tail)

        parse_expecting
            (Prefixed_Name_Base_Character.parse
             .>>. many Prefixed_Name_Tail_Body_Character.parse
             |>> fun struct (head, tail_characters) ->
                     match split_tail tail_characters with
                     | Ok tail -> { head = head; tail = tail }
                     | Error message -> failwith message)
            """ PN_PREFIX ::= PN_CHARS_BASE ( ( PN_CHARS | '.' )* PN_CHARS )? """


    static member from_string(input: string) =
        result_from_parse Turtle_Prefix_Name.parse OnInput input
